using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_friendly
{
    public partial class App_win : Form
    {
        public static int C_Date;
        public static int C_month;
        public static int C_year;
        public static int last_year;
        public bool check_1 ;
        public bool found_1 ;

        public void next_date() {
            if (C_Date < 31)
            {
                C_Date += 1;
            }
            else {
                C_Date = 1;
                if (C_month < 12)
                {
                    C_month += 1;
                }
                else {
                    C_month = 1;
                    C_year += 1;
                }
            }
        }

        public App_win()
        {
            InitializeComponent();
            this.CGPA_value.Text = "0.00";
            this.Birth_value.Text = "1/1/1900";
            this.WB1.Navigate("www.google.com");
            Batches.Items.Add("BE(SE)-3");
            Batches.Items.Add("BE(SE)-4");
            Batches.Items.Add("BE(SE)-5");
            Batches.Items.Add("BE(SE)-6");
            Batches.Items.Add("BEE-4");
            Batches.Items.Add("BEE-5");
            Batches.Items.Add("BEE-6");
            Batches.Items.Add("BEE-7");
            Batches.Items.Add("BS(CS)-2");
            Batches.Items.Add("BS(CS)-3");
            Batches.Items.Add("BS(CS)-4");
            Batches.Items.Add("BS(CS)-5");
            Batches.Items.Add("MS(IT)");
            Batches.Items.Add("MS(CS)");
            Batches.Items.Add("MS(IS)");
            Batches.Items.Add("MS(ITE)");
            Batches.Items.Add("MS(EE)-TCN");
            Batches.Items.Add("MS(EE)-DSP");
            Batches.Items.Add("MS(EE)-RF");
            Batches.Items.Add("MS(EE)-PEC");
            for (int i = 54; i <= 97; i++)
            {
                Starting_Year.Items.Add(i.ToString());
            }
            URL_value_box.Items.Add("http://seecs.nust.edu.pk/Student-Affairs/Results/fall-2015/");
            C_Date = 1;
            C_month = 1;
            check_1 = true;
            found_1 = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void GO_b_Click(object sender, EventArgs e)
        {
            GO_b.Text = "Working...";
            //all go code here
            if (Batches.SelectedItem == null || string.IsNullOrEmpty(REG_value.Text)
                || URL_value_box.SelectedItem == null || Starting_Year.SelectedItem == null)
            {
                Error.Text = "Some information is missing...check if any data-box in empty";
            }
            else
            {
                Error.Text = "Proceeding.....";
                C_year = Int32.Parse(Starting_Year.Text);
                last_year = Int32.Parse(Starting_Year.Text) + 2;
                while (C_year <= last_year && !found_1)
                {
                    WB1.Navigate(URL_value_box.Text);
                    while (WB1.ReadyState != WebBrowserReadyState.Complete)
                    {
                        Application.DoEvents();
                    }
                    Error.Text = "Loaded page";
                    WB1.Document.GetElementById("regno").SetAttribute("value", REG_value.Text);
                    WB1.Document.GetElementById("cboclass").SetAttribute("value", Batches.Text);
                    WB1.Document.GetElementById("cboyear1").SetAttribute("value", C_year.ToString());
                    if (C_Date < 10)
                    {
                        WB1.Document.GetElementById("cboday1").SetAttribute("value", "0" + C_Date.ToString());
                    }
                    else
                    {
                        WB1.Document.GetElementById("cboday1").SetAttribute("value", C_Date.ToString());
                    }
                    if (C_month < 10)
                    {
                        WB1.Document.GetElementById("cbomonth1").SetAttribute("value", "0" + C_month.ToString());
                    }
                    else
                    {
                        WB1.Document.GetElementById("cbomonth1").SetAttribute("value", C_month.ToString());
                    }
                    WB1.Document.GetElementById("Submit").InvokeMember("click");
                    while (check_1)
                    {
                        Application.DoEvents();
                        if (WB1.Url.ToString() == "http://seecs.nust.edu.pk/Student-Affairs/Results/fall-2015/result.php") {
                            string file_all = WB1.DocumentText;
                            string[] separators = { "<b>", "</b>", REG_value.Text };
                            string[] words = file_all.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            if (words.Length >= 2)
                                if (words[1] == "Date of Birth is not matched with provided Registration No, unable to display result")
                                {
                                    check_1 = false;
                                }
                                else
                                {
                                    if(words.Length ==2){
                                    found_1 = true;
                                    check_1 = false;
                                    }
                                }
                                
                        }
                    }
                    if (!found_1)
                    {
                        next_date();
                    }
                    check_1 = true;
                }
                if (found_1)
                {
                    Error.Text = "FOUND";
                    CGPA_value.Text="On webpage";
                    Birth_value.Text = C_Date.ToString()+"/"+C_month.ToString()+ "/"+C_year.ToString();
                    found_1 = false;
                }
                else {
                    Error.Text = "notfound";
                }
                C_Date = 1;
                C_month = 1;
                Error.Text = "Done";
            }
            GO_b.Text = "GO";
        }
        private void WB1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Birth_value_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CGPA_value_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void REG_value_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Reg_label_Click(object sender, EventArgs e)
        {
            
        }

        private void example_Click(object sender, EventArgs e)
        {
            
        }

        private void CGPA_label_Click(object sender, EventArgs e)
        {
            
        }

        private void Birth_label_Click(object sender, EventArgs e)
        {
            
        }



        private void Batches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Error_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void App_win_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void example_Y_Click(object sender, EventArgs e)
        {

        }
    }
}
