   M S B A M L   `   `   `  ����J  FTransparent app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ffffff  5   	        Transparent_app.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:fff     5   	   -   5          �Name$  window��5   	    � Title$ Transparent window��5	   	   $
��1280��5
   	   $	��720��6    J� Opacity$ 1Q�5   	    � AllowsTransparency$
 True��6    � WindowStyle$
 None=�5   	    � Topmost$
 True��6   
������  � Icon$ 	/icon.png��5   "   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   � -   5        	 �Name$	 config��5      $��1��6   $��1��6,   $��2��6<   $��2��6M   ��5      
� 5      
 
� GradientOrigin$
 0.5,0.5&�6&    
� RadiusX$
 0.95Q�6?    
� RadiusY$
 0.95Q�6N   .��5      �  � Color$ Black��6#    � Offset$
 0.25Q�61   � 5       $ 	#FF212121��6#   $ 1Q�65   5!       5#      �� 5$      6"   �� 5%      6"   �� 5&      6"   �� 5'      6"   �� 5(      6"   �� 5)      6"   �� 5*      6"   �� 5+      6"   �� 5,      6"    5.      �� 5/      6%   �� 50      6%   .+�53      �� -   5         ��Name$ inputDeviceName��53   0   $��Some input device��6   $��0��54      $��0��6   $��Center=�55      
�������$��10q�57      �� 58      -   5        $ outputDeviceName��58   1   $��Some output device��6   $��1��59      $��0��6   $��Center=�5:      
�������$��10q�5<      �� 5=      -   5        $ 
volumeName��5=   *   $��Some volume��6   $��2��5>      $��0��6   $��Center=�5?      
�������$��10q�5A      �� 5C      -   5         ��Name$ inputDeviceSlider��5C      $��0��5D      $��1��6   $��10q�5E       � Value$ 0Q�5F       � Minimum$ 0Q�5G       � Maximum$ 10Q�5H      $��Center=�5I       �� TickPlacement$ BottomRight=�5J       �� IsSnapToTickEnabled$
 True��5K      �� 5L      -   5        $ outputDeviceSlider��5L      $��1��5M      $��1��6   $��10q�5N      $ 0Q�5O      $ 0Q�5P      $ 10Q�5Q      $��Center=�5R      $ BottomRight=�5S      $
 True��5T      �� 5U      -   5        $ volumeSlider��5U      $��2��5V      $��1��6   $��10q�5W      $ 50Q�5X      $ 0Q�5Y      $	 100Q�5Z      $��Center=�5[      $ BottomRight=�5\      �� 5^      -	   5         ��Name$ startButton��5^      $��START AUDIO STREAM��6*   $��6��5_      $��2��6   ���	#FF646464
�������
������ $��10q�5a      5b      �� 5c      -
   5        $ 
hideButton��5c      $��	HIDE MENU��6)   $��7��5d      $��2��6   ���	#FF646464
�������
������ $��10q�5f      5g      �� 5h      -   5        $ closeButton��5h      $��	CLOSE APP��6*   $��8��5i      $��2��6   ���	#FF646464
�������
������ $��10q�5k      5l      5m      �� 5n   
   -   5        $ 
showButton��5n      $��4��5o      $��4��6   $
��Left=�5p      $	��Top=�6(   
���  ��
���  ��5q      5r      5s      