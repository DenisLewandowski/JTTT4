namespace jttt_hackathon
{
    partial class WeatherForm
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
            this.CityNameTextBox = new System.Windows.Forms.TextBox();
            this.CityName = new System.Windows.Forms.Label();
            this.WeatherButon = new System.Windows.Forms.Button();
            this.WeatherListBox = new System.Windows.Forms.ListBox();
            this.WeatherPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CityNameTextBox
            // 
            this.CityNameTextBox.Location = new System.Drawing.Point(87, 20);
            this.CityNameTextBox.Name = "CityNameTextBox";
            this.CityNameTextBox.Size = new System.Drawing.Size(239, 20);
            this.CityNameTextBox.TabIndex = 0;
            // 
            // CityName
            // 
            this.CityName.AutoSize = true;
            this.CityName.Location = new System.Drawing.Point(32, 23);
            this.CityName.Name = "CityName";
            this.CityName.Size = new System.Drawing.Size(41, 13);
            this.CityName.TabIndex = 1;
            this.CityName.Text = "Miasto:";
            // 
            // WeatherListBox
            // 
            this.WeatherListBox.FormattingEnabled = true;
            this.WeatherListBox.Location = new System.Drawing.Point(35, 93);
            this.WeatherListBox.Name = "WeatherListBox";
            this.WeatherListBox.Size = new System.Drawing.Size(209, 69);
            this.WeatherListBox.TabIndex = 3;
            // 
            // WeatherPictureBox
            // 
            this.WeatherPictureBox.Location = new System.Drawing.Point(250, 93);
            this.WeatherPictureBox.Name = "WeatherPictureBox";
            this.WeatherPictureBox.Size = new System.Drawing.Size(76, 69);
            this.WeatherPictureBox.TabIndex = 4;
            this.WeatherPictureBox.TabStop = false;
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 182);
            this.Controls.Add(this.WeatherPictureBox);
            this.Controls.Add(this.WeatherListBox);
            this.Controls.Add(this.WeatherButon);
            this.Controls.Add(this.CityName);
            this.Controls.Add(this.CityNameTextBox);
            this.Name = "WeatherForm";
            this.Text = "Pogoda";
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CityNameTextBox;
        private System.Windows.Forms.Label CityName;
        private System.Windows.Forms.Button WeatherButon;
        private System.Windows.Forms.PictureBox WeatherPictureBox;
        private System.Windows.Forms.ListBox WeatherListBox;
    }
}