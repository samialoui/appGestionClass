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
    public partial class ModifierEtudiant : Form
    {
        public ModifierEtudiant()
        {
            InitializeComponent();
        }

        Etudiant etudiant = new Etudiant();
        private void button1_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            etudiant.NumInscri = int.Parse(textNum.Text);
            etudiant.Nom = textNom.Text;
            etudiant.Prenom = textPrenom.Text;
            if(cmbClass.Text =="ingInf1" || cmbClass.Text == "ingInf2" || cmbClass.Text == "ingInf3")
            {
                etudiant.Classe = cmbClass.Text;

                isSuccess = etudiant.ModifierEtudiant(etudiant);

                if (isSuccess == true)
                {
                    MessageBox.Show("Etudiant modifié avec succée", "Modifier Etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vider();
                    var listEtd = etudiant.AfficherEtudiant();

                    var bindingList = new BindingList<Etudiant>(listEtd);
                    var source = new BindingSource(bindingList, null);

                    dataGridView2.DataSource = source;
                }
                else
                {
                    MessageBox.Show("Impossible de modifier un etudiant,Veuillez vérifier votre code ...","Erreur de modification",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ce classe n'existe pas dans la liste,Veuillez saisir un classe existe ...","Vérification des champs",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
  
           
        }

        public void vider()
        {
            textNum.Text = "";
            textNom.Text = "";
            textPrenom.Text = "";
            cmbClass.Text = "";
        }

        private void ModifierEtudiant_Load(object sender, EventArgs e)
        {
            var listEtd = etudiant.AfficherEtudiant();

            var bindingList = new BindingList<Etudiant>(listEtd);
            var source = new BindingSource(bindingList, null);

            dataGridView2.DataSource = source;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textNum.Text = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            textNom.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            textPrenom.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            cmbClass.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listEtd = etudiant.AfficherEtudiant();

            var bindingList = new BindingList<Etudiant>(listEtd);
            var source = new BindingSource(bindingList, null);

            dataGridView2.DataSource = source;
        }
    }
}
