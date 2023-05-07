using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orar_Proiect
{
    public class Institutie : ICloneable
    {
        private int cod_instit;
        private string denumire;
        List<Clasa> clase = new List<Clasa>();

        public Institutie()
        {
            cod_instit = 0;
            denumire = "N/A";
        }

        public Institutie(int cod_instit, string denumire, List<Clasa> clase)
        {
            this.cod_instit = cod_instit;
            this.denumire = denumire;
            this.clase = clase;
        }

        public int Cod_instit { get => cod_instit; set => cod_instit = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public List<Clasa> Clase { get => clase; set => clase = value; }

        public object Clone()
        {
            Institutie clona = new Institutie();
            clona.Cod_instit = cod_instit;
            clona.Denumire = denumire;
            clona.Clase = this.clase;
            return clona;
        }
    }
}