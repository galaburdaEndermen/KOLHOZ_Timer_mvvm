   M S B A M L   `   `   `  ���� I  EGAS_timer_mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GAS_timer_mvvmGAS_timer_mvvm      GAS_timer_mvvm.Settings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:GAS_timer_mvvm       � Title$  Settings��$	��450��$	��800��.���  � RowDefinitions �� $
��450* ��� $
��110* � � ColumnDefinitions �� $
��100* ��� $
��650* ��� $
��100* � � 	Resources    Add  Save  Del  Down  Up  
SaveButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value  ControllButtonStyle  SaveText��%  &	        &	 4     &	 i     &	 �     &	 �     &	     &	 �    &	 B    �� $.��(pack://application:,,,/Resourses\Add.png���� $/��)pack://application:,,,/Resourses\Save.png���� .R��� $.��(pack://application:,,,/Resourses\Del.png���� .R��� $/��)pack://application:,,,/Resourses\Down.png���� .R��� $-��'pack://application:,,,/Resourses\Up.png���� " ��.���  � ��
 �������  � ��$ 70����  � ��$ 70����  � ��$ Right=���  � ��$ Bottom=���  � ��$ 5q���  � ��
 �������  �@J�Opacity$	 0.9Q���  � �� �� " ��.R��� $	��Brd��$ 5��#��z��._��� $��5q�$��Center=�$��Center=�	 P� 
 �@J�IsMouseOver .  . ���  �@J�Opacity$	 0.8Q���  � ��$ 8q�P� 
 � �� . . ���  �@J�Opacity$	 1.0Q�P� 
 � {� .  �� " ��.���  � ��
 �������  � ��
 �������  �@J�Opacity$	 0.9Q���  � �� �� " ��.R��� $	��Brd��#��z��._��� $��5q�$��Center=�$��Center=�	 P� 
 �@J�IsMouseOver .  . ���  �@J�Opacity$	 0.8Q�P� 
 � �� . . ���  �@J�Opacity$	 1.0Q�P� 
 � {� .  �� " ��.���  � ��$ 15(���  � ��$ Courier New)���  � ��$
 Bold"���  �@��TextAlignment$ Center=�.+��� $��1��$��0��
�������$��Stretch=����� *Timers+���� " ��.���  � ��
 ���� ��  � �� �� *HorizontalContentAlignment+ �� RelativeSource ��  �� AncestorType" ����  � �� �� *VerticalContentAlignment+ �� " ����  � ��$ 2,0,0,0q���  �@�FocusVisualStyle �� .���  � �� Z� ��  � �� �� " ��.R���  ��Name$ Bd��#��z��#��z��#��z�� �� Padding# z�� J� SnapsToDevicePixels . ._��� #��z��# z #��z��	 P� 
 � {� .  . ��� # � �� � ������ .R���  �� Orientation$ Vertical=����� .R�� $��5q�$��Stretch=�$��Stretch=�$��50�� �� $
��100* ��� $
��100* � �� $	��50* ��� $
��200* ��� $
��200* ��� $	��50* �.+��� $��0��$��0��#��[ #��[ ����  �� *FindAncestor+" � �� AncestorLevel$ 2�� �� Path$ DataContext.MoveUp����� *Name+�� $��0��$��1��#��[ #��[ ����  �� *FindAncestor+" �$ 2��$ DataContext.MoveDown����� *Name+�� $��1��$��0��$��2��#��[ ���� *Name+�� $��2��$��0��$��2��#��[ ���� *Time+�� $��3��$��0��$��2��#��[ #��[ ����  �� *FindAncestor+" �$ 2��$ DataContext.Delete����� *Name+�� $��1��$��1��#��[ $��5q�#��[  ���� *	AddSave+�� $��2��$��1��#��[ $��5q�#��[ ���� *	SaveAll+