   M S B A M L   `   `   `  ����J  FExcellentMeetUp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ExcellentMeetUpExcellentMeetUp  5   	   K*clr-namespace:ExcellentMeetUp.UserControlsExcellentMeetUp.UserControls  5   	        ExcellentMeetUp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ExcellentMeetUp     5   	   =custom*clr-namespace:ExcellentMeetUp.UserControls     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �� .��5   
   � $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      4   .ExcellentMeetUp.UserControls.TextBoxWithHeader  -   5          Name$ 	NameParty��5   /      
TextHeader$ Название��6B   $	��500��6X      	IsTextBox . 6w     5      -   5        $ 	DateParty��5   /   $ Дата��6B   $	��500��6T   6b     5      -   5        $ 
PlaceParty��5   /   $ 
Место��6C   $	��500��6V    . 6u     5      -   5        $ DescriptionParty��5   /   $ Описание��6I   $	��500��6_    . 6   6   0ExcellentMeetUp.UserControls.ImageWithDatePicker  5      -   5          Name$ 
ImageParty��5   1      
TextHeader$ Изображение��6E   6`   �� 5      $��0,15,0,0q�6    $��Программа��62   $��20(�6C   $
��Bold"�6Q   
���OO/�6�   �� 5      $	��250��6#   $��0,15,0,0q�63   .��5      �� -   5        $��ListOfPrograms��5   %   5      5      �� 5      �� 5      -   5        .�5   3   .,Добавить этап программы6L   5      5       5!      �� 5#      $��Right=�6   .+�5$      �� -   5        
����  �
������ $��2q�5$   X   ._�5%      �� $��Отмена��6    $
��Bold"�6.   
����  �$��20,10,20,10q�6R    �� TextAlignment$ Center=�6g   6�   5&      �� 5(      -	   5        
����  �
����  �$��2q�5(   O   $��0,10,0,0q�6c   ._�5)      �� $��Сохранить��6    $
��Bold"�61   
�������$��20,10,20,10q�6V   $ Center=�6k   6�   5*      5+      5-      5.      5/      