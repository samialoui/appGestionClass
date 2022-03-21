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
    public partial class AjouterEtudiant : Form
    {
        public AjouterEtudiant()
        {
            InitializeComponent();
        }

        Etudiant etudiant = new Etudiant();
        private void button1_Click(object sender, EventArgs e)
        {
            

            bool isSuccess = false;
            bool existe = false;
            int numInsc = int.Parse(textNum.Text);

            existe = etudiant.chercherEtudiant(numInsc);
            if(existe == true)
            {
                MessageBox.Show("Il existe le méme numéro d'inscription,Veuillez choisir un autre numéro..", "Erreur d'ajout", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Etudiant etud = new Etudiant(numInsc,textNom.Text,textPrenom.Text,cmbClass.Text);
                

                isSuccess = etudiant.AjouterEtudiant(etud);

                if (isSuccess == true)
                {
                    MessageBox.Show("Etudiant a été ajouté avec succée","Ajouter Etudiant",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    vider();
                    var listEtd = etudiant.AfficherEtudiant();

                    var bindingList = new BindingList<Etudiant>(listEtd);
                    var source = new BindingSource(bindingList, null);

              
                    dataGridView1.DataSource = source;
                }
                else
                {
                    MessageBox.Show("Impossible d'ajouter un etudiant, Veuillez vérifier votre code...");
                }

            }


           
            
        }

        public void vider()
        {
            textNum.Text = "";
            textNom.Text = "";
            textPrenom.Text = "";
            cmbClass.Text = "";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void AjouterEtudiant_Load(object sender, EventArgs e)
        {
            var listEtd = etudiant.AfficherEtudiant();

            var bindingList = new BindingList<Etudiant>(listEtd);
            var source = new BindingSource(bindingList, null);
          
            dataGridView1.DataSource = source ;
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listEtd = etudiant.AfficherEtudiant();

            var bindingList = new BindingList<Etudiant>(listEtd);
            var source = new BindingSource(bindingList, null);

            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textNum.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textNom.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textPrenom.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbClass.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();


        }
    }
}
