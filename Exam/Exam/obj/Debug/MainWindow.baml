   M S B A M L   `   `   `  ����?  ;Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ExamExam  5   	   Y UDe.TorstenMandelkow.MetroChart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart 5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L5clr-namespace:System.Diagnostics;assembly=WindowsBaseSystem.Diagnostics 5   	       Exam.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Exam     5   	   fchartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart     5   	   Fdiag5clr-namespace:System.Diagnostics;assembly=WindowsBase     5   	     � Title$
  MVVM��5
   	   $	��925��6   $
��1050��6'    � WindowStartupLocation$ CenterScreen=�6e    � DataContext 5         Exam.MainWindowViewModel  5   
    � 	Resources 5       �� MergedDictionaries �� Source �� 
TargetType �� Property �� Value�� 5   
    5      �� 5      $ Dictionary.xaml?�6%   %�   '��       �� 5      " ��6   .�5      ��  � ��$ 16(�67   �� 5       � �� �	#FFFFFFFF69   �� 5       � ��$ Center=�6B   �� 5       � ��$ Center=�6@   5      5      .��5      � -   5        	 �Name$	 gdMain��5      
 � RowDefinitions
 5   
   �� 5      $
��Auto �6   �� 5      �� 5      �� 5       $	��120��6    � ColumnDefinitions 5"   
   �� 5#      $	��300��6   $
��Auto �6.   �� 5$      $
��Auto �6   �� 5%      �� 5&      .+�5(   
   �� .+�5)      �� $��Stretch=�6    �� TextAlignment$ Center=�66   $��18(�6M   ���	#FF595959���	#FFFFFFFFFilter6�   ]� 5*      .+�5+      �� $��Right=�6   $��14(�60   $��35��6^   ��6>   ��  �� Path$ Search�.��5,      �� $��Pictures/lupa.png��6   69   5-      �� 5.      $��14(�6   ��6(   �� $ 
SearchUser� �� UpdateSourceTrigger$ 	LostFocus=�5/      �� 50      -   5         ��Name$ cbChoise��50      ��6)   �� $ 
Profession� �� SelectedItem 6Q   �� $ 
SelectProf� �� Mode$ TwoWay=��� 51      $��14(�6   ��6#   �� $ ShowAll�.��6D   
Show All6N   52      �� 53   
   -   5         ��Name$ lbMain��53      $��1��6"   $��3��6/   ��6@   �� $ Users� 6c   �� $ 
SelectUser�$ TwoWay=���54      �� 55      .R�56      ��  �� Orientation$ 
Horizontal=�6!   .+�57      �� ��6    �� $ 	thumbnail��� 58      $ Vertical=�6%   .+�59      �� $��3q�6F   $��14(�6Q   ��6(   �� $ first�6Q   �� 5:      $��3q�6E   $��14(�6P   ��6(   �� $
 last�6P   �� 5;      $��3q�6P   $��14(�6[   ��6(   �� $ workingPosition�6[   5<      5=      5>      5@      �� 5B   
   -   5         ��Name$ spChild��5B      $��1��6&   $��3��66   $ Vertical=�6G   ���	#FF595959 6^   ��  �� ElementName$ lbMain��$ SelectedItem�.+�5C      �� $	��120��62   $	��240��6B   $	��160��6R   $	��300��6a   ��6   �� $ large�6a   �� 5D      $��Center=�64   $��16(�6Q   ���	#FFFFFFFF��6   �� $ first�6_   �� 5E      $��Center=�63   $��16(�6P   ���	#FFFFFFFF��6   �� $
 last�6^   �� 5F      $��Center=�6>   $��16(�6[   ���	#FFFFFFFF��6   �� $ workingPosition�6i   �� 5G      $��Center=�6r   $��16(�6�   ���	#FFFFFFFF��6   �� $
 rank� �� StringFormat$ Rating - {0}��$ PropertyChanged=�6�   9� 5H       9� ExpandDirection$
 Down=�6   $��15(�6.   $��Additional info��6<   .��5I      �� .+�5J      �� $��2q�6X   ��6    �� $ gender�$ Gender - {0}��6X   �� 5K      $��2q�6T   ��6    �� $
 city�$ 
City - {0}��6T   �� 5L      $��2q�6X   ��6    �� $ street�$ Street - {0}��6X   �� 5M      $��2q�6W   ��6    �� $	 zip�$ Zip code - {0}��6W   �� 5N      $��2q�6X   ��6    �� $ salary�$ Salary - {0}��6X   �� 5O      $��2q�6\   ��6    �� $ birthday�$ Birthday - {0}��6\   �� 5P      $��2q�6V   ��6    �� $ email�$ Email - {0}��6V   5Q      5R      5S      �� 5T   
   $��1��6   $��3��6%   $��2��62   ���	#FF595959 6F   �� $ lbMain��$ SelectedItem�.+�5U      &   System.Windows.Controls.DataGrid  $	��120��6   "   VerticalScrollBarVisibility$
 Auto=�6'      AutoGenerateColumns .     RowBackground �	#FF595959
�������$��14(�6�   ��6f   �� *
projects+ 5V      =  7System.Windows.Controls.Primitives.DataGridColumnHeader��%Z   '        �� 5W      "  6   .�5X      ��  � �� �	#FF39393967   5Y      5Z         Columns 5[      0  *System.Windows.Controls.DataGridTextColumn  5\      ,  &System.Windows.Controls.DataGridColumn   Header$ Project Name��6)      MinWidth$	 100Q�6_      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *projectName+    ElementStyle  5]      �� 5^      " ��6$   .�5_   "   ��  � ��$
 Wrap=�6A   6P   5`      5b        5c      $ Customer��6)   $	 100Q�6X   !   MaxWidth$	! 250Q�6g   $
 auto 6v    6;   �� *
customer+  5d      �� 5e      " ��6$   .�5f   "   ��  � ��$
 Wrap=�6A   6P   5g      5i        5j      $ 
Begin date��6)   $ 85Q�6[   $
 auto 6i    6=   �� *	beginDate+6i     5k      $ End date��6)   $ 85Q�6W   $
 auto 6e    6;   �� *	endDate+6e     5l      $ Execution percentage��6)   $ 85Q�6o   $
 auto 6}    6G   �� *executionPercentage+6}   5n      5o      ]� 5q   
   $��3��6   $��3��6!   ��.  .+�5r      �� $	��Top=�6   $��40��6*   $��16(�69   ��6G   �� $ 
NewCommand�.��6k   Change selected user data6�   �� 5s      $	��Top=�6   $��40��6*   $��16(�69   ��6H   �� $ 
DelCommand�.��6m   Delete selected user6�   �� 5t      $��Bottom=�6   $��40��6-   $��16(�6<   ��6J   �� $ ShowWinUser�.��6p   Add new user6~   5u      �� 5w   
   $��2��6   $��2��6%   $��2��66   ���	#FF595959 6J   �� $ lbMain��$ SelectedItem�.+�5x      6  0De.TorstenMandelkow.MetroChart.ClusteredBarChart  .	  (De.TorstenMandelkow.MetroChart.ChartBase" 	  
ChartTitle$#" SuperDeveloperSolutionCompany��6'   # 	  ChartSubTitle$,# &Quality indicators of employee's tasks��6R   $	��450��6�   $	��450��6�   $ 	  MaxDataPointValue$	$ 100Q�6�   % 	  ChartLegendVisibility$% Hidden=�6�   $	��408��6�   & 	  Series& 5z      0
  *De.TorstenMandelkow.MetroChart.ChartSeries
  ' 
  DisplayMember$' Category��6E   ( 
  ValueMember$( Number��6^   ��6(   �� *data+6^   5|      5}      �� 5   
   $��2��6   $��2��6%   $��2��69   ���	#FF595959.+�5�      9  3De.TorstenMandelkow.MetroChart.ClusteredColumnChart  $#" SuperDeveloperSolutionCompany��6)   $# All employee's ranking��6T   $	��300��6{   $	��200��6�   $	��340��6�   & 5�      
  $' Category��6t   $( Number��6�   ��6(   �� *AllFirmRanking+$ PropertyChanged=�6�   5�      5�      5�      5�      