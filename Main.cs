using Experimenter.Properties;
using fNbt;
using System.Diagnostics;

namespace Experimenter
{
    public partial class Main : Form
    {
        private readonly fNbt.NbtFile file = new();
        bool fileLoadedSuccessfully = false;
        private readonly bool isUWP = false;

        private string path = "";

        private readonly string[] possibleExperiments = [
            "gametest",
            "cameras",
            "upcoming_creator_features"
        ];

        private readonly List<NbtByte> currentExperiments = [];
        public Main()
        {
            InitializeComponent();
            isUWP = Config.Default.isUWP;
            isUWPCheckbox.Checked = isUWP;
        }

        private void Save() {
            if (!fileLoadedSuccessfully || path == "")
            {
                MessageBox.Show("No file loaded");
                return;
            }

            byte[] modifiedData = file.SaveToBuffer(NbtCompression.None);
            byte[] finalData = new byte[modifiedData.Length + 8];
            Array.Copy(modifiedData, 0, finalData, 8, modifiedData.Length);

            File.WriteAllBytes(path, finalData);
            MessageBox.Show("Saved");

            this.Unload();
        }

        private void Unload() {
            path = "";
            worldNameLabel.Text = "WorldName";
            worldPreviewPictureBox.Image = null;
            flowLayoutPanel1.Controls.Clear();
            currentExperiments.Clear();
            saveButton.Enabled = false;
            fileLoadedSuccessfully = false;
        }

        private void OpenWorldButton_Click(object sender, EventArgs e)
        {
            if (fileLoadedSuccessfully)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save the current file?", "Save?", MessageBoxButtons.YesNo);
                
                if(dialogResult == DialogResult.Yes)
                {
                   Save();
                }
                else
                {
                   Unload();
                }
            }


            OpenFileDialog openFileDialog = new()
            {
                Title = "Select a level.dat file",
                Filter = "level.dat files|level.dat",
                InitialDirectory = WorldUtils.GetWorldsFolder(isUWP)
            };

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                string worldName = WorldUtils.GetWorldName(path);
                worldNameLabel.Text = worldName;

                worldPreviewPictureBox.Image = WorldUtils.GetWorldIcon(path);

                //Check if the file exists
                if (!File.Exists(path))
                {
                    MessageBox.Show("File does not exist");
                    return;
                }

                try
                {
                    file.BigEndian = false;
                    byte[] data = File.ReadAllBytes(path);
                    file.LoadFromBuffer(data, 8, data.Length - 8, NbtCompression.None);


                    //Debug.WriteLine("filename: " + file.FileName.ToString());
                    //Debug.WriteLine("Compression type: " + file.FileCompression.ToString());



                    fileLoadedSuccessfully = true;

                    NbtCompound root = file.RootTag;
                    var experiments = root.Get<NbtCompound>("experiments");
                    Debug.WriteLine("Experiments: " + experiments.ToString());

                    foreach (NbtByte tag in experiments.Tags.Cast<NbtByte>())
                    { 
                        currentExperiments.Add(tag);
                    }

                    //Check if the possible expreiments have more than the current, if so add the mising ones
                    foreach (string experiment in possibleExperiments)
                    {
                        if(currentExperiments.Find(x => x.Name == experiment) == null)
                        {
                            currentExperiments.Add(new NbtByte(experiment, 0));
                        }
                    }

                    //sort the experiments
                    currentExperiments.Sort((x, y) => x.Name.CompareTo(y.Name));

                    foreach (NbtByte tag in currentExperiments)
                    {

                        CheckBox cb = new()
                        {
                            Text = tag.Name,
                            Checked = tag.Value != 0,
                            AutoSize = true
                        };
                        cb.CheckedChanged += (s, ev) =>
                        {
                            ToggleFunction(tag.Name, cb.Checked);
                        };

                        flowLayoutPanel1.Controls.Add(cb);
                    }

                    saveButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                    fileLoadedSuccessfully = false;
                }

            }

        }

        private void ToggleFunction(string name, bool state)
        {
            if (!fileLoadedSuccessfully)
            {
                MessageBox.Show("No file loaded");
                return;
            }

            NbtCompound root = file.RootTag;
            var experiments = root.Get<NbtCompound>("experiments");
            var tag = experiments.Get<NbtByte>(name);
            if(tag == null)
            {
                tag = new NbtByte(name, state ? (byte)1 : (byte)0);
                experiments.Add(tag);
            }else
            {
                tag.Value = state ? (byte)1 : (byte)0;
            }
            Debug.WriteLine(file.RootTag.Get<NbtCompound>("experiments").ToString());
        }

        private void IsUWPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool state = isUWPCheckbox.Checked;
            Config.Default.isUWP = state;
            Config.Default.Save();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Save();
        }
    }
}
