   M S B A M L   `   `   `  ����W  SMoneyManagerApp.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   K*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   '    !MoneyManagerApp.Presentation.Home   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:MoneyManagerApp.Presentation     5   	   A
converters*clr-namespace:MoneyManagerApp.Presentation     5   	     � Title$
  Home��5	   	   $	��550��6   $	��800��6#    � 
ResizeMode$ NoResize=�6/    � SizeToContent$ Manual=�6E   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��129 �6   6.   �� 5      $	��671 �6   6-    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   � $��0��6   $��5��6   
����ح�.+�5      �� 
���   �$��1q�6)   5      �� 5   
   -   5        $
��Home��5      $��Center=�6   $��Center=�6<   $��23(�6W   6e   �� 5   
   -   5        $��Accounts��5      $��Center=�6#   $��1��6@   $��Center=�6M   $��23(�6h   6v   �� 5   
   -   5        $��My goals��5      $��Center=�6#   $��2��6@   $��Center=�6M   $��23(�6h   6v   �� 5   
   -   5        $��	Statistic��5      $��Center=�6$   $��3��6A   $��Center=�6N   $��23(�6i   6w   �� 5   
   -   5        $��
My profile��5      $��Center=�6%   $��4��6B   $��Center=�6O   $��23(�6j   6x   � 5"   
   $��1��6   $��5��6   .+�5$      �� $
��Left=�6   $��
93,100,0,0q�63   $
��Wrap=�6G   $��Balance:��6[   $	��Top=�6k   $��22(�6�   $��32��6�   $	��106��6�   �� 5%      $
��Left=�6   $��	93,50,0,0q�63   $
��Wrap=�6F   $��Account:��6Z   $	��Top=�6j   $��22(�6�   $��31��6�   $	��113��6�   �� 5&      -   5         ��Name$ AccountNameLabel��5&      $
��Main��6.   $
��Left=�6=   $��
229,46,0,0q�6X   $	��Top=�6l   $	��150��6�   $��22(�6�   $��38��6�    J� RenderTransformOrigin$ 0.515,0.565&�6�   �� 5'      -   5        $ BalanceLabel��5'      $��19��6*   $
��Left=�68   $��
229,94,0,0q�6S   $	��Top=�6g   $	��150��6   $��22(�6�   $��38��6�   �� 5(      -   5        $��22(�5(      $��Account setting��6%   $
��Left=�6?   $��
384,51,0,0q�6Z   $	��Top=�6n   $	��185��6�   $��60��6�   ���#AA00D7
������� � 	Resources 5)       �� 
TargetType	 �� Property
 �� Value��%^   '��       �� 5*      " ��6   .�5+      �� 	 �@��CornerRadius$
 5��69   5,      5-      5.      �� 5/      $
��Left=�6   $	��235��63   $��
93,155,0,0q�6@   
���   �$	��Top=�6c   $	��476��6{   
����ح�6�   �� 50      -	   5        $��22(�50      $��Add transaction��6#   $
��Left=�6=   $��
93,460,0,0q�6X   $	��Top=�6l   $	��476��6�   $��40��6�   ���#0092FF
������� 51      ��%^   '��       �� 52      " ��6   .�53      �� 	 �@��CornerRadius$
 5��69   54      55      56      �� 57      $
��Left=�6   $	��255��61   $��
93,145,0,0q�6>   $	��Top=�6R   $	��476��6j   
����ح�
���   �$��1q�6�   ��58      �� *Transactions+��59      �� 5:      .R�5;      �� .+�5<      ��  �� Orientation$ 
Horizontal=�6)   $��0,0,0,5q�6B   .+�5=   "   �� $��18(�6U   $	��160��6c   ��6,   �� *TransactionsDescription+6c   �� 5>   "   $	��₴��6,   $��18(�65   �� 5?   "   $��18(�6M   $	��100��6[   ��6,   �� *TransactionsSum+6[   �� 5@   "   $��18(�6v   ��6,   �� *TransactionsDate+ �� StringFormat$ {0:dd/MM/yyyy HH:mm:ss}��6v   5A      5C      5D      5F      �� 5H      -
   5        $��22(�5H      $��See more��6#   $
��Left=�66   $��
93,408,0,0q�6Q   $	��Top=�6e   $	��476��6}   ���#0092FF
�������$��40                     ��6�    5J      ��%^   '��       �� 5K      " ��6   .�5L      �� 	 �@��CornerRadius$
 5��69   5M      5N      5O      5Q      5U      5V      