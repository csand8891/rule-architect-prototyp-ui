   M S B A M L   `   `   `  ����U  QRuleArchitect_UI_Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:RuleArchitect_UI_Prototype.Controls#RuleArchitect_UI_Prototype.Controls  5      >    8RuleArchitect_UI_Prototype.Controls.RulesheetCardControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:RuleArchitect_UI_Prototype.Controls     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $
��self��5	   7   .��5      #  MaterialDesignThemes.Wpf.Card  $	��350��6   $��8q�6&   $��0q�61       UniformCornerRadius$  8Q�6=   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�6U   .��5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6'      Mode$ 
PrimaryMid=�64   $
��12 8q�6F      CornerRadius$ 8,8,0,0��6U   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�5   .   $��0,0,8,0q�6I   $��20��6Z   $��20��6e      Kind 5   .   �� *HeaderIconKind+ �� ElementName$
 self�� �� FallbackValue$ FileDocumentOutline��5   e   �� 5       $   MaterialDesignSubtitle1TextBlock#��[  5       $��Medium"�5       $��CharacterEllipsis=�5       ��5       �� *
OptionName+$
 self��$ Rulesheet Name Here��5       5      5      �� 5      $��1��6   $
��Auto=�6(   $	��200��6K   .��5      �� $��16q�6   .+�5       ��    MaterialDesignBody2TextBlock#��[ 6    $
��Wrap=�6V   $��0,0,0,5q�6j   �� 5!      $��SemiBold"�6   $�Control Type:��64    �� 5"      �6   �� *ControlType+$
 self��$	 N/A��5#      �� 5%      #��[ 6    $
��Wrap=�6V   $��0,0,0,5q�6j   �� 5&      $��SemiBold"�6   $�	Option #:��64    �� 5'      �6   �� *PrimaryOptionNumberDisplay+$
 self��$	 N/A��5(      �� 5*      $��Spec Codes:��6    $��SemiBold"�63   #��[ 6I   $��0,8,0,2q�6   �� 5+      $
��Wrap=�5,       $��11(�64    " MaterialDesignCaptionTextBlock#��[ 5-       $��60��6X   $��CharacterEllipsis=�6g   ��5+       �� *SpecCodesSummary+$
 self��$ No spec codes defined.��5-   g   �� 5/      $��Activation Rule:��6    $��SemiBold"�68   #��[ 6N   $��0,8,0,2q�6�   �� 50      $
��Wrap=�51       $��11(�64   #��[ 52       $��60��6X   $��CharacterEllipsis=�6g   ��50       �� *ActivationRuleSummary+$
 self��$ No activation rules.��52   g   �� 54      $��Notes:��6    $��SemiBold"�6.   #��[ 6D   $��0,8,0,2q�6z   �� 55      $
��Wrap=�56       $��Italic$�64   $��10(�6G   #��[ 57       $��40��6X   $��CharacterEllipsis=�6g   ��55       �� *SoftwareOptionNotes+$
 self��$ 	No notes.��57   g   58      59      �� 5;      $��2��6     MaterialDesignDivider#���  6"   $��0,1,0,0q�6X   	 �� Padding$	 8q�6r   ._�5<      ��   MaterialDesignFlatButton#��[ 6   $��Right=�5?      ��5=      �� *ActionCommand+$
 self����5>      �� *ActionCommandParameter+$
 self����5@      �� *
ActionText+$
 self��$ VIEW DETAILS��5A      5B      5C      5D      