   M S B A M L   `   `   `  ���� \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089d `Microsoft.Kinect.Wpf.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35   LightGrayColor  MediumGrayColor  DarkGrayColor  
WhiteColor  
BlackColor  LightGrayBrush  �� Color  DarkGrayBrush  
WhiteBrush  MediumGrayBrush 	 
BlackBrush4   .System.Windows.Media.Animation.ExponentialEase 
 VisualStateEasingFunction    Exponent  HeaderStyle �� 
TargetType �� Property �� Value / +ListViewItemPlaceholderBackgroundThemeBrush + 'ListViewItemOverlayBackgroundThemeBrush + 'ListViewItemOverlayForegroundThemeBrush 4 0ListViewItemOverlaySecondaryForegroundThemeBrush  KinectTileButton �� 
TargetType ��Name'   !System.Windows.VisualStateManager   VisualStateGroups%   System.Windows.VisualStateGroup   States    System.Windows.VisualState	   
Storyboard
 g� Duration �� 
TargetName �� TargetProperty	 �� To  ButtonTextStyle  SingleButtonStyle   Transitions%   System.Windows.VisualTransition   From   GeneratedDuration   
Storyboard	 W� To W� EasingFunction R� KeyTime R� Value  System.Windows.Visibility	   To   GeneratedEasingFunction ��Name J� Opacity ��Name J� RenderTransformOrigin �Name �� Padding K� ZIndex ��Name  �� ScaleX! �� ScaleY  StackedButtonStyle" �� BasedOn  RadioButtonStyle0  *System.Windows.Media.Animation.QuarticEase# � ColumnDefinitions$ A�Name% �� Stretch& � UseLayoutRounding  CheckBoxStyle' F�Name  BackButtonStyle0  *Microsoft.Kinect.Wpf.Controls.KinectRegion4  .System.Windows.Automation.AutomationProperties( �� Padding) ��Name* J� IsHitTestVisible+ �� StrokeEndLineCap, �� StrokeDashArray- �� StrokeDashOffset�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      0k(http://schemas.microsoft.com/kinect/2014  %];  &	        &	      &	 &     &	 9     &	 L     &	 _     7   &	 i     7  &	 s     7  &	 }     7  &		 �     7  &	
 �     &	 �     '�� #    &	 �    &	 �    &	 �    &	 �    &	 �    &	 :    &	 �    7  7  7  7  7  7  7  7  7  7  7  7  7  &	 �    7  &	 �    7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 �$    7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 �3    7  7  ��	#FF6B6B6B����	#FF3A3A3A����	#FF101010����	#FFEBEBEB����	#FF101010���� 8    �� 8    �� 8    �� 8    �� 8       $ 7Q��� " ��.���  � ��$ 28(���  � ��$ Segoe UI Light)���  �@��
LineHeight$ 36����  � ��$ 10 10 10 25q��� BaseTextBlockStyle��" ��.���  � ��$ Segoe UI)���  � ��$ 24(���  � ��$ Center=��� $  Black���� $  DarkGray���� $  Yellow���� $
  Aqua���� " ��.���  � �� �� " ��.R��� $ 	focusRect��$��6q�$��-6q�._��� ���� focusRectBrush��$  Transparent��   CommonStates��.   
Normal��  	MouseOver��.	 �� .���� $
 0D�$ focusRectBrush��$ Color�$
 GrayX�  Pressed��.	 �� .���� $
 0D�$ focusRectBrush��$ Color�$
 GrayX��� " ��.���  � ��$ Segoe UI)���  � ��$ SemiBold"���  � ��$ 24(���  � ��$ 0q���  �@��
LineHeight$ 48����  � ��$
 Wrap=���  � ��$ Center=��� " ��.���  � ��$
 Left=���  � ��$	 Top=���  � ��$
 Left=���  � ��$ Bottom=���  � ��$	 112����  � ��$	 216����  � ��$ 
14,20,0,16q���  � ��8   ��  � ��
 ���� ��  � ��$ 1q���  � �� �� " ��.R��    CommonStates��   $ Pressed��$ 0D�. �� .��W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 	rectangle��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 
rectangle1��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle2��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle3��    $ 7Q�T� $ (UIElement.Visibility)�$ DarkMask��..�i� $ 	0:0:0.333��  Visible=�.   
Normal��  PointerOver��.	 �� .��W� $
 0D�$ 1X�$ (UIElement.Opacity)�$ PointerOverHighlight��  Pressed��.	 �� .��W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 	rectangle��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 
rectangle1��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle2��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle3��    $ 7Q�T� $ (UIElement.Visibility)�$ DarkMask��..�i� $ 0��  Visible=�  Disabled��.	 �� .��W� $
 0D�$ 0X�$ (UIElement.Opacity)�$ ContentPresenter��  FocusStates��   $ Focused��$ 	Unfocused��$ 	0:0:0.133D�    $ 7Q�  $ PointerFocused��$ 	Unfocused��$ 	0:0:0.133D�    $ 7Q�.   Focused��.	 �� .��T� $ 
Background�$ Border��..�i� $ 0��8  W� $
 0D�$ 1X�$ (UIElement.Opacity)�$ FocusHighlight��T� $ (UIElement.Visibility)�$ FocusHighlight��..�i� $ 0��  Visible=�W� $
 0:0:0.0D�$
 .285X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 	rectangle��W� $
 0:0:0.0D�$
 .285X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 
rectangle1��W� $
 0:0:0.0D�$
 .285X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle2��W� $
 0:0:0.0D�$
 .285X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle3��T� $ (UIElement.Visibility)�$ DarkMask��..�i� $ 0:0:0.0��  Visible=�  	Unfocused��  PointerFocused��.	 �� .��T� $ 
Background�$ Border��..�i� $ 0��8  W� $
 0D�$ 1X�$ (UIElement.Opacity)�$ FocusHighlight��T� $ (UIElement.Visibility)�$ FocusHighlight��..�i� $ 0��  Visible=�W� $
 0:0:0.0D�$
 .285X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 	rectangle��W� $
 0:0:0.0D�$
 .285X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 
rectangle1��W� $
 0:0:0.0D�$
 .285X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle2��W� $
 0:0:0.0D�$
 .285X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle3��T� $ (UIElement.Visibility)�$ DarkMask��..�i� $ 0:0:0.0��  Visible=�.+��� $ PointerOverHighlight��$�� ��8�� 8�� $��4q���.  $ 0Q����� " ��.R�� .+��� $ HilightRectangle��$��HighlightRectangle.png��$
��Fill=�$��-31,-30q��� $ HighlightBorder��#��z��#��z��#��z��$��-8q��� #��z��#��z��#��z��#��z��#��z���� $ FocusHighlight��8�� 8�� $��4q���.  $�� ��$ 0Q�$y�	Collapsed=����� " ��.R�� .+��� $ HilightRectangle��$��HighlightRectangle.png��$
��Fill=�$��-31,-30q��� $ HighlightBorder��#��z��#��z��#��z��$��-8q��� #��z��#��z��#��z��#��z��#��z���� $ Border��#��z��8�� #��z��$ 0.5,0.5&�z��� ._�� $ ContentPresenter��$��Center=�$
��Left=�.+��� #��z��# z��$��Stretch=�$��Stretch=�8�� $ 2��� $ DarkMask��$y�	Collapsed=�$��-4q�.+��� $ 	rectangle��8��	 $
��Left=�$��14��$ 0,0.5&�z��� $  0Q��� $ 
rectangle1��8��
 $��Right=�$��14��$ 1,0.5&�z��� $  0Q��� $ 
rectangle2��8�� $��14��$	��Top=�$ 0.5,0&�z��� $! 0Q��� $ 
rectangle3��8�� $��14��$��Bottom=�$ 0.5,1&�z��� $! 0Q��� " ��8"   .���  � ��$ 0,0,0,1q��� " 	�.���  � ��$	 112����  � ��$	 316����  � ��$	 948����  � ��$ 18,14,18,14q���  � ��8   ��  � ��$
 Left=���  � ��$	 Top=���  � ��$
 Left=���  � ��$	 Top=���  � ��$ 0,1,0,0q���  � ��
 ���� ��  � �� �� " 	�.R�� $	��4,6q�$	��Top=�   CommonStates��   $ Pressed��$ 0D�. �� .��W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 	rectangle��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 
rectangle1��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle2��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle3��    $ 7Q�T� $ (UIElement.Visibility)�$ DarkMask��..�i� $ 	0:0:0.333��  Visible=�  $ PointerOver��$ Normal��$ 0:0:0.33D�   .   
Normal��  PointerOver��.	 �� .��W� $
 0D�$ 1X�$ (UIElement.Opacity)�$ PointerOverHighlight��  Pressed��.	 �� .��W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 	rectangle��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 
rectangle1��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle2��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle3��    $ 7Q�T� $ (UIElement.Visibility)�$ DarkMask��..�i� $ 0��  Visible=�  Disabled��.	 �� .��W� $
 0D�$ 0X�$ (UIElement.Opacity)�$ ContentPresenter��  FocusStates��   $ Focused��$ 	Unfocused��$ 0:0:0.33D�     $ PointerFocused��$ 	Unfocused��$ 0:0:0.33D�   .   Focused��.	 �� .��T� $ 
Background�$ Border��..�i� $ 0��8  T� $ (Shape.Fill)�$ NormalRectangle��..�i� $ 0��8  T� $ (UIElement.Visibility)�$ FocusHighlight��..�i� $ 0��  Visible=�  	Unfocused��  PointerFocused��.	 �� .��T� $ 
Background�$ Border��..�i� $ 0��8  T� $ (UIElement.Visibility)�$ FocusHighlight��..�i� $ 0��  Visible=�  CheckStates��.   Checked��.	 �� .��T� $ (UIElement.Visibility)�$ 
CheckGlyph��..�i� $ 0��  Visible=�  	Unchecked��  Indeterminate��.	 �� .��T� $ (UIElement.Visibility)�$ IndeterminateGlyph��..�i� $ 0��  Visible=�.+��� $ PointerOverHighlight��8�� $��4q�$��-8q�$ 0Q���Z� �� $ FocusHighlight��8�� $��4q�$��-8q�$y�	Collapsed=���Z� �� $ Border��#��z��8�� $ 0.5,0.5&�z��� ._�� # �� $
��Auto ��� $��* �.+�� $ CheckBox��#��z��$ 1,0.5&�$	��100��$	��100��$	��Top=�z��� .+�A� $$ NormalRectangle��8�� $��4��$��18q�A� $$ 
CheckGlyph��8�� $��25.557��$��25.557��$y�	Collapsed=�$
% Fill=��� $ IndeterminateGlyph��8��	 $��28��$��28��& .  $y�	Collapsed=�� $ ContentPresenter��$��1��$ 0,0.5&�$
��Left=�$��Center=�z��� .+��� #��z��# z��$��Stretch=�$��Stretch=�8��
 $ 2��� $ DarkMask��$y�	Collapsed=�$��-4q�.+��� $ 	rectangle��8�� $
��Left=�$��14��$ 0,0.5&�z��� $  0Q��� $ 
rectangle1��8�� $��Right=�$��14��$ 1,0.5&�z��� $  0Q��� $ 
rectangle2��8�� $��14��$	��Top=�$ 0.5,0&�z��� $! 0Q��� $ 
rectangle3��8�� $��14��$��Bottom=�$ 0.5,1&�z��� $! 0Q��� " ��.���  � ��$	 112����  � ��$	 316����  � ��$	 948����  � ��$ 18,14,18,14q���  � ��8   ��  � ��$
 Left=���  � ��$	 Top=���  � ��$
 Left=���  � ��$	 Top=���  � ��$ 0,1,0,0q���  � ��
 ���� ��  � �� �� " ��.R�� $	��4,6q�$	��Top=�   CommonStates��   $ Pressed��$ 0D�. �� .��W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 	rectangle��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 
rectangle1��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle2��    $ 7Q�W� $
 	0:0:0.333D�$ 0X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle3��    $ 7Q�T� $ (UIElement.Visibility)�$ DarkMask��..�i� $ 	0:0:0.333��  Visible=�  $ PointerOver��$ Normal��$ 0:0:0.33D�   .   
Normal��  PointerOver��.	 �� .��W� $
 0D�$ 1X�$ (UIElement.Opacity)�$ PointerOverHighlight��  Pressed��.	 �� .��W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 	rectangle��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleX)�$ 
rectangle1��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle2��    $ 7Q�W� $
 	0:0:0.133D�$ 1X�$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�$ 
rectangle3��    $ 7Q�T� $ (UIElement.Visibility)�$ DarkMask��..�i� $ 0��  Visible=�  Disabled��.	 �� .��W� $
 0D�$ 0X�$ (UIElement.Opacity)�$ ContentPresenter��  FocusStates��   $ Focused��$ 	Unfocused��$ 0:0:0.33D�     $ PointerFocused��$ 	Unfocused��$ 0:0:0.33D�   .   Focused��.	 �� .��T� $ 
Background�$ Border��..�i� $ 0��8  T� $ (Shape.Fill)�$ NormalRectangle��..�i� $ 0��8  T� $ (UIElement.Visibility)�$ FocusHighlight��..�i� $ 0��  Visible=�  	Unfocused��  PointerFocused��.	 �� .��T� $ 
Background�$ Border��..�i� $ 0��8  T� $ (UIElement.Visibility)�$ FocusHighlight��..�i� $ 0��  Visible=�  CheckStates��.   Checked��.	 �� .��T� $ (UIElement.Visibility)�$ 
CheckGlyph��..�i� $ 0��  Visible=�  	Unchecked��  Indeterminate��.	 �� .��T� $ (UIElement.Visibility)�$ IndeterminateGlyph��..�i� $ 0��  Visible=�.+��� $ PointerOverHighlight��8�� $��4q�$��-8q�$ 0Q���Z� �� $ FocusHighlight��8�� $��4q�$��-8q�$y�	Collapsed=���Z� �� $ Border��#��z��8�� $ 0.5,0.5&�z��� ._�� # �� $
��Auto ��� $��* �.+�� $ CheckBox��#��z��$ 1,0.5&�$	��100��$	��100��$	��Top=�z��� .+��� $ NormalRectangle��8�� $��4��$��18q�F� $' 
CheckGlyph��=����=t�ؾ ����i �xIB�F��� 4�� ��| �*��ZC���8�� $��25.557��$��32.985��$y�	Collapsed=�$
% Fill=��� $ IndeterminateGlyph��8��	 $��28��$��28��& .  $y�	Collapsed=�� $ ContentPresenter��$��1��$ 0,0.5&�$
��Left=�$��Center=�z��� .+��� #��z��8��
 # z��$��Stretch=�$��Stretch=�$ 2��� $ DarkMask��$y�	Collapsed=�$��-4q�.+��� $ 	rectangle��8�� $
��Left=�$��14��$ 0,0.5&�z��� $  0Q��� $ 
rectangle1��8�� $��Right=�$��14��$ 1,0.5&�z��� $  0Q��� $ 
rectangle2��8�� $��14��$	��Top=�$ 0.5,0&�z��� $! 0Q��� $ 
rectangle3��8�� $��14��$��Bottom=�$ 0.5,1&�z��� $! 0Q��� " ��.���  � ��$ 48����  � ��$ 48����  � ��$ 36,36,36,36q���  �@ KinectPressInset$ 36,36,36,36q���  � ��$ Bottom=���  � ��$ Normal"���  �@ AutomationId$ 
BackButton����  �@ Name$
 Back����  �@ ItemType$ Navigation Button����  � �� �� " ��.R�� $ RootGrid��.+��� #( z��
������ ._�� $��
-1,-16,0,0q�.+��� $) BackgroundGlyph��$	����
���   �$ 0Q�$��Segoe UI Symbol)�$��56(��� $) NormalGlyph��$	����
���   �$��Segoe UI Symbol)�$��56(��� $) 
ArrowGlyph��$	����
�������$ 0Q�$��Segoe UI Symbol)�$��56(��� $ FocusVisualWhite��* .  
�������$+ Square=�$	, 1,1R�$ 0Q�$	- 1.5Q��� $ FocusVisualBlack��* .  
���   �$+ Square=�$	, 1,1R�$ 0Q�$	- 0.5Q�   CommonStates��.   
Normal��  PointerOver��.	 �� .��T� $ BackgroundGlyph��$ 
Foreground�..�i� $ 0��8   T� $ NormalGlyph��$ 
Foreground�..�i� $ 0��8    Pressed��.	 �� .��W� $ 
ArrowGlyph��$ Opacity�$ 1X�$
 0D�W� $ BackgroundGlyph��$ Opacity�$ 1X�$
 0D�W� $ NormalGlyph��$ Opacity�$ 0X�$
 0D�  Disabled��.	 �� .��T� $ RootGrid��$ 
Visibility�..�i� $ 0��$ 	Collapsed��  FocusStates��.   Focused��.	 �� .��W� $ FocusVisualWhite��$ Opacity�$ 1X�$
 0D�W� $ FocusVisualBlack��$ Opacity�$ 1X�$
 0D�  	Unfocused��  PointerFocused��