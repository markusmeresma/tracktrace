   M S B A M L   `   `   `  ����K  GTrackTraceSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TrackTraceSystemTrackTraceSystem  5   	   *    $TrackTraceSystem.RecordContactWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TrackTraceSystem     5   	     � Title$  RecordContactWindow��5   	   $	��450��6%   $	��800��62   .��5	      � .+�5
   
   �� $
��Left=�6   $��	23,21,0,0q�6/   $
��Wrap=�6B   $��Record contact��6V   $	��Top=�6l   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtContactIndividual1��5      $
��Left=�61   $��23��6L   $��
51,129,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��171��6�    �� 
IsReadOnly . 6�   �� 5   
   -   5        $ txtContactIndividual2��5      $
��Left=�61   $��23��6L   $��312,129,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $	��171��6�    . 6�   �� 5   
   -   5         ��Name$ lblContactIndividual1��5      $$��Select one individual involved��6/   $
��Left=�6X   $��	40,81,0,0q�6s   $	��Top=�6�   $��14(�6�   �� 5   
   $&�� Select other individual involved��6   $
��Left=�6;   $��
296,81,0,0q�6V   $	��Top=�6j   $��14(�6�   �� 5   
   -   5         ��Name$ contactIndividual1ListBox��5      $
��Left=�65   $	��207��6P   $��
51,177,0,0q�6]   $	��Top=�6q   $	��171��6�   6�   �� 5   
   -   5        $ contactIndividual2ListBox��5      $
��Left=�65   $	��207��6P   $��312,177,0,0q�6]   $	��Top=�6r   $	��171��6�   6�   �� 5   
   -   5        $ txtDate��5      $
��Left=�6#   $��23��6>   $��603,129,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ txtTime��5      $
��Left=�6#   $��23��6>   $��603,211,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   $��Insert date dd/mm/yyyy
��6   $
��Left=�6;   $��
580,80,0,0q�6V   $	��Top=�6j   $��14(�6�   $��30��6�   �� 5   
   $(��"Insert time HH:MM (24-hour format)��6   $
��Left=�6=   $��550,177,0,0q�6X   $	��Top=�6m   $��14(�6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��688,369,0,0q�6L   $	��Top=�6a   $��75��6y   6�   5      5      