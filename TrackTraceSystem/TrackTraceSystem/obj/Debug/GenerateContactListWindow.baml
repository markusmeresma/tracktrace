   M S B A M L   `   `   `  ����K  GTrackTraceSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TrackTraceSystemTrackTraceSystem  5   	   0    *TrackTraceSystem.GenerateContactListWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TrackTraceSystem     5   	     � Title$  GenerateContactListWindow��5   	   $	��450��6+   $	��800��68   .��5	      � .+�5
   
   �� $
��Left=�6   $��	27,21,0,0q�6/   $
��Wrap=�6B   $��Generate list of contacts��6V   $	��Top=�6w   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ lblSpecifiedIndividual��5      $+��%Select individual from the list below��60   $
��Left=�6`   $��	27,80,0,0q�6{   $	��Top=�6�   $��14(�6�   �� 5   
   -   5         ��Name$ txtSpecifiedIndividual��5      $
��Left=�62   $��22��6M   $��
44,114,0,0q�6Y    �� TextWrapping$
 Wrap=�6m   $	��Top=�6�   $	��201��6�    �� 
IsReadOnly . 6�   �� 5   
   -   5         ��Name$  specifiedIndividualListBox��5      $
��Left=�66   $	��231��6Q   $��
44,160,0,0q�6^   $	��Top=�6r   $	��201��6�   6�   �� 5   
   -   5        $ lblDate��5      $��Insert date dd/mm/yyyy
��6!   $
��Left=�6G   $��
280,78,0,0q�6b   $	��Top=�6v   $��14(�6�   $��30��6�   �� 5   
   -   5        $ txtDate��5      $
��Left=�6#   $��23��6>   $��299,114,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ lblTime��5      $(��"Insert time HH:MM (24-hour format)��6!   $
��Left=�6N   $��280,160,0,0q�6i   $	��Top=�6~   $��14(�6�   �� 5   
   -   5        $ txtTime��5      $
��Left=�6#   $��22��6>   $��299,194,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ listOfContactsListBox��5      $
��Left=�61   $	��311��6L   $��
537,80,0,0q�6Y   $	��Top=�6m   $	��232��6�   �� 5   
   -	   5         ��Name$ lblListOfContacts��5      $
��Left=�6/   $��
500,56,0,0q�6J   $
��Wrap=�6^   $	��Top=�6r   $	��285��6�   $��14(�6�   �� 6�   $5�/List of contacts after specified date and time:��6�   6�   �� 5   
   -
   5         ��Name$ btnGenerate��5      $��Generate��6&   $
��Left=�69   $��299,244,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5      5      