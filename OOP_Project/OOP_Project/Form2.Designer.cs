namespace QLSV_Win
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            mssv = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            name = new TextBox();
            clas = new TextBox();
            schoolyear = new TextBox();
            label6 = new Label();
            gender = new TextBox();
            phone = new TextBox();
            button1 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(42, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 1;
            label1.Text = "Thông Tin Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "MSSV:";
            label2.Click += label2_Click;
            // 
            // mssv
            // 
            mssv.Location = new Point(97, 85);
            mssv.Margin = new Padding(2, 3, 2, 3);
            mssv.Name = "mssv";
            mssv.Size = new Size(180, 27);
            mssv.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 137);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 137);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 5;
            label4.Text = "Mã Lớp:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 188);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Khóa:";
            // 
            // name
            // 
            name.Location = new Point(97, 131);
            name.Margin = new Padding(2, 3, 2, 3);
            name.Name = "name";
            name.Size = new Size(210, 27);
            name.TabIndex = 7;
            // 
            // clas
            // 
            clas.Location = new Point(465, 135);
            clas.Margin = new Padding(2, 3, 2, 3);
            clas.Name = "clas";
            clas.Size = new Size(161, 27);
            clas.TabIndex = 8;
            // 
            // schoolyear
            // 
            schoolyear.Location = new Point(465, 185);
            schoolyear.Margin = new Padding(2, 3, 2, 3);
            schoolyear.Name = "schoolyear";
            schoolyear.Size = new Size(161, 27);
            schoolyear.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 183);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 10;
            label6.Text = "Giới tính:";
            // 
            // gender
            // 
            gender.Location = new Point(97, 183);
            gender.Margin = new Padding(2, 3, 2, 3);
            gender.Name = "gender";
            gender.Size = new Size(99, 27);
            gender.TabIndex = 12;
            // 
            // phone
            // 
            phone.Location = new Point(97, 229);
            phone.Margin = new Padding(2, 3, 2, 3);
            phone.Name = "phone";
            phone.Size = new Size(219, 27);
            phone.TabIndex = 15;
            phone.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(565, 372);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(128, 56);
            button1.TabIndex = 17;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 231);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 18;
            label7.Text = "Phone:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 496);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(phone);
            Controls.Add(gender);
            Controls.Add(label6);
            Controls.Add(schoolyear);
            Controls.Add(clas);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mssv);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mssv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox clas;
        private System.Windows.Forms.TextBox schoolyear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private Label label7;
    }
}