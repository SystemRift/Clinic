   M S B A M L   `   `   `  ����D  @MedClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MedClinic.WinMedClinic.Win  5   	       MedClinic.Win.RegDesk   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MedClinic.Win     5   	     � Title$  RegDesk��5   	   $	��800��6   $
��1400��6&    � 
ResizeMode$ NoResize=�5	   	    � Topmost .  � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       .+�5#   
   �� ���#2b4748$��2��5$      $��7��6(   �� 5%   
   $��2��6   $	��114��6$   $	��280��61   $	��Top=�5&      $
��Left=�6(   $��M E N U��5'      $��40(�6"   
�������$��Center=�5(       � 5)   
   -   5          �Name$
 Main��5)      $��2��6   $��8��6.   $��7��6B   $	��800��5*      $
��1120��6   $	��Top=�5+      $��Right=�6(     � NavigationUIVisibility$ Hidden=�5,      �� 5/   
   -   5        	 ��Name$	 
DoctorsBtn��5/      $��1��6%   $��2��62   
������ $��0q�50      .��51      �� .+�52      �� $��/Pics/clock-9-64.png��6   $��42��66   $��76��6B   �� 53      $��25(�6   
�������Doctor's schedule6P   54      55      �� 56   
   -   5        $	 
PatientBtn��56      $��2��6%   $��2��62   
������ $��0q�57      $
��Left=�6%   $	��280��6@   $	��114��6L   $	��Top=�6Y   .��58      �� .+�59      �� $��/Pics/list-rich-64.png��6   $��42��68   $��76��6D   �� 5:      $��25(�6   
�������Patient's List6M   5;      5<      �� 5=   
   -   5        $	 
AppointBtn��5=      $��3��6%   $��2��62   
������ $��0q�5>      $	��114��6%   $	��Top=�62   $
��Left=�6J   $	��280��6e   .��5?      �� .+�5@      �� $��/Pics/add-user-64.png��6   $��42��67   $��76��6C   �� 5A      $��25(�6   
�������Appointment6J   5B      5C      �� 5D   
   -   5        $	 ExitBtn��5D      $��6��6"   $��2��6/   
������ $��0q�5E      $	��114��6%   $	��Top=�62   $
��Left=�6J   $	��280��6e   .��5F      �� .+�5G      �� $��/Pics/close-window-64.png��6   $��42��6;   $��76��6G   �� 5H      $��25(�6   
�������Exit programm6L   5I      5J      5K      5M      