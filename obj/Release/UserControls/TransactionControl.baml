   M S B A M L   `   `   `  ���� E  AFinanceiro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Financeiro.UserControlsFinanceiro.UserControls  ?$clr-namespace:Financeiro.Managers.UIFinanceiro.Managers.UI  0    *Financeiro.UserControls.TransactionControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7local%clr-namespace:Financeiro.UserControls     X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  -ui$clr-namespace:Financeiro.Managers.UI  
�������.���   � ColumnDefinitions  �� $��1* ��� $��3* �.+��  � RowDefinitions �� $��20 ��� �� $��40 �.+��� $��Right=�
�������	Filtros�� $
��Auto=�$��1��.���� $��5q�.+���    TransactionsTBL#��[  	Conteúdo�� -   $��
ConteudoTB��$��0,0,0,5q�.�� � ToolTip _� .����Os resultados da pesquisa devem conter os caracteres, na ordem dada, em qualquer posição do título. Caso nenhum caractér seja dado, o campo título não vai ser filtrado..���� -    ��Name$ IncluirDescricaoTB��.��Incluir descrição�� �� #��[  Valor�  �� ��   �� $��70 ��� .+��� 	Mínimo�� -    ��Name$ ValorMinimoMTB��$��1��$��0,0,0,10q�.�� _� .��zxOs resultados da pesquisa devem ter pelo menos o valor fornecido. Caso não seja dado, o valor mínimo se torna -10.000..���� $��1��	Máximo�� -   $ ValorMaximoMTB��$��1��$��1��.�� _� .��sqOs resultados da pesquisa devem ter até o valor fornecido. Caso não seja dado, o valor máximo se torna 10.000..���� $��2���  �� �� �� ��   �� �� $��70 �.+��� $��0��#��[  
Provedor*   $Financeiro.UserControls.ChooseEntity  -     Name$ 
ProvedorCE��$��1��$��2��   	TableName$ Entity�� _� .����Os resultados da pesquisa devem ter a origem (coluna “De”) com o valor da origem escolhida. Caso não seja fornecido, este campo não vai ser filtrado na pesquisa.�� $��2��#��[  	Recebedor  -   $ RecebedorCE��$��3��$��2��$ Entity���� �� #��[  Data*   $Financeiro.UserControls.DateInterval  -     Name$ DateIntervalDI���� -   $��
PesquisarB��$��2��  GreenButton#��[ .��	Pesquisar _� .��&$Realizar pesquisa aplicando filtros.� $��1�� �� �� $	��100 ��� $��40 �.+�&   System.Windows.Controls.DataGrid  -	   $��TransactionsDG��$��5,5,5,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Título��
   MinWidth$	
 150Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Title+  $	 Valor��$
 50Q� �� *Amount+  $
	 Data��$
 70Q� �� *	DateStr+  $	 De��$	
 100Q� �� *
OriginName+  $
	 Para��$	
 100Q� �� *DestinationName+ � ContextMenu �� -
   $��TransactionsCM��.@�m� -   $��EditarMI��$��Editar��m� -   $��	RemoverMI��$��Deletar��� $��1��$��5q�  �� $��80 ��� .+��� $
��Auto=�.���   �� �� .+��� .+��� Items:�� $��1�� � 	Resources  �� 
TargetType �� Property �� Value��%G   '��       �� " ��.���  � ��$ Right=���  � ��$	 0.0��.+��� -    ��Name$ ItemsCountTBL��$��0�� _� .��)'Número de items na tabela de pesquisa.�� $��1��$
��Auto=�$
��Auto=�.���� -    ��Name$ ResumoSP�� �� Orientation$ 
Horizontal=�� $��2��.+��� $ 
Horizontal=�$
��Left=�.+��� -   $��	ExportarB��#��[ .��
Exportar�� $ 
Horizontal=�$��Right=�.+��� -   $��InserirB��#��[ .��	Inserir�� -   $��EditarB��#��[ {�.  .��Editar�� -   $��RemoveB��#��[ {�.  .��	Remover