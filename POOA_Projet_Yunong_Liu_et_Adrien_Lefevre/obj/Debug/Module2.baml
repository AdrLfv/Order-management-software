   M S B A M L   `   `   `  ����c  _POOA_Projet_Yunong_Liu_et_Adrien_Lefevre, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:POOA_Projet_Yunong_Liu_et_Adrien_Lefevre(POOA_Projet_Yunong_Liu_et_Adrien_Lefevre  5   	   6    0POOA_Projet_Yunong_Liu_et_Adrien_Lefevre.Module2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:POOA_Projet_Yunong_Liu_et_Adrien_Lefevre     5   	     � Title$  Module2��5   	   $��540.765��6   $	��800��6*   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ White��6   � 5      $ 	#FFBB8102��6    � Offset$ 1Q�61   5      .+�5   
   �� -   5        $��	ListBoxM2��5      $
��Left=�6$   $	��123��6?   $��
180,92,0,0q�6L   $	��Top=�6`   $	��426��6x   $y�Visible=�6�   .@�5      �� -   5        $��Ajouter une commande��5      $	��412��64   $��35��6@   $��20(�6L   $��Dubai Medium)�6Z   6u   �� 5      -   5        $��Modifier une commande��5      $	��412��65   $��35��6A   $��20(�6M   $��Dubai Medium)�6[   6v   �� 5      -   5        $)��#Afficher les details d'une commande��5      $	��412��6C   $��35��6O   $��20(�6[   $��Dubai Medium)�6i   6�   5      �� 5   
   -   5        $*��$AjoutCommandeInfoClientCommisLivreur��5      $
��Left=�6B   $	��302��6]   $��
201,68,0,0q�6j   $	��Top=�6~   $	��387��6�   $y�Hidden=�6�   .+�5      �� $
��Wrap=�6   $��Rentrez le nom du client��6,   $��0,0,-0.333,0q�6L   �� 5      -   5         ��Name$# TextBoxAjoutCommandeNomClient��5   P   $��23��6    �� TextWrapping$
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5      $
��Wrap=�6   $"��Rentrez le numero du livreur��6,   �� 5      -   5        $$ TextBoxAjoutCommandeNomLivreur��5   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5      $
��Wrap=�6   $��Rentrez le nom du commis��6,   �� 5      -   5        $# TextBoxAjoutCommandeNomCommis��5   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5      �� 5    
   -	   5        $��AjoutCommandeAjoutPizza��5       $
��Left=�65   $	��222��6P   $��
201,68,0,0q�6]   $	��Top=�6q   $	��387��6�   $y�Hidden=�6�   .+�5!      �� $
��Wrap=�6   $<��6Rentrez la taille de la pizza (Petite, Medium, Grande)��6,   �� 5"      -
   5        $��TextBoxAjoutPizzaTaille��5"   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5#      $
��Wrap=�6   $X��RRentrez le type de la pizza (Marguerite, Hawaii, Vegetarienne, 4Fromages, Chorizo)��6,   �� 5$      -   5        $��TextBoxAjoutPizzaType��5$   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5%      $
��Wrap=�6   $��Rentrez la quantite��6,   �� 5&      -   5        $��TextBoxAjoutPizzaQuantite��5&   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5'      �� 5)   
   -   5        $��BoutonAjoutPizza��5)      $��Ajouter une pizza��6*   $y�Visible=�6G   $
��Left=�6\   $��465,324,0,0q�6w   $	��Top=�6�   $	��123��6�   $��25��6�   6�   �� 5*   
   -   5        $��BoutonValiderAjoutPizza��5*      $��Valider��61   $y�Hidden=�6D   $
��Left=�6X   $��465,324,0,0q�6s   $	��Top=�6�   $	��123��6�   $��25��6�   6�   �� 5,   
   -   5        $��AjoutCommandeAjoutBoisson��5,      $
��Left=�67   $	��230��6R   $��
201,68,0,0q�6_   $	��Top=�6s   $	��387��6�   $y�Hidden=�6�   .+�5-      �� $
��Wrap=�6   $D��>Rentrez le type de la boisson (Coca, Fanta, Orangina, Perrier)��6,   �� 5.      -   5        $��TextBoxAjoutBoissonType��5.   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5/      $
��Wrap=�6   $6��0Rentrez le volume de la boisson (0.33 / 0.5 / 1)��6,   �� 50      -   5        $��TextBoxAjoutBoissonVolume��50   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 51      $
��Wrap=�6   $��Rentrez la quantite��6,   �� 52      -   5        $!��TextBoxAjoutBoissonQuantite��52   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   53      �� 55   
   -   5        $��BoutonAjoutBoisson��55      $��Ajouter une boisson��6,   $y�Visible=�6K   $
��Left=�6`   $��465,354,0,0q�6{   $	��Top=�6�   $	��123��6�   $��25��6�   6�   �� 56   
   -   5        $��BoutonValiderAjoutBoisson��56      $��Valider��63   $y�Hidden=�6F   $
��Left=�6Z   $��465,391,0,0q�6u   $	��Top=�6�   $	��123��6�   $��25��6�   6�   �� 58   
   -   5        $ ��BoutonValiderAjoutCommande��58      $��Valider la commande��64   $y�Visible=�6R   $
��Left=�6g   $��444,384,0,0q�6�   $	��Top=�6�   $	��144��6�   $��25��6�   6�   �� 5:   
   -   5        $��PanelRecherche��5:      $
��Left=�6,   $	��171��6G   $��
201,68,0,0q�6T   $��Center=�6h   $	��387��6�   $y�Hidden=�6�   .+�5;      �� $
��Wrap=�6   $&�� Rentrez le numero de la commande��6,   $��0,0,-0.333,0q�6T   �� 5<      -   5        $ TextBoxCommandeRecherche��5<   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5=      �� 5@   
   -   5        $%��BoutonValiderNumeroModification��5@      $��Valider��69   $
��Left=�6K   $y�Visible=�6f   $��437,345,0,0q�6{   $	��Top=�6�   $	��130��6�   $��25��6�   6�   �� 5A   
   -   5        $&�� BoutonValiderNumeroAffichagePrix��5A      $��Valider��6:   $
��Left=�6L   $y�Hidden=�6g   $��437,345,0,0q�6{   $	��Top=�6�   $	��130��6�   $��25��6�   6�   �� 5C   
   -   5        $��BoutonValiderModification��5C      $��Valider��63   $
��Left=�6E   $y�Hidden=�6`   $��437,345,0,0q�6t   $	��Top=�6�   $	��130��6�   $��25��6�   6�   �� 5E   
   -   5        $��ModificationCommande��5E      $
��Left=�62   $	��283��6M   $��180,46,0,89.4q�6Z   $��Center=�6q   $	��387��6�   $y�Hidden=�6�   .+�5F      �� $
��Wrap=�6   $��Entrer l'heure��6,   $��
0,0,-0.8,0q�6B   �� 5G      -   5        $ TextBoxModificationHeure��5G   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5H      $
��Wrap=�6   $?��9Pour modifier :1-En préparation 2-En livraison 3-Fermée��6,   $��0,0,-0.333,0q�6k   �� 5I      -   5        $ TextBoxModificationEtat��5I   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5J      $
��Wrap=�6   $��Entrez le nom de commis��6,   $��0,0,-0.333,0q�6K   �� 5K      -   5        $" TextBoxModificationNomCommis��5K   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5L      $
��Wrap=�6   $��Entrez le nom du livreur��6,   $��0,0,-0.333,0q�6L   �� 5M      -   5        $# TextBoxModificationNomLivreur��5M   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5N      $
��Wrap=�6   $>��8Entrez si la commande est encaissée ou non (oui ou non)��6,   $��0,0,-0.333,0q�6k   �� 5O      -    5        $! TextBoxModificationEstPerte��5O   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5Q      �� 5S   
   -!   5        $��Encaisse��5S      $
��Left=�6&   $	��171��6A   $��
201,68,0,0q�6N   $��Center=�6b   $	��387��6}   $y�Hidden=�6�   .+�5T      �� $
��Wrap=�6   $A��;Pour modifier :\n1-En préparation 2-En livraison 3-Fermée��6,   $��0,0,-0.333,0q�6m   �� 5U      -"   5        $ TextBoxEncaisse��5U   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5V      �� 5X   
   -#   5        $��MonTexteBlock��5X      $
��Left=�6*   $��
64,324,0,0q�6E   $
��Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��154��6�   $	��270��6�   
�������$y�Visible=�6�   �� 5Y   
   -$   5        $��
MaTexteBox��5Y      $
��Left=�6%   $��23��6@   $��603,455,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   $y�Hidden=�6�   �� 5[   
   -%   5        $"��BoutonValiderNumeroAffichage��5[      $��Valider��66   $
��Left=�6H   $y�Hidden=�6c   $��437,290,0,0q�6w   $	��Top=�6�   $	��130��6�   $��25��6�   6�   �� 5^   
   -&   5        $��BoutonQuitter��5^   +   $��Menu principal��6   $
��Left=�6@   $��659,383,0,0q�6[   $	��Top=�6p   $	��123��6�   $��26��6�   5`      5a      