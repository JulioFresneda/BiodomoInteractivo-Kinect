   M S B A M L   `   `   `  ����   ControlsBasics-WPF:    4Microsoft.Samples.Kinect.ControlsBasics.SliderSample   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .���   � RowDefinitions  �� $
��Auto ��� $��* �.+��� -    ��Name$ 	pageTitle��$��1��$��Sliders��$��	10 0 10 0q�� $��1�� � ColumnDefinitions �� $
��0.5* ��� $
��0.5* �.+�� $��0�� �� $
��0.5* ��� $
��0.5* �  �� $
��Auto ��� $
��0.3* ��� $
��0.3* ��� $��* �.+��� $��0��   HeaderStyle#��[  	Sliders�� $��0��$��2��$��1�� �� Orientation$ 
Horizontal=�$��Stretch=�$��	50 0 50 0q��� $��0��$��2��$��2�� � Value$ 50Q�$ 
Horizontal=� �� IsSnapToTickEnabled .  � Maximum$ 3Q� �� TickPlacement$ BottomRight=� �� TickFrequency$ 1Q�$��Stretch=�$��	50 0 50 0q��� $��0��$��3��$ Vertical=�$��Stretch=�$��100 10 0 10q��� $��1��$��3��$ 50Q�$ Vertical=� . $ 3Q�$ BottomRight=�$ 1Q�$��Stretch=�$��	0 10 0 10q�