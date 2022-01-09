using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    public class Client : IPrix, IMoyenne
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string ville;
        private string numeroTel;
        private DateTime datePremiereCommande;
        private double montant_achat;
        private List<Commande> listeCommande;
        private List<string> listeCodeUtilise = new List<string>();

        #region constructeur & proprietes
        public Client(string nom, string prenom, string adresse, string ville, string numeroTel, DateTime datePremiereCommande, double montant_achat, List<Commande> listeCommandes)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ville = ville;
            this.numeroTel = numeroTel;
            this.datePremiereCommande = datePremiereCommande;
            this.montant_achat = montant_achat;
            this.listeCommande = listeCommandes;
            listeCodeUtilise = new List<string>();
        }
        public Client(string nom, string prenom, string adresse, string ville, string numeroTel, DateTime datePremiereCommande, double montant_achat)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ville = ville;
            this.numeroTel = numeroTel;
            this.datePremiereCommande = datePremiereCommande;
            this.montant_achat = montant_achat;
            this.listeCommande = new List<Commande>();
            listeCodeUtilise = new List<string>();
        }
        public Client(string nom, string prenom, string adresse, string ville, string numeroTel, DateTime datePremiereCommande)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ville = ville;
            this.numeroTel = numeroTel;
            this.datePremiereCommande = datePremiereCommande;
            montant_achat = 0;
            listeCommande = new List<Commande>();
            listeCodeUtilise = new List<string>();
        }

        
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string NumeroTel 
        {
            get { return numeroTel; }
            set { numeroTel = value; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public DateTime DatePremiereCommande
        {
            get { return datePremiereCommande; }
        }
        public double Montant_achat
        {
            get { return montant_achat; }
            set { montant_achat = value; }
        }
        public List<Commande> ListeCommande
        {
            get { return listeCommande; }
            set { listeCommande = value; }
        }
        public List<string> ListeCodeUtilise
        {
            get { return listeCodeUtilise; }
            set { listeCodeUtilise = value; }
        }

        public override string ToString()
        {
            return nom + " " + prenom + " " + adresse + " " + ville + " " + numeroTel + " " + datePremiereCommande + " " + montant_achat;
        }
        #endregion

        /// <summary>
        /// Return tout ce qu'a dépensé un client 
        /// </summary>
        /// <returns></returns>
        public float Prix()
        {
            float res = 0;
            if(listeCommande.Count != 0)
            {
                foreach (Commande c in listeCommande)
                {
                    res += (float)c.Prix();
                }
            }
            
            return (float)res;
        }

        /// <summary>
        /// Return la moyenne de tout ce qu'a dépensé un client
        /// </summary>
        /// <returns></returns>
        public float Moyenne()
        {
            float res = 0;
            int i = 0;
            if (listeCommande.Count != 0)
            {
                foreach (Commande c in listeCommande)
                    {
                        if (c != null)
                        {
                            res += (float)c.GetPrix;
                            i++;
                        }
                    }
                res = res  /  i;
            }
            return res;
        }
        public static int CompareVille(Client a, Client b)
        {
            return a.Ville.CompareTo(b.Ville);
        }

        public static int CompareAchat(Client a, Client b)
        {
            return a.Montant_achat.CompareTo(b.Montant_achat);
        }
    }
}
