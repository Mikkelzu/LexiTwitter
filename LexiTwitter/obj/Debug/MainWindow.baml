   M S B A M L   `   `   `  ����F  BLexiTwitter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LexiTwitterLexiTwitter  5   	       LexiTwitter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LexiTwitter     5   	     � Title$  
MainWindow��5   	   $��453.387��6   $��714.894��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ TextBoxNewTweet��5
      $
��Left=�6+   $��23��6F   $��	40,28,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��208��6�   �� 5   
   -   5         ��Name$ ButtonSendTweet��5      $��
SendTweet!��6*   $
��Left=�6?   $��
253,31,0,0q�6Z   $	��Top=�6n   $��75��6�   6�   �� 5   
   -   5        $ ButtonReTweet��5      $��Retweet��6(   $
��Left=�6:   $��565,370,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5         ��Name$ 
viewtweets��5      $
��Left=�6'   $	��256��6B   $��	40,89,0,0q�6O   $	��Top=�6b   $	��618��6z    �� View 5      �� 5      .P�5      �� $��TweetID��6%    �� DisplayMemberBinding 66   ��  �� Path$ ID��� 5      $��Author��6%    65   �� $ Author��� 5      $��Tweet��6%    64   �� $ Tweet�5      5      5      5      