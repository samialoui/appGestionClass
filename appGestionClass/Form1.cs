using appGestionClass.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appGestionClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        //public List<String> listEtudiant = new List<String>();


        AjouterEtudiant AE;
        private void ajouterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            if (AE == null)
            {
                AE = new AjouterEtudiant();
                AE.MdiParent = this;
                AE.MdiParent.Dock = DockStyle.Fill;
                AE.Show();
            }
        }

        ModifierEtudiant ME;
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (ME == null)
            {
                ME = new ModifierEtudiant();
                ME.MdiParent = this;
                ME.MdiParent.Dock = DockStyle.Fill;
                //ME.Height = ME.Height - 150;
                ME.Show();
            }
        }

        SupprimerEtudiant SE;
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (SE == null)
            {
                SE = new SupprimerEtudiant();
                SE.MdiParent = this;
                SE.MdiParent.Dock = DockStyle.Fill;
                //SE.Anchor = AnchorStyles.Left;
                //SE.Anchor = AnchorStyles.Top;

                SE.Show();

            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
