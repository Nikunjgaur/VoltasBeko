namespace VoltasBeko.CustomControl
{
    partial class PoseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelFocus = new System.Windows.Forms.Label();
            this.labelZoom = new System.Windows.Forms.Label();
            this.labelExposure = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.numericUpDownFocus = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExposure = new System.Windows.Forms.NumericUpDown();
            this.labelPoseNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExposure)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(489, 143);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 37);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "Delete Pose";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEdit.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(337, 143);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(144, 37);
            this.buttonEdit.TabIndex = 36;
            this.buttonEdit.Text = "Edit Pose";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelFocus
            // 
            this.labelFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(134)))), ((int)(((byte)(212)))));
            this.labelFocus.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFocus.ForeColor = System.Drawing.Color.White;
            this.labelFocus.Location = new System.Drawing.Point(7, 97);
            this.labelFocus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFocus.Name = "labelFocus";
            this.labelFocus.Size = new System.Drawing.Size(74, 30);
            this.labelFocus.TabIndex = 25;
            this.labelFocus.Text = "Focus";
            this.labelFocus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelZoom
            // 
            this.labelZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(134)))), ((int)(((byte)(212)))));
            this.labelZoom.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoom.ForeColor = System.Drawing.Color.White;
            this.labelZoom.Location = new System.Drawing.Point(7, 35);
            this.labelZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoom.MaximumSize = new System.Drawing.Size(148, 37);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(74, 30);
            this.labelZoom.TabIndex = 21;
            this.labelZoom.Text = "Zoom";
            this.labelZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExposure
            // 
            this.labelExposure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(134)))), ((int)(((byte)(212)))));
            this.labelExposure.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExposure.ForeColor = System.Drawing.Color.White;
            this.labelExposure.Location = new System.Drawing.Point(253, 88);
            this.labelExposure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExposure.Name = "labelExposure";
            this.labelExposure.Size = new System.Drawing.Size(74, 30);
            this.labelExposure.TabIndex = 25;
            this.labelExposure.Text = "Exposure";
            this.labelExposure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPosition
            // 
            this.labelPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(134)))), ((int)(((byte)(212)))));
            this.labelPosition.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(253, 35);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(74, 30);
            this.labelPosition.TabIndex = 25;
            this.labelPosition.Text = "Position";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxY);
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Controls.Add(this.textBoxX);
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Location = new System.Drawing.Point(347, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 32);
            this.panel1.TabIndex = 39;
            // 
            // textBoxY
            // 
            this.textBoxY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxY.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY.Location = new System.Drawing.Point(168, 0);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(90, 32);
            this.textBoxY.TabIndex = 43;
            // 
            // labelY
            // 
            this.labelY.BackColor = System.Drawing.Color.Black;
            this.labelY.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelY.ForeColor = System.Drawing.Color.White;
            this.labelY.Location = new System.Drawing.Point(130, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(38, 32);
            this.labelY.TabIndex = 42;
            this.labelY.Text = "Y";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxX
            // 
            this.textBoxX.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxX.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX.Location = new System.Drawing.Point(30, 0);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 32);
            this.textBoxX.TabIndex = 30;
            // 
            // labelX
            // 
            this.labelX.BackColor = System.Drawing.Color.Black;
            this.labelX.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(0, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(30, 32);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownFocus
            // 
            this.numericUpDownFocus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownFocus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFocus.Location = new System.Drawing.Point(101, 97);
            this.numericUpDownFocus.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownFocus.Name = "numericUpDownFocus";
            this.numericUpDownFocus.Size = new System.Drawing.Size(130, 24);
            this.numericUpDownFocus.TabIndex = 40;
            this.numericUpDownFocus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownFocus.ThousandsSeparator = true;
            this.numericUpDownFocus.Value = new decimal(new int[] {
            56,
            0,
            0,
            0});
            // 
            // numericUpDownZoom
            // 
            this.numericUpDownZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownZoom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownZoom.Location = new System.Drawing.Point(101, 39);
            this.numericUpDownZoom.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownZoom.Name = "numericUpDownZoom";
            this.numericUpDownZoom.Size = new System.Drawing.Size(130, 24);
            this.numericUpDownZoom.TabIndex = 40;
            this.numericUpDownZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownZoom.ThousandsSeparator = true;
            this.numericUpDownZoom.Value = new decimal(new int[] {
            56,
            0,
            0,
            0});
            // 
            // numericUpDownExposure
            // 
            this.numericUpDownExposure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExposure.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExposure.Location = new System.Drawing.Point(350, 94);
            this.numericUpDownExposure.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownExposure.Name = "numericUpDownExposure";
            this.numericUpDownExposure.Size = new System.Drawing.Size(130, 24);
            this.numericUpDownExposure.TabIndex = 40;
            this.numericUpDownExposure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownExposure.ThousandsSeparator = true;
            this.numericUpDownExposure.Value = new decimal(new int[] {
            56,
            0,
            0,
            0});
            // 
            // labelPoseNumber
            // 
            this.labelPoseNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(134)))), ((int)(((byte)(212)))));
            this.labelPoseNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPoseNumber.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoseNumber.ForeColor = System.Drawing.Color.White;
            this.labelPoseNumber.Location = new System.Drawing.Point(0, 0);
            this.labelPoseNumber.Name = "labelPoseNumber";
            this.labelPoseNumber.Size = new System.Drawing.Size(612, 23);
            this.labelPoseNumber.TabIndex = 41;
            this.labelPoseNumber.Text = "Pose Number";
            this.labelPoseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PoseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelPoseNumber);
            this.Controls.Add(this.numericUpDownExposure);
            this.Controls.Add(this.numericUpDownZoom);
            this.Controls.Add(this.numericUpDownFocus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelExposure);
            this.Controls.Add(this.labelFocus);
            this.Controls.Add(this.labelZoom);
            this.Name = "PoseControl";
            this.Size = new System.Drawing.Size(612, 190);
            this.Load += new System.EventHandler(this.PoseControl_Load);
            this.Leave += new System.EventHandler(this.PoseControl_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExposure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelFocus;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Label labelExposure;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        public System.Windows.Forms.NumericUpDown numericUpDownFocus;
        private System.Windows.Forms.NumericUpDown numericUpDownZoom;
        private System.Windows.Forms.NumericUpDown numericUpDownExposure;
        public System.Windows.Forms.Label labelPoseNumber;
    }
}
