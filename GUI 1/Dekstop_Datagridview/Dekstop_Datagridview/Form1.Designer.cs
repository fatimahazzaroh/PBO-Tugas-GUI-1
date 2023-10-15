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
            btnTambah = new Button();
            Nama = new DataGridViewTextBoxColumn();
            NIP = new DataGridViewTextBoxColumn();
            Gaji = new DataGridViewTextBoxColumn();
            TanggalLahir = new DataGridViewTextBoxColumn();
            TempatLahir = new DataGridViewTextBoxColumn();
            Bidang = new DataGridViewTextBoxColumn();
            noTelp = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nama, NIP, Gaji, TanggalLahir, TempatLahir, Bidang, noTelp });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(766, 350);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.Name = "Nama";
            // 
            // NIP
            // 
            NIP.HeaderText = "NIP";
            NIP.Name = "NIP";
            // 
            // Gaji
            // 
            Gaji.HeaderText = "Gaji";
            Gaji.Name = "Gaji";
            // 
            // TanggalLahir
            // 
            TanggalLahir.HeaderText = "Tanggal Lahir";
            TanggalLahir.Name = "TanggalLahir";
            // 
            // TempatLahir
            // 
            TempatLahir.HeaderText = "Tempat Lahir";
            TempatLahir.Name = "TempatLahir";
            // 
            // Bidang
            // 
            Bidang.HeaderText = "Bidang";
            Bidang.Name = "Bidang";
            // 
            // noTelp
            // 
            noTelp.HeaderText = "No. Telepon";
            noTelp.Name = "noTelp";
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