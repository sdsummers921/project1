namespace PatientManagement
{
    partial class MainForm
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
            this.buttonSearchForPatient = new System.Windows.Forms.Button();
            this.buttonCreateNewPatient = new System.Windows.Forms.Button();
            this.buttonSwitchUserLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearchForPatient
            // 
            this.buttonSearchForPatient.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchForPatient.Location = new System.Drawing.Point(128, 177);
            this.buttonSearchForPatient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchForPatient.Name = "buttonSearchForPatient";
            this.buttonSearchForPatient.Size = new System.Drawing.Size(158, 50);
            this.buttonSearchForPatient.TabIndex = 1;
            this.buttonSearchForPatient.Text = "Search for Patient";
            this.buttonSearchForPatient.UseVisualStyleBackColor = false;
            this.buttonSearchForPatient.Click += new System.EventHandler(this.buttonSearchForPatient_Click);
            // 
            // buttonCreateNewPatient
            // 
            this.buttonCreateNewPatient.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCreateNewPatient.Location = new System.Drawing.Point(128, 106);
            this.buttonCreateNewPatient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateNewPatient.Name = "buttonCreateNewPatient";
            this.buttonCreateNewPatient.Size = new System.Drawing.Size(158, 50);
            this.buttonCreateNewPatient.TabIndex = 3;
            this.buttonCreateNewPatient.Text = "Create New Patient";
            this.buttonCreateNewPatient.UseVisualStyleBackColor = false;
            this.buttonCreateNewPatient.Click += new System.EventHandler(this.buttonCreateNewPatient_Click);
            // 
            // buttonSwitchUserLogOut
            // 
            this.buttonSwitchUserLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSwitchUserLogOut.Location = new System.Drawing.Point(128, 249);
            this.buttonSwitchUserLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSwitchUserLogOut.Name = "buttonSwitchUserLogOut";
            this.buttonSwitchUserLogOut.Size = new System.Drawing.Size(158, 50);
            this.buttonSwitchUserLogOut.TabIndex = 4;
            this.buttonSwitchUserLogOut.Text = "Switch User / Log Out";
            this.buttonSwitchUserLogOut.UseVisualStyleBackColor = false;
            this.buttonSwitchUserLogOut.Click += new System.EventHandler(this.buttonSwitchUserLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to SDS Patient Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(424, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSwitchUserLogOut);
            this.Controls.Add(this.buttonCreateNewPatient);
            this.Controls.Add(this.buttonSearchForPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Management 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchForPatient;
        private System.Windows.Forms.Button buttonCreateNewPatient;
        private System.Windows.Forms.Button buttonSwitchUserLogOut;
        private System.Windows.Forms.Label label1;
    }
}

