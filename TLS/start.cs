using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLS.Siniflar;

namespace TLS
{
    public partial class start : Form
    { 
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            try
            {
                this.ctrl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void prbar()
        {
            this.progressBar1.Value += 1;
        }

        private void ctrl()
        {
            this.progressBar1.Maximum = 4;
            this.progressBar1.Value = 0;
            this.lblAciklama.Text = ".Net Framework ayarları okunuyor ...";
            this.prbar();
            this.lblAciklama.Text = ".Net Framework ayarları okunuyor (32 bit) ...";
            List<object> win32 = new List<object>();
            List<object> win64 = new List<object>();
            try
            {
                win32 = KayitDefteri.anahtarlariGetir(@"SOFTWARE\WOW6432Node\Microsoft\.NETFramework", KayitDefteri.makineOrtam.mevcutMakine, KayitDefteri.mimari.win32, "v");
                
            }
            catch (Exception ex)
            {

            }
            this.prbar();
            this.lblAciklama.Text = ".Net Framework ayarları okunuyor (64 bit) ...";
            try
            {
                win64 = KayitDefteri.anahtarlariGetir(@"SOFTWARE\Microsoft\.NETFramework", KayitDefteri.makineOrtam.mevcutMakine, KayitDefteri.mimari.win64, "v");
                
            }
            catch (Exception ex)
            {
            }
            this.prbar();
            this.lblAciklama.Text = "Nesneler yükleniyor ....";
            this.prbar();
            new TLS(win32, win64).ShowDialog();
            this.Hide();
        }
    }
}
