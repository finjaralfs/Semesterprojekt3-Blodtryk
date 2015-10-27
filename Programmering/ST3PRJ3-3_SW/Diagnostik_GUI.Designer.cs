namespace ST3PRJ3_3_SW
{
    partial class Diagnostik_GUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnostik_GUI));
            this.Patient_CPR_Label = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.Systolisk_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Diastolisk_Textbox = new System.Windows.Forms.TextBox();
            this.Digitalt_filter_Til_radioButton = new System.Windows.Forms.RadioButton();
            this.Digitalt_filter_fra_radioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Puls_textBox = new System.Windows.Forms.TextBox();
            this.Lydløs_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gem_data_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Patient_CPR_Label
            // 
            this.Patient_CPR_Label.AutoSize = true;
            this.Patient_CPR_Label.Location = new System.Drawing.Point(13, 13);
            this.Patient_CPR_Label.Name = "Patient_CPR_Label";
            this.Patient_CPR_Label.Size = new System.Drawing.Size(65, 13);
            this.Patient_CPR_Label.TabIndex = 0;
            this.Patient_CPR_Label.Text = "Patient CPR";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 46);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Blodtryk";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(824, 340);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Systolisk";
            // 
            // Systolisk_Textbox
            // 
            this.Systolisk_Textbox.Location = new System.Drawing.Point(862, 117);
            this.Systolisk_Textbox.Name = "Systolisk_Textbox";
            this.Systolisk_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Systolisk_Textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Diastolisk";
            // 
            // Diastolisk_Textbox
            // 
            this.Diastolisk_Textbox.Location = new System.Drawing.Point(862, 191);
            this.Diastolisk_Textbox.Name = "Diastolisk_Textbox";
            this.Diastolisk_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Diastolisk_Textbox.TabIndex = 5;
            // 
            // Digitalt_filter_Til_radioButton
            // 
            this.Digitalt_filter_Til_radioButton.AutoSize = true;
            this.Digitalt_filter_Til_radioButton.Location = new System.Drawing.Point(400, 466);
            this.Digitalt_filter_Til_radioButton.Name = "Digitalt_filter_Til_radioButton";
            this.Digitalt_filter_Til_radioButton.Size = new System.Drawing.Size(36, 17);
            this.Digitalt_filter_Til_radioButton.TabIndex = 6;
            this.Digitalt_filter_Til_radioButton.TabStop = true;
            this.Digitalt_filter_Til_radioButton.Text = "Til";
            this.Digitalt_filter_Til_radioButton.UseVisualStyleBackColor = true;
            // 
            // Digitalt_filter_fra_radioButton
            // 
            this.Digitalt_filter_fra_radioButton.AutoSize = true;
            this.Digitalt_filter_fra_radioButton.Location = new System.Drawing.Point(442, 466);
            this.Digitalt_filter_fra_radioButton.Name = "Digitalt_filter_fra_radioButton";
            this.Digitalt_filter_fra_radioButton.Size = new System.Drawing.Size(40, 17);
            this.Digitalt_filter_fra_radioButton.TabIndex = 7;
            this.Digitalt_filter_fra_radioButton.TabStop = true;
            this.Digitalt_filter_fra_radioButton.Text = "Fra";
            this.Digitalt_filter_fra_radioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digitalt filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(859, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puls";
            // 
            // Puls_textBox
            // 
            this.Puls_textBox.Location = new System.Drawing.Point(862, 277);
            this.Puls_textBox.Name = "Puls_textBox";
            this.Puls_textBox.Size = new System.Drawing.Size(100, 20);
            this.Puls_textBox.TabIndex = 10;
            // 
            // Lydløs_button
            // 
            this.Lydløs_button.Location = new System.Drawing.Point(529, 418);
            this.Lydløs_button.Name = "Lydløs_button";
            this.Lydløs_button.Size = new System.Drawing.Size(145, 56);
            this.Lydløs_button.TabIndex = 11;
            this.Lydløs_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Gem_data_button
            // 
            this.Gem_data_button.Location = new System.Drawing.Point(862, 382);
            this.Gem_data_button.Name = "Gem_data_button";
            this.Gem_data_button.Size = new System.Drawing.Size(75, 23);
            this.Gem_data_button.TabIndex = 13;
            this.Gem_data_button.Text = "Gem data";
            this.Gem_data_button.UseVisualStyleBackColor = true;
            // 
            // Diagnostik_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 495);
            this.Controls.Add(this.Gem_data_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lydløs_button);
            this.Controls.Add(this.Puls_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Digitalt_filter_fra_radioButton);
            this.Controls.Add(this.Digitalt_filter_Til_radioButton);
            this.Controls.Add(this.Diastolisk_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Systolisk_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Patient_CPR_Label);
            this.Name = "Diagnostik_GUI";
            this.Text = "Diagnostik";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Patient_CPR_Label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Systolisk_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Diastolisk_Textbox;
        private System.Windows.Forms.RadioButton Digitalt_filter_Til_radioButton;
        private System.Windows.Forms.RadioButton Digitalt_filter_fra_radioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Puls_textBox;
        private System.Windows.Forms.Button Lydløs_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Gem_data_button;
    }
}