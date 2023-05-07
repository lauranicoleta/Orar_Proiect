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

namespace Orar_Proiect
{
    public partial class VizProfesor : Form
    {
        List<Profesor> nouaLista = new List<Profesor>();
        public VizProfesor(List<Profesor> lista, string cod_instit)
        {
            InitializeComponent();
            foreach (Profesor prof in lista)
            {
                nouaLista.Add(prof);
                ListViewItem lv = new ListViewItem(Convert.ToString(prof.Cod));
                lv.SubItems.Add(prof.Nume);
                lv.SubItems.Add(prof.Prenume);
                lv.SubItems.Add(prof.Disciplina);
                lv.SubItems.Add(prof.Titularizare);
                prof.Cod_instit = Convert.ToInt32(cod_instit);
                lv.SubItems.Add(Convert.ToString(prof.Cod_instit));
                lv.SubItems.Add(Convert.ToString(prof.Nr_ore));
                lv.Tag = prof;
                lvProfesori.Items.Add(lv);
            }

        }
        private void VizProfesor_Load(object sender, EventArgs e)
        {

        }

        private void editeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvProfesori.SelectedItems.Count > 0)
            {
                Profesor p = lvProfesori.SelectedItems[0].Tag as Profesor;
                ProfesorNou fm = new ProfesorNou(nouaLista, p, Convert.ToString(p.Cod_instit));
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lv = lvProfesori.SelectedItems[0];
                    lv.SubItems[0].Text = Convert.ToString(p.Cod);
                    lv.SubItems[1].Text = p.Nume;
                    lv.SubItems[2].Text = p.Prenume;
                    lv.SubItems[3].Text = p.Disciplina;
                    lv.SubItems[4].Text = p.Titularizare;
                    lv.SubItems[5].Text = Convert.ToString(p.Cod_instit);
                    lv.SubItems[6].Text = Convert.ToString(p.Nr_ore);
                }
            }
            this.Close();
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
