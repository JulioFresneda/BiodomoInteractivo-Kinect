   M S B A M L   `   `   `  ����   ControlsBasics-WPF>    8Microsoft.Samples.Kinect.ControlsBasics.SelectionDisplay   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     
������ $��Segoe UI)�$��30(�|�.   � 	Resources     OnLoadedStoryboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value R� KeyTime  System.Windows.Visibility   Hidden R� Value��%	  &	        �� -   .��U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$
 grid��.\�  $ 0��$	 0.1Q�  $ 0:0:0.2��$ 1Q�  $ 0:0:2.2��$ 1Q�  $ 0:0:2.4��$	 0.1Q�U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$
 grid��.\�  $ 0��$	 0.1Q�  $ 0:0:0.2��$ 1Q�  $ 0:0:2.2��$ 1Q�  $ 0:0:2.4��$	 0.1Q�T� $ (UIElement.Visibility)�$
 grid��..�i� $ 0:0:2.4��# Z  � Triggers :� 	 :� RoutedEvent$	 FrameworkElement.Loaded��.[��� -   
 ��Name$(
 "OnLoadedStoryboard_BeginStoryboard��#��[  .��� -    �Name$ 
layoutRoot��.+�� -   $
 grid��  	BlueBrush#��[  J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� .+��� -    ��Name$ messageTextBlock��
�������$��Center=�$��Center=�You selected item #14