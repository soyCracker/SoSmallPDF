   M S B A M L   `   `   `  ����E  ASoSmallPDF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SoSmallPDF
SoSmallPDF  5          SoSmallPDF.RotatePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SoSmallPDF     5        N� Title$  
RotatePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��SelectFileButton��5      $!��1. select file 選擇檔案��6)   $
��18px(�6G   $��Center=�6W   $��Center=�6t   $��200px��6�   $��0��6�   $��1��6�   ���#ffede9$��Bradley Hand ITC)�6�   $
��Bold"�6  �� 5   
   -   5        $��StartButton��5      $��3. 各別旋轉��6$   $
��18px(�66   $��Center=�6F   $��Center=�6c   $��2��6~   $��0��6�   $��150px��6�   ���#ffede9$��Bradley Hand ITC)�6�   $
��Bold"�6�   �� 5   
   -   5        $��AllRotateButton��5      $��3. 全部旋轉��6(   $
��18px(�6:   $��Center=�6J   $��Center=�6g   $��2��6�   $��1��6�   $��150px��6�   ���#ffede9$��Bradley Hand ITC)�6�   $
��Bold"�6�   �� 5   
   -   5        $��SelectFileTextBlock��5      $�� ��60   $
��16px(�68   $
��Wrap=�6H   $��Center=�6\   $��Bottom=�6y   $��
0,0,0,20pxq�6�   $��300px��6�   $��0��6�   $��1��6�   $��Bradley Hand ITC)�6�   $
��Bold"�6�   �� 5   
   -   5        $��MessageTextBlock��5      $
��Wrap=�6,   $
��16px(�6@   $'��!2. 請選擇全部旋轉角度：��6P   $
��Left=�6e   $	��Top=�6�   $��150px��6�   $��1��6�   $��1��6�   $��Bradley Hand ITC)�6�   $
��Bold"�6�   �� 5   
   -   5        $��DegreeComboBox��5      $��Center=�6)   $��Center=�6F   $��200px��6a   $��1��6o   $��1��6|   .@�5      �� -   5        $��right��5      $��右轉90度��6(   $
��18px(�68   $��Bradley Hand ITC)�6H   $
��Bold"�6f   �� 5      -   5        $
��half��5      $��	轉180度��6'   $
��18px(�67   $��Bradley Hand ITC)�6G   $
��Bold"�6e   �� 5      -	   5        $
��left��5      $��左轉90度��6'   $
��18px(�67   $��Bradley Hand ITC)�6G   $
��Bold"�6e   5      �� 5   
   -
   5        $��PageListBox��5      $
��Left=�6%   $	��311��6@   $��	36,35,0,0q�6M   $	��Top=�6`   $	��260��6x   $��3��6�    J� 	AllowDrop . 6�   5       5!      