using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Project.V15.Lib;
namespace Project.V15
{
    public partial class FormMain : Form
    {
        DataService ds = new();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            List<ID> ID = ds.GetID();

            dataGridViewInput_EEI.AutoGenerateColumns = true;
            dataGridViewInput_EEI.DataSource = ID;


            chartRes_EEI.Series.Clear();
            foreach (var id in ID)
            {
                var IDnumber = chartRes_EEI.Series.Add(Convert.ToString(id.IDNumber));
                IDnumber.Points.AddXY(id.IDNumber, id.salary);

            }
            chartRes_EEI.ChartAreas[0].AxisX.Title = "Номер id";
            chartRes_EEI.ChartAreas[0].AxisY.Title = "Оклад";

        }

        private void buttonHelp_EEI_Click(object sender, EventArgs e)
        {
            FormHelp help = new FormHelp();
            help.ShowDialog();
        }

        private void buttonINF_EEI_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void buttonSoh_EEI_Click(object sender, EventArgs e)
        {


            saveFileDialog_EEI.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog_EEI.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog_EEI.FileName;

                StringBuilder csvContent = new StringBuilder();

                for (int i = 0; i < dataGridViewOutput_EEI.Columns.Count; i++)
                {
                    csvContent.Append(dataGridViewOutput_EEI.Columns[i].HeaderText);
                    if (i < dataGridViewOutput_EEI.Columns.Count - 1)
                        csvContent.Append(",");
                }
                csvContent.AppendLine();

                foreach (DataGridViewRow row in dataGridViewOutput_EEI.Rows)
                {
                    for (int i = 0; i < dataGridViewOutput_EEI.Columns.Count; i++)
                    {
                        csvContent.Append(row.Cells[i].Value?.ToString());
                        if (i < dataGridViewOutput_EEI.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }
                File.WriteAllText(filename, csvContent.ToString());
                MessageBox.Show("Файл сохранен");
            }

        }
        private void textBoxRes_EEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRes_EEI_Click(object sender, EventArgs e)
        {
            List<ID> IDS = ds.SearchID(textBoxRes_EEI.Text);
            dataGridViewOutput_EEI.AutoGenerateColumns = true;
            dataGridViewOutput_EEI.DataSource = IDS;


            chartRes_EEI.Series.Clear();


            foreach (var id in IDS)
            {
                var IDSnumber = chartRes_EEI.Series.Add(Convert.ToString(id.IDNumber));
                IDSnumber.Points.AddXY(id.IDNumber, id.salary);

            }

            chartRes_EEI.ChartAreas[0].AxisX.Title = "Номер id";
            chartRes_EEI.ChartAreas[0].AxisY.Title = "Оклад";
        }

        private void chartRes_EEI_Click(object sender, EventArgs e)
        {

        }


        private void dataGridViewInput_EEI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

                dataGridViewInput_EEI.Columns[e.ColumnIndex].Width = 500;
            }

        }

        private void groupBoxRes_EEI_Enter(object sender, EventArgs e)
        { 

        }

        private void saveFileDialog_EEI_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolTipHelp_EEI_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonRes_EEI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxRes_EEI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonSort_EEI_Click(object sender, EventArgs e)
        {
            List<ID> IDS = ds.SortID();
            dataGridViewOutput_EEI.AutoGenerateColumns = true;
            dataGridViewOutput_EEI.DataSource = IDS;


            chartRes_EEI.Series.Clear();


            foreach (var id in IDS)
            {
                var IDSnumber = chartRes_EEI.Series.Add(Convert.ToString(id.IDNumber));
                IDSnumber.Points.AddXY(id.IDNumber, id.salary);

            }

            chartRes_EEI.ChartAreas[0].AxisX.Title = "Номер id";
            chartRes_EEI.ChartAreas[0].AxisY.Title = "Оклад";
        }

        private void chartRes_EEI_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewOutput_EEI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

                dataGridViewOutput_EEI.Columns[e.ColumnIndex].Width = 500;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

