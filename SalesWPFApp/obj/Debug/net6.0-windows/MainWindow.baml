   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5   	   -   5        $��
mainWindow��5
   	    
  MainVM  � DataContext#  [  5	   	     MaterialDesignBody#���  5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Sale Home App��5   	   $	��670��5   	   $	��850��5   	   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *LoadedWindowCommand+	   CommandParameter	 5   $   �� 
 �� ElementName$
 
mainWindow��5      .��5       � $��	0,10,0,-6q�6   ��5!   
   �� 5"       �� ImageSource$ Resources/logo.jpg��6    j� Stretch$
 Fill=�5#      .+�5&   
   �� $
��25px(�6   $
��50pxq�5'      $
��Bold"�5(      Shopping Application:6=   �� 5)   
   $
��20px(�6   $��80,118,120,82q�5*      $
��Bold"�5+      
Account:60   �� 5,   
   $
��20px(�6   $��210,118,90,82q�5-      $
��Bold"�5.      ��5/      �� *Email+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�	App Admin6g   � 50   
   $��80,137,-80,-137q�6   .+�51      �� $��Company Name��6   $��
0,50,0,-89q�52      �� 53      $
��City��6   $��0,130,0,-153q�54      �� 55      $��Country��6   $��0,208,0,-253q�56      �� 58      $
��20px(�6   $��130,46,90,154q�5:      ��59      �� *CompanyName+$ PropertyChanged=�$ TwoWay=�Admin5:   6   �� 5;      $
��20px(�6   $��130,130,-30,10q�5=      ��5<      �� *City+$ PropertyChanged=�$ TwoWay=�Admin5=   7   �� 5>      $
��20px(�6   $��130,202,90,108q�5@      ��5?      �� *	Country+$ PropertyChanged=�$ TwoWay=�Admin5@   7   5B      �� 5D   
    # MaterialDesignRaisedLightButton#��[ 5F      $	��250��5G       � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5H      $��480,132,120,346q�5I      ��5D      �� *AccountCommand+��5E      �� $
 
mainWindow��.��5I   *   Account Management5K      �� 5L   
    $  MaterialDesignRaisedAccentButton#��[ 5N      $	��250��5O      $5 /Resource name: MaterialDesignRaisedAccentButton��5P       J� RenderTransformOrigin$ 0.84,-0.531&�5Q      $��480,254,120,264q�5R      ��5L      �� *ProductCommand+��5M      �� $
 
mainWindow��.��5R   *   Product Management5T      �� 5U   
    " MaterialDesignRaisedDarkButton#��[ 5W      $	��250��5X      $8 2Resource name: MaterialDesignRaisedLightDarkButton��5Y      $��480,344,120,174q�5Z      ��5U      �� *OrderCommand+��5V      �� $
 
mainWindow��.��5Z   *   Order5\      5]      5^      