using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_Datagridview
{
    public partial class FormDataBaru : Form
    {
        public FormDataBaru()
        {
            InitializeComponent();

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public PNS GetPNS()
        {
            PNS pns1 = new PNS();
            pns1.nama = tbNama.Text;
            pns1.nip = long.Parse(tbNip.Text);
            pns1.gaji = long.Parse(tbGaji.Text);
            pns1.tanggalLahir = DateOnly.Parse(dateTimePicker1.Value.ToShortDateString());
            pns1.tempatLahir = tbTanggal.Text;
            pns1.bidang = cbBidang.Text;
            pns1.noTelp = tbTelp.Text;
            return pns1;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLuas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDataBaru_Load(object sender, EventArgs e)
        {

        }
    }
}
