   M S B A M L   `   `   `  ����c  _POOA_Projet_Yunong_Liu_et_Adrien_Lefevre, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:POOA_Projet_Yunong_Liu_et_Adrien_Lefevre(POOA_Projet_Yunong_Liu_et_Adrien_Lefevre  5   	   6    0POOA_Projet_Yunong_Liu_et_Adrien_Lefevre.Module3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:POOA_Projet_Yunong_Liu_et_Adrien_Lefevre     5   	     � Title$  Module3��5   	   $	��450��6   $	��800��6&   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ White��6   � 5      $ 	#FFBB8102��6    � Offset$ 1Q�61   5      .+�5   
   �� -   5        $��	MaListBox��5   r   $
��Left=�6   $	��202��6-   $��
153,28,0,0q�6:   $	��Top=�6N   $	��494��6f   .@�5      �� -   5        $9��3Afficher le nombre de commandes gérées par commis��5      $	��480��6Q   $��35��6]   $��20(�6i   $��Dubai Medium)�6w   6�   �� 5      -   5        $>��8Afficher le nombre de livraisons effectuées par livreur��5      $	��480��6W   $��35��6c   $��20(�6o   $��Dubai Medium)�6}   6�   �� 5      -   5        $8��2Afficher les commandes selon une période de temps��5      $	��480��6Q   $��35��6]   $��20(�6i   $��Dubai Medium)�6w   6�   �� 5      -   5        $0��*Afficher la moyenne des prix des commandes��5      $	��480��6J   $��35��6V   $��20(�6b   $��Dubai Medium)�6p   6�   �� 5      -   5        $-��'Afficher la moyenne des comptes clients��5      $	��480��6G   $��35��6S   $��20(�6_   $��Dubai Medium)�6m   6�   5      �� 5   
   -   5        $��PanelBoxEtBlocksPeriode��5      $
��Left=�65   $	��170��6P   $��
185,44,0,0q�6]   $	��Top=�6q   $	��387��6�   $y�Hidden=�6�   .+�5      �� $
��Wrap=�6   $��Rentrez le jour��6,   �� 5      -   5        $��TextBoxPeriodeJour��5   P   $��23��6    �� TextWrapping$
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5      $
��Wrap=�6   $��Rentrez le mois��6,   �� 5      -	   5        $��TextBoxPeriodeMois��5   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5      $
��Wrap=�6   $��Rentrez l'annee��6,   �� 5      -
   5        $��TextBoxPeriodeAnnee��5   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5       �� 5"   
   -   5        $��BoutonQuitter��5"   +   $��Menu principal��6   $
��Left=�6@   $��449,300,0,0q�6[   $	��Top=�6p   $	��123��6�   $��26��6�   $y�Visible=�6�   �� 5$   
   -   5        $��BoutonValiderPeriode��5$      $��Valider��6.   $
��Left=�6@   $��449,331,0,0q�6[   $	��Top=�6p   $	��123��6�   $��25��6�   $y�Visible=�6�   �� 5&   
   -   5        $��
MaTexteBox��5&      $
��Left=�6%   $��26��6@   $��599,362,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��125��6�   $y�Visible=�6�   �� 5'   
   -   5        $��MonTexteBlock��5'      $
��Left=�6*   $��
54,300,0,0q�6E   $
��Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��111��6�   $	��270��6�   
�������$y�Visible=�6�   5)      5*      