---
title: "Command Flag Element"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "CommandFlag element (VSCT XML schema)"
  - "VSCT XML schema elements, CommandFlag"
ms.assetid: 5ef63399-d2db-4dc1-97ce-be1bd4ef4e39
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Command Flag Element
Modifies its parent element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following section describes valid element values.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Value|Description|  
|-----------|-----------------|  
|AllowParams|Indicates that users can enter command parameters in the **Command** window when they type the canonical name of the command.\<br />\<br /> Valid for: <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|  
|AlwaysCreate|Menu is created even if it has no groups or buttons.\<br />\<br /> Valid for: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|CaseSensitive|User entries are case-sensitive.\<br />\<br /> Valid for: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|CommandWellOnly|Apply this flag if the command does not appear on the top-level menu and you want to make it available for additional shell customization, for example, for binding it to a keyboard shortcut. After the VSPackage is installed, you can customize these commands by opening the **Options** dialog box and then editing the command placement under the **Keyboard Environment** category. This flag does not affect placement on shortcut menus, toolbars, menu controllers, or submenus.\<br />\<br /> Valid for: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|DefaultDisabled|By default, the command is disabled if the VSPackage that implements it is not loaded or the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method has not been called.\<br />\<br /> Valid for: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|DefaultDocked|Docked by default. This setting no longer applies to toolbars because they are always docked.|  
|DefaultInvisible|By default, the command is invisible if the VSPackage that implements it is not loaded or the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method has not been called.\<br />\<br /> We recommend that you combine this with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> flag.\<br />\<br /> Valid for: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|DontCache|The development environment does not cache the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method results for this command.\<br />\<br /> For a menu, this tells a menu controller not to cache the text of its menu items. Use this flag when the menu contains dynamic items or items that have dynamic text.\<br />\<br /> Valid for: <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|DynamicItemStart|Indicates the beginning of a dynamic list. This enables the environment to build a list by successively calling the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method on list items until the OLECMDERR_E_UNSUPPORTED flag is returned. This works well for items such as most recently used (MRU) lists and window lists.\<br />\<br /> Valid for: <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|DynamicVisibility|The visibility of the command can be changed through the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method or through a context GUID that is included in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> section.\<br />\<br /> Applies to commands that appear on menus and tool window toolbars, but not on top-level toolbars that appear on the main window. Top-level toolbar items can be disabled but not hidden, when the OLECMDF_INVISIBLE flag is returned from the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method. Toolbar commands that appear on tool window toolbars can be hidden.\<br />\<br /> On a menu, this flag also indicates that it should be automatically hidden when all its members are hidden. This flag is typically assigned to submenus because top-level menus already have this behavior.\<br />\<br /> This flag should be combined with the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> flag.\<br />\<br /> Valid for: <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|FilterKeys|See the Filtering Keys topic under [Combo](../vs140/combo-element.md).\<br />\<br /> Valid for: <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|FixMenuController|If this command is positioned on a menu controller, the command is always the default; that is, the command is selected whenever the menu controller button itself is selected. If the menu controller has the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> flag set, then the menu controller also takes its text from the command that has the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> flag.\<br />\<br /> Only one command on a menu controller should have the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> flag. If more than one command is so marked, the last command in the menu becomes the default command.\<br />\<br /> Valid for: <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|IconAndText|Show an icon and text on menu and toolbar.\<br />\<br /> Valid for: <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|NoAutoComplete|Auto-complete feature is disabled.\<br />\<br /> Valid for: <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|NoButtonCustomize|Do not let the user customize this button.\<br />\<br /> Valid for: <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|NoKeyCustomize|Do not enable keyboard customization.\<br />\<br /> Valid for: <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|NoShowOnMenuController|If this command is positioned on a menu controller, the command does not appear in the drop-down list.\<br />\<br /> Valid for: <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|NotInTBList|Does not appear in the list of available toolbars. This is valid only for Toolbar menu types.\<br />\<br /> Valid for: <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|NoToolbarClose|User cannot close the toolbar. This is valid only for Toolbar menu types.\<br />\<br /> Valid for: <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
|Pict|Show only an icon on a toolbar, but only text on a menu. If no icon is specified, shows a clickable blank space on a toolbar.\<br />\<br /> Valid for: <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
|PostExec|Makes the command non-blocking. The development environment defers execution until all pre-processing queries are completed.\<br />\<br /> Valid for: <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|RouteToDocs|The command is routed to the active document.\<br />\<br /> Valid for: <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|StretchHorizontally|When this flag is set, the width becomes the minimum width for the combo box, and if there is room on the toolbar, the combo box stretches to fill available space. This occurs only if the toolbar is horizontally docked, and only one combo box on the toolbar can use the flag (the flag is ignored on all except the first combo box).\<br />\<br /> Valid for: <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|TextMenuUseButton|Use the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> field for menus. The default field is <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> if it is specified.\<br />\<br /> Valid for: <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|TextChanges|The command or menu text can be changed at run time, typically through the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> method.\<br />\<br /> Valid for: <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
|TextChangesButton|Valid for: <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|TextIsAnchorCommand|For a menu controller, the text of the menu is taken from the default (anchor) command. An anchor command is the last command selected or latched. If this flag is not set, the menu controller uses its own <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> field. However, clicking the menu controller still enables the last selected command from that controller.\<br />\<br /> We recommend that you combine this flag with the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> flag.\<br />\<br /> This flag applies only to menus of type MenuController or MenuControllerLatched.\<br />\<br /> Valid for: <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
|TextMenuCtrlUseMenu|Use the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> field on menu controllers. The default field is <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.\<br />\<br /> Valid for: <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|TextMenuUseButton|Use the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> field for menus. The default field is <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> if it is specified.\<br />\<br /> Valid for: <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
|TextOnly|Show only text on a toolbar or a menu but no icon even if the icon is specified.\<br />\<br /> Valid for: <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Buttons](../vs140/buttons-element.md)|Provides a group for [Button](../vs140/button-element.md) elements.|  
|[Menus](../vs140/menus-element.md)|Defines all the menus that a VSPackage implements.|  
  
## See Also  
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)