   M S B A M L   `   `   `  ����J  FExcellentMeetUp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ExcellentMeetUp.UserControlsExcellentMeetUp.UserControls  5      4    .ExcellentMeetUp.UserControls.TextBoxWithHeader   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:ExcellentMeetUp.UserControls     5      -   5          � 	Resources  5	       �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker��%  '��       '��     '�� >    '  �    �� 5
   
   " ��6   .�5      ��  � ��$
 Bold"�6+   6:   �� 5       � ��$ 5q�6'   63   �� 5       � ��$ 0q�60   6<   �� 5       � ��$
 Left=�6;   6J   �� 5       � ��$ Center=�69   6J   �� 5       � ��
 ���� 6A   5      �� 5   
   " ��6   .�5      ��  � ��
 �OO/�6C   �� 5       � ��$ Center=�62   6C   �� 5       � ��$
 Left=�64   6C   �� 5       � ��$ 10q�6'   64   �� 5       � ��$
 13.5(�6)   68   �� 5       � ��$
 Bold"�6+   6:   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6;   �� 5       � ��$ 1q�60   6<   �� 5       �@��CornerRadius$ 8��6-   69   5      �� 5   
   "  6   .�5       ��  � ��
 ���� 6B   �� 5!       � ��$ 0q�60   6<   �� 5"       � ��
 ���� 6A   �� 5#       � ��$ Center=�69   6J   �� 5$       � ��$ 	0,10,0,10q�6'   6;   5%      5&      .��5'      � -   5        $��MainContainer��5'      
������ $��Center=�69    � RowDefinitions 5(   
   �� 5)      6   �� 5*      6   .+�5,   
   �� -   5        $��Header��5,      $��0��6"   ��6/   �� *
TextHeader+6M   �� 5-   
   -   5        $��Border��5-      $��1��6   ��6,   ��  �� ElementName$ MainContainer�� �� Path$ ActualWidth�._�5.      � .+�5/      �� -   5        $��
InputField��5/      ��6,   �� $ MainContainer��$ ActualWidth�6l     50      -   5        $��DateInputField��50      ��63   �� $ MainContainer��$ ActualWidth�6s   51      52      53      54      