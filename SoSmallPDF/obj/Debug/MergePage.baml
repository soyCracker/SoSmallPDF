   M S B A M L   `   `   `  ����E  ASoSmallPDF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SoSmallPDF
SoSmallPDF  5          SoSmallPDF.MergePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SoSmallPDF     5        N� Title$  	MergePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��6* �6   �� 5      $��4* �6   .+�5   
   �� -   5        $��SelectFileButton��5      $��select file 選擇檔案��6)   $
��18px(�6D   $��Center=�5      $��Center=�6.   $��200px��6I   $��0��5      $��1��6   ���#ffede9$��Bradley Hand ITC)�5      $
��Bold"�6/   �� 5   
   -   5        $��RemoveFileButton��5      $
��18px(�6)   $��remove file 移除檔案��69   $��Center=�5      $��Center=�6.   $��200px��6I   $��1��5      $��1��6   ���#ffede9$��Bradley Hand ITC)�5      $
��Bold"�6/   �� 5    
   -   5        $��UpFileButton��5       $
��18px(�6%   $��up file 上移檔案��65   $��Center=�5!      $��Center=�6.   $��200px��6I   $��2��5"      $��1��6   ���#ffede9$��Bradley Hand ITC)�5#      $
��Bold"�6/   �� 5$   
   -   5        $��DownFileButton��5$      $
��18px(�6'   $��down file 下移檔案��67   $��Center=�5%      $��Center=�6.   $��200px��6I   $��3��5&      $��1��6   ���#ffede9$��Bradley Hand ITC)�5'      $
��Bold"�6/   �� 5(   
   -   5        $��StartButton��5(      $��start 開始��6$   $
��18px(�67   $
��Left=�6G   $��Center=�6b   $��5��6}   $��1��6�   $��120px��6�   ���#ffede9$��Bradley Hand ITC)�6�   $
��Bold"�6�   �� 5)   
   -   5        $��MessageTextBlock��5)      $
��Wrap=�6,   $
��16px(�6@   $:��4可拖曳檔案至上方框，按順序選擇檔案:��6P   $��300px��6j   $��Right=�6x   $��Center=�6�   $��5��6�   $��0��6�   $��Bradley Hand ITC)�6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   �� 5*   
   -   5        $��
PdfListBox��5*      $
��Left=�6$   $	��311��6?   $��	36,35,0,0q�6L   $	��Top=�6_   $	��350��6w   $��5��6�    J� 	AllowDrop . 6�   5+      5,      