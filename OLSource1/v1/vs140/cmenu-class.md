---
title: "CMenu Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HMENU"
  - "menus, class"
  - "menus, base class"
  - "menus, creating"
  - "menus, managing"
  - "CMenu class"
ms.assetid: 40cacfdc-d45c-4ec7-bf28-991c72812499
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu Class
An encapsulation of the Windows <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMenu::CMenu](#cmenu__cmenu)|Constructs a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMenu::AppendMenu](#cmenu__appendmenu)|Appends a new item to the end of this menu.|  
|[CMenu::Attach](#cmenu__attach)|Attaches a Windows menu handle to a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.|  
|[CMenu::CheckMenuItem](#cmenu__checkmenuitem)|Places a check mark next to or removes a check mark from a menu item in the pop-up menu.|  
|[CMenu::CheckMenuRadioItem](#cmenu__checkmenuradioitem)|Places a radio button next to a menu item and removes the radio button from all of the other menu items in the group.|  
|[CMenu::CreateMenu](#cmenu__createmenu)|Creates an empty menu and attaches it to a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.|  
|[CMenu::CreatePopupMenu](#cmenu__createpopupmenu)|Creates an empty pop-up menu and attaches it to a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
|[CMenu::DeleteMenu](#cmenu__deletemenu)|Deletes a specified item from the menu. If the menu item has an associated pop-up menu, destroys the handle to the pop-up menu and frees the memory used by it.|  
|[CMenu::DeleteTempMap](#cmenu__deletetempmap)|Deletes any temporary <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> objects created by the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> member function.|  
|[CMenu::DestroyMenu](#cmenu__destroymenu)|Destroys the menu attached to a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object and frees any memory that the menu occupied.|  
|[CMenu::Detach](#cmenu__detach)|Detaches a Windows menu handle from a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object and returns the handle.|  
|[CMenu::DrawItem](#cmenu__drawitem)|Called by the framework when a visual aspect of an owner-drawn menu changes.|  
|[CMenu::EnableMenuItem](#cmenu__enablemenuitem)|Enables, disables, or dims (grays) a menu item.|  
|[CMenu::FromHandle](#cmenu__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object given a Windows menu handle.|  
|[CMenu::GetDefaultItem](#cmenu__getdefaultitem)|Determines the default menu item on the specified menu.|  
|[CMenu::GetMenuContextHelpId](#cmenu__getmenucontexthelpid)|Retrieves the help context ID associated with the menu.|  
|[CMenu::GetMenuInfo](#cmenu__getmenuinfo)|Retrieves information on a specific menu.|  
|[CMenu::GetMenuItemCount](#cmenu__getmenuitemcount)|Determines the number of items in a pop-up or top-level menu.|  
|[CMenu::GetMenuItemID](#cmenu__getmenuitemid)|Obtains the menu-item identifier for a menu item located at the specified position.|  
|[CMenu::GetMenuItemInfo](#cmenu__getmenuiteminfo)|Retrieves information about a menu item.|  
|[CMenu::GetMenuState](#cmenu__getmenustate)|Returns the status of the specified menu item or the number of items in a pop-up menu.|  
|[CMenu::GetMenuString](#cmenu__getmenustring)|Retrieves the label of the specified menu item.|  
|[CMenu::GetSafeHmenu](#cmenu__getsafehmenu)|Returns the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> wrapped by this <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.|  
|[CMenu::GetSubMenu](#cmenu__getsubmenu)|Retrieves a pointer to a pop-up menu.|  
|[CMenu::InsertMenu](#cmenu__insertmenu)|Inserts a new menu item at the specified position, moving other items down the menu.|  
|[CMenu::InsertMenuItem](#cmenu__insertmenuitem)|Inserts a new menu item at the specified position in a menu.|  
|[CMenu::LoadMenu](#cmenu__loadmenu)|Loads a menu resource from the executable file and attaches it to a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.|  
|[CMenu::LoadMenuIndirect](#cmenu__loadmenuindirect)|Loads a menu from a menu template in memory and attaches it to a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object.|  
|[CMenu::MeasureItem](#cmenu__measureitem)|Called by the framework to determine menu dimensions when an owner-drawn menu is created.|  
|[CMenu::ModifyMenu](#cmenu__modifymenu)|Changes an existing menu item at the specified position.|  
|[CMenu::RemoveMenu](#cmenu__removemenu)|Deletes a menu item with an associated pop-up menu from the specified menu.|  
|[CMenu::SetDefaultItem](#cmenu__setdefaultitem)|Sets the default menu item for the specified menu.|  
|[CMenu::SetMenuContextHelpId](#cmenu__setmenucontexthelpid)|Sets the help context ID to be associated with the menu.|  
|[CMenu::SetMenuInfo](#cmenu__setmenuinfo)|Sets information on a specific menu.|  
|[CMenu::SetMenuItemBitmaps](#cmenu__setmenuitembitmaps)|Associates the specified check-mark bitmaps with a menu item.|  
|[CMenu::SetMenuItemInfo](#cmenu__setmenuiteminfo)|Changes information about a menu item.|  
|[CMenu::TrackPopupMenu](#cmenu__trackpopupmenu)|Displays a floating pop-up menu at the specified location and tracks the selection of items on the pop-up menu.|  
|[CMenu::TrackPopupMenuEx](#cmenu__trackpopupmenuex)|Displays a floating pop-up menu at the specified location and tracks the selection of items on the pop-up menu.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CMenu::operator HMENU](#cmenu__operator_hmenu)|Retrieves the handle of the menu object.|  
|[CMenu::operator !=](#cmenu__operator__neq)|Determines if two menu objects are not equal.|  
|[CMenu::operator ==](#cmenu__operator__eq_eq)|Determines if two menu objects are equal.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMenu::m_hMenu](#cmenu__m_hmenu)|Specifies the handle to the Windows menu attached to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 It provides member functions for creating, tracking, updating, and destroying a menu.  
  
 Create a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object on the stack frame as a local, then call <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>'s member functions to manipulate the new menu as needed. Next, call [CWnd::SetMenu](../vs140/cwnd-class.md#cwnd__setmenu) to set the menu to a window, followed immediately by a call to the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object's [Detach](#cmenu__detach) member function. The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> member function sets the window's menu to the new menu, causes the window to be redrawn to reflect the menu change, and also passes ownership of the menu to the window. The call to **Detach** detaches the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> from the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object, so that when the local <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> variable passes out of scope, the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object destructor does not attempt to destroy a menu it no longer owns. The menu itself is automatically destroyed when the window is destroyed.  
  
 You can use the [LoadMenuIndirect](#cmenu__loadmenuindirect) member function to create a menu from a template in memory, but a menu created from a resource by a call to [LoadMenu](#cmenu__loadmenu) is more easily maintained, and the menu resource itself can be created and modified by the menu editor.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cmenu__appendmenu">\</a>  CMenu::AppendMenu  
 Appends a new item to the end of a menu.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Specifies information about the state of the new menu item when it is added to the menu. It consists of one or more of the values listed in the Remarks section.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Specifies either the command ID of the new menu item or, if <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is set to **MF_POPUP**, the menu handle ( <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>) of a pop-up menu. The <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> parameter is ignored (not needed) if <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is set to **MF_SEPARATOR**.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Specifies the content of the new menu item. The <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> parameter is used to interpret <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> in the following way:  
  
|nFlags|Interpretation of lpszNewItem|  
|------------|-----------------------------------|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Contains an application-supplied 32-bit value that the application can use to maintain additional data associated with the menu item. This 32-bit value is available to the application when it processes <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> messages. The value is stored in the **itemData** member of the structure supplied with those messages.|  
|**MF_STRING**|Contains a pointer to a null-terminated string. This is the default interpretation.|  
|**MF_SEPARATOR**|The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> parameter is ignored (not needed).|  
  
 *pBmp*  
 Points to a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object that will be used as the menu item.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The application can specify the state of the menu item by setting values in <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> specifies a pop-up menu, it becomes part of the menu to which it is appended. If that menu is destroyed, the appended menu will also be destroyed. An appended menu should be detached from a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object to avoid conflict. Note that **MF_STRING** and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> are not valid for the bitmap version of <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
 The following list describes the flags that may be set in <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>:  
  
-   **MF_CHECKED** Acts as a toggle with **MF_UNCHECKED** to place the default check mark next to the item. When the application supplies check-mark bitmaps (see the [SetMenuItemBitmaps](#cmenu__setmenuitembitmaps) member function), the "check mark on" bitmap is displayed.  
  
-   **MF_UNCHECKED** Acts as a toggle with **MF_CHECKED** to remove a check mark next to the item. When the application supplies check-mark bitmaps (see the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> member function), the "check mark off" bitmap is displayed.  
  
-   **MF_DISABLED** Disables the menu item so that it cannot be selected but does not dim it.  
  
-   <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> Enables the menu item so that it can be selected and restores it from its dimmed state.  
  
-   **MF_GRAYED** Disables the menu item so that it cannot be selected and dims it.  
  
-   **MF_MENUBARBREAK** Places the item on a new line in static menus or in a new column in pop-up menus. The new pop-up menu column will be separated from the old column by a vertical dividing line.  
  
-   **MF_MENUBREAK** Places the item on a new line in static menus or in a new column in pop-up menus. No dividing line is placed between the columns.  
  
-   <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> Specifies that the item is an owner-draw item. When the menu is displayed for the first time, the window that owns the menu receives a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> message, which retrieves the height and width of the menu item. The <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> message is the one sent whenever the owner must update the visual appearance of the menu item. This option is not valid for a top-level menu item.  
  
-   **MF_POPUP** Specifies that the menu item has a pop-up menu associated with it. The ID parameter specifies a handle to a pop-up menu that is to be associated with the item. This is used for adding either a top-level pop-up menu or a hierarchical pop-up menu to a pop-up menu item.  
  
-   **MF_SEPARATOR** Draws a horizontal dividing line. Can only be used in a pop-up menu. This line cannot be dimmed, disabled, or highlighted. Other parameters are ignored.  
  
-   **MF_STRING** Specifies that the menu item is a character string.  
  
 Each of the following groups lists flags that are mutually exclusive and cannot be used together:  
  
-   **MF_DISABLED**, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, and **MF_GRAYED**  
  
-   **MF_STRING**, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, **MF_SEPARATOR**, and the bitmap version  
  
-   **MF_MENUBARBREAK** and **MF_MENUBREAK**  
  
-   **MF_CHECKED** and **MF_UNCHECKED**  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application should call [CWnd::DrawMenuBar](../vs140/cwnd-class.md#cwnd__drawmenubar).  
  
### Example  
  See the example for [CMenu::CreateMenu](#cmenu__createmenu).  
  
##  \<a name="cmenu__attach">\</a>  CMenu::Attach  
 Attaches an existing Windows menu to a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Specifies a handle to a Windows menu.  
  
### Return Value  
 Nonzero if the operation was successful; otherwise 0.  
  
### Remarks  
 This function should not be called if a menu is already attached to the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object. The menu handle is stored in the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> data member.  
  
 If the menu you want to manipulate is already associated with a window, you can use the [CWnd::GetMenu](../vs140/cwnd-class.md#cwnd__getmenu) function to get a handle to the menu.  
  
### Example  
 [!code[NVC_MFCWindowing#21](../vs140/codesnippet/CPP/cmenu-class_1.cpp)]  
  
##  \<a name="cmenu__checkmenuitem">\</a>  CMenu::CheckMenuItem  
 Adds check marks to or removes check marks from menu items in the pop-up menu.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 Specifies the menu item to be checked, as determined by <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Specifies how to check the menu item and how to determine the item's position in the menu. The <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> parameter can be a combination of **MF_CHECKED** or **MF_UNCHECKED** with **MF_BYPOSITION** or **MF_BYCOMMAND** flags. These flags can be combined by using the bitwise OR operator. They have the following meanings:  
  
-   **MF_BYCOMMAND** Specifies that the parameter gives the command ID of the existing menu item. This is the default.  
  
-   **MF_BYPOSITION** Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.  
  
-   **MF_CHECKED** Acts as a toggle with **MF_UNCHECKED** to place the default check mark next to the item.  
  
-   **MF_UNCHECKED** Acts as a toggle with **MF_CHECKED** to remove a check mark next to the item.  
  
### Return Value  
 The previous state of the item: **MF_CHECKED** or **MF_UNCHECKED**, or 0xFFFFFFFF if the menu item did not exist.  
  
### Remarks  
 The <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> parameter specifies the item to be modified.  
  
 The <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> parameter may identify a pop-up menu item as well as a menu item. No special steps are required to check a pop-up menu item. Top-level menu items cannot be checked. A pop-up menu item must be checked by position since it does not have a menu-item identifier associated with it.  
  
### Example  
  See the example for [CMenu::GetMenuState](#cmenu__getmenustate).  
  
##  \<a name="cmenu__checkmenuradioitem">\</a>  CMenu::CheckMenuRadioItem  
 Checks a specified menu item and makes it a radio item.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Specifies (as an ID or offset, depending on the value of <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>) the first menu item in the radio button group.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 Specifies (as an ID or offset, depending on the value of <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>) the last menu item in the radio button group.  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Specifies (as an ID or offset, depending on the value of <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>) the item in the group which will be checked with a radio button.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Specifies interpretation of <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> in the following way:  
  
|nFlags|Interpretation|  
|------------|--------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
### Return Value  
 Nonzero if successful; otherwise 0  
  
### Remarks  
 At the same time, the function unchecks all other menu items in the associated group and clears the radio-item type flag for those items. The checked item is displayed using a radio button (or bullet) bitmap instead of a check mark bitmap.  
  
### Example  
  See the example for [ON_COMMAND_RANGE](../vs140/on_command_range.md).  
  
##  \<a name="cmenu__cmenu">\</a>  CMenu::CMenu  
 Creates an empty menu and attaches it to a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The menu is not created until you call one of the create or load member functions of **CMenu:**  
  
-   [CreateMenu](#cmenu__createmenu)  
  
-   [CreatePopupMenu](#cmenu__createpopupmenu)  
  
-   [LoadMenu](#cmenu__loadmenu)  
  
-   [LoadMenuIndirect](#cmenu__loadmenuindirect)  
  
-   [Attach](#cmenu__attach)  
  
##  \<a name="cmenu__createmenu">\</a>  CMenu::CreateMenu  
 Creates a menu and attaches it to the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the menu was created successfully; otherwise 0.  
  
### Remarks  
 The menu is initially empty. Menu items can be added by using the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> member function.  
  
 If the menu is assigned to a window, it is automatically destroyed when the window is destroyed.  
  
 Before exiting, an application must free system resources associated with a menu if the menu is not assigned to a window. An application frees a menu by calling the [DestroyMenu](#cmenu__destroymenu) member function.  
  
### Example  
 [!code[NVC_MFCWindowing#22](../vs140/codesnippet/CPP/cmenu-class_2.cpp)]  
  
##  \<a name="cmenu__createpopupmenu">\</a>  CMenu::CreatePopupMenu  
 Creates a pop-up menu and attaches it to the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the pop-up menu was successfully created; otherwise 0.  
  
### Remarks  
 The menu is initially empty. Menu items can be added by using the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> member function. The application can add the pop-up menu to an existing menu or pop-up menu. The <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> member function may be used to display this menu as a floating pop-up menu and to track selections on the pop-up menu.  
  
 If the menu is assigned to a window, it is automatically destroyed when the window is destroyed. If the menu is added to an existing menu, it is automatically destroyed when that menu is destroyed.  
  
 Before exiting, an application must free system resources associated with a pop-up menu if the menu is not assigned to a window. An application frees a menu by calling the [DestroyMenu](#cmenu__destroymenu) member function.  
  
### Example  
  See the example for [CMenu::CreateMenu](#cmenu__createmenu).  
  
##  \<a name="cmenu__deletemenu">\</a>  CMenu::DeleteMenu  
 Deletes an item from the menu.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Specifies the menu item that is to be deleted, as determined by <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Is used to interpret <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> in the following way:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 If the menu item has an associated pop-up menu, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> destroys the handle to the pop-up menu and frees the memory used by the pop-up menu.  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application must call [CWnd::DrawMenuBar](../vs140/cwnd-class.md#cwnd__drawmenubar).  
  
### Example  
  See the example for [CWnd::GetMenu](../vs140/cwnd-class.md#cwnd__getmenu).  
  
##  \<a name="cmenu__deletetempmap">\</a>  CMenu::DeleteTempMap  
 Called automatically by the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> idle-time handler, deletes any temporary <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> objects created by the [FromHandle](#cmenu__fromhandle) member function.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> detaches the Windows menu object attached to a temporary <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object before deleting the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_MFCWindowing#23](../vs140/codesnippet/CPP/cmenu-class_3.cpp)]  
  
##  \<a name="cmenu__destroymenu">\</a>  CMenu::DestroyMenu  
 Destroys the menu and any Windows resources that were used.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the menu is destroyed; otherwise 0.  
  
### Remarks  
 The menu is detached from the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object before it is destroyed. The Windows <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> function is automatically called in the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> destructor.  
  
### Example  
  See the example for [CMenu::CreateMenu](#cmenu__createmenu).  
  
##  \<a name="cmenu__detach">\</a>  CMenu::Detach  
 Detaches a Windows menu from a <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object and returns the handle.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The handle, of type <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>, to a Windows menu, if successful; otherwise **NULL**.  
  
### Remarks  
 The <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> data member is set to **NULL**.  
  
### Example  
 [!code[NVC_MFCWindowing#21](../vs140/codesnippet/CPP/cmenu-class_1.cpp)]  
  
##  \<a name="cmenu__drawitem">\</a>  CMenu::DrawItem  
 Called by the framework when a visual aspect of an owner-drawn menu changes.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 A pointer to a [DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md) structure that contains information about the type of drawing required.  
  
### Remarks  
 The <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> structure defines the drawing action that is to be performed. Override this member function to implement drawing for an owner-draw <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> before the termination of this member function.  
  
 See [CWnd::OnDrawItem](../vs140/cwnd-class.md#cwnd__ondrawitem) for a description of the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> structure.  
  
### Example  
 The following code is from the MFC [CTRLTEST](../vs140/visual-c---samples.md) sample:  
  
 [!code[NVC_MFCWindowing#24](../vs140/codesnippet/CPP/cmenu-class_4.cpp)]  
  
##  \<a name="cmenu__enablemenuitem">\</a>  CMenu::EnableMenuItem  
 Enables, disables, or dims a menu item.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 *nIDEnableItem*  
 Specifies the menu item to be enabled, as determined by <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>. This parameter can specify pop-up menu items as well as standard menu items.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Specifies the action to take. It can be a combination of **MF_DISABLED**, <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>, or **MF_GRAYED**, with **MF_BYCOMMAND** or **MF_BYPOSITION**. These values can be combined by using the bitwise OR operator. These values have the following meanings:  
  
-   **MF_BYCOMMAND** Specifies that the parameter gives the command ID of the existing menu item. This is the default.  
  
-   **MF_BYPOSITION** Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.  
  
-   **MF_DISABLED** Disables the menu item so that it cannot be selected but does not dim it.  
  
-   <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> Enables the menu item so that it can be selected and restores it from its dimmed state.  
  
-   **MF_GRAYED** Disables the menu item so that it cannot be selected and dims it.  
  
### Return Value  
 Previous state ( **MF_DISABLED**, <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>, or **MF_GRAYED**) or –1 if not valid.  
  
### Remarks  
 The [CreateMenu](#cmenu__createmenu), [InsertMenu](#cmenu__insertmenu), [ModifyMenu](#cmenu__modifymenu), and [LoadMenuIndirect](#cmenu__loadmenuindirect) member functions can also set the state (enabled, disabled, or dimmed) of a menu item.  
  
 Using the **MF_BYPOSITION** value requires an application to use the correct <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> of the menu bar is used, a top-level menu item (an item in the menu bar) is affected. To set the state of an item in a pop-up or nested pop-up menu by position, an application must specify the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> of the pop-up menu.  
  
 When an application specifies the **MF_BYCOMMAND** flag, Windows checks all pop-up menu items that are subordinate to the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>; therefore, unless duplicate menu items are present, using the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> of the menu bar is sufficient.  
  
### Example  
 [!code[NVC_MFCWindowing#25](../vs140/codesnippet/CPP/cmenu-class_5.cpp)]  
  
##  \<a name="cmenu__fromhandle">\</a>  CMenu::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> object given a Windows handle to a menu.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 A Windows handle to a menu.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> that may be temporary or permanent.  
  
### Remarks  
 If a <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object is not already attached to the Windows menu object, a temporary <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> object is created and attached.  
  
 This temporary <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> object is only valid until the next time the application has idle time in its event loop, at which time all temporary objects are deleted.  
  
### Example  
  See the example for [CMenu::CreateMenu](#cmenu__createmenu).  
  
##  \<a name="cmenu__getdefaultitem">\</a>  CMenu::GetDefaultItem  
 Determines the default menu item on the specified menu.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *gmdiFlags*  
 Value specifying how the function searches for menu items. This parameter can be none, one, or a combination of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|**GMDI_GOINTOPOPUPS**|Specifies that, if the default item is one that opens a submenu, the function is to search in the corresponding submenu recursively. If the submenu has no default item, the return value identifies the item that opens the submenu.\<br />\<br /> By default, the function returns the first default item on the specified menu, regardless of whether it is an item that opens a submenu.|  
|**GMDI_USEDISABLED**|Specifies that the function is to return a default item, even if it is disabled.\<br />\<br /> By default, the function skips disabled or grayed items.|  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 Value specifying whether to retrieve the menu item's identifier or its position. If this parameter is **FALSE**, the identifier is returned. Otherwise, the position is returned.  
  
### Return Value  
 If the function succeeds, the return value is the identifier or position of the menu item. If the function fails, the return value is - 1.  
  
### Remarks  
 This member function implements the behavior of the Win32 function                         [GetMenuDefaultItem](http://msdn.microsoft.com/library/windows/desktop/ms647976), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [CMenu::InsertMenu](#cmenu__insertmenu).  
  
##  \<a name="cmenu__getmenucontexthelpid">\</a>  CMenu::GetMenuContextHelpId  
 Retrieves the context help ID associated with <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The context help ID currently associated with <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> if it has one; zero otherwise.  
  
### Example  
  See the example for [CMenu::InsertMenu](#cmenu__insertmenu).  
  
##  \<a name="cmenu__getmenuinfo">\</a>  CMenu::GetMenuInfo  
 Retrieves information for a menu.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 A pointer to a                                 [MENUINFO](http://msdn.microsoft.com/library/windows/desktop/ms647575) structure containing information for the menu.  
  
### Return Value  
 If the function succeeds, the return value is nonzero; otherwise, the return value is zero.  
  
### Remarks  
 Call this function to retrieve information about the menu.  
  
##  \<a name="cmenu__getmenuitemcount">\</a>  CMenu::GetMenuItemCount  
 Determines the number of items in a pop-up or top-level menu.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the menu if the function is successful; otherwise –1.  
  
### Example  
  See the example for [CWnd::GetMenu](../vs140/cwnd-class.md#cwnd__getmenu).  
  
##  \<a name="cmenu__getmenuitemid">\</a>  CMenu::GetMenuItemID  
 Obtains the menu-item identifier for a menu item located at the position defined by <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 Specifies the position (zero-based) of the menu item whose ID is being retrieved.  
  
### Return Value  
 The item ID for the specified item in a pop-up menu if the function is successful. If the specified item is a pop-up menu (as opposed to an item within the pop-up menu), the return value is –1. If <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> corresponds to a **SEPARATOR** menu item, the return value is 0.  
  
### Example  
  See the example for [CMenu::InsertMenu](#cmenu__insertmenu).  
  
##  \<a name="cmenu__getmenuiteminfo">\</a>  CMenu::GetMenuItemInfo  
 Retrieves information about a menu item.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 Identifier or position of the menu item to get information about. The meaning of this parameter depends on the value of <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 A pointer to a                                 [MENUITEMINFO](http://msdn.microsoft.com/library/windows/desktop/ms647578), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], that contains information about the menu.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 Value specifying the meaning of <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>. By default, <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> is **FALSE**, which indicates that uItem is a menu item identifier. If <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> is not set to **FALSE**, it indicates a menu item position.  
  
### Return Value  
 If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, use the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 This member function implements the behavior of the of the Win32 function                         [GetMenuItemInfo](http://msdn.microsoft.com/library/windows/desktop/ms647980), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Note that in the MFC implementation of <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>, you do not use a handle to a menu.  
  
### Example  
 [!code[NVC_MFCWindowing#26](../vs140/codesnippet/CPP/cmenu-class_6.cpp)]  
  
##  \<a name="cmenu__getmenustate">\</a>  CMenu::GetMenuState  
 Returns the status of the specified menu item or the number of items in a pop-up menu.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 Specifies the menu item ID, as determined by <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 Specifies the nature of <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>. It can be one of the following values:  
  
-   **MF_BYCOMMAND** Specifies that the parameter gives the command ID of the existing menu item. This is the default.  
  
-   **MF_BYPOSITION** Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.  
  
### Return Value  
 The value 0xFFFFFFFF if the specified item does not exist. If                         *nId* identifies a pop-up menu, the high-order byte contains the number of items in the pop-up menu and the low-order byte contains the menu flags associated with the pop-up menu. Otherwise the return value is a mask (Boolean OR) of the values from the following list (this mask describes the status of the menu item that                         *nId* identifies):  
  
-   **MF_CHECKED** Acts as a toggle with **MF_UNCHECKED** to place the default check mark next to the item. When the application supplies check-mark bitmaps (see the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> member function), the "check mark on" bitmap is displayed.  
  
-   **MF_DISABLED** Disables the menu item so that it cannot be selected but does not dim it.  
  
-   <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> Enables the menu item so that it can be selected and restores it from its dimmed state. Note that the value of this constant is 0; an application should not test against 0 for failure when using this value.  
  
-   **MF_GRAYED** Disables the menu item so that it cannot be selected and dims it.  
  
-   **MF_MENUBARBREAK** Places the item on a new line in static menus or in a new column in pop-up menus. The new pop-up menu column will be separated from the old column by a vertical dividing line.  
  
-   **MF_MENUBREAK** Places the item on a new line in static menus or in a new column in pop-up menus. No dividing line is placed between the columns.  
  
-   **MF_SEPARATOR** Draws a horizontal dividing line. Can only be used in a pop-up menu. This line cannot be dimmed, disabled, or highlighted. Other parameters are ignored.  
  
-   **MF_UNCHECKED** Acts as a toggle with **MF_CHECKED** to remove a check mark next to the item. When the application supplies check-mark bitmaps (see the <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> member function), the "check mark off" bitmap is displayed. Note that the value of this constant is 0; an application should not test against 0 for failure when using this value.  
  
### Example  
 [!code[NVC_MFCWindowing#27](../vs140/codesnippet/CPP/cmenu-class_7.cpp)]  
  
##  \<a name="cmenu__getmenustring">\</a>  CMenu::GetMenuString  
 Copies the label of the specified menu item to the specified buffer.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 Specifies the integer identifier of the menu item or the offset of the menu item in the menu, depending on the value of <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 Points to the buffer that is to receive the label.  
  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> object that is to receive the copied menu string.  
  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 Specifies the maximum length (in characters) of the label to be copied. If the label is longer than the maximum specified in <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>, the extra characters are truncated.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Specifies the interpretation of the <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> parameter. It can be one of the following values:  
  
|nFlags|Interpretation of nIDItem|  
|------------|-------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
### Return Value  
 Specifies the actual number of characters copied to the buffer, not including the null terminator.  
  
### Remarks  
 The <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> parameter should be one larger than the number of characters in the label to accommodate the null character that terminates a string.  
  
### Example  
  See the example for [CMenu::InsertMenu](#cmenu__insertmenu).  
  
##  \<a name="cmenu__getsafehmenu">\</a>  CMenu::GetSafeHmenu  
 Returns the <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> wrapped by this <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> object, or a **NULL**<CodeContentPlaceHolder>194\</CodeContentPlaceHolder> pointer.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Example  
  See the example for [CMenu::LoadMenu](#cmenu__loadmenu).  
  
##  \<a name="cmenu__getsubmenu">\</a>  CMenu::GetSubMenu  
 Retrieves the <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> object of a pop-up menu.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 Specifies the position of the pop-up menu contained in the menu. Position values start at 0 for the first menu item. The pop-up menu's identifier cannot be used in this function.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> object whose <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> member contains a handle to the pop-up menu if a pop-up menu exists at the given position; otherwise **NULL**. If a <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> object does not exist, then a temporary one is created. The <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> pointer returned should not be stored.  
  
### Example  
  See the example for [CMenu::TrackPopupMenu](#cmenu__trackpopupmenu).  
  
##  \<a name="cmenu__insertmenu">\</a>  CMenu::InsertMenu  
 Inserts a new menu item at the position specified by <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> and moves other items down the menu.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 Specifies the menu item before which the new menu item is to be inserted. The <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> parameter can be used to interpret <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> in the following ways:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0. If <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> is –1, the new menu item is appended to the end of the menu.|  
  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 Specifies how <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> is interpreted and specifies information about the state of the new menu item when it is added to the menu. For a list of the flags that may be set, see the [AppendMenu](#cmenu__appendmenu) member function. To specify more than one value, use the bitwise OR operator to combine them with the **MF_BYCOMMAND** or **MF_BYPOSITION** flag.  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 Specifies either the command ID of the new menu item or, if <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> is set to **MF_POPUP**, the menu handle ( <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>) of the pop-up menu. The <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> parameter is ignored (not needed) if <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> is set to **MF_SEPARATOR**.  
  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 Specifies the content of the new menu item. <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> can be used to interpret <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> in the following ways:  
  
|nFlags|Interpretation of lpszNewItem|  
|------------|-----------------------------------|  
|<CodeContentPlaceHolder>216\</CodeContentPlaceHolder>|Contains an application-supplied 32-bit value that the application can use to maintain additional data associated with the menu item. This 32-bit value is available to the application in the **itemData** member of the structure supplied by the                                                 [WM_MEASUREITEM](http://msdn.microsoft.com/library/windows/desktop/bb775925) and                                                 [WM_DRAWITEM](http://msdn.microsoft.com/library/windows/desktop/bb775923) messages. These messages are sent when the menu item is initially displayed or is changed.|  
|**MF_STRING**|Contains a long pointer to a null-terminated string. This is the default interpretation.|  
|**MF_SEPARATOR**|The <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> parameter is ignored (not needed).|  
  
 *pBmp*  
 Points to a <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> object that will be used as the menu item.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The application can specify the state of the menu item by setting values in <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>.  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application should call <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
 When <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> specifies a pop-up menu, it becomes part of the menu in which it is inserted. If that menu is destroyed, the inserted menu will also be destroyed. An inserted menu should be detached from a <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> object to avoid conflict.  
  
 If the active multiple document interface (MDI) child window is maximized and an application inserts a pop-up menu into the MDI application's menu by calling this function and specifying the **MF_BYPOSITION** flag, the menu is inserted one position farther left than expected. This happens because the Control menu of the active MDI child window is inserted into the first position of the MDI frame window's menu bar. To position the menu properly, the application must add 1 to the position value that would otherwise be used. An application can use the **WM_MDIGETACTIVE** message to determine whether the currently active child window is maximized.  
  
### Example  
 [!code[NVC_MFCWindowing#28](../vs140/codesnippet/CPP/cmenu-class_8.cpp)]  
  
##  \<a name="cmenu__insertmenuitem">\</a>  CMenu::InsertMenuItem  
 Inserts a new menu item at the specified position in a menu.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 See description of <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> in                                 [InsertMenuItem](http://msdn.microsoft.com/library/windows/desktop/ms647988) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 See description of <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> in **InsertMenuItem** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 See description of <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> in **InsertMenuItem** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 This function wraps                         [InsertMenuItem](http://msdn.microsoft.com/library/windows/desktop/ms647988), described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmenu__loadmenu">\</a>  CMenu::LoadMenu  
 Loads a menu resource from the application's executable file and attaches it to the <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 Points to a null-terminated string that contains the name of the menu resource to load.  
  
 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
 Specifies the menu ID of the menu resource to load.  
  
### Return Value  
 Nonzero if the menu resource was loaded successfully; otherwise 0.  
  
### Remarks  
 Before exiting, an application must free system resources associated with a menu if the menu is not assigned to a window. An application frees a menu by calling the [DestroyMenu](#cmenu__destroymenu) member function.  
  
### Example  
 [!code[NVC_MFCWindowing#29](../vs140/codesnippet/CPP/cmenu-class_9.cpp)]  
  
##  \<a name="cmenu__loadmenuindirect">\</a>  CMenu::LoadMenuIndirect  
 Loads a resource from a menu template in memory and attaches it to the <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 *lpMenuTemplate*  
 Points to a menu template (which is a single                                 [MENUITEMTEMPLATEHEADER](http://msdn.microsoft.com/library/windows/desktop/ms647583) structure and a collection of one or more                                 [MENUITEMTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms647581) structures). For more information on these two structures, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Nonzero if the menu resource was loaded successfully; otherwise 0.  
  
### Remarks  
 A menu template is a header followed by a collection of one or more                         [MENUITEMTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms647581) structures, each of which may contain one or more menu items and pop-up menus.  
  
 The version number should be 0.  
  
 The **mtOption** flags should include **MF_END** for the last item in a pop-up list and for the last item in the main list. See the <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> member function for other flags. The **mtId** member must be omitted from the **MENUITEMTEMPLATE** structure when **MF_POPUP** is specified in **mtOption**.  
  
 The space allocated for the **MENUITEMTEMPLATE** structure must be large enough for **mtString** to contain the name of the menu item as a null-terminated string.  
  
 Before exiting, an application must free system resources associated with a menu if the menu is not assigned to a window. An application frees a menu by calling the [DestroyMenu](#cmenu__destroymenu) member function.  
  
### Example  
 [!code[NVC_MFCWindowing#30](../vs140/codesnippet/CPP/cmenu-class_10.cpp)]  
  
##  \<a name="cmenu__m_hmenu">\</a>  CMenu::m_hMenu  
 Specifies the <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> handle of the Windows menu attached to the <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Example  
  See the example for [CMenu::LoadMenu](#cmenu__loadmenu).  
  
##  \<a name="cmenu__measureitem">\</a>  CMenu::MeasureItem  
 Called by the framework when a menu with the owner-draw style is created.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> structure.  
  
### Remarks  
 By default, this member function does nothing. Override this member function and fill in the <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> structure to inform Windows of the menu's dimensions.  
  
 See [CWnd::OnMeasureItem](../vs140/cwnd-class.md#cwnd__onmeasureitem) for a description of the <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> structure.  
  
### Example  
 The following code is from the MFC [CTRLTEST](../vs140/visual-c---samples.md) sample:  
  
 [!code[NVC_MFCWindowing#31](../vs140/codesnippet/CPP/cmenu-class_11.cpp)]  
  
##  \<a name="cmenu__modifymenu">\</a>  CMenu::ModifyMenu  
 Changes an existing menu item at the position specified by <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 Specifies the menu item to be changed. The <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> parameter can be used to interpret <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> in the following ways:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 Specifies how <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> is interpreted and gives information about the changes to be made to the menu item. For a list of flags that may be set, see the [AppendMenu](#cmenu__appendmenu) member function.  
  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 Specifies either the command ID of the modified menu item or, if <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> is set to **MF_POPUP**, the menu handle ( <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>) of a pop-up menu. The <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> parameter is ignored (not needed) if <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> is set to **MF_SEPARATOR**.  
  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 Specifies the content of the new menu item. The <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> parameter can be used to interpret <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> in the following ways:  
  
|nFlags|Interpretation of lpszNewItem|  
|------------|-----------------------------------|  
|<CodeContentPlaceHolder>254\</CodeContentPlaceHolder>|Contains an application-supplied 32-bit value that the application can use to maintain additional data associated with the menu item. This 32-bit value is available to the application when it processes **MF_MEASUREITEM** and **MF_DRAWITEM**.|  
|**MF_STRING**|Contains a long pointer to a null-terminated string or to a <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>.|  
|**MF_SEPARATOR**|The <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> parameter is ignored (not needed).|  
  
 *pBmp*  
 Points to a <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> object that will be used as the menu item.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The application specifies the new state of the menu item by setting values in <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>. If this function replaces a pop-up menu associated with the menu item, it destroys the old pop-up menu and frees the memory used by the pop-up menu.  
  
 When <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> specifies a pop-up menu, it becomes part of the menu in which it is inserted. If that menu is destroyed, the inserted menu will also be destroyed. An inserted menu should be detached from a <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> object to avoid conflict.  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application should call <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>. To change the attributes of existing menu items, it is much faster to use the <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> member functions.  
  
### Example  
  See the example for [CMenu::InsertMenu](#cmenu__insertmenu).  
  
##  \<a name="cmenu__operator_hmenu">\</a>  CMenu::operator HMENU  
 Use this operator to retrieve the handle of the <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 If successful, the handle of the <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> object; otherwise, **NULL**.  
  
### Remarks  
 You can use the handle to call Windows APIs directly.  
  
##  \<a name="cmenu__operator__neq">\</a>  CMenu::operator !=  
 Determines if two menus are logically not equal.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> object for comparison.  
  
### Remarks  
 Tests if a menu object on the left side is not equal to a menu object on the right side.  
  
##  \<a name="cmenu__operator__eq_eq">\</a>  CMenu::operator ==  
 Determines if two menus are logically equal.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> object for comparison.  
  
### Remarks  
 Tests if a menu object on the left side is equal (in terms of the <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> value) to a menu object on the right side.  
  
##  \<a name="cmenu__removemenu">\</a>  CMenu::RemoveMenu  
 Deletes a menu item with an associated pop-up menu from the menu.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 Specifies the menu item to be removed. The <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> parameter can be used to interpret <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> in the following ways:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 Specifies how <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> is interpreted.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 It does not destroy the handle for a pop-up menu, so the menu can be reused. Before calling this function, the application may call the <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> member function to retrieve the pop-up <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> object for reuse.  
  
 Whenever a menu that resides in a window is changed (whether or not the window is displayed), the application must call <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CMenu::InsertMenu](#cmenu__insertmenu).  
  
##  \<a name="cmenu__setdefaultitem">\</a>  CMenu::SetDefaultItem  
 Sets the default menu item for the specified menu.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 Identifier or position of the new default menu item or - 1 for no default item. The meaning of this parameter depends on the value of <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 Value specifying the meaning of <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>. If this parameter is **FALSE**, <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> is a menu item identifier. Otherwise, it is a menu item position.  
  
### Return Value  
 If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, use the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 This member function implements the behavior of the Win32 function                         [SetMenuDefaultItem](http://msdn.microsoft.com/library/windows/desktop/ms647996), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [CMenu::InsertMenu](#cmenu__insertmenu).  
  
##  \<a name="cmenu__setmenucontexthelpid">\</a>  CMenu::SetMenuContextHelpId  
 Associates a context help ID with <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 Context help ID to associate with <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise 0  
  
### Remarks  
 All items in the menu share this identifier — it is not possible to attach a help context identifier to the individual menu items.  
  
### Example  
  See the example for [CMenu::InsertMenu](#cmenu__insertmenu).  
  
##  \<a name="cmenu__setmenuinfo">\</a>  CMenu::SetMenuInfo  
 Sets information for a menu.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 A pointer to a                                 [MENUINFO](http://msdn.microsoft.com/library/windows/desktop/ms647575) structure containing information for the menu.  
  
### Return Value  
 If the function succeeds, the return value is nonzero; otherwise, the return value is zero.  
  
### Remarks  
 Call this function to set specific information about the menu.  
  
##  \<a name="cmenu__setmenuitembitmaps">\</a>  CMenu::SetMenuItemBitmaps  
 Associates the specified bitmaps with a menu item.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 Specifies the menu item to be changed. The <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> parameter can be used to interpret <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> in the following ways:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
 <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 Specifies how <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> is interpreted.  
  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 Specifies the bitmap to use for menu items that are not checked.  
  
 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 Specifies the bitmap to use for menu items that are checked.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 Whether the menu item is checked or unchecked, Windows displays the appropriate bitmap next to the menu item.  
  
 If either <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> is **NULL**, then Windows displays nothing next to the menu item for the corresponding attribute. If both parameters are **NULL**, Windows uses the default check mark when the item is checked and removes the check mark when the item is unchecked.  
  
 When the menu is destroyed, these bitmaps are not destroyed; the application must destroy them.  
  
 The Windows **GetMenuCheckMarkDimensions** function retrieves the dimensions of the default check mark used for menu items. The application uses these values to determine the appropriate size for the bitmaps supplied with this function. Get the size, create your bitmaps, and then set them.  
  
### Example  
 [!code[NVC_MFCWindowing#32](../vs140/codesnippet/CPP/cmenu-class_12.cpp)]  
  
 [!code[NVC_MFCWindowing#33](../vs140/codesnippet/CPP/cmenu-class_13.cpp)]  
  
##  \<a name="cmenu__setmenuiteminfo">\</a>  CMenu::SetMenuItemInfo  
 Changes information about a menu item.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
 See description of <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> in                                 [SetMenuItemInfo](http://msdn.microsoft.com/library/windows/desktop/ms648001) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 See description of <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> in **SetMenuItemInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 See description of <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> in **SetMenuItemInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 This function wraps                         [SetMenuItemInfo](http://msdn.microsoft.com/library/windows/desktop/ms648001), described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmenu__trackpopupmenu">\</a>  CMenu::TrackPopupMenu  
 Displays a floating pop-up menu at the specified location and tracks the selection of items on the pop-up menu.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 Specifies screen-position and mouse-position flags. See                                 [TrackPopupMenu](http://msdn.microsoft.com/library/windows/desktop/ms648002) for a list of available flags.  
  
 *x*  
 Specifies the horizontal position in screen coordinates of the pop-up menu. Depending on the value of the <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> parameter, the menu can be left-aligned, right-aligned, or centered relative to this position.  
  
 *y*  
 Specifies the vertical position in screen coordinates of the top of the menu on the screen.  
  
 <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
 Identifies the window that owns the pop-up menu. This parameter cannot be **NULL**, even if the **TPM_NONOTIFY** flag is specified. This window receives all **WM_COMMAND** messages from the menu. In Windows versions 3.1 and later, the window does not receive **WM_COMMAND** messages until <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> returns. In Windows 3.0, the window receives **WM_COMMAND** messages before <CodeContentPlaceHolder>307\</CodeContentPlaceHolder> returns.  
  
 <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 Ignored.  
  
### Return Value  
 This method returns the result of calling                         [TrackPopupMenu](http://msdn.microsoft.com/library/windows/desktop/ms648002) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 A floating pop-up menu can appear anywhere on the screen.  
  
### Example  
 [!code[NVC_MFCWindowing#34](../vs140/codesnippet/CPP/cmenu-class_14.cpp)]  
  
##  \<a name="cmenu__trackpopupmenuex">\</a>  CMenu::TrackPopupMenuEx  
 Displays a floating pop-up menu at the specified location and tracks the selection of items on the pop-up menu.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 Specifies various functions for the extended menu. For a listing of all values and their meaning, see                                 [TrackPopupMenuEx](http://msdn.microsoft.com/library/windows/desktop/ms648003).  
  
 *x*  
 Specifies the horizontal position in screen coordinates of the pop-up menu.  
  
 *y*  
 Specifies the vertical position in screen coordinates of the top of the menu on the screen.  
  
 <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 A pointer to the window owning the pop-up menu and receiving the messages from the created menu. This window can be any window from the current application but cannot be **NULL**. If you specify **TPM_NONOTIFY** in the <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> parameter, the function does not send any messages to <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>. The function must return for the window pointed to by <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> to receive the **WM_COMMAND** message.  
  
 *lptpm*  
 Pointer to a                                 [TPMPARAMS](http://msdn.microsoft.com/library/windows/desktop/ms647586) structure that specifies an area of the screen the menu should not overlap. This parameter can be **NULL**.  
  
### Return Value  
 If you specify **TPM_RETURNCMD** in the <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> parameter, the return value is the menu-item identifier of the item that the user selected. If the user cancels the menu without making a selection, or if an error occurs, then the return value is 0.  
  
 If you do not specify **TPM_RETURNCMD** in the <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> parameter, the return value is nonzero if the function succeeds and 0 if it fails. To get extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 A floating pop-up menu can appear anywhere on the screen. For more information on handling errors when creating the pop-up menu, see                         [TrackPopupMenuEx](http://msdn.microsoft.com/library/windows/desktop/ms648003).  
  
## See Also  
 [MFC Sample CTRLTEST](../vs140/visual-c---samples.md)   
 [MFC Sample DYNAMENU](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject](../vs140/cobject-class.md)