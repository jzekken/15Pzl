namespace PrelimApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            showSolutionToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            musicToolStripMenuItem = new ToolStripMenuItem();
            easyToolStripMenuItem = new ToolStripMenuItem();
            hardToolStripMenuItem = new ToolStripMenuItem();
            othersToolStripMenuItem = new ToolStripMenuItem();
            aboutTheGameToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pauseToolStripMenuItem1 = new ToolStripMenuItem();
            resetToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, musicToolStripMenuItem, othersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, pauseToolStripMenuItem, resetToolStripMenuItem, showSolutionToolStripMenuItem, exitToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(62, 24);
            gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(187, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(187, 26);
            pauseToolStripMenuItem.Text = "Pause";
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(187, 26);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // showSolutionToolStripMenuItem
            // 
            showSolutionToolStripMenuItem.Name = "showSolutionToolStripMenuItem";
            showSolutionToolStripMenuItem.Size = new Size(187, 26);
            showSolutionToolStripMenuItem.Text = "Show Solution";
            showSolutionToolStripMenuItem.Click += showSolutionToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(187, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // musicToolStripMenuItem
            // 
            musicToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { easyToolStripMenuItem, hardToolStripMenuItem });
            musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            musicToolStripMenuItem.Size = new Size(83, 24);
            musicToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            easyToolStripMenuItem.Size = new Size(125, 26);
            easyToolStripMenuItem.Text = "Easy";
            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            // 
            // hardToolStripMenuItem
            // 
            hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            hardToolStripMenuItem.Size = new Size(125, 26);
            hardToolStripMenuItem.Text = "Hard";
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;
            // 
            // othersToolStripMenuItem
            // 
            othersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutTheGameToolStripMenuItem });
            othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            othersToolStripMenuItem.Size = new Size(66, 24);
            othersToolStripMenuItem.Text = "Others";
            // 
            // aboutTheGameToolStripMenuItem
            // 
            aboutTheGameToolStripMenuItem.Name = "aboutTheGameToolStripMenuItem";
            aboutTheGameToolStripMenuItem.Size = new Size(201, 26);
            aboutTheGameToolStripMenuItem.Text = "About the Game";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 421);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 171);
            label1.Name = "label1";
            label1.Size = new Size(365, 106);
            label1.TabIndex = 2;
            label1.Text = "00:00:00";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(356, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(405, 145);
            textBox1.TabIndex = 1;
            // 
            // button16
            // 
            button16.BackColor = Color.MistyRose;
            button16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button16.Location = new Point(254, 266);
            button16.Name = "button16";
            button16.Size = new Size(75, 75);
            button16.TabIndex = 0;
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.MistyRose;
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button15.Location = new Point(173, 266);
            button15.Name = "button15";
            button15.Size = new Size(75, 75);
            button15.TabIndex = 0;
            button15.Text = "15";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.MistyRose;
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button14.Location = new Point(92, 266);
            button14.Name = "button14";
            button14.Size = new Size(75, 75);
            button14.TabIndex = 0;
            button14.Text = "14";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.MistyRose;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button13.Location = new Point(11, 266);
            button13.Name = "button13";
            button13.Size = new Size(75, 75);
            button13.TabIndex = 0;
            button13.Text = "13";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.MistyRose;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button12.Location = new Point(254, 185);
            button12.Name = "button12";
            button12.Size = new Size(75, 75);
            button12.TabIndex = 0;
            button12.Text = "12";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.MistyRose;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button11.Location = new Point(173, 185);
            button11.Name = "button11";
            button11.Size = new Size(75, 75);
            button11.TabIndex = 0;
            button11.Text = "11";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.MistyRose;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button10.Location = new Point(92, 185);
            button10.Name = "button10";
            button10.Size = new Size(75, 75);
            button10.TabIndex = 0;
            button10.Text = "10";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.MistyRose;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button9.Location = new Point(11, 185);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 0;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.MistyRose;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button8.Location = new Point(254, 104);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 0;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.MistyRose;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.Location = new Point(173, 104);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 0;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MistyRose;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.Location = new Point(92, 104);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 0;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(11, 104);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 0;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(254, 23);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 0;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(173, 23);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 0;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(92, 23);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 0;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(11, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { pauseToolStripMenuItem1, resetToolStripMenuItem1, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(116, 76);
            // 
            // pauseToolStripMenuItem1
            // 
            pauseToolStripMenuItem1.Name = "pauseToolStripMenuItem1";
            pauseToolStripMenuItem1.Size = new Size(115, 24);
            pauseToolStripMenuItem1.Text = "Pause";
            pauseToolStripMenuItem1.Click += pauseToolStripMenuItem1_Click;
            // 
            // resetToolStripMenuItem1
            // 
            resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            resetToolStripMenuItem1.Size = new Size(115, 24);
            resetToolStripMenuItem1.Text = "Reset";
            resetToolStripMenuItem1.Click += resetToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(115, 24);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "15 Puzzle";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem showSolutionToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem musicToolStripMenuItem;
        private ToolStripMenuItem othersToolStripMenuItem;
        private ToolStripMenuItem aboutTheGameToolStripMenuItem;
        private Panel panel1;
        private Button button1;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem hardToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pauseToolStripMenuItem1;
        private ToolStripMenuItem resetToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}
