   M S B A M L   `   `   `  ����I  EBlackJack_V1.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BlackJack_V1._1BlackJack_V1._1  5   	   W0clr-namespace:BlackJack_V1._1.Views.UserControls"BlackJack_V1._1.Views.UserControls  5   	   G(clr-namespace:BlackJack_V1._1.ViewModelsBlackJack_V1._1.ViewModels  5   	        BlackJack_V1._1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BlackJack_V1._1     5   	   Euserctrl0clr-namespace:BlackJack_V1._1.Views.UserControls     5   	   >	viewmodel(clr-namespace:BlackJack_V1._1.ViewModels     5   	     � Title$  
Black Jack��5
   	   $	��400��6   $	��800��6)    � 	Resources 5      )   #BlackJack_V1._1.ViewModels.PlayerVM   PlayerVM)   #BlackJack_V1._1.ViewModels.DealerVM  DealerVM,   &BlackJack_V1._1.ViewModels.BlackJackVM  BlackJackVM��%W   &	        &	      &	 &       5   
   6     5   
   6     5   
   6    5      .��5      �� 
��� � �$��5q�6!    �� CornerRadius$ 5��65   ._�5   
   �  � DataContext# [ 6   
���   � � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��	Your Hand��6   
�������$��0��6_   $	��200��6o   $	��200��6{   {�6&   �� *
IsGameOn+.��5      �� .+�5      1   +BlackJack_V1._1.Views.UserControls.PlayerUC  $	��200��6$   �� 5      
���������62   �� *PlayerScore+5      5      �� 5       $��Dealers Hand��6   
�������$��2��6f   $	��200��6v   $	��200��6�   {�6-   �� *
IsGameOn+.��5!      �� .+�5"      1   +BlackJack_V1._1.Views.UserControls.DealerUC  $	��200��6$   �� 5#      
���������62   �� *DealerScore+5$      5%      �� 5&   
   $��1��6   $��Center=�6&   .+�5'      �� 
��� � �$��
Start Game��6(   $��50��6>   ��6J   �� *StartGameCommand+5(      �� 5)   
   $��1��6   $��Center=�6%   .+�5+      �� 
���   �$
��Left=�6G   ��6'   �� *PlayerLabel+6G   �� 5,      
���   �$��Right=�6G   ��6'   �� *DealerLabel+6G   5-      �� 5.   
   $��1��6    �� Orientation$ Vertical=�6%   $	��Top=�6<   $��Center=�6T   .+�5/      �� z�50      �� 51       �� ScaleX$ 2Q�6%    �� ScaleY$ 2Q�60   �� 53      
��� � �$��Segoe)�6+   $��	BlackJack��6>   $��Center=�6R   $	��Top=�6o   54      �� 55      $ 
Horizontal=�6   $��Center=�62   $	��115��6O   $	��115��6\   .+�56      �� $��/Images/Ace_Spades.png��6   $��60��68   $��75��6C   �� 57      $��/Images/Jack_Diamonds.png��6   $��60��6;   $��75��6F   58      59      5:      5;      5<      