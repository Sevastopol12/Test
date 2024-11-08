namespace oop_winform
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button5 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Khóa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 157);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "Kết quả tìm kiếm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(747, 12);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(228, 29);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm thông tin";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column9, Column10, Column5, Column4, Column6, Column8, Column7, Khóa });
            dataGridView1.Location = new Point(16, 187);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(942, 513);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 11);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 5;
            label3.Text = "Thông tin sinh viên:";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mã số sinh viên", "Mã lớp", "Mã học phần", "Mã khoa" });
            comboBox2.Location = new Point(16, 40);
            comboBox2.Margin = new Padding(5, 4, 5, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(134, 25);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Mã số sinh viên";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 40);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(414, 36);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 36);
            button1.TabIndex = 8;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(9, 81);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(143, 68);
            button2.TabIndex = 9;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 80);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(143, 68);
            button3.TabIndex = 10;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(311, 81);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(143, 68);
            button4.TabIndex = 11;
            button4.Text = "Cập Nhật";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tên", "Khóa", "GPA", "ĐRL" });
            comboBox1.Location = new Point(883, 155);
            comboBox1.Margin = new Padding(5, 4, 5, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(71, 28);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Tên";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(794, 161);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 13;
            label4.Text = "Sắp xếp theo";
            // 
            // button5
            // 
            button5.Location = new Point(463, 80);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(143, 68);
            button5.TabIndex = 14;
            button5.Text = "Danh sách sinh viên";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "MSSV";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 45;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Gender";
            Column3.HeaderText = "Giới tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Email";
            Column9.HeaderText = "Email";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 200;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "Phonenumber";
            Column10.HeaderText = "SĐT";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ClassID";
            Column5.HeaderText = "Mã lớp";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 45;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Birthday";
            Column4.HeaderText = "Ngày sinh";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 60;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DepartmentID";
            Column6.HeaderText = "Mã Khoa";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "GPA";
            Column8.HeaderText = "GPA";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 40;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "DRL";
            Column7.HeaderText = "ĐRL";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 40;
            // 
            // Khóa
            // 
            Khóa.DataPropertyName = "SchoolYear";
            Khóa.HeaderText = "Khóa";
            Khóa.MinimumWidth = 6;
            Khóa.Name = "Khóa";
            Khóa.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 715);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private Button button5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Khóa;
    }
}

