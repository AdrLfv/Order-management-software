   M S B A M L   `   `   `  ����c  _POOA_Projet_Yunong_Liu_et_Adrien_Lefevre, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:POOA_Projet_Yunong_Liu_et_Adrien_Lefevre(POOA_Projet_Yunong_Liu_et_Adrien_Lefevre  5   	   6    0POOA_Projet_Yunong_Liu_et_Adrien_Lefevre.Module4   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:POOA_Projet_Yunong_Liu_et_Adrien_Lefevre     5   	     � Title$  Module4��5   	   $	��450��6   $	��800��6&   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ White��6   � 5      $ 	#FFBB8102��6    � Offset$ 1Q�61   5      .+�5   
   �� -   5        $��	MaListBox��5   s   $
��Left=�6   $	��164��6-   $��186,106,0,0q�6:   $	��Top=�6O   $	��430��6g   $y�Hidden=�6�   .@�5      �� -   5        $1��+Utiliser un code promotion sur une commande��5      $	��412��6K   $��35��6W   $��20(�6c   $��Dubai Medium)�6q   6�   �� 5      -   5        $.��(Verifier si un code promo est utilisable��5      $	��412��6H   $��35��6T   $��20(�6`   $��Dubai Medium)�6n   6�   �� 5      -   5        $&�� Afficher tous les codes utilises��5      $	��412��6@   $��35��6L   $��20(�6X   $��Dubai Medium)�6f   6�   �� 5      -   5        $��Tout sauvegarder��5      $	��412��60   $��35��6<   $��20(�6H   $��Dubai Medium)�6V   6q   5      �� 5   
   -   5        $#��PanelBoxEtBlocksAppliquerCode��5      $
��Left=�6;   $	��393��6V   $��
185,62,0,0q�6c   $	��Top=�6w   $	��387��6�   $y�Hidden=�6�   .+�5      �� $
��Wrap=�6   $#��Rentrez le numero de commande��6,   �� 5      -   5        $��TextBoxAppliquerCode0��5   P   $��23��6    �� TextWrapping$
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5      $
��Wrap=�6   $��Rentrez le codo promo��6,   �� 5      -   5        $��TextBoxAppliquerCode1��5   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5      �� 5   
   -	   5        $"��PanelBoxEtBlocksVerifierCode��5      $
��Left=�6:   $	��393��6U   $��
185,62,0,0q�6b   $	��Top=�6v   $	��387��6�   $y�Visible=�6�   .+�5       �� $
��Wrap=�6   $.��(Rentrez le numero de telephone du client��6,   �� 5!      -
   5        $��TextBoxVerifierCode0��5!   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   �� 5#      $
��Wrap=�6   $��Rentrez le codo promo��6,   �� 5$      -   5        $��TextBoxVerifierCode1��5$   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5%      �� 5&   
   -   5        $)��#PanelBoxEtBlocksValiderAfficherCode��5&      $
��Left=�6A   $	��122��6\   $��
185,62,0,0q�6i   $	��Top=�6}   $	��387��6�   $y�Visible=�6�   .+�5'      �� $
��Wrap=�6   $.��(Rentrez le numero de telephone du client��6,   �� 5(      -   5        $��TextBoxAfficherCode0��5(   P   $��23��6   $
 Wrap=�6"   $�� ��66   $��0,0,0,20q�6>   6P   5)      �� 5,   
   -   5        $��
MaTexteBox��5,      $
��Left=�6%   $��23��6@   $��425,331,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��191��6�   $y�Hidden=�6�   �� 5-   
   -   5        $��MonTexteBlock��5-      $
��Left=�6*   $��
65,331,0,0q�6E   $
��Wrap=�6Y   $�� ��6m   $	��Top=�6u   $��78��6�   $	��310��6�   
�������$y�Hidden=�6�   �� 5.   
   -   5        $��BoutonQuitter��5.   +   $��Menu principal��6   $
��Left=�6@   $��449,300,0,0q�6[   $	��Top=�6p   $	��123��6�   $��26��6�   $y�Visible=�6�   �� 5/   
   -   5        $��BoutonValiderCodePromo��5/      $��Valider��60   $
��Left=�6B   $��449,189,0,0q�6]   $	��Top=�6r   $	��123��6�   $��25��6�   $y�Hidden=�6�   �� 50   
   -   5        $$��BoutonValiderVerifierCodePromo��50      $��Valider��68   $
��Left=�6J   $��449,189,0,0q�6e   $	��Top=�6z   $	��123��6�   $��25��6�   $y�Visible=�6�   �� 51   
   -   5        $$��BoutonValiderAfficherCodePromo��51      $��Valider��68   $
��Left=�6J   $��449,189,0,0q�6e   $	��Top=�6z   $	��123��6�   $��25��6�   $y�Visible=�6�   52      53      