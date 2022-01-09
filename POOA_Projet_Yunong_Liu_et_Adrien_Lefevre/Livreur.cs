using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    public class Livreur : Effectif
    {
        private string moyenTransport;
        private int nbLivraison;

        #region constructeur & proprietes
        public Livreur(string nom, string prenom, string adresse, string num, string etat, string moyenTransport, int nbLivraison) : base(nom, prenom, adresse, num, etat)
        {
            this.moyenTransport = moyenTransport;
            this.nbLivraison = nbLivraison;
        }
        public string MoyenTransport
        {
            get { return moyenTransport; }
            set { moyenTransport = value; }
        }
        public int NbLivraison
        {
            get { return nbLivraison; }
            set { nbLivraison = value; }
        }
        #endregion

        public static int CompareLivraison(Livreur a, Livreur b)
        {
            return a.NbLivraison.CompareTo(b.NbLivraison);
        }
        public override string ToString()
        {
            return base.ToString() + " " + moyenTransport + " " + nbLivraison;
        }
    }
}
