using System;
using System.Windows.Forms;
using System.IO;

namespace Scanner1
{
    public partial class Form1 : Form
    {

        static String[] _values = { "Yesif", "Otherwise", "Omw", "SIMww", "Chji", "Seriestl",
            "IMwf", "SIMwf", "NOReturn", "RepeatWhen", "Reiterate", "GetBack",
            "OutLoop", "Loli", "Include", "Start", "Last"};
        AutoComplete autoComplete; 

        public Form1()
        {
            InitializeComponent();
            AutoComplete.Values = _values;
        }
      
        public int line = 0;
        public int column = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            GetTokens getTokens = new GetTokens(autoComplete.Text);
            richTextBox1.Text = getTokens.Compile();
            label4.Text = GetTokens.errors.ToString();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            autoComplete = new AutoComplete(); 
            autoComplete.Width = 950;
            autoComplete.Multiline = true;
            autoComplete.Height = 200;
            autoComplete.Top = 70; 
            autoComplete.ScrollBars = ScrollBars.Vertical;
            Controls.Add(autoComplete);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            autoComplete.Cut();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            autoComplete.Clear();
        }

        private static int CountLines(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");
            if (str == string.Empty)
                return 0;
            int index = -1;
            int count = 0;
            while (-1 != (index = str.IndexOf(Environment.NewLine, index + 1)))
                count++;

            return count + 1;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
           
            if(autoComplete.SelectedText.Length == 0)
            {

            }
            else
            {
                string show = autoComplete.SelectedText;
                string temp = show;
                int Number_in_section = CountLines(show);
                string str = temp.Remove(0, 2);
                if (Number_in_section == 1 && show.StartsWith("/^"))
                    autoComplete.Text = autoComplete.Text.Replace(show, show.Remove(0, 2));
                else if (Number_in_section != 1 && (show.StartsWith("/@") && show.EndsWith("@/")))
                {
                    autoComplete.Text = autoComplete.Text.Replace(show, str.Remove(str.Length - 2, 2));

                }

            }
        }
           



        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Title = "My open file dialog";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    autoComplete.Clear();
                    using (StreamReader sr = new StreamReader(openfile.FileName))
                    {
                        autoComplete.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Save file as..";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtoutput = new StreamWriter(savefile.FileName);
                txtoutput.Write(autoComplete.Text);
                txtoutput.Close();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            autoComplete.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            autoComplete.Paste();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            autoComplete.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            autoComplete.SelectAll();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            line = 1 + autoComplete.GetLineFromCharIndex(autoComplete.GetFirstCharIndexOfCurrentLine());
            column = 1 + autoComplete.SelectionStart - autoComplete.GetFirstCharIndexOfCurrentLine();
            toolStripStatusLabel1.Text = "line: " + line.ToString() + " | column: " + column.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (textBox3.Text != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox4.Text != null && !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                autoComplete.Text = autoComplete.Text.Replace(textBox3.Text, textBox4.Text);
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comment_Click(object sender, EventArgs e)
        {
            string show = autoComplete.SelectedText;
            
            
            if (autoComplete.SelectedText.Length ==  0 )
            { 
            } 
            else
            {
                
                int Number_in_section = CountLines(show);
                if (Number_in_section == 1)
                {
                    if (show.StartsWith("/@") )
                    {

                    }else if (show.EndsWith("@/"))
                    {

                    }
                    else
                        autoComplete.Text = autoComplete.Text.Replace(show, ("/^" + show));
                }

                else
                {
                    autoComplete.Text = autoComplete.Text.Replace(show, ("/@" + show + "@/"));
                    
                }
                    
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Title = "My open file dialog";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    autoComplete.Clear();
                    using (StreamReader sr = new StreamReader(openfile.FileName))
                    {
                        GetTokens getTokens = new GetTokens(sr.ReadToEnd());
                        richTextBox1.Text = getTokens.Compile();
                        sr.Close();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
