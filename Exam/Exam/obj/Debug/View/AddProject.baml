   M S B A M L   `   `   `  ����?  ;Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Exam.View	Exam.View  5   	       Exam.View.AddProject   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Exam.View     5   	     � Title$  
AddProject��5   	   $	��330��6   $	��300��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� �    �� 5
   
   " ��6   .�5      ��  � ��$ 16(�63   �� 5       � �� �	#FFFFFFFF65   �� 5       � ��$ Center=�6>   �� 5       � ��$ Center=�6<   5      �� 5   
   " ��6   .�5      ��  � �� �	#FFFFFFFF63   �� 5       � ��$ 16(�61   �� 5       � �� �	#FF59595963   �� 5       � ��$ Center=�6:   �� 5       �@��TextAlignment$ Center=�66   5      �� 5   
   " ��6   .�5      ��  � �� �	#FF5959596+   �� 5       � �� �	#FFFFFFFF6+   �� 5       � �� �	#FF3333336,   5      5      .��5      �� ���	#FF393939.+�5   
   �� Project Name6"   �� 5   
   ��6   ��  �� Path$' !SelectUser.newProject.projectName� �� UpdateSourceTrigger$ PropertyChanged=�6q   �� 5    
   
Customer6   �� 5!   
   ��6   �� $$ SelectUser.newProject.customer�$ PropertyChanged=�6n   �� 5"   
   
Begin Date6    �� 5#   
   ��6   �� $% SelectUser.newProject.beginDate�$ PropertyChanged=�6o   �� 5$   
   
End Date6   �� 5%   
   ��6   �� $# SelectUser.newProject.endDate�$ PropertyChanged=�6m   �� 5&   
   Execution Percentage6*   �� 5'   
   	 � ToolTip$	 Number between 0 and 100��6w   ��6   �� $/ )SelectUser.newProject.executionPercentage�$ PropertyChanged=�6�   �� 5(   
   $��15(�6   ��6   �� $ 
AddProject�.��6C   Ok6G   �� 5)   
   $��15(�6   
 �� IsCancel
 . .��6/   Cancel67   5*      5+      