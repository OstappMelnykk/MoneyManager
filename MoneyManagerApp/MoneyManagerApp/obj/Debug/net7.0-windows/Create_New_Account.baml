   M S B A M L   `   `   `  ����W  SMoneyManagerApp.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   5    /MoneyManagerApp.Presentation.Create_New_Account   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:MoneyManagerApp.Presentation     5   	     � Title$  Create new account��5   	   $	��550��6$   $	��800��61    � 
ResizeMode$ NoResize=�6=    � SizeToContent$ Manual=�6S    � 	Resources 5	         CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius  BackButtonStyle	 �� BasedOn��%�  &	        &	 �    7   �� 5   
   " ��6*   .�5      ��  � ��$ 26(�6)   �� 5       � ��$ 45��6'   �� 5       � ��$	 140��6&   �� 5       � �� �#0092FF6+   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��1q�6!   ���#0092FF#��z��6K   $ 5��6u   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      5      �� 5   
   " ��6(   8	   .�5      ��  � ��$ 25(�6)   �� 5       � ��$ 40��6'   �� 5        � ��$ 80��6&   �� 5!       � �� �#AA00D76+   �� 5"       � ��$ 	70,40,0,0q�6'   5#      5$      .��5&      � 
 � ColumnDefinitions
 5'   
   �� 5(      $	��129 �6   6.   �� 5)      $	��671 �6   6-    � RowDefinitions 5+   
   �� 5,      6   �� 5-      6   �� 5.      6   �� 5/      6   �� 50      6   .+�52   
   � $��0��6   $��5��6   
����ح�6I   �� 53   
   -   5        $
��Home��53      $��Center=�6   $��Center=�6<   $��23(�6W   6e   �� 54   
   -   5        $��Accounts��54      $��Center=�6#   $��1��6@   $��Center=�6M   $��23(�6h   6v   �� 55   
   -   5        $��My goals��55      $��Center=�6#   $��2��6@   $��Center=�6M   $��23(�6h   6v   �� 56   
   -   5        $��	Statistic��56      $��Center=�6$   $��3��6A   $��Center=�6N   $��23(�6i   6w   �� 57   
   -   5        $��
My profile��57      $��Center=�6%   $��4��6B   $��Center=�6O   $��23(�6j   6x   � 58   
   $��1��6   $��5��6   .+�59      �� $
��Left=�6   $��
226,35,0,0q�63   $
��Wrap=�6G   $��Create new account��6[   $	��Top=�6u   $��35(�6�   $��50��6�   $	��320��6�   �� 5:      $
��Left=�6   $��
76,150,0,0q�63   $
��Wrap=�6G   $��Account name:��6[   $	��Top=�6p   $��23(�6�   $��35��6�   $	��150��6�   �� 5;      -   5         ��Name$ AccountNameTextBox��5;      $
��Left=�62   $��336,152,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��210��6�   $��20(�6�   �� 5<      -   5        #��[  5<      $
��Save��6@   $
��Left=�6O   $��406,412,0,0q�6j   $	��Top=�6   6�   �� 5=      -   5        #��[ 5=      $
��Back��6>   $
��Left=�6M   $	��Top=�6h   6�   5>      5?      5@      