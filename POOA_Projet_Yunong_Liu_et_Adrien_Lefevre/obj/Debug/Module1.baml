   M S B A M L   `   `   `  ����c  _POOA_Projet_Yunong_Liu_et_Adrien_Lefevre, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:POOA_Projet_Yunong_Liu_et_Adrien_Lefevre(POOA_Projet_Yunong_Liu_et_Adrien_Lefevre  5   	   6    0POOA_Projet_Yunong_Liu_et_Adrien_Lefevre.Module1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:POOA_Projet_Yunong_Liu_et_Adrien_Lefevre     5   	     � Title$  Module1��5   	   $��625.5��6   $	��800��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��769* �6   �� 5      $	��24* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ White��6   � 5      $ 	#FFBB8102��6    � Offset$ 1Q�61   5      .+�5   
   �� -   5        $��ButtonListBox��5      $
��Left=�6(   $	��445��6C   $��	98,10,0,0q�6P   $	��Top=�6c   $	��625��6{   $y�Visible=�6�   .@�5      �� -   5        $��Bouton1��5      $��5,5,10,5q�6%   $��49��68   $	��570��6D   .��5      �� $
��Wrap=�6   $��43��60   $��20(�6<   $��Dubai Medium)�6J   $��Right=�6d   $	��560��6�    �� 
LineHeight$ 6��6�    �� TextAlignment$ Center=�6�   $>��8 Afficher l'ensemble des Clients par ordre alphabétique��6�   5      �� 5      -   5        $��Bouton2��5      $��5,5,10,5q�6&   $��49��68   $	��570��6g   .��5      �� $
��Wrap=�6   $��43��60   $��20(�6<   $ Center=�6J   $��Dubai Medium)�6a   $��Right=�6{   $	��487��6�   $<��6Afficher l'ensemble des Commis par ordre alphabétique��6�   5      �� 5      -   5        $��Bouton3��5      $��5,5,10,5q�6&   $��49��68   $	��570��6i   .��5       �� $
��Wrap=�6   $��43��60   $��20(�6<   $ Center=�6J   $��Dubai Medium)�6a   $��Right=�6{   $	��560��6�   $>��8Afficher l'ensemble des Livreurs par ordre alphabétique��6�   5"      �� 5$      -   5        $��Bouton4��5$      $��5,5,10,5q�6&   $��49��68   $	��570��6Z   .��5%      �� $
��Wrap=�6   $��43��60   $��20(�6<   $ Center=�6J   $��Dubai Medium)�6a   $��Right=�6{   $	��513��6�   $/��)Afficher l'ensemble des Clients par ville��6�   5'      �� 5)      -   5        $��Bouton5��5)      $��5,5,10,5q�6&   $��49��68   $	��570��6c   .��5*      �� $
��Wrap=�6   $��43��60   $��20(�6<   $ Center=�6J   $��Dubai Medium)�6a   $��Right=�6{   $	��531��6�   $F��@ Afficher l'ensemble des Clients par montant des achats cumulés��6�   5+      �� 5-      -   5        $��Bouton6��5-      $��5,5,10,5q�6&   $��49��68   $	��570��6X   .��5.      �� $
��Wrap=�6   $��Ajouter un Client��60   $��43��6I   $��20(�6U   $ Center=�6c   $��Dubai Medium)�6z   $��Right=�6�   $	��374��6�   5/      �� 51      -   5        $��Bouton7��51      $��5,5,10,5q�6&   $��49��68   $	��570��6X   .��52      �� $
��Wrap=�6   $��Ajouter un Commis��60   $��43��6I   $��20(�6U   $ Center=�6c   $��Dubai Medium)�6z   $��Right=�6�   $	��374��6�   53      �� 55      -	   5        $��Bouton8��55      $��5,5,10,5q�6&   $��49��68   $	��570��6Y   .��56      �� $
��Wrap=�6   $��Ajouter un Livreur��60   $��43��6J   $��20(�6V   $ Center=�6d   $��Dubai Medium)�6{   $��Right=�6�   $	��374��6�   57      �� 59      -
   5        $��Bouton9��59      $��5,5,10,5q�6&   $��49��68   $	��570��6^   .��5:      �� $
��Wrap=�6   $��Supprimer un Client��60   $��43��6K   $��20(�6W   $ Center=�6e   $��Dubai Medium)�6|   $��Right=�6�   $	��374��6�   5;      �� 5=      -   5        $��Bouton10��5=      $��5,5,10,5q�6'   $��49��69   $	��570��6_   .��5>      �� $
��Wrap=�6   $��Supprimer un Commis��60   $��43��6K   $��20(�6W   $ Center=�6e   $��Dubai Medium)�6|   $��Right=�6�   $	��374��6�   5?      �� 5A      -   5        $��Bouton11��5A      $��5,5,10,5q�6'   $��49��69   $	��570��6`   .��5B      �� $
��Wrap=�6   $��Supprimer un Livreur��60   $��43��6L   $��20(�6X   $ Center=�6f   $��Dubai Medium)�6}   $��Right=�6�   $	��374��6�   5C      �� 5E      -   5        $��Bouton12��5E      $��5,5,10,5q�6'   $��49��69   $	��570��6`   .��5F      �� $
��Wrap=�6   $��Modifier un Client��60   $��43��6J   $��20(�6V   $ Center=�6d   $��Dubai Medium)�6{   $��Right=�6�   $	��374��6�   5G      �� 5I      -   5        $��Bouton13��5I      $��5,5,10,5q�6'   $��49��69   $	��570��6`   .��5J      �� $
��Wrap=�6   $��Modifier un Commis��60   $��43��6J   $��20(�6V   $ Center=�6d   $��Dubai Medium)�6{   $��Right=�6�   $	��374��6�   5K      �� 5M      -   5        $��Bouton14��5M      $��5,5,10,5q�6'   $��49��69   $	��570��6a   .��5N      �� $
��Wrap=�6   $��Modifier un Livreur��60   $��43��6K   $��20(�6W   $ Center=�6e   $��Dubai Medium)�6|   $��Right=�6�   $	��374��6�   5O      5P      �� 5S   
   -   5        $!��PanelBoxEtBlocksAjoutClient��5S      $
��Left=�69   $	��393��6T   $��
185,62,0,0q�6a   $	��Top=�6u   $	��387��6�   $y�Hidden=�6�   .+�5T      �� $
��Wrap=�6   $��Rentrez le nom du client��6,   �� 5U      -   5        $��TextBoxAjoutClient1��5U   P   $��23��6   	 �� TextWrapping$
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5V      $
��Wrap=�6   $!��Rentrez le prenom du client��6,   �� 5W      -   5        $��TextBoxAjoutClient2��5W   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5X      $
��Wrap=�6   $!��Rentrez l'adresse du client��6,   �� 5Y      -   5        $��TextBoxAjoutClient3��5Y   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5Z      $
��Wrap=�6   $ ��Rentrez la ville du client��6,   �� 5[      -   5        $��TextBoxAjoutClient4��5[   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5\      $
��Wrap=�6   $.��(Rentrez le numero de telephone du client��6,   �� 5]      -   5        $��TextBoxAjoutClient5��5]   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5^      �� 5_   
   -   5        $!��PanelBoxEtBlocksAjoutCommis��5_      $
��Left=�69   $	��393��6T   $��
185,62,0,0q�6a   $	��Top=�6u   $	��387��6�   $y�Hidden=�6�   .+�5`      �� $
��Wrap=�6   $��Rentrez le nom du commis��6,   �� 5a      -   5        $��TextBoxCommis1��5a   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5b      $
��Wrap=�6   $!��Rentrez le prenom du commis��6,   �� 5c      -   5        $��TextBoxCommis2��5c   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5d      $
��Wrap=�6   $!��Rentrez l'adresse du commis��6,   �� 5e      -   5        $��TextBoxCommis3��5e   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5f      $
��Wrap=�6   $.��(Rentrez le numero de telephone du commis��6,   �� 5g      -   5        $��TextBoxCommis4��5g   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5h      �� 5i   
   -   5        $"��PanelBoxEtBlocksAjoutLivreur��5i      $
��Left=�6:   $	��393��6U   $��
185,62,0,0q�6b   $	��Top=�6v   $	��387��6�   $y�Hidden=�6�   .+�5j      �� $
��Wrap=�6   $��Rentrez le nom du livreur��6,   �� 5k      -   5        $��TextBoxLivreur1��5k   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5l      $
��Wrap=�6   $"��Rentrez le prenom du livreur��6,   �� 5m      -   5        $��TextBoxLivreur2��5m   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5n      $
��Wrap=�6   $"��Rentrez le numero du livreur��6,   �� 5o      -   5        $��TextBoxLivreur3��5o   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5p      $
��Wrap=�6   $"��Rentrez l'adresse du livreur��6,   �� 5q      -   5        $��TextBoxLivreur4��5q   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5r      $
��Wrap=�6   $.��(Rentrez le moyen de transport du livreur��6,   �� 5s      -    5        $��TextBoxLivreur5��5s   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5t      $
��Wrap=�6   $8��2Rentrez l'etat du livreur (Sur place ou en congé)��6,   �� 5u      -!   5        $��TextBoxLivreur6��5u   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5v      �� 5x   
   -"   5        $(��"PanelBoxEtBlocksModificationClient��5x      $
��Left=�6@   $	��393��6[   $��
185,62,0,0q�6h   $	��Top=�6|   $	��387��6�   $y�Hidden=�6�   .+�5y      �� $
��Wrap=�6   $.��(Rentrez le numero de telephone du client��6,   �� 5z      -#   5        $ ��TextBoxModificationClient0��5z   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5{      $
��Wrap=�6   $&�� Rentrez le nouveau nom du client��6,   �� 5|      -$   5        $ ��TextBoxModificationClient1��5|   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5}      $
��Wrap=�6   $)��#Rentrez le nouveau prenom du client��6,   �� 5~      -%   5        $ ��TextBoxModificationClient2��5~   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5      $
��Wrap=�6   $+��%Rentrez la nouvelle adresse du client��6,   �� 5�      -&   5        $ ��TextBoxModificationClient3��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $)��#Rentrez la nouvelle ville du client��6,   �� 5�      -'   5        $ ��TextBoxModificationClient4��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $6��0Rentrez le nouveau numero de telephone du client��6,   �� 5�      -(   5        $ ��TextBoxModificationClient5��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5�      �� 5�   
   -)   5        $(��"PanelBoxEtBlocksModificationCommis��5�      $
��Left=�6@   $	��393��6[   $��
185,62,0,0q�6h   $	��Top=�6|   $	��387��6�   $y�Hidden=�6�   .+�5�      �� $
��Wrap=�6   $.��(Rentrez le numero de telephone du commis��6,   �� 5�      -*   5        $ ��TextBoxModificationCommis0��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $&�� Rentrez le nouveau nom du commis��6,   �� 5�      -+   5        $ ��TextBoxModificationCommis1��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $)��#Rentrez le nouveau prenom du commis��6,   �� 5�      -,   5        $ ��TextBoxModificationCommis2��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $+��%Rentrez la nouvelle adresse du commis��6,   �� 5�      --   5        $ ��TextBoxModificationCommis3��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $*��$Rentrez le nouveau numéro du commis��6,   �� 5�      -.   5        $ ��TextBoxModificationCommis4��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $'��!Rentrez le nouvel état du commis��6,   �� 5�      -/   5        $ ��TextBoxModificationCommis5��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5�      �� 5�   
   -0   5        $)��#PanelBoxEtBlocksModificationLivreur��5�      $
��Left=�6A   $	��393��6\   $��
185,62,0,0q�6i   $	��Top=�6}   $	��387��6�   $y�Hidden=�6�   .+�5�      �� $
��Wrap=�6   $/��)Rentrez le numero de telephone du livreur��6,   �� 5�      -1   5        $!��TextBoxModificationLivreur0��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $'��!Rentrez le nouveau nom du livreur��6,   �� 5�      -2   5        $!��TextBoxModificationLivreur1��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $*��$Rentrez le nouveau prenom du livreur��6,   �� 5�      -3   5        $!��TextBoxModificationLivreur2��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $,��&Rentrez la nouvelle adresse du livreur��6,   �� 5�      -4   5        $!��TextBoxModificationLivreur3��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $+��%Rentrez le nouveau numéro du livreur��6,   �� 5�      -5   5        $!��TextBoxModificationLivreur4��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $(��"Rentrez le nouvel état du livreur��6,   �� 5�      -6   5        $!��TextBoxModificationLivreur5��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5�      $
��Wrap=�6   $6��0Rentrez le nouveau moyen de transport du livreur��6,   �� 5�      -7   5        $!��TextBoxModificationLivreur6��5�   P   $��23��6   $
	 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5�      �� 5�   
   -8   5        $��MonTexteBlock��5�   3   $��Choisissez une fonction��6   $
��Left=�6I   $��
10,474,0,0q�6d   $
��Wrap=�6x   $	��Top=�6�   $	��111��6�   $	��399��6�   
�������$y�Visible=�6�   �� 5�   
   -9   5        $��
MaTexteBox��5�      $
��Left=�6%   $��23��6@   $��603,455,0,0q�6L   $
	 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   $y�Hidden=�6�   �� 5�   
   -:   5        $��BoutonValiderAjoutClient��5�      $��Valider��62   $
��Left=�6D   $��449,438,0,0q�6_   $	��Top=�6t   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -;   5        $��BoutonValiderAjoutCommis��5�      $��Valider��62   $
��Left=�6D   $��449,476,0,0q�6_   $	��Top=�6t   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -<   5        $��BoutonValiderAjoutLivreur��5�      $��Valider��63   $
��Left=�6E   $��449,438,0,0q�6`   $	��Top=�6u   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -=   5        $$��BoutonValiderSuppressionClient��5�      $��Valider��68   $
��Left=�6J   $��449,438,0,0q�6e   $	��Top=�6z   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   ->   5        $$��BoutonValiderSuppressionCommis��5�      $��Valider��68   $
��Left=�6J   $��449,438,0,0q�6e   $	��Top=�6z   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -?   5        $%��BoutonValiderSuppressionLivreur��5�      $��Valider��69   $
��Left=�6K   $��449,438,0,0q�6f   $	��Top=�6{   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -@   5        $��BoutonValiderNumeroClient��5�      $��Valider��63   $
��Left=�6E   $��
600,75,0,0q�6`   $	��Top=�6t   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -A   5        $%��BoutonValiderModificationClient��5�      $��Valider��69   $
��Left=�6K   $��449,438,0,0q�6f   $	��Top=�6{   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -B   5        $��BoutonValiderNumeroCommis��5�      $��Valider��63   $
��Left=�6E   $��
600,75,0,0q�6`   $	��Top=�6t   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -C   5        $%��BoutonValiderModificationCommis��5�      $��Valider��69   $
��Left=�6K   $��449,438,0,0q�6f   $	��Top=�6{   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -D   5        $ ��BoutonValiderNumeroLivreur��5�      $��Valider��64   $
��Left=�6F   $��
600,75,0,0q�6a   $	��Top=�6u   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -E   5        $&�� BoutonValiderModificationLivreur��5�      $��Valider��6:   $
��Left=�6L   $��449,438,0,0q�6g   $	��Top=�6|   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 5�   
   -F   5        $��BoutonQuitter��5�   +   $��Menu principal��6   $
��Left=�6@   $��449,530,0,0q�6[   $	��Top=�6p   $	��123��6�   $��26��6�   5�      5�      