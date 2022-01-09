using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    public class Commande : IPrix
    {
        private List<Pizza> listePizzas = new List<Pizza>();
        private List<Boisson> listeBoissons = new List<Boisson>();
        private TimeSpan heure;
        private string numClient;
        private string nomCommis;
        private string nomLivreur;
        private string etat;
        private DateTime date;
        private int numCommande;
        private bool estUnePerte;
        private float prix;

        #region constructeur & propriete

        public Commande(TimeSpan heure, DateTime date, string numClient, string nomCommis, int numCommande, string nomLivreur)
        {
            this.heure = heure;
            this.date = date;
            this.numClient = numClient;
            this.nomCommis = nomCommis;
            this.numCommande = numCommande;
            this.nomLivreur = nomLivreur;
            this.estUnePerte = false;
            this.etat = "en préparation";
            this.prix = 0;
        }
        public Commande(List<Pizza> listePizzas, List<Boisson> listeBoissons, TimeSpan heure, string numClient, string nomCommis, int numCommande, string nomLivreur, DateTime date)
        {
            this.listePizzas = listePizzas;
            this.listeBoissons = listeBoissons;
            this.heure = heure;
            this.numClient = numClient;
            this.nomCommis = nomCommis;
            this.numCommande = numCommande;
            this.nomLivreur = nomLivreur;
            this.date = date;
            this.prix = 0;
            this.etat = "en préparation";
        }
        public Commande()
        {
        }
        public List<Pizza> ListePizzas
        {
            get { return listePizzas; }
            set { listePizzas = value; }
        }
        public List<Boisson> ListeBoissons
        {
            get { return listeBoissons; }
            set { listeBoissons = value; }
        }
        public float GetPrix
        {
            get { return prix; }
            set { prix = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public TimeSpan Heure
        {
            get { return heure; }
            set { heure = value; }
        }
        public string NomLivreur
        {
            get { return nomLivreur; }
            set { nomLivreur = value; }
        }
        public int NumCommande
        {
            get { return numCommande; }
            set { numCommande = value; }
        }
        public string NumClient
        {
            get { return numClient; }
            set { numClient = value; }
        }
        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        public bool EstUnePerte
        {
            get { return estUnePerte; }
            set { estUnePerte = value; }
        }
        public string NomCommis
        {
            get { return nomCommis; }
            set { nomCommis = value; }
        }
        #endregion

        public float Prix()
        {
            float prix = 0;
            if (listePizzas != null)
            {
                foreach (Pizza p in listePizzas)
                {
                    prix += p.Prix();
                }
            }
            if (listePizzas != null)
            {
                foreach (Boisson b in listeBoissons)
                {
                    prix += b.Prix();
                }
            }
            return prix;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Pizza pizza in listePizzas)
            {
                result += pizza + "\n";
            }
            foreach (Boisson boisson in listeBoissons)
            {
                result += boisson + "\n";
            }
            if (this.GetPrix == 0)
            { this.GetPrix = this.Prix(); }
            result += "Prix : " + GetPrix + "\n";
            return result + "heure : " + heure + "\nnumClient :" + numClient + "\nnomCommis :" + nomCommis + "\nnumCommande :" + numCommande;
        }

        public void AjoutPizza()
        {
            bool ajoutPizza = true;
            string reponse;
            while (ajoutPizza)
            {
                Console.WriteLine("Voulez-vous ajouter une pizza ?");
                reponse = Console.ReadLine();

                if (reponse == "Oui" || reponse == "OUI" || reponse == "oui")
                {
                    Console.WriteLine("Rentrez la taille de la pizza (Petite, Medium, Grande)");
                    string taille = Console.ReadLine();
                    while (taille != "Petite" && taille != "Medium" && taille != "Grande")
                    {
                        Console.WriteLine("Rentrez une taille valide (Petite, Medium, Grande)");
                        taille = Console.ReadLine();
                    }
                    Console.Clear();

                    Console.WriteLine("Rentrez le type de la pizza (Marguerite, Hawaii, Vegetarienne, 4Fromages, Chorizo)");
                    string type = Console.ReadLine();
                    while (type != "Marguerite" && type != "Hawaii" && type != "Vegetarienne" && type != "4Fromages" && type != "Chorizo")
                    {
                        Console.WriteLine("Rentrez un type valide (Marguerite, Hawaii, Vegetarienne, 4Fromages, Chorizo)");
                        type = Console.ReadLine();
                    }
                    Console.Clear();

                    Console.WriteLine("Rentrez la quantite");
                    int quantite = Convert.ToInt32(Console.ReadLine());
                    while (quantite < 1)
                    {
                        Console.WriteLine("Rentrez une quantite valide positive");
                        quantite = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Clear();

                    Pizza p = new Pizza(taille, type, quantite);
                    listePizzas.Add(p);

                    Console.WriteLine("Ajout reussi. Vous avez commande " + p);
                }
                else
                {
                    ajoutPizza = false;
                }

            }
        }

        public void AjoutBoisson()
        {
            bool ajoutBoisson = true;
            string reponse;
            while (ajoutBoisson)
            {
                Console.WriteLine("Voulez-vous ajouter une boisson ?");
                reponse = Console.ReadLine();

                if (reponse == "Oui" || reponse == "OUI" || reponse == "oui")
                {
                    Console.WriteLine("Rentrez le type de la boisson (Coca, Fanta, Orangina, Perrier)");
                    string type = Console.ReadLine();
                    while (type != "Coca" && type != "Fanta" && type != "Orangina" && type != "Perrier")
                    {
                        Console.WriteLine("Rentrez un type valide (Coca, Fanta, Orangina, Perrier)");
                        type = Console.ReadLine();
                    }
                    Console.Clear();

                    Console.WriteLine("Rentrez le volume de la boisson (0.33 / 0.5 / 1)");
                    string volume = Console.ReadLine();
                    while (volume != "0,33" && volume != "0.33" && volume != "0,5" && volume != "0.5" && volume != "1" && volume != "1")
                    {
                        Console.WriteLine("Rentrez un volume valide (0.33 / 0.5 / 1)");
                        volume = Console.ReadLine();
                    }
                    Console.Clear();

                    Console.WriteLine("Rentrez la quantite");
                    int quantite = Convert.ToInt32(Console.ReadLine());

                    while (quantite < 1)
                    {
                        Console.WriteLine("Rentrez une quantité positive valide");
                        volume = Console.ReadLine();
                    }
                    Console.Clear();

                    Boisson b = new Boisson(type, volume, quantite);
                    listeBoissons.Add(b);

                    Console.WriteLine("Ajout reussi. Vous avez commande " + b);
                }
                else
                {
                    ajoutBoisson = false;
                }

            }
        }

        public void ModifEtat()
        {
            Console.WriteLine("Etat actuel : " + etat);
            Console.WriteLine("Pour modifier :\n1-En préparation 2-En livraison 3-Fermée");
            int i = int.Parse(Console.ReadLine());
            while (i != 1 && i != 2 && i != 3)
            {
                Console.WriteLine("Rentrez une option valide (1-En préparation 2-En livraison 3-Fermée)");
                i = int.Parse(Console.ReadLine());
            }
            switch (i)
            {
                case 1:
                    etat = "En préparation";
                    break;
                case 2:
                    etat = "En livraison";
                    break;
                case 3:
                    etat = "Fermée";
                    break;
            }
            Console.WriteLine("Modification enregistre. Etat actuel : " + etat);
        }

        public void Encaisser(float caisse)
        {
            if (!estUnePerte)
            {
                Console.WriteLine("Caisse actuelle : " + caisse);
                Console.WriteLine("Commande no." + numCommande + " n'est pas une perte. Souhaitez-vous l'encaisser ? o/n");
                string i = Console.ReadLine();
                while (i != "o" && i != "n")
                {
                    Console.WriteLine("Rentrez une option valide (o/n)");
                    i = Console.ReadLine();
                }
                if (i == "n")
                {
                    Console.WriteLine("La commande s'agit-elle une perte ?");
                    string p = Console.ReadLine();
                    while (p != "o" && p != "n")
                    {
                        Console.WriteLine("Rentrez une option valide (o/n)");
                        p = Console.ReadLine();
                    }
                    if (p == "o")
                    {
                        estUnePerte = true;
                        Console.WriteLine("Commis en charge : " + nomCommis);
                    }
                }
                else { caisse += this.Prix(); Console.WriteLine("La commande est encaissee."); }

                Console.WriteLine("Modification enregistre. ");

                if (estUnePerte)
                { Console.Write("Commande no." + numCommande + " est une perte."); Console.WriteLine("Caisse actuelle : " + caisse); }
                else
                { Console.Write("Commande no." + numCommande + " n'est pas une perte."); Console.WriteLine("Caisse actuelle : " + caisse); }
            }
        }


    }
}





