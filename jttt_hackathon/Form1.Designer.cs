namespace jttt_hackathon
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DoTaskButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TaskNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.WeatherButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Strona = new System.Windows.Forms.TabPage();
            this.Pogoda = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.MiastoBox = new System.Windows.Forms.TextBox();
            this.TemperaturyList = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Strona.SuspendLayout();
            this.Pogoda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TemperaturyList)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(12, 19);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(239, 20);
            this.UrlBox.TabIndex = 0;
            this.UrlBox.Text = "http://demotywatory.pl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj adres URL:";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(12, 72);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(239, 20);
            this.KeyBox.TabIndex = 2;
            this.KeyBox.Text = "się";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szukana fraza:";
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(39, 189);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(239, 20);
            this.MailBox.TabIndex = 4;
            this.MailBox.Text = "airdeniskuba2@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Na ten mail wyślij znaleziony link:";
            // 
            // DoTaskButton
            // 
            this.DoTaskButton.Location = new System.Drawing.Point(357, 189);
            this.DoTaskButton.Name = "DoTaskButton";
            this.DoTaskButton.Size = new System.Drawing.Size(106, 56);
            this.DoTaskButton.TabIndex = 6;
            this.DoTaskButton.Text = "Wykonaj";
            this.DoTaskButton.UseVisualStyleBackColor = true;
            this.DoTaskButton.Click += new System.EventHandler(this.DoTaskButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(541, 266);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 46);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Wyjdź";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TaskNameBox
            // 
            this.TaskNameBox.Location = new System.Drawing.Point(119, 229);
            this.TaskNameBox.Name = "TaskNameBox";
            this.TaskNameBox.Size = new System.Drawing.Size(159, 20);
            this.TaskNameBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nazwa zadania:";
            // 
            // TaskListBox
            // 
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.Location = new System.Drawing.Point(357, 35);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(290, 134);
            this.TaskListBox.TabIndex = 11;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(469, 189);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(98, 56);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Czyść";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(572, 189);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(75, 20);
            this.SerializeButton.TabIndex = 13;
            this.SerializeButton.Text = "Serializuj";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(573, 222);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(75, 23);
            this.DeserializeButton.TabIndex = 14;
            this.DeserializeButton.Text = "Deserializuj";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(39, 266);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(185, 46);
            this.AddTaskButton.TabIndex = 15;
            this.AddTaskButton.Text = "Dodaj do listy";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // WeatherButton
            // 
            this.WeatherButton.Location = new System.Drawing.Point(357, 266);
            this.WeatherButton.Name = "WeatherButton";
            this.WeatherButton.Size = new System.Drawing.Size(106, 46);
            this.WeatherButton.TabIndex = 16;
            this.WeatherButton.Text = "POGODA";
            this.WeatherButton.UseVisualStyleBackColor = true;
            this.WeatherButton.Click += new System.EventHandler(this.WeatherButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Strona);
            this.tabControl1.Controls.Add(this.Pogoda);
            this.tabControl1.Location = new System.Drawing.Point(26, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 147);
            this.tabControl1.TabIndex = 17;
            // 
            // Strona
            // 
            this.Strona.Controls.Add(this.label1);
            this.Strona.Controls.Add(this.UrlBox);
            this.Strona.Controls.Add(this.label2);
            this.Strona.Controls.Add(this.KeyBox);
            this.Strona.Location = new System.Drawing.Point(4, 22);
            this.Strona.Name = "Strona";
            this.Strona.Padding = new System.Windows.Forms.Padding(3);
            this.Strona.Size = new System.Drawing.Size(301, 121);
            this.Strona.TabIndex = 0;
            this.Strona.Text = "Sprawdź stronę";
            this.Strona.UseVisualStyleBackColor = true;
            // 
            // Pogoda
            // 
            this.Pogoda.Controls.Add(this.label6);
            this.Pogoda.Controls.Add(this.TemperaturyList);
            this.Pogoda.Controls.Add(this.MiastoBox);
            this.Pogoda.Controls.Add(this.label5);
            this.Pogoda.Location = new System.Drawing.Point(4, 22);
            this.Pogoda.Name = "Pogoda";
            this.Pogoda.Padding = new System.Windows.Forms.Padding(3);
            this.Pogoda.Size = new System.Drawing.Size(301, 121);
            this.Pogoda.TabIndex = 1;
            this.Pogoda.Text = "Sprawdź pogodę";
            this.Pogoda.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Miasto";
            // 
            // MiastoBox
            // 
            this.MiastoBox.Location = new System.Drawing.Point(22, 30);
            this.MiastoBox.Name = "MiastoBox";
            this.MiastoBox.Size = new System.Drawing.Size(145, 20);
            this.MiastoBox.TabIndex = 1;
            // 
            // TemperaturyList
            // 
            this.TemperaturyList.Location = new System.Drawing.Point(22, 79);
            this.TemperaturyList.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TemperaturyList.Name = "TemperaturyList";
            this.TemperaturyList.Size = new System.Drawing.Size(120, 20);
            this.TemperaturyList.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Temperatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 334);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.WeatherButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.DeserializeButton);
            this.Controls.Add(this.SerializeButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TaskListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TaskNameBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DoTaskButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MailBox);
            this.Name = "Form1";
            this.Text = "JTTT";
            this.tabControl1.ResumeLayout(false);
            this.Strona.ResumeLayout(false);
            this.Strona.PerformLayout();
            this.Pogoda.ResumeLayout(false);
            this.Pogoda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TemperaturyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DoTaskButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox TaskNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button WeatherButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Strona;
        private System.Windows.Forms.TabPage Pogoda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TemperaturyList;
        private System.Windows.Forms.TextBox MiastoBox;
        private System.Windows.Forms.Label label5;
    }
}

