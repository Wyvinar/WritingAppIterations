   M S B A M L   `   `   `  ????A  =WPFAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAPPWPFAPP  5          WPFAPP.StartPage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:WPFAPP     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$  	StartPage??5
      .??5      ? -   5         ?Name$ StartMainGrid??5       ? ColumnDefinitions 5   
   ?? 5      $	??180 ?6   ?? 5      .+?5   
   ? $??0??6   ???	#FFF0F0F0 ? RowDefinitions 5      ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6    ?? 5      $??* ?6    ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6     ? 	Resources 5       ?? 
TargetType ?? Property ?? Value'  !MaterialDesignThemes.Wpf.PackIcon??%3  '??       '  w    '?? ?    ?? 5       " ??6   .?5!      ??  ? ??$ 20,10,10,10q?60   ?? 5"       ? ??$
 Left=?5#      ?? 5$       ? ??$ 1,0,0,0q?6/   ?? 5%       ? ??$ 0q?68   ?? 5&       ? ??$ 18(?61   ?? 5'       ? ??$ Segoe UI Light)?5(      ?? 5)       ? ??$ Center=?5*      ?? 5+       ? ?? ?	#FFF0F0F063   5,      ?? 5.      "  6   .?5/      ??  ? ??$ Center=?50      51      ?? 53      " ??6   .?54      ??  ? ??$ 10,0,0,0q?6/   55      56      .+?59      ?? -   5         ??Name$ 
mnuBtnHome??59      $??0??6)   .??5;      ?? 	 ?? Orientation$	 
Horizontal=?6   .+?5<        
   Kind$
 HomeOutline=?5=      ?? 5>      -   5         ??Name$ mnuHome??5>       $
??Home??61   5?      5@      ?? 5C      -   5        $ mnuBtnLibrary??5C      $??1??6,   .??5E      ?? $	 
Horizontal=?6   .+?5F        $ 
 BookOpenPageVariantOutline=?5G      ?? 5H      -   5        $ 
mnuLibrary??5H       $??Library??64   5I      5J      ?? 5M      -   5        $ 	mnuBtnNew??5M      $??2??6(   .??5O      ?? $	 
Horizontal=?6   .+?5P        $
 PencilOutline=?5Q      ?? 5R      -   5        $ mnuNew??5R       $	??New??60   5S      5T      ?? 5W      -   5         ??Name$ mnuSeparator??5X      $??3??5W      $??0q?6%   $??	15,0,15,0q?61   5X      ?? 5[      -	   5        $ mnuBtnTemplates??5[      $??4??6.   .??5]      ?? $	 
Horizontal=?6   .+?5^        $
 BookOutline=?5_      ?? 5`      -
   5        $ 	mnuTmplts??5`       $??	Templates??63   5a      5b      ?? 5e      -   5        $ mnuBtnSettings??5e      $??6??6-   .??5g      ?? $	 
Horizontal=?6   .+?5h        $
 
CogOutline=?5i      ?? 5j      -   5        $ mnuSettings??5j       $??Settings??65   5k      5l      ?? 5o      -   5        $ mnuBtnCollapse??5o      $??7??6-   .??5q      ?? $	 
Horizontal=?6   .+?5r      ?? -   5        $ mnuCollapse??5s       $??Collapse Menu??5r       $??0,0,10,0q?65   5s         5t      -   5          Name$ mnuCollapseIcon??5v      $ 
 ArrowLeftDropCircleOutline=?5u      5v      5w      5x      ?? 5{      -   5        $ mnuBtnExpand??5{      $??7??6+   $y?Hidden=?5|   0   .??5}      ?? $	 
Horizontal=?6   .+?5~        -   5        $ mnuExpandIcon??5?      $!
 ArrowRightDropCircleOutline=?5      5?      5?      5?      5?       ? 5?   
   -   5          ?Name$ StartPageFrame??5?      $??1??6(     ? Source$ HomePage.xaml??5?        ? NavigationUIVisibility$ Hidden=?6'   5?      5?      