   M S B A M L   `   `   `  ����@  <demo3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:demo3demo3  5   	       demo3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   $libsclr-namespace:demo3     5   	     � Title$  
MainWindow��5   	    � WindowState$ 	Maximized=�6   
�������.��5      � .+�5   
   �� .@�5      �� $��Button��6   .��5	      � .+�5
      �� $	��Top=�6!   $��Center=�69    �� Orientation$ 
Horizontal=�6V   $��23,230,23,0q�6o   .+�5      �� $��ButtonSuccess��6!   $	��110��69      buttonSuccess#��[  6E   $��0,0,0,10q�6l   �� 5      $��ButtonPrimary��6!   $	��110��69     buttonPrimary#��[ 6E   $��	10,0,0,10q�6l   �� 5      $��
ButtonInfo��6!   $	��110��66     
buttonInfo#��[ 6B   $��	10,0,0,10q�6f   �� 5      $��ButtonDanger��6!   $	��110��68     buttonDanger#��[ 6D   $��	10,0,0,10q�6j   �� 5      $��ButtonWarning��6!   $	��110��69     buttonWarning#��[ 6E   $��	10,0,0,10q�6l   �� 5      $��Button��6!   $	��110��62   $��	10,0,0,10q�6?   5      5      5      �� 5      $��Switch Button��6   .��5      �� $ 
Horizontal=�6   $��Center=�66   $��
23,10,23,0q�6S   .+�5        demo3.SwitchButton    SwitchButtonSuccess#��[ 6(      Disabled . $��	10,0,0,10q�6f     5        SwitchButtonPrimary#��[ 6(    .  $��	10,0,0,10q�6g     5        SwitchButtonInfo#��[ 6)   $��	10,0,0,10q�6S     5        SwitchButtonDanger#��[ 6)    . $��	10,0,0,10q�6e     5       	 SwitchButtonWarning#��[	 6)   $��	10,0,0,10q�6V     5       
 SwitchButtonBasic#��[
 6)   $��	10,0,0,10q�6T   5      5      �� 5      $��Checks��6   .��5       �� $��Center=�6   $��23,200,23,0q�6:   .+�5!      ��   CheckBoxSuccess#��[ 6     �� Left$	 115��6J   
 �� Top$ 46��6\   �� 5"        CheckBoxPrimary#��[ 6    $	 135��6J   $ 46��6\   �� 5#        CheckBoxInfo#��[ 6    $	 155��6G   $ 46��6Y   �� 5$        CheckBoxDanger#��[ 6    $	 175��6I   $ 46��6[   �� 5%        CheckBoxWarning#��[ 6    $	 195��6J   $ 46��6\   �� 5&        CheckBoxBasic#��[ 6    $	 215��6H   $ 46��6Z   5'      5(      �� 5)      $��CheckBox��6   .��5*      �� $��Center=�6   $��23,200,23,0q�6:   $��86��6O   .+�5+      �� $��CheckBox��6   $��0,0,0,5q�62     CheckSuccess#��[ 6C    d� 	IsChecked$
 TrueY�6j   $	 147��6{   $ 29��6�   $��17��6�   �� 5,      $��CheckBox��6   $��0,0,0,5q�62     CheckPrimary#��[ 6C   $
 TrueY�6j   $	 147��6{   $ 29��6�   �� 5-      $��CheckBox��6   $��0,0,0,5q�62     	CheckInfo#��[ 6C   $
 TrueY�6g   $	 147��6x   $ 29��6�   �� 5.      $��CheckBox��6   $��0,0,0,5q�63     CheckDanger#��[ 6D   $
 TrueY�6j   $	 147��6{   $ 29��6�   �� 5/      $��CheckBox��6   $��0,0,0,5q�63     CheckWarning#��[ 6D   $
 TrueY�6k   $	 147��6|   $ 29��6�   �� 50      $��CheckBox��6   $��0,0,0,5q�63   $
 TrueY�6F   $	 147��6W   $ 29��6i   51      52      �� 53      $��Radio Button��6   .��54      � .+�55      �� $ Vertical=�6!   $��300,100,682,350q�68   .+�56      	� $
��Left=�6(   $��0,0,0,10q�6C   $	��Top=�6V   	� 57      $��RadioButton��6&   $
��Left=�6<   $��0,0,0,10q�6W     RadioButtonPrimary#��[ 6i   $	��Top=�6�   	� 58      $��RadioButton��6&   $
��Left=�6<   $��0,0,0,10q�6W     RadioButtonDanger#��[ 6j   $	��Top=�6�   	� 59      $��RadioButton��6&   $
��Left=�6<   $��0,0,0,10q�6W     RadioButtonSuccess#��[ 6j   $	��Top=�6�   	� 5:      $��RadioButton��6&   $
��Left=�6<   $��0,0,0,10q�6W     RadioButtonWarning#��[ 6j   $	��Top=�6�   	� 5;      $��RadioButton��6&   $
��Left=�6<   $��0,0,0,10q�6W     RadioButtonInfo#��[ 6j   $	��Top=�6�   5<      �� 5>      $ Vertical=�6!   $
��Left=�68   $��800,80,282,270q�6T   .+�5?      	�  	� 	GroupName$ stripe��6&     VerticalTabButtonBasic#��[ 69   $
 TrueY�6i   $��0,0,0,10q�6{   $��RadioButton��6�   $
��Left=�6�   $	��Top=�6�   	� 5@      $ stripe��6&     VerticalTabButtonSuccess#��[ 69   $��0,0,0,10q�6l   $��RadioButton��6~   $
��Left=�6�   $	��Top=�6�   	� 5A      $ stripe��6&     VerticalTabButtonInfo#��[ 69   $��0,0,0,10q�6i   $��RadioButton��6{   $
��Left=�6�   $	��Top=�6�   	� 5B      $ stripe��6&     VerticalTabButtonWarning#��[ 69   $��0,0,0,10q�6k   $��RadioButton��6}   $
��Left=�6�   $	��Top=�6�   	� 5C      $ stripe��6&     VerticalTabButtonDanger#��[ 69   $��0,0,0,10q�6j   $��RadioButton��6|   $
��Left=�6�   $	��Top=�6�   	� 5D      $ stripe��6&      VerticalTabButtonPrimary#��[  69   $��0,0,0,10q�6k   $��RadioButton��6}   $
��Left=�6�   $	��Top=�6�   5E      �� 5G      $��40��6!   $ 
Horizontal=�6.   $��350,500,200,50q�6G   .+�5H      	� $ phones��6'   $��0,0,10,0q�6:   $��Samsung��6L   $
 TrueY�6_    ! TabRadioButtonBasic#��[! 6r   	� 5I      $ phones��6'   $��0,0,10,0q�6:   $��Apple��6L    " TabRadioButtonPrimary#��[" 6`   	� 5J      $ phones��6'   $��0,0,10,0q�6:   $��Nokia��6L    # TabRadioButtonInfo#��[# 6`   	� 5K      $ phones��6'   $��0,0,10,0q�6:   $��Firefox��6L    $ TabRadioButtonWarning#��[$ 6_   	� 5L      $ phones��6'   $��0,0,10,0q�6:   $��Firefox��6L    % TabRadioButtonSuccess#��[% 6_   	� 5M      $ phones��6'   $��0,0,10,0q�6:   $��Firefox��6L    & TabRadioButtonDanger#��[& 6_   5N      5O      5P      5Q      5R      5S      