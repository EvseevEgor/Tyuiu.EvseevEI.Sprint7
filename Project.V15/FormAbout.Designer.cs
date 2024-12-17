namespace Project.V15
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_EEI = new PictureBox();
            buttonClose_EEI = new Button();
            labelINF_EEI = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_EEI).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_EEI
            // 
            pictureBox_EEI.Image = (Image)resources.GetObject("pictureBox_EEI.Image");
            pictureBox_EEI.Location = new Point(-123, -217);
            pictureBox_EEI.Name = "pictureBox_EEI";
            pictureBox_EEI.Size = new Size(501, 702);
            pictureBox_EEI.TabIndex = 0;
            pictureBox_EEI.TabStop = false;
            pictureBox_EEI.Click += pictureBox_EEI_Click;
            // 
            // buttonClose_EEI
            // 
            buttonClose_EEI.BackColor = SystemColors.ActiveCaption;
            buttonClose_EEI.ForeColor = SystemColors.InactiveCaptionText;
            buttonClose_EEI.Location = new Point(597, 467);
            buttonClose_EEI.Name = "buttonClose_EEI";
            buttonClose_EEI.Size = new Size(321, 64);
            buttonClose_EEI.TabIndex = 1;
            buttonClose_EEI.Text = "Закрыть";
            buttonClose_EEI.UseVisualStyleBackColor = false;
            buttonClose_EEI.Click += buttonClose_EEI_Click;
            // 
            // labelINF_EEI
            // 
            labelINF_EEI.Location = new Point(384, 9);
            labelINF_EEI.Name = "labelINF_EEI";
            labelINF_EEI.Size = new Size(549, 424);
            labelINF_EEI.TabIndex = 2;
            labelINF_EEI.Text = "Разработчик: Евсеев Егор Игоревич\r\nГруппа: ИИПБ-24-2\r\n\r\nТюменские Индустриальный Университет (с) 2024\r\nВысшая школа цифровых технологий (с) 2024\r\n\r\nВнутреннее имя: Project.EvseevEI.V15\r\n";
            labelINF_EEI.Click += labelINF_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 560);
            Controls.Add(labelINF_EEI);
            Controls.Add(buttonClose_EEI);
            Controls.Add(pictureBox_EEI);
            Name = "FormAbout";
            Text = "Разработчик";
            ((System.ComponentModel.ISupportInitialize)pictureBox_EEI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_EEI;
        private Button buttonClose_EEI;
        private Label labelINF_EEI;
    }
}