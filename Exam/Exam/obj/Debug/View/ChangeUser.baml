   M S B A M L   `   `   `  ����?  ;Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Exam.View	Exam.View  5   	   clr-namespace:ExamExam  5   	       Exam.View.ChangeUser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Exam.View     5   	   "appclr-namespace:Exam     5   	     � Title$  AddUser��5	   	   $	��600��6   $	��700��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � DataContext 5
         Exam.MainWindowViewModel  5   
   6$    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� �    �� 5   
   " ��6   .�5      ��  � ��$ 16(�63   �� 5       � �� �	#FFFFFFFF65   �� 5       � ��$ Center=�6>   �� 5       � ��$ Center=�6<   5      �� 5   
   " ��6   .�5      ��  � �� �	#FFFFFFFF63   �� 5       � ��$ 16(�61   �� 5       � �� �	#FF59595963   �� 5       � ��$ Center=�6:   �� 5       �@��TextAlignment$ Center=�66   5      �� 5   
   " ��6   .�5      ��  � �� �	#FF5959596+   �� 5       � �� �	#FFFFFFFF6+   �� 5       � �� �	#FF3333336,   5      5       .��5!      � ���	#FF393939 � ColumnDefinitions 5"   
   �� 5#      �� 5$      .+�5&   
   �� 	 �� Orientation$	 Vertical=�6   .+�5'      �� 
First name6$   �� 5(      ��6   �� 
 �� Path$
 TestUser.first� �� UpdateSourceTrigger$ PropertyChanged=��� 5)      	Last name6#   �� 5*      ��6   �� $
 TestUser.last�$ PropertyChanged=��� 5+      Gender6    �� 5,      ��6   �� $
 TestUser.gender�$ PropertyChanged=��� 5-      City6   �� 5.      ��6   �� $
 TestUser.city�$ PropertyChanged=��� 5/      Street6    �� 50      ��6   �� $
 TestUser.street�$ PropertyChanged=��� 51      
Zip code6"   �� 52      ��6   �� $
 TestUser.zip�$ PropertyChanged=��� 53      Email6   �� 54      ��6   �� $
 TestUser.email�$ PropertyChanged=��� 55      
Birthday6"   �� 56      ��6   �� $
 TestUser.birthday�$ PropertyChanged=��� 57      Working position6*   �� 58      ��6   �� $
 TestUser.workingPosition�$ PropertyChanged=��� 59      Salary6    �� 5:      ��6   �� $
 TestUser.salary�$ PropertyChanged=�5;      ]� 5<   
   $��1��6   ��. .+�5=      �� $	��Top=�6   .+�5>      �� Effectiveness Of Teamwork67   �� 5?       � ToolTip$ Number between 0 and 100��6d   ��6   �� $
 TestUser.item1�$ PropertyChanged=�6d   �� 5@      ,*Percentage Successfully Completed Projects6H   �� 5A      $ Number between 0 and 100��6d   ��6   �� $
 TestUser.item2�$ PropertyChanged=�6d   �� 5B      +)Effectiveness Leadership Development Team6G   �� 5C      $ Number between 0 and 100��6d   ��6   �� $
 TestUser.item3�$ PropertyChanged=�6d   �� 5D      #!Rating Positive Customer Feedback6?   �� 5E      $ Number between 0 and 100��6d   ��6   �� $
 TestUser.item4�$ PropertyChanged=�6d   �� 5F      Rating Colleagues Reviews67   �� 5G      $ Number between 0 and 100��6d   ��6   �� $
 TestUser.item5�$ PropertyChanged=�6d   �� 5H      $��18(�6   ��6'   �� $
 AddPhoto�.��6I   Change photo6W   5I      �� 5J      $��Bottom=�6   $	 
Horizontal=�61   .+�5K      �� $	��175��6   $��18(�6%   ��63   �� $
 
ChangeData�.��6W   Change6_   �� 5L      $	��175��6   $��18(�6%    �� IsCancel . .��6C   Cancel6K   5M      �� 5N      ��6   �� $
 TestUser.large�$ PropertyChanged=�5O      5P      5Q      