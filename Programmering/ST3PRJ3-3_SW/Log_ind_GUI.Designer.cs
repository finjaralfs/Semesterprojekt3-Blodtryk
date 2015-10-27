namespace ST3PRJ3_3_SW
{
    partial class Log_ind
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
            this.label2 = new System.Windows.Forms.Label();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Log_ind_button = new System.Windows.Forms.Button();
            this.Forkert_password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(135, 64);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.ID_textbox.TabIndex = 2;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(135, 108);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(100, 20);
            this.Password_textbox.TabIndex = 3;
            // 
            // Log_ind_button
            // 
            this.Log_ind_button.Location = new System.Drawing.Point(42, 170);
            this.Log_ind_button.Name = "Log_ind_button";
            this.Log_ind_button.Size = new System.Drawing.Size(75, 23);
            this.Log_ind_button.TabIndex = 4;
            this.Log_ind_button.Text = "Log ind";
            this.Log_ind_button.UseVisualStyleBackColor = true;
            // 
            // Forkert_password_label
            // 
            this.Forkert_password_label.AutoSize = true;
            this.Forkert_password_label.Location = new System.Drawing.Point(42, 217);
            this.Forkert_password_label.Name = "Forkert_password_label";
            this.Forkert_password_label.Size = new System.Drawing.Size(187, 13);
            this.Forkert_password_label.TabIndex = 5;
            this.Forkert_password_label.Text = "ID eller password er forkert - Prøv igen";
            // 
            // Log_ind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Forkert_password_label);
            this.Controls.Add(this.Log_ind_button);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Log_ind";
            this.Text = "Log ind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Button Log_ind_button;
        private System.Windows.Forms.Label Forkert_password_label;
    }
}

