﻿
namespace Scanner1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripButton = new System.Windows.Forms.Button();
            this.pasteToolStripButton = new System.Windows.Forms.Button();
            this.copyToolStripButton = new System.Windows.Forms.Button();
            this.cutToolStripButton = new System.Windows.Forms.Button();
            this.saveToolStripButton = new System.Windows.Forms.Button();
            this.openToolStripButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.Comment = new System.Windows.Forms.Button();
            this.NotComment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(603, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(702, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Location = new System.Drawing.Point(0, 0);
            this.newToolStripButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.newToolStripButton.TabIndex = 4;
            this.newToolStripButton.Text = "Clear";
            this.newToolStripButton.UseVisualStyleBackColor = true;
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.Location = new System.Drawing.Point(249, 0);
            this.pasteToolStripButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.pasteToolStripButton.TabIndex = 5;
            this.pasteToolStripButton.Text = "Paste";
            this.pasteToolStripButton.UseVisualStyleBackColor = true;
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Location = new System.Drawing.Point(198, 0);
            this.copyToolStripButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.copyToolStripButton.TabIndex = 6;
            this.copyToolStripButton.Text = "Copy";
            this.copyToolStripButton.UseVisualStyleBackColor = true;
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Location = new System.Drawing.Point(155, 0);
            this.cutToolStripButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(38, 22);
            this.cutToolStripButton.TabIndex = 7;
            this.cutToolStripButton.Text = "Cut";
            this.cutToolStripButton.UseVisualStyleBackColor = true;
            this.cutToolStripButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Location = new System.Drawing.Point(108, 0);
            this.saveToolStripButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(42, 22);
            this.saveToolStripButton.TabIndex = 8;
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.UseVisualStyleBackColor = true;
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Location = new System.Drawing.Point(54, 0);
            this.openToolStripButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.openToolStripButton.TabIndex = 9;
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.UseVisualStyleBackColor = true;
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(302, 0);
            this.undoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(48, 22);
            this.undoButton.TabIndex = 10;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(355, 0);
            this.selectAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(78, 22);
            this.selectAllButton.TabIndex = 12;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(438, 1);
            this.Comment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(77, 22);
            this.Comment.TabIndex = 13;
            this.Comment.Text = "Comment";
            this.Comment.UseVisualStyleBackColor = true;
            this.Comment.Click += new System.EventHandler(this.Comment_Click);
            // 
            // NotComment
            // 
            this.NotComment.Location = new System.Drawing.Point(521, 0);
            this.NotComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotComment.Name = "NotComment";
            this.NotComment.Size = new System.Drawing.Size(106, 22);
            this.NotComment.TabIndex = 14;
            this.NotComment.Text = "uncomment";
            this.NotComment.UseVisualStyleBackColor = true;
            this.NotComment.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(747, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 22);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 217);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(102, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel1.Text = "lineandcolumn";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 27);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 23);
            this.textBox3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Find";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(230, 27);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 23);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Replace";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 27);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 22);
            this.button3.TabIndex = 23;
            this.button3.Text = "Run Replacement";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Yesif",
            "Otherwise",
            "Omw",
            "SIMww",
            "Chji",
            "Seriestl",
            "IMwf",
            "SIMwf",
            "NOReturn",
            "RepeatWhen",
            "Reiterate",
            "GetBack",
            "OutLoop",
            "Loli",
            "Include",
            "Start",
            "Last",
            "/^",
            "@/",
            "/@",
            "“,’",
            "->"});
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(0, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(794, 164);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 242);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(791, 96);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 338);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.NotComment);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.openToolStripButton);
            this.Controls.Add(this.saveToolStripButton);
            this.Controls.Add(this.cutToolStripButton);
            this.Controls.Add(this.copyToolStripButton);
            this.Controls.Add(this.pasteToolStripButton);
            this.Controls.Add(this.newToolStripButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Compiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button newToolStripButton;
        private System.Windows.Forms.Button pasteToolStripButton;
        private System.Windows.Forms.Button copyToolStripButton;
        private System.Windows.Forms.Button cutToolStripButton;
        private System.Windows.Forms.Button saveToolStripButton;
        private System.Windows.Forms.Button openToolStripButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button Comment;
        private System.Windows.Forms.Button NotComment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

