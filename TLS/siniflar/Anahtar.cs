using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLS.Siniflar
{
    public class Anahtar
    {
        private string anahtar;
        private List<KeyValuePair<string, object>> anahtarList;

        public Anahtar() { }

        public Anahtar(string anahtar, List<KeyValuePair<string, object>> anahtarList)
        {
            this.anahtar = anahtar;
            this.anahtarList = anahtarList;
        }

        public string getAnahtar() { return anahtar; }
        public List<KeyValuePair<string, object>> getAnahtarList() { return anahtarList; }
    }
}
