   M S B A M L   `   `   `  ����W  SMoneyManagerApp.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   /    )MoneyManagerApp.Presentation.Edit_Profile   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:MoneyManagerApp.Presentation     5   	     � Title$  Edit profile��5   	   $	��550��6   $	��800��6+    � 
ResizeMode$ NoResize=�67    � SizeToContent$ Manual=�6M    � 	Resources 5	       �� 
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
268,25,0,0q�63   $
��Wrap=�6G   $��Edit profile��6[   $	��Top=�6o   $��35(�6�   $��50��6�   $	��200��6�   �� 5-      -   5         ��Name$ NewPhotoImage��5-      $
��Left=�6+   $	��170��6F   $��125,123,0,0q�6S   $	��Top=�6h   $	��200��6�   $��My_Photo.png��6�   �� 5.      -   5        $��25(�5.      $
��Back��6#   $
��Left=�62   $��
125,35,0,0q�6M   $	��Top=�6a   $��40��6y   $��80��6�   ���#AA00D76�   �� 50      -   5        $��25(�50      $
��Save��6#   $
��Left=�62   $��484,443,0,0q�6M   $	��Top=�6b   $��40��6z   $	��110��6�   ���#0092FF6�   �� 52      -	   5        $��Change photo��52      $
��Left=�6,   $��125,310,0,0q�6G   $	��Top=�6\   $��25(�6t   ���#0092FF$	��164��6�   $��37��6�   �� 53      $
��Left=�6   $��394,148,0,0q�63   $
��Wrap=�6H   $��Set Name��6\   $	��Top=�6l   $ ��23                        (�6�   �� 55      -
   5         ��Name$ FirstTextBox��55      $
��Left=�6,   $��394,184,0,0q�6G    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��200��6�   $��27��6�   6�   �� 56      $
��Left=�6   $��394,241,0,0q�63   $
��Wrap=�6H   $��Set E-mail/Phone��6\   $	��Top=�6t   $ ��23                        (�6�    J� RenderTransformOrigin$ -0.351,0.419&�57      �� 58      -   5        $ ThirdTextBox��58      $
��Left=�6-   $��394,277,0,0q�6H   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��200��6�   $��27��6�   5:      5;      5<      