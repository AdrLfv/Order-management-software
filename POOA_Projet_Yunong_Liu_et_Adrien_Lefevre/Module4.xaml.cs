using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
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
    /// Logique d'interaction pour Module4.xaml
    /// </summary>
    public partial class Module4 : Window
    {
        Pizzeria pizzeria;

        /// <summary>
        /// Le constructeur du module 4 met à jour l'affichage pour présenter les boutons des différentes fonctions
        /// </summary>
        /// <param name="pizzeria"></param>
        public Module4(Pizzeria pizzeria)
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
            MaTexteBox.Visibility = Visibility.Hidden;
            MonTexteBlock.Visibility = Visibility.Visible;
            MaListBox.Visibility = Visibility.Visible;
            BoutonValiderCodePromo.Visibility = Visibility.Hidden;
            BoutonValiderVerifierCodePromo.Visibility = Visibility.Hidden;

            PanelBoxEtBlocksAppliquerCode.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksVerifierCode.Visibility = Visibility.Hidden;

            BoutonValiderAfficherCodePromo.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksValiderAfficherCode.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Met à jour l'affichage pour permettre d'appliquer un code de promotion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppliquerCode(object sender, RoutedEventArgs e)
        {
            MaTexteBox.Visibility = Visibility.Hidden;
            MonTexteBlock.Visibility = Visibility.Visible;
            MaListBox.Visibility = Visibility.Hidden;
            BoutonValiderCodePromo.Visibility = Visibility.Visible;

            PanelBoxEtBlocksAppliquerCode.Visibility = Visibility.Visible ;

        }

        /// <summary>
        /// L'utilisateur rentre un code de promotion et une commande, si la commande existe et que le code de promotion n'est pas utilisé
        /// on enleve le montant du code promo à la commande choisie, on enlève le montant au montant des achats du client,
        /// on ajoute le code à la liste de codes utilisés par le client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonCodePromo(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(TextBoxAppliquerCode0.Text);
            int index = pizzeria.RechercheCommande(num);

            if (index == -1) { MonTexteBlock.Text = "Commande non trouvee"; }
            else
            {
                string code = TextBoxAppliquerCode1.Text;

                //on passe à VerifierCode le code rentré et le client correspondant au numéro de téléphone rentré
                //si on voit la fonction VerifierCode nous dit que le code n'est pas utilisé
                if (!pizzeria.VerifierCode(code, pizzeria.ListeClients[pizzeria.RechercheClientTel(pizzeria.ListeCommandes[index].NumClient)]))
                {
                    float montant = pizzeria.ListeCodePromo.ElementAt(pizzeria.ListeCodePromo.IndexOfKey(code)).Value;
                    pizzeria.ListeCommandes[index].GetPrix -= montant;
                    pizzeria.ListeClients[pizzeria.RechercheClientTel(pizzeria.ListeCommandes[index].NumClient)].Montant_achat -= montant;
                    pizzeria.ListeClients[pizzeria.RechercheClientTel(pizzeria.ListeCommandes[index].NumClient)].ListeCodeUtilise.Add(code);

                    MonTexteBlock.Text = "Code promo applique. ";


                    ReinitialiserAffichage();

                }
                else { MonTexteBlock.Text = "Code deja utilise."; }
            }
        }

        /// <summary>
        /// Met à jour l'affichage pour permettre de vérifier si un code de promotion a été utilisé ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifierCode(object sender, RoutedEventArgs e)
        {
            MaTexteBox.Visibility = Visibility.Visible;
            MonTexteBlock.Visibility = Visibility.Visible;
            BoutonValiderVerifierCodePromo.Visibility = Visibility.Visible;
            MaListBox.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksVerifierCode.Visibility = Visibility.Visible;

            
        }

        /// <summary>
        /// L'utilisateur rendre un numéro de téléphone d'un client et un code de promotion
        /// la textBlock affiche alors si ce client l'a déjà utilisé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonVerifierCodePromo(object sender, RoutedEventArgs e)
        {
            string tel = TextBoxVerifierCode0.Text;
            string code = TextBoxVerifierCode1.Text;

            if (pizzeria.VerifierCode(code, pizzeria.ListeClients[pizzeria.RechercheClientTel(tel)]))
            {
                MonTexteBlock.Text = "Ce code a deja ete utilise";
            }
            else
            {
                MonTexteBlock.Text = "Ce code est utilisable";
            }

            ReinitialiserAffichage();
        }

        /// <summary>
        /// Met à jour l'affichage pour permettre de demander un client puis afficher tous ses codes de promotion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherCode(object sender, RoutedEventArgs e)
        {
            MaTexteBox.Visibility = Visibility.Visible;
            MonTexteBlock.Visibility = Visibility.Visible;
            BoutonValiderAfficherCodePromo.Visibility = Visibility.Visible;
            PanelBoxEtBlocksValiderAfficherCode.Visibility = Visibility.Visible;
            MaListBox.Visibility = Visibility.Hidden;


        }

        /// <summary>
        /// Affiche tous les codes de promotion utilisés par un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonAfficherCodePromo(object sender, RoutedEventArgs e)
        {
            string telephone = TextBoxAfficherCode0.Text;
            //pour tous les codes promos utilisés par le client on les ajoute au résultat
            string result = "";
            foreach (string code in pizzeria.ListeClients[pizzeria.RechercheClientTel(telephone)].ListeCodeUtilise)
            {
                 result += code + " ";
            }
            MonTexteBlock.Text = result;
        }


        /// <summary>
        /// Appelle les méthodes d'écriture des paramètres des clients, commis, livreurs et commandes dans des excels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ecriture(object sender, RoutedEventArgs e)
        {
            pizzeria.EcritureClients();
            pizzeria.EcritureCommis();
            pizzeria.EcritureLivreurs();
            pizzeria.EcritureCommandes();
            pizzeria.EcritureDetailsCommandes();
            MonTexteBlock.Text = "La sauvegarde a été effectuée.\nChoisissez une fonction";
        }


        /// <summary>
        /// Ferme la fenetre et retourne au menu principal
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



