namespace Web_friendly
{
    partial class App_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App_win));
            this.REG_value = new System.Windows.Forms.TextBox();
            this.Reg_label = new System.Windows.Forms.Label();
            this.Batch_label = new System.Windows.Forms.Label();
            this.GO_b = new System.Windows.Forms.Button();
            this.Birth_label = new System.Windows.Forms.Label();
            this.Birth_value = new System.Windows.Forms.TextBox();
            this.CGPA_label = new System.Windows.Forms.Label();
            this.CGPA_value = new System.Windows.Forms.TextBox();
            this.WB1 = new System.Windows.Forms.WebBrowser();
            this.URL_label = new System.Windows.Forms.Label();
            this.example = new System.Windows.Forms.Label();
            this.Batches = new System.Windows.Forms.ComboBox();
            this.Error = new System.Windows.Forms.TextBox();
            this.URL_value_box = new System.Windows.Forms.ComboBox();
            this.Starting_Year = new System.Windows.Forms.ComboBox();
            this.year_label = new System.Windows.Forms.Label();
            this.example_Y = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // REG_value
            // 
            this.REG_value.Location = new System.Drawing.Point(165, 12);
            this.REG_value.Name = "REG_value";
            this.REG_value.Size = new System.Drawing.Size(226, 20);
            this.REG_value.TabIndex = 0;
            this.REG_value.TextChanged += new System.EventHandler(this.REG_value_TextChanged);
            // 
            // Reg_label
            // 
            this.Reg_label.AutoSize = true;
            this.Reg_label.Location = new System.Drawing.Point(78, 15);
            this.Reg_label.Name = "Reg_label";
            this.Reg_label.Size = new System.Drawing.Size(81, 13);
            this.Reg_label.TabIndex = 1;
            this.Reg_label.Text = "Registration no.";
            this.Reg_label.Click += new System.EventHandler(this.Reg_label_Click);
            // 
            // Batch_label
            // 
            this.Batch_label.AutoSize = true;
            this.Batch_label.Location = new System.Drawing.Point(409, 15);
            this.Batch_label.Name = "Batch_label";
            this.Batch_label.Size = new System.Drawing.Size(64, 13);
            this.Batch_label.TabIndex = 2;
            this.Batch_label.Text = "Batch name";
            this.Batch_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // GO_b
            // 
            this.GO_b.Location = new System.Drawing.Point(1229, 14);
            this.GO_b.Name = "GO_b";
            this.GO_b.Size = new System.Drawing.Size(108, 23);
            this.GO_b.TabIndex = 4;
            this.GO_b.Text = "GO";
            this.GO_b.UseVisualStyleBackColor = true;
            this.GO_b.Click += new System.EventHandler(this.GO_b_Click);
            // 
            // Birth_label
            // 
            this.Birth_label.AutoSize = true;
            this.Birth_label.Location = new System.Drawing.Point(770, 631);
            this.Birth_label.Name = "Birth_label";
            this.Birth_label.Size = new System.Drawing.Size(66, 13);
            this.Birth_label.TabIndex = 5;
            this.Birth_label.Text = "Date of Birth";
            this.Birth_label.Click += new System.EventHandler(this.Birth_label_Click);
            // 
            // Birth_value
            // 
            this.Birth_value.Enabled = false;
            this.Birth_value.Location = new System.Drawing.Point(878, 628);
            this.Birth_value.Name = "Birth_value";
            this.Birth_value.Size = new System.Drawing.Size(158, 20);
            this.Birth_value.TabIndex = 6;
            this.Birth_value.TextChanged += new System.EventHandler(this.Birth_value_TextChanged);
            // 
            // CGPA_label
            // 
            this.CGPA_label.AutoSize = true;
            this.CGPA_label.Location = new System.Drawing.Point(368, 631);
            this.CGPA_label.Name = "CGPA_label";
            this.CGPA_label.Size = new System.Drawing.Size(36, 13);
            this.CGPA_label.TabIndex = 7;
            this.CGPA_label.Text = "CGPA";
            this.CGPA_label.Click += new System.EventHandler(this.CGPA_label_Click);
            // 
            // CGPA_value
            // 
            this.CGPA_value.Enabled = false;
            this.CGPA_value.Location = new System.Drawing.Point(442, 628);
            this.CGPA_value.Name = "CGPA_value";
            this.CGPA_value.Size = new System.Drawing.Size(100, 20);
            this.CGPA_value.TabIndex = 8;
            this.CGPA_value.TextChanged += new System.EventHandler(this.CGPA_value_TextChanged);
            // 
            // WB1
            // 
            this.WB1.Location = new System.Drawing.Point(81, 56);
            this.WB1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB1.Name = "WB1";
            this.WB1.ScriptErrorsSuppressed = true;
            this.WB1.Size = new System.Drawing.Size(1200, 540);
            this.WB1.TabIndex = 9;
            this.WB1.Url = new System.Uri("", System.UriKind.Relative);
            this.WB1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WB1_DocumentCompleted);
            // 
            // URL_label
            // 
            this.URL_label.AutoSize = true;
            this.URL_label.Location = new System.Drawing.Point(631, 15);
            this.URL_label.Name = "URL_label";
            this.URL_label.Size = new System.Drawing.Size(29, 13);
            this.URL_label.TabIndex = 10;
            this.URL_label.Text = "URL";
            this.URL_label.Click += new System.EventHandler(this.label5_Click);
            // 
            // example
            // 
            this.example.AutoSize = true;
            this.example.Location = new System.Drawing.Point(642, 36);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(331, 13);
            this.example.TabIndex = 12;
            this.example.Text = "URL i.e. http://seecs.nust.edu.pk/Student-Affairs/Results/fall-2015/";
            this.example.Click += new System.EventHandler(this.example_Click);
            // 
            // Batches
            // 
            this.Batches.FormattingEnabled = true;
            this.Batches.Location = new System.Drawing.Point(479, 12);
            this.Batches.Name = "Batches";
            this.Batches.Size = new System.Drawing.Size(130, 21);
            this.Batches.TabIndex = 14;
            this.Batches.SelectedIndexChanged += new System.EventHandler(this.Batches_SelectedIndexChanged);
            // 
            // Error
            // 
            this.Error.Enabled = false;
            this.Error.Location = new System.Drawing.Point(81, 602);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(1200, 20);
            this.Error.TabIndex = 15;
            this.Error.TextChanged += new System.EventHandler(this.Error_TextChanged);
            // 
            // URL_value_box
            // 
            this.URL_value_box.FormattingEnabled = true;
            this.URL_value_box.Location = new System.Drawing.Point(677, 12);
            this.URL_value_box.Name = "URL_value_box";
            this.URL_value_box.Size = new System.Drawing.Size(305, 21);
            this.URL_value_box.TabIndex = 16;
            this.URL_value_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Starting_Year
            // 
            this.Starting_Year.FormattingEnabled = true;
            this.Starting_Year.Location = new System.Drawing.Point(1099, 12);
            this.Starting_Year.Name = "Starting_Year";
            this.Starting_Year.Size = new System.Drawing.Size(63, 21);
            this.Starting_Year.TabIndex = 17;
            this.Starting_Year.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // year_label
            // 
            this.year_label.AllowDrop = true;
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(1018, 19);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(65, 13);
            this.year_label.TabIndex = 18;
            this.year_label.Text = "Sarting Year";
            this.year_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // example_Y
            // 
            this.example_Y.AutoSize = true;
            this.example_Y.Location = new System.Drawing.Point(1046, 36);
            this.example_Y.Name = "example_Y";
            this.example_Y.Size = new System.Drawing.Size(137, 13);
            this.example_Y.TabIndex = 19;
            this.example_Y.Text = "i.e. 94, checks for 94,95,96";
            this.example_Y.Click += new System.EventHandler(this.example_Y_Click);
            // 
            // App_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 681);
            this.Controls.Add(this.example_Y);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.Starting_Year);
            this.Controls.Add(this.URL_value_box);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Batches);
            this.Controls.Add(this.example);
            this.Controls.Add(this.URL_label);
            this.Controls.Add(this.WB1);
            this.Controls.Add(this.CGPA_value);
            this.Controls.Add(this.CGPA_label);
            this.Controls.Add(this.Birth_value);
            this.Controls.Add(this.Birth_label);
            this.Controls.Add(this.GO_b);
            this.Controls.Add(this.Batch_label);
            this.Controls.Add(this.Reg_label);
            this.Controls.Add(this.REG_value);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App_win";
            this.Text = "GPA_win";
            this.Load += new System.EventHandler(this.App_win_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox REG_value;
        private System.Windows.Forms.Label Reg_label;
        private System.Windows.Forms.Label Batch_label;
        private System.Windows.Forms.ComboBox Batches;
        private System.Windows.Forms.Button GO_b;
        private System.Windows.Forms.Label Birth_label;
        private System.Windows.Forms.TextBox Birth_value;
        private System.Windows.Forms.Label CGPA_label;
        private System.Windows.Forms.TextBox CGPA_value;
        private System.Windows.Forms.WebBrowser WB1;
        private System.Windows.Forms.Label URL_label;
        private System.Windows.Forms.ComboBox URL_value_box;
        private System.Windows.Forms.Label example;
        private System.Windows.Forms.TextBox Error;
        private System.Windows.Forms.ComboBox Starting_Year;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label example_Y;
        
    }
}

