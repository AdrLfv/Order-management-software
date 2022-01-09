using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    public class Boisson : IPrix
    {
        private string type;
        private string volume;
        private int quantite;

        #region constructeur & proprietes
        public Boisson(string type, string volume, int quantite)
        {
            this.type = type;
            this.volume = volume;
            this.quantite = quantite;
        }
        public Boisson()
        {
            volume = null;
            type = null;
            quantite = 0;
        }
        public string Type
        {
            get { return type; }
        }
        public string Volume
        {
            get { return volume; }
        }
        public int Quantite
        {
            get { return quantite; }
        }

        #endregion
        public override string ToString()
        {
            return type + " " + volume + " x" + quantite;
        }
        public float Prix()
        {//1L-->6euro  500ml-->3euro
            int prix = 6;
            if (volume == "0.33" || volume == "0,33") { prix = 2; }
            else if (volume == "0.5" || volume == "0,5") { prix = 3; }
            else if (volume == "1" || volume == "1") { prix = 6; }
            return prix;
        }
    }
}
