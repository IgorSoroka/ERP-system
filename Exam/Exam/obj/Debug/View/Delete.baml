   M S B A M L   `   `   `  ����?  ;Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Exam.View	Exam.View  5   	   clr-namespace:ExamExam  5   	       Exam.View.Delete   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Exam.View     5   	   "appclr-namespace:Exam     5   	     � Title$  Delete��5	   	   $	��200��6   $	��250��6%    � 
ResizeMode$ NoResize=�61    � WindowStartupLocation$ CenterScreen=�6G    � DataContext 5
         Exam.MainWindowViewModel  5   
   6$    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '�� �     �� 5   
   " ��6   .�5      ��  � �� �	#FFFFFFFF63   �� 5       � ��$ 16(�61   �� 5       � �� �	#FF59595963   �� 5       � ��$ Center=�6:   �� 5       �@��TextAlignment$ Center=�66   5      �� 5   
   " ��6   .�5      ��  � �� �	#FF5959596+   �� 5       � �� �	#FFFFFFFF6+   �� 5       � �� �	#FF3333336,   5      5      .��5      ]� ���	#FF595959.+�5   
   �� $��16(�6   $��Center=�6   ���	#FFFFFFFF$	��Top=�6R   .��6g   Do you want to remove?6   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   $��Center=�6F   .+�5      �� $��95��6   $��30��6    $��16(�6,   ��6:   �� 	 �� Path$	 
DeleteUser�.��6^   Ok6b   �� 5       $��95��6   $��30��6    $��16(�6,   
 �� IsCancel
 . .��6J   Cancel6R   5!      �� 5"   
   $ Vertical=�6   .+�5#      �� $��92��6   $��2q�6#   ��6.   �� $	 SelectUser.first� �� UpdateSourceTrigger$ PropertyChanged=�6|   �� 5$      $��92��6   $��2q�6#   ��6.   �� $	 SelectUser.last�$ PropertyChanged=�6{   5%      5&      5'      