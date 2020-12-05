namespace Assignment.Base.Common.UserControls
{
    partial class HomeMdiApplicationInformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.appInfoValueLabelVersion = new Assignment.Base.Common.CustomControls.AppInfoValueLabel();
            this.appInfoLabel5 = new Assignment.Base.Common.CustomControls.AppInfoLabel();
            this.appInfoLabel1 = new Assignment.Base.Common.CustomControls.AppInfoLabel();
            this.appInfoLabel4 = new Assignment.Base.Common.CustomControls.AppInfoLabel();
            this.appInfoLabel2 = new Assignment.Base.Common.CustomControls.AppInfoLabel();
            this.appInfoLabel3 = new Assignment.Base.Common.CustomControls.AppInfoLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appInfoValueLabelVersion);
            this.panel1.Controls.Add(this.appInfoLabel5);
            this.panel1.Controls.Add(this.appInfoLabel1);
            this.panel1.Controls.Add(this.appInfoLabel4);
            this.panel1.Controls.Add(this.appInfoLabel2);
            this.panel1.Controls.Add(this.appInfoLabel3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 41);
            this.panel1.TabIndex = 5;
            // 
            // appInfoValueLabelVersion
            // 
            this.appInfoValueLabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.appInfoValueLabelVersion.Location = new System.Drawing.Point(207, 9);
            this.appInfoValueLabelVersion.Name = "appInfoValueLabelVersion";
            this.appInfoValueLabelVersion.Size = new System.Drawing.Size(75, 23);
            this.appInfoValueLabelVersion.TabIndex = 5;
            this.appInfoValueLabelVersion.Text = "Loading...";
            // 
            // appInfoLabel5
            // 
            this.appInfoLabel5.AutoSize = true;
            this.appInfoLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.appInfoLabel5.Location = new System.Drawing.Point(518, 9);
            this.appInfoLabel5.Name = "appInfoLabel5";
            this.appInfoLabel5.Size = new System.Drawing.Size(69, 17);
            this.appInfoLabel5.TabIndex = 4;
            this.appInfoLabel5.Text = "Database";
            // 
            // appInfoLabel1
            // 
            this.appInfoLabel1.AutoSize = true;
            this.appInfoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.appInfoLabel1.Location = new System.Drawing.Point(3, 9);
            this.appInfoLabel1.Name = "appInfoLabel1";
            this.appInfoLabel1.Size = new System.Drawing.Size(103, 17);
            this.appInfoLabel1.TabIndex = 0;
            this.appInfoLabel1.Text = "Program Name";
            // 
            // appInfoLabel4
            // 
            this.appInfoLabel4.AutoSize = true;
            this.appInfoLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.appInfoLabel4.Location = new System.Drawing.Point(429, 9);
            this.appInfoLabel4.Name = "appInfoLabel4";
            this.appInfoLabel4.Size = new System.Drawing.Size(43, 17);
            this.appInfoLabel4.TabIndex = 3;
            this.appInfoLabel4.Text = "Login";
            // 
            // appInfoLabel2
            // 
            this.appInfoLabel2.AutoSize = true;
            this.appInfoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.appInfoLabel2.Location = new System.Drawing.Point(145, 9);
            this.appInfoLabel2.Name = "appInfoLabel2";
            this.appInfoLabel2.Size = new System.Drawing.Size(56, 17);
            this.appInfoLabel2.TabIndex = 1;
            this.appInfoLabel2.Text = "Version";
            // 
            // appInfoLabel3
            // 
            this.appInfoLabel3.AutoSize = true;
            this.appInfoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.appInfoLabel3.Location = new System.Drawing.Point(305, 9);
            this.appInfoLabel3.Name = "appInfoLabel3";
            this.appInfoLabel3.Size = new System.Drawing.Size(89, 17);
            this.appInfoLabel3.TabIndex = 2;
            this.appInfoLabel3.Text = "Organization";
            // 
            // HomeMdiApplicationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Name = "HomeMdiApplicationInformation";
            this.Size = new System.Drawing.Size(757, 86);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.AppInfoLabel appInfoLabel1;
        private CustomControls.AppInfoLabel appInfoLabel2;
        private CustomControls.AppInfoLabel appInfoLabel3;
        private CustomControls.AppInfoLabel appInfoLabel4;
        private CustomControls.AppInfoLabel appInfoLabel5;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.AppInfoValueLabel appInfoValueLabelVersion;
    }
}
