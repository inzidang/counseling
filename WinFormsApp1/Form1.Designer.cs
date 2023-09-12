namespace WinFormsApp1
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
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label11 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label5 = new Label();
            label10 = new Label();
            label12 = new Label();
            label15 = new Label();
            label16 = new Label();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            label13 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            checkBox6 = new CheckBox();
            label9 = new Label();
            checkBox7 = new CheckBox();
            label14 = new Label();
            checkBox8 = new CheckBox();
            label17 = new Label();
            label18 = new Label();
            checkBox9 = new CheckBox();
            label19 = new Label();
            checkBox10 = new CheckBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            groupBox5 = new GroupBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label25 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox5 = new TextBox();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(28, 83);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1414, 1053);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1406, 1012);
            tabPage1.TabIndex = 0;
            tabPage1.Text = " 상담요청List  ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1406, 1012);
            tabPage2.TabIndex = 1;
            tabPage2.Text = " 상담완료 및 수정  ";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12, Column13 });
            dataGridView2.Location = new Point(18, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1305, 439);
            dataGridView2.TabIndex = 17;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(33, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1341, 504);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = " 상담신청 접수LIst";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox11);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(609, 548);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(765, 428);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "상담자";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(138, 48);
            textBox11.Margin = new Padding(4);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(193, 39);
            textBox11.TabIndex = 20;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(138, 139);
            textBox10.Margin = new Padding(4);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(609, 206);
            textBox10.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(31, 140);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 18;
            label11.Text = "상담내용";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(261, 96);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(113, 32);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "전화상담";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(139, 96);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 32);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "대면상담";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(426, 48);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(234, 39);
            textBox6.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(389, 56);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 25);
            label6.TabIndex = 4;
            label6.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(31, 100);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 8;
            label7.Text = "상담유형";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(50, 54);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 2;
            label8.Text = "상담사";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 60);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 2;
            label4.Text = "상담접수일";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 8;
            label3.Text = "상담요청자";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 213);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 18;
            label1.Text = "문의내용";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(33, 548);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(568, 428);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "문의내용";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(138, 60);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 19;
            label2.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(138, 97);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 20;
            label5.Text = "label5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(333, 97);
            label10.Name = "label10";
            label10.Size = new Size(73, 25);
            label10.TabIndex = 23;
            label10.Text = "label10";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(257, 97);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(69, 25);
            label12.TabIndex = 22;
            label12.Text = "연락처";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(138, 134);
            label15.Name = "label15";
            label15.Size = new Size(73, 25);
            label15.TabIndex = 25;
            label15.Text = "label15";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(62, 134);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(67, 25);
            label16.TabIndex = 24;
            label16.Text = "E-mail";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(468, 171);
            checkBox5.Margin = new Padding(4);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(74, 32);
            checkBox5.TabIndex = 19;
            checkBox5.Text = "기타";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(387, 171);
            checkBox4.Margin = new Padding(4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(74, 32);
            checkBox4.TabIndex = 18;
            checkBox4.Text = "건강";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(306, 171);
            checkBox3.Margin = new Padding(4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(74, 32);
            checkBox3.TabIndex = 17;
            checkBox3.Text = "진로";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(41, 174);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(88, 25);
            label13.TabIndex = 14;
            label13.Text = "문의유형";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(225, 171);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 32);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "주거";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(144, 171);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 32);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "재정";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 213);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 192);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(322, 368);
            button1.Name = "button1";
            button1.Size = new Size(186, 44);
            button1.TabIndex = 21;
            button1.Text = "상담 완료";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1067, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 44);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, Column14, Column15, Column16, Column17 });
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1394, 468);
            dataGridView1.TabIndex = 17;
            // 
            // Column7
            // 
            Column7.HeaderText = "No.";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "접수일";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // Column9
            // 
            Column9.HeaderText = "상담요청자";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 140;
            // 
            // Column10
            // 
            Column10.HeaderText = "연락처";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 200;
            // 
            // Column11
            // 
            Column11.HeaderText = "e-mail";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 200;
            // 
            // Column12
            // 
            Column12.HeaderText = "문의유형";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 150;
            // 
            // Column13
            // 
            Column13.HeaderText = "문의내용";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 300;
            // 
            // Column17
            // 
            Column17.HeaderText = "상담내용";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.Width = 300;
            // 
            // Column16
            // 
            Column16.HeaderText = "상담유형";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.Width = 125;
            // 
            // Column15
            // 
            Column15.HeaderText = "ID";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.Width = 150;
            // 
            // Column14
            // 
            Column14.HeaderText = "상담사";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "문의내용";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "문의유형";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "e-mail";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "연락처";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "상담요청자";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "접수일";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "No.";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(checkBox6);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(checkBox7);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(checkBox8);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(checkBox9);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(checkBox10);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(label24);
            groupBox4.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(31, 506);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(543, 477);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "문의내용";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 213);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(397, 256);
            textBox2.TabIndex = 21;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(469, 172);
            checkBox6.Margin = new Padding(4);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(74, 32);
            checkBox6.TabIndex = 19;
            checkBox6.Text = "기타";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(139, 135);
            label9.Name = "label9";
            label9.Size = new Size(63, 25);
            label9.TabIndex = 25;
            label9.Text = "label9";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(388, 172);
            checkBox7.Margin = new Padding(4);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(74, 32);
            checkBox7.TabIndex = 18;
            checkBox7.Text = "건강";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(63, 135);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(67, 25);
            label14.TabIndex = 24;
            label14.Text = "E-mail";
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox8.Location = new Point(307, 172);
            checkBox8.Margin = new Padding(4);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(74, 32);
            checkBox8.TabIndex = 17;
            checkBox8.Text = "진로";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(334, 98);
            label17.Name = "label17";
            label17.Size = new Size(73, 25);
            label17.TabIndex = 23;
            label17.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(42, 175);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(88, 25);
            label18.TabIndex = 14;
            label18.Text = "문의유형";
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox9.Location = new Point(226, 172);
            checkBox9.Margin = new Padding(4);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(74, 32);
            checkBox9.TabIndex = 16;
            checkBox9.Text = "주거";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(258, 98);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(69, 25);
            label19.TabIndex = 22;
            label19.Text = "연락처";
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox10.Location = new Point(145, 172);
            checkBox10.Margin = new Padding(4);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(74, 32);
            checkBox10.TabIndex = 15;
            checkBox10.Text = "재정";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(139, 98);
            label20.Name = "label20";
            label20.Size = new Size(73, 25);
            label20.TabIndex = 20;
            label20.Text = "label20";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(139, 61);
            label21.Name = "label21";
            label21.Size = new Size(73, 25);
            label21.TabIndex = 19;
            label21.Text = "label21";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(42, 214);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(88, 25);
            label22.TabIndex = 18;
            label22.Text = "문의내용";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(23, 98);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(107, 25);
            label23.TabIndex = 8;
            label23.Text = "상담요청자";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(23, 61);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(107, 25);
            label24.TabIndex = 2;
            label24.Text = "상담접수일";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(label25);
            groupBox5.Controls.Add(radioButton3);
            groupBox5.Controls.Add(radioButton4);
            groupBox5.Controls.Add(textBox5);
            groupBox5.Controls.Add(label26);
            groupBox5.Controls.Add(label27);
            groupBox5.Controls.Add(label28);
            groupBox5.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(607, 506);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(765, 428);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "상담자";
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(895, 947);
            button2.Name = "button2";
            button2.Size = new Size(186, 44);
            button2.TabIndex = 21;
            button2.Text = "상담 수정";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 48);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 39);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 139);
            textBox4.Margin = new Padding(4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(619, 281);
            textBox4.TabIndex = 19;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(32, 141);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(88, 25);
            label25.TabIndex = 18;
            label25.Text = "상담내용";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(262, 97);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(113, 32);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "전화상담";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(140, 97);
            radioButton4.Margin = new Padding(4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(113, 32);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "대면상담";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(426, 48);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 39);
            textBox5.TabIndex = 5;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(390, 57);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(31, 25);
            label26.TabIndex = 4;
            label26.Text = "ID";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(32, 101);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(88, 25);
            label27.TabIndex = 8;
            label27.Text = "상담유형";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(51, 55);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(69, 25);
            label28.TabIndex = 2;
            label28.Text = "상담사";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 1159);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(21, 80, 21, 20);
            SizeGripStyle = SizeGripStyle.Show;
            Text = "자립준비청년 상담관리";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label11;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label15;
        private Label label16;
        private Label label10;
        private Label label12;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label label13;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private Button button2;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private CheckBox checkBox6;
        private Label label9;
        private CheckBox checkBox7;
        private Label label14;
        private CheckBox checkBox8;
        private Label label17;
        private Label label18;
        private CheckBox checkBox9;
        private Label label19;
        private CheckBox checkBox10;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private GroupBox groupBox5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label25;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox5;
        private Label label26;
        private Label label27;
        private Label label28;
    }
}