   M S B A M L   `   `   `  ����W  SMoneyManagerApp.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   8    2MoneyManagerApp.Presentation.Transfer_From_Account   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:MoneyManagerApp.Presentation     5   	     � Title$  Transfer to account��5   	   $	��550��6%   $	��800��62    � 
ResizeMode$ NoResize=�6>    � SizeToContent$ Manual=�6T    � 	Resources 5	       �� 
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
   $��1��6   $��5��6   .+�5,      �� $��Center=�6   $��0,29,0,0q�65   $
��Wrap=�6G   $	��Top=�6[   $��32(�6s   $��94��6�   $	��211��6�   �� 6�   $�Transfer from ��6�   �� 6�   �� 6�   $�     account��6�   6�   �� 5-      -   5        $��25(�5-      $
��Back��6#   $
��Left=�62   $��
110,56,0,0q�6M   $	��Top=�6a   $��40��6y   $��80��6�   ���#AA00D76�   �� 5.      $
��Left=�6   $��120,200,0,0q�63   $
��Wrap=�6H   $��From:��6\   $	��Top=�6i   $��25(�6�   $��40��6�   $��60��6�   �� 5/      $
��Left=�6   $��120,270,0,0q�63   $
��Wrap=�6H   $��Description:��6\   $	��Top=�6p   $��25(�6�   $��40��6�   $	��140��6�   �� 50      $
��Left=�6   $��120,331,0,0q�63   $
��Wrap=�6H   $
��Sum:��6\   $	��Top=�6h   $��25(�6�   $��40��6�   $��60��6�   �� 51      -   5         ��Name$ FromAccountComboBox��51      $��25(�64   $
��Left=�6B   $��336,200,0,0q�6]    �� Text$ Account name��6s   $	��Top=�6�   $	��210��6�   �� 52      -   5         ��Name$ DescriptionTextBox��52      $��25(�62   $
��Left=�6@   $��336,270,0,0q�6[    �� TextWrapping$
 Wrap=�6p   $��Description��6�   $	��Top=�6�   $	��210��6�   �� 53      -	   5        $ 
SumTextBox��53      $��25(�6*   $
��Left=�68   $��336,340,0,0q�6S   $
 Wrap=�6h   $��Amount��6|   $	��Top=�6�   $	��210��6�   6�   �� 54      -
   5        $��25(�54      $	��Add��6#   $
��Left=�61   $��376,435,0,0q�6L   $	��Top=�6a   $��40��6y   $	��170��6�   ���#0092FF6�   56      58      59      