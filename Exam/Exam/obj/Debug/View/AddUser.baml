   M S B A M L   `   `   `  ����?  ;Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Exam.View	Exam.View  5   	       Exam.View.AddUser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Exam.View     5   	     � Title$  AddUser��5   	   $	��600��6   $	��700��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� �    �� 5
   
   " ��6   .�5      ��  � ��$ 16(�63   �� 5       � �� �	#FFFFFFFF65   �� 5       � ��$ Center=�6>   �� 5       � ��$ Center=�6<   5      �� 5   
   " ��6   .�5      ��  � �� �	#FFFFFFFF63   �� 5       � ��$ 16(�61   �� 5       � �� �	#FF59595963   �� 5       � ��$ Center=�6:   �� 5       �@��TextAlignment$ Center=�66   5      �� 5   
   " ��6   .�5      ��  � �� �	#FF5959596+   �� 5       � �� �	#FFFFFFFF6+   �� 5       � �� �	#FF3333336,   5      5      .��5      � ���	#FF393939 � ColumnDefinitions 5   
   �� 5      �� 5       .+�5"   
   ��  �� Orientation$ Vertical=�6   .+�5#      �� 
First name6$   �� 5$      ��6   �� 	 �� Path$	 NewUser.first�
 �� UpdateSourceTrigger$
 PropertyChanged=��� 5%      	Last name6#   �� 5&      ��6   �� $	 NewUser.last�$
 PropertyChanged=��� 5'      Gender6    �� 5(      ��6   �� $	 NewUser.gender�$
 PropertyChanged=��� 5)      City6   �� 5*      ��6   �� $	 NewUser.city�$
 PropertyChanged=��� 5+      Street6    �� 5,      ��6   �� $	 NewUser.street�$
 PropertyChanged=��� 5-      
Zip code6"   �� 5.      ��6   �� $	 NewUser.zip�$
 PropertyChanged=��� 5/      Email6   �� 50      ��6   �� $	 NewUser.email�$
 PropertyChanged=��� 51      
Birthday6"   �� 52      ��6   �� $	 NewUser.birthday�$
 PropertyChanged=��� 53      Working position6*   �� 54      ��6   �� $	 NewUser.workingPosition�$
 PropertyChanged=��� 55      Salary6    �� 56      ��6   �� $	 NewUser.salary�$
 PropertyChanged=�57      ]� 58   
   $��1��6   ��. .+�59      �� $	��Top=�6   .+�5:      �� Effectiveness Of Teamwork67   �� 5;       � ToolTip$ Number between 0 and 100��6c   ��6   �� $	 NewUser.item1�$
 PropertyChanged=�6c   �� 5<      ,*Percentage Successfully Completed Projects6H   �� 5=      $ Number between 0 and 100��6c   ��6   �� $	 NewUser.item2�$
 PropertyChanged=�6c   �� 5>      +)Effectiveness Leadership Development Team6G   �� 5?      $ Number between 0 and 100��6c   ��6   �� $	 NewUser.item3�$
 PropertyChanged=�6c   �� 5@      #!Rating Positive Customer Feedback6?   �� 5A      $ Number between 0 and 100��6c   ��6   �� $	 NewUser.item4�$
 PropertyChanged=�6c   �� 5B      Rating Colleagues Reviews67   �� 5C      $ Number between 0 and 100��6c   ��6   �� $	 NewUser.item5�$
 PropertyChanged=�6c   �� 5D      $��18(�6   ��6'   �� $	 AddPhoto�.��6I   	Add photo6T   5E      �� 5F      $��Bottom=�6   $ 
Horizontal=�61   .+�5G      �� $	��175��6   $��18(�6%   ��63   �� $	 AddUser�.��6T   Add6Y   �� 5H      $	��175��6   $��18(�6%    �� IsCancel . .��6C   Cancel6K   5I      �� 5J      ��6   �� $	 NewUser.large�$
 PropertyChanged=�5K      5L      5M      