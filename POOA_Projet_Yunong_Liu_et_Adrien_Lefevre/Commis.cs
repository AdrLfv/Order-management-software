using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    public class Commis : Effectif
    {
        private DateTime dateEmbauche;
        private int nbCommandes;

        #region constructeur & proprietes
        public Commis(string nom, string prenom, string adresse, string numero, string etat, DateTime dateEmbauche, int nbCommandes) : base(nom, prenom, adresse, numero, etat)
        {
            this.dateEmbauche = dateEmbauche;
            this.nbCommandes = nbCommandes;
        }
        public int NbCommandesGerees
        {
            get { return nbCommandes; }
            set { nbCommandes = value; }
        }
        public DateTime DateEmbauche
        {
            get { return dateEmbauche; }
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + " " + dateEmbauche + " " + nbCommandes;
        }

        public static int CompareCommande(Commis a, Commis b)
        {
            return a.nbCommandes.CompareTo(b.nbCommandes);
        }

        //public string Prenom
        //{
        //    get { return base.Prenom; }

        //}
    }
}
