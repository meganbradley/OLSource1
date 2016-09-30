---
title: "COleIPFrameWndEx Class"
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
  - "COleIPFrameWndEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleIPFrameWndEx class"
ms.assetid: ebff1560-a1eb-4854-af00-95d4a192bd55
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx Class
The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> class implements an OLE container that supports MFC. You must derive the in-place frame window class for your application from the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> class, instead of deriving it from the [COleIPFrameWnd](../vs140/coleipframewnd-class.md)class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleIPFrameWndEx::AddDockSite](#coleipframewndex__adddocksite)||  
|[COleIPFrameWndEx::AddPane](#coleipframewndex__addpane)||  
|[COleIPFrameWndEx::AdjustDockingLayout](#coleipframewndex__adjustdockinglayout)||  
|[COleIPFrameWndEx::DockPane](#coleipframewndex__dockpane)||  
|[COleIPFrameWndEx::DockPaneLeftOf](#coleipframewndex__dockpaneleftof)|Docks one pane to the left of another pane.|  
|[COleIPFrameWndEx::EnableAutoHidePanes](#coleipframewndex__enableautohidepanes)||  
|[COleIPFrameWndEx::EnableDocking](#coleipframewndex__enabledocking)||  
|[COleIPFrameWndEx::EnablePaneMenu](#coleipframewndex__enablepanemenu)||  
|[COleIPFrameWndEx::GetActivePopup](#coleipframewndex__getactivepopup)|Returns a pointer to the currently displayed popup menu.|  
|[COleIPFrameWndEx::GetContainerFrameWindow](#coleipframewndex__getcontainerframewindow)||  
|[COleIPFrameWndEx::GetDefaultResId](#coleipframewndex__getdefaultresid)|Returns the resource ID of the frame window that you specified when the window was loaded.|  
|[COleIPFrameWndEx::GetDockFrame](#coleipframewndex__getdockframe)||  
|[COleIPFrameWndEx::GetDockingManager](#coleipframewndex__getdockingmanager)||  
|[COleIPFrameWndEx::GetMainFrame](#coleipframewndex__getmainframe)||  
|[COleIPFrameWndEx::GetMenuBar](#coleipframewndex__getmenubar)|Returns a pointer to the menu bar object attached to the frame window.|  
|[COleIPFrameWndEx::GetPane](#coleipframewndex__getpane)||  
|[COleIPFrameWndEx::GetTearOffBars](#coleipframewndex__gettearoffbars)|Returns a list of pane objects that are in a tear-off state.|  
|[COleIPFrameWndEx::GetToolbarButtonToolTipText](#coleipframewndex__gettoolbarbuttontooltiptext)|Called by the framework before the tooltip for a button is displayed.|  
|[COleIPFrameWndEx::InsertPane](#coleipframewndex__insertpane)||  
|[COleIPFrameWndEx::IsMenuBarAvailable](#coleipframewndex__ismenubaravailable)|Determines whether the pointer to the menu bar object is not <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.|  
|[COleIPFrameWndEx::IsPointNearDockSite](#coleipframewndex__ispointneardocksite)||  
|[COleIPFrameWndEx::LoadFrame](#coleipframewndex__loadframe)|(Overrides <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.)|  
|[COleIPFrameWndEx::OnCloseDockingPane](#coleipframewndex__onclosedockingpane)||  
|[COleIPFrameWndEx::OnCloseMiniFrame](#coleipframewndex__oncloseminiframe)||  
|[COleIPFrameWndEx::OnClosePopupMenu](#coleipframewndex__onclosepopupmenu)|Called by the framework when an active pop-up menu processes a WM_DESTROY message.|  
|[COleIPFrameWndEx::OnCmdMsg](#coleipframewndex__oncmdmsg)|(Overrides <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.)|  
|[COleIPFrameWndEx::OnDrawMenuImage](#coleipframewndex__ondrawmenuimage)|Called by the framework when the image associated with a menu item is drawn.|  
|[COleIPFrameWndEx::OnDrawMenuLogo](#coleipframewndex__ondrawmenulogo)|Called by the framework when a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)object processes a WM_PAINT message.|  
|[COleIPFrameWndEx::OnMenuButtonToolHitTest](#coleipframewndex__onmenubuttontoolhittest)|Called by the framework when a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)object processes WM_NCHITTEST message.|  
|[COleIPFrameWndEx::OnMoveMiniFrame](#coleipframewndex__onmoveminiframe)||  
|[COleIPFrameWndEx::OnSetPreviewMode](#coleipframewndex__onsetpreviewmode)|Call this member function to set the application's main frame window into and out of print-preview mode. (Overrides [CFrameWnd::OnSetPreviewMode](../vs140/cframewnd-class.md#cframewnd__onsetpreviewmode).)|  
|[COleIPFrameWndEx::OnShowCustomizePane](#coleipframewndex__onshowcustomizepane)||  
|[COleIPFrameWndEx::OnShowPanes](#coleipframewndex__onshowpanes)||  
|[COleIPFrameWndEx::OnShowPopupMenu](#coleipframewndex__onshowpopupmenu)|Called by the framework when a pop-up menu is activated.|  
|[COleIPFrameWndEx::OnTearOffMenu](#coleipframewndex__ontearoffmenu)|Called by the framework when a menu that has a tear-off bar is activated.|  
|[COleIPFrameWndEx::PaneFromPoint](#coleipframewndex__panefrompoint)||  
|[COleIPFrameWndEx::PreTranslateMessage](#coleipframewndex__pretranslatemessage)|(Overrides <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.)|  
|[COleIPFrameWndEx::RecalcLayout](#coleipframewndex__recalclayout)|(Overrides <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.)|  
|[COleIPFrameWndEx::RemovePaneFromDockManager](#coleipframewndex__removepanefromdockmanager)||  
|[COleIPFrameWndEx::SetDockState](#coleipframewndex__setdockstate)|Applies the specified docking state to the panes that belong to the frame window.|  
|[COleIPFrameWndEx::SetupToolbarMenu](#coleipframewndex__setuptoolbarmenu)|Modifies a toolbar object by searching for dummy items and replacing them with the specified user-defined items.|  
|[COleIPFrameWndEx::ShowPane](#coleipframewndex__showpane)||  
|[COleIPFrameWndEx::WinHelp](#coleipframewndex__winhelpa)|Called by the framework to initiate the WinHelp application or context help.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleIPFrameWndEx::InitUserToobars](#coleipframewndex__initusertoobars)|Tells the framework to initialize a range of control IDs that are assigned to user-defined toolbars.|  
  
## Example  
 The following example demonstrates how to subclass an instance of the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> class and over ride its methods. The example shows how to over ride the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> method, the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> method, the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> method, and the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> method. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#1](../vs140/codesnippet/CPP/coleipframewndex-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 [COleIPFrameWnd](../vs140/coleipframewnd-class.md)  
  
 [COleIPFrameWndEx](../vs140/coleipframewndex-class.md)  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
##  \<a name="coleipframewndex__adddocksite">\</a>  COleIPFrameWndEx::AddDockSite  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="coleipframewndex__addpane">\</a>  COleIPFrameWndEx::AddPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__adjustdockinglayout">\</a>  COleIPFrameWndEx::AdjustDockingLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="coleipframewndex__dockpane">\</a>  COleIPFrameWndEx::DockPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="coleipframewndex__dockpaneleftof">\</a>  COleIPFrameWndEx::DockPaneLeftOf  
 Docks one pane to the left of another pane.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A pointer to the pane to dock.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to the pane that serves as origin.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> if the operation is successful. Otherwise returns <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to dock several pane objects in a predefined order. This method docks the pane specified by <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to the left of the pane specified by <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
##  \<a name="coleipframewndex__enableautohidepanes">\</a>  COleIPFrameWndEx::EnableAutoHidePanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__enabledocking">\</a>  COleIPFrameWndEx::EnableDocking  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__enablepanemenu">\</a>  COleIPFrameWndEx::EnablePaneMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="coleipframewndex__getactivepopup">\</a>  COleIPFrameWndEx::GetActivePopup  
 Returns a pointer to the currently displayed pop-up menu.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the active pop-up menu; otherwise <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to obtain a pointer to the [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object that is currently displayed.  
  
##  \<a name="coleipframewndex__getcontainerframewindow">\</a>  COleIPFrameWndEx::GetContainerFrameWindow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__getdefaultresid">\</a>  COleIPFrameWndEx::GetDefaultResId  
 Returns the menu resource ID that was specified when the frame window loaded the menu.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns the resource ID of the menu, or 0 if the frame window has no menu bar.  
  
### Remarks  
 Call this function to retrieve the resource ID that was specified when the frame window loaded the menu resource by calling <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
##  \<a name="coleipframewndex__getdockframe">\</a>  COleIPFrameWndEx::GetDockFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__getdockingmanager">\</a>  COleIPFrameWndEx::GetDockingManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__getmainframe">\</a>  COleIPFrameWndEx::GetMainFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__getmenubar">\</a>  COleIPFrameWndEx::GetMenuBar  
 Returns a pointer to the menu bar object attached to the frame window.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the menu bar object.  
  
### Remarks  
 Use this function to retrieve a pointer to the menu bar object that belongs to the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.  
  
##  \<a name="coleipframewndex__getpane">\</a>  COleIPFrameWndEx::GetPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__gettearoffbars">\</a>  COleIPFrameWndEx::GetTearOffBars  
 Returns a list of pane objects that are in a tear-off state.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object that contains a collection of pointers to the [CBasePane](../vs140/cbasepane-class.md)-derived objects.  
  
### Remarks  
 The <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object maintains the collection of tear-off menus as a list of [CBasePane](../vs140/cbasepane-class.md)-derived objects. Use this method to retrieve a reference to this list.  
  
##  \<a name="coleipframewndex__gettoolbarbuttontooltiptext">\</a>  COleIPFrameWndEx::GetToolbarButtonToolTipText  
 Called by the framework before the tooltip for a button is displayed.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Pointer to the button.  
  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Pointer to the tooltip text.  
  
### Return Value  
 The default implementation returns 0.  
  
### Remarks  
 Override this function to customize the display of tooltips on toolbar buttons.  
  
##  \<a name="coleipframewndex__initusertoobars">\</a>  COleIPFrameWndEx::InitUserToobars  
 Specifies a range of control IDs that the framework assigns to the user-defined toolbars.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The registry entry where the library stores user toolbar settings.  
  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Control ID assigned to the first user-defined toolbar.  
  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Control ID assigned to the last user-defined toolbar.  
  
### Remarks  
 Use this function to initialize a range of control IDs for assignment to toolbars that users define dynamically. The parameters <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> define a range of allowed toolbar control IDs. To disable the creation of user-defined toolbars, set <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> to -1.  
  
##  \<a name="coleipframewndex__insertpane">\</a>  COleIPFrameWndEx::InsertPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__ismenubaravailable">\</a>  COleIPFrameWndEx::IsMenuBarAvailable  
 Determines whether the pointer to the menu bar object is not <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Returns a non-zero value if the frame window has a menu bar; otherwise returns 0.  
  
### Remarks  
 Call this method to determine whether the frame window maintains a non- <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> pointer to its menu bar object.  
  
##  \<a name="coleipframewndex__ispointneardocksite">\</a>  COleIPFrameWndEx::IsPointNearDockSite  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__loadframe">\</a>  COleIPFrameWndEx::LoadFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__onclosedockingpane">\</a>  COleIPFrameWndEx::OnCloseDockingPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__oncloseminiframe">\</a>  COleIPFrameWndEx::OnCloseMiniFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__onclosepopupmenu">\</a>  COleIPFrameWndEx::OnClosePopupMenu  
 Called by the framework when an active pop-up menu processes a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 A pointer to the pop-up menu object.  
  
### Remarks  
 Override this method to receive notifications from <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> objects when they process <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> messages.  
  
##  \<a name="coleipframewndex__oncmdmsg">\</a>  COleIPFrameWndEx::OnCmdMsg  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__ondrawmenuimage">\</a>  COleIPFrameWndEx::OnDrawMenuImage  
 Called by the framework when the image that is associated with a menu item is drawn.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 Pointer to the device context.  
  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Pointer to the menu button.  
  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The image associated with the menu item.  
  
### Return Value  
 The default implementation does nothing and returns 0.  
  
### Remarks  
 Override this method if you want to customize image drawing for the menu items that belong to the menu bar owned by the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>-derived object.  
  
##  \<a name="coleipframewndex__ondrawmenulogo">\</a>  COleIPFrameWndEx::OnDrawMenuLogo  
 Called by the framework when a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)object processes a <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 Pointer to the device context.  
  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Pointer to the pop-up menu object.  
  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Pointer to the logo to display.  
  
### Remarks  
 Override this method to display a logo on the pop-up menu associated with the menu bar owned by the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>-derived object. The default implementation does nothing.  
  
##  \<a name="coleipframewndex__onmenubuttontoolhittest">\</a>  COleIPFrameWndEx::OnMenuButtonToolHitTest  
 Called by the framework when a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)object processes a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] pButton  
 Pointer to a menu button.  
  
 [out] pTI  
 Pointer to a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> structure.  
  
### Return Value  
 The default implementation does nothing and returns 0. Your implementation should return a non-zero value if it fills the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> parameter.  
  
### Remarks  
 Override this method to provide ToolTip information about a specific menu item.  
  
##  \<a name="coleipframewndex__onmoveminiframe">\</a>  COleIPFrameWndEx::OnMoveMiniFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__onsetpreviewmode">\</a>  COleIPFrameWndEx::OnSetPreviewMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="coleipframewndex__onshowcustomizepane">\</a>  COleIPFrameWndEx::OnShowCustomizePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__onshowpanes">\</a>  COleIPFrameWndEx::OnShowPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__onshowpopupmenu">\</a>  COleIPFrameWndEx::OnShowPopupMenu  
 Called by the framework when a pop-up menu is displayed.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 Pointer to the pop-up menu to be displayed.  
  
### Return Value  
 The default implementation does nothing and returns a non-zero value. Your implementation should return <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> if the pop-up menu cannot be displayed.  
  
### Remarks  
 Override this method to customize the display of a pop-up menu. For example, you could change the menu buttons to color menu buttons or initialize tear-off bars.  
  
##  \<a name="coleipframewndex__ontearoffmenu">\</a>  COleIPFrameWndEx::OnTearOffMenu  
 Called by the framework when the user selects a menu that has a tear-off bar.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 A pointer to the pop-up menu that the user selected.  
  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A pointer to the pane that hosts the menu.  
  
### Return Value  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> if you want the framework to activate the pop-up menu; otherwise <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this function if you want to customize the setup of the tear-off bar.  
  
##  \<a name="coleipframewndex__panefrompoint">\</a>  COleIPFrameWndEx::PaneFromPoint  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__pretranslatemessage">\</a>  COleIPFrameWndEx::PreTranslateMessage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="coleipframewndex__recalclayout">\</a>  COleIPFrameWndEx::RecalcLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="coleipframewndex__removepanefromdockmanager">\</a>  COleIPFrameWndEx::RemovePaneFromDockManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="coleipframewndex__setdockstate">\</a>  COleIPFrameWndEx::SetDockState  
 Applies the specified docking state to panes that belong to the frame window.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Specifies the docking state.  
  
### Remarks  
 Use this function to specify a new docking state for panes that belong to the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> object.  
  
##  \<a name="coleipframewndex__setuptoolbarmenu">\</a>  COleIPFrameWndEx::SetupToolbarMenu  
 Modifies a toolbar object by searching for dummy items and replacing them with the specified user-defined items.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 A reference to a [CMenu](../vs140/cmenu-class.md) object to be modified.  
  
 [in]  <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Specifies the first user-defined command.  
  
 [in]  <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Specifies the last user-defined command.  
  
### Remarks  
  
##  \<a name="coleipframewndex__showpane">\</a>  COleIPFrameWndEx::ShowPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="coleipframewndex__winhelpa">\</a>  COleIPFrameWndEx::WinHelpA  
 Called by the framework to initiate the WinHelp application or context help.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] dwData  
 Specifies data as required for the type of help specified by <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Specifies the type of help requested. For a list of possible values and how they affect the <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> parameter, see the                                 [WinHelp Function](http://msdn.microsoft.com/library/windows/desktop/bb762267) in the Windows SDK.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CFrameWndEx](../vs140/cframewndex-class.md)   
 [CMDIFrameWndEx](../vs140/cmdiframewndex-class.md)