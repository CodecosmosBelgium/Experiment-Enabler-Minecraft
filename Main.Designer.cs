namespace Experimenter
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            worldPreviewPictureBox = new PictureBox();
            worldNameLabel = new Label();
            openWorldButton = new Button();
            isUWPCheckbox = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            logoPictureBox = new PictureBox();
            copyrightPictureBox = new PictureBox();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)worldPreviewPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)copyrightPictureBox).BeginInit();
            SuspendLayout();
            // 
            // worldPreviewPictureBox
            // 
            worldPreviewPictureBox.BorderStyle = BorderStyle.FixedSingle;
            worldPreviewPictureBox.Location = new Point(12, 12);
            worldPreviewPictureBox.Name = "worldPreviewPictureBox";
            worldPreviewPictureBox.Size = new Size(350, 197);
            worldPreviewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            worldPreviewPictureBox.TabIndex = 0;
            worldPreviewPictureBox.TabStop = false;
            // 
            // worldNameLabel
            // 
            worldNameLabel.AutoSize = true;
            worldNameLabel.Font = new Font("Segoe UI", 20F);
            worldNameLabel.Location = new Point(12, 225);
            worldNameLabel.Name = "worldNameLabel";
            worldNameLabel.Size = new Size(200, 46);
            worldNameLabel.TabIndex = 1;
            worldNameLabel.Text = "WorldName";
            // 
            // openWorldButton
            // 
            openWorldButton.Font = new Font("Arial", 20F);
            openWorldButton.Image = Properties.Resources.Open_World_Button;
            openWorldButton.Location = new Point(12, 350);
            openWorldButton.Name = "openWorldButton";
            openWorldButton.Size = new Size(228, 191);
            openWorldButton.TabIndex = 2;
            openWorldButton.UseVisualStyleBackColor = true;
            openWorldButton.Click += OpenWorldButton_Click;
            // 
            // isUWPCheckbox
            // 
            isUWPCheckbox.AutoSize = true;
            isUWPCheckbox.Location = new Point(12, 285);
            isUWPCheckbox.Name = "isUWPCheckbox";
            isUWPCheckbox.Size = new Size(139, 24);
            isUWPCheckbox.TabIndex = 3;
            isUWPCheckbox.Text = "Is Store Version?";
            isUWPCheckbox.UseVisualStyleBackColor = true;
            isUWPCheckbox.CheckedChanged += IsUWPCheckbox_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(368, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(355, 529);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.WrapContents = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = Properties.Resources.Enlgish_or_smanish;
            logoPictureBox.Location = new Point(729, 12);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(41, 529);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 9;
            logoPictureBox.TabStop = false;
            // 
            // copyrightPictureBox
            // 
            copyrightPictureBox.Image = Properties.Resources.Copyright;
            copyrightPictureBox.Location = new Point(12, 315);
            copyrightPictureBox.Name = "copyrightPictureBox";
            copyrightPictureBox.Size = new Size(228, 29);
            copyrightPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            copyrightPictureBox.TabIndex = 10;
            copyrightPictureBox.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.BackgroundImage = Properties.Resources.SaveIcon;
            saveButton.BackgroundImageLayout = ImageLayout.Zoom;
            saveButton.Enabled = false;
            saveButton.FlatAppearance.BorderColor = Color.IndianRed;
            saveButton.FlatAppearance.BorderSize = 2;
            saveButton.Location = new Point(239, 414);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(123, 127);
            saveButton.TabIndex = 11;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(saveButton);
            Controls.Add(copyrightPictureBox);
            Controls.Add(logoPictureBox);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(isUWPCheckbox);
            Controls.Add(openWorldButton);
            Controls.Add(worldNameLabel);
            Controls.Add(worldPreviewPictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            Text = "Experiment Enabler";
            TransparencyKey = Color.Magenta;
            ((System.ComponentModel.ISupportInitialize)worldPreviewPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)copyrightPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox worldPreviewPictureBox;
        private Label worldNameLabel;
        private Button openWorldButton;
        private CheckBox isUWPCheckbox;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox logoPictureBox;
        private PictureBox copyrightPictureBox;
        private Button saveButton;
    }
}
