   M S B A M L   `   `   `  ���� I  EGAS_timer_mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GAS_timer_mvvmGAS_timer_mvvm      GAS_timer_mvvm.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:GAS_timer_mvvm       � Title$  	GAS_Timer��$	��350��$	��650��.���  � 	Resources    Cog 	 Stats  	SplitBrsh �� Color  StandartTextBlockStyle �� 
TargetType �� Property �� Value  StandartButtonStyle �� 
TargetType �� CornerRadius �� Triggers	 P� Property
 P� Value  ControllButtonStyle��%�  &	        &	 4     &	 j     &	 }     &	 �     &	 f    �� $.��(pack://application:,,,/Resourses\Cog.png���� $0��*pack://application:,,,/Resourses\Stats.png���� $ #009B77���� " ��.���  � ��$ Center=���  � ��$ Center=���  � ��$ 50(��� " ��.���  � ��$ 6q���  � ��$ 30(���  � ��
 �������  �@J�Opacity$	 0.9Q���  � ��
 �   ���  � �� �� " ��.R��� $	��Brd��$ 5��#��z��._��� $��5q�$��Center=�$��Center=� P� 	 �@J�IsMouseOver
 .  . ���  �@J�Opacity$	 0.8Q���  � ��$ 8q�P� 	 � ��
 . . ���  �@J�Opacity$	 1.0Q�P� 	 � {�
 .  �� " ��.���  � ��
 �������  � ��$ 0 6 0 6q���  �@J�Opacity$	 0.9Q���  � �� �� " ��.R��� $	��Brd��$ 5��#��z��._��� $��5q�$��Center=�$��Center=� P� 	 �@J�IsMouseOver
 .  . ���  �@J�Opacity$	 0.8Q�P� 	 � ��
 . . ���  �@J�Opacity$	 1.0Q� � ColumnDefinitions �� $��55 ��� $��7 ��� .+��� $��0��.+��� $��45��$��45��#��[ $��0��#��[ ���� *Stats_start+�� $��45��$��45��#��[ $��1��#��[  ���� *Settings_starts+�� $��1��
��������� $��5q�$��Stretch=�$��Stretch=�$��2��
����������� *Timers+���� " ��.���  � ��
 ���� ��  � �� �� *HorizontalContentAlignment+ �� RelativeSource ��  �� AncestorType" ����  � �� �� *VerticalContentAlignment+ �� " ����  � ��$ 2,0,0,0q���  �@�FocusVisualStyle �� .���  � �� Z� ��  � �� �� " ��.R���  ��Name$ Bd��#��z��#��z��#��z�� �� Padding# z�� J� SnapsToDevicePixels . ._��� #��z��# z #��z�� P� 	 � {�
 .  . ��� # � �� � ������ .R���  �� Orientation$ 
Horizontal=����� .R�� $��5q�$��Stretch=�$��Stretch=�$	��200�� � RowDefinitions �� $
��170* ��� $
��100* �.+��� $��0��#��[ ���� *Time+�� $��1��#��[ $��Stretch=�$��Stretch=����� *Name+���� *CurrentColor+���� *ChangeState+