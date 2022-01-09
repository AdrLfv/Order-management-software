using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre

{
    public class Pizza : IPrix
    {
        private string taille;
        private string type;
        //private int prix_de_base;
        private int quantite;

        #region constructeur & proprietes
        public Pizza(string taille, string type, int quantite)
        {
            this.taille = taille;
            this.type = type;
            //this.prix_de_base = prix_de_base;
            this.quantite = quantite;
        }
        public Pizza()
        {
            taille = null;
            type = null;
            quantite = 0;
        }
        public string Taille
        {
            get { return taille; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        //public int Prix_de_base
        //{
        //    get { return prix_de_base; }
        //    //set { prix_de_base = value; }
        //}
        public int Quantite
        {
            get { return quantite; }
            //set { prix_de_base = value; }
        }
        #endregion


        public override string ToString()
        {
            return taille + " " + type + " " + quantite;
        }

        public float Prix()
        {

            float prix = 0;
            if (type == "Marguerite" || type == "4Fromages") { prix = 5; }
            else if (type == "Hawaii") { prix = 7; }
            else if (type == "Vegetarienne" || type == "Chorizo") { prix = 6; }
            else { prix = 6; }

            if (taille == "Medium") { prix += 3; }
            else if (taille == "Grande") { prix += 5; }

            return (float)quantite * prix;
        }
    }
}
