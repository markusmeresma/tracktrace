   M S B A M L   `   `   `  ����K  GTrackTraceSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TrackTraceSystemTrackTraceSystem  5   	   (    "TrackTraceSystem.RecordVisitWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TrackTraceSystem     5   	     � Title$  RecordVisitWindow��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   �� $
��Left=�6   $��	29,21,0,0q�6/   $
��Wrap=�6B   $ ��Record visit to a location��6V   $	��Top=�6x   $��18��6�   $	��191��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5         ��Name$ lblSelectIndividual��5      $.��(Select an individual from the list below��6-   $
��Left=�6`   $��	29,72,0,0q�6{   $	��Top=�6�   $��14(�6�   �� 5   
   -   5         ��Name$ txtVisitIndividual��5      $
��Left=�6.   $��22��6I   $��
39,116,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��165��6�    �� 
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ individualListBox��5      $
��Left=�6-   $	��223��6H   $��
39,166,0,0q�6U   $	��Top=�6i   $	��166��6�   6�   �� 5   
   -   5        $ lblSelectLocation��5      $+��%Select a location from the list below��6+   $
��Left=�6[   $��
307,72,0,0q�6v   $	��Top=�6�   $��14(�6�   �� 5   
   -   5        $ txtVisitLocation��5      $
��Left=�6,   $��23��6G   $��318,115,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�    . 6�   �� 5   
   -   5        $ locationListBox��5      $
��Left=�6+   $	��223��6F   $��318,166,0,0q�6S   $	��Top=�6h   $	��154��6�   6�   �� 5   
   -   5         ��Name$ lblDate��5      $
��Left=�6%   $��
584,77,0,0q�6@   $
��Wrap=�6T   $��Insert date dd/mm/yyyy��6h   $	��Top=�6�   $��14(�6�   �� 5   
   -   5        $ txtDate��5      $
��Left=�6#   $��23��6>   $��595,115,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -	   5        $ txtTime��5      $
��Left=�6#   $��22��6>   $��595,200,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -
   5        $ lblTime��5      $(��"Insert time HH:MM (24-hour format)��6!   $
��Left=�6N   $��542,156,0,0q�6i   $	��Top=�6~   $��14(�6�   $	��243��6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��681,374,0,0q�6L   $	��Top=�6a   $��75��6y   6�   5      5      