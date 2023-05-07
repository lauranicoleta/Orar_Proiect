using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Orar_Proiect
{
    [Serializable]
    public class Profesor : ICloneable, IComparable
    {
        private int cod;
        private string nume;
        private string prenume;
        private string disciplina;
        private string titularizare;
        private int cod_instit;
        private int nr_ore;

        public Profesor()
        {
            cod = 0;
            nume = "Anonim";
            prenume = "Anonim";
            disciplina = "N/A";
            titularizare = "N/A";
            cod_instit = 0;
            nr_ore = 0;
        }

        public Profesor(int cod, string nume, string prenume, string disciplina, string titularizare, int cod_instit, int nr_ore)
        {
            this.cod = cod;
            this.nume = nume;
            this.prenume = prenume;
            this.disciplina = disciplina;
            this.titularizare = titularizare;
            this.cod_instit = cod_instit;
            this.nr_ore = nr_ore;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Disciplina { get => disciplina; set => disciplina = value; }
        public int Nr_ore { get => nr_ore; set => nr_ore = value; }
        public string Titularizare { get => titularizare; set => titularizare = value; }
        public int Cod_instit { get => cod_instit; set => cod_instit = value; }

        public object Clone()
        {
            Profesor clona = (Profesor)this.MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string rezultat = cod + "," + nume + "," + prenume + "," + disciplina + "," + titularizare + "," + nr_ore + "," + cod_instit;
            return rezultat;
        }
    }
}