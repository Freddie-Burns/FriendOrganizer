   M S B A M L   `   `   `  ����M  IFriendOrganizer.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FriendOrganizer.UI.ViewFriendOrganizer.UI.View  5      .    (FriendOrganizer.UI.View.FriendDetailView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:FriendOrganizer.UI.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��	Firstname��6   $��
10 10 10 0q�5      �� 5   
   $��1��6   $��
10 0 10 10q�5      ��5      �� *Friend.FirstName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5    
   $��2��6   $��Lastname��5!      $
��10 0q�5"      �� 5$   
   $��3��6   $��
10 0 10 10q�5%      ��5&      �� *Friend.LastName+$ TwoWay=�$ PropertyChanged=��� 5*   
   $��4��6   $��Email��5+      $
��10 0q�5,      �� 5.   
   $��5��6   $��
10 0 10 10q�5/      ��50      �� *Friend.Email+ �� TargetNullValue$  ��$ TwoWay=�$ PropertyChanged=��� 55   
   $��6��6   $
��10 0q�56      $��Favourite Language��57      �� 59   
   $��7��6   $��	10 0 10 0q�5:       �� DisplayMemberPath$ DisplayMember��5<       �� SelectedValuePath$ Id��5=      ��5;      �� *ProgrammingLanguages+ �� SelectedValue 5>      �� *Friend.FavouriteLanguageId+$ TwoWay=�]� 5@   
   $��8��6   $��10q�6!   .+�5A      �� $��Right=�6   .+�5B      �� $	��Add��6   $	��125��5C      $��10 0 0 0q�5D      ��5E      �� *AddPhoneNumberCommand+�� 5F      $��Remove��6   $	��125��5G      $��	10 10 0 0q�5H      ��5I      �� *RemovePhoneNumberCommand+5J      &   System.Windows.Controls.DataGrid  5L         AutoGenerateColumns .     RowHeaderWidth$ 0Q�5O      ��5L      �� *PhoneNumbers+	 �� SelectedItem	 5M      �� *SelectedPhoneNumber+$ TwoWay=�
   Columns
 5P      0  *System.Windows.Controls.DataGridTextColumn  5Q      ,  &System.Windows.Controls.DataGridColumn   Header$ Phone Numbers��5R         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5S         DataGridColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [  5T        DataGridEditingColumnStyle   EditingElementStyle# [ 5U         Binding 5V      �� *Number+$ TwoWay=�$ PropertyChanged=�5X      5Y      �� 5[   
   $��9��6    �� Orientation$ 
Horizontal=�6"   .+�5\      �� $
��Save��6   $	��125��5]      $��10q�5^      ��5_      �� *SaveCommand+�� 5`      $��Delete��6   $	��125��5a      $��10q�5b      ��5c      �� *DeleteCommand+5d      5e      5f      