   M S B A M L   `   `   `  ����h  dValhCreationSuiteCharacterScheduleApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:ValhCreationSuiteCharacterScheduleApplication-ValhCreationSuiteCharacterScheduleApplication  5   	   >    8ValhCreationSuiteCharacterScheduleApplication.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Mlocal;clr-namespace:ValhCreationSuiteCharacterScheduleApplication     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��69* �6   �� 5      $
��131* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6   � 5      $ 	#FF6A83C5��6    � Offset$ 1Q�61   5      .+�5   
   �� -   5         ��Name$ InputSleepLocation��5      $
��Left=�6.   $��	278,8,0,0q�6I   $��input x,y,z��6\    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5   
   -   5         ��Name$ SleepLocationLabel��5      $
��Left=�60   $��
175,10,0,0q�6K   $��Sleep Location��6_   $
��Wrap=�6u   $	��Top=�6�   $��1��6�   �� 5   
   -   5        $ InputIdleLocation��5      $
��Left=�6-   $��
278,38,0,0q�6H   $��0.0, 0.0, 0.0��6\   $
 Wrap=�6q   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5   
   -   5        $ IdleLocationLabel��5      $
��Left=�6/   $��
175,38,0,0q�6J   $��Idle Location��6^   $
��Wrap=�6s   $	��Top=�6�   $��1��6�   �� 5   
   -   5        $ InputWorkLocation��5      $
��Left=�6-   $��
278,71,0,0q�6H   $��0.0, 0.0, 0.0��6\   $
 Wrap=�6q   $	��Top=�6�   $	��120��6�   $��1��6�   �� 5   
   -   5        $ WorklocationLabel��5      $
��Left=�6/   $��
175,73,0,0q�6J   $��Work Location��6^   $
��Wrap=�6s   $	��Top=�6�   $��1��6�   �� 5   
   -   5        	 ��Name$	 Guard��5      $��Guard��6    $
��Left=�60   $��175,105,0,0q�6K   $	��Top=�6`   $��1��6�   �� 5   
   -   5        $
	 Farm��5      $
��Farm��6   $
��Left=�6.   $��216,105,0,0q�6I   $	��Top=�6^   
 J� RenderTransformOrigin$
 0.566,-1.65&�6v   $��1��6�   �� 5   
   -	   5        $
	 Idle��5      $
��Idle��6   $��Center=�6.   $��	0,105,0,0q�6K   $	��Top=�6^   $��1��6�   �� 5   
   -
   5        $	 Hammer��5      $��Hammer��6!   $
��Left=�62   $��279,105,0,0q�6M   $	��Top=�6b   $��1��6�   �� 5   
   -   5        $
	 Monk��5      $
��Monk��6   $
��Left=�6.   $��334,105,0,0q�6I   $	��Top=�6^   $��1��6�   �� 5   
   -   5        $ CharacterNumber��5      $
��Left=�6+   $��
30,107,0,0q�6F   $��Input Char#��6Z   $ WrapWithOverflow=�6m   $	��Top=�6�   $��97��6�   �� 5    
   -   5        $	 NewScheduleButton��5       $��Change Character��6,   $
��Left=�6G   $��148,105,0,0q�6b   $	��Top=�6w   $
 0.307,0.198&�6�   �� 5!   
   -   5        $ 
HeaderInfo��5!      $
��Left=�6&   $��	30,10,0,0q�6A   $��Now Serving Character ###��6T   $ WrapWithOverflow=�6u   $	��Top=�6�   $	��167��6�   �� 5"   
   -   5        $ OccupationInfo��5"      $
��Left=�6*   $��	30,33,0,0q�6E   $��Occupation: ��6X   $ WrapWithOverflow=�6l   $	��Top=�6�   $	��120��6�   �� 5#   
   -   5        $	 ApplyChanges��5#      $��Apply Changes��6'   $��175,233,0,0q�6?   $��1��6o   $��20��6   $	��Top=�6�   $
��Left=�6�   $��83��6�   �� 5$   
   -   5        $ WorkWanderInput��5$      $
��Left=�6+   $��278,142,0,0q�6F   $��Wander��6[   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $��1��6�   �� 5%   
   -   5        $ WorkWanderLabel��5%      $
��Left=�6-   $��175,143,0,0q�6H   $��Wander Distance��6]   $
��Wrap=�6t   $	��Top=�6�   $��1��6�   �� 5&   
   -   5        $ Status��5&      $
��Left=�6$   $��
29,243,0,0q�6?   $��Status��6S   $��WrapWithOverflow=�6a   $	��Top=�6�   $��2��6�   $	��273��6�   �� 5'   
   -   5        $ OutputInput��5'      $
��Left=�6'   $��137,389,0,0q�6B   $$��\Users\13094\Desktop\Sched.txt��6W   $ WrapWithOverflow=�6}   $	��Top=�6�   $	��253��6�   $��2��6�   �� 5(   
   -   5        $ OutputLabel��5(      $
��Left=�6)   $��
29,391,0,0q�6D   $��Path and filename��6X   $
��Wrap=�6q   $	��Top=�6�   5*      5+      