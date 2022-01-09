using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre
{
    /// <summary>
    /// Logique d'interaction pour Module2.xaml
    /// </summary>
    public partial class Module2 : Window
    {
        Pizzeria pizzeria;
        Commande commande;
        List<Pizza> listePizzas = new List<Pizza>();
        List<Boisson> listeBoissons = new List<Boisson>();
        int numCommandeCherchee;
        int position;
        Commande commande1;


        /// <summary>
        /// Constructeur du module 2
        /// </summary>
        /// <param name="pizzeria"></param>
        public Module2(Pizzeria pizzeria)
        {
            InitializeComponent();
            this.pizzeria = pizzeria;
            commande = new Commande();
            listePizzas = new List<Pizza>();
            listeBoissons = new List<Boisson>();
            ReinitialiserAffichage();
            
        }

        /// <summary>
        /// Remet l'affichage par défaut sur la fenetre de choix des méthodes
        /// </summary>
        public void ReinitialiserAffichage()
        {
            ListBoxM2.Visibility = Visibility.Visible;

            MonTexteBlock.Visibility = Visibility.Visible;

            AjoutCommandeAjoutPizza.Visibility = Visibility.Hidden;
            AjoutCommandeInfoClientCommisLivreur.Visibility = Visibility.Hidden;
            AjoutCommandeAjoutBoisson.Visibility = Visibility.Hidden;

            BoutonValiderAjoutBoisson.Visibility = Visibility.Hidden;
            BoutonValiderAjoutPizza.Visibility = Visibility.Hidden;
            BoutonValiderAjoutCommande.Visibility = Visibility.Hidden;

            BoutonValiderNumeroModification.Visibility = Visibility.Hidden;
            BoutonValiderModification.Visibility = Visibility.Hidden;
            ModificationCommande.Visibility = Visibility.Hidden;
            PanelRecherche.Visibility = Visibility.Hidden;

            BoutonValiderNumeroAffichage.Visibility = Visibility.Hidden;

            BoutonAjoutPizza.Visibility = Visibility.Hidden;
            BoutonAjoutBoisson.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Pour chaque méthode à partir d'ici, on cache tous les éléméents que l'on ne veut plus afficher (menu de sélection)
        /// et on affiche le nouveau menu d'entrée de texte avec les textbox et text blocks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjoutCommande(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            ListBoxM2.Visibility = Visibility.Hidden;
            MaTexteBox.Visibility = Visibility.Hidden;
            AjoutCommandeInfoClientCommisLivreur.Visibility = Visibility.Visible;
            BoutonValiderAjoutCommande.Visibility = Visibility.Visible;
            BoutonAjoutPizza.Visibility = Visibility.Visible;
            BoutonAjoutBoisson.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Ce bouton récupère tous les éléments rentrés dans les TextBox concernant les information de client & commis & livreur lors de l'ajout d'une commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBoutonValiderAjoutCommande(object sender, RoutedEventArgs e)
        {
            string nomClient = TextBoxAjoutCommandeNomClient.Text;
            string nomLivreur = TextBoxAjoutCommandeNomLivreur.Text;
            string nomCommis = TextBoxAjoutCommandeNomCommis.Text;

            commande = new Commande(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), DateTime.Now, nomClient, nomCommis, pizzeria.NumCommande, nomLivreur);
            commande.ListePizzas = listePizzas;
            commande.ListeBoissons = listeBoissons;


            #region actualiser nombre de commandes gerees par commis & livreur
            foreach (Commis commis in pizzeria.ListeCommis)
            {
                if (commis.Nom == commande.NomCommis)
                {
                    commis.NbCommandesGerees++;
                    break;
                }
            }

            foreach (Livreur livreur in pizzeria.ListeLivreurs)
            {
                if (livreur.Numero == commande.NomLivreur)
                {
                    livreur.NbLivraison++;
                    break;
                }
            }
            #endregion

            commande.GetPrix = commande.Prix();

            pizzeria.ListeCommandes.Add(commande);

            #region actualiser nombre d'achats effectues par client
            


            foreach (Client client in pizzeria.ListeClients)
            {
                if (client.NumeroTel == commande.NumClient)
                {
                    client.ListeCommande.Add(commande);
                    client.Montant_achat += commande.GetPrix;
                }
            }
            #endregion


            ReinitialiserAffichage();

            MonTexteBlock.Text = "Votre commande a bien ete enregistee, numero de commande : " + commande.NumCommande;

            pizzeria.NumCommande++;
        }

        /// <summary>
        /// Met à jour l'affichage pour l'ajout des pizzas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjoutPizza(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            ListBoxM2.Visibility = Visibility.Hidden;
            AjoutCommandeAjoutPizza.Visibility = Visibility.Visible;
            BoutonValiderAjoutPizza.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Ce bouton récupère tous les éléments rentrés dans les TextBox concernant les informations de pizza lors de l'ajout d'une commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBoutonValiderAjoutPizza(object sender, RoutedEventArgs e)
        {
            string taille = TextBoxAjoutPizzaTaille.Text;
            string type = TextBoxAjoutPizzaType.Text;
            int quantite = int.Parse(TextBoxAjoutPizzaQuantite.Text);

            Pizza p = new Pizza(taille, type, quantite);

            listePizzas.Add(p);

            ReinitialiserAffichage();
            ListBoxM2.Visibility = Visibility.Hidden;
            MonTexteBlock.Visibility = Visibility.Visible;
            AjoutCommandeInfoClientCommisLivreur.Visibility = Visibility.Visible;

            BoutonAjoutPizza.Visibility = Visibility.Visible;
            BoutonAjoutBoisson.Visibility = Visibility.Visible;
            BoutonValiderAjoutCommande.Visibility = Visibility.Visible;
            MonTexteBlock.Text = "Ajout pizza reussi.\nNombre de pizzas dans la commande : " + listePizzas.Count ;
        }

        /// <summary>
        /// Met à jour l'affichage pour l'ajout des boissons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjoutBoisson(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            ListBoxM2.Visibility = Visibility.Hidden;
            AjoutCommandeAjoutBoisson.Visibility = Visibility.Visible;
            BoutonValiderAjoutBoisson.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Ce bouton récupère tous les éléments rentrés dans les TextBox concernant les indormation de boisson lors de l'ajout d'une commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBoutonValiderAjoutBoisson(object sender, RoutedEventArgs e)
        {
            string type = TextBoxAjoutBoissonType.Text;
            string volume = TextBoxAjoutBoissonVolume.Text;
            int quantite = int.Parse(TextBoxAjoutBoissonQuantite.Text);

            Boisson b = new Boisson(type, volume, quantite);

            listeBoissons.Add(b);
            ReinitialiserAffichage();
            ListBoxM2.Visibility = Visibility.Hidden;
            MonTexteBlock.Visibility = Visibility.Visible;
            AjoutCommandeInfoClientCommisLivreur.Visibility = Visibility.Visible;
            BoutonAjoutPizza.Visibility = Visibility.Visible;
            BoutonAjoutBoisson.Visibility = Visibility.Visible;
            BoutonValiderAjoutCommande.Visibility = Visibility.Visible;
            MonTexteBlock.Text = "Ajout boisson reussi.\nNombre de boissons dans la commande : " + listeBoissons.Count;
        }

        /// <summary>
        /// Met à jour l'affichage pour afficher le prix de la commande recherchee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherPrixCommande(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            ListBoxM2.Visibility = Visibility.Hidden;
            PanelRecherche.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Recherche le commande dans la liste de commande et afficher son prix
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBoutonBoutonValiderNumeroAffichagePrix(object sender, RoutedEventArgs e)
        {
            PanelRecherche.Visibility = Visibility.Visible;
            BoutonValiderNumeroAffichagePrix.Visibility = Visibility.Visible;
            numCommandeCherchee = Convert.ToInt32(TextBoxCommandeRecherche.Text);

            position = pizzeria.RechercheCommande(numCommandeCherchee);

            if (position != -1)
            {
                MonTexteBlock.Text = "Le prix de la commande " + numCommandeCherchee +
                    " est " + pizzeria.ListeCommandes[position].GetPrix + " euro(s)";
            }
            else { MonTexteBlock.Text = "Commande introuvable"; }
        }

        /// <summary>
        /// Met à jour l'affichage pour afficher les details de la commande recherchee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherCommande(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            BoutonValiderNumeroAffichage.Visibility = Visibility.Visible;
            ListBoxM2.Visibility = Visibility.Hidden;
            PanelRecherche.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Recherche le commande dans la liste de commande et afficher ses details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBoutonValiderNumeroAffichage(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;

            numCommandeCherchee = Convert.ToInt32(TextBoxCommandeRecherche.Text);

            position = pizzeria.RechercheCommande(numCommandeCherchee);

            if (position != -1)
            {
                MonTexteBlock.Text = pizzeria.ListeCommandes[position].ToString();
            }
            else { MonTexteBlock.Text = "Commande introuvable"; }

            ReinitialiserAffichage();
        }

        /// <summary>
        /// Met à jour l'affichage pour demander a l'utilisateur le numero de la commande dont il souhaite modifier les details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierCommande(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();

            ListBoxM2.Visibility = Visibility.Hidden;
            PanelRecherche.Visibility = Visibility.Visible;
            BoutonValiderNumeroModification.Visibility = Visibility.Visible;
            BoutonValiderModification.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Recherche le commande dans la liste de commande, affiche ses details et demande a l'utilisateur de rentrer les nouvelles info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBoutonValiderNumeroModification(object sender, RoutedEventArgs e)
        {
            
            numCommandeCherchee = Convert.ToInt32(TextBoxCommandeRecherche.Text);
            position = pizzeria.RechercheCommande(numCommandeCherchee);

            if (position == -1)
            { MonTexteBlock.Text = "Commande introuvable"; }
            else
            {
                ReinitialiserAffichage();
                ListBoxM2.Visibility = Visibility.Hidden;
                MonTexteBlock.Visibility = Visibility.Visible;
                ModificationCommande.Visibility = Visibility.Visible;
                BoutonValiderModification.Visibility = Visibility.Visible;

                commande1 = pizzeria.ListeCommandes[pizzeria.RechercheCommande(numCommandeCherchee)];

                TextBoxModificationHeure.Text = Convert.ToString(commande1.Heure);
                TextBoxModificationEtat.Text = Convert.ToString(commande1.Etat);
                TextBoxModificationNomCommis.Text = Convert.ToString(commande1.NomCommis);
                TextBoxModificationNomLivreur.Text = Convert.ToString(commande1.NomLivreur);
                string estEncaisse;
                if(commande1.EstUnePerte)
                {
                    estEncaisse = "non";
                }
                else
                {
                    estEncaisse = "oui";
                }
                TextBoxModificationEstPerte.Text = Convert.ToString(estEncaisse);
            }
        }

        /// <summary>
        /// Ce bouton récupère tous les éléments rentrés dans les TextBox lors de la modification d'une commande
        /// Demande a l'utilisatuer s'il souhaite encaisser cette commande ou pas et l'encaisse si besoin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickValiderModificationCommande(object sender, RoutedEventArgs e)
        {
            commande1.Heure = TimeSpan.Parse(TextBoxModificationHeure.Text);
            commande1.Etat = TextBoxModificationEtat.Text;
            commande1.NomCommis = TextBoxModificationNomCommis.Text;
            commande1.NomLivreur = TextBoxModificationNomLivreur.Text;
            string encaissement = TextBoxModificationEstPerte.Text;

            if (encaissement == "oui" || encaissement == "Oui")
            {
                pizzeria.Caisse += commande1.GetPrix; 
                MaTexteBox.Text = "La commande est encaissée.";
            }
            else
            {
                MaTexteBox.Text = "La commande n'a pas été encaissée.";
            }

            ReinitialiserAffichage();

        }

        /// <summary>
        /// Ferme la fenetre du module 2 et ouvre la fenetre principale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetourMenuPrincipal(object sender, RoutedEventArgs e)
        {
            MainWindow fenetrePrincipale = new MainWindow(pizzeria);
            fenetrePrincipale.Show();
            this.Close();
        }
    }
}









