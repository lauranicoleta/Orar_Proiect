using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orar_Proiect
{
    public class Clasa : ICloneable
    {
        private string profil;
        private string an;
        private int cod_sala;
        private int cod_clasa;
        private int cod_instit;

        public Clasa()
        {
            profil = "N/A";
            an = "NA";
            cod_sala = 0;
            cod_clasa = 0;
            cod_instit = 0;
        }
        public Clasa(int cod_clasa, string profil, string an, int cod_sala, int cod_instit)
        {
            this.cod_clasa = cod_clasa;
            this.profil = profil;
            this.an = an;
            this.cod_sala = cod_sala;
            this.cod_instit = cod_instit;
        }

        public string Profil { get => profil; set => profil = value; }
        public string An { get => an; set => an = value; }
        public int Cod_sala { get => cod_sala; set => cod_sala = value; }
        public int Cod_clasa { get => cod_clasa; set => cod_clasa = value; }
        public int Cod_instit { get => cod_instit; set => cod_instit = value; }

        public object Clone()
        {
            Clasa clona = (Clasa)this.MemberwiseClone();
            return clona;
        }

        public override string ToString()
        {
            string rezultat = cod_clasa + "," + profil + "," + an + "," + cod_sala + "," + cod_instit;
            return rezultat;
        }

    }
}
