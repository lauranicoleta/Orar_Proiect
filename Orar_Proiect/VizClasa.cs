using Orar_Proiect;
using System;
using System.Collections;
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
    public partial class VizClasa : Form
    {
        List<Clasa> listClase = new List<Clasa>();
        public VizClasa(List<Clasa> cls)
        {
            InitializeComponent();
            foreach (Clasa clasa in cls)
                {
                    listClase.Add(clasa);
                    ListViewItem lv = new ListViewItem(Convert.ToString(clasa.Cod_clasa));
                    lv.SubItems.Add(clasa.An);
                    lv.SubItems.Add(clasa.Profil);
                    lv.SubItems.Add(Convert.ToString(clasa.Cod_sala));
                    lv.SubItems.Add(Convert.ToString(clasa.Cod_instit));
                    lv.Tag = clasa;
                    lvClase.Items.Add(lv);
                }
        }

        private void VizClasa_Load(object sender, EventArgs e)
        {

        }

        private void editeazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvClase.SelectedItems.Count > 0)
            {
                Clasa c = lvClase.SelectedItems[0].Tag as Clasa;
                ClasaNoua fm = new ClasaNoua(c, c.Cod_instit);
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lv = lvClase.SelectedItems[0];
                    lv.SubItems[0].Text = Convert.ToString(c.Cod_clasa);
                    lv.SubItems[2].Text = c.Profil;
                    lv.SubItems[1].Text = c.An;
                    lv.SubItems[3].Text = Convert.ToString(c.Cod_sala); 
                }
            }
        }

        private void lvClase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void înapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
