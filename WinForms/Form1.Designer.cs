namespace WinForms
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
            button1 = new Button();
            listView1 = new ListView();
            textBox1 = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            richTextBox1 = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(360, 105);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(103, 22);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(7, 6);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(205, 503);
            listView1.TabIndex = 1;
            listView1.Columns.Add("First Column Title");
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 54);
            label1.TabIndex = 3;
            label1.Text = "Form details";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(223, 172);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(314, 172);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(403, 172);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(223, 226);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(326, 226);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(426, 226);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(226, 261);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(294, 96);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(226, 390);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" });
            comboBox1.Location = new Point(226, 428);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(226, 473);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 154);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 14;
            label2.Text = "Select your preferences:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 208);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 15;
            label3.Text = "Select your preference:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 520);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RichTextBox richTextBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}