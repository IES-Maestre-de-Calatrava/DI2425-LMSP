   M S B A M L   `   `   `  ����G  CWpfAppCanvas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfAppCanvasWpfAppCanvas  5   	       WpfAppCanvas.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfAppCanvas     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      A� -   5        $��	container��5	       A� Rows$ 2��6#    A� Columns$ 2��6,   .+�5
   
   � -   5        $
��wrap��5
       � Orientation$ Vertical=�6    .+�5      �� -   5        $
��btn1��5      $
��btn1��6!   �� 5      -   5        $
��btn2��5      $
��btn2��6!   �� 5      -   5        $
��btn3��5      $
��btn3��6!   �� 5      -   5        $
��btn4��5      $
��btn4��6!   �� 5      -   5        $
��btn5��5      $
��btn5��6!   5      �� 5   
   -   5        $��stack��5      .+�5      �� $	��btn��6   �� 5      $	��btn��6   �� 5      $	��btn��6   �� 5      $	��btn��6   5      ]� 5   
   -	   5        $
��dock��5      .+�5      �� $	��btn��6   �� 5      $	��btn��6   �� 5      $	��btn��6   �� 5      $	��btn��6   5      �� 5   
   -
   5        $��canvas��5      .+�5      �� $	��btn��6    �� Left$ 10��6#   
 �� Top$ 10��64   �� 5       $	��btn��6   $ 25��6#   $ 25��64   �� 5!      $	��btn��6   $ 40��6#   $ 40��64   5"      5#      5'      