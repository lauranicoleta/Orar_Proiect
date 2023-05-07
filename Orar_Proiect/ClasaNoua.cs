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
    public partial class ClasaNoua : Form
    {
        List<Clasa> listCls = new List<Clasa>();

        public Clasa cNoua;
        public ClasaNoua(Clasa c, int cod_instit)
        {
            InitializeComponent();
            if(c== null)
            {
                cNoua = new Clasa();
                label7.Text = Convert.ToString(cod_instit);
            }
            else
            {
                cNoua = c;
                textBox2.Text = Convert.ToString(cNoua.Cod_clasa);
                comboBox1.Text = cNoua.Profil;
                comboBox2.Text = cNoua.An;
                textBox1.Text = Convert.ToString(cNoua.Cod_clasa);
                label7.Text = Convert.ToString(cNoua.Cod_instit);
            }
        }

        private void schimbăFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.Font = dlg.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                errorProvider1.SetError(comboBox1, "Selectati profilul!");
            else
              if (comboBox2.Text == "")
                errorProvider1.SetError(comboBox2, "Selectati anul!");
            else
              if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Introduceti codul salii de clasa!");
            else
              if (textBox2.Text == "")
                errorProvider1.SetError(textBox2, "Introduceti codul clasei!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int cod_clasa = Convert.ToInt32(textBox2.Text);
                    string profil = comboBox1.Text;
                    string an = comboBox2.Text;
                    int cod_sala = Convert.ToInt32(textBox1.Text);
                    int cod_instit = Convert.ToInt32(label7.Text);
                    Clasa c = new Clasa(cod_clasa, profil, an, cod_sala, cod_instit);
                    listCls.Add(c);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VizClasa frm = new VizClasa(listCls);
            frm.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ClasaNoua_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
