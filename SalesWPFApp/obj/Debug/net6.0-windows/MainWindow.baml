   M S B A M L   `   `   `  ????F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5   	   -   5        $??
mainWindow??5
   	    
  MainVM  ? DataContext#  [  5	   	     MaterialDesignBody#???  5   
   $??Regular"?5   
   $??13(?5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   
      TextRenderingMode$
 Auto=?5   
     MaterialDesignPaper#???  5   
     MaterialDesignFont#???  5   
    ? WindowStartupLocation$ CenterScreen=?5   	    ? Title$ Sale Home App??5   	   $	??570??6   $	??850??6,   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded??6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 5      ?? *LoadedWindowCommand+	   CommandParameter	 5      ?? 
 ?? ElementName$
 
mainWindow??5      .??5      ? $??	0,0,0,-76q?6   .+?5    
   ?? $
??25px(?6   $
??50pxq?6$   $
??Bold"?62   	WELLCOME:6O   ?? 5!   
   $
??20px(?6   $??80,118,120,82q?6$   $
??Bold"?6;   
Account:6W   ?? 5"   
   $
??20px(?6   $??210,118,90,82q?6$   $
??Bold"?6;   ??6M   ?? *Email+ ?? UpdateSourceTrigger$ PropertyChanged=? ?? Mode$ TwoWay=?	App Admin6?   ? 5#   
   $??80,137,-80,-137q?6   .+?5$      ?? $??Company Name??6   $??
0,50,0,-89q?6+   ?? 5%      $
??City??6   $??0,130,0,-153q?6#   ?? 5&      $??Country??6   $??0,208,0,-253q?6&   ?? 5(      $
??20px(?6   $??130,46,90,154q?6w   ??6(   ?? *CompanyName+$ PropertyChanged=?$ TwoWay=?6?   ?? 5)      -   5        $??companyName??5)      $??33??6)   $	??195??65   $
??Left=?6C   $	??Top=?6^   $??
130,43,0,0q?6v   ?? 5*      $
??20px(?6   $??130,115,90,115q?6q   ??6)   ?? *City+$ PropertyChanged=?$ TwoWay=?6?   ?? 5+      -   5        $
??city??5+      $??33??6"   $	??195??6.   $
??Left=?6<   $	??Top=?6W   $??130,115,0,0q?6o   ?? 5,      $
??20px(?6   $??130,192,90,108q?6t   ??6)   ?? *	Country+$ PropertyChanged=?$ TwoWay=?6?   ?? 5-      -   5        $??country??5-      $??33??6%   $	??195??61   $
??Left=?6?   $	??Top=?6Z   $??130,192,0,0q?6r   5/      ?? 51   
    # MaterialDesignRaisedLightButton#??[ 54      $	??250??55       ? ToolTip$4 .Resource name: MaterialDesignRaisedLightButton??56      $??480,132,120,346q?6F   ??52      ?? *AccountCommand+??53      ?? $
 
mainWindow??.??56   `   Account Management58      ?? 59   
    $  MaterialDesignRaisedAccentButton#??[ 5<      $	??250??5=      $5 /Resource name: MaterialDesignRaisedAccentButton??5>       J? RenderTransformOrigin$ 0.84,-0.531&?6G   $??480,254,120,324q?6k   ??5:      ?? *ProductCommand+??5;      ?? $
 
mainWindow??.??5>   ?   Product Management5@      ?? 5A   
    " MaterialDesignRaisedDarkButton#??[ 5D      $	??250??5E      $8 2Resource name: MaterialDesignRaisedLightDarkButton??5F      $??480,277,120,201q?6J   ??5B      ?? *OrderCommand+??5C      ?? $
 
mainWindow??.??5F   c   Order5H      5I      5J      