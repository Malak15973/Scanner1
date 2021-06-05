﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Collections;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Loader;

namespace Scanner1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
      
        public int line = 0;
        public int column = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            GetTokens getTokens = new GetTokens(textBox2.Text);
            richTextBox1.Text = getTokens.Compile();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
        }
 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Cut();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
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
           
            if(textBox2.SelectedText.Length == 0)
            {

            }
            else
            {
                string show = textBox2.SelectedText;
                string temp = show;
                int Number_in_section = CountLines(show);
                string str = temp.Remove(0, 2);
                if (Number_in_section == 1 && show.StartsWith("/^"))
                    textBox2.Text = textBox2.Text.Replace(show, show.Remove(0, 2));
                else if (Number_in_section != 1 && (show.StartsWith("/@") && show.EndsWith("@/")))
                {
                    textBox2.Text = textBox2.Text.Replace(show, str.Remove(str.Length - 2, 2));

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
                    textBox2.Clear();
                    using (StreamReader sr = new StreamReader(openfile.FileName))
                    {
                        textBox2.Text = sr.ReadToEnd();
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
                txtoutput.Write(textBox2.Text);
                txtoutput.Close();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            textBox2.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            textBox2.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            line = 1 + textBox2.GetLineFromCharIndex(textBox2.GetFirstCharIndexOfCurrentLine());
            column = 1 + textBox2.SelectionStart - textBox2.GetFirstCharIndexOfCurrentLine();
            toolStripStatusLabel1.Text = "line: " + line.ToString() + " | column: " + column.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (textBox3.Text != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox4.Text != null && !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox2.Text = textBox2.Text.Replace(textBox3.Text, textBox4.Text);
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
            string show = textBox2.SelectedText;
            
            
            if (textBox2.SelectedText.Length ==  0 )
            { 
            }
            //else if (textBox2.Text.Contains("/^") || textBox2.Text.Contains("/@") || textBox2.Text.Contains("@/"))
            //{ 
            //}
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
                        textBox2.Text = textBox2.Text.Replace(show, ("/^" + show));
                }

                else
                {
                    textBox2.Text = textBox2.Text.Replace(show, ("/@" + show + "@/"));
                    
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
                    textBox2.Clear();
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
    }
}
