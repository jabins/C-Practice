   M S B A M L   `   `   `  ����b  ^Jason-Choi_Simple_Dental_Payment_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Jason_Choi_Simple_Dental_Payment_System'Jason_Choi_Simple_Dental_Payment_System  5   	   8    2Jason_Choi_Simple_Dental_Payment_System.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Jason_Choi_Simple_Dental_Payment_System     5   	     � Title$  
MainWindow��5   	   $	��400��5	   	   $	��800��5
   	   .��5      � .+�5   
   �� $��Dental Payment System��6   $��20(�5      $
��Bold"�5      $
��Left=�5      $��
285,27,0,0q�5      $	��Top=�5       J� RenderTransformOrigin$ 
0.524,0.19&�5      �� 5   
   $��Name of Patient:��6   $��15(�5      $
��Bold"�5      $
��Left=�5      $��	49,88,0,0q�5      $	��Top=�5      �� 5   
   $��Address:��6   $��15(�5      $
��Bold"�5      $
��Left=�5      $��108,133,0,0q�5      $	��Top=�5      $ 	0.49,0.02&�5      �� 5    
   -   5         ��Name$ txtName��5       $
��Left=�5!      $��23��5"      $��
183,95,0,0q�5#       �� TextWrapping$
 Wrap=�5$      $	��Top=�5%      $	��243��5&      �� 5'   
   -   5        $ 
txtAddress��5'      $
��Left=�5(      $��23��5)      $��183,140,0,0q�5*      $
 Wrap=�5+      $	��Top=�5,      $	��243��5-      �� 5.   
   -   5         ��Name$ comboBoxProvince��5.      $
��Left=�5/      $��183,187,0,0q�50      $	��Top=�51      $	��120��52      .@�54      �� $��Alberta��6   �� 55      $��Ontario��6   �� 56      $��Quebec��6   57      �� 58   
   $��	Province:��6   $��15(�59      $
��Bold"�5:      $
��Left=�5;      $��103,179,0,0q�5<      $	��Top=�5=      �� 5>   
   -   5         ��Name$ listBoxAgeCategory��5>      $��71��5?      $��183,236,0,0q�5@      $	��Top=�5A      $	��147��5B      $
��Auto=�5C      $
��Left=�5D      .+�5E      	� -   5         	�Name$ radioSenior��5E      $��Senior��5F      $��16(�5G      $��Berlin Sans FB)�5H      	� 5I      -   5        $ radioKidsYouth��5I      $��Kids and Youth��5J      $��16(�5K      $��Berlin Sans FB)�5L      	� 5M      -   5        $ 
radioAdult��5M      $��Adult��5N      $��16(�5O      $��Berlin Sans FB)�5P      5Q      �� 5R   
   $��Age Category:��6   $��15(�5S      $
��Bold"�5T      $
��Left=�5U      $��
67,231,0,0q�5V      $	��Top=�5W      �� 5X   
   $��Dental Services Available��6   $��15(�5Y      $
��Bold"�5Z      $��Italic$�5[      $
��Left=�5\      $��
494,88,0,0q�5]      $	��Top=�5^      �� 5_   
   $
��Left=�6   $��73��5`      $��494,123,0,0q�5a      $	��Top=�5b      $	��189��5c      .+�5d      �� -   5         ��Name$ checkBoxFlossing��5d      $��Flossing - $20��5e      $��16(�5f      $��Berlin Sans FB)�5g      �� 5h      -	   5        $ checkBoxFilling��5h      $��Filling - $75��5i      $��16(�5j      $��Berlin Sans FB)�5k      �� 5l      -
   5        $ checkBoxRootCanal��5l      $��Root Canal - $150��5m      $��16(�5n      $��Berlin Sans FB)�5o      5p      �� 5q   
   -   5        $��	Calculate��5q      $��20(�5r      $
��Bold"�5s      ���	#FF27F3B3$
��Left=�5u      $��554,231,0,0q�5v      $	��Top=�5w      $	��129��5x      $��41��5y      
���   �$��Bodoni MT Black)�5{      5|      5}      5~      