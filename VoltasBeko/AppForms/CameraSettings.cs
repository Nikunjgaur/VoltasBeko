using Newtonsoft.Json;
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

namespace VoltasBeko
{
    public partial class CameraSettings : Form
    {
        int camNumber = 1;
        bool changesMade = false;
        private string path = $@"{AppData.ProjectDirectory}/Settings/";


        public CameraSettings()
        {
            InitializeComponent();

        }

        private void CameraSettings_Load(object sender, EventArgs e)
        {
            var tb = GetAll(this, typeof(TextBox));

            foreach (TextBox textBox in tb)
            {
                textBox.KeyDown += TextBox_KeyDown;
                textBox.Leave += TextBox_Leave;
                textBox.TextChanged += TextBox_TextChanged;
            }

            var trackBars = GetAll(this, typeof(TrackBar));


            textBoxExposure.KeyDown += TextBoxLineRateCam1_KeyDown;

        }

        private void TextBoxLineRateCam1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            changesMade = true;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if ((textBox.Text != "" && float.TryParse(textBox.Text, out float n)) == false)
            {
                textBox.Text = "0";
                MessageBox.Show("Enter valid input value.");
            }
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            var tb = GetAll(this, typeof(TextBox));

            TrackBar trackBar = (TrackBar)sender;

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //var trackBars = GetAll(this, typeof(TrackBar));
            //TextBox textBox = (TextBox)sender;

            //if (e.KeyCode == Keys.Enter && textBox.Text != "" && float.TryParse(textBox.Text, out float n) == true)
            //{
            //    for (int i = 0; i < CameraParameters.List.Count; i++)
            //    {
            //        if (textBox.Name.Remove(0, 7) == CameraParameters.List[i].nodeName)
            //        {

            //            CameraParameters.List[i].nodeVal = float.Parse(textBox.Text);
            //            textBox.Text = CameraParameters.List[i].nodeVal.ToString();

            //            foreach (TrackBar trackBar in trackBars)
            //            {
            //                if (trackBar.Name.Remove(0, 8) == textBox.Name.Remove(0, 7))
            //                {
            //                    trackBar.Value = Convert.ToInt32(textBox.Text);
            //                }
            //            }
            //        }
            //    }
            //}
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save Changes ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string camSettings = JsonConvert.SerializeObject("passCameraObj");
                File.WriteAllText($"{path}/Camera{camNumber}.json", camSettings);
                changesMade = false;
                MessageBox.Show("Camera settings Updated", "Settings Saved");
            }
        }

        private void CameraSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changesMade == true)
            {
                DialogResult result = MessageBox.Show("Close wihtout saving ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    //CommonParameters.InspectionPage.cameraSettings = null;
                }
            }
            else
            {
                //CommonParameters.InspectionPage.cameraSettings = null;

            }

        }


        private void trackBarExposure_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBarLineRateCam2_Scroll(object sender, EventArgs e)
        {


        }

        public void ResetSettings()
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {

        }

        private void trackBarExposure_ValueChanged(object sender, EventArgs e)
        {
            int trackValue = trackBarExposure.Value;
            textBoxExposure.Text = trackValue.ToString();


        }

        private void trackBarGain_ValueChanged(object sender, EventArgs e)
        {
            int trackValue = trackBarGain.Value;
            textBoxGain.Text = trackValue.ToString();

        }
    }
}
