using Orar_Proiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Orar_Proiect
{
    public partial class ProfesorNou : Form
    {
        private List<Profesor> listaProf = new List<Profesor>();

        public Profesor pProfNou;

        public List<Profesor> ListaProf { get => listaProf; set => listaProf = value; }

        public ProfesorNou(List<Profesor> list, Profesor p, string cod_instit)
        {
            InitializeComponent();
            listaProf = list;
            if (p == null)
            {
                pProfNou = new Profesor();
                label9.Text = cod_instit;
            }
            else
            {
                pProfNou = p;
                textBox1.Text = Convert.ToString(pProfNou.Cod);
                textBox2.Text = pProfNou.Nume;
                textBox3.Text = pProfNou.Prenume;
                comboBox1.Text = pProfNou.Disciplina;
                comboBox2.Text = pProfNou.Titularizare;
                textBox4.Text = Convert.ToString(pProfNou.Nr_ore);
                label9.Text = Convert.ToString(pProfNou.Cod_instit);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Introduceti codul!");
            else
               if (textBox2.Text == "")
                errorProvider1.SetError(textBox2, "Introduceti numele!");
            else
               if (textBox3.Text == "")
                errorProvider1.SetError(textBox3, "Introduceti prenumele!");
            else
               if (comboBox1.Text == "")
                errorProvider1.SetError(comboBox1, "Selectati disciplina!");
            else
               if (comboBox2.Text == "")
                errorProvider1.SetError(comboBox2, "Selectati statutul profesorului!");
            else
               if (textBox4.Text == "")
                errorProvider1.SetError(textBox4, "Introduceti numarul de ore!");
            else
                   if (comboBox2.Text == "Titular" && textBox4.Text != "18")
                errorProvider1.SetError(textBox4, "Norma de predare pentru profesori titulari a rămas la 18 ore pe săptămână în anul școlar 2022-2023.");

            else
            {
                errorProvider1.Clear();
                try
                {
                    int cod = Convert.ToInt32(textBox1.Text);
                    string nume = Convert.ToString(textBox2.Text);
                    string prenume = Convert.ToString(textBox3.Text);
                    string disciplina = Convert.ToString(comboBox1.Text);
                    string titular = Convert.ToString(comboBox2.Text);
                    int cod_instit = Convert.ToInt32(textBox4.Text);
                    int nr_ore = Convert.ToInt32(textBox4.Text);
                    Profesor p = new Profesor(cod, nume, prenume, disciplina, titular, cod_instit, nr_ore);
                    //MessageBox.Show(s.ToString());
                    listaProf.Add(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox4.Clear();
                }
            }
        }

        private void schimbaCuloareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.BackColor = dlg.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VizProfesor frm = new VizProfesor(listaProf, label9.Text);
            frm.Show();
            this.Close();
        }

        private void ProfesorNou_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public List<Profesor> getListaPorf()
        {
            return listaProf;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfesorNou_Load_1(object sender, EventArgs e)
        {

        }
    }
}
