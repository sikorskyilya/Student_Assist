   M S B A M L   `   `   `  ����I  EStudent_Assist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Student_Assist.ViewStudent_Assist.View  5   	   ` \De.TorstenMandelkow.MetroChart, Version=0.9.5818.20693, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart 5   	   "    Student_Assist.View.MainMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Student_Assist.View     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   e
MetroChartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart  5   	   -   5          � Title$  MainMenu��5
   	    � 
ResizeMode$ NoResize=�6   $	��640��61   $
��1200��6>    � WindowStyle$
 None=�6l   .��5      � .+�5   
   � $
��Left=�6   $��56��6+   $��0,46,0,0q�66    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 1Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFACACAC��6B   .+�5      �� ���	#FF31577E$��0,0,0,0q�60   .+�5      �� -   5         � ToolTip$ NoteBook��5         ButtonOpacity_0#��[  6?   
�������$��46��6{   $��46��6�   ��5      �� 5       �� Color$ Azure��6*   	 �� Opacity$	 0Q�68   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Notebook=�6.   $��33��6>   $��36��6J   5      �� 5      -   5        $ Progress��5      #��[  6B   
�������$��46��6~   $��46��6�   ��5      �� 5      $ Azure��6*   $	 0Q�68   .��5        $
 ProgressTick=�6.   $��33��6B   $��36��6N   5      �� 5      -   5        $ 	Timetable��5      #��[  6E   
�������$��46��6�   $��46��6�   ��5      �� 5      $ Azure��6*   $	 0Q�68   .��5!        $
 
TableLarge=�6.   $��33��6@   $��36��6L   5"      �� 5#      -   5        $
 Quit��5#   &   #��[  65   
�������$��46��6q   $��46��6|   ��5$      �� 5%      $ Azure��6*   $	 0Q�68   .��5'        $
 CloseBoxOutline=�6.   $��33��6E   $��36��6Q   5(      5)      5*      � 5,   
   ���	#FF5C99D6$	��Top=�6&   $��46��6>   $��0,0,0,0q�6J    5-        5.      $ 1Q�6#   $ 1Q�62   $ 	#FFACACAC��6B   .+�50      �� -   5        $ Account��50   "   $��6,0,0,0q�64   #��[  6E   $��46��6o   $��46��6z   $
��Left=�6�   ��51      �� 52      $ Azure��6&   $	 0Q�64   .��54        $
 AccountCircle=�6*   $��33��6?   $��36��6K   55      �� 56       �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�58      '  !MaterialDesignThemes.Wpf.PopupBox  
�������   PlacementMode$ BottomAndAlignRightEdges=�6=      	StaysOpen .  $��10q�6x      PopupContent. 5:      �� $	��150��6!   .+�5;      �� -   5        $��Logout��5;   !   62   �� 5<      �� 5=      -   5        $��Minimize��5=   !   64   �� 5>      -	   5        $
��Quit��5>   !   60   5?      5@      5A      �� 5B      $��Center=�6   $��Center=�65   
�������$��30(�6c   $	��261��6r   $��0,6,0,0q�6~   Student Assistent6�   5C      � 5D   
   -
   5        $��	MainStack��5D      $��61,51,-0.4,0.4q�6!    � ColumnDefinitions 5E      �� 5F      $��1115* �6#   �� 5G      $	��24* �6#   5I      5J      5L      