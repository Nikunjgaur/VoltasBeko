using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoltasBeko.CustomControl;

namespace VoltasBeko.AppForms
{
    public partial class CameraSetup : Form
    {
        public CameraSetup()
        {
            InitializeComponent();
            AppData.camera.Poses.ListChanged += Poses_ListChanged;
            Poses_ListChanged(null, null);
        }

        Pose cameraPose = new Pose();


        private void Poses_ListChanged(object sender, ListChangedEventArgs e)
        {
            poseControl1.labelPoseNumber.Text = $"Pose Number: {AppData.camera.Poses.Count + 1}";
        }


        private void CameraSetup_Load(object sender, EventArgs e)
        {
            poseControl1.RefreshCameraValues();
        }

        private void buttonSavePose_Click(object sender, EventArgs e)
        {
            poseControl1.SaveChanges();
            cameraPose = new Pose(poseControl1.pose);
            AppData.camera.Poses.Add(new Pose(cameraPose));
            PoseControl poseControl = new PoseControl(AppData.camera.Poses.Last(), AppData.camera.Poses.Count);
            flowLayoutPanelPose.Controls.Add(poseControl);
        }
        
        private void poseControl1_Load(object sender, EventArgs e)
        {
            AppData.camera.OpenCamera();
            AppData.camera.ImageRecieved += Camera_ImageRecieved;
        }

        private void Camera_ImageRecieved(object sender, Bitmap e)
        {
            zoomInOutPictureBox1.PictureBox1.Image = e.DeepClone();
        }

        private async void buttonAutoFocus_Click(object sender, EventArgs e)
        {
            AppData.camera.AutoFocus();
            Application.UseWaitCursor = true;
            await Task.Delay(TimeSpan.FromSeconds(6));
            cameraPose.focus = AppData.camera.Focus;
            ConsoleExtension.WriteWithColor(AppData.camera.Focus, ConsoleColor.Blue);
            poseControl1.numericUpDownFocus.Value = cameraPose.focus;
            Application.UseWaitCursor = false;
            Cursor.Current = Cursors.Default;

        }

        private void buttonSaveSetup_Click(object sender, EventArgs e)
        {

        }
    }
}
