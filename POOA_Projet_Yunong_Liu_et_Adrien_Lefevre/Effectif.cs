using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    abstract public class Effectif
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string numero;
        private string etat;



        #region constructeur & propriete
        public Effectif(string nom, string prenom, string adresse, string numero, string etat)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.numero = numero;
            this.etat = etat;
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
        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string Numero
        {
            get { return numero; }

            set { numero = value; }
        }
        #endregion

        public override string ToString()
        {
            return nom + " " + prenom +" " + adresse +" " + numero +" " + etat;
        }
    }
}
