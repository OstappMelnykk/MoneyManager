   M S B A M L   `   `   `  ����W  SMoneyManagerApp.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   -    'MoneyManagerApp.Presentation.My_Profile   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:MoneyManagerApp.Presentation     5   	     � Title$  
My profile��5   	   $	��550��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � SizeToContent$ Manual=�6K    � 	Resources 5	       �� 
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
   $��1��6   $��5��6   .+�5,      �� $
��Left=�6   $��
284,24,0,0q�63   $
��Wrap=�6G   $��
My profile��6[   $	��Top=�6m   $��35(�6�   $��50��6�   $	��200��6�   �� 5-      -   5         ��Name$ MyImage��5-      $
��Left=�6%   $	��231��6@   $��124,102,0,0q�6M   $	��Top=�6b   $	��247��6z   $��images/My_Photo.png��6�   �� 5.      $
��Left=�6   $��124,376,0,0q�64   $
��Wrap=�6I   $��	User name��6]   $	��Top=�6n   $��24(�6�   $	��126��6�   �� 5/      -   5        $
��Left=�5/      $��431,103,0,0q�61   $	��Top=�6F   $	��120��6^   $��60��6j   ���#0092FF.��50      �� $��Center=�6   $	��Top=�6:   $��18(�6R   $��  Edit
profile��6`   51      �� 52      -   5        $
��Left=�52      $��431,185,0,0q�60   $	��Top=�6E   $	��120��6^   $��60��6j   ���#AA00D7.��53      �� $��Center=�6   $	��Top=�6:   $��18(�6R   $��Security
 setting��6`   55      �� 56      -	   5        $
��Left=�56      $��431,273,0,0q�60   $	��Top=�6E   $	��120��6^   $��60��6j   ���#FF3349.��57      �� $��Center=�6   $	��Top=�6:   $��18(�6R   $��	 Log
 out��6`   59      �� 5:      $
��Left=�6   $��124,452,0,0q�63   $
��Wrap=�6H   $��E-mail/Phone��6\   $	��Top=�6p   $��24(�6�    J� RenderTransformOrigin$ 0.386,0.565&�6�   $��38��6�   $	��189��6�   �� 5;      -
   5         ��Name$ EmailTextBlock��5;      $
��Left=�61   $��433,452,0,0q�6L   $
��Wrap=�6a   $��
Vental-Koz��6u   $	��Top=�6�   $��24(�6�   �� 5A      -   5        $ UsernameTextBlock��5A      $	��202��63   $��27��6?   $��431,376,0,0q�6L   $
��Left=�6a   $	��Top=�6|   $��24(�6�   5C      5E      5F      5G      