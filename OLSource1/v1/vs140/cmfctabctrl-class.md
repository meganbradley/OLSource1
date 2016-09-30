---
title: "CMFCTabCtrl Class"
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
  - "CMFCTabCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCTabCtrl::SwapTabs method"
  - "CMFCTabCtrl constructor"
  - "CMFCTabCtrl::MoveTab method"
  - "CMFCTabCtrl::GetTabFromPoint method"
  - "CMFCTabCtrl::PreTranslateMessage method"
  - "CMFCTabCtrl::RecalcLayout method"
  - "CMFCTabCtrl class"
  - "CMFCTabCtrl::IsPtInTabArea method"
ms.assetid: d441385d-2c72-4203-96fa-deae2273da35
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl Class
The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> class provides functionality for a tab control. The tab control displays a dockable window with flat or three-dimensional tabs at its top or bottom. The tabs can display text and an image and can change color when active.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCTabCtrl::ActivateMDITab](#cmfctabctrl__activatemditab)|Displays the specified tab of the current tab control and sets the focus on that tab.|  
|[CMFCTabCtrl::AllowDestroyEmptyTabbedPane](#cmfctabctrl__allowdestroyemptytabbedpane)||  
|[CMFCTabCtrl::AutoSizeWindow](#cmfctabctrl__autosizewindow)|Specifies whether the framework is to resize the client area of all tab control windows when a user interface element of the tab control changes.|  
|[CMFCTabCtrl::CalcRectEdit](#cmfctabctrl__calcrectedit)|Deflates the size of the specified tab area. (Overrides <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.)|  
|[CMFCTabCtrl::Create](#cmfctabctrl__create)|Creates the tab control and attaches it to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCTabCtrl::EnableActiveTabCloseButton](#cmfctabctrl__enableactivetabclosebutton)|Shows or hides a Close button ( **X**) on the active tab.|  
|[CMFCTabCtrl::EnableInPlaceEdit](#cmfctabctrl__enableinplaceedit)|Enables or disables editable tab labels. (Overrides [CMFCBaseTabCtrl::EnableInPlaceEdit](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__enableinplaceedit).)|  
|[CMFCTabCtrl::EnableTabDocumentsMenu](#cmfctabctrl__enabletabdocumentsmenu)|Replaces two buttons that scroll the window tabs with a button that opens a menu of tabbed windows.|  
|[CMFCTabCtrl::EnsureVisible](#cmfctabctrl__ensurevisible)|Ensures that a tab is visible.|  
|[CMFCTabCtrl::GetDocumentIcon](#cmfctabctrl__getdocumenticon)|Retrieves the symbol that is associated with a tab in a popup menu of tabbed windows.|  
|[CMFCTabCtrl::GetFirstVisibleTabNum](#cmfctabctrl__getfirstvisibletabnum)|Retrieves the index of the first tab that is visible in the current tab control.|  
|[CMFCTabCtrl::GetResizeMode](#cmfctabctrl__getresizemode)|Retrieves a value that specifies how the current tab control can be resized.|  
|[CMFCTabCtrl::GetScrollBar](#cmfctabctrl__getscrollbar)|Retrieves a pointer to the scroll bar object that is associated with the tab control.|  
|[CMFCTabCtrl::GetTabArea](#cmfctabctrl__gettabarea)|Retrieves the bounding rectangle of the tab label area at the top or bottom of the tab control. (Overrides [CMFCBaseTabCtrl::GetTabArea](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__gettabarea).)|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Retrieves the tab that contains a specified point. (Overrides [CMFCBaseTabCtrl::GetTabFromPoint](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__gettabfrompoint).)|  
|[CMFCTabCtrl::GetTabMaxWidth](#cmfctabctrl__gettabmaxwidth)|Retrieves the maximum width of a tab.|  
|[CMFCTabCtrl::GetTabsHeight](#cmfctabctrl__gettabsheight)|Retrieves the height of the tab area of the current tab control.|  
|[CMFCTabCtrl::GetTabsRect](#cmfctabctrl__gettabsrect)|Retrieves a rectangle that bounds the tab area of the current tab control. (Overrides [CMFCBaseTabCtrl::GetTabsRect](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__gettabsrect).)|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCTabCtrl::GetWndArea](#cmfctabctrl__getwndarea)|Retrieves the boundary of the client area of the current tab control.|  
|[CMFCTabCtrl::HideActiveWindowHorzScrollBar](#cmfctabctrl__hideactivewindowhorzscrollbar)|Hides the horizontal scroll bar, if any, of the active window.|  
|[CMFCTabCtrl::HideInactiveWindow](#cmfctabctrl__hideinactivewindow)|Specifies whether the framework is to display inactive tab control windows.|  
|[CMFCTabCtrl::HideNoTabs](#cmfctabctrl__hidenotabs)|Enables or disables drawing the tab area if there are no visible tabs.|  
|[CMFCTabCtrl::HideSingleTab](#cmfctabctrl__hidesingletab)|Enables or disables drawing a tab when there is a single tabbed window. (Overrides [CMFCBaseTabCtrl::HideSingleTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__hidesingletab).)|  
|[CMFCTabCtrl::IsActiveInMDITabGroup](#cmfctabctrl__isactiveinmditabgroup)|Indicates whether the current tab of a tab control is the active tab in an multiple document interface tab group.|  
|[CMFCTabCtrl::IsActiveTabBoldFont](#cmfctabctrl__isactivetabboldfont)|Indicates whether the text of the active tab is displayed using a bold font.|  
|[CMFCTabCtrl::IsActiveTabCloseButton](#cmfctabctrl__isactivetabclosebutton)|Indicates whether the Close button ( **X**) is displayed on an active tab or the upper-right corner of the tab area.|  
|[CMFCTabCtrl::IsDrawFrame](#cmfctabctrl__isdrawframe)|Indicates whether the tabbed window draws a frame rectangle around embedded panes.|  
|[CMFCTabCtrl::IsFlatFrame](#cmfctabctrl__isflatframe)|Indicates whether the frame around the tab area is flat or 3D.|  
|[CMFCTabCtrl::IsFlatTab](#cmfctabctrl__isflattab)|Indicates whether the appearance of the tabs in the current tab control is flat or not.|  
|[CMFCTabCtrl::IsLeftRightRounded](#cmfctabctrl__isleftrightrounded)|Indicates whether the appearance of the left and right side of a tab in the current tab control is rounded.|  
|[CMFCTabCtrl::IsMDITabGroup](#cmfctabctrl__ismditabgroup)|Indicates whether the current tab control is contained in the client area of a multiple-document interface window.|  
|[CMFCTabCtrl::IsOneNoteStyle](#cmfctabctrl__isonenotestyle)|Indicates whether the current tab control is displayed in the style of Microsoft OneNote.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Determines if a point is inside the tab area. (Overrides [CMFCBaseTabCtrl::IsPtInTabArea](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__isptintabarea).)|  
|[CMFCTabCtrl::IsSharedScroll](#cmfctabctrl__issharedscroll)|Indicates whether the current tab control has a scroll bar that can scroll its tabs as a group.|  
|[CMFCTabCtrl::IsTabDocumentsMenu](#cmfctabctrl__istabdocumentsmenu)|Indicates whether the tab control displays scroll buttons or a button that displays a menu of tabbed windows.|  
|[CMFCTabCtrl::IsVS2005Style](#cmfctabctrl__isvs2005style)|Indicates whether tabs are displayed in the style of Visual Studio .NET 2005.|  
|[CMFCTabCtrl::ModifyTabStyle](#cmfctabctrl__modifytabstyle)|Specifies the appearance of tabs in the current tab control.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Moves a tab to another tab position. (Overrides [CMFCBaseTabCtrl::MoveTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__movetab).)|  
|[CMFCTabCtrl::OnDragEnter](#cmfctabctrl__ondragenter)|Called by the framework when the cursor is first dragged into the tab control window.|  
|[CMFCTabCtrl::OnDragOver](#cmfctabctrl__ondragover)|Called by the framework during a drag operation when the mouse is moved over the drop target window. (Overrides [CMFCBaseTabCtrl::OnDragOver](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__ondragover).)|  
|[CMFCTabCtrl::OnShowTabDocumentsMenu](#cmfctabctrl__onshowtabdocumentsmenu)|Displays a popup menu of tabbed windows, waits until the user selects a tab, and makes the selected tab the active tab.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Translates window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. (Overrides [CMFCBaseTabCtrl::PreTranslateMessage](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__pretranslatemessage).)|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Recalculates the internal layout of the tab control. (Overrides [CMFCBaseTabCtrl::RecalcLayout](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__recalclayout).)|  
|[CMFCTabCtrl::SetActiveInMDITabGroup](#cmfctabctrl__setactiveinmditabgroup)|Sets the current tab of a tab control as the active tab in an multiple document interface tab group.|  
|[CMFCTabCtrl::SetActiveTab](#cmfctabctrl__setactivetab)|Activates a tab. (Overrides [CMFCBaseTabCtrl::SetActiveTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__setactivetab).)|  
|[CMFCTabCtrl::SetActiveTabBoldFont](#cmfctabctrl__setactivetabboldfont)|Enables or disables use of a bold font on active tabs.|  
|[CMFCTabCtrl::SetDrawFrame](#cmfctabctrl__setdrawframe)|Enables or disables drawinga frame rectangle around an embedded bar.|  
|[CMFCTabCtrl::SetFlatFrame](#cmfctabctrl__setflatframe)|Specifies whether to draw a flat or a 3D frame around the tab area.|  
|[CMFCTabCtrl::SetImageList](#cmfctabctrl__setimagelist)|Specifies an image list. (Overrides [CMFCBaseTabCtrl::SetImageList](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__setimagelist).)|  
|[CMFCTabCtrl::SetResizeMode](#cmfctabctrl__setresizemode)|Specifies how the current tab control can be resized and then redisplays the control.|  
|[CMFCTabCtrl::SetTabMaxWidth](#cmfctabctrl__settabmaxwidth)|Specifies the maximum tab width in a tabbed window.|  
|[CMFCTabCtrl::StopResize](#cmfctabctrl__stopresize)|Terminates the current resize operation on the tab control.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Swaps a pair of tabs. (Overrides [CMFCBaseTabCtrl::SwapTabs](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__swaptabs).)|  
|[CMFCTabCtrl::SynchronizeScrollBar](#cmfctabctrl__synchronizescrollbar)|Draws a horizontal scroll bar on a tab control that displays flat tabs.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCTabCtrl::m_bEnableActivate](#cmfctabctrl__m_benableactivate)|Prevents the active view from losing focus when a new tab is inserted and enabled.|  
  
## Remarks  
 The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> class supports:  
  
-   Tab control styles that include 3D, flat, and flat with a shared horizontal scroll bar.  
  
-   Tabs located at the top or the bottom of the window.  
  
-   Tabs that display text, images, or text and images.  
  
-   Tabs that change color when the tab is active.  
  
-   Border size changes for adjustable tabs.  
  
-   Detachable tabbed windows.  
  
 The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> class can be used with a dialog box, but is intended for applications that use docking control bars like [!INCLUDE[ofprexcel](../vs140/includes/ofprexcel_md.md)] and [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For more information, see [CMFCDockingControlBar](../vs140/cdockablepane-class.md).  
  
 Follow these steps to add a resizable, docking tab control in your application:  
  
1.  Create an instance of [CMFCTabbedControlBar](../vs140/ctabbedpane-class.md).  
  
2.  Call [CMFCTabbedControlBar::Create](../vs140/cdockablepane-class.md#cdockablepane__create).  
  
3.  Use [AddTab](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__addtab) or [InsertTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__inserttab) to add new tabs.  
  
4.  Call [EnableDocking](../vs140/cbasepane-class.md#cbasepane__enabledocking) so that the current docking tab control can dock at the main frame window.  
  
5.  Call [DockControlBar](../vs140/cframewndex-class.md#cframewndex__dockpane) to dock the tabbed window at the main frame.  
  
 For an example of how to create a tabbed window as a docking control bar, see [CMFCTabbedControlBar](../vs140/ctabbedpane-class.md). To use <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> as a non-docking control, create a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object and then call [CMFCTabCtrl::Create](#cmfctabctrl__create).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md)  
  
 [CMFCTabCtrl](../vs140/cmfctabctrl-class.md)  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> class to configure a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object. The example explains how to add a tab, show the Close button on the active tab, enable editable tab labels, and display a pop-up menu of tabbed window labels. This example is part of the [State Collection sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_StateCollection#1](../vs140/codesnippet/CPP/cmfctabctrl-class_1.h)]  
[!code[NVC_MFC_StateCollection#3](../vs140/codesnippet/CPP/cmfctabctrl-class_2.cpp)]  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
##  \<a name="cmfctabctrl__activatemditab">\</a>  CMFCTabCtrl::ActivateMDITab  
 Displays the specified tab of the current tab control and sets the focus on that tab.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The zero-based index of a tab to display, or -1 to specify the currently active tab.  
  
##  \<a name="cmfctabctrl__allowdestroyemptytabbedpane">\</a>  CMFCTabCtrl::AllowDestroyEmptyTabbedPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Always <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__autosizewindow">\</a>  CMFCTabCtrl::AutoSizeWindow  
 Specifies whether the framework is to resize the client area of all tab control windows when a user interface element of the tab control changes.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> to automatically resize tab control windows; otherwise, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__create">\</a>  CMFCTabCtrl::Create  
 Creates the tab control and attaches it to the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The style of the tab control. For more information, see Remarks.  
  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 A rectangle that bounds the tab control.  
  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to a parent window. Must not be <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The ID of the tab control.  
  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The location of tabs. The default value is <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. For more information, see Remarks.  
  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> to display a close button on the tab; otherwise, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if successful; otherwise, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
### Remarks  
 The following table describes the values you can specify for the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> parameter.  
  
|Style|Description|  
|-----------|-----------------|  
|STYLE_3D|Creates a tab control with a three-dimensional appearance.|  
|STYLE_FLAT|Creates a tab control with flat tabs.|  
|STYLE_FLAT_SHARED_HORZ_SCROLL|Creates a tab control with flat tabs and a scroll bar that can scroll the tabs if they are clipped by a parent window.|  
|STYLE_3D_ONENOTE|Creates a tab control in the style of Microsoft OneNote.|  
|STYLE_3D_VS2005|Creates a tab control in the style of Microsoft Visual Studio 2005.|  
|STYLE_3D_ROUNDED|Creates a tab control with rounded tabs in the style of Microsoft Visual Studio 2005.|  
|STYLE_3D_ROUNDED_SCROLL|Creates a tab control with rounded tabs and scroll buttons in the style of Microsoft Visual Studio 2005.|  
  
 The following table lists the values you can specify for the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> parameter.  
  
|Location|Description|  
|--------------|-----------------|  
|LOCATION_BOTTOM|Tabs are located at the bottom of the tab control.|  
|LOCATION_TOP|Tabs are located at the top of the tab control.|  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> class. This example is part of the [State Collection sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_StateCollection#1](../vs140/codesnippet/CPP/cmfctabctrl-class_1.h)]  
[!code[NVC_MFC_StateCollection#2](../vs140/codesnippet/CPP/cmfctabctrl-class_3.cpp)]  
  
##  \<a name="cmfctabctrl__calcrectedit">\</a>  CMFCTabCtrl::CalcRectEdit  
 Deflates the size of the specified tab area.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 A rectangle that specifies the area of a tab.  
  
### Remarks  
 This method is called when you change the label of a tab. This method deflates the left and right sides of the specified rectangle by one-half the current tab height, and deflates the top and bottom by one unit.  
  
##  \<a name="cmfctabctrl__enableactivetabclosebutton">\</a>  CMFCTabCtrl::EnableActiveTabCloseButton  
 Shows or hides a Close button ( **X**) on the active tab.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> to display the Close button on the active tab; <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> to display the Close button on the upper-right corner of the tab area. The default value is <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctabctrl__enableinplaceedit">\</a>  CMFCTabCtrl::EnableInPlaceEdit  
 Enables or disables editable tab labels.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to enable editable tab labels; <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> to disable editable tab labels.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__enabletabdocumentsmenu">\</a>  CMFCTabCtrl::EnableTabDocumentsMenu  
 Toggles between a user interface that uses two buttons to scroll the window tabs and an interface that displays a pop-up menu of tabbed windows.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> to display a pop-up menu of tabbed window labels; <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> to display forward and backward scroll buttons. The default value is <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
### Remarks  
 When the user clicks a tab label, the framework displays the corresponding tabbed window. If the tab label is visible, the tabbed window is opened without changing its position. If the user selects a document from the pop-up menu and the corresponding tabbed window is off screen, the tabbed window becomes the first tab.  
  
##  \<a name="cmfctabctrl__ensurevisible">\</a>  CMFCTabCtrl::EnsureVisible  
 Ensures that a tab is visible.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The zero-based index of a tab.  
  
### Return Value  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> if it is successful; <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> parameter index is invalid.  
  
### Remarks  
 Use this method to guarantee that the specified tab is visible. The tab control will scroll if it is required.  
  
##  \<a name="cmfctabctrl__getdocumenticon">\</a>  CMFCTabCtrl::GetDocumentIcon  
 Retrieves the image that is associated with a tab in a pop-up menu of tabbed windows.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The command ID of a tab in a pop-up menu of tabbed windows.  
  
### Return Value  
 The handle of a bitmap image.  
  
##  \<a name="cmfctabctrl__getfirstvisibletabnum">\</a>  CMFCTabCtrl::GetFirstVisibleTabNum  
 Retrieves the index of the first tab that is visible in the current tab control.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of a tab in the tab control.  
  
### Remarks  
 Use this method only when the tab control is displayed in the style of Microsoft OneNote. Use the [CMFCTabCtrl::IsOneNoteStyle](#cmfctabctrl__isonenotestyle) method to determine the style.  
  
##  \<a name="cmfctabctrl__getresizemode">\</a>  CMFCTabCtrl::GetResizeMode  
 Retrieves a value that specifies how the current tab control can be resized.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 One of the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> enumeration values that specifies how the tab control can be resized. For a list of possible values, see the Remarks section of the [CMFCTabCtrl::SetResizeMode](#cmfctabctrl__setresizemode) method.  
  
##  \<a name="cmfctabctrl__getscrollbar">\</a>  CMFCTabCtrl::GetScrollBar  
 Retrieves a pointer to the scroll bar object that is associated with the tab control.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a scrollbar object, or a <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> if the tab control was not created by using the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> style.  
  
### Remarks  
 Use this method to access the tab control's embedded scroll bar. A scroll bar object is created only when the tab control has the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> style.  
  
##  \<a name="cmfctabctrl__gettabarea">\</a>  CMFCTabCtrl::GetTabArea  
 Retrieves the bounding rectangle of the tab label area at the top or bottom of the tab control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 When this method returns, this reference contains a rectangle that bounds the top tab label area. The rectangle is in client coordinates. This reference is empty if no tab label area exists at the top of the tab control.  
  
 [out] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 When this method returns, this reference contains a rectangle that bounds the bottom tab label area. The rectangle is in client coordinates. This reference is empty if no tab label area exists at the bottom of the tab control.  
  
### Remarks  
 Use this method to determine the size and position of the tab area in the tabbed window.  
  
##  \<a name="cmfctabctrl__gettabmaxwidth">\</a>  CMFCTabCtrl::GetTabMaxWidth  
 Retrieves the maximum width of a tab.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Maximum width of a tab, in pixels. If the return value is 0, the tab width is unlimited.  
  
### Remarks  
 Use the [CMFCTabCtrl::SetTabMaxWidth](#cmfctabctrl__settabmaxwidth) method to set maximum tab width.  
  
##  \<a name="cmfctabctrl__gettabsheight">\</a>  CMFCTabCtrl::GetTabsHeight  
 Retrieves the height of the tab area of the current tab control.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The height of the tab area if any tab is visible, or zero if no tab is visible.  
  
##  \<a name="cmfctabctrl__gettabsrect">\</a>  CMFCTabCtrl::GetTabsRect  
 Retrieves a rectangle that bounds the tab area of the current tab control.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 When this method returns, the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> parameter contains a rectangle that bounds the tab area.  
  
##  \<a name="cmfctabctrl__getwndarea">\</a>  CMFCTabCtrl::GetWndArea  
 Retrieves the boundary of the client area of the current tab control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 When this method returns, this parameter contains a rectangle that bounds the current tab control.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__hideactivewindowhorzscrollbar">\</a>  CMFCTabCtrl::HideActiveWindowHorzScrollBar  
 Hides the horizontal scroll bar, if any, in the active window.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 Use this method to prevent the tab control from blinking when the user switches between tab control pages.  
  
##  \<a name="cmfctabctrl__hideinactivewindow">\</a>  CMFCTabCtrl::HideInactiveWindow  
 Specifies whether the framework displays inactive tab control windows.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> not to display an inactive window; <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> to display an inactive window. The default value is <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__hidenotabs">\</a>  CMFCTabCtrl::HideNoTabs  
 Enables or disables drawing of the tab area if there are no visible tabs.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> to enable drawing the tab area; <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> to disable drawing. The default value is <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__hidesingletab">\</a>  CMFCTabCtrl::HideSingleTab  
 Enables or disables tab drawing if there is a single tabbed window.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> to not draw a tab for a single tabbed window; <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> to draw a single tab. The default value is <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__isactiveinmditabgroup">\</a>  CMFCTabCtrl::IsActiveInMDITabGroup  
 Indicates whether the current tab of a tab control is the active tab in a multiple document interface tab group.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> if the current tab of a tab control is the active tab in an MDI tab group; otherwise, <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can organize multiple document windows into either vertical or horizontal tab groups and easily shuffle documents from one tab group to another.  
  
##  \<a name="cmfctabctrl__isactivetabboldfont">\</a>  CMFCTabCtrl::IsActiveTabBoldFont  
 Indicates whether the text of the active tab is displayed using a bold font.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> if the active tab is displayed using the bold font; otherwise, <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use the [CMFCTabCtrl::SetActiveTabBoldFont](#cmfctabctrl__setactivetabboldfont) method to change the active tab font.  
  
##  \<a name="cmfctabctrl__isactivetabclosebutton">\</a>  CMFCTabCtrl::IsActiveTabCloseButton  
 Indicates whether the Close button ( **X**) is displayed on an active tab or on the upper-right corner of the tab area.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> if the Close button is displayed on the active tab; <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> if the Close button is displayed on the upper-right corner of the tab area.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__isdrawframe">\</a>  CMFCTabCtrl::IsDrawFrame  
 Indicates whether the tabbed window draws a frame rectangle around embedded panes.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> if a frame rectangle is drawn; otherwise, <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use the [CMFCTabCtrl::SetDrawFrame](#cmfctabctrl__setdrawframe) method to enable or disable drawing a frame rectangle.  
  
##  \<a name="cmfctabctrl__isflatframe">\</a>  CMFCTabCtrl::IsFlatFrame  
 Indicates whether the frame around the tab area is flat or 3D.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> if the frame around the tab area is flat; <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> if the frame is three-dimensional.  
  
### Remarks  
 Use the [CMFCTabCtrl::SetFlatFrame](#cmfctabctrl__setflatframe) method to change how the frame is drawn.  
  
##  \<a name="cmfctabctrl__isflattab">\</a>  CMFCTabCtrl::IsFlatTab  
 Indicates whether the appearance of the tabs in the current tab control is flat or not.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> if the appearance of the tabs in the current tab control is flat; otherwise, <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctabctrl__isleftrightrounded">\</a>  CMFCTabCtrl::IsLeftRightRounded  
 Indicates whether the appearance of the left and right side of a tab in the current tab control is rounded.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> if the sides of each tab is rounded; otherwise, <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctabctrl__ismditabgroup">\</a>  CMFCTabCtrl::IsMDITabGroup  
 Indicates whether the current tab control is contained in the client area of a multiple-document interface window.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> if the current tab control is in an MDI client area window; otherwise, <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctabctrl__isonenotestyle">\</a>  CMFCTabCtrl::IsOneNoteStyle  
 Indicates whether the current tab control is displayed in the style of Microsoft OneNote.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> if the tab control is displayed in the style of Microsoft OneNote; otherwise, <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctabctrl__issharedscroll">\</a>  CMFCTabCtrl::IsSharedScroll  
 Indicates whether the current tab control has a scroll bar that can scroll its tabs as a group.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> if the tab control has a shared scroll bar; otherwise, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> parameter of the [CMFCTabCtrl::Create](#cmfctabctrl__create) method is STYLE_FLAT_SHARED_HORZ_SCROLL.  
  
##  \<a name="cmfctabctrl__istabdocumentsmenu">\</a>  CMFCTabCtrl::IsTabDocumentsMenu  
 Indicates whether the tab control displays scroll buttons or a button that displays a menu of tabbed windows.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> if tabbed windows are scrolled using a popup menu of tabbed window labels; <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> if tabbed windows are scrolled using forward and backward scroll buttons.  
  
### Remarks  
 Use the [CMFCTabCtrl::EnableTabDocumentsMenu](#cmfctabctrl__enabletabdocumentsmenu) method to specify the method of scrolling tabbed windows.  
  
##  \<a name="cmfctabctrl__isvs2005style">\</a>  CMFCTabCtrl::IsVS2005Style  
 Indicates whether tabs are drawn using the style of Visual Studio 2005.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> if tabs are drawn using the style of Visual Studio 2005; otherwise, <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> parameter of the [CMFCTabCtrl::Create](#cmfctabctrl__create) method to specify how tabs are drawn.  
  
##  \<a name="cmfctabctrl__m_benableactivate">\</a>  CMFCTabCtrl::m_bEnableActivate  
 Prevents the active view from losing focus when a new tab is inserted and enabled.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Remarks  
 The focus is usually taken by a new tabbed window when the tab is inserted and made active. Set the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> member variable to <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> to retain the original focus. The default value is <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctabctrl__modifytabstyle">\</a>  CMFCTabCtrl::ModifyTabStyle  
 Specifies the appearance of tabs in the current tab control.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 One of the enumeration values that specifies the appearance of the tab control. For more information, see the table in Remarks.  
  
### Return Value  
 Always <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Remarks  
 The value of the <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> parameter can be one of the following <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> enumerations.  
  
|Name|Description|  
|----------|-----------------|  
|STYLE_3D|Displays three-dimensional, rectangular tabs that have round corners.|  
|STYLE_3D_ONENOTE|Displays three-dimensional tabs that have one vertical side and one slanted side and that have rounded corners.|  
|STYLE_3D_ROUNDED|Displays three-dimensional tabs that have slanted sides and rounded corners.|  
|STYLE_3D_ROUNDED_SCROLL|Displays three-dimensional tabs that have slanted sides and rounded corners. If there are more tabs than can be displayed at the same time, the framework displays a drop-down arrow and a menu of tabs to make active.|  
|STYLE_3D_SCROLLED|Displays three-dimensional, rectangular tabs. If there are more tabs than can be displayed at the same time, the framework displays a drop-down arrow and a menu of tabs to make active.|  
|STYLE_3D_VS2005|Displays three-dimensional, rounded tabs that have one slanted side and one vertical side.|  
|STYLE_FLAT|Displays two-dimensional tabs that have slanted left and right sides.|  
|STYLE_FLAT_SHARED_HORZ_SCROLL|Displays two-dimensional tabs. If there are more tabs than can be displayed at the same time, the framework displays scroll arrows at the ends of the tab area.|  
  
##  \<a name="cmfctabctrl__ondragenter">\</a>  CMFCTabCtrl::OnDragEnter  
 Called by the framework during a drag-and-drop operation when the cursor first enters the window of the current tab control.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 Points to a data object that contains data that the user drags.  
  
 [in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 Contains the state of the modifier keys. This parameter is a bitwise combination (OR) of the following values: <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>. For more information, see the                                 **Message Parameters** section of                                 [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601).  
  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 Contains the current location of the cursor in client coordinates.  
  
### Return Value  
 Always <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>, which means that the drop target cannot accept the data.  
  
### Remarks  
 Use this method to support a drag-and-drop operation. Override this method to implement your own custom behavior.  
  
 By default, this method only calls <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>, which always returns <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctabctrl__ondragover">\</a>  CMFCTabCtrl::OnDragOver  
 Called by the framework during a drag operation when the mouse is moved over the drop target window.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 Pointer to a [COleDataObject](../vs140/coledataobject-class.md) object that is being dragged over the drop target.  
  
 [in] <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 The state of the modifier keys, which is a bitwise combination (OR) of <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. For more information, see "Message Parameters" in                                 [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601).  
  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 The current mouse position.  
  
### Return Value  
 Always <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method with your custom implementation. For more information, see the [CView::OnDragOver](../vs140/cview-class.md#cview__ondragover) method.  
  
##  \<a name="cmfctabctrl__onshowtabdocumentsmenu">\</a>  CMFCTabCtrl::OnShowTabDocumentsMenu  
 Displays a pop-up menu of tabbed windows, waits until the user selects a tab, and makes the selected tab the active tab.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 The coordinates of where to display the pop-up menu.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__setactiveinmditabgroup">\</a>  CMFCTabCtrl::SetActiveInMDITabGroup  
 Sets the current tab of a tab control as the active tab in a multiple document interface tab group.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> to make the current tab the active tab; <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> to make the current tab inactive.  
  
### Remarks  
 You can organize multiple document windows into either vertical or horizontal tab groups and easily shuffle documents from one tab group to another.  
  
##  \<a name="cmfctabctrl__setactivetab">\</a>  CMFCTabCtrl::SetActiveTab  
 Activates a tab.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the tab to activate.  
  
### Return Value  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> if the specified tab was made active; <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> if the specified <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> parameter value is invalid.  
  
### Remarks  
 This method does not send the <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> notification to the parent window of the tab control.  
  
 The <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> method automatically calls the [CMFCTabCtrl::HideActiveWindowHorzScrollBar](#cmfctabctrl__hideactivewindowhorzscrollbar) method to prevent the screen from blinking.  
  
##  \<a name="cmfctabctrl__setactivetabboldfont">\</a>  CMFCTabCtrl::SetActiveTabBoldFont  
 Enables or disables use of a bold font on active tabs.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> to use a bold font to display the label of the active tab; <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> to use the standard font to display the label. The default value is <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__setdrawframe">\</a>  CMFCTabCtrl::SetDrawFrame  
 Specifies whether a frame rectangle is drawn around an embedded bar.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> to display a frame rectangle around an embedded bar; otherwise, <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__setflatframe">\</a>  CMFCTabCtrl::SetFlatFrame  
 Specifies whether to draw a flat or a 3D frame around the tab area.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> to draw a flat (2D) frame around the tab area; <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> to draw a three-dimensional (3D) frame. The default value is <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> to redraw the window immediately; otherwise, <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctabctrl__setimagelist">\</a>  CMFCTabCtrl::SetImageList  
 Specifies an image list.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 The ID of a bitmap resource that contains the image list.  
  
 [in] <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 The width of each image, in pixels. The default value is 15.  
  
 [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The transparent image color. The parts of the image that are this color will be transparent. The default value is the color magenta, RGB(255,0,255).  
  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 A handle to a preloaded image list.  
  
### Return Value  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> if this method is successful. <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> if the tab control is created by using a flat style or if the first method overload cannot load the bitmap that is specified by the <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> parameter.  
  
### Remarks  
 Use this method to set an image list for the tab control. The images from the image list are displayed next to the tab label. This method recalculates the tab height so that the tab is sized to contain both the image and the text.  
  
 Use the [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__addtab) method that is inherited by the tab control to specify the index of the image to display.  
  
##  \<a name="cmfctabctrl__setresizemode">\</a>  CMFCTabCtrl::SetResizeMode  
 Specifies how the current tab control can be resized and then redisplays the control.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 One of the <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> enumeration values that specifies how the tab control can be resized. For a list of possible values, see the table in Remarks.  
  
### Remarks  
 The <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> parameter can be one of the following <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> enumeration values.  
  
|Name|Description|  
|----------|-----------------|  
|RESIZE_NO|The tab control cannot be resized.|  
|RESIZE_VERT|The tab control can be resized vertically but not horizontally.|  
|RESIZE_HORIZ|The tab control can be resized horizontally but not vertically.|  
  
##  \<a name="cmfctabctrl__settabmaxwidth">\</a>  CMFCTabCtrl::SetTabMaxWidth  
 Specifies the maximum tab width in a tabbed window.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 The maximum tab width, in pixels.  
  
### Remarks  
 Use this method to limit the width of each tab in a tabbed window. This method is useful if tabs have very long labels. The [CMFCTabCtrl](../vs140/cmfctabctrl-class.md) class constructor initializes the maximum tab width to 0, which actually means that the width is not limited.  
  
##  \<a name="cmfctabctrl__stopresize">\</a>  CMFCTabCtrl::StopResize  
 Terminates the current resize operation on the tab control.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> to abandon the current resize operation; <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> to complete the current resize operation. In either case, the framework stops drawing the resize rectangle.  
  
##  \<a name="cmfctabctrl__synchronizescrollbar">\</a>  CMFCTabCtrl::SynchronizeScrollBar  
 Draws a horizontal scroll bar on a tab control that displays flat tabs.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 Pointer to a                                 [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure or <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>. When this method returns, and if this parameter is not <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>, the structure contains all the parameters of the scroll bar. The default value is <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> if this method succeeds; otherwise, <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method affects only a tab control that displays flat tabs. The scroll bar influences all the tabs at the same time.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCDockingControlBar](../vs140/cdockablepane-class.md)   
 [CMFCDockingControlBar](../vs140/cdockablepane-class.md)   
 [CMFCBaseTabWnd](../vs140/cmfcbasetabctrl-class.md)