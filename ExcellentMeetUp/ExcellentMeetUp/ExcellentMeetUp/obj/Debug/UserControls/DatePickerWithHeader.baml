   M S B A M L   `   `   `  ����J  FExcellentMeetUp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ExcellentMeetUp.UserControlsExcellentMeetUp.UserControls  5      7    1ExcellentMeetUp.UserControls.DatePickerWithHeader   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:ExcellentMeetUp.UserControls     5      X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fGimg=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5        � 	Resources  5
       �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker��%  '��       '��     '�� >    '  �    �� 5   
   " ��6   .�5      ��  � ��$
 Bold"�6+   6:   �� 5       � ��$ 5q�6'   63   �� 5       � ��$ 0q�60   6<   �� 5       � ��$
 Left=�6;   6J   �� 5       � ��$ Center=�69   6J   �� 5       � ��
 ���� 6A   5      �� 5   
   " ��6   .�5      ��  � ��
 �OO/�6C   �� 5       � ��$ Center=�62   6C   �� 5       � ��$
 Left=�64   6C   �� 5       � ��$ 10q�6'   64   �� 5       � ��$
 13.5(�6)   68   �� 5       � ��$
 Bold"�6+   6:   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6;   �� 5       � ��$ 1q�60   6<   �� 5       �@��CornerRadius$ 8��6-   69   5      �� 5    
   "  6   .�5!      ��  � ��
 ���� 6B   �� 5"       � ��$ 0q�60   6<   �� 5#       � ��
 ���� 6A   �� 5$       � ��$ Center=�69   6J   �� 5%       � ��$ 	0,10,0,10q�6'   6;   5&      5'      .��5(      � -   5        $��MainContainer��5(      
������ $��Center=�69   $��Center=�6T   $��8q�6q    � RowDefinitions 5)   
   �� 5*      6   �� 5+      6   .+�5-   
   �� -   5        $��Border��5-      $��1��6   $��Center=�6,   ._�5.      � .+�50      � -   5        $��ClearThisProgram��50   <   $��10q�6   
������ .+�51      !  FontAwesome.Sharp.IconImage  -   5        �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ TrashAlt=�51   $   $	��Top=�64   $��Right=�6L   $��25��6h   $��25��6t   6�   52      � 54      $��10q�6    � ColumnDefinitions 55      �� 56      6-   �� 57      6-   .+�5:      �� $��0��6!   $
��Left=�61   $��8q�6L   .+�5;      �� $��Начало��6$   64   �� 5<      $��1��6!   $	��250��6.   ._�5=      � .+�5>   "   �� -   5        $��Start��5>   *   $	��250��6Q    �� 	MaxLength$ 5��6]   6m   �� 5?   "    �� Orientation$ 
Horizontal=�6-   $��Right=�6F   .+�5@   &   �� $��AM��6,   $
��Bold"�69   $��0,0,5,0q�6K   6^     5A   &   $ Clock=�64   $��Center=�6A   $��Right=�6\   $��25��6x   6�   5B   #   5C      5D      5E      �� 5G      $��1��6!   $
��Left=�61   $��8q�6L   .+�5H      �� $��
Конец��6$   63   �� 5I      $��1��6!   $	��250��6.   ._�5J      � .+�5K   "   �� -   5        $	��End��5K   *   $	��250��6O   $ 5��6[   6k   �� 5L   "   $ 
Horizontal=�6-   $��Right=�6F   .+�5M   &   �� $��AM��6,   $
��Bold"�69   $��0,0,5,0q�6K   6^     5N   &   $ Clock=�64   $��Center=�6A   $��Right=�6\   $��25��6x   6�   5O   #   5P      5Q      5R      5S      5T      5U      5V      5W      