namespace VoltasBeko
{
    partial class CameraSettings
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
            this.trackBarExposure = new System.Windows.Forms.TrackBar();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarGain = new System.Windows.Forms.TrackBar();
            this.textBoxExposure = new System.Windows.Forms.TextBox();
            this.textBoxGain = new System.Windows.Forms.TextBox();
            this.camIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExposure)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarExposure
            // 
            this.trackBarExposure.Location = new System.Drawing.Point(217, 48);
            this.trackBarExposure.Maximum = 100;
            this.trackBarExposure.Minimum = 5;
            this.trackBarExposure.Name = "trackBarExposure";
            this.trackBarExposure.Size = new System.Drawing.Size(209, 45);
            this.trackBarExposure.TabIndex = 37;
            this.trackBarExposure.Value = 100;
            this.trackBarExposure.Scroll += new System.EventHandler(this.trackBarExposure_Scroll);
            this.trackBarExposure.ValueChanged += new System.EventHandler(this.trackBarExposure_ValueChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Black;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(144, 196);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(120, 45);
            this.buttonReset.TabIndex = 35;
            this.buttonReset.Text = "Reset to Default";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Black;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(294, 196);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 45);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.trackBarExposure);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarGain);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.textBoxExposure);
            this.panel1.Controls.Add(this.textBoxGain);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Location = new System.Drawing.Point(44, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 301);
            this.panel1.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Gain:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Exposure:";
            // 
            // trackBarGain
            // 
            this.trackBarGain.Location = new System.Drawing.Point(217, 112);
            this.trackBarGain.Maximum = 2047;
            this.trackBarGain.Minimum = 256;
            this.trackBarGain.Name = "trackBarGain";
            this.trackBarGain.Size = new System.Drawing.Size(208, 45);
            this.trackBarGain.TabIndex = 58;
            this.trackBarGain.Value = 256;
            this.trackBarGain.ValueChanged += new System.EventHandler(this.trackBarGain_ValueChanged);
            // 
            // textBoxExposure
            // 
            this.textBoxExposure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExposure.Location = new System.Drawing.Point(448, 48);
            this.textBoxExposure.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxExposure.MaxLength = 4;
            this.textBoxExposure.Name = "textBoxExposure";
            this.textBoxExposure.Size = new System.Drawing.Size(84, 38);
            this.textBoxExposure.TabIndex = 34;
            this.textBoxExposure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGain
            // 
            this.textBoxGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGain.Location = new System.Drawing.Point(448, 112);
            this.textBoxGain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxGain.MaxLength = 4;
            this.textBoxGain.Name = "textBoxGain";
            this.textBoxGain.Size = new System.Drawing.Size(84, 38);
            this.textBoxGain.TabIndex = 34;
            this.textBoxGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // camIcon
            // 
            this.camIcon.BackColor = System.Drawing.Color.Transparent;
            this.camIcon.Image = global::VoltasBeko.Properties.Resources.camGreen;
            this.camIcon.Location = new System.Drawing.Point(272, 8);
            this.camIcon.Name = "camIcon";
            this.camIcon.Size = new System.Drawing.Size(104, 102);
            this.camIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.camIcon.TabIndex = 44;
            this.camIcon.TabStop = false;
            // 
            // CameraSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 463);
            this.Controls.Add(this.camIcon);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.Name = "CameraSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Parameter Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraSettings_FormClosing);
            this.Load += new System.EventHandler(this.CameraSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExposure)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarExposure;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox camIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarGain;
        private System.Windows.Forms.TextBox textBoxExposure;
        private System.Windows.Forms.TextBox textBoxGain;
    }
}