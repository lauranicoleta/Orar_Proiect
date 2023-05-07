using Orar_Proiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;


namespace Orar_Proiect
{
    public partial class Meniu : Form
    {
        FileStream fileStreamProf = new FileStream("profesori.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        List<Profesor> listPFisier = new List<Profesor>();

        FileStream fileStreamClas = new FileStream("clase.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        List<Clasa> listCFisier = new List<Clasa>();

        public Meniu()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(fileStreamProf);
            string linie = null;
            while((linie = sr.ReadLine()) != null)
            {
                int cod = Convert.ToInt32(linie.Split(',')[0]); ;
                string nume = linie.Split(',')[1];
                string prenume = linie.Split(',')[2];
                string disciplina = linie.Split(',')[3];
                string titular = linie.Split(',')[4];
                int cod_instit = Convert.ToInt32(linie.Split(',')[6]);
                int nr_ore = Convert.ToInt32(linie.Split(',')[5]);
                Profesor p = new Profesor(cod, nume, prenume, disciplina, titular, cod_instit, nr_ore);
                //MessageBox.Show(s.ToString());
                listPFisier.Add(p);
            }
            sr.Close();
            fileStreamProf.Close();

            StreamReader sr1 = new StreamReader(fileStreamClas);
            string linie1 = null;
            while((linie1 = sr1.ReadLine()) != null)
            {
                int cod_clasa = Convert.ToInt32(linie1.Split(',')[0]);
                string profil = linie1.Split(',')[1];
                string an = linie1.Split(',')[2];
                int cod_sala = Convert.ToInt32(linie1.Split(',')[3]);
                int cod_instit = Convert.ToInt32(linie1.Split(',')[4]);
                Clasa c = new Clasa(cod_clasa, profil, an, cod_sala, cod_instit);
                listCFisier.Add(c);
            }
            sr1.Close();
            fileStreamClas.Close();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {

        }

        private void adaugăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Introduceti codul institutiei!");
            else
                if (textBox2.Text == "")
                errorProvider1.SetError(textBox2, "Introduceti denumirea institutiei!");
            else

            {
                Profesor pNou = new Profesor();
                pNou = null;
                List<Profesor> listPeCod = new List<Profesor>();
                foreach (Profesor p in listPFisier)
                {
                    if (p.Cod_instit == Convert.ToInt32(textBox1.Text))
                        listPeCod.Add(p);
                }
                ProfesorNou frm = new ProfesorNou(listPeCod, pNou, textBox1.Text);
                frm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vizualizeazăToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Incercarea de a prelua lista din Profesor nou si de a o pune in fisier

            //List<Profesor> profesors = new List<Profesor>();    
            //profesors = ProfesorNou.                  
            //VizProfesoriTextFile frm = new VizProfesoriTextFile(profesors);
            //frm.Show();
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Introduceti codul institutiei!");
            else
            {
                List<Profesor> listPeCod = new List<Profesor>();
                foreach(Profesor p in listPFisier)
                {
                    if(p.Cod_instit == Convert.ToInt32(textBox1.Text))
                        listPeCod.Add(p);
                }
                VizProfesor frm = new VizProfesor(listPeCod, textBox1.Text);
                frm.Show();
            }
        }

        private void adaugăClasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Introduceti codul institutiei!");
            else
            {
                Clasa c1 = new Clasa();
                c1 = null;
                ClasaNoua frm = new ClasaNoua(c1, Convert.ToInt32(textBox1.Text));
                frm.Show();
            }
        }

        private void vizualizeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Introduceti codul institutiei!");
            else
            {
                List<Clasa> listCNoua = new List<Clasa>();
                foreach (Clasa p in listCFisier)
                {
                    if (p.Cod_instit == Convert.ToInt32(textBox1.Text))
                        listCNoua.Add(p);
                }
                VizClasa frm = new VizClasa(listCNoua);
                frm.Show();
            }
        }
    }
}
