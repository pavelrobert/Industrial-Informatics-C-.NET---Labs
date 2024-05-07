namespace Ex1
{
    partial class Form1
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
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.listBox_Fac = new System.Windows.Forms.ListBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_CodeUniv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Entry = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_newUniv = new System.Windows.Forms.TextBox();
            this.textBox_newCity = new System.Windows.Forms.TextBox();
            this.textBox_newCode = new System.Windows.Forms.TextBox();
            this.textBox_newId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.ItemHeight = 16;
            this.listBox_Univ.Location = new System.Drawing.Point(59, 95);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(189, 228);
            this.listBox_Univ.TabIndex = 0;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox_Fac
            // 
            this.listBox_Fac.FormattingEnabled = true;
            this.listBox_Fac.ItemHeight = 16;
            this.listBox_Fac.Location = new System.Drawing.Point(348, 95);
            this.listBox_Fac.Name = "listBox_Fac";
            this.listBox_Fac.Size = new System.Drawing.Size(155, 84);
            this.listBox_Fac.TabIndex = 1;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(348, 218);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(100, 22);
            this.textBox_City.TabIndex = 2;
            // 
            // textBox_CodeUniv
            // 
            this.textBox_CodeUniv.Location = new System.Drawing.Point(348, 273);
            this.textBox_CodeUniv.Name = "textBox_CodeUniv";
            this.textBox_CodeUniv.Size = new System.Drawing.Size(100, 22);
            this.textBox_CodeUniv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Universitati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Facultatii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cod Univ:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // Entry
            // 
            this.Entry.AutoSize = true;
            this.Entry.Location = new System.Drawing.Point(189, 347);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(40, 16);
            this.Entry.TabIndex = 12;
            this.Entry.Text = "Entry:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_newUniv
            // 
            this.textBox_newUniv.Location = new System.Drawing.Point(579, 95);
            this.textBox_newUniv.Name = "textBox_newUniv";
            this.textBox_newUniv.Size = new System.Drawing.Size(100, 22);
            this.textBox_newUniv.TabIndex = 14;
            // 
            // textBox_newCity
            // 
            this.textBox_newCity.Location = new System.Drawing.Point(579, 146);
            this.textBox_newCity.Name = "textBox_newCity";
            this.textBox_newCity.Size = new System.Drawing.Size(100, 22);
            this.textBox_newCity.TabIndex = 15;
            // 
            // textBox_newCode
            // 
            this.textBox_newCode.Location = new System.Drawing.Point(579, 196);
            this.textBox_newCode.Name = "textBox_newCode";
            this.textBox_newCode.Size = new System.Drawing.Size(100, 22);
            this.textBox_newCode.TabIndex = 16;
            // 
            // textBox_newId
            // 
            this.textBox_newId.Location = new System.Drawing.Point(579, 247);
            this.textBox_newId.Name = "textBox_newId";
            this.textBox_newId.Size = new System.Drawing.Size(100, 22);
            this.textBox_newId.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nume nou:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Oras nou:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cod nou:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Id nou:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(502, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_newId);
            this.Controls.Add(this.textBox_newCode);
            this.Controls.Add(this.textBox_newCity);
            this.Controls.Add(this.textBox_newUniv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CodeUniv);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.listBox_Fac);
            this.Controls.Add(this.listBox_Univ);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.ListBox listBox_Fac;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_CodeUniv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Entry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_newUniv;
        private System.Windows.Forms.TextBox textBox_newCity;
        private System.Windows.Forms.TextBox textBox_newCode;
        private System.Windows.Forms.TextBox textBox_newId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

