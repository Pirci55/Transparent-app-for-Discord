   M S B A M L   `   `   `  ����   Transparent app     Transparent_app.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  window�� � Title$ Transparent window��$
��1280��$	��720�� J� Opacity$ 1Q� � AllowsTransparency$
 True�� � WindowStyle$
 None=� � Topmost$
 True��
������  � Icon$ 	/icon.png��.���  � ColumnDefinitions �� �� �� ��  � RowDefinitions �� �� �� �� .+�� -   	 �Name$	 config��$��1��$��1��$��2��$��2����
� 
 
� GradientOrigin$
 0.5,0.5&� 
� RadiusX$
 0.95Q� 
� RadiusY$
 0.95Q�.���  � Color$ Black�� � Offset$
 0.25Q�� $ 	#FF212121��$ 1Q� �� �� �� �� �� �� �� �� �� �� ��  �� �� .+��� -    ��Name$ inputDeviceName��$��Some input device��$��0��$��0��$��Center=�
�������$��10q��� -   $ outputDeviceName��$��Some output device��$��1��$��0��$��Center=�
�������$��10q��� -   $ 
volumeName��$��Some volume��$��2��$��0��$��Center=�
�������$��10q��� $��
X position��$��3��$��0��$��Center=�
�������$��10q��� $��
Y position��$��4��$��0��$��Center=�
�������$��10q��� $��Width��$��5��$��0��$��Center=�
�������$��10q��� $��Height��$��6��$��0��$��Center=�
�������$��10q��� -    ��Name$ inputDeviceSlider��$��0��$��1��$��10q� � Value$ 0Q� � Minimum$ 0Q� � Maximum$ 10Q�$��Center=� �� TickPlacement$ BottomRight=� �� IsSnapToTickEnabled$
 True���� -   $ outputDeviceSlider��$��1��$��1��$��10q�$ 0Q�$ 0Q�$ 10Q�$��Center=�$ BottomRight=�$
 True���� -   $ volumeSlider��$��2��$��1��$��10q�$ 75Q�$ 0Q�$	 100Q�$��Center=�$ BottomRight=��� -	    ��Name$ xPosBox��$��3��$��1��$
��auto��$��Center=�
�������
������ 
������ $��10q��� -
   $ yPosBox��$��4��$��1��$
��auto��$��Center=�
�������
������ 
������ $��10q��� -   $ widthBox��$��5��$��1��$
��auto��$��Center=�
�������
������ 
������ $��10q��� -   $ 	heigthBox��$��6��$��1��$
��auto��$��Center=�
�������
������ 
������ $��10q��� -    ��Name$ startButton��$��START AUDIO STREAM��$��8��$��2�����	#FF646464
�������
������ $��10q��� -   $ 
hideButton��$��	HIDE MENU��$��9��$��2�����	#FF646464
�������
������ $��10q��� -   $ closeButton��$��	CLOSE APP��$��10��$��2�����	#FF646464
�������
������ $��10q��� -   $ 
showButton��$��4��$��4��$
��Left=�$	��Top=�
���  ��
���  ��