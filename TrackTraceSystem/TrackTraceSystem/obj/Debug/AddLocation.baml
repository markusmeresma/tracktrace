   M S B A M L   `   `   `  ����K  GTrackTraceSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TrackTraceSystemTrackTraceSystem  5   	   "    TrackTraceSystem.AddLocation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TrackTraceSystem     5   	     � Title$  AddLocation��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� $
��Left=�6   $��	26,23,0,0q�6/   $
��Wrap=�6B   $��Add a new location��6V   $	��Top=�6p   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ lblType��5      $��Type (shop, cafe, etc)��6!   $
��Left=�6B   $��	26,84,0,0q�6]   $	��Top=�6p   $��14(�6�   �� 5   
   -   5         ��Name$ txtType��5      $
��Left=�6#   $��23��6>   $��
204,87,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $ 
lblAddress��5      $��Address��6$   $
��Left=�66   $��
26,141,0,0q�6Q   $	��Top=�6e   $��14(�6}   �� 5   
   -   5        $ 
txtAddress��5      $
��Left=�6&   $��22��6A   $��204,141,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��224,189,0,0q�6L   $	��Top=�6a   $��75��6y   6�   �� 5   
   -   5         ��Name$ ListBox��5      $
��Left=�6#   $	��257��6>   $��509,119,0,0q�6K   $	��Top=�6`   $	��241��6x   �� 5   
   $
��Left=�6   $��
509,84,0,0q�6/   $
��Wrap=�6C   $&�� List of saved locations (types):��6W   $	��Top=�6   $��14(�6�   5      5      