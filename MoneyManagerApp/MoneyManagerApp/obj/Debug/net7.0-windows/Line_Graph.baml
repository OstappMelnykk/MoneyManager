   M S B A M L   `   `   `  ����W  SMoneyManagerApp.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MoneyManagerApp.PresentationMoneyManagerApp.Presentation  5   	   -    'MoneyManagerApp.Presentation.Line_Graph   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   R NOxyPlot.Wpf, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0Y UOxyPlot.Wpf.Shared, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"oxyhttp://oxyplot.org/wpf   5   	   8local*clr-namespace:MoneyManagerApp.Presentation   5   	     � Title$  
Line graph��5
   	   $	��550��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � SizeToContent$ Manual=�6K    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%	  '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 5��6!   #��z��62   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      5      5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $	��129 �6   6.   �� 5      $	��671 �6   6-   
 � RowDefinitions
 5    
   �� 5!      6   �� 5"      6   �� 5#      6   �� 5$      6   �� 5%      6   .+�5'   
   � $��0��6   $��5��6   
����ح�6I   �� 5(   
   -   5        $
��Home��5(      $��Center=�6   $��Center=�6<   $��23(�6W   6e   �� 5)   
   -   5        $��Accounts��5)      $��Center=�6#   $��1��6@   $��Center=�6M   $��23(�6h   6v   �� 5*   
   -   5        $��My goals��5*      $��Center=�6#   $��2��6@   $��Center=�6M   $��23(�6h   6v   �� 5+   
   -   5        $��	Statistic��5+      $��Center=�6$   $��3��6A   $��Center=�6N   $��23(�6i   6w   �� 5,   
   -   5        $��
My profile��5,      $��Center=�6%   $��4��6B   $��Center=�6O   $��23(�6j   6x   � 5.   
   $��1��6   $��5��6   .+�5/      �� $��Center=�6   $��0,40,0,0q�65   $
��Wrap=�6G   $��	Statistic��6[   $	��Top=�6l   $��35(�6�   $��50��6�   $	��131��6�   �� 50      $��Center=�6   $��0,95,0,0q�65   $
��Wrap=�6G   $��Income vs expences��6[   $	��Top=�6u   $��25(�6�   $��35��6�   $	��250��6�     OxyPlot.Wpf.PlotView  52      -   5          Name$ plotView��52      $
��Left=�6-   $	��Top=�6H   $	��607��6`   $	��300��6l   $��
30,135,0,0q�6y   54      �� 57      -   5        $��23(�57      $��Apply��6#   $
��Left=�63   $��507,462,0,0q�6N   $	��Top=�6c   $��35��6{   $	��120��6�   ���#0092FF6�   �� 58      -   5         ��Name$ endDateTextBox��58      $
��Left=�6.   $��258,470,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��100��6�   $��27��6�   �� 59      -	   5        $ startDateTextBox��59      $
��Left=�60   $��106,470,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��100��6�   $��27��6�   �� 5:      $��18(�6   $
��Left=�6&   $��153,435,0,0q�6A   $
��Wrap=�6V   $��Select a date range��6j   $	��Top=�6�   $��25��6�   $	��155��6�   �� 5;      $��20(�6   $
��Left=�6&   $��
51,470,0,0q�6A   $
��Wrap=�6U   $��From:��6i   $	��Top=�6v   �� 5<      $��20(�6   $
��Left=�6&   $��226,470,0,0q�6A   $
��Wrap=�6V   $	��To:��6j   $	��Top=�6u    J� RenderTransformOrigin$ 0.425,-1.012&�6�   �� 5?      $��Line_Graph.png��6   $	��400��6,   $��Center=�68   $	��Top=�6U   $��	0,200,0,0q�6m   5A      5B      5C      5D      