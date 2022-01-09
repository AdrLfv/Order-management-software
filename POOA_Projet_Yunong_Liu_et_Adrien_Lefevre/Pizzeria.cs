using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    public class Pizzeria
    {
        private List<Commande> listeCommandes;
        private List<Commis> listeCommis;
        private List<Client> listeClients;
        private List<Livreur> listeLivreurs;
        private SortedList<string, float> listeCodePromo;
        //la listeCodePromo est formée d'un string pour le code, et d'un float pour le tarif de remise
        private int numeroDeCommande = 1;
        private float caisse = 0;

        /// <summary>
        /// Construction de la pizzeria en fonction des données des différents excels
        /// </summary>
        public Pizzeria()
        {
            
            //listeCommandes = LectureCommandes();
            LectureCommandes();
            listeClients = LectureClients();
            listeCommis = LectureCommis();
            listeLivreurs = LectureLivreurs();
            listeCodePromo = LecturePromoss();
        }

        /// <summary>
        /// Ce main s'occupe d'ouvrir la fenetre pour l'affichage en wpf
        /// il s'occupe aussi de l'affichage et de la lecture de la console
        /// car notre programme est utilisable aussi en utilisant la console seule
        /// </summary>
        public void Main()
        {
            MainWindow fenetre = new MainWindow();
            fenetre.Show();

            ConsoleKeyInfo cki;
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu :\n"
                                 + "Module1 : Afficher, ajouter, supprimer, modifier les clients\n"
                                 + "          Afficher, ajouter, supprimer, modifier les commis\n"
                                 + "          Afficher, ajouter, supprimer, modifier les livreurs \n"
                                 + "Module2 : Ajouter une commande\n"
                                 + "          Modifier une commande\n"
                                 + "          Afficher une commande\n"
                                 + "Module3 : Afficher le nombre de commandes gérées par commis\n"
                                 + "          Afficher le nombre de livraisons effectuées par livreur\n"
                                 + "          Afficher les commandes selon une période de temps\n"
                                 + "          Afficher la moyenne des prix des commandes\n"
                                 + "          Afficher la moyenne des comptes clients\n"

                                 + "Module4 : Enregistrer\n"
                                 + "          Utiliser un code promotion sur une commande\n"
                                 + "          Verifier si un code promo est utilisable\n"
                                 + "          Afficher tous les codes utlises\n"
                                 //+ "          Sauvegarder les clients dans un fichier : \n\n"
                                 + "Entrez le numéro du module désiré ");

                int numModule = Convert.ToInt32(Console.ReadLine());
                while (numModule < 1 || numModule > 5)
                {
                    Console.WriteLine("Le numéro choisi n'est pas valable. Veuillez recommencez l'opération.");
                    Console.Write("Numéro de l'exercice souhaité : ");
                    numModule = Convert.ToInt32(Console.ReadLine());
                }
                switch (numModule)
                {
                    case 1:
                        #region Module1 Client/Effectif
                        Console.Clear();

                        AfficherMeilleurClient();

                        Console.WriteLine("1 - AfficherAlphabetiqueClients\n" +
                            "2 - AfficherAlphabetiqueCommis\n" +
                            "3 - AfficherAlphabetiqueLivreurs\n" +
                            "4 - AfficherVille\n" +
                            "5 - AfficherMeilleurClient\n" +
                            "6 - AjoutClient\n" +
                            "7 - AjoutCommis\n" +
                            "8 - AjoutLivreur\n" +
                            "9 - SuppressionClient\n" +
                            "10 - SuppressionCommis\n" +
                            "11 - SuppressionLivreur" +
                            "12 - ModificationClient\n" +
                            "13 - ModificationCommis\n" +
                            "14 - ModificationLivreur");

                        int numReponse = Convert.ToInt32(Console.ReadLine());
                        while (numReponse < 1 || numReponse > 11)
                        {
                            Console.WriteLine("Entrez un numéro valide");
                            numReponse = Convert.ToInt32(Console.ReadLine());
                        }
                        switch (numReponse)
                        {
                            #region 1-5 affichage
                            case 1:
                                AfficherAlphabetiqueClients();
                                Console.ReadKey();
                                break;

                            case 2:
                                AfficherAlphabetiqueCommis();
                                Console.ReadKey();
                                break;

                            case 3:
                                AfficherAlphabetiqueLivreurs();
                                Console.ReadKey();
                                break;


                            case 4:
                                AfficherVille();
                                Console.ReadKey();
                                break;


                            case 5:
                                AfficherMeilleurClient();
                                Console.ReadKey();
                                break;
                            #endregion

                            #region 6-8 ajout
                            case 6:
                                listeClients = AjoutClient(listeClients);

                                Console.ReadKey();
                                break;
                            case 7:
                                listeCommis = AjoutCommis(listeCommis);


                                Console.ReadKey();
                                break;
                            case 8:
                                listeLivreurs = AjoutLivreur(listeLivreurs);

                                Console.ReadKey();
                                break;
                            #endregion

                            #region 9-11 supression
                            case 9:
                                SuppressionClient();
                                Console.ReadKey();
                                break;
                            case 10:
                                SuppressionCommis();
                                Console.ReadKey();
                                break;
                            case 11:
                                SuppressionLivreur();
                                Console.ReadKey();
                                break;
                            #endregion

                            #region 12-14 modification
                            case 12:
                                ModificationClientAdresse();
                                Console.ReadKey();
                                break;
                            case 13:
                                ModificationCommisAdresse();
                                Console.ReadKey();
                                break;
                            case 14:
                                ModificationLivreurAdresse();
                                Console.ReadKey();
                                break;
                                #endregion
                        }
                        break;

                    #endregion

                    case 2:
                        #region Module2 Commandes
                        Console.Clear();
                        Console.WriteLine("1 - Ajouter une commande\n" +
                            "2 - Modifier l'état d'une commande\n" +
                            "3 - Valider ou non l'encaissement d'une commande\n" +
                            "4 - Afficher le prix d'une commande\n" +
                            "5 - Afficher une commande" +
                            "6 - Modifier l'heure d'une commande");
                        numReponse = Convert.ToInt32(Console.ReadLine());
                        while (numReponse < 1 || numReponse > 5)
                        {
                            Console.WriteLine("Entrez un numéro valide");
                            numReponse = Convert.ToInt32(Console.ReadLine());
                        }
                        switch (numReponse)
                        {
                            case 1:
                                numeroDeCommande++;
                                AjoutCommande();
                                break;

                            case 2:
                                Console.WriteLine("Entrez le numero de commande");
                                int numCommandeCherchee = Convert.ToInt32(Console.ReadLine());

                                int i = RechercheCommande(numCommandeCherchee);

                                if (i != -1)
                                {
                                    listeCommandes[i].ModifEtat();
                                }
                                else
                                {
                                    Console.WriteLine("Commande introuvable");
                                }

                                Console.ReadKey();
                                break;

                            case 3:
                                Console.WriteLine("Entrez le numero de commande");
                                numCommandeCherchee = Convert.ToInt32(Console.ReadLine());

                                i = RechercheCommande(numCommandeCherchee);

                                if (i != -1)
                                {
                                    listeCommandes[i].Encaisser(caisse);
                                }
                                else
                                {
                                    Console.WriteLine("Commande introuvable");
                                }

                                Console.ReadKey();
                                break;


                            case 4:
                                Console.WriteLine("Entrez le numero de commande");
                                numCommandeCherchee = Convert.ToInt32(Console.ReadLine());

                                RechercheCommandePrix(numCommandeCherchee);

                                Console.ReadKey();
                                break;


                            case 5:
                                Console.WriteLine("Entrez le numero de commande");
                                numCommandeCherchee = Convert.ToInt32(Console.ReadLine());

                                RechercheCommandeAff(numCommandeCherchee);

                                break;

                            case 6:
                                Console.WriteLine("Entrez le numero de commande");
                                numCommandeCherchee = Convert.ToInt32(Console.ReadLine());

                                ModificationCommandeHeure();

                                break;
                        }
                        break;
                    #endregion

                    case 3:
                        #region Module3 Statistiques
                        Console.WriteLine("1 - Afficher le nombre de commandes gérées par commis\n"
                                 + "2 - Afficher le nombre de livraisons effectuées par livreur\n"
                                 + "3 - Afficher les commandes selon une période de temps\n"
                                 + "4 - Afficher la moyenne des prix des commandes\n"
                                 + "5 - Afficher la moyenne des comptes clients");
                        numReponse = Convert.ToInt32(Console.ReadLine());
                        while (numReponse < 1 || numReponse > 5)
                        {
                            Console.WriteLine("Entrez un numéro valide");
                            numReponse = Convert.ToInt32(Console.ReadLine());
                        }
                        switch (numReponse)
                        {
                            case 1:
                                AfficherCommisCommandes();
                                break;

                            case 2:
                                AfficherLivreurLivraisons();
                                break;

                            case 3:
                                Console.WriteLine("Veuillez saisir la date de debut");
                                DateTime t1 = SaisieDate();
                                Console.WriteLine("Veuillez saisir la date de fin");
                                DateTime t2 = SaisieDate();

                                AfficherCommandePeriode(t1, t2);
                                Console.ReadKey();
                                break;


                            case 4:
                                Console.WriteLine("La moyenne des prix de commande est " + MoyenneCommande());
                                Console.ReadKey();
                                break;


                            case 5:
                                Console.WriteLine("La moyenne des comptes clients est " + MoyenneCptClient());
                                Console.ReadKey();
                                break;
                        }
                        Console.Clear();
                        break;


                    #endregion

                    case 4:
                        #region Module4 Autres
                        Console.WriteLine("1 - Enregistrer\n"
                                 + "2 - Utiliser un code promotion sur une commande\n"
                                 + "3 - Verifier si un code promo est utilisable\n"
                                 + "4 - Afficher tous les codes utlise");
                        numReponse = Convert.ToInt32(Console.ReadLine());
                        while (numReponse < 1 || numReponse > 4)
                        {
                            Console.WriteLine("Entrez un numéro valide");
                            numReponse = Convert.ToInt32(Console.ReadLine());
                        }
                        switch (numReponse)
                        {
                            case 1:
                                Console.Clear();
                                EcritureClients();
                                EcritureCommis();
                                EcritureLivreurs();
                                EcritureCommandes();
                                EcritureDetailsCommandes();
                                Console.ReadKey(); 

                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("Numero de commande : ");
                                int num = int.Parse(Console.ReadLine());
                                AppliquerCode(num);

                                //listeCommandes = AppliquerCode();
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Numero de telephone de client : ");
                                string tel = Console.ReadLine();
                                Console.WriteLine("Code promo : ");
                                string code = Console.ReadLine();
                                if (VerifierCode(code, listeClients[RechercheClientTel(tel)]))
                                {
                                    Console.WriteLine("Ce code a deja ete utilise");
                                }
                                else
                                {
                                    Console.WriteLine("Ce code est utilisable");
                                }
                                Console.ReadKey();
                                break;


                            case 4:
                                Console.Clear();
                                Console.WriteLine("Numero de telephone de client : ");
                                string t = Console.ReadLine();
                                foreach (string s in listeClients[RechercheClientTel(t)].ListeCodeUtilise)
                                {
                                    Console.WriteLine(s + " ");
                                }
                                Console.ReadKey();
                                break;

                        }
                        Console.Clear();
                        break;


                        #endregion


                }
                Console.WriteLine("\nTapez Q pour sortir ou un numero d'exo");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Q);

            Console.Read();
            Console.ReadKey();
        }

        //LECTURE & ECRITURE FICHIER
        #region Lecture/ecriture

        /// <summary>
        /// Récupère toutes les données des clients dans les excels
        /// </summary>
        /// <returns>liste des clients lue dans l'excel</returns>
        public List<Client> LectureClients()
        {
            List<Client> listeClients = new List<Client>();

            foreach (string[] tabLigne in LireFichier("./Clients.csv"))
            //foreach (string[] tabLigne in LireFichier("C:\\Users\\lefev\\OneDrive\\Documents\\Test.csv"))
            {
                List<Commande> listeCommandesClient = CreationListeCommandesClient(tabLigne[4]);
                listeClients.Add(new Client(tabLigne[0], tabLigne[1], tabLigne[2], tabLigne[3], tabLigne[4], Convert.ToDateTime(tabLigne[5]), Convert.ToInt32(tabLigne[6]), listeCommandesClient));
            }
            return listeClients;
        }

        public List<Commande> CreationListeCommandesClient(string numeroClient)
        {
            List<Commande> listeCommandesClients = new List<Commande>();
            foreach (Commande commande in listeCommandes)
            {
                if(commande.NumClient == numeroClient)
                {
                    listeCommandesClients.Add(commande);
                    
                }
            }
            return listeCommandesClients;
        }

        public void EcritureClients()
        {
            string clientToString = "";
            foreach (Client client in listeClients)
            {
                clientToString += client.Nom + ";" + client.Prenom + ";" + client.Adresse + ";" + client.Ville + ";" + Convert.ToString(client.NumeroTel) + "; " + Convert.ToString(client.DatePremiereCommande.Day) + "/" + Convert.ToString(client.DatePremiereCommande.Month) + "/" + Convert.ToString(client.DatePremiereCommande.Year) + ";" + Convert.ToString(client.Montant_achat) + ";" + "\n";

            }
            AppendFichier(clientToString, ".\\SaveClients.csv");
        }

        /// <summary>
        /// Construit la ligne d'écriture des éléments de la liste de commis et l'envoie dans la méthode qui écrit dans les excels
        /// </summary>
        public void EcritureCommis()
        {
            string commisToString = "";
            foreach (Commis commis in listeCommis)
            {
                commisToString += commis.Nom + ";" + commis.Prenom + ";" + commis.Adresse + ";" + Convert.ToString(commis.Numero) + "; " + Convert.ToString(commis.DateEmbauche.Day) + "/" + Convert.ToString(commis.DateEmbauche.Month) + "/" + Convert.ToString(commis.DateEmbauche.Year) + ";" + Convert.ToString(commis.NbCommandesGerees) + ";" + "\n";

            }
            AppendFichier(commisToString, ".\\SaveCommis.csv");
        }

        /// <summary>
        /// Construit la ligne d'écriture des éléments de la liste de livreurs et l'envoie dans la méthode qui écrit dans les excels
        /// </summary>
        public void EcritureLivreurs()
        {
            string livreurToString = "";
            foreach (Livreur livreur in listeLivreurs)
            {
                livreurToString += livreur.Nom + ";" + livreur.Prenom + ";" + livreur.Adresse + ";" + Convert.ToString(livreur.Numero) + ";" + Convert.ToString(livreur.MoyenTransport) + "\n";

            }
            AppendFichier(livreurToString, ".\\SaveLivreurs.csv");
        }

        /// <summary>
        /// Construit la ligne d'écriture des éléments de la liste de commande et l'envoie dans la méthode qui écrit dans les excels
        /// </summary>
        public void EcritureDetailsCommandes()
        {
            string commandeToString = "\n";
            foreach (Commande commande in listeCommandes)
            {
                foreach (Pizza pizza in commande.ListePizzas)
                {
                    commandeToString += commande.NumCommande + ";"+"Pizza ;" + pizza.Prix() + ";" + pizza.Type + ";" + pizza.Taille + "; ;" + pizza.Quantite + "\n";
                }
                foreach (Boisson boisson in commande.ListeBoissons)
                {
                    commandeToString += commande.NumCommande + ";" + boisson.Type + ";" + boisson.Prix()+"; ; ;" + boisson.Volume + ";" + boisson.Quantite;
                }
                
            }
            AppendFichier(commandeToString, ".\\SaveDetailsCommandes.csv");
        }

        /// <summary>
        /// Construit la ligne d'écriture des éléments de la liste de commandes et l'envoie dans la méthode qui écrit dans les excels
        /// </summary>
        public void EcritureCommandes()
        {
            string commandeToString = "\n";
            foreach (Commande commande in listeCommandes)
            {
                commandeToString += commande.NumCommande + ";" + commande.Heure + ";"+ commande.Date + ";"+ commande.NumClient + ";"+commande.NomCommis + ";" + commande.NomLivreur + ";" + commande.Etat + ";" ;
                if (commande.EstUnePerte)
                {
                    commandeToString += "perdue\n";
                }
                else
                {
                    commandeToString += "ok\n";
                }

            }
            AppendFichier(commandeToString, ".\\SaveDetailsCommandes.csv");
        }

        /// <summary>
        /// Construit la ligne d'écriture des éléments de la liste de livreurs et l'envoie dans la méthode qui écrit dans les excels
        /// </summary>
        public void EcritureLivreurs(List<Livreur> listeLivreur)
        {
            List<string> listStringCommis = new List<string>();
            string clientToString = "";
            foreach (Livreur livreur in listeLivreur)
            {
                clientToString += livreur.Nom + ";" + livreur.Prenom + ";" + livreur.Adresse + ";" + Convert.ToString(livreur.Numero) + ";" + Convert.ToString(livreur.MoyenTransport) + "\n";

            }
            AppendFichier(clientToString, ".\\SaveLivreurs.csv");
        }

        /// <summary>
        /// Récupère toutes les données des commis dans les excels
        /// </summary>
        /// <returns>liste des commis lue dans l'excel</returns>
        public List<Commis> LectureCommis()
        {
            List<Commis> listeCommis = new List<Commis>();

            foreach (string[] tabLigne in LireFichier("./Commis.csv"))
            {
                listeCommis.Add(new Commis(tabLigne[0], tabLigne[1], tabLigne[2], tabLigne[3], tabLigne[4], Convert.ToDateTime(tabLigne[5]), Convert.ToInt32(tabLigne[6])));
            }
            return listeCommis;
        }

        /// <summary>
        /// Récupère toutes les données des livreurs dans les excels
        /// </summary>
        /// <returns>liste des livreurs lue dans l'excel</returns>
        public List<Livreur> LectureLivreurs()
        {
            List<Livreur> listeLivreur = new List<Livreur>();

            foreach (string[] tabLigne in LireFichier("./Livreur.csv"))
            {
                listeLivreur.Add(new Livreur(tabLigne[0], tabLigne[1], tabLigne[2], tabLigne[3], tabLigne[4], tabLigne[5], Convert.ToInt32(tabLigne[6])));
            }
            return listeLivreur;
        }

        /// <summary>
        /// Récupère toutes les données des codes de promotion dans les excels
        /// </summary>
        /// <returns>liste des livreurs lue dans l'excel</returns>
        public SortedList<string, float> LecturePromoss()
        {
            SortedList<string, float> listePromos = new SortedList<string, float>();

            foreach (string[] tabLigne in LireFichier("./Promos.csv"))
            {
                listePromos.Add(Convert.ToString(tabLigne[0]), float.Parse(tabLigne[1]));
            }
            return listePromos;
        }

        /// <summary>
        /// Récupère toutes les données des commandes dans les excels "Commandes" et "DetailsCommandes"
        /// </summary>
        /// <returns>liste des clients lue dans l'excel</returns>
        public void LectureCommandes()
        {
            List<string[]> lectureDetailsCommandes = LireFichier("./DetailsCommandes.csv");
            List<string[]> lectureCommandes = LireFichier("./Commandes.csv");
            //la liste contient chaques lignes, dont chaque cases sont séparés dans un tableau

            foreach (string[] tabLigneDetailsCommandes in lectureDetailsCommandes)
            {
                if (tabLigneDetailsCommandes[0] != "Num Commande")
                {
                    List<Pizza> listePizza = new List<Pizza>();
                    List<Boisson> listeBoisson = new List<Boisson>();

                    Boisson boisson = new Boisson();
                    Pizza pizza = new Pizza();

                    if (tabLigneDetailsCommandes[1] == "Pizza")
                    {
                        pizza =  new Pizza(tabLigneDetailsCommandes[4], tabLigneDetailsCommandes[3], Convert.ToInt32(tabLigneDetailsCommandes[6]) );
                        listePizza.Add(new Pizza(tabLigneDetailsCommandes[4], tabLigneDetailsCommandes[3], Convert.ToInt32(tabLigneDetailsCommandes[6])));
                    }
                    else if (tabLigneDetailsCommandes[1] == "Coca" || tabLigneDetailsCommandes[1] == "Jus d'orange" || tabLigneDetailsCommandes[1] == "Fanta")
                    {
                        boisson = new Boisson(tabLigneDetailsCommandes[1], tabLigneDetailsCommandes[5], Convert.ToInt32(tabLigneDetailsCommandes[6]));
                        listeBoisson.Add(new Boisson(tabLigneDetailsCommandes[1], tabLigneDetailsCommandes[5], Convert.ToInt32(tabLigneDetailsCommandes[6])));
                    }
                    int numeroDeCommande = Convert.ToInt32(tabLigneDetailsCommandes[0]);

                    string numClient = "";
                    string nomCommis = "";
                    string nomLivreur = "";
                    TimeSpan heure = new TimeSpan();
                    DateTime date = new DateTime();
                    foreach (string[] tabLigneCommandes in lectureCommandes)
                    {
                        if (tabLigneCommandes[0] != "Num Commande")
                        {
                            if (Convert.ToInt32(tabLigneCommandes[0]) == numeroDeCommande)
                            {
                                numClient = tabLigneCommandes[3];
                                nomCommis = tabLigneCommandes[4];
                                nomLivreur = tabLigneCommandes[5];
                                date = Convert.ToDateTime(tabLigneCommandes[2]);
                                heure = TimeSpan.Parse(tabLigneCommandes[1]);
                            }
                        }
                    }
                    if(listeCommandes != null)
                    {
                        if (RechercheCommande(numeroDeCommande) == -1)
                        {
                            listeCommandes.Add(new Commande(listePizza, listeBoisson, heure, numClient, nomCommis, numeroDeCommande, nomLivreur, date));
                        }
                        else
                        {
                            if (boisson.Quantite != 0)
                            {
                                listeCommandes[RechercheCommande(numeroDeCommande)].ListeBoissons.Add(boisson);
                            }
                            else if (pizza.Quantite != 0)
                            {
                                listeCommandes[RechercheCommande(numeroDeCommande)].ListePizzas.Add(pizza);
                            }
                        }
                    }
                    else
                    {
                        listeCommandes = new List<Commande>();
                        Commande cmd = new Commande(listePizza, listeBoisson, heure, numClient, nomCommis, numeroDeCommande, nomLivreur, date);
                        cmd.GetPrix = cmd.Prix();
                        listeCommandes.Add(cmd);
                    }
                    
                    
                }
            }
        }

        /// <summary>
        /// Récupère toutes les données d'un excel en utilisant le chemin "file name"
        /// </summary>
        /// <returns>liste des éléments lus dans l'excel</returns>
        public List<string[]> LireFichier(string filename)
        {
            string nomFich = filename;
            //string filenameCommande = "./Commandes.csv";
            //string filenameCommis = "./Commis.csv";
            //string filenameDetailsCommandes = "./DetailsCommandes.csv";
            //string filenameLivreurs = "./Livreur - Copy.csv";

            StreamReader fichLect = new StreamReader(nomFich);
            char[] sep = new char[1] { ';' };
            string ligne = "";
            string[] datas = new string[6];
            string result = "";
            List<string[]> listeResult = new List<string[]>();

            while (fichLect.Peek() > 0)
            {
                ligne = fichLect.ReadLine();

                result += "ligne lue : " + ligne + "\n";

                datas = ligne.Split(sep);
                listeResult.Add(datas);
            }
            fichLect.Close();
            return listeResult;
        }

        /// <summary>
        /// Ecriture d'une ligne entrée en paramètre dans un fichier dont le chemin est filename
        /// </summary>
        /// <param name="ligne">ligne à rentrer</param>
        /// <param name="filename">chemin du fichier</param>
        public void AppendFichier(string ligne, string filename)
        {
            StreamWriter file = null;

            try
            {
                file = new StreamWriter(filename);
                file.Write(ligne); ;
                Console.WriteLine("Ligne ajoutée avec succès\n");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }
        #endregion

        //AFFICHAGES
        #region AFFICHAGES

        /// <summary>
        /// Passe en revue tous les clients de la liste et return un string les contenant
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public string AfficherTousClients(List<Client> listeClients)
        {
            string result = "";
            foreach (Client client in listeClients)
            {
                result += client;
            }
            return result;
        }

        /// <summary>
        /// Passe en revue toutes les commandes de la liste et return un string les contenant
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public string AfficherToutesCommandes(List<Commande> listeCommandes)
        {
            string result = "";
            foreach (Commande commande in listeCommandes)
            {
                result += commande;
            }
            return result;
        }

        /// <summary>
        /// Passe en revue tous les commis de la liste et return un string les contenant
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public string AfficherToutesCommis(List<Commis> listeCommis)
        {
            string result = "";
            foreach (Commis commis in listeCommis)
            {
                result += commis;
            }
            return result;
        }

        /// <summary>
        /// Passe en revue tous les livreurs de la liste et return un string les contenant
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public string AfficherTousLivreurs(List<Livreur> listeLivreurs)
        {
            string result = "";
            foreach (Livreur livreur in listeLivreurs)
            {
                result += livreur;
            }
            return result;
        }
        #endregion

        //TRIS
        #region TRIS

        /// <summary>
        /// Return un string des clients triés dans l'ordre alphabétique
        /// </summary>
        /// <returns></returns>
        public string AfficherAlphabetiqueClients()
        {
            string result = "";
            listeClients.Sort((Client client1, Client client2) => client1.Nom.CompareTo(client2.Nom));
            listeClients.ForEach(x => result += x + "\n");
            return result;
        }

        /// <summary>
        /// Return un string des livreurs triés dans l'ordre alphabétique
        /// </summary>
        /// <returns></returns>
        public string AfficherAlphabetiqueLivreurs()
        {
            string result = "";
            Console.WriteLine("\n Affichage selon le nom \n");
            listeLivreurs.Sort((Livreur livreur1, Livreur livreur2) => livreur1.Nom.CompareTo(livreur2.Nom));
            listeLivreurs.ForEach(x => result += x + "\n");
            return result;
        }

        /// <summary>
        /// Return un string des commis triés dans l'ordre alphabétique
        /// </summary>
        /// <returns></returns>
        public string AfficherAlphabetiqueCommis()
        {
            string result = "";
            Console.WriteLine("\n Affichage selon le nom \n");
            listeCommis.Sort((Commis commis1, Commis commis2) => commis1.Nom.CompareTo(commis2.Nom));
            listeCommis.ForEach(x => result += x + "\n");
            return result;
        }

        /// <summary>
        /// Return un string des clients triés selon leur ville
        /// </summary>
        /// <returns></returns>
        public string AfficherVille()
        {
            string result = "";
            Console.WriteLine("\n Tri selon la ville \n");
            listeClients.Sort(delegate (Client a1, Client b1) { return Client.CompareVille(a1, b1); });
            listeClients.ForEach(x => result += x + "\n");
            return result;
        }

        /// <summary>
        /// return un string des clients triés selon leur montant d'achat
        /// </summary>
        /// <returns></returns>
        public string AfficherMeilleurClient()
        {
            string result = "";
            Console.WriteLine("\n Tri selon le montant d'achat \n");
            listeClients.Sort(delegate (Client a1, Client b1) { return Client.CompareAchat(a1, b1); });
            listeClients.ForEach(x => result += x + "\n");
            return result;
        }

        /// <summary>
        /// Return un string des livreurs selon leur nombre de livraisons effectuées
        /// </summary>
        /// <returns></returns>
        public string AfficherNbCommandeEffectueParLivreur()
        {
            string result = "";
            Console.WriteLine("\n Tri selon le nombre de commandes effectuees \n");
            listeLivreurs.Sort(delegate (Livreur a1, Livreur b1) { return Livreur.CompareLivraison(a1, b1); });
            listeLivreurs.ForEach(x => result += x + "\n");
            return result;
        }

        /// <summary>
        /// Return un string des commis selon leur nombre de commandes effectuées
        /// </summary>
        /// <returns></returns>
        public string AfficherNbCommandeEffectueParCommis()
        {
            string result = "";
            Console.WriteLine("\n Tri selon le nombre de commandes effectuees \n");
            listeCommis.Sort(delegate (Commis a1, Commis b1) { return Commis.CompareCommande(a1, b1); });
            listeCommis.ForEach(x => result += x + "\n");
            return result;
        }
        #endregion

        //AFFICHAGES PARTIELS
        #region AFFICHAGES PARTIELS

        /// <summary>
        /// Return un string des commis avec leur nombre de commandes gérées
        /// </summary>
        /// <returns></returns>
        public string AfficherCommisCommandes()
        {
            string result = "";
            foreach (Commis commis in listeCommis)
            {
                result += commis.Nom + " Nombre de  commandes gérées : " + commis.NbCommandesGerees + "\n";
            }
            return result;
        }

        /// <summary>
        /// Return un string des livreurs avec leur nombre de commandes gérées
        /// </summary>
        /// <returns></returns>
        public string AfficherLivreurLivraisons()
        {
            string result = "";
            foreach (Livreur livreur in listeLivreurs)
            {
                result += livreur.Nom + " Nombre de  commandes gérées : " + livreur.NbLivraison + "\n";
            }

            return result;
        }

        /// <summary>
        /// Return un string des commandes triées selon leur date de création
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public string AfficherCommandePeriode(DateTime fin, DateTime debut)
        {
            string result = "";
            //Console.WriteLine("\n Tri selon le periode des commandes effectuees \n");
            foreach (Commande commande in listeCommandes)
            {
                if (commande.Date.Year < fin.Year && commande.Date.Year > debut.Year)
                {
                    result += commande.NumCommande +" ";
                }
                else if(commande.Date.Year == fin.Year)
                {
                    if (commande.Date.Month < fin.Month && commande.Date.Month > debut.Month)
                    {
                        result += commande.NumCommande + " ";
                    }
                    else if(commande.Date.Month == fin.Month)
                    {
                        if (commande.Date.Day < fin.Day && commande.Date.Day > debut.Day)
                        {
                            result += commande.NumCommande + " ";
                        }
                    }
                }
            }
            return result;
        }
        #endregion

        //RECHERCHES
        #region RECHERCHES

        /// <summary>
        /// Return une commande à partir d'un numéro de téléphone d'un client
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int RechercheCommande(int num)
        {
            bool commandeTrouvee = false;
            int i = 0;
            for (i = 0; i < listeCommandes.Count; i++)
            {
                if (listeCommandes[i].NumCommande == num)
                {
                    commandeTrouvee = true;
                    break;
                }
            }
            if (!commandeTrouvee) { i = -1; }
            return i;
        }

        /// <summary>
        /// Return une commande à partir d'un numéro de téléphone d'un client
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string RechercheCommandeAff(int num)
        {
            string result = "";
            bool commandeTrouvee = false;
            foreach (Commande c in listeCommandes)
            {
                if (c.NumCommande == num)
                {
                    result += c;
                    commandeTrouvee = true;
                    break;
                }
            }
            if (!commandeTrouvee) { result = "Commande introuvable."; }
            return result;
        }

        /// <summary>
        /// Return le prix d'une commande à partir d'un numéro de téléphone d'un client
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string RechercheCommandePrix(int num)
        {
            string result = "";
            bool commandeTrouvee = false;
            foreach (Commande c in listeCommandes)
            {
                if (c.NumCommande == num)
                {
                    result += c.Prix();
                    commandeTrouvee = true;
                    break;
                }
            }
            if (!commandeTrouvee) { Console.WriteLine("Commande introuvable."); }
            return result;
        }

        /// <summary>
        /// Return l'indice d'un client dans la liste à partir de son numéro de téléphone
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int RechercheClientTel(string numeroTel)
        {
            bool Trouvee = false;
            int i = 0;
            for (i = 0; i < listeClients.Count; i++)
            {
                if (listeClients[i].NumeroTel == numeroTel)
                {
                    Trouvee = true;
                    break;
                }
            }
            if (!Trouvee) { i = -1; }
            return i;
        }

        /// <summary>
        /// Return l'indice d'un client dans la liste à partir de son nom
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int RechercheClientNom(string nom)
        {
            bool Trouvee = false;
            int i = 0;
            for (i = 0; i < listeClients.Count; i++)
            {
                if (listeClients[i].Nom == nom)
                {
                    Trouvee = true;
                    break;
                }
            }
            if (!Trouvee) { i = -1; }
            return i;
        }

        /// <summary>
        /// Return l'indice d'un commis dans la liste à partir de son numéro de téléphone
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int RechercheCommis(string nom)
        {
            bool Trouvee = false;
            int i = 0;
            for (i = 0; i < listeCommis.Count; i++)
            {
                if (listeCommis[i].Nom == nom)
                {
                    Trouvee = true;
                    break;
                }
            }
            if (!Trouvee) { i = -1; }
            return i;
        }

        /// <summary>
        /// Return l'indice d'un livreur dans la liste à partir de son numéro de téléphone
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int RechercheLivreur(string nom)
        {
            bool Trouvee = false;
            int i = 0;
            for (i = 0; i < listeLivreurs.Count; i++)
            {
                if (listeLivreurs[i].Nom == nom)
                {
                    Trouvee = true;
                    break;
                }
            }
            if (!Trouvee) { i = -1; }
            return i;
        }
        #endregion

        //SUPPRESSION
        #region SUPPRESSION

        /// <summary>
        /// Supprime un client de la liste en fonction de son numero entré
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public void SuppressionClient()
        {
            Console.WriteLine("Rentrez le numero du client");
            string num = Console.ReadLine();
            if (RechercheClientTel(num) == -1) { Console.WriteLine("Client non trouve"); }
            else { listeClients.RemoveAt(RechercheClientTel(num)); }
            Console.WriteLine("Suppression reussie");
        }

        /// <summary>
        /// Supprime un commis de la liste en fonction de son nom
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public void SuppressionCommis()
        {
            Console.WriteLine("Rentrez le nom du commis");
            string nom = Console.ReadLine();
            if (RechercheCommis(nom) == -1) { Console.WriteLine("Commis non trouve"); }
            else { listeCommis.RemoveAt(RechercheCommis(nom)); }
            Console.WriteLine("Suppression reussie");
        }

        /// <summary>
        /// Supprime un livreur de la liste en fonction de son nom
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public void SuppressionLivreur()
        {
            Console.WriteLine("Rentrez le nom du livreur");
            string nom = Console.ReadLine();
            foreach (Livreur livreur in listeLivreurs)
            {
                if (livreur.Nom == nom)
                {
                    listeLivreurs.Remove(livreur);
                }
            }
            Console.WriteLine("Suppression reussie");
        }
        #endregion

        //MODIFICATION
        #region MODIFICATION

        /// <summary>
        /// Demande un numero de client et sa nouvelle adresse et le modifie
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public void ModificationClientAdresse()
        {
            Console.WriteLine("Rentrez le numero du client");
            string num = Console.ReadLine();
            if (RechercheClientTel(num) == -1) { Console.WriteLine("Client non trouve"); }
            else
            {
                int index = RechercheClientTel(num);
                Console.WriteLine("Nouvelle adresse : ");
                listeClients[index].Adresse = Console.ReadLine();
            }
            Console.WriteLine("Modification reussie");
        }

        /// <summary>
        /// Demande un nom de commis et sa nouvelle adresse et le modifie
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public void ModificationCommisAdresse()
        {
            Console.WriteLine("Rentrez le nom du commis");
            string num = Console.ReadLine();
            if (RechercheCommis(num) == -1) { Console.WriteLine("Commis non trouve"); }
            else
            {
                int index = RechercheCommis(num);
                Console.WriteLine("Nouvelle adresse : ");
                listeCommis[index].Adresse = Console.ReadLine();
            }
            Console.WriteLine("Modification reussie");
        }

        /// <summary>
        /// Demande un nom de livreur et sa nouvelle adresse et le modifie
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public void ModificationLivreurAdresse()
        {
            Console.WriteLine("Rentrez le nom du livreur");
            string num = Console.ReadLine();
            if (RechercheLivreur(num) == -1) { Console.WriteLine("Livreur non trouve"); }
            else
            {
                int index = RechercheLivreur(num);
                Console.WriteLine("Nouvelle adresse : ");
                listeLivreurs[index].Adresse = Console.ReadLine();
            }
            Console.WriteLine("Modification reussie");
        }

        /// <summary>
        /// Demande un numero de commande et sa nouvelle heure et la modifie
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public void ModificationCommandeHeure()
        {
            Console.WriteLine("Rentrez le numero de la commande");
            int num = int.Parse(Console.ReadLine());
            if (RechercheCommande(num) == -1) { Console.WriteLine("Commande non trouve"); }
            else
            {
                int index = RechercheCommande(num);
                Console.WriteLine("Nouvelle heure : ");
                listeCommandes[index].Heure = TimeSpan.Parse(Console.ReadLine());
            }
            Console.WriteLine("Modification reussie");
        }
        #endregion

        //MOYENNES
        #region MOYENNES

        /// <summary>
        /// Return la moyenne des prix de toutes les commandes
        /// </summary>
        /// <returns></returns>
        public float MoyenneCommande()
        {
            float res = 0;
            int i = 0;
            foreach (Commande c in listeCommandes)
            {
                if (c != null)
                {
                    res += c.Prix();
                    i++;
                }
            }
            return (float)res / i;
        }

        /// <summary>
        /// Return la moyenne de toutes les dépenses de tous les clients
        /// </summary>
        /// <returns></returns>
        public float MoyenneCptClient()
        {
            float res = 0;
            int i = 0;
            foreach (Client c in listeClients)
            {
                if (c != null)
                {
                    res += c.Moyenne();
                    i++;
                }
            }
            return (float)res / i;
        }



        #endregion

        //AJOUTS
        #region AJOUTS
        /// <summary>
        /// Demande à l'utilisateur de rentrer tous les attributs d'un client et le crée
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public List<Client> AjoutClient(List<Client> listeClients)
        {
            Console.WriteLine("Rentrez le nom du client");
            string nom = Console.ReadLine();
            Console.WriteLine("Rentrez le prenom du client");
            string prenom = Console.ReadLine();
            Console.WriteLine("Rentrez l'adresse du client");
            string adresse = Console.ReadLine();
            Console.WriteLine("Rentrez la ville du client");
            string ville = Console.ReadLine();
            Console.WriteLine("Rentrez le numero de telephone du client");
            string numTelephone = Console.ReadLine();
            Console.WriteLine("Rentrez la date de la premiere commande du client");
            DateTime datePremiereCommande = SaisieDate();
            //DateTime datePremiereCommande = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Rentrez le montant de la premiere commande du client");
            double montantPremiereCommande = Convert.ToDouble(Console.ReadLine());

            listeClients.Add(new Client(nom, prenom, adresse, ville, numTelephone, datePremiereCommande, montantPremiereCommande));

            return listeClients;
        }

        /// <summary>
        /// Demande à l'utilisateur de rentrer tous les attributs d'un commis et le crée
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public List<Commis> AjoutCommis(List<Commis> listeCommis)
        {
            Console.WriteLine("Rentrez le nom du commis");
            string nom = Console.ReadLine();
            Console.WriteLine("Rentrez le prenom du commis");
            string prenom = Console.ReadLine();
            Console.WriteLine("Rentrez l'adresse du commis");
            string adresse = Console.ReadLine();
            Console.WriteLine("Rentrez le numero du commis");
            string numero = Console.ReadLine();
            Console.WriteLine("Rentrez la date d'embauche du commis");
            //DateTime dateEmbauche = Convert.ToDateTime(Console.ReadLine());
            DateTime dateEmbauche = SaisieDate();

            Commis commis = new Commis(nom, prenom, adresse, numero, "en conge", dateEmbauche, 0);
            listeCommis.Add(commis);
            return listeCommis;
        }

        /// <summary>
        /// Demande à l'utilisateur de rentrer tous les attributs d'un livreur et le crée
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public List<Livreur> AjoutLivreur(List<Livreur> listeLivreur)
        {
            Console.WriteLine("Rentrez le nom du livreur");
            string nom = Console.ReadLine();
            Console.WriteLine("Rentrez le prenom du livreur");
            string prenom = Console.ReadLine();
            Console.WriteLine("Rentrez le numero du livreur");
            string num = Console.ReadLine();
            Console.WriteLine("Rentrez l'adresse du livreur");
            string adresse = Console.ReadLine();
            Console.WriteLine("Rentrez le moyen de transport du livreur");
            string moyenTransport = Console.ReadLine();
            Console.WriteLine("Rentrez l'etat du livreur (Sur place ou en congé)");
            string etatLivreur = Console.ReadLine();

            Livreur livreur = new Livreur(nom, prenom, adresse, num, etatLivreur, moyenTransport, 0);
            listeLivreur.Add(livreur);
            return listeLivreur;
        }

        /// <summary>
        /// Demande à l'utilisateur de rentrer tous les détails d'une commande et la crée
        /// </summary>
        /// <param name="listeClients"></param>
        /// <returns></returns>
        public List<Commande> AjoutCommande()
        {
            Console.WriteLine("1 - Entrer l'heure de la commande manuellement\n2 - Prendre l'heure actuelle");
            int reponse = Convert.ToInt32(Console.ReadLine());
            TimeSpan heureCommande;
            if (reponse == 1)
            {
                Console.WriteLine("Rentrez l'heure de la commande");
                heureCommande = TimeSpan.Parse(Console.ReadLine());
            }
            else if (reponse == 2)
            {
                heureCommande = TimeSpan.Parse(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
            }
            else
            {
                Console.WriteLine("Saisie invalide");
                Console.WriteLine("Rentrez l'heure de la commande");
                heureCommande = TimeSpan.Parse(Console.ReadLine());
            }

            Console.WriteLine("Rentrez le nom du client");
            string nomClient = Console.ReadLine();

            Console.WriteLine("Rentrez le numero du livreur");
            string numLiveur = Console.ReadLine();

            Console.WriteLine("Rentrez le nom du commis");
            string nomCommis = Console.ReadLine();

            foreach (Commis commis in listeCommis)
            {
                if (commis.Nom == nomCommis)
                {
                    commis.NbCommandesGerees++;
                }
            }

            foreach (Livreur livreur in listeLivreurs)
            {
                if (livreur.Numero == numLiveur)
                {
                    livreur.NbLivraison++;
                }
            }


            DateTime dateCommande = SaisieDate();


            Commande commande = new Commande(heureCommande, dateCommande, nomClient, nomCommis, numeroDeCommande, numLiveur);

            commande.AjoutPizza();
            commande.AjoutBoisson();

            commande.GetPrix = commande.Prix();

            listeCommandes.Add(commande);

            bool trouve = false;
            while (!trouve)
            {
                foreach (Client client in listeClients)
                {
                    if (client.Nom == nomClient)
                    {
                        client.ListeCommande.Add(commande);
                        client.Montant_achat += commande.GetPrix;
                        trouve = true;
                    }
                }
            }


            Console.WriteLine("Votre commande a bien ete enregistee, nomero de commande : " + commande.NumCommande);

            return listeCommandes;
        }
        #endregion

        /// <summary>
        /// Demande à l'utilisateur d'entrer une date valide
        /// </summary>
        /// <returns></returns>
        public DateTime SaisieDate()
        {
            DateTime t1 = new DateTime();
            Console.WriteLine("1 - Entrer le jour de la commande manuellement\n2 - Prendre le jour actuel");
            int reponse = Convert.ToInt32(Console.ReadLine());

            if (reponse == 1)
            {
                Console.WriteLine("Rentrez la date de la commande");
                t1 = Convert.ToDateTime(Console.ReadLine());
            }
            else if (reponse == 2)
            {
                t1 = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Saisie invalide");
                Console.WriteLine("1 - Entrer le jour de la commande manuellement\n2 - Prendre le jour actuel");
                reponse = Convert.ToInt32(Console.ReadLine());
            }

            return t1;
        }

        //AUTRES
        #region Autre
        /// <summary>
        /// Permet de vérifier qu'un code promo n'a pas été utilisé
        /// </summary>
        /// <param name="code">le code promo</param>
        /// <param name="c">le client</param>
        /// <returns></returns>
        public bool VerifierCode(string code, Client c)
        {
            bool res = false;
            foreach (string s in c.ListeCodeUtilise)
            {
                if (code == s) { res = true; break; }
            }
            return res;
        }

        /// <summary>
        /// Permet d'appliquer un code promo sur une commande
        /// L'utilisateur rentre un code de promotion et une commande, si la commande existe et que le code de promotion n'est pas utilisé
        /// on enleve le montant du code promo à la commande choisie, on enlève le montant au montant des achats du client,
        /// on ajoute le code à la liste de codes utilisés par le client
        /// </summary>
        /// <param name="num">numéro de la commande sur laquelle appliquer le code</param>
        public void AppliquerCode(int num)
        {

            Console.WriteLine("Souhaitez-vous utiliser un code promo ? o/n");
            string i = Console.ReadLine();
            while (i != "o" && i != "n")
            {
                Console.WriteLine("Rentrez une option valide (o/n)");
                i = Console.ReadLine();
            }
            if (i == "o")
            {
                int index = RechercheCommande(num);
                if (index == -1) { Console.WriteLine("Commande non trouvee"); }
                else
                {
                    Console.WriteLine("Code promo :");
                    string code = Console.ReadLine();

                    if (VerifierCode(code, listeClients[RechercheClientTel(listeCommandes[index].NumClient)]))
                    {
                        float montant = listeCodePromo.ElementAt(listeCodePromo.IndexOfKey(code)).Value;
                        listeCommandes[index].GetPrix -= montant;
                        listeClients[RechercheClientTel(listeCommandes[index].NumClient)].Montant_achat -= montant;
                        listeClients[RechercheClientTel(listeCommandes[index].NumClient)].ListeCodeUtilise.Add(code);

                        Console.WriteLine("Code promo applique. ");

                    }
                    else { Console.WriteLine("Code deja utilise"); }
                }

            }


        }

        #endregion


        #region Proprietes
        public List<Commande> ListeCommandes
        {
            get { return listeCommandes; }
            set { listeCommandes = value; }
        }
        public List<Commis> ListeCommis
        {
            get { return listeCommis; }
            set { listeCommis = value; }
        }
        public List<Client> ListeClients
        {
            get { return listeClients; }
            set { listeClients = value; }
        }
        public List<Livreur> ListeLivreurs
        {
            get { return listeLivreurs; }
            set { listeLivreurs = value; }
        }
        public SortedList<string, float> ListeCodePromo
        {
            get { return listeCodePromo; }
            set { listeCodePromo = value; }
        }
        public int NumCommande
        {
            get { return numeroDeCommande; }
            set { numeroDeCommande = value; }
        }
        public float Caisse
        {
            get { return caisse; }
            set { caisse = value; }
        }
        #endregion
    }
}





