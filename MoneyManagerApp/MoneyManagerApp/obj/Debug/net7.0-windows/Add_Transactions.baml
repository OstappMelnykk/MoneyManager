   M S B A M L   `   `   `  ����W  SMoneyManagerApp.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   3    -MoneyManagerApp.Presentation.Add_Transactions   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:MoneyManagerApp.Presentation     5   	     � Title$  Add transaction��5   	   $	��550��6!   $	��800��6.    � 
ResizeMode$ NoResize=�6:    � SizeToContent$ Manual=�6P    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%	  '��       �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 5��6!   #��z��62   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      5      5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $	��129 �6   6.   �� 5      $	��671 �6   6-   
 � RowDefinitions
 5   
   �� 5      6   �� 5      6   �� 5       6   �� 5!      6   �� 5"      6   .+�5$   
   � $��0��6   $��5��6   
����ح�6I   �� 5%   
   -   5        $
��Home��5%      $��Center=�6   $��Center=�6<   $��23(�6W   6e   �� 5&   
   -   5        $��Accounts��5&      $��Center=�6#   $��1��6@   $��Center=�6M   $��23(�6h   6v   �� 5'   
   -   5        $��My goals��5'      $��Center=�6#   $��2��6@   $��Center=�6M   $��23(�6h   6v   �� 5(   
   -   5        $��	Statistic��5(      $��Center=�6$   $��3��6A   $��Center=�6N   $��23(�6i   6w   �� 5)   
   -   5        $��
My profile��5)      $��Center=�6%   $��4��6B   $��Center=�6O   $��23(�6j   6x   � 5+   
   $��1��6   $��5��6   
 5,      �� 5-      $
��164* �6    �� 5.      $
��103* �6    .+�50      �� $��Center=�6   $��0,40,0,0q�65   $
��Wrap=�6G   $��Add transaction��6[   $	��Top=�6r   $��35(�6�   $��50��6�   $	��250��6�   �� 51      -   5        $��21(�51      $
��Back��6$   $
��Left=�63   $��	47,48,0,0q�6N   $	��Top=�6a   $��34��6y   $��90��6�   ���#AA00D7
������� 52      ��%^   '��       �� 53      " ��6   .�54      ��  �@��CornerRadius$ 5��69   55      56      57      �� 58      -   5        $��Center=�58      $��	0,140,0,0q�63   $	��Top=�6F   $��60��6^   $	��250��6j   $��19(�6v   ���#767676.��59      �� $��Transfer to account��6    �� TextAlignment$ Center=�68   5:      �� 5;      -   5        $��Tranfer from account��5;      $��Center=�64   $��	0,234,0,0q�6Q   $��60��6e   $	��250��6q   $��19(�6}   $	��Top=�6�   ���#7676766�   �� 5<      -	   5        $��Transfer between accounts��5<      $��Center=�69   $��0,12,0,0q�6V   $��60��6i   $	��250��6u   $��19(�6�   $	��Top=�6�   $��1��6�   ���#7676766�   5>      5@      5A      