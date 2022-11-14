using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsGyumolcsok
{
    internal class gyumolcs
    {
        int id;
        string nev;
        double egysegar;
        double mennyiseg;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public double Egysegar { get => egysegar; set => egysegar = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public gyumolcs(int id, string nev, double egysegar, double mennyiseg)
        {
            this.id = id;
            this.nev = nev;
            this.egysegar = egysegar;
            this.mennyiseg = mennyiseg;
        }
        public override string ToString()
        {
            return nev + " (" + egysegar + "ft/kg) " + mennyiseg +"db";
        }

    }
}
