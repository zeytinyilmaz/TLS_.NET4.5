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
    public partial class TLS : Form
    {
        private List<object> win32, win64;
        public TLS()
        {
            InitializeComponent();
        }
        public TLS(List<object> win32, List<object> win64)
        {
            InitializeComponent();
            this.win32 = win32;
            this.win64 = win64;
            this.BackColor = Color.White;
        }

        private void TLS_Load(object sender, EventArgs e)
        {
            loadList();
        }

        void loadList()
        {
            listView1.CheckBoxes = true;

            #region 32 Bit
            foreach (var item in this.win32)
            {
                ListViewItem listViewItem1 = new ListViewItem();
                listViewItem1.SubItems.Add(item.ToString());
                listViewItem1.SubItems.Add("32 Bit (x86)");
                listView1.Items.Add(listViewItem1);
            }
            #endregion
            #region 64 Bit
            foreach (var item in this.win64)
            {
                ListViewItem listViewItem1 = new ListViewItem();
                listViewItem1.SubItems.Add(item.ToString());
                listViewItem1.SubItems.Add("64 Bit (x64)");
                listView1.Items.Add(listViewItem1);
            }
            #endregion
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            DialogResult meg = MessageBox.Show("Ayarlar Kaydedilecek. Uygulansın mı? \n(Windows ayarlarınızda değişiklik uygulanacaktır.)", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == meg)
            {
                ayarlariUygula();
            }
            else
            {
                MessageBox.Show("İşlem şptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TLS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnUygula_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult meg = MessageBox.Show("Ayarlar Kaydedilecek. Uygulansın mı? \n(Windows ayarlarınızda değişiklik uygulanacaktır.)", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == meg)
                {
                    ayarlariUygula();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ayarlariUygula()
        {
            string konum;
            int deger = (rdbDisabled.Checked) ? 0 : 1;
            this.progressBar1.Maximum = listView1.CheckedItems.Count;
            this.progressBar1.Value = 0;
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                var versiyon = item.SubItems[1].Text;
                
                if (item.SubItems[2].Text != "64 Bit (x64)")
                {
                    konum = (string)@"SOFTWARE\WOW6432Node\Microsoft\.NETFramework\" + versiyon;
                }
                else
                {
                    konum = (string)@"SOFTWARE\Microsoft\.NETFramework\" + versiyon;
                }

                KayitDefteri.anahtarGuncelle(konum, "SchUseStrongCrypto", deger, KayitDefteri.deger.REG_DWORD, KayitDefteri.makineOrtam.mevcutMakine);
                this.progressBar1.Value += 1;
            }
            MessageBox.Show("İşlam tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
