using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGestionClass
{
  
    class Etudiant
    {
        public int NumInscri { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Classe { get; set; }



        public static  List<Etudiant> listEtudiant = new List<Etudiant>();
        
       

        public Etudiant(int NumInscri, string Nom, string Prenom, string Classe)
        {
            this.NumInscri = NumInscri;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Classe = Classe;
        }

        public Etudiant()
        {
        }

        public  List<Etudiant> AfficherEtudiant()
        { 
            return listEtudiant;
        }


        public bool chercherEtudiant(int numInscri)
        {
           
            bool existe = false;
            try
            {
                var num = listEtudiant.FirstOrDefault(p => p.NumInscri == numInscri);
                if (num != null)
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return existe;
                
        }

        public bool AjouterEtudiant(Etudiant etd)
        {
            bool isSuccess = false;
            int row1 = listEtudiant.Count;
            try
            {
                listEtudiant.Add(etd);
                int row2 = listEtudiant.Count;
                if (row2 > row1)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isSuccess;

        }


        public bool ModifierEtudiant( Etudiant etd )
        {
            bool isSuccess = false;

            try
            {

                var nouveau = listEtudiant.FirstOrDefault(p => p.NumInscri == etd.NumInscri);
                if (nouveau != null)
                {
                    nouveau.NumInscri = etd.NumInscri;
                    nouveau.Nom = etd.Nom;
                    nouveau.Prenom = etd.Prenom;
                    nouveau.Classe = etd.Classe;
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isSuccess;

        }

        public bool SupprimerEtudiant(String Classe)
        {
            bool isSuccess = false;
            try
            {
                int row1 = listEtudiant.Count;
                var nouveau = listEtudiant.FirstOrDefault(p => p.Classe == Classe);
                if (nouveau != null)
                {
                    listEtudiant.Remove(nouveau);
                    int row2 = (listEtudiant.Count) - 1;
                    if (row1 > row2)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return isSuccess;
        }
      
    }
}
