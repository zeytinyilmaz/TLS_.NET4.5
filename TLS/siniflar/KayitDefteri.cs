using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLS.Siniflar
{

    static class KayitDefteri
    {
        /*
         İlgili sınıf yalnızca mevcut kullanıcı ve osu kullanan diğer kullanıcıları ilgilendiren işlemleri kapsayacağı için ortam kısmında 
         yalnızca mevcut kullanıcı ve cihaz baz alınmıştur.
        Silme ve ekleme işlemine ihtiyaç olmadığı için anahtar silme ile ekleme blokları eklenmemiştir. Yalnızca güncelleme işlemi amaçlanmıştır.
         */
        public enum makineOrtam
        {
            mevcutMakine,
            mevcutKullanici
        }

        public enum mimari
        {
            win32,
            win64
        }

        public enum deger
        {
            REG_SZ,
            REG_BINARY,
            REG_DWORD,
            REG_MULTI_SZ,
            REG_EXPAND_SZ
        }

        public static RegistryKey AnahtarGetir_alt(string konum, makineOrtam makine, bool degisiklikYapilabilir = false)
        {
            RegistryKey kayıtAnahari;
            if (makine == makineOrtam.mevcutMakine)
            {
                kayıtAnahari = Registry.LocalMachine.OpenSubKey(name: konum, writable: degisiklikYapilabilir);
            }
            else
            {
                kayıtAnahari = Registry.CurrentUser.OpenSubKey(name: konum, writable: degisiklikYapilabilir);
            }
            return kayıtAnahari;
        }

        public static object anahtarDegeriniAl(RegistryKey anahtar)
        {
            if (anahtar == null)
            {
                throw new Exception("Anahtar değeri bulunamadı!");
            }

            return null;
        }

        public static bool kayitVarmi(string konum, string veri)
        {
            List<object> anahtarListesi = new List<object>();
            using (RegistryKey anahtar = Registry.LocalMachine.OpenSubKey(konum))
            {
                if (anahtar != null)
                {
                    if (anahtar.GetValue(veri) != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public static void anahtarGuncelle(string konum, string anahtar, object yenideger, deger deger, makineOrtam ortam)
        {
            RegistryKey registryKey = KayitDefteri.AnahtarGetir_alt(konum, ortam, true);
            registryKey.SetValue(anahtar, yenideger);
            registryKey.Flush();
        }

        public static List<object> anahtarlariGetir(string konum, makineOrtam ortam, mimari osMimari, string baslayan = null)
        {
            List<object> liste = new List<object>();

            RegistryKey anaAnahtarlar;
            RegistryView mimarisi = osMimari == mimari.win32 ? RegistryView.Registry32 : RegistryView.Registry64;

            if (ortam == makineOrtam.mevcutMakine)
            {
                anaAnahtarlar = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, mimarisi);
            }
            else
            {
                anaAnahtarlar = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, mimarisi);
            }

            if (anaAnahtarlar != null)
            {
                RegistryKey altAnahtar = anaAnahtarlar.OpenSubKey(konum, true);
                foreach (var item in altAnahtar.GetSubKeyNames())
                { 
                    if (baslayan != null)
                    {
                        if (item.StartsWith(baslayan))
                        {
                            liste.Add(item);
                        }
                        
                    }
                    else
                    {
                        liste.Add(item);
                    }

                }
            }
            return liste;
        }
    }
}
