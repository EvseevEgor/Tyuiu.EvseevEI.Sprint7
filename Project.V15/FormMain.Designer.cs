namespace Project.V15
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            iDBindingSource = new BindingSource(components);
            openFileDialog_EEI = new OpenFileDialog();
            saveFileDialog_EEI = new SaveFileDialog();
            toolTipHelp_EEI = new ToolTip(components);
            buttonINF_EEI = new Button();
            buttonSoh_EEI = new Button();
            buttonRes_EEI = new Button();
            buttonHelp_EEI = new Button();
            buttonSort_EEI = new Button();
            iDnumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moneyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDnumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fIODataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            adressDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            moneyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateInDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateOutDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewInput_EEI = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridViewOutput_EEI = new DataGridView();
            groupBoxRes_EEI = new GroupBox();
            textBoxRes_EEI = new TextBox();
            chartRes_EEI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            splitter4 = new Splitter();
            splitter2 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)iDBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_EEI).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_EEI).BeginInit();
            groupBoxRes_EEI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_EEI).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iDBindingSource
            // 
            iDBindingSource.DataSource = typeof(Lib.ID);
            // 
            // openFileDialog_EEI
            // 
            openFileDialog_EEI.FileName = "openFileDialog1";
            // 
            // saveFileDialog_EEI
            // 
            saveFileDialog_EEI.FileOk += saveFileDialog_EEI_FileOk;
            // 
            // toolTipHelp_EEI
            // 
            toolTipHelp_EEI.ToolTipTitle = "Подсказка";
            toolTipHelp_EEI.Popup += toolTipHelp_EEI_Popup;
            // 
            // buttonINF_EEI
            // 
            buttonINF_EEI.Image = (Image)resources.GetObject("buttonINF_EEI.Image");
            buttonINF_EEI.Location = new Point(245, 20);
            buttonINF_EEI.Name = "buttonINF_EEI";
            buttonINF_EEI.Size = new Size(165, 162);
            buttonINF_EEI.TabIndex = 4;
            toolTipHelp_EEI.SetToolTip(buttonINF_EEI, "Информация о разработчике");
            buttonINF_EEI.UseVisualStyleBackColor = true;
            buttonINF_EEI.Click += buttonINF_EEI_Click;
            // 
            // buttonSoh_EEI
            // 
            buttonSoh_EEI.Image = (Image)resources.GetObject("buttonSoh_EEI.Image");
            buttonSoh_EEI.Location = new Point(17, 20);
            buttonSoh_EEI.Name = "buttonSoh_EEI";
            buttonSoh_EEI.Size = new Size(170, 162);
            buttonSoh_EEI.TabIndex = 0;
            toolTipHelp_EEI.SetToolTip(buttonSoh_EEI, "Сохранить новые данные\r\n");
            buttonSoh_EEI.UseVisualStyleBackColor = true;
            buttonSoh_EEI.Click += buttonSoh_EEI_Click;
            // 
            // buttonRes_EEI
            // 
            buttonRes_EEI.BackColor = Color.DarkSalmon;
            buttonRes_EEI.Location = new Point(721, 114);
            buttonRes_EEI.Name = "buttonRes_EEI";
            buttonRes_EEI.Size = new Size(211, 53);
            buttonRes_EEI.TabIndex = 6;
            buttonRes_EEI.Text = "Выполнить";
            toolTipHelp_EEI.SetToolTip(buttonRes_EEI, "Выполнить поиск по данным");
            buttonRes_EEI.UseVisualStyleBackColor = false;
            buttonRes_EEI.Click += buttonRes_EEI_Click;
            buttonRes_EEI.KeyPress += buttonRes_EEI_KeyPress;
            // 
            // buttonHelp_EEI
            // 
            buttonHelp_EEI.Image = (Image)resources.GetObject("buttonHelp_EEI.Image");
            buttonHelp_EEI.Location = new Point(464, 20);
            buttonHelp_EEI.Name = "buttonHelp_EEI";
            buttonHelp_EEI.RightToLeft = RightToLeft.No;
            buttonHelp_EEI.Size = new Size(163, 162);
            buttonHelp_EEI.TabIndex = 5;
            buttonHelp_EEI.TextAlign = ContentAlignment.TopCenter;
            toolTipHelp_EEI.SetToolTip(buttonHelp_EEI, "Помощь по работе приложения");
            buttonHelp_EEI.UseVisualStyleBackColor = true;
            buttonHelp_EEI.Click += buttonHelp_EEI_Click;
            // 
            // buttonSort_EEI
            // 
            buttonSort_EEI.Image = (Image)resources.GetObject("buttonSort_EEI.Image");
            buttonSort_EEI.ImageAlign = ContentAlignment.TopCenter;
            buttonSort_EEI.Location = new Point(690, 20);
            buttonSort_EEI.Name = "buttonSort_EEI";
            buttonSort_EEI.Size = new Size(163, 162);
            buttonSort_EEI.TabIndex = 7;
            toolTipHelp_EEI.SetToolTip(buttonSort_EEI, "Сортировка\r\n");
            buttonSort_EEI.UseVisualStyleBackColor = true;
            buttonSort_EEI.Click += buttonSort_EEI_Click;
            // 
            // iDnumberDataGridViewTextBoxColumn
            // 
            iDnumberDataGridViewTextBoxColumn.DataPropertyName = "IDnumber";
            iDnumberDataGridViewTextBoxColumn.HeaderText = "IDnumber";
            iDnumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            iDnumberDataGridViewTextBoxColumn.Name = "iDnumberDataGridViewTextBoxColumn";
            iDnumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            fIODataGridViewTextBoxColumn.MinimumWidth = 10;
            fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            fIODataGridViewTextBoxColumn.Width = 200;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            adressDataGridViewTextBoxColumn.MinimumWidth = 10;
            adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            adressDataGridViewTextBoxColumn.Width = 200;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            moneyDataGridViewTextBoxColumn.MinimumWidth = 10;
            moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            moneyDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            dateInDataGridViewTextBoxColumn.MinimumWidth = 10;
            dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            dateInDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            dateOutDataGridViewTextBoxColumn.DataPropertyName = "DateOut";
            dateOutDataGridViewTextBoxColumn.HeaderText = "DateOut";
            dateOutDataGridViewTextBoxColumn.MinimumWidth = 10;
            dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            dateOutDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDnumberDataGridViewTextBoxColumn1
            // 
            iDnumberDataGridViewTextBoxColumn1.DataPropertyName = "IDnumber";
            iDnumberDataGridViewTextBoxColumn1.HeaderText = "IDnumber";
            iDnumberDataGridViewTextBoxColumn1.MinimumWidth = 10;
            iDnumberDataGridViewTextBoxColumn1.Name = "iDnumberDataGridViewTextBoxColumn1";
            iDnumberDataGridViewTextBoxColumn1.Width = 200;
            // 
            // fIODataGridViewTextBoxColumn1
            // 
            fIODataGridViewTextBoxColumn1.DataPropertyName = "FIO";
            fIODataGridViewTextBoxColumn1.HeaderText = "FIO";
            fIODataGridViewTextBoxColumn1.MinimumWidth = 10;
            fIODataGridViewTextBoxColumn1.Name = "fIODataGridViewTextBoxColumn1";
            fIODataGridViewTextBoxColumn1.Width = 200;
            // 
            // adressDataGridViewTextBoxColumn1
            // 
            adressDataGridViewTextBoxColumn1.DataPropertyName = "Adress";
            adressDataGridViewTextBoxColumn1.HeaderText = "Adress";
            adressDataGridViewTextBoxColumn1.MinimumWidth = 10;
            adressDataGridViewTextBoxColumn1.Name = "adressDataGridViewTextBoxColumn1";
            adressDataGridViewTextBoxColumn1.Width = 200;
            // 
            // moneyDataGridViewTextBoxColumn1
            // 
            moneyDataGridViewTextBoxColumn1.DataPropertyName = "Money";
            moneyDataGridViewTextBoxColumn1.HeaderText = "Money";
            moneyDataGridViewTextBoxColumn1.MinimumWidth = 10;
            moneyDataGridViewTextBoxColumn1.Name = "moneyDataGridViewTextBoxColumn1";
            moneyDataGridViewTextBoxColumn1.Width = 200;
            // 
            // dateInDataGridViewTextBoxColumn1
            // 
            dateInDataGridViewTextBoxColumn1.DataPropertyName = "DateIn";
            dateInDataGridViewTextBoxColumn1.HeaderText = "DateIn";
            dateInDataGridViewTextBoxColumn1.MinimumWidth = 10;
            dateInDataGridViewTextBoxColumn1.Name = "dateInDataGridViewTextBoxColumn1";
            dateInDataGridViewTextBoxColumn1.Width = 200;
            // 
            // dateOutDataGridViewTextBoxColumn1
            // 
            dateOutDataGridViewTextBoxColumn1.DataPropertyName = "DateOut";
            dateOutDataGridViewTextBoxColumn1.HeaderText = "DateOut";
            dateOutDataGridViewTextBoxColumn1.MinimumWidth = 10;
            dateOutDataGridViewTextBoxColumn1.Name = "dateOutDataGridViewTextBoxColumn1";
            dateOutDataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewInput_EEI
            // 
            dataGridViewInput_EEI.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewInput_EEI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_EEI.Dock = DockStyle.Left;
            dataGridViewInput_EEI.Location = new Point(0, 0);
            dataGridViewInput_EEI.Name = "dataGridViewInput_EEI";
            dataGridViewInput_EEI.RowHeadersVisible = false;
            dataGridViewInput_EEI.RowHeadersWidth = 200;
            dataGridViewInput_EEI.Size = new Size(931, 612);
            dataGridViewInput_EEI.TabIndex = 0;
            dataGridViewInput_EEI.CellContentClick += dataGridViewInput_EEI_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(dataGridViewInput_EEI);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 612);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(dataGridViewOutput_EEI);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(937, 388);
            panel3.Name = "panel3";
            panel3.Size = new Size(915, 612);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // dataGridViewOutput_EEI
            // 
            dataGridViewOutput_EEI.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewOutput_EEI.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewOutput_EEI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_EEI.Dock = DockStyle.Fill;
            dataGridViewOutput_EEI.GridColor = SystemColors.WindowText;
            dataGridViewOutput_EEI.Location = new Point(0, 0);
            dataGridViewOutput_EEI.Name = "dataGridViewOutput_EEI";
            dataGridViewOutput_EEI.RowHeadersVisible = false;
            dataGridViewOutput_EEI.RowHeadersWidth = 82;
            dataGridViewOutput_EEI.Size = new Size(915, 612);
            dataGridViewOutput_EEI.TabIndex = 1;
            dataGridViewOutput_EEI.CellContentClick += dataGridViewOutput_EEI_CellContentClick;
            // 
            // groupBoxRes_EEI
            // 
            groupBoxRes_EEI.Controls.Add(buttonRes_EEI);
            groupBoxRes_EEI.Controls.Add(textBoxRes_EEI);
            groupBoxRes_EEI.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBoxRes_EEI.Location = new Point(17, 216);
            groupBoxRes_EEI.Name = "groupBoxRes_EEI";
            groupBoxRes_EEI.Size = new Size(938, 173);
            groupBoxRes_EEI.TabIndex = 3;
            groupBoxRes_EEI.TabStop = false;
            groupBoxRes_EEI.Text = "Поиск";
            groupBoxRes_EEI.Enter += groupBoxRes_EEI_Enter;
            // 
            // textBoxRes_EEI
            // 
            textBoxRes_EEI.Anchor = AnchorStyles.Left;
            textBoxRes_EEI.BackColor = Color.PaleGoldenrod;
            textBoxRes_EEI.Font = new Font("Palatino Linotype", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_EEI.Location = new Point(0, 63);
            textBoxRes_EEI.Multiline = true;
            textBoxRes_EEI.Name = "textBoxRes_EEI";
            textBoxRes_EEI.PlaceholderText = "Введите id сотрудника";
            textBoxRes_EEI.Size = new Size(602, 104);
            textBoxRes_EEI.TabIndex = 2;
            textBoxRes_EEI.TextChanged += textBoxRes_EEI_TextChanged;
            textBoxRes_EEI.KeyPress += textBoxRes_EEI_KeyPress;
            // 
            // chartRes_EEI
            // 
            chartRes_EEI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chartRes_EEI.BackColor = Color.LightGray;
            chartRes_EEI.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartRes_EEI.BorderlineColor = SystemColors.GradientInactiveCaption;
            chartArea1.Name = "ChartArea1";
            chartRes_EEI.ChartAreas.Add(chartArea1);
            chartRes_EEI.DataSource = iDBindingSource;
            legend1.Name = "Legend1";
            chartRes_EEI.Legends.Add(legend1);
            chartRes_EEI.Location = new Point(955, 0);
            chartRes_EEI.Name = "chartRes_EEI";
            chartRes_EEI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_EEI.Series.Add(series1);
            chartRes_EEI.Size = new Size(902, 382);
            chartRes_EEI.TabIndex = 6;
            chartRes_EEI.Text = "chartGraficRes_EEI";
            chartRes_EEI.Click += chartRes_EEI_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitter4);
            panel1.Controls.Add(chartRes_EEI);
            panel1.Controls.Add(buttonSort_EEI);
            panel1.Controls.Add(buttonHelp_EEI);
            panel1.Controls.Add(groupBoxRes_EEI);
            panel1.Controls.Add(buttonSoh_EEI);
            panel1.Controls.Add(buttonINF_EEI);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1852, 388);
            panel1.TabIndex = 8;
            // 
            // splitter4
            // 
            splitter4.Location = new Point(0, 0);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(6, 388);
            splitter4.TabIndex = 8;
            splitter4.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(937, 388);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(10, 612);
            splitter2.TabIndex = 11;
            splitter2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 1000);
            Controls.Add(splitter2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 7 | Финальный проект | Евсеев Е.И";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)iDBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_EEI).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_EEI).EndInit();
            groupBoxRes_EEI.ResumeLayout(false);
            groupBoxRes_EEI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_EEI).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog_EEI;
        private SaveFileDialog saveFileDialog_EEI;
        private ToolTip toolTipHelp_EEI;
        private BindingSource iDBindingSource;
        private DataGridViewTextBoxColumn iDnumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDnumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn1;
        private DataGridView dataGridViewInput_EEI;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridViewOutput_EEI;
        private Button buttonINF_EEI;
        private Button buttonSoh_EEI;
        private GroupBox groupBoxRes_EEI;
        private Button buttonRes_EEI;
        private TextBox textBoxRes_EEI;
        private Button buttonHelp_EEI;
        private Button buttonSort_EEI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_EEI;
        private Panel panel1;
        private Splitter splitter4;
        private Splitter splitter2;
    }
}
