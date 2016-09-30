---
title: "CMFCMenuBar Class"
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
  - "CMFCMenuBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCMenuBar class"
ms.assetid: 8a3ce4c7-b012-4dc0-b4f8-53c10b4b86b8
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar Class
A menu bar that implements docking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCMenuBar::AdjustLocations](#cmfcmenubar__adjustlocations)|(Overrides <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.)|  
|[CMFCMenuBar::AllowChangeTextLabels](#cmfcmenubar__allowchangetextlabels)|Specifies whether text labels can be shown under images on the toolbar buttons. (Overrides [CMFCToolBar::AllowChangeTextLabels](../vs140/cmfctoolbar-class.md#cmfctoolbar__allowchangetextlabels).)|  
|[CMFCMenuBar::AllowShowOnPaneMenu](#cmfcmenubar__allowshowonpanemenu)|(Overrides <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.)|  
|[CMFCMenuBar::CalcFixedLayout](#cmfcmenubar__calcfixedlayout)|Calculates the horizontal size of the toolbar. (Overrides [CMFCToolBar::CalcFixedLayout](../vs140/cmfctoolbar-class.md#cmfctoolbar__calcfixedlayout).)|  
|[CMFCMenuBar::CalcLayout](#cmfcmenubar__calclayout)|(Overrides <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.)|  
|[CMFCMenuBar::CalcMaxButtonHeight](#cmfcmenubar__calcmaxbuttonheight)|Calculates the maximum height of buttons in the toolbar. (Overrides [CMFCToolBar::CalcMaxButtonHeight](../vs140/cmfctoolbar-class.md#cmfctoolbar__calcmaxbuttonheight).)|  
|[CMFCMenuBar::CanBeClosed](#cmfcmenubar__canbeclosed)|Specifies whether a user can close the toolbar. (Overrides [CMFCToolBar::CanBeClosed](../vs140/cmfctoolbar-class.md#cmfctoolbar__canbeclosed).)|  
|[CMFCMenuBar::CanBeRestored](#cmfcmenubar__canberestored)|Determines whether the system can restore a toolbar to its original state after customization. (Overrides [CMFCToolBar::CanBeRestored](../vs140/cmfctoolbar-class.md#cmfctoolbar__canberestored).)|  
|[CMFCMenuBar::Create](#cmfcmenubar__create)|Creates a menu control and attaches it to a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.|  
|[CMFCMenuBar::CreateEx](#cmfcmenubar__createex)|Creates a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object with additional style options.|  
|[CMFCMenuBar::CreateFromMenu](#cmfcmenubar__createfrommenu)|Initializes a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object. Accepts a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> parameter that acts as a template for a populated <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.|  
|[CMFCMenuBar::EnableHelpCombobox](#cmfcmenubar__enablehelpcombobox)|Enables a **Help** combo box that is located on the right side of the menu bar.|  
|[CMFCMenuBar::EnableMenuShadows](#cmfcmenubar__enablemenushadows)|Specifies whether to display shadows for pop-up menus.|  
|[CMFCMenuBar::GetAvailableExpandSize](#cmfcmenubar__getavailableexpandsize)|(Overrides [CPane::GetAvailableExpandSize](../vs140/cpane-class.md#cpane__getavailableexpandsize).)|  
|[CMFCMenuBar::GetColumnWidth](#cmfcmenubar__getcolumnwidth)|Returns the width of the toolbar buttons. (Overrides [CMFCToolBar::GetColumnWidth](../vs140/cmfctoolbar-class.md#cmfctoolbar__getcolumnwidth).)|  
|[CMFCMenuBar::GetDefaultMenu](#cmfcmenubar__getdefaultmenu)|Returns a handle to the original menu in the resource file.|  
|[CMFCMenuBar::GetDefaultMenuResId](#cmfcmenubar__getdefaultmenuresid)|Returns the resource identifier for the original menu in the resource file.|  
|[CMFCMenuBar::GetFloatPopupDirection](#cmfcmenubar__getfloatpopupdirection)||  
|[CMFCMenuBar::GetForceDownArrows](#cmfcmenubar__getforcedownarrows)||  
|[CMFCMenuBar::GetHelpCombobox](#cmfcmenubar__gethelpcombobox)|Returns a pointer to the **Help** combo box.|  
|[CMFCMenuBar::GetHMenu](#cmfcmenubar__gethmenu)|Returns the handle to the menu that is attached to the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.|  
|[CMFCMenuBar::GetMenuFont](#cmfcmenubar__getmenufont)|Returns the current global font for menu objects.|  
|[CMFCMenuBar::GetMenuItem](#cmfcmenubar__getmenuitem)|Returns the toolbar button associated with the provided item index.|  
|[CMFCMenuBar::GetRowHeight](#cmfcmenubar__getrowheight)|Returns the height of toolbar buttons. (Overrides [CMFCToolBar::GetRowHeight](../vs140/cmfctoolbar-class.md#cmfctoolbar__getrowheight).)|  
|[CMFCMenuBar::GetSystemButton](#cmfcmenubar__getsystembutton)||  
|[CMFCMenuBar::GetSystemButtonsCount](#cmfcmenubar__getsystembuttonscount)||  
|[CMFCMenuBar::GetSystemMenu](#cmfcmenubar__getsystemmenu)||  
|[CMFCMenuBar::HighlightDisabledItems](#cmfcmenubar__highlightdisableditems)|Indicates whether disabled menu items are highlighted.|  
|[CMFCMenuBar::IsButtonExtraSizeAvailable](#cmfcmenubar__isbuttonextrasizeavailable)|Determines whether the toolbar can display buttons that have extended borders. (Overrides [CMFCToolBar::IsButtonExtraSizeAvailable](../vs140/cmfctoolbar-class.md#cmfctoolbar__isbuttonextrasizeavailable).)|  
|[CMFCMenuBar::IsHighlightDisabledItems](#cmfcmenubar__ishighlightdisableditems)|Indicates whether disabled items are highlighted.|  
|[CMFCMenuBar::IsMenuShadows](#cmfcmenubar__ismenushadows)|Indicates whether shadows are drawn for pop-up menus.|  
|[CMFCMenuBar::IsRecentlyUsedMenus](#cmfcmenubar__isrecentlyusedmenus)|Indicates whether recently used menu commands are displayed on the menu bar.|  
|[CMFCMenuBar::IsShowAllCommands](#cmfcmenubar__isshowallcommands)|Indicates whether pop-up menus display all commands.|  
|[CMFCMenuBar::IsShowAllCommandsDelay](#cmfcmenubar__isshowallcommandsdelay)|Indicates whether menus display all the commands after a short delay.|  
|[CMFCMenuBar::LoadState](#cmfcmenubar__loadstate)|Loads the state of the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object from the registry.|  
|[CMFCMenuBar::OnChangeHot](#cmfcmenubar__onchangehot)|Called by the framework when a user selects a button on the toolbar. (Overrides [CMFCToolBar::OnChangeHot](../vs140/cmfctoolbar-class.md#cmfctoolbar__onchangehot).)|  
|[CMFCMenuBar::OnDefaultMenuLoaded](#cmfcmenubar__ondefaultmenuloaded)|Called by the framework when a frame window loads the default menu from the resource file.|  
|[CMFCMenuBar::OnSendCommand](#cmfcmenubar__onsendcommand)|(Overrides <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.)|  
|[CMFCMenuBar::OnSetDefaultButtonText](#cmfcmenubar__onsetdefaultbuttontext)|Called by the framework when a menu is in customization mode and the user changes a menu item's text.|  
|[CMFCMenuBar::OnToolHitTest](#cmfcmenubar__ontoolhittest)|(Overrides <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.)|  
|[CMFCMenuBar::PreTranslateMessage](#cmfcmenubar__pretranslatemessage)|(Overrides <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.)|  
|[CMFCMenuBar::RestoreOriginalstate](#cmfcmenubar__restoreoriginalstate)|Called by the framework when a menu is in customization mode and the user selects **Reset** for a menu bar.|  
|[CMFCMenuBar::SaveState](#cmfcmenubar__savestate)|Saves the state of the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object to the registry.|  
|[CMFCMenuBar::SetDefaultMenuResId](#cmfcmenubar__setdefaultmenuresid)|Sets the original menu in the resource file.|  
|[CMFCMenuBar::SetForceDownArrows](#cmfcmenubar__setforcedownarrows)||  
|[CMFCMenuBar::SetMaximizeMode](#cmfcmenubar__setmaximizemode)|Called by the framework when an MDI child window changes its display mode. If the MDI child window is newly maximized or is no longer maximized, this method updates the menu bar.|  
|[CMFCMenuBar::SetMenuButtonRTC](#cmfcmenubar__setmenubuttonrtc)|Sets the runtime class information that is generated when the user dynamically creates menu buttons.|  
|[CMFCMenuBar::SetMenuFont](#cmfcmenubar__setmenufont)|Sets the font for all menus in the application.|  
|[CMFCMenuBar::SetRecentlyUsedMenus](#cmfcmenubar__setrecentlyusedmenus)|Specifies whether a menu bar displays recently used menu commands.|  
|[CMFCMenuBar::SetShowAllCommands](#cmfcmenubar__setshowallcommands)|Specifies whether the menu bar shows all commands.|  
  
## Remarks  
 The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> class is a menu bar that implements docking functionality. It resembles a toolbar, although it cannot be closed - it is always displayed.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> supports the option of displaying recently used menu item objects. If this option is enabled, the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> displays only a subset of the available commands on first viewing. Thereafter, recently used commands are displayed together with the original subset of commands. In addition, the user can always expand the menu to view all available commands. Thus, each available command is configured to display constantly, or to display only if it has been recently selected.  
  
 To use a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object, embed it in the main window frame object. When processing the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> message, call <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>. Regardless of which create function you use, pass in a pointer to the main frame window. Then enable docking by calling [CFrameWndEx::EnableDocking](../vs140/cframewndex-class.md#cframewndex__enabledocking). Dock this menu by calling [CFrameWndEx::DockPane](../vs140/cframewndex-class.md#cframewndex__dockpane).  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> class. The example shows how to set the style of the pane, enable the customize button, enable a Help box, enable shadows for pop-up menus, and update the menu bar. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#1](../vs140/codesnippet/CPP/cmfcmenubar-class_1.h)]  
[!code[NVC_MFC_IEDemo#3](../vs140/codesnippet/CPP/cmfcmenubar-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCBaseToolBar](../vs140/cmfcbasetoolbar-class.md)  
  
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)  
  
 [CMFCMenuBar](../vs140/cmfcmenubar-class.md)  
  
## Requirements  
 **Header:** afxmenubar.h  
  
##  \<a name="cmfcmenubar__adjustlocations">\</a>  CMFCMenuBar::AdjustLocations  
 Adjusts the positions of the menu items on the menu bar.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcmenubar__allowchangetextlabels">\</a>  CMFCMenuBar::AllowChangeTextLabels  
 Determines whether text labels are allowed under images in the menu bar.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> if the user can choose to show text labels under images.  
  
### Remarks  
  
##  \<a name="cmfcmenubar__allowshowonpanemenu">\</a>  CMFCMenuBar::AllowShowOnPaneMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__calcfixedlayout">\</a>  CMFCMenuBar::CalcFixedLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__calclayout">\</a>  CMFCMenuBar::CalcLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__calcmaxbuttonheight">\</a>  CMFCMenuBar::CalcMaxButtonHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__canbeclosed">\</a>  CMFCMenuBar::CanBeClosed  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__canberestored">\</a>  CMFCMenuBar::CanBeRestored  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__create">\</a>  CMFCMenuBar::Create  
 Creates a menu control and attaches it to a [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Pointer to the parent window for the new <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The style of the new menu bar.  
  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The ID for the child window of the menu bar.  
  
### Return Value  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 After you construct a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object, you must call <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>. This method creates the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> control and attaches it to the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
 For more information about toolbar styles, see [CBasePane::SetPaneStyle](../vs140/cbasepane-class.md#cbasepane__setpanestyle).  
  
##  \<a name="cmfcmenubar__createex">\</a>  CMFCMenuBar::CreateEx  
 Creates a [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object with specified extended styles.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Pointer to the parent window of the new <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Additional styles for the new menu bar.  
  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The main style of the new menu bar.  
  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> parameter that specifies the sizes for the borders of the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The ID for the child window of the menu bar.  
  
### Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
### Remarks  
 You should use this function instead of [CMFCMenuBar::Create](#cmfcmenubar__create) when you want to specify styles in addition to the toolbar style. Some frequently used additional styles are <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
 For lists of additional styles, see                         [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439),                         [common control styles](http://msdn.microsoft.com/library/windows/desktop/bb775498), and                         [common window styles](http://msdn.microsoft.com/library/windows/desktop/ms632600).  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#1](../vs140/codesnippet/CPP/cmfcmenubar-class_1.h)]  
[!code[NVC_MFC_IEDemo#2](../vs140/codesnippet/CPP/cmfcmenubar-class_3.cpp)]  
  
##  \<a name="cmfcmenubar__createfrommenu">\</a>  CMFCMenuBar::CreateFromMenu  
 Initializes a [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object. This method models the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object after a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> parameter.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A handle to a menu resource. <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> uses this resource as a template for the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 A Boolean that indicates whether the new menu is the default menu.  
  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A Boolean that indicates whether this method forces a menu update.  
  
### Remarks  
 Use this method if you want a menu control to have the same menu items as a menu resource. You call this method after you call either [CMFCMenuBar::Create](#cmfcmenubar__create) or [CMFCMenuBar::CreateEx](#cmfcmenubar__createex).  
  
##  \<a name="cmfcmenubar__enablehelpcombobox">\</a>  CMFCMenuBar::EnableHelpCombobox  
 Enables a **Help** combo box that is located on the right side of the menu bar.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The command ID for the button of the **Help** combo box.  
  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A string that contains the text that the framework displays in the combo box if it is empty and not active. For example, "Enter the text here".  
  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The width of the button for the combo box in pixels.  
  
### Remarks  
 The **Help** combo box resembles the **Help** combo box in the menu bar of [!INCLUDE[ofprword](../vs140/includes/ofprword_md.md)].  
  
 When you call this method with <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> set to 0, this method hides the combo box. Otherwise, this method displays the combo box automatically on the right side of your menu bar. After you call this method, call [CMFCMenuBar::GetHelpCombobox](#cmfcmenubar__gethelpcombobox) to obtain a pointer to the inserted [CMFCToolBarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md) object.  
  
##  \<a name="cmfcmenubar__enablemenushadows">\</a>  CMFCMenuBar::EnableMenuShadows  
 Enables shadows for pop-up menus.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether shadows should be enabled for pop-up menus.  
  
### Remarks  
 The algorithm that this method uses is complex and may decrease the performance of your application on slower systems.  
  
##  \<a name="cmfcmenubar__getavailableexpandsize">\</a>  CMFCMenuBar::GetAvailableExpandSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__getcolumnwidth">\</a>  CMFCMenuBar::GetColumnWidth  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__getdefaultmenu">\</a>  CMFCMenuBar::GetDefaultMenu  
 Retrieves a handle to the original menu. The framework loads the original menu from the resource file.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A handle to a menu resource.  
  
### Remarks  
 If your application customizes a menu, you can use this method to retrieve a handle to the original menu.  
  
##  \<a name="cmfcmenubar__getdefaultmenuresid">\</a>  CMFCMenuBar::GetDefaultMenuResId  
 Retrieves the resource identifier for the default menu.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A menu resource identifier.  
  
### Remarks  
 The framework loads the default menu for the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object from the resource file.  
  
##  \<a name="cmfcmenubar__getfloatpopupdirection">\</a>  CMFCMenuBar::GetFloatPopupDirection  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__getforcedownarrows">\</a>  CMFCMenuBar::GetForceDownArrows  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__gethelpcombobox">\</a>  CMFCMenuBar::GetHelpCombobox  
 Returns a pointer to the **Help** combo box.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the **Help** combo box. <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> if the **Help** combo box is hidden or not enabled.  
  
### Remarks  
 The **Help** combo box is located on the right side of the menu bar. Call the method [CMFCMenuBar::EnableHelpCombobox](#cmfcmenubar__enablehelpcombobox) to enable this combo box.  
  
##  \<a name="cmfcmenubar__gethmenu">\</a>  CMFCMenuBar::GetHMenu  
 Retrieves the handle to the menu attached to the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="cmfcmenubar__getmenufont">\</a>  CMFCMenuBar::GetMenuFont  
 Retrieves the current menu font.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether to return the horizontal or vertical font. <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> indicates the horizontal font.  
  
### Return Value  
 A pointer to a [CFont](../vs140/cfont-class.md) parameter that contains the current menu bar font.  
  
### Remarks  
 The returned font is a global parameter for the application. Two global fonts are maintained for all <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> objects. These separate fonts are used for horizontal and vertical menu bars.  
  
##  \<a name="cmfcmenubar__getmenuitem">\</a>  CMFCMenuBar::GetMenuItem  
 Retrieves a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object on a menu bar based on the item index.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The index of the menu item to return.  
  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object that matches the index specified by <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> if the index is invalid.  
  
##  \<a name="cmfcmenubar__getrowheight">\</a>  CMFCMenuBar::GetRowHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__getsystembutton">\</a>  CMFCMenuBar::GetSystemButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__getsystembuttonscount">\</a>  CMFCMenuBar::GetSystemButtonsCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__getsystemmenu">\</a>  CMFCMenuBar::GetSystemMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__highlightdisableditems">\</a>  CMFCMenuBar::HighlightDisabledItems  
 Controls whether the framework highlights disabled menu items.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the framework highlights unavailable menu items.  
  
### Remarks  
 By default, the framework does not highlight unavailable menu items when the user positions the mouse pointer over them.  
  
##  \<a name="cmfcmenubar__isbuttonextrasizeavailable">\</a>  CMFCMenuBar::IsButtonExtraSizeAvailable  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__ishighlightdisableditems">\</a>  CMFCMenuBar::IsHighlightDisabledItems  
 Indicates whether the framework highlights unavailable menu items.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> if unavailable menu items are highlighted; otherwise <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, the framework does not highlight unavailable menu items when the user positions the mouse pointer over them. Use the [CMFCMenuBar::HighlightDisabledItems](#cmfcmenubar__highlightdisableditems) method to enable this feature.  
  
##  \<a name="cmfcmenubar__ismenushadows">\</a>  CMFCMenuBar::IsMenuShadows  
 Indicates whether the framework draws shadows for pop-up menus.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> if the framework draws menu shadows; otherwise <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use the [CMFCMenuBar::EnableMenuShadows](#cmfcmenubar__enablemenushadows) method to enable or disable this feature.  
  
##  \<a name="cmfcmenubar__isrecentlyusedmenus">\</a>  CMFCMenuBar::IsRecentlyUsedMenus  
 Indicates whether recently used menu commands are displayed on the menu bar.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object shows recently used menu commands; otherwise 0.  
  
### Remarks  
 Use the function [CMFCMenuBar::SetRecentlyUsedMenus](#cmfcmenubar__setrecentlyusedmenus) to control whether the menu bar shows recently used menu commands.  
  
##  \<a name="cmfcmenubar__isshowallcommands">\</a>  CMFCMenuBar::IsShowAllCommands  
 Indicates whether menus display all commands.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) displays all commands; otherwise 0.  
  
### Remarks  
 A <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> object can be configured to either show all commands or show only a subset of commands. For more information about this feature, see [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md).  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> will tell you how this feature is configured for the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object. To control which menu commands are shown, use the methods [CMFCMenuBar::SetShowAllCommands](#cmfcmenubar__setshowallcommands) and [CMFCMenuBar::SetRecentlyUsedMenus](#cmfcmenubar__setrecentlyusedmenus).  
  
##  \<a name="cmfcmenubar__isshowallcommandsdelay">\</a>  CMFCMenuBar::IsShowAllCommandsDelay  
 Indicates whether the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object displays all the commands after a short delay.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the menu bar displays full menus after a short delay; otherwise 0.  
  
### Remarks  
 When you configure a menu bar to display recently used items, the menu bar displays the full menu in one of two ways:  
  
-   Display the full menu after a programmed delay from when the user hovers the cursor over the arrow at the bottom of the menu.  
  
-   Display the full menu after the user clicks the arrow at the bottom of the menu.  
  
 By default, all <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> objects use the option to display the full menu after a short delay. This option cannot be changed programmatically in the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> class. However, a user can change the behavior during toolbar customization by using the **Customize** dialog box..  
  
##  \<a name="cmfcmenubar__loadstate">\</a>  CMFCMenuBar::LoadState  
 Loads the state of the menu bar from the Windows registry.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A string that contains the path of a Windows registry key.  
  
 [in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The control ID for the menu bar.  
  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A reserved value.  
  
### Return Value  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use the [CMFCMenuBar::SaveState](#cmfcmenubar__savestate) method to save the state of the menu bar to the registry. The saved information includes the menu items, the dock state, and the position of the menu bar.  
  
 In most cases your application does not call <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>. The framework calls this method when it initializes the workspace.  
  
##  \<a name="cmfcmenubar__onchangehot">\</a>  CMFCMenuBar::OnChangeHot  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcmenubar__ondefaultmenuloaded">\</a>  CMFCMenuBar::OnDefaultMenuLoaded  
 The framework calls this method when it loads the menu resource from the resource file.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The handle for the menu attached to the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object.  
  
### Remarks  
 The default implementation of this function does nothing. Override this function to execute custom code after the framework loads a menu resource from the resource file.  
  
##  \<a name="cmfcmenubar__onsendcommand">\</a>  CMFCMenuBar::OnSendCommand  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__onsetdefaultbuttontext">\</a>  CMFCMenuBar::OnSetDefaultButtonText  
 The framework calls this method when the user changes the text of an item on the menu bar.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 A pointer to the [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object that the user wants to customize.  
  
### Return Value  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> if the framework applies the user changes to the menu bar; otherwise <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation for this method changes the text of the button to the text that the user provides.  
  
##  \<a name="cmfcmenubar__ontoolhittest">\</a>  CMFCMenuBar::OnToolHitTest  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__pretranslatemessage">\</a>  CMFCMenuBar::PreTranslateMessage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcmenubar__restoreoriginalstate">\</a>  CMFCMenuBar::RestoreOriginalstate  
 Called by the framework when the user selects **Reset** from the **Customize** dialog box.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
### Remarks  
 This method is called when the user selects **Reset** from the customization menu. You can also manually call this method to programmatically reset the state of the menu bar. This method loads the original state from the resource file.  
  
 Override this method if you want to do any processing when the user selects the **Reset** option.  
  
##  \<a name="cmfcmenubar__savestate">\</a>  CMFCMenuBar::SaveState  
 Saves the state of the [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object to the Windows registry.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 A string that contains the path of a Windows registry key.  
  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 The control ID for the menu bar.  
  
 [in] <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 A reserved value.  
  
### Return Value  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>;  
  
### Remarks  
 Usually, your application does not call <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>. The framework calls this method when the workspace is serialized. For more information, see [CWinAppEx::SaveState](../vs140/cwinappex-class.md#cwinappex__savestate).  
  
 The saved information includes the menu items, the dock state, and the position of the menu bar.  
  
##  \<a name="cmfcmenubar__setdefaultmenuresid">\</a>  CMFCMenuBar::SetDefaultMenuResId  
 Sets the default menu for a [CMFCMenuBar](../vs140/cmfcmenubar-class.md) object based on the resource ID.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 The resource ID for the new default menu.  
  
### Remarks  
 The [CMFCMenuBar::RestoreOriginalstate](#cmfcmenubar__restoreoriginalstate) method restores the default menu from the resource file.  
  
 Use the [CMFCMenuBar::GetDefaultMenuResId](#cmfcmenubar__getdefaultmenuresid) method to retrieve the default menu without restoring it.  
  
##  \<a name="cmfcmenubar__setforcedownarrows">\</a>  CMFCMenuBar::SetForceDownArrows  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcmenubar__setmaximizemode">\</a>  CMFCMenuBar::SetMaximizeMode  
 The framework calls this method when a MDI changes its display mode and the menu bar must be updated.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 A Boolean that specifies the mode. See the Remarks section for more information.  
  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 A pointer to the MDI child window that is changing.  
  
 [in] <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 A Boolean that specifies whether the layout of the menu bar should be recalculated immediately.  
  
### Remarks  
 When an MDI child window is maximized, a menu bar attached to the MDI main frame window displays the system menu and the **Minimize**, **Maximize** and **Close** buttons. If <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>, the MDI child window is maximized and the menu bar must incorporate the extra controls. Otherwise, the menu bar returns to its regular state.  
  
##  \<a name="cmfcmenubar__setmenubuttonrtc">\</a>  CMFCMenuBar::SetMenuButtonRTC  
 Sets the runtime class information that the framework uses when the user creates menu buttons.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 The [CRuntimeClass](../vs140/cruntimeclass-structure.md) information for a class derived from the [CMFCMenuButton Class](../vs140/cmfcmenubutton-class.md).  
  
### Remarks  
 When a user adds new buttons to the menu bar, the framework creates the buttons dynamically. By default, it creates <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> objects. Override this method to change the type of button objects that the framework creates.  
  
##  \<a name="cmfcmenubar__setmenufont">\</a>  CMFCMenuBar::SetMenuFont  
 Sets the font for all menu bars in your application.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 A pointer to a                                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/bb773327) structure that defines the font to set.  
  
 [in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 TRUE if you want the <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> parameter to be used for the vertical font, FALSE if you want it to be used for horizontal font.  
  
### Return Value  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
### Remarks  
 Two fonts are used for all [CMFCMenuBar](../vs140/cmfcmenubar-class.md) objects. These separate fonts are used for horizontal and vertical menu bars.  
  
 The font settings are global variables and affect all <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> objects.  
  
##  \<a name="cmfcmenubar__setrecentlyusedmenus">\</a>  CMFCMenuBar::SetRecentlyUsedMenus  
 Controls whether a menu bar displays recently used menu commands.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 A Boolean that controls whether recently used menu commands are displayed.  
  
##  \<a name="cmfcmenubar__setshowallcommands">\</a>  CMFCMenuBar::SetShowAllCommands  
 Controls whether a menu shows all the available commands.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the pop-up menu shows all the menu commands.  
  
### Remarks  
 If a menu does not display all the menu commands, it hides the commands that are rarely used. For more information about displaying menu commands, see [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)