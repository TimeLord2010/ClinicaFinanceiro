   M S B A M L   `   `   `  ���� E  AFinanceiro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Financeiro.UserControls.MoreFinanceiro.UserControls.More  9    3Financeiro.UserControls.More.EspecifyDatabaseImport   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:Financeiro.UserControls.More     
�������.���   � RowDefinitions  �� �� $��20 ��� �� $��40 � � ColumnDefinitions �� $	��200���� $	��300��.+�	� -   $��DatabaseFileRB��$��Center=�$��Center=�.���� Arquivo de banco de dados	� $��Center=�$��Center=�$��2�� d� 	IsChecked$
 TrueY�.���� Servidor de banco de dados�� -   $��DatabaseFileSP��$��1��$��Center=�$��Center=� �� Orientation$ 
Horizontal=�$��0,0,0,0q�{�.  .+��� $	��200����    GreenButton#��[  .��
Procurar�� -   $��ServerDatabaseSP��$��2��$��1��$��Center=�$��Center=� � 	Resources  �� 
TargetType �� Property �� Value��%3   '��       �� " ��.���  � ��$ 0,10,0,0q�.+��� $��0q�	Endereço�� -    ��Name$ ServerTB��.��192.168.0.3�� 
Usuário�� -   $ UserTB��.��root�� SenhaG� -   	 G�Name$	 
PasswordPB��
 G� Password$

 1025���� Nome do banco de dados�� -   $��
DatabaseTB��$��0,0,0,5q�.��
clinica2�� $��3��$��1��$��1��$ 
Horizontal=�$��Right=�.+��� -    ��Name$ 	CancelarB��  	RedButton#��[ .��
Cancelar�� -	   $ NextB��#��[  .��
Próximo