   M S B A M L   `   `   `  ����H  DIIQ Dashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:IIQ_DashboardIIQ_Dashboard  5   	       IIQ_Dashboard.Tasks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:IIQ_Dashboard     5   	     � Title$  	IIQ Tasks��5   
    � Icon$< 6C:\final\IIQ Dashboard\IIQ Dashboard\images\tasks1.png��6   
�������$	��500��6r   $��Stretch=�6~   $��Stretch=�6�    � WindowStartupLocation$ CenterScreen=�6�    � WindowState$ 	Maximized=�6�    � WindowStyle$ ThreeDBorderWindow=�6�   $��2q�6  ���#007FFF � 	Resources 5	       �� Color��%(  (��       5
      * SystemColors.HighlightBrushKey+)(�� #     5      *SystemColors.ControlBrushKey+)(�� F     5      *$"SystemColors.HighlightTextBrushKey+)(�� e     5      *" SystemColors.ControlTextBrushKey+)(�� �     5      *1/SystemColors.InactiveSelectionHighlightBrushKey+)(�� �     5      *SystemColors.ScrollBarColor+)�� 5
   
   $ 	#FF3598DC��6L   �� 5   
   $ 	#FFD0D1D7��6J   �� 5   
   $ White��6P   �� 5   
   $ Black��6N   �� 5   
   $ Transparent��6]   �� 5   
   $ 	#FFD0D1D7��6I   5      .��5      � #��� ��6    � ContextMenu 5   
   �� 5      $��0,1,1,1q�6   $��Calibri)�64    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      .+�5   
   �� 	 �� TabStripPlacement$
	 Left=�6    5      
 �� 
TargetType �� Property �� Value � LayoutTransform �� Angle��%�   '��       �� 5      "
 ��6   .�5      ��  � �� 5      �� 5      .R�5    "   �� #��z��63    5!   &   �� 5"   *   $	 270Q�6:   5$   #   5%      5'      �� 5(       � ��$ 10q�60   5)      5*      .@�5+      �� $��Daily Task Status��6   .��5,      &   System.Windows.Controls.DataGrid  -   5          Name$ tskgrid��5,   �   $��4��6      AutoGenerateColumns .     CanUserSortColumns .    CanUserResizeRows .  $��1��6x   $��2��6�   
�������
���   �   AlternatingRowBackground �	#FFEAEAEA   HorizontalGridLinesBrush �	#FFD6D6D6   GridLinesVisibility$ 
Horizontal=�6?     CanUserReorderColumns .     CanUserResizeColumns .     MinColumnWidth$ 16Q�6�     RowBackground �	#FFF2F2F2   	RowHeight$ 50Q�6�     VerticalGridLinesBrush 6�   Z�    Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 150* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *name+    ElementStyle  51      �� 52      "
 ��6$   .�53   "   ��  � ��$
 Wrap=�6A   �� 54   &    � ��$ Center=�6L   �� 55   "    � ��$ Center=�6F   56      !   EditingElementStyle! 58      �� 59      "
 ��6$   .�5:   "   ��  � ��$ Center=�6H   �� 5;   "    � ��$ Center=�6F   �� 5<   "    � ��
 ��  �6?   �� 5=   "    � �� 69   �� *name+5>      5@      4  .System.Windows.Controls.DataGridTemplateColumn  5B      $ Created��61   $
 150* 6B   "   CellTemplate" 5C      �� 5D   "   .R�5E   &   �� $��4q�6I   $��Center=�6T   $��Center=�6q   ��60   �� *	created+6q   5F   #   #   CellEditingTemplate# 5H      �� 5I   "   .R�5J   &   (  "System.Windows.Controls.DatePicker  $��Center=�6R   $��Center=�6o   $   SelectedDate$ 61   �� *	created+6o   5K   #   5M        5O      $ 	Completed��61   $
 150* 6D   " 5P      �� 5Q   "   .R�5R   &   �� $��4q�6K   $��Center=�6V   $��Center=�6s   ��60   �� *	completed+6s   5S   #   # 5U      �� 5V   "   .R�5W   &     $��Center=�6T   $��Center=�6q   $ 61   �� *	completed+6q   5X   #   5Z        5\      $ Status��6-   $
 150* 6X    6=   �� *status+  5]      �� 5^   "   "
 ��6(   .�5_   &   ��  � ��$
 Wrap=�6E   �� 5`   &    � ��$ Center=�6L   �� 5a   &    � ��$ Center=�6J   5b   #   ! 5d      �� 5e   "   "
 ��6(   .�5f   &   ��  � ��$ Center=�6L   �� 5g   &    � ��$ Center=�6J   �� 5h   &    � ��
 ��  �6C   �� 5i   &    � �� 6=   �� *status+5j   #   5l      5n      5o      �� 5p      $��Failed Tasks��6   .��5r        -   5        $ 	fltskgrid��5r   �   $��4��6    .   .  .  $��1��6x   $��2��6�   
�������
���   � �	#FFEAEAEA �	#FFD6D6D6$ 
Horizontal=�6A   .   .  $ 16Q�6�   �	#FFF2F2F2$ 50Q�6�   6�   Z�  5t        5v      $
 Name��6-   $
 150* 6T    6;   �� *name+  5w      �� 5x   "   "
 ��6(   .�5y   &   ��  � ��$
 Wrap=�6E   �� 5z   &    � ��$ Center=�6L   �� 5{   &    � ��$ Center=�6J   5|   #   ! 5~      �� 5   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   �� 5�   &    � ��
 ��  �6C   �� 5�   &    � �� 6=   �� *name+5�   #   5�        5�      $ Created��61   $
 150* 6B   " 5�      �� 5�   "   .R�5�   &   �� $��4q�6I   $��Center=�6T   $��Center=�6q   ��60   �� *	created+6q   5�   #   # 5�      �� 5�   "   .R�5�   &     $��Center=�6R   $��Center=�6o   $ 61   �� *	created+6o   5�   #   5�        5�      $ 	Completed��61   $
 150* 6D   " 5�      �� 5�   "   .R�5�   &   �� $��4q�6K   $��Center=�6V   $��Center=�6s   ��60   �� *	completed+6s   5�   #   # 5�      �� 5�   "   .R�5�   &     $��Center=�6T   $��Center=�6q   $ 61   �� *	completed+6q   5�   #   5�      %   RowDetailsTemplate% 5�      �� 5�      .R�5�      �� $��2q�6%   ���	#FF36BCDC._�5�   "   � $��75��6'   & � ColumnDefinitions& 5�   &   �� 5�   *   $��30 �6;   �� 5�   *   $	��100 �6;   �� 5�   *   $	��50* �6;   ' � RowDefinitions' 5�   &   �� 5�   *   $��10 �68   �� 5�   *   $��25 �68   �� 5�   *   $��5 �68   �� 5�   *   $��25 �68   �� 5�   *   $��15 �68   .+�5�   &   �� $��Error Message��60   $
��Wrap=�6E   
���   �$��1��6l   $��1��6y   $��Center=�6�   $
��Left=�6�   �� 5�   &   ( �� TextWrapping$
( Wrap=�6.   $��1��6B   $��2��6O   $��Center=�6�   $
��Left=�6�   ��6_   �� ) �� Path$) error_message�6�   5�   #   5�      5�      5�      5�      �� 5�      $��Warnings��6   .��5�        -   5        $ wargrid��5�   �   $��4��6    .   .  .  $��1��6x   $��2��6�   
�������
���   � �	#FFEAEAEA �	#FFD6D6D6$ 
Horizontal=�6?   .   .  $ 16Q�6�   �	#FFF2F2F2$ 50Q�6�   6�   Z�  5�        5�      $
 Name��6-   $
 150* 6T    6;   �� *name+  5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$
 Wrap=�6E   �� 5�   &    � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   5�   #   ! 5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��$ Center=�6J   �� 5�   &    � ��
 ��  �6C   �� 5�   &    � �� 6=   �� *name+5�   #   5�        5�      $ Created��61   $
 150* 6B   " 5�      �� 5�   "   .R�5�   &   �� $��4q�6I   $��Center=�6T   $��Center=�6q   ��60   �� *	created+6q   5�   #   # 5�      �� 5�   "   .R�5�   &     $��Center=�6R   $��Center=�6o   $ 61   �� *	created+6o   5�   #   5�        5�      $ 	Completed��61   $
 150* 6D   " 5�      �� 5�   "   .R�5�   &   �� $��4q�6K   $��Center=�6V   $��Center=�6s   ��60   �� *	completed+6s   5�   #   # 5�      �� 5�   "   .R�5�   &     $��Center=�6T   $��Center=�6q   $ 61   �� *	completed+6q   5�   #   5�      % 5�      �� 5�      .R�5�      �� $��2q�6%   ���	#FF36BCDC._�5�   "   � $��75��6'   & 5�   &   �� 5�   *   $��30 �6;   �� 5�   *   $	��100 �6;   �� 5�   *   $	��50* �6;   ' 5�   &   �� 5�   *   $��10 �68   �� 5�   *   $��25 �68   �� 5�   *   $��5 �68   �� 5�   *   $��25 �68   �� 5�   *   $��15 �68   .+�5�   &   �� $��Error Message��60   $
��Wrap=�6E   
���   �$��1��6l   $��1��6y   $��Center=�6�   $
��Left=�6�   �� 5�   &   $
( Wrap=�6.   $��1��6B   $��2��6O   $��Center=�6�   $
��Left=�6�   ��6_   �� $) error_message�6�   5   #   5     5     5     5     5     5     5	     