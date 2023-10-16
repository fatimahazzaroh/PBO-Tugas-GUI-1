namespace Dekstop_Datagridview
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
            dataGridView1 = new DataGridView();
            Nama = new DataGridViewTextBoxColumn();
            NIP = new DataGridViewTextBoxColumn();
            Gaji = new DataGridViewTextBoxColumn();
            TanggalLahir = new DataGridViewTextBoxColumn();
            TempatLahir = new DataGridViewTextBoxColumn();
            Bidang = new DataGridViewTextBoxColumn();
            noTelp = new DataGridViewTextBoxColumn();
            btnTambah = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nama, NIP, Gaji, TanggalLahir, TempatLahir, Bidang, noTelp });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(766, 350);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 10;
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            Nama.Width = 200;
            // 
            // NIP
            // 
            NIP.HeaderText = "NIP";
            NIP.MinimumWidth = 10;
            NIP.Name = "NIP";
            NIP.ReadOnly = true;
            NIP.Width = 200;
            // 
            // Gaji
            // 
            Gaji.HeaderText = "Gaji";
            Gaji.MinimumWidth = 10;
            Gaji.Name = "Gaji";
            Gaji.ReadOnly = true;
            Gaji.Width = 200;
            // 
            // TanggalLahir
            // 
            TanggalLahir.HeaderText = "Tanggal Lahir";
            TanggalLahir.MinimumWidth = 10;
            TanggalLahir.Name = "TanggalLahir";
            TanggalLahir.ReadOnly = true;
            TanggalLahir.Width = 200;
            // 
            // TempatLahir
            // 
            TempatLahir.HeaderText = "Tempat Lahir";
            TempatLahir.MinimumWidth = 10;
            TempatLahir.Name = "TempatLahir";
            TempatLahir.ReadOnly = true;
            TempatLahir.Width = 200;
            // 
            // Bidang
            // 
            Bidang.HeaderText = "Bidang";
            Bidang.MinimumWidth = 10;
            Bidang.Name = "Bidang";
            Bidang.ReadOnly = true;
            Bidang.Width = 200;
            // 
            // noTelp
            // 
            noTelp.HeaderText = "No. Telepon";
            noTelp.MinimumWidth = 10;
            noTelp.Name = "noTelp";
            noTelp.ReadOnly = true;
            noTelp.Width = 200;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(681, 406);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 370);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 399);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 399);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 370);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(28, 422);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 23);
            textBox5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 373);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 8;
            label1.Text = "Fatimah Azzaroh (222410101054)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 402);
            label2.Name = "label2";
            label2.Size = new Size(173, 15);
            label2.TabIndex = 9;
            label2.Text = "Jetro Sulthan F.  (222410101064)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 425);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 10;
            label3.Text = "Neifa Ulil L. (222410101067)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 373);
            label4.Name = "label4";
            label4.Size = new Size(171, 15);
            label4.TabIndex = 11;
            label4.Text = "Fariq Abdhe M. (222410101069)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 402);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 12;
            label5.Text = "Rafi Jauhari (222410101087)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnTambah);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTambah;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn NIP;
        private DataGridViewTextBoxColumn Gaji;
        private DataGridViewTextBoxColumn TanggalLahir;
        private DataGridViewTextBoxColumn TempatLahir;
        private DataGridViewTextBoxColumn Bidang;
        private DataGridViewTextBoxColumn noTelp;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}