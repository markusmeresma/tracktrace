   M S B A M L   `   `   `  ����K  GTrackTraceSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TrackTraceSystemTrackTraceSystem  5   	   1    +TrackTraceSystem.GenerateVisitorsListWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TrackTraceSystem     5   	     � Title$   GenerateVisitorsListWindow��5   	   $	��450��6,   $	��800��69   .��5	      � .+�5
   
   �� $
��Left=�6   $��	29,27,0,0q�6/   $
��Wrap=�6B   $��Generate List of Visitors��6V   $	��Top=�6w   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5         ��Name$ lblSpecifiedLocation��5      $��Select location��6.   $
��Left=�6H   $��	29,84,0,0q�6c   $	��Top=�6v   $��14(�6�   �� 5   
   -   5         ��Name$ txtSpecifiedLocation��5      $
��Left=�60   $��22��6K   $��
29,118,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��156��6�    �� 
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ specifiedLocationListBox��5      $
��Left=�64   $	��223��6O   $��
29,156,0,0q�6\   $	��Top=�6p   $	��156��6�   6�   �� 5   
   -   5         ��Name$ lblStartDate��5      $
��Left=�6*   $��
225,89,0,0q�6E   $
��Wrap=�6Y   $	��Top=�6m   $��21��6�   $��14(�6�   �� 6�   $"�Insert start date dd/mm/yyyy��6�   �� 6�   �� 6�   6�   �� 5   
   $�� ��6   $
��Left=�6   $��307,272,0,0q�66   $	��Top=�6K   �� 5   
   -   5        $ lblStartTime��5      $(��"Insert time HH:MM (24-hour format)��6&   $
��Left=�6S   $��216,156,0,0q�6n   $	��Top=�6�   $��14(�6�   �� 5   
   -   5        $ txtStartDate��5      $
��Left=�6(   $��23��6C   $��225,118,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ txtStartTime��5      $
��Left=�6(   $��22��6C   $��225,190,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ 
lblEndDate��5      $$��Insert end date dd/mm/yyyy

��6$   $
��Left=�6]   $��216,229,0,0q�6x   $	��Top=�6�   $��28��6�   $��14(�6�   �� 5   
   -	   5        $ 
txtEndDate��5      $
��Left=�6&   $��23��6A   $��225,262,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -
   5        $ 
lblEndTime��5      $0��*Insert another time HH:MM (24-hour format)��6$   $
��Left=�6Y   $��216,303,0,0q�6t   $	��Top=�6�   $��14(�6�   �� 5   
   -   5        $ 
txtEndTime��5      $
��Left=�6&   $��24��6A   $��225,336,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ listOfVisitorsListBox��5      $
��Left=�61   $	��271��6L   $��
543,89,0,0q�6Y   $	��Top=�6m   $	��200��6�   �� 5   
   -   5         ��Name$ btnGenerate��5      $��Generate��6&   $
��Left=�69   $��225,383,0,0q�6T   $	��Top=�6i   $��75��6�   6�   �� 5   
   $
��Left=�6   $��
543,66,0,0q�6/   $
��Wrap=�6C   $��List of Visitors:��6W   $	��Top=�6p   $��14(�6�   5      5      