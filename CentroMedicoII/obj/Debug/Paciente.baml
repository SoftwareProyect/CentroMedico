   M S B A M L   `   `   `  ����I  ECentroMedicoII, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CentroMedicoCentroMedico  5   	       CentroMedicoII.Paciente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CentroMedico     5   	   -   5          � Title$  Paciente��5   	    � WindowState$ 	Maximized=�6   .��5	      � ��5
   
   �� 5       j� Stretch$
 None=�6    �� ImageSource$ ventana/paciente2.jpg��6(    j� 
AlignmentY$	 Top=�6L    j� 
AlignmentX$
 Left=�6]    � RowDefinitions 5   
   �� 5      $	��55* �6   �� 5      $	��45* �6   �� 5      $
��200* �6   �� 5      $	��30* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $	��30* �6#   �� 5      $	��21* �6#   �� 5      $	��24* �6#   �� 5      $	��20* �6#   .+�5      �� -   5        $��
btnagregar��5      
����  �$��2q�6=   $��1��6Q   $��btn agregar��6a   6w   �� 5      -   5        $��txtbusqueda��5      $��12q�6)   
����  �$��2q�6L   $��2��6`   $��Bottom=�6p   $	��346��6�   $��50��6�   $��buscar��6�   6�   �� 5      -   5        $��	btnbuscar��5      
����  �$��2q�6<   $��3��6P   $��
btn buscar��6`   5      �� 5!   
   $��2��6   $��5q�6"   $��Center=�6-   $
��1250��6J    �� CanVerticallyScroll . $��Visible=�6r   .+�5"      �� -   5        $��lst_paciente��5"   W   
�������.@�5#      �� $
��hola��6   �� 5$      $��.��6   �� 5%      $��... Movimiento ��6   �� 5&      $��naranja ...��6   �� 5'      $	��...��6   �� 5(      $$��el futuro esta en tus manos :v��6   5)      5*      �� 5,   
   $��3��6   .+�5-      �� -   5        $��
btn_volver��5-      
����  �$��2q�6=   $��
btn volver��6Q   $	��100��6f   $	��120��6r   $
��left=�6�   6�   5.      5/      50      