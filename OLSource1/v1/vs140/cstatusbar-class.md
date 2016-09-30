---
title: "CStatusBar Class"
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
  - "CStatusBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "indicators, status bar"
  - "CStatusBar class"
  - "status bars"
  - "indicators"
  - "status indicators"
ms.assetid: a3bde3db-e71c-4881-a3ca-1d5481c345ba
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBar Class
A control bar with a row of text output panes, or "indicators."  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CStatusBar::CStatusBar](#cstatusbar__cstatusbar)|Constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CStatusBar::CommandToIndex](#cstatusbar__commandtoindex)|Gets index for a given indicator ID.|  
|[CStatusBar::Create](#cstatusbar__create)|Creates the status bar, attaches it to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object, and sets the initial font and bar height.|  
|[CStatusBar::CreateEx](#cstatusbar__createex)|Creates a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object with additional styles for the embedded <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[CStatusBar::DrawItem](#cstatusbar__drawitem)|Called when a visual aspect of an owner-draw status bar control changes.|  
|[CStatusBar::GetItemID](#cstatusbar__getitemid)|Gets indicator ID for a given index.|  
|[CStatusBar::GetItemRect](#cstatusbar__getitemrect)|Gets display rectangle for a given index.|  
|[CStatusBar::GetPaneInfo](#cstatusbar__getpaneinfo)|Gets indicator ID, style, and width for a given index.|  
|[CStatusBar::GetPaneStyle](#cstatusbar__getpanestyle)|Gets indicator style for a given index.|  
|[CStatusBar::GetPaneText](#cstatusbar__getpanetext)|Gets indicator text for a given index.|  
|[CStatusBar::GetStatusBarCtrl](#cstatusbar__getstatusbarctrl)|Allows direct access to the underlying common control.|  
|[CStatusBar::SetIndicators](#cstatusbar__setindicators)|Sets indicator IDs.|  
|[CStatusBar::SetPaneInfo](#cstatusbar__setpaneinfo)|Sets indicator ID, style, and width for a given index.|  
|[CStatusBar::SetPaneStyle](#cstatusbar__setpanestyle)|Sets indicator style for a given index.|  
|[CStatusBar::SetPaneText](#cstatusbar__setpanetext)|Sets indicator text for a given index.|  
  
## Remarks  
 The output panes commonly are used as message lines and as status indicators. Examples include the menu help-message lines that briefly explain the selected menu command and the indicators that show the status of the SCROLL LOCK, NUM LOCK, and other keys.  
  
 [CStatusBar::GetStatusBarCtrl](#cstatusbar__getstatusbarctrl), a member function new to MFC 4.0, allows you to take advantage of the Windows common control's support for status bar customization and additional functionality. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member functions give you most of the functionality of the Windows common controls; however, when you call <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, you can give your status bars even more of the characteristics of a Windows 95/98 status bar. When you call <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, it will return a reference to a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object. See [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md) for more information about designing toolbars using Windows common controls. For more general information about common controls, see                 [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The framework stores indicator information in an array with the leftmost indicator at position 0. When you create a status bar, you use an array of string IDs that the framework associates with the corresponding indicators. You can then use either a string ID or an index to access an indicator.  
  
 By default, the first indicator is "elastic": it takes up the status-bar length not used by the other indicator panes, so that the other panes are right-aligned.  
  
 To create a status bar, follow these steps:  
  
1.  Construct the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
2.  Call the [Create](#cstatusbar__create) (or [CreateEx](#cstatusbar__createex)) function to create the status-bar window and attach it to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
3.  Call [SetIndicators](#cstatusbar__setindicators) to associate a string ID with each indicator.  
  
 There are three ways to update the text in a status-bar pane:  
  
1.  Call [CWnd::SetWindowText](../vs140/cwnd-class.md#cwnd__setwindowtext) to update the text in pane 0 only.  
  
2.  Call [CCmdUI::SetText](../vs140/ccmdui-class.md#ccmdui__settext) in the status bar's <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> handler.  
  
3.  Call [SetPaneText](#cstatusbar__setpanetext) to update the text for any pane.  
  
 Call [SetPaneStyle](#cstatusbar__setpanestyle) to update the style of a status-bar pane.  
  
 For more information on using <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, see the article [Status Bar Implementation in MFC](../vs140/status-bar-implementation-in-mfc.md) and [Technical Note 31 : Control Bars](../vs140/tn031--control-bars.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CControlBar](../vs140/ccontrolbar-class.md)  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="cstatusbar__commandtoindex">\</a>  CStatusBar::CommandToIndex  
 Gets the indicator index for a given ID.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 String ID of the indicator whose index is to be retrieved.  
  
### Return Value  
 The index of the indicator if successful; –1 if not successful.  
  
### Remarks  
 The index of the first indicator is 0.  
  
##  \<a name="cstatusbar__create">\</a>  CStatusBar::Create  
 Creates a status bar (a child window) and associates it with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to the [CWnd](../vs140/cwnd-class.md) object whose Windows window is the parent of the status bar.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The status-bar style. In addition to the standard Windows [styles](../vs140/window-styles.md), these styles are supported.  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> Control bar is at top of frame window.  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> Control bar is at bottom of frame window.  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> Control bar is not repositioned when the parent is resized.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The toolbar's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Also sets the initial font and sets the status bar's height to a default value.  
  
##  \<a name="cstatusbar__createex">\</a>  CStatusBar::CreateEx  
 Call this function to create a status bar (a child window) and associate it with the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Pointer to the [CWnd](../vs140/cwnd-class.md) object whose Windows window is the parent of the status bar.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Additional styles for the creation of the embedded [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md) object. The default specifies a status bar without a sizing grip or tooltip support. Status bar styles supported are:  
  
-   **SBARS_SIZEGRIP** The status bar control includes a sizing grip at the right end of the status bar. A sizing grip is similar to a sizing border; it is a rectangular area that the user can click and drag to resize the parent window.  
  
-   **SBT_TOOLTIPS** The status bar supports tooltips.  
  
 For details on these styles, see [Settings for the CStatusBarCtrl](../vs140/settings-for-the-cstatusbarctrl.md).  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The status bar style. The default specifies that a visible status bar be created at the bottom of the frame window. Apply any combination of status bar control styles listed in [Window Styles](../vs140/window-styles.md) and [CDialogBar::Create](../vs140/cdialogbar-class.md#cdialogbar__create). However, this parameter should always include the WS_CHILD and WS_VISIBLE styles.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The status bar's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This function also sets the initial font and sets the status bar's height to a default value.  
  
 Use <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, instead of [Create](#cstatusbar__create), when certain styles need to be present during the creation of the embedded status bar control. For example, set <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to **SBT_TOOLTIPS** to display tooltips in a status bar object.  
  
##  \<a name="cstatusbar__cstatusbar">\</a>  CStatusBar::CStatusBar  
 Constructs a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object, creates a default status-bar font if necessary, and sets the font characteristics to default values.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="cstatusbar__drawitem">\</a>  CStatusBar::DrawItem  
 This member function is called by the framework when a visual aspect of an owner-drawn status bar changes.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to a                                 [DRAWITEMSTRUCT](http://msdn.microsoft.com/library/windows/desktop/bb775802) structure that contains information about the type of drawing required.  
  
### Remarks  
 The **itemAction** member of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> structure defines the drawing action that is to be performed. Override this member function to implement drawing for an owner-draw <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> before the termination of this member function.  
  
##  \<a name="cstatusbar__getitemid">\</a>  CStatusBar::GetItemID  
 Returns the ID of the indicator specified by <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Index of the indicator whose ID is to be retrieved.  
  
### Return Value  
 The ID of the indicator specified by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
##  \<a name="cstatusbar__getitemrect">\</a>  CStatusBar::GetItemRect  
 Copies the coordinates of the indicator specified by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> into the structure pointed to by <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Index of the indicator whose rectangle coordinates are to be retrieved.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Points to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure or a [CRect](../vs140/crect-class.md) object that will receive the coordinates of the indicator specified by <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
### Remarks  
 Coordinates are in pixels relative to the upper-left corner of the status bar.  
  
##  \<a name="cstatusbar__getpaneinfo">\</a>  CStatusBar::GetPaneInfo  
 Sets <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to the ID, style, and width of the indicator pane at the location specified by <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Index of the pane whose information is to be retrieved.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Reference to a **UINT** that is set to the ID of the pane.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Reference to a **UINT** that is set to the style of the pane.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Reference to an integer that is set to the width of the pane.  
  
##  \<a name="cstatusbar__getpanestyle">\</a>  CStatusBar::GetPaneStyle  
 Call this member function to retrieve the style of a status bar's pane.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Index of the pane whose style is to be retrieved.  
  
### Return Value  
 The style of the status-bar pane specified by <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
### Remarks  
 A pane's style determines how the pane appears.  
  
 For a list of styles available for status bars, see [Create](#cstatusbar__create).  
  
##  \<a name="cstatusbar__getpanetext">\</a>  CStatusBar::GetPaneText  
 Call this member function to retrieve the text that appears in a status-bar pane.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Index of the pane whose text is to be retrieved.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object that contains the text to be retrieved.  
  
### Return Value  
 A <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object containing the pane's text.  
  
### Remarks  
 The second form of this member function fills a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object with the string text.  
  
##  \<a name="cstatusbar__getstatusbarctrl">\</a>  CStatusBar::GetStatusBarCtrl  
 This member function allows direct access to the underlying common control.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Contains a reference to a [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md) object.  
  
### Remarks  
 Use <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to take advantage of the functionality of the Windows status-bar common control, and to take advantage of the support [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md) provides for status-bar customization. For example, by using the common control, you can specify a style that includes a sizing grip on the status bar, or you can specify a style to have the status bar appear at the top of the parent window's client area.  
  
 For more general information about common controls, See                         [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cstatusbar__setindicators">\</a>  CStatusBar::SetIndicators  
 Sets each indicator's ID to the value specified by the corresponding element of the array <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, loads the string resource specified by each ID, and sets the indicator's text to the string.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Pointer to an array of IDs.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Number of elements in the array pointed to by <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
##  \<a name="cstatusbar__setpaneinfo">\</a>  CStatusBar::SetPaneInfo  
 Sets the specified indicator pane to a new ID, style, and width.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Index of the indicator pane whose style is to be set.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 New ID for the indicator pane.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 New style for the indicator pane.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 New width for the indicator pane.  
  
### Remarks  
 The following indicator styles are supported:  
  
-   **SBPS_NOBORDERS** No 3-D border around the pane.  
  
-   **SBPS_POPOUT** Reverse border so that text "pops out."  
  
-   **SBPS_DISABLED** Do not draw text.  
  
-   **SBPS_STRETCH** Stretch pane to fill unused space. Only one pane per status bar can have this style.  
  
-   **SBPS_NORMAL** No stretch, borders, or pop-out.  
  
##  \<a name="cstatusbar__setpanestyle">\</a>  CStatusBar::SetPaneStyle  
 Call this member function to set the style of a status bar's pane.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Index of the pane whose style is to be set.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 Style of the pane whose style is to be set.  
  
### Remarks  
 A pane's style determines how the pane appears.  
  
 For a list of styles available for status bars, see [SetPaneInfo](#cstatusbar__setpaneinfo).  
  
##  \<a name="cstatusbar__setpanetext">\</a>  CStatusBar::SetPaneText  
 Call this member function to set the pane text to the string pointed to by <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Index of the pane whose text is to be set.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Pointer to the new pane text.  
  
 *bUpdate*  
 If **TRUE**, the pane is invalidated after the text is set.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 After you call <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, you must add a UI update handler to display the new text in the status bar.  
  
### Example  
 [!code[NVC_MFCDocView#176](../vs140/codesnippet/CPP/cstatusbar-class_1.cpp)]  
  
 [!code[NVC_MFCDocView#177](../vs140/codesnippet/CPP/cstatusbar-class_2.cpp)]  
  
 [!code[NVC_MFCDocView#178](../vs140/codesnippet/CPP/cstatusbar-class_3.cpp)]  
  
## See Also  
 [MFC Sample CTRLBARS](../vs140/visual-c---samples.md)   
 [MFC Sample DLGCBR32](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md)   
 [CControlBar](../vs140/ccontrolbar-class.md)   
 [CWnd::SetWindowText](../vs140/cwnd-class.md#cwnd__setwindowtext)   
 [CStatusBar::SetIndicators](#cstatusbar__setindicators)