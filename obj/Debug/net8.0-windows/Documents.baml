   M S B A M L   `   `   `  ����  amira_kenza_yasmineUA2&     amira_kenza_yasmineUA2.Documents   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � $��10q�6     � RowDefinitions  5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Chercher un livre��6   $��14(�6-   $
��Bold"�6;   $��0,0,0,10q�6M   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��	0,10,0,20q�6;   .+�5      �� -   5         ��Name$ 	SearchBox��5      $	��300��6)   $��30��65   $��0,0,10,0q�6A   �� 5      -   5        $��Chercher��5      $��80��6(   $��30��63   ���#2F316F���#F0FFFF6i   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ BooksDataGrid��5         AutoGenerateColumns$ False��6*   $	��300��6F   $��2��6S      CanUserAddRows$ False��6`   $   HorizontalScrollBarVisibility$
 Auto=�6w      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 ISBN��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 1.5* 6L   
   
Foreground

 �   �1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *ISBN+6Y     5      $ Titre��6%   $	 2* 6N   

 �   � 64   �� *Titre+6Y     5      $ Auteur��6%   $	 2* 6P   

 �   � 65   �� *Auteur+6[     5      $ Année��6%   $
	 1.5* 6N   

 �   � 64   �� *Annee+6[   5      5      5      