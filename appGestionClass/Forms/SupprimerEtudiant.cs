using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appGestionClass.Forms
{
    public partial class SupprimerEtudiant : Form
    {
        public SupprimerEtudiant()
        {
            InitializeComponent();
        }

        Etudiant etudiant = new Etudiant();
        private void button1_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
           String classe = textClass.Text;
            isSuccess = etudiant.SupprimerEtudiant(classe);

            if(isSuccess == true)
            {
                MessageBox.Show("Etudiant a été supprimé avec succée","Supprimer Etudiant",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textClass.Text = "";
                var listEtd = etudiant.AfficherEtudiant();

                var bindingList = new BindingList<Etudiant>(listEtd);
                var source = new BindingSource(bindingList, null);

                dataGridView3.DataSource = source;
            }
            else
            {
                MessageBox.Show("Impossible de supprimer un etudiant, Veuillez vérifier votre code ...","Erreur de suppression",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void SupprimerEtudiant_Load(object sender, EventArgs e)
        {
            var listEtd = etudiant.AfficherEtudiant();

            var bindingList = new BindingList<Etudiant>(listEtd);
            var source = new BindingSource(bindingList, null);

            dataGridView3.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listEtd = etudiant.AfficherEtudiant();

            var bindingList = new BindingList<Etudiant>(listEtd);
            var source = new BindingSource(bindingList, null);

            dataGridView3.DataSource = source;
        }
    }
}
