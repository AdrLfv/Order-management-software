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
    /// Logique d'interaction pour Module3.xaml
    /// </summary>
    public partial class Module3 : Window
    {
        Pizzeria pizzeria;

        /// <summary>
        /// Constructeur du module 3
        /// </summary>
        /// <param name="pizzeria"></param>
        public Module3(Pizzeria pizzeria)
        {
            InitializeComponent();
            this.pizzeria = pizzeria;

            BoutonValiderPeriode.Visibility = Visibility.Hidden;
            MaListBox.Visibility = Visibility.Visible;
            PanelBoxEtBlocksPeriode.Visibility = Visibility.Hidden;
            BoutonQuitter.Visibility = Visibility.Visible;
            MonTexteBlock.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Remet l'affichage par défaut sur la fenetre de choix des méthodes
        /// </summary>
        public void ReinitialiserAffichage()
        {
            BoutonValiderPeriode.Visibility = Visibility.Hidden;
            MaListBox.Visibility = Visibility.Visible;
            PanelBoxEtBlocksPeriode.Visibility = Visibility.Hidden;
            BoutonQuitter.Visibility = Visibility.Visible;
            MonTexteBlock.Visibility = Visibility.Visible;
            BoutonValiderPeriode.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Permet d'afficher les commis selon les nombres des commandes gerees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherCommisCommandes(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = pizzeria.AfficherCommisCommandes();
        }

        /// <summary>
        /// Permet d'afficher les livreurs selon les nombres des livraisons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherLivreurLivraisons(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = pizzeria.AfficherLivreurLivraisons();
        }

        /// <summary>
        /// Met à jour l'affichage pour saisir la date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherCommandePeriode(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            MaListBox.Visibility = Visibility.Hidden;
            PanelBoxEtBlocksPeriode.Visibility = Visibility.Visible;
            BoutonValiderPeriode.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Permet d'afficher les commandes selon une periode de temps
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBouttonValiderDate(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            MonTexteBlock.Visibility = Visibility.Visible;

            DateTime t1 = new DateTime(Convert.ToInt32(TextBoxPeriodeAnnee.Text), Convert.ToInt32(TextBoxPeriodeMois.Text), Convert.ToInt32(TextBoxPeriodeJour.Text));
            MonTexteBlock.Text = pizzeria.AfficherCommandePeriode(DateTime.Now, t1);
        }

        /// <summary>
        /// Permet d'afficher la moyenne de toutes les commandes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoyenneCommande(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = "La moyenne des prix de commande est " + pizzeria.MoyenneCommande();
        }

        /// <summary>
        /// Permet d'afficher la moyenne des comptes clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoyenneCptClient(object sender, RoutedEventArgs e)
        {
            ReinitialiserAffichage();
            MonTexteBlock.Visibility = Visibility.Visible;
            MonTexteBlock.Text = "La moyenne des comptes clients est " + pizzeria.MoyenneCptClient();
        }


        /// <summary>
        /// Ferme la fenetre du module 3 et ouvre la fenetre principale
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



