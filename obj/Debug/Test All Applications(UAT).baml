   M S B A M L   `   `   `  ����H  DIIQ Dashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:IIQ_Dashboard.CustomButtonIIQ_Dashboard.CustomButton  5   
   -clr-namespace:IIQ_DashboardIIQ_Dashboard  5   	   .    (IIQ_Dashboard.Test_All_Applications_UAT_   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   BCustomControl(clr-namespace:IIQ_Dashboard.CustomButton     5   
   -localclr-namespace:IIQ_Dashboard     5   	     � Title$"  Test All Applications(UAT-A)��5
   	    � Icon$= 7C:\final\IIQ Dashboard\IIQ Dashboard\images\testcon.png��6.   
�������$	��500��6�   $��Stretch=�6�   $��Stretch=�6�    � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$ ThreeDBorderWindow=�6�   $��2q�6  ���#007FFF � 	Resources 5       �� Color��%(  (��       5      * SystemColors.HighlightBrushKey+)(�� #     5      *SystemColors.ControlBrushKey+)(�� F     5      *$"SystemColors.HighlightTextBrushKey+)(�� e     5      *" SystemColors.ControlTextBrushKey+)(�� �     5      *1/SystemColors.InactiveSelectionHighlightBrushKey+)(�� �     5      *SystemColors.ScrollBarColor+)�� 5   
   $ 	#FF3598DC��6L   �� 5   
   $ 	#FFD0D1D7��6J   �� 5   
   $ White��6P   �� 5   
   $ Black��6N   �� 5   
   $ Transparent��6]   �� 5   
   $ 	#FFD0D1D7��6I   5      .��5      � #��� ��6    � ContextMenu 5   
   �� 5      $��0,1,1,1q�6   $��Calibri)�64    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5       � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $��5* �6   �� 5      $	��50* �6   �� 5       $��5* �6   �� 5!      $
��600* �6   �� 5"      $	��50* �6   	 � ColumnDefinitions	 5$   
   �� 5%      $	��10* �6   �� 5&      $	��82* �6   �� 5'      $
��163* �6   �� 5(      $	��10* �6   .+�5+   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 Desgrid��5+   �   $��4��6      CanUserSortColumns .    AutoGenerateColumns .     CanUserResizeRows .  $��1��6r   $��2��6�   #��� ��6�   
���   �   VerticalGridLinesBrush �	#FFD6D6D6   AlternatingRowBackground �	#FFEAEAEA   HorizontalGridLinesBrush �	#FFD6D6D6   GridLinesVisibility$	 All=�6p     CanUserReorderColumns .     CanUserResizeColumns .    MinColumnWidth$ 16Q�6�     RowBackground �	#FFF2F2F2   	RowHeight$ 50Q�6�     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 350 6     ColumnHeaderHeight$ 30Q�6     Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Applications��6%      Width$
 150* 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Applications+   ElementStyle 5/      �� 50       �� 
TargetType" ��6    .�51      ��  �� Property � ��  �� Value$
  Wrap=�6=   �� 52       � ��$  Center=�6D   �� 53       � ��$  Center=�6B   54      !   EditingElementStyle! 56      �� 57      " ��6    .�58      ��  � ��$  Center=�6D   �� 59       � ��$  Center=�6B   �� 5:       � ��
  ��  �6;   �� 5;       � ��  65   �� *Applications+5<      5>        5@      $ Status��6%   $
 150* 6P    65   �� *Status+ 5A      �� 5B      " ��6    .�5C      ��  � ��$
  Wrap=�6=   �� 5D       � ��$  Center=�6D   �� 5E       � ��$  Center=�6B   5F      ! 5H      �� 5I      " ��6    .�5J      ��  � ��$  Center=�6D   �� 5K       � ��$  Center=�6B   �� 5L       � ��
  ��  �6;   �� 5M       � ��  65   �� *Status+5N      5P      5T      �� 5U   
   -   5        " ��Name$" txtcompleted��5U   i   $��Segoe UI)�6   $��14(�6*   $��2��68   $��1��6E   $��2��6U   5W      5X      5Z      