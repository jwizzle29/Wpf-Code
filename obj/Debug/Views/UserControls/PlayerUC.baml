   M S B A M L   `   `   `  ����I  EBlackJack_V1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:BlackJack_V1._1.Views.UserControls"BlackJack_V1._1.Views.UserControls  5      1    +BlackJack_V1._1.Views.UserControls.PlayerUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:BlackJack_V1._1.Views.UserControls     5        � 	Resources  5	         PlayerHandTemplate��%�   &	        �� 5
   
   .R�5      �� �� 5      $��50��69   $��90��6D   ��6   �� *CardImagePath+6D   5      5      5      .��5      �  � ColumnDefinitions 5   
    � RowDefinitions 5   
   �� 5      .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� #��[  6   $	��160��6J   $	��240��6W   
���**��
��� � �
������� �� SelectedItem 5      �� *PlayerInstance.SelectedCard+��5      �� *PlayerInstance.Hand+��5      �� 5      .R�5      �� $ 
Horizontal=�6%   5      5      5       �� 5!   
   $��2��6   $��Bottom=�6"   $
��Left=�6=   $��60��6X   .+�5"      �� $	��Hit��6   ��6#   �� *!PlayerInstance.PlayerHitCommand+5#      �� 5$   
   $��2��6   $��Bottom=�6"   $��Right=�6=   $��60��6Y   .+�5%      �� $
��Stop��6   ��6$   �� *" PlayerInstance.PlayerStopCommand+5&      5'      5(      