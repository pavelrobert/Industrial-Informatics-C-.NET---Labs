namespace Ex3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            menuStrip1 = new MenuStrip();
            additionToolStripMenuItem = new ToolStripMenuItem();
            substractionToolStripMenuItem = new ToolStripMenuItem();
            multiplicationToolStripMenuItem = new ToolStripMenuItem();
            divisionToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { additionToolStripMenuItem, substractionToolStripMenuItem, multiplicationToolStripMenuItem, divisionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // additionToolStripMenuItem
            // 
            additionToolStripMenuItem.Name = "additionToolStripMenuItem";
            additionToolStripMenuItem.Size = new Size(81, 24);
            additionToolStripMenuItem.Text = "Addition";
            additionToolStripMenuItem.Click += additionToolStripMenuItem_Click;
            // 
            // substractionToolStripMenuItem
            // 
            substractionToolStripMenuItem.Name = "substractionToolStripMenuItem";
            substractionToolStripMenuItem.Size = new Size(105, 24);
            substractionToolStripMenuItem.Text = "Substraction";
            substractionToolStripMenuItem.Click += substractionToolStripMenuItem_Click;
            // 
            // multiplicationToolStripMenuItem
            // 
            multiplicationToolStripMenuItem.Name = "multiplicationToolStripMenuItem";
            multiplicationToolStripMenuItem.Size = new Size(115, 24);
            multiplicationToolStripMenuItem.Text = "Multiplication";
            multiplicationToolStripMenuItem.Click += multiplicationToolStripMenuItem_Click;
            // 
            // divisionToolStripMenuItem
            // 
            divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            divisionToolStripMenuItem.Size = new Size(76, 24);
            divisionToolStripMenuItem.Text = "Division";
            divisionToolStripMenuItem.Click += divisionToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Number 1:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 119);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Number 2:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 272);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Result:";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem additionToolStripMenuItem;
        private ToolStripMenuItem substractionToolStripMenuItem;
        private ToolStripMenuItem multiplicationToolStripMenuItem;
        private ToolStripMenuItem divisionToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
