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
            btnTambah.Location = new Point(351, 397);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambah);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
    }
}