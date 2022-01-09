using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour Module1.xaml
    /// </summary>
    public partial class Module1 : Window
    {
        Pizzeria pizzeria;
        private Client client;
        private Commis commis;
        private Livreur livreur;
        //on a besoin de ces éléments pour les recuperer de ClickBouttonNumero à ClickBouttonValiderModification

        /// <summary>
        /// Constructeur du module 1
        /// </summary>
        /// <param name="pizzeria"></param>
        public Module1(Pizzeria pizzeria)
        {
            InitializeComponent();
            this.pizzeria = pizzeria;
            ReinitialiserAffichage();
            
        }
        /// <summary>
        /// Remet l'affichage par défaut sur la fenetre de choix des méthodes
        /// </summary>
        public void ReinitialiserAffichage()
        {
            ButtonListBox.Visibility = Visibility.Visible;
            BoutonValiderAjoutClient.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksAjoutClient.Visibility = Visibility.Hidden;

            BoutonValiderAjoutCommis.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksAjoutCommis.Visibility = Visibility.Hidden;

            BoutonValiderAjoutLivreur.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksAjoutLivreur.Visibility = Visibility.Hidden;

            BoutonValiderNumeroClient.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksModificationClient.Visibility = Visibility.Hidden;

            BoutonValiderNumeroCommis.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksModificationCommis.Visibility = Visibility.Hidden;

            BoutonValiderNumeroLivreur.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksModificationLivreur.Visibility = Visibility.Hidden;

            BoutonValiderModificationClient.Visibility = Visibility.Hidden;
            BoutonValiderModificationCommis.Visibility = Visibility.Hidden;
            BoutonValiderModificationCommis.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Permet d'afficher les clients par ordre alphabétique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherAlphabetiqueClients(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = pizzeria.AfficherAlphabetiqueClients();
        }

        /// <summary>
        /// Permet d'afficher les commis par ordre alphabétique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherAlphabetiqueCommis(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = pizzeria.AfficherAlphabetiqueCommis();
        }

        /// <summary>
        /// Permet d'afficher les livreurs par ordre alphabétique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherAlphabetiqueLivreurs(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = pizzeria.AfficherAlphabetiqueLivreurs();
        }

        /// <summary>
        /// Permet d'afficher les clients selon les villes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherVille(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = pizzeria.AfficherVille();
        }

        /// <summary>
        /// Permet d'afficher les meilleurs client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherMeilleurClient(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = pizzeria.AfficherMeilleurClient();
        }

        /// <summary>
        /// Pour chaque méthode à partir d'ici, on cache tous les éléméents que l'on ne veut plus afficher (menu de sélection)
        /// et on affiche le nouveau menu d'entrée de texte avec les textbox et text blocks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjoutClient(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Hidden;
            MaTexteBox.Visibility = Visibility.Hidden;
            BoutonValiderAjoutClient.Visibility = Visibility.Visible;
            ButtonListBox.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksAjoutClient.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Ce bouton récupère tous les éléments rentrés dans les TextBox lors de l'ajout d'un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonValiderAjoutClient(object sender, RoutedEventArgs e)
        {
            string nom = TextBoxAjoutClient1.Text;
            string prenom = TextBoxAjoutClient2.Text;
            string adresse = TextBoxAjoutClient3.Text;
            string ville = TextBoxAjoutClient4.Text;
            string numTelephone = TextBoxAjoutClient5.Text;
            pizzeria.ListeClients.Add(new Client(nom, prenom, adresse, ville, numTelephone, DateTime.Now));

            ReinitialiserAffichage();
            MonTexteBlock.Text = "Le client a été ajouté.\nChoisissez une fonction";
        }

        /// <summary>
        /// Met à jour l'affichage pour l'ajout d'un commis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjoutCommis(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Hidden;
            ButtonListBox.Visibility = Visibility.Hidden;
            BoutonValiderAjoutCommis.Visibility = Visibility.Visible;
            PanelBoxEtBlocksAjoutCommis.Visibility = Visibility.Visible;
            MaTexteBox.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Ce bouton récupère tous les éléments rentrés dans les TextBox lors de l'ajout d'un commis
        /// </summary>
        /// <param name="sender"></param>
        private void ClickBouttonValiderAjoutCommis(object sender, RoutedEventArgs e)
        {
            string nom = TextBoxCommis1.Text;
            string prenom = TextBoxCommis2.Text;
            string adresse = TextBoxCommis3.Text;
            string numero = TextBoxCommis4.Text;

            Commis commis = new Commis(nom, prenom, adresse, numero, "en conge", DateTime.Now, 0);
            pizzeria.ListeCommis.Add(commis);

            ReinitialiserAffichage();
            MonTexteBlock.Text = "Le commis a été ajouté.\nChoisissez une fonction";
        }

        /// <summary>
        /// Met à jour l'affichage pour l'ajout d'un livreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjoutLivreur(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Hidden;
            BoutonValiderAjoutLivreur.Visibility = Visibility.Visible;
            ButtonListBox.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksAjoutLivreur.Visibility = Visibility.Visible;
            MaTexteBox.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Ce bouton récupère tous les éléments rentrés dans les TextBox lors de l'ajout d'un livreur
        /// </summary>
        /// <param name="sender"></param>
        private void ClickBouttonValiderAjoutLivreur(object sender, RoutedEventArgs e)
        {
            string nom = TextBoxLivreur1.Text;
            string prenom = TextBoxLivreur2.Text;
            string num = TextBoxLivreur3.Text;
            string adresse = TextBoxLivreur4.Text;
            string moyenTransport = TextBoxLivreur5.Text;
            string etatLivreur = TextBoxLivreur6.Text;

            Livreur livreur = new Livreur(nom, prenom, adresse, num, etatLivreur, moyenTransport, 0);
            pizzeria.ListeLivreurs.Add(livreur);

            ReinitialiserAffichage();
            MonTexteBlock.Text = "Le livreur a été ajouté.\nChoisissez une fonction";
        }

        /// <summary>
        /// Met à jour l'affichage pour la suppression d'un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuppressionClient(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;
            MaTexteBox.Visibility = Visibility.Visible;
            BoutonValiderSuppressionClient.Visibility = Visibility.Visible;

            MonTexteBlock.Text = "Rentrez le numero du client";

            
        }
        /// <summary>
        /// Recherche un client dans la liste de clients et le supprime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonValiderSuppressionClient(object sender, RoutedEventArgs e)
        {
            string num = MaTexteBox.Text;
            if (pizzeria.RechercheClientTel(num) == -1) { MonTexteBlock.Text = "Client non trouve"; }
            else { pizzeria.ListeClients.RemoveAt(pizzeria.RechercheClientTel(num));
                MonTexteBlock.Text = "Suppression reussie";
            }

            ReinitialiserAffichage();
        }

        /// <summary>
        /// Met à jour l'affichage pour la suppression d'un commis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuppressionCommis(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;
            MaTexteBox.Visibility = Visibility.Visible;
            BoutonValiderSuppressionCommis.Visibility = Visibility.Visible;

            MonTexteBlock.Text = "Rentrez le numero du client";

        }
        /// <summary>
        /// Recherche un commis dans la liste de commis et le supprime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonValiderSuppressionCommis(object sender, RoutedEventArgs e)
        {
            string nom = MonTexteBlock.Text;
            if (pizzeria.RechercheCommis(nom) == -1) { MonTexteBlock.Text = "Commis non trouve"; }
            else { pizzeria.ListeCommis.RemoveAt(pizzeria.RechercheCommis(nom));
                MonTexteBlock.Text = "Suppression reussie";
            }
            ReinitialiserAffichage();
        }

        /// <summary>
        /// Met à jour l'affichage pour la suppression d'un livreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuppressionLivreur(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Visible;
            MaTexteBox.Visibility = Visibility.Visible;
            BoutonValiderSuppressionLivreur.Visibility = Visibility.Visible;

            MonTexteBlock.Text = "Rentrez le nom du livreur";
            
        }
        /// <summary>
        /// Recherche un livreur dans la liste de livreur et le supprime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonValiderSuppressionLivreur(object sender, RoutedEventArgs e)
        {
            string nom = MonTexteBlock.Text;
            foreach (Livreur livreur in pizzeria.ListeLivreurs)
            {
                if (livreur.Nom == nom)
                {
                    pizzeria.ListeLivreurs.Remove(livreur);
                }
            }
            MonTexteBlock.Text = "Suppression reussie";
            ReinitialiserAffichage();
        }

        /// <summary>
        /// Actualise le contenu des TexBox avec les propriétés du client entré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonNumeroClient(object sender, RoutedEventArgs e)
        {
            string numeroClient = TextBoxModificationClient0.Text;
            foreach (Client client1 in pizzeria.ListeClients)
            {
                if (client1.NumeroTel == numeroClient)
                {
                    client = client1;
                    TextBoxModificationClient1.Text = client1.Nom;
                    TextBoxModificationClient2.Text = client1.Prenom;
                    TextBoxModificationClient3.Text = client1.Adresse;
                    TextBoxModificationClient4.Text = client1.Ville;
                    TextBoxModificationClient5.Text = client1.NumeroTel;
                    break;
                }
            }
            
        }

        /// <summary>
        /// Met à jour l'affichage pour la modification d'un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificationClient(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Hidden;
            BoutonValiderModificationClient.Visibility = Visibility.Visible;
            ButtonListBox.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksModificationClient.Visibility = Visibility.Visible;
            BoutonValiderNumeroClient.Visibility = Visibility.Visible;

            

            MonTexteBlock.Text = "Rentrez le numero du client";
            
        }

        /// <summary>
        /// Modifie les propriétés du client en fonction des modifications entrées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonValiderModificationClient(object sender, RoutedEventArgs e)
        {
            client.Nom = TextBoxModificationClient1.Text;
            client.Prenom = TextBoxModificationClient2.Text;
            client.Adresse = TextBoxModificationClient3.Text;
            client.Ville = TextBoxModificationClient4.Text;
            client.NumeroTel = TextBoxModificationClient5.Text;

            ReinitialiserAffichage();

            MonTexteBlock.Text = "Le client a été modifié.\nChoisissez une fonction";
        }
        /// <summary>
        /// Actualise le contenu des TexBox avec les propriétés du commis entré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonNumeroCommis(object sender, RoutedEventArgs e)
        {
            string numeroCommis = TextBoxModificationCommis0.Text;
            foreach (Commis commis1 in pizzeria.ListeCommis)
            {
                if (commis1.Numero == numeroCommis)
                {
                    commis = commis1;
                    TextBoxModificationCommis1.Text = commis1.Nom;
                    TextBoxModificationCommis2.Text = commis1.Prenom;
                    TextBoxModificationCommis3.Text = commis1.Adresse;
                    TextBoxModificationCommis4.Text = commis1.Numero;
                    TextBoxModificationCommis5.Text = commis1.Etat;
                    break;
                }
            }
            string nom = TextBoxCommis1.Text;
            string prenom = TextBoxCommis2.Text;
            string adresse = TextBoxCommis3.Text;
            string numero = TextBoxCommis4.Text;
        }

        /// <summary>
        /// Met à jour l'affichage pour la modification d'un commis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificationCommis(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Hidden;
            BoutonValiderModificationCommis.Visibility = Visibility.Visible;
            ButtonListBox.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksModificationCommis.Visibility = Visibility.Visible;
            BoutonValiderNumeroCommis.Visibility = Visibility.Visible;

            

            MonTexteBlock.Text = "Rentrez le numero du commis";
            
        }

        /// <summary>
        /// Modifie les propriétés du commis en fonction des modifications entrées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonValiderModificationCommis(object sender, RoutedEventArgs e)
        {
            commis.Nom = TextBoxModificationCommis1.Text;
            commis.Prenom = TextBoxModificationCommis2.Text;
            commis.Adresse = TextBoxModificationCommis3.Text;
            commis.Numero = TextBoxModificationCommis4.Text;
            commis.Etat = TextBoxModificationCommis5.Text;
            ReinitialiserAffichage();

            MonTexteBlock.Text = "Le commis a été modifié.\nChoisissez une fonction";
        }
        /// <summary>
        /// Actualise le contenu des TexBox avec les propriétés du livreur entré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonNumeroLivreur(object sender, RoutedEventArgs e)
        {
            string numeroLivreur = TextBoxModificationLivreur0.Text;
            foreach (Livreur livreur1 in pizzeria.ListeLivreurs)
            {
                if (livreur1.Numero == numeroLivreur)
                {
                    livreur = livreur1;
                    TextBoxModificationLivreur1.Text = livreur1.Nom;
                    TextBoxModificationLivreur2.Text = livreur1.Prenom;
                    TextBoxModificationLivreur3.Text = livreur1.Adresse;
                    TextBoxModificationLivreur4.Text = livreur1.Numero;
                    TextBoxModificationLivreur5.Text = livreur1.Etat;
                    TextBoxModificationLivreur6.Text = livreur1.MoyenTransport;
                    break;
                }
            }
            string nom = TextBoxLivreur1.Text;
            string prenom = TextBoxLivreur2.Text;
            string adresse = TextBoxLivreur3.Text;
            string numero = TextBoxLivreur4.Text;
        }

        /// <summary>
        /// Met à jour l'affichage pour la modification d'un livreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificationLivreur(object sender, RoutedEventArgs e)
        {
            MonTexteBlock.Visibility = Visibility.Hidden;
            BoutonValiderModificationLivreur.Visibility = Visibility.Visible;
            ButtonListBox.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksModificationLivreur.Visibility = Visibility.Visible;
            BoutonValiderNumeroLivreur.Visibility = Visibility.Visible;

            MonTexteBlock.Text = "Rentrez le numero du commis";
            
        }

        /// <summary>
        /// Modifie les propriétés du livreur en fonction des modifications entrées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonValiderModificationLivreur(object sender, RoutedEventArgs e)
        {
            livreur.Nom = TextBoxModificationLivreur1.Text;
            livreur.Prenom = TextBoxModificationLivreur2.Text;
            livreur.Adresse = TextBoxModificationLivreur3.Text;
            livreur.Numero = TextBoxModificationLivreur4.Text;
            livreur.Etat = TextBoxModificationLivreur5.Text;
            livreur.MoyenTransport = TextBoxModificationLivreur6.Text;

            ReinitialiserAffichage();

            MonTexteBlock.Text = "Le livreur a été modifié.\nChoisissez une fonction";
        }

        /// <summary>
        /// Ferme la fenetre du module 1 et ouvre la fenetre principale
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





