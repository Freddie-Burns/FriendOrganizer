   M S B A M L   `   `   `  ����M  IFriendOrganizer.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FriendOrganizer.UIFriendOrganizer.UI  5          FriendOrganizer.UI.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      2local clr-namespace:FriendOrganizer.UI     5        �� 	Resources  5       �� 
TargetType �� Property �� Value ��Name �� ElementName �� Path �� Triggers P� Property	 P� Value
 �� RelativeSource   DataGridColumnStyle  DataGridEditingColumnStyle��%�  '��       &	      &	 �    �� 5   
   " ��6   .�5      ��  �@=�ErrorTemplate 5	      �� 5
      .R�5      �� .+�5      �� $ placeholder��68   �� 5      $��12(�6(   
���  ����6G   �� $ placeholder��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      5      5       5      P� 5       �@=�HasError	 . . �5      ��  � ��
 �  ��63   �� 5       �@�ToolTip 60   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent�5      5      �� 5   
   " ��6,    5      P� 5       �@=�HasError	 . . �5      ��  � ��
 �  ��63   �� 5        �@�ToolTip 60   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent�5"      5$      �� 5&   
   " ��63    5'      P� 5(       �@=�HasError	 . . �5)      ��  � ��
 �  ��63   �� 5*       �@�ToolTip 60   �� 
 �� *Self+$) #(Validation.Errors)[0].ErrorContent�5,      5.      50      51      