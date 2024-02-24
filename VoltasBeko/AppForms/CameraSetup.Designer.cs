namespace VoltasBeko.AppForms
{
    partial class CameraSetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPose = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSavePose = new System.Windows.Forms.Button();
            this.buttonAutoFocus = new System.Windows.Forms.Button();
            this.buttonSaveSetup = new System.Windows.Forms.Button();
            this.poseControl1 = new VoltasBeko.CustomControl.PoseControl();
            this.zoomInOutPictureBox1 = new VoltasBeko.CustomControl.ZoomInOutPictureBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1408, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "CAMERA SETUP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelPose
            // 
            this.flowLayoutPanelPose.AllowDrop = true;
            this.flowLayoutPanelPose.AutoScroll = true;
            this.flowLayoutPanelPose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            this.flowLayoutPanelPose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelPose.Location = new System.Drawing.Point(759, 67);
            this.flowLayoutPanelPose.Name = "flowLayoutPanelPose";
            this.flowLayoutPanelPose.Size = new System.Drawing.Size(619, 789);
            this.flowLayoutPanelPose.TabIndex = 9;
            // 
            // buttonSavePose
            // 
            this.buttonSavePose.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSavePose.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePose.Location = new System.Drawing.Point(526, 759);
            this.buttonSavePose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSavePose.Name = "buttonSavePose";
            this.buttonSavePose.Size = new System.Drawing.Size(144, 37);
            this.buttonSavePose.TabIndex = 37;
            this.buttonSavePose.Text = "Save Pose";
            this.buttonSavePose.UseVisualStyleBackColor = false;
            this.buttonSavePose.Click += new System.EventHandler(this.buttonSavePose_Click);
            // 
            // buttonAutoFocus
            // 
            this.buttonAutoFocus.BackColor = System.Drawing.Color.Yellow;
            this.buttonAutoFocus.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutoFocus.Location = new System.Drawing.Point(374, 759);
            this.buttonAutoFocus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAutoFocus.Name = "buttonAutoFocus";
            this.buttonAutoFocus.Size = new System.Drawing.Size(144, 37);
            this.buttonAutoFocus.TabIndex = 37;
            this.buttonAutoFocus.Text = "Auto Focus";
            this.buttonAutoFocus.UseVisualStyleBackColor = false;
            this.buttonAutoFocus.Click += new System.EventHandler(this.buttonAutoFocus_Click);
            // 
            // buttonSaveSetup
            // 
            this.buttonSaveSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSaveSetup.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSetup.Location = new System.Drawing.Point(410, 832);
            this.buttonSaveSetup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveSetup.Name = "buttonSaveSetup";
            this.buttonSaveSetup.Size = new System.Drawing.Size(277, 37);
            this.buttonSaveSetup.TabIndex = 37;
            this.buttonSaveSetup.Text = "Complete Setup";
            this.buttonSaveSetup.UseVisualStyleBackColor = false;
            this.buttonSaveSetup.Click += new System.EventHandler(this.buttonSaveSetup_Click);
            // 
            // poseControl1
            // 
            this.poseControl1.BackColor = System.Drawing.Color.White;
            this.poseControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poseControl1.Location = new System.Drawing.Point(75, 609);
            this.poseControl1.Name = "poseControl1";
            this.poseControl1.Size = new System.Drawing.Size(612, 206);
            this.poseControl1.TabIndex = 10;
            this.poseControl1.Load += new System.EventHandler(this.poseControl1_Load);
            // 
            // zoomInOutPictureBox1
            // 
            this.zoomInOutPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomInOutPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.zoomInOutPictureBox1.Location = new System.Drawing.Point(25, 67);
            this.zoomInOutPictureBox1.Name = "zoomInOutPictureBox1";
            this.zoomInOutPictureBox1.PictureBoxImage = null;
            this.zoomInOutPictureBox1.PictureBoxSize = new System.Drawing.Size(712, 508);
            this.zoomInOutPictureBox1.Size = new System.Drawing.Size(712, 508);
            this.zoomInOutPictureBox1.TabIndex = 7;
            // 
            // CameraSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1408, 924);
            this.Controls.Add(this.buttonSaveSetup);
            this.Controls.Add(this.buttonAutoFocus);
            this.Controls.Add(this.buttonSavePose);
            this.Controls.Add(this.poseControl1);
            this.Controls.Add(this.flowLayoutPanelPose);
            this.Controls.Add(this.zoomInOutPictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CameraSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraSetup";
            this.Load += new System.EventHandler(this.CameraSetup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControl.ZoomInOutPictureBox zoomInOutPictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPose;
        private CustomControl.PoseControl poseControl1;
        private System.Windows.Forms.Button buttonSavePose;
        private System.Windows.Forms.Button buttonAutoFocus;
        private System.Windows.Forms.Button buttonSaveSetup;
    }
}