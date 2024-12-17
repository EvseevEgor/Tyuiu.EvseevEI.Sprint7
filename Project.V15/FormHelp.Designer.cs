namespace Project.V15
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            textBox1 = new TextBox();
            buttonClose_EEI = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1270, 757);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonClose_EEI
            // 
            buttonClose_EEI.BackColor = SystemColors.Menu;
            buttonClose_EEI.Location = new Point(962, 643);
            buttonClose_EEI.Name = "buttonClose_EEI";
            buttonClose_EEI.Size = new Size(285, 58);
            buttonClose_EEI.TabIndex = 1;
            buttonClose_EEI.Text = "закрыть";
            buttonClose_EEI.UseVisualStyleBackColor = false;
            buttonClose_EEI.Click += buttonClose_EEI_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 769);
            Controls.Add(buttonClose_EEI);
            Controls.Add(textBox1);
            Name = "FormHelp";
            Text = "Помощь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonClose_EEI;
    }
}