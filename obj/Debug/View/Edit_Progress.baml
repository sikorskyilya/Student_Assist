   M S B A M L   `   `   `  ����I  EStudent_Assist, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Student_Assist.ViewStudent_Assist.View  5   	   '    !Student_Assist.View.Edit_Progress   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Student_Assist.View     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � WindowStartupLocation$  CenterScreen=�5       � Title$ Edit_Progress��5   	   $��307.2��5	   	   $��304.5��6    � 
ResizeMode$ NoResize=�6G    � WindowStyle$
 None=�6]   .��5
      � ���	#FF31577E.+�5   
   �� -   5           ButtonOpacity_0#��[  5      $
��Left=�6G   $��270,0,-0.2,0q�6b   $	��Top=�6x   $��35��6�   $��24��6�   ��5      �� 5       �� Color$ Azure��6"    �� Opacity$	 0.4Q�60   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6&   5      �� 5   
   $��10,22,-0.2,258.2q�6   !Введите имя поля:6A   �� 5   
   -   5        $��OldName��5   +   $��10,49,9.8,236.2q�6   6<   �� 5   
   $��10,76,-0.2,204.2q�6   TRВведите значения на которые хотите заменить:6\   �� 5   
   -   5        $��NewName��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Новое имя��6!   $��10,103,9.8,178.2q�6L   �� 5   
   -   5        $��PR_SS��5   '   
�������$ 
Сдано��64   $��72��6[    & "MaterialDesignFloatingHintComboBox#��[ 6j   $��45��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��10,134,222.8,128.2q�6�   ��5      �� 5      .R�5      $� 5      5      �� 5   
   -   5        $��PR_VV��5   &   
�������$ 
Всего��63   $��72��6Z   $��158,134,74.8,128.2q�6h   #��[ 6�   $��45��6�   ��5      �� 5      .R�5      $� 5       5"      �� 5#   
   -   5        $��84,184,91.8,91.2q�5#      .��6;   Изменить6E   5$      5%      