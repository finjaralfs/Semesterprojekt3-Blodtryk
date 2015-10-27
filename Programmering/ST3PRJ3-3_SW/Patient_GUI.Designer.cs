namespace ST3PRJ3_3_SW
{
    partial class Patient_GUI
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
            this.Patient_CPR_Textbox = new System.Windows.Forms.TextBox();
            this.Hent_patientoplysninger_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient CPR";
            // 
            // Patient_CPR_Textbox
            // 
            this.Patient_CPR_Textbox.Location = new System.Drawing.Point(141, 72);
            this.Patient_CPR_Textbox.Name = "Patient_CPR_Textbox";
            this.Patient_CPR_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Patient_CPR_Textbox.TabIndex = 1;
            // 
            // Hent_patientoplysninger_button
            // 
            this.Hent_patientoplysninger_button.Location = new System.Drawing.Point(92, 120);
            this.Hent_patientoplysninger_button.Name = "Hent_patientoplysninger_button";
            this.Hent_patientoplysninger_button.Size = new System.Drawing.Size(108, 46);
            this.Hent_patientoplysninger_button.TabIndex = 2;
            this.Hent_patientoplysninger_button.Text = "Hent Patientoplysninger";
            this.Hent_patientoplysninger_button.UseVisualStyleBackColor = true;
            // 
            // Patient_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 193);
            this.Controls.Add(this.Hent_patientoplysninger_button);
            this.Controls.Add(this.Patient_CPR_Textbox);
            this.Controls.Add(this.label1);
            this.Name = "Patient_GUI";
            this.Text = "Patientoplysninger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Patient_CPR_Textbox;
        private System.Windows.Forms.Button Hent_patientoplysninger_button;
    }
}