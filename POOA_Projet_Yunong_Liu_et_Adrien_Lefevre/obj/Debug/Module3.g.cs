#pragma checksum "..\..\Module3.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C547270D51F444103C1880652A958674220ADD302A3136A1400D72E2B64D3650"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using POOA_Projet_Yunong_Liu_et_Adrien_Lefevre;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace POOA_Projet_Yunong_Liu_et_Adrien_Lefevre {
    
    
    /// <summary>
    /// Module3
    /// </summary>
    public partial class Module3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MaListBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PanelBoxEtBlocksPeriode;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPeriodeJour;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPeriodeMois;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPeriodeAnnee;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BoutonQuitter;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BoutonValiderPeriode;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaTexteBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Module3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MonTexteBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/POOA_Projet_Yunong_Liu_et_Adrien_Lefevre;component/module3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Module3.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MaListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            
            #line 17 "..\..\Module3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AfficherCommisCommandes);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 18 "..\..\Module3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AfficherLivreurLivraisons);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\Module3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AfficherCommandePeriode);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 20 "..\..\Module3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MoyenneCommande);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 21 "..\..\Module3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MoyenneCptClient);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PanelBoxEtBlocksPeriode = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.TextBoxPeriodeJour = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TextBoxPeriodeMois = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.TextBoxPeriodeAnnee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.BoutonQuitter = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Module3.xaml"
            this.BoutonQuitter.Click += new System.Windows.RoutedEventHandler(this.RetourMenuPrincipal);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BoutonValiderPeriode = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Module3.xaml"
            this.BoutonValiderPeriode.Click += new System.Windows.RoutedEventHandler(this.ClickBouttonValiderDate);
            
            #line default
            #line hidden
            return;
            case 13:
            this.MaTexteBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.MonTexteBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

