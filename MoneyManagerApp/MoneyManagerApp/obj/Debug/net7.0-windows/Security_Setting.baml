   M S B A M L   `   `   `  ����W  SMoneyManagerApp.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   3    -MoneyManagerApp.Presentation.Security_Setting   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:MoneyManagerApp.Presentation     5   	     � Title$  Security setting��5   	   $	��550��6"   $	��800��6/    � 
ResizeMode$ NoResize=�6;    � SizeToContent$ Manual=�6Q    � 	Resources 5	       �� 
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
   $��1��6   $��5��6   $��0,5,0,-5q�60   .+�5,      �� $��Center=�6   $��0,25,0,0q�65   $
��Wrap=�6G   $��Security setting��6[   $	��Top=�6s   $��35(�6�   $��50��6�   $	��250��6�   �� 5-      -   5        $��25(�5-      $
��Back��6#   $
��Left=�62   $��	42,35,0,0q�6M   $	��Top=�6`   $��40��6x   $��80��6�   ���#AA00D76�   �� 5.      $��24(�6   $
��Left=�6&   $��210,135,0,0q�6A   $
��Wrap=�6V   $��Old password��6j   $	��Top=�6~   �� 5/      $��24(�6   $
��Left=�6&   $��210,224,0,0q�6A   $
��Wrap=�6V   $��New password��6j   $	��Top=�6~   �� 50      $��24(�6   $
��Left=�6&   $��210,305,0,0q�6A   $
��Wrap=�6V   $��Repeat new password��6j   $	��Top=�6�   G� 51      -   5         G�Name$ OldPasswordTextBox��51      $
��Left=�66   $��210,172,0,0q�6Q   $	��Top=�6g   $	��230��6   $��30��6�   $��20(�6�   G� 52      -   5        $ NewPasswordTextBox��52      $
��Left=�66   $	��Top=�6R   $	��230��6j   $��30��6v   $��20(�6�   $��210,261,0,0q�6�   G� 53      -	   5        $ RepeatPasswordTextBox��53      $
��Left=�69   $��210,342,0,0q�6T   $	��Top=�6j   $	��230��6�   $��30��6�   $��20(�6�   �� 54      -
   5        $��25(�54      $
��Save��6#   $
��Left=�62   $��245,401,0,0q�6M   $	��Top=�6b   $��35��6z   $	��160��6�   ���#0092FF6�   56      58      59      