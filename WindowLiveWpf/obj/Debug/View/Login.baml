   M S B A M L   `   `   `  ����F  BLive.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Live.Client.ViewLive.Client.View  5   	       Live.Client.View.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   *localclr-namespace:Live.Client.View  5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������ $	��400��5   	   $	��800��5   	    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      
BlurRadius$ 10Q�6      Color$ 	#FF858484��6+      	Direction$ 90Q�6=   	   ShadowDepth$	 1Q�6L   .��5      � $	��330��6   $	��370��6   
 � RowDefinitions
 5   
   �� 5      $��30 �6   �� 5      $	��110 �6   �� 5      ��5   
   �� 5       �� Color$ #263462��6   60   .+�5   
   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6"   $��30��5   "   $��30��5    "   $��Right=�5!   "   
�������$��Center=�5#   "   .  (System.Windows.Interactivity.Interaction   Triggers 5$      /  )System.Windows.Interactivity.EventTrigger  5%         	EventName$ MouseLeftButtonDown��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5&      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *ExitCommand+ �� Mode$ OneWay=�5'      5)      � 5*   
   $��1��6   
 5+      �� 5,      $	��110 �6    .+�5.      �� $��0��6    �� Orientation$ 
Horizontal=�6'   $��Center=�6A   $��Center=�6\   .+�5/        $��0��6*   $ Jsfiddle=�67   
�������$��Center=�6Z   $��32��6u   $��32��6�   $��Center=�6�   �� 50      
�������$��华文新魏)�6/   $��21.75pt(�6A   $
��Bold"�6T   $��Center=�6g   格 知 直 播6�   51      52      � 53   
   $��2��6   
�������
 54      �� 55      $��15 �6    �� 56      $��45 �6    �� 57      $��45 �6    �� 58      $��30 �6    �� 59      �� 5:      $��30 �6    .+�5<      �� -   5        $��userName��5<   #   $��1��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	用户名��5=      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .    
Foreground �#666666   UnderlineBrush �#263462$	��180��5B      $��Center=�5C      $��Center=�5D      ��5A      �� *
UserName+.��5D   5   5F      G� 5G      -   5        $��password��5G   '   $��2��6   $ 密  码��5H       .  �#666666 �#263462$	��180��5L      $��Center=�5M      $��Center=�5O      (	   "Live.Client.View.PasswordBoxHelper 	  Password 5N      �� *
Password+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   	Behaviors 5P      *
   $Live.Client.View.PasswordBoxBehavior
  5Q      5S      �� 5T      $��3��6   $��记住密码��6$   $��Center=�6U   $��Bottom=�6r   $��	0 0 110 0q�6�   ���#666666 d� 	IsChecked 63   �� *UserChecked+6�   �� 5U      $��4��6   $
��14pt(�6"   $
��Bold"�62   $��宋体)�6D   ���#00ace1$��登 录��6i   $��Center=�6�   $��Center=�6�   $	��180��6�   {�6w   �� *
IsCancel+��6�   �� *SignCommand+�� 5V      $��5��6   $��Center=�6<   ���#ABABAB��6!   �� *Report+6Y   5W      5X      5Y      