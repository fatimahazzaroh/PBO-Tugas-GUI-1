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
            pns1.tempatLahir = "Metro P";
            pns1.bidang = "Agrikultur";
            pns1.noTelp = "081221389123";

            PNS pns2 = new PNS();
            pns2.nama = "FAREK";
            pns2.nip = 222410101067;
            pns2.gaji = 2000000;
            pns2.tanggalLahir = new DateOnly(2008, 07, 22);
            pns2.tempatLahir = "lUMPUR";
            pns2.bidang = "Agrikultur";
            pns2.noTelp = "081226669123";

            PNS pns3 = new PNS();
            pns3.nama = "Rapijo";
            pns3.nip = 222410101087;
            pns3.gaji = 2000;
            pns3.tanggalLahir = new DateOnly(2000, 08, 11);
            pns3.tempatLahir = "Banyuwangi";
            pns3.bidang = "Agrikultur";
            pns3.noTelp = "0812266699099";

            dataGridView1.Rows.Add(pns1.nama, pns1.nip, pns1.gaji, pns1.tanggalLahir, pns1.tempatLahir, pns1.bidang, pns1.noTelp);
            dataGridView1.Rows.Add(pns2.nama, pns2.nip, pns2.gaji, pns2.tanggalLahir, pns2.tempatLahir, pns2.bidang, pns2.noTelp);
            dataGridView1.Rows.Add(pns3.nama, pns3.nip, pns3.gaji, pns3.tanggalLahir, pns3.tempatLahir, pns3.bidang, pns3.noTelp);
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