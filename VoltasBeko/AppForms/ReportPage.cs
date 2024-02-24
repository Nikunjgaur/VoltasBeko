using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoltasBeko.AppForms
{
    public partial class ReportPage : Form
    {
        public ReportPage()
        {
            InitializeComponent();
            LoadFolderNamesToComboBox($"{AppData.ProjectDirectory}/Models", comboBoxModel);

            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public static void LoadFolderNamesToComboBox(string folderPath, ComboBox comboBox)
        {
            try
            {
                // Clear the ComboBox to start with a clean slate
                comboBox.Items.Clear();

                // Check if the folder path exists
                if (Directory.Exists(folderPath))
                {
                    // Get all subdirectories (folder names) in the specified path
                    string[] folderNames = Directory.GetDirectories(folderPath);

                    // Add each folder name to the ComboBox
                    foreach (string folderName in folderNames)
                    {
                        // Get the folder name from the full path
                        string folder = Path.GetFileName(folderName);

                        comboBox.Items.Add(folder);
                    }
                    comboBox.SelectedIndex = 0;
                }
                else
                {
                    // Handle the case where the folder path does not exist
                    MessageBox.Show("Folder does not exist.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void LoadData()
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string modelQuery = "";
                if (checkBoxModelFilter.Checked)
                {
                    modelQuery = $" where modelname = '{comboBoxModel.SelectedItem}'";
                }

                string selectQuery = $@"SELECT _date as ""Date"", _time as ""Time"", modelname as ""Model Name"",ngpartcount as ""NG Part Count"" FROM public.buttonreport {modelQuery}";

                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                labelTotalPlatesCount.Text = dataGridView1.Rows.Count.ToString();
            }


        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSaveReport_Click(object sender, EventArgs e)
        {
            CsvExporter.ExportToCsv(dataGridView1);
            //Database.InsertRandomData(30);
        }
    }
}
