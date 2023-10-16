using System.Windows.Forms;

namespace Dekstop_Datagridview
{
    public partial class Form1 : Form
    {
        List<PNS> listPNS = new List<PNS>();
        public Form1()
        {
            InitializeComponent();

            PNS pns1 = new PNS();
            pns1.nama = "Jetro";
            pns1.nip = 222410101064;
            pns1.gaji = 2000000;
            pns1.tanggalLahir = new DateOnly(2004, 05, 17);
            pns1.tempatLahir = "Metro";
            pns1.bidang = "Agrikultur";
            pns1.noTelp = "081221389123";

            PNS pns2 = new PNS();
            pns2.nama = "Fariq";
            pns2.nip = 222410101069;
            pns2.gaji = 2500000;
            pns2.tanggalLahir = new DateOnly(2003, 07, 22);
            pns2.tempatLahir = "lUMPUR";
            pns2.bidang = "Agrikultur";
            pns2.noTelp = "081226669135";

            PNS pns3 = new PNS();
            pns3.nama = "Rafi";
            pns3.nip = 222410101087;
            pns3.gaji = 2000;
            pns3.tanggalLahir = new DateOnly(2003, 08, 11);
            pns3.tempatLahir = "Banyuwangi";
            pns3.bidang = "Kesehatan";
            pns3.noTelp = "0812266699099";

            PNS pns4 = new PNS();
            pns4.nama = "Fatimah";
            pns4.nip = 222410101054;
            pns4.gaji = 500;
            pns4.tanggalLahir = new DateOnly(2004, 11, 11);
            pns4.tempatLahir = "Sidoarjo";
            pns4.bidang = "Ekonomi";
            pns4.noTelp = "0821333698009";

            PNS pns5 = new PNS();
            pns5.nama = "FAUNA";
            pns5.nip = 222410101067;
            pns5.gaji = 99999999999;
            pns5.tanggalLahir = new DateOnly(2003, 12, 13);
            pns5.tempatLahir = "Kudus";
            pns5.bidang = "Pariwisara";
            pns5.noTelp = "08970861118";

            dataGridView1.Rows.Add(pns1.nama, pns1.nip, pns1.gaji, pns1.tanggalLahir, pns1.tempatLahir, pns1.bidang, pns1.noTelp);
            dataGridView1.Rows.Add(pns2.nama, pns2.nip, pns2.gaji, pns2.tanggalLahir, pns2.tempatLahir, pns2.bidang, pns2.noTelp);
            dataGridView1.Rows.Add(pns3.nama, pns3.nip, pns3.gaji, pns3.tanggalLahir, pns3.tempatLahir, pns3.bidang, pns3.noTelp);
            dataGridView1.Rows.Add(pns4.nama, pns4.nip, pns4.gaji, pns4.tanggalLahir, pns4.tempatLahir, pns4.bidang, pns4.noTelp);
            dataGridView1.Rows.Add(pns5.nama, pns5.nip, pns5.gaji, pns5.tanggalLahir, pns5.tempatLahir, pns5.bidang, pns5.noTelp);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (FormDataBaru frmDataBaru = new FormDataBaru())
            {
                if (frmDataBaru.ShowDialog() == DialogResult.OK)
                {
                    PNS pns_baru = frmDataBaru.GetPNS();
                    dataGridView1.Rows.Add(pns_baru.nama, pns_baru.nip, pns_baru.gaji, pns_baru.tanggalLahir, pns_baru.tempatLahir, pns_baru.bidang, pns_baru.noTelp);
                    frmDataBaru.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    public class PNS
    {
        public string nama { get; set; }
        public long nip { get; set; }
        public long gaji { get; set; }
        public DateOnly tanggalLahir { get; set; }
        public string tempatLahir { get; set; }
        public string bidang { get; set; }
        public string noTelp { get; set; }

    }
}