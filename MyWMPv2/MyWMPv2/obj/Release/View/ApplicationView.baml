   M S B A M L   `   `   `  ���� B  >MyWMPv2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MyWMPv2.ModelMyWMPv2.Model  "    MyWMPv2.View.ApplicationView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -Modelclr-namespace:MyWMPv2.Model     \ XHardcodet.Wpf.TaskbarNotification, Version=1.0.5.0, Culture=neutral, PublicKeyToken=null)tb http://www.hardcodet.net/taskbar    � Title$  ApplicationView��$	��720��$
��1280�� � WindowStyle$
 None=�$	��560��$	��640�� � Icon$" Resources/Images/wmpicon.ico�� � 	Resources    SliderRepeatButton �� 
TargetType �� Property �� Value �� 
TargetType  SliderRepeatButton1 J� SnapsToDevicePixels	 �� Path  SliderThumb 
 Slider
 � RowDefinitions ]�Name ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  HorizontalSlider �� Triggers P� Property P� Value  ListViewStyle  ListViewHeader  ListViewItemStyle �� Color  TreeViewStyle 	 TreeViewItemStyle��%d  &	        &	 �     &	 �    &	 Z    7  7  7   &	 (    7  &	     &	 >    &	 �    &	 H    &		 {    �� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  � �� �� " ��.R��� $��1q�
���   �
���   �$��3���� " ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� �� " ��.R���  . $��1q�$��3������ $	 TE.ColorSlider1����� $	 TE.ColorSlider2��� " n�.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � �� �� " n�.R�A� $��10��$��10������ $	 TE.ColorSlider1��� " ��.R�� 
 �� $
��Auto ��� $
��Auto �#��z���� $
��Auto �.+�]� $ 
PART_Track��$��1�� �� 8��  $��Slider.DecreaseLarge�� n� 8��  �� 8�� $��Slider.IncreaseLarge���� " ��.���  � |� .  ��  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle .  P�  �@��Orientation$ 
Horizontal=�. ���  � ��$ 21����  � ��$	 104����  � ��8   �� " ��.���  � �� �� $	 	TE.BgList��� " ��.���  � ��$. (Resources/Fonts/Gravity-Book.ttf#Gravity)���  � �� �� $	 	TE.BgList���  � �� �� $	 	TE.FgList��� " ��.���  � ��$. (Resources/Fonts/Gravity-Book.ttf#Gravity)���  � �� ��  �� $	 FgList��� " R�.���  � �� �� $	 	TE.BgList��� " Q�.���  � ��$. (Resources/Fonts/Gravity-Book.ttf#Gravity)���  � �� ��  �� $	 FgList� J� InputBindings �� 
 �� Key$
 Left�� �� Command �� $$	 HomeViewModel.MediaPrevCommand��� $ Right�� �� $$	 HomeViewModel.MediaNextCommand��� $
 Down�� �� $)	 #HomeViewModel.MediaPlayPauseCommand�.��� 
 �� $��3* ��� $��3* ��� $��3* ��� $	��80* �.+�3  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon  -     Name$ 	NotifIcon��$y�Visible=�   
IconSource$" Resources/Images/wmpicon.ico��   ToolTipText �� $ 	 HomeViewModel.Media.Source� �� Mode$ TwoWay=�� -   $��0������ $	 TE.BgWindow1�.+��� $��12(�$1��+Resources/Fonts/Gravity-Regular.ttf#Gravity)�$��Center=�$��0,3,0,0q����� $&	  HomeViewModel.Media.SourceString����� $	 
TE.FgTitle��� $.��(Resources/Fonts/Gravity-Bold.ttf#Gravity)�$��17(�$��Center=�$��Center=�$��0,0,0,0q����� $	 TE.Title����� $	 
TE.FgTitle��� -   $��20��$
��auto��$��Right=�$	��Top=�$��0,0,20,0q�#��[" �.���� ���� $	 	TE.ImgBar��� -   $��20��$
��auto��$��Right=�$	��Top=�#��[" �.���� ���� $	 TE.ImgClose�� -   $��1������ $	 TE.BgWindow2�.+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��Center=�$��	40,3,40,0q�$��15(�$.��(Resources/Fonts/Gravity-Book.ttf#Gravity)�#��[" ����� $	 TE.ChangeTheme����� $	 TE.BgButton����� $	 TE.FgButton�� -   $��2������ $	 TE.BgWindow3�.+��� $ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��Center=�$��	20,3,20,0q�$��15(�$.��(Resources/Fonts/Gravity-Book.ttf#Gravity)�#��[" ����� $	 TE.Music����� $	 TE.BgButton����� $	 TE.FgButton� � ContextMenu �� .@�m� -	   $��Select the directory�� m� Icon �� $'��!Resources/Images/reload-black.png��$��32��$
��auto��m� -
   $$��Do a custom search by filename�� �� $'��!Resources/Images/search-black.png��$��32��$
��auto��m� -   $"��Do a custom search by author�� �� $'��!Resources/Images/search-black.png��$��32��$
��auto��m� -   $!��Do a custom search by album�� �� $'��!Resources/Images/search-black.png��$��32��$
��auto���� -   $��Center=�$��	20,3,20,0q�$��15(�$.��(Resources/Fonts/Gravity-Book.ttf#Gravity)�#��[" ����� $	 TE.Video����� $	 TE.BgButton����� $	 TE.FgButton� �� .@�m� -   $��Select the directory�� �� $'��!Resources/Images/reload-black.png��$��32��$
��auto��m� -   $$��Do a custom search by filename�� �� $'��!Resources/Images/search-black.png��$��32��$
��auto���� -   $��Center=�$��	20,3,20,0q�$��15(�$.��(Resources/Fonts/Gravity-Book.ttf#Gravity)�#��[" ����� $	 TE.Image����� $	 TE.BgButton����� $	 TE.FgButton� �� .@�m� -   $��Select the directory�� �� $'��!Resources/Images/reload-black.png��$��32��$
��auto��m� -   $$��Do a custom search by filename�� �� $'��!Resources/Images/search-black.png��$��32��$
��auto���� -   $��Center=�$��	20,3,20,0q�$��15(�$.��(Resources/Fonts/Gravity-Book.ttf#Gravity)�#��[" ����� $	 TE.Playlist����� $	 TE.BgButton����� $	 TE.FgButton� �� .@�m� -   $%��Add current media to a playlist�� �� $%��Resources/Images/plus-black.png��$��32��$
��auto��� $��3��
 �� $	��60* ��� $��2* ��� $��4* �.+�� -   $��0�� J� 	AllowDrop . ���� $	 TE.BgWindow4� �� .@�m� -   $��Change opacity�� �� $'��!Resources/Images/pencil-black.png��$��32��$
��auto��m� -   $��Change speed ratio�� �� $'��!Resources/Images/pencil-black.png��$��32��$
��auto��.+�r� -   $��Media�� r� UnloadedBehavior$ Close=� r� 
SpeedRatio$ 1Q�  r� Source  �� $ 	 HomeViewModel.Media.Source�$ TwoWay=�! r� LoadedBehavior! �� $	 HomeViewModel.Media.State�$ TwoWay=�" J� Opacity" �� $!	 HomeViewModel.Media.Opacity��� -   $��Progress��$��40(�
�������$��Center=�$��Center=����� $"	 HomeViewModel.Media.Progress��� $��Center=�$��Center=�$	��150��$
��auto������ $	 
TE.ImgLogo�y��� $"	 HomeViewModel.PlayVisibility��� -   $��	ListMusic��$y�	Collapsed=�#��[ # �� View# �� !$ �� ColumnHeaderContainerStyle#$ [ .P��� % �� Width$	% 300������ $	 TE.ListMusicFilename�& �� DisplayMemberBinding& �� $	 Filename��� $	% 300������ $	 TE.ListMusicTitle�& �� $	 Title��� $	% 200������ $	 TE.ListMusicAlbum�& �� $	 Album��� $	% 200������ $	 TE.ListMusicAuthor�& �� $	 Author��� $	% 150������ $	 TE.ListMusicLength�& �� $	 Length� �� .@�m� -   $%��Add this media(s) to a playlist�� �� $%��Resources/Images/plus-black.png��$��32��$
��auto������ " ��' �� BasedOn#' [ .�-   �� -   $��	ListVideo��$y�	Collapsed=�#��[ # �� #$ [ .P��� $	% 200������ $	 TE.ListVideoFilename�& �� *
Filename+�� $	% 150������ $	 TE.ListVideoHeight�& �� *Height+�� $	% 150������ $	 TE.ListVideoWidth�& �� *Width+�� $	% 150������ $	 TE.ListVideoLength�& �� *Length+ �� .@�m� -   $%��Add this media(s) to a playlist�� �� $%��Resources/Images/plus-black.png��$��32��$
��auto������ " ��#' [ .�-   �� -    $��	ListImage��$y�	Collapsed=�#��[ # �� #$ [ .P��� $	% 300������ $	 TE.ListImageFilename�& �� *
Filename+�� $	% 500������ $	 TE.ListImagePath�& �� *Path+ �� .@�m� -!   $��Create a diaporama�� �� $%��Resources/Images/plus-black.png��$��32��$
��auto������ " ��#' [ .�-"   R� -#   $��TreePlaylist��$��Right=�$	��100��$y�	Collapsed=�#��[  ( �� DataType  MyWMPv2.Model.MyPlaylist) �� ItemsSource* m� CommandParameter+ �� RelativeSource  MyWMPv2.Model.MyMedia, m� Command��%�  (��       *, +)(�� �    *, +)�� "(  ) �� *Medias+.R��� ���� *Name+ �� .@�m� -$   $��Start the playlist��* �� + �� *Self+$	 Parent� �� $%��Resources/Images/play-black.png��$��32��$
��auto��m� -%   $"��Start the playlist in random��* �� + �� *Self+$	 Parent� �� $%��Resources/Images/play-black.png��$��32��$
��auto��m� -&   $��Rename the playlist��* �� + �� *Self+$	 Parent� �� $'��!Resources/Images/pencil-black.png��$��32��$
��auto��m� -'   $��Delete the playlist��* �� + �� *Self+$	 Parent� �� $"��Resources/Images/x-black.png��$��32��$
��auto���� "(  .R��� $ 
Horizontal=�.+��� ���� *Name+ �� .@�m� $��	MediaItem��$��Delete from playlist��, �� $	 DeleteSelfCommand�* �� $	 PlaylistPath� �� $"��Resources/Images/x-black.png��$��32��$
��auto������ " Q�#' [	 .�-(   � $��1������ $	 TE.BgWindow5�.+��� -)   - ��Name$- SliderMedia��$��Stretch=�$��Center=�. � Minimum$. 0Q�#��[ � $��2������ $	 TE.BgWindow6�.+��� $ 
Horizontal=�$��Center=� ��%Z   '��       '�� #     �� " ��.���  � ��$ 50���� " ��.���  � ��$ 60��.+��� $��Center=�$.��(Resources/Fonts/Gravity-Book.ttf#Gravity)����� $"	 HomeViewModel.Media.Position����� $	 
TE.FgTitle��� $��Center=�$.��(Resources/Fonts/Gravity-Book.ttf#Gravity)����� $%	 HomeViewModel.Media.PositionMax����� $	 
TE.FgTitle��� $" 0Q�$��10���� #��[" ����� $&	  HomeViewModel.MediaRepeatCommand�y��� $&	  HomeViewModel.NoRepeatVisibility�.���� ���� $	 TE.ImgLoop1��� #��[" ����� $&	  HomeViewModel.MediaRepeatCommand�y��� $$	 HomeViewModel.RepeatVisibility�.���� ���� $	 TE.ImgLoop2��� #��[" ����� $$	 HomeViewModel.MediaOpenCommand� �� .@�m� -*   $��Open youtube video�� �� $&�� Resources/Images/youtube-ico.png��$��32��$
��auto��.���� ���� $	 
TE.ImgOpen��� $" 0Q�$��30���� #��[" ����� $$	 HomeViewModel.MediaPrevCommand�y��� $&	  HomeViewModel.PlaylistVisibility�.���� ���� $	 
TE.ImgPrev��� #��[" ����� $$	 HomeViewModel.MediaStopCommand�.���� ���� $	 
TE.ImgStop��� #��[" ����� $$	 HomeViewModel.MediaPlayCommand�y��� $"	 HomeViewModel.PlayVisibility�.���� ���� $	 
TE.ImgPlay��� #��[" ����� $%	 HomeViewModel.MediaPauseCommand�y��� $#	 HomeViewModel.PauseVisibility�.���� ���� $	 TE.ImgPause��� #��[" ����� $$	 HomeViewModel.MediaNextCommand�y��� $&	  HomeViewModel.PlaylistVisibility�.���� ���� $	 
TE.ImgNext��� $" 0Q�$��60���� -+   $- SliderVolume��$��Center=�$	��125��$. 0Q�/ � Maximum$/ 1Q�0 � Value$	0 0.5Q�#��[ �� $" 0Q�$��50��