using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoltasBeko.CustomControl
{
    public partial class PoseControl : UserControl
    {
        public Pose pose = new Pose();
        private bool editMode = false;

        public PoseControl(Pose _pose, int index)
        {
            InitializeComponent();
            if (index % 2 != 0)
            {
                this.BackColor = Color.AntiqueWhite;
            }
            pose = _pose;
            numericUpDownExposure.Value = pose.exposure;
            numericUpDownFocus.Value = pose.focus;
            numericUpDownZoom.Value = pose.zoom;
            textBoxX.Text = pose.location.X.ToString();
            textBoxY.Text = pose.location.Y.ToString();
            buttonDelete.Visible = true;
            buttonEdit.Visible = true;
            foreach (Control control in this.Controls)
            {
                if (control.Name == "buttonEdit" || control.Name == "buttonDelete" || control.Name.Contains("label") || control.Name.Contains("panel"))
                {
                    continue;
                }
                control.Enabled = false;

            }
            textBoxX.Enabled = false;
            textBoxY.Enabled = false;
            AppData.camera.Poses.ListChanged += Poses_ListChanged;
            Poses_ListChanged(null, null);
        }

        private void Poses_ListChanged(object sender, ListChangedEventArgs e)
        {
            for (int i = 0; i < AppData.camera.Poses.Count; i++)
            {

                if (pose.GetHashCode() == AppData.camera.Poses[i].GetHashCode())
                {
                    labelPoseNumber.Text = $"Pose Number: {i + 1}";
                }
            }
        }

        public PoseControl()
        {
            InitializeComponent();
            RefreshCameraValues();
        }

        public void RefreshCameraValues()
        {
            try
            {
                pose.exposure = AppData.camera.Exposure;
                pose.focus = AppData.camera.Focus;
                pose.zoom = AppData.camera.Zoom;
                numericUpDownExposure.Value = pose.exposure;
                numericUpDownFocus.Value = pose.focus;
                numericUpDownZoom.Value = pose.zoom;
                textBoxX.Text = pose.location.X.ToString();
                textBoxY.Text = pose.location.Y.ToString();

            }
            catch (Exception ex)
            {
                ConsoleExtension.WriteWithColor($"{ex.Message}\n{ex.StackTrace}", ConsoleColor.Yellow);
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editMode = !editMode;
            if (editMode)
            {
                buttonEdit.Text = "Save and stop edit";
                foreach (Control control in this.Controls)
                {
                    control.Enabled = true;
                }
                textBoxX.Enabled = true;
                textBoxY.Enabled = true;
            }
            else
            {
                buttonEdit.Text = "Edit Pose";

                foreach (Control control in this.Controls)
                {
                    if (control.Name == "buttonEdit" || control.Name == "buttonDelete" || control.Name.Contains("label") || control.Name.Contains("panel"))
                    {
                        continue;
                    }
                    control.Enabled = false;
                    SaveChanges();

                }
                textBoxX.Enabled = false;
                textBoxY.Enabled = false;
            }
        }

        public void SaveChanges()
        {
            pose.zoom = (int)numericUpDownZoom.Value;
            pose.exposure = (int)numericUpDownExposure.Value;
            pose.focus = (int)numericUpDownFocus.Value;
            pose.location.X = textBoxX.Digit();
            pose.location.Y = textBoxY.Digit();
            AppData.camera.Exposure = pose.exposure;
            AppData.camera.Focus = pose.focus;
            AppData.camera.Zoom = pose.zoom;
            RefreshCameraValues();
        }

        private void PoseControl_Leave(object sender, EventArgs e)
        {
            if (editMode)
            {
                DialogResult dialogResult = MessageBox.Show("Edits not saved do you want to save changes ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveChanges();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AppData.camera.Poses.Count; i++)
            {

                if (pose.GetHashCode() == AppData.camera.Poses[i].GetHashCode())
                {
                    //MessageBox.Show($"Obj same at {i} value 1: {pose.exposure}\n HashCode {pose.GetHashCode()}" +
                    //    $" value 2: {AppData.camera.Poses[i].exposure} \n HashCode {AppData.camera.Poses[i].GetHashCode()}" +
                    //    $"");
                    DialogResult dialogResult = MessageBox.Show("Delete item from list ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        AppData.camera.Poses.RemoveAt(i);
                        this.Dispose();
                    }
                   
                }
            }
        }

        private void PoseControl_Load(object sender, EventArgs e)
        {
            numericUpDownExposure.KeyDown += Control_KeyDown;
            numericUpDownFocus.KeyDown += Control_KeyDown;
            numericUpDownZoom.KeyDown += Control_KeyDown;
            textBoxX.KeyDown += Control_KeyDown;
            textBoxY.KeyDown += Control_KeyDown;

        }

        
        private void Control_ValueChanged(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveChanges();
            }
        }
    }
}
