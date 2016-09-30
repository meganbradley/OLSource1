---
title: "CMDIFrameWndEx Class"
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
  - "CMDIFrameWndEx.AddDockSite"
  - "CMDIFrameWndEx"
  - "CMDIFrameWndEx::AddDockSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMDIFrameWndEx class"
ms.assetid: dbcafcb3-9a7a-4f11-9dfe-ba57565c81d0
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx Class
Extends the functionality of [CMDIFrameWnd](../vs140/cframewnd-class.md), a Windows Multiple Document Interface (MDI) frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMDIFrameWndEx::ActiveItemRecalcLayout](#cmdiframewndex__activeitemrecalclayout)|Recalculates the layout of the active item.|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|This method is not used.|  
|[CMDIFrameWndEx::AddPane](#cmdiframewndex__addpane)|Registers a pane with the docking manager.|  
|[CMDIFrameWndEx::AdjustClientArea](#cmdiframewndex__adjustclientarea)|Reduces the client area to allow for a border.|  
|[CMDIFrameWndEx::AdjustDockingLayout](#cmdiframewndex__adjustdockinglayout)|Recalculates the layout of all docked panes.|  
|[CMDIFrameWndEx::AreMDITabs](#cmdiframewndex__aremditabs)|Determines whether the MDI Tabs feature or the MDI Tabbed Groups feature is enabled.|  
|[CMDIFrameWndEx::CanCovertControlBarToMDIChild](#cmdiframewndex__cancovertcontrolbartomdichild)|Called by the framework to determine whether the frame window can convert docking panes to tabbed documents.|  
|[CMDIFrameWndEx::ControlBarToTabbedDocument](#cmdiframewndex__controlbartotabbeddocument)|Converts the specified docking pane to a tabbed document.|  
|[CMDIFrameWndEx::CreateDocumentWindow](#cmdiframewndex__createdocumentwindow)|Creates a child document window.|  
|[CMDIFrameWndEx::CreateNewWindow](#cmdiframewndex__createnewwindow)|Called by the framework to create a new window.|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMDIFrameWndEx::DockPane](#cmdiframewndex__dockpane)|Docks the specified pane to the frame window.|  
|[CMDIFrameWndEx::DockPaneLeftOf](#cmdiframewndex__dockpaneleftof)|Docks one pane to the left of another pane.|  
|[CMDIFrameWndEx::EnableAutoHideBars](#cmdiframewndex__enableautohidepanes)|Enables auto-hide mode for panes when they are docked at specified sides of the main frame window.|  
|[CMDIFrameWndEx::EnableDocking](#cmdiframewndex__enabledocking)|Enables docking of the panes that belong to the MDI frame window.|  
|[CMDIFrameWndEx::EnableFullScreenMainMenu](#cmdiframewndex__enablefullscreenmainmenu)|Shows or hides the main menu in full-screen mode.|  
|[CMDIFrameWndEx::EnableFullScreenMode](#cmdiframewndex__enablefullscreenmode)|Enables full-screen mode for the frame window.|  
|[CMDIFrameWndEx::EnableLoadDockState](#cmdiframewndex__enableloaddockstate)|Enables or disables the loading of the docking state.|  
|[CMDIFrameWndEx::EnableMDITabbedGroups](#cmdiframewndex__enablemditabbedgroups)|Enables or disables the MDI Tabbed Groups feature.|  
|[CMDIFrameWndEx::EnableMDITabs](#cmdiframewndex__enablemditabs)|Enables or disables the MDI Tabs feature. When enabled, the frame window displays a tab for each MDI child window.|  
|[CMDIFrameWndEx::EnableMDITabsLastActiveActivation](#cmdiframewndex__enablemditabslastactiveactivation)|Specifies whether the last active tab should be activated when the user closes the current tab.|  
|[CMDIFrameWndEx::EnablePaneMenu](#cmdiframewndex__enablepanemenu)|Enables or disables automatic creation and management of the pop-up pane menu, which displays a list of application panes.  .|  
|[CMDIFrameWndEx::EnableWindowsDialog](#cmdiframewndex__enablewindowsdialog)|Inserts a menu item whose command ID calls a [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) dialog box.|  
|[CMDIFrameWndEx::GetActivePopup](#cmdiframewndex__getactivepopup)|Returns a pointer to the currently displayed popup menu.|  
|[CMDIFrameWndEx::GetPane](#cmdiframewndex__getpane)|Returns a pointer to the pane that has the specified control ID.|  
|[CMDIFrameWndEx::GetDefaultResId](#cmdiframewndex__getdefaultresid)|Returns the ID of shared resources of the MDI frame window.|  
|[CMDIFrameWndEx::GetMDITabGroups](#cmdiframewndex__getmditabgroups)|Returns a list of MDI tabbed windows.|  
|[CMDIFrameWndEx::GetMDITabs](#cmdiframewndex__getmditabs)|Returns a reference to the underlined tabbed window.|  
|[CMDIFrameWndEx::GetMDITabsContextMenuAllowedItems](#cmdiframewndex__getmditabscontextmenualloweditems)|Returns a combination of flags that determines what context menu items are valid when the MDI Tabbed Groups feature is enabled.|  
|[CMDIFrameWndEx::GetMenuBar](#cmdiframewndex__getmenubar)|Returns a pointer to a menu bar object attached to the frame window.|  
|[CMDIFrameWndEx::GetRibbonBar](#cmdiframewndex__getribbonbar)|Retrieves the ribbon bar control for the frame.|  
|[CMDIFrameWndEx::GetTearOffBars](#cmdiframewndex__gettearoffbars)|Returns a list of [CPane](../vs140/cpane-class.md)-derived objects that are in a tear-off state.|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Called by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMDIFrameWndEx::GetToolbarButtonToolTipText](#cmdiframewndex__gettoolbarbuttontooltiptext)|Called by the framework when the application displays the tooltip for a toolbar button.|  
|[CMDIFrameWndEx::InsertPane](#cmdiframewndex__insertpane)|Registers the specified pane with the docking manager.|  
|[CMDIFrameWndEx::IsFullScreen](#cmdiframewndex__isfullscreen)|Determines whether the frame window is in full-screen mode.|  
|[CMDIFrameWndEx::IsMDITabbedGroup](#cmdiframewndex__ismditabbedgroup)|Determines whether the MDI Tabbed Groups feature is enabled.|  
|[CMDIFrameWndEx::IsMemberOfMDITabGroup](#cmdiframewndex__ismemberofmditabgroup)|Determines whether the specified tabbed window is in the list of windows that are in MDI Tabbed Groups.|  
|[CMDIFrameWndEx::IsMenuBarAvailable](#cmdiframewndex__ismenubaravailable)|Determines whether the frame window has a menu bar.|  
|[CMDIFrameWndEx::IsPointNearDockSite](#cmdiframewndex__ispointneardocksite)|Determines whether a specified point is near the dock site.|  
|[CMDIFrameWndEx::IsPrintPreview](#cmdiframewndex__isprintpreview)|Determines whether the frame window is in print-preview mode.|  
|[CMDIFrameWndEx::LoadFrame](#cmdiframewndex__loadframe)|Creates a frame window from resource information. (Overrides <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.)|  
|[CMDIFrameWndEx::LoadMDIState](#cmdiframewndex__loadmdistate)|Loads the specified layout of MDI Tabbed Groups and the list of previously opened documents.|  
|[CMDIFrameWndEx::MDITabMoveToNextGroup](#cmdiframewndex__mditabmovetonextgroup)|Moves the active tab from the currently active tabbed window to the next or previous tabbed group.|  
|[CMDIFrameWndEx::MDITabNewGroup](#cmdiframewndex__mditabnewgroup)|Creates a new tabbed group that has a single window.|  
|[CMDIFrameWndEx::NegotiateBorderSpace](#cmdiframewndex__negotiateborderspace)|Negotiates border space in a frame window during OLE in-place activation.|  
|[CMDIFrameWndEx::OnCloseDockingPane](#cmdiframewndex__onclosedockingpane)|Called by the framework when the user clicks the **Close** button on a dockable pane.|  
|[CMDIFrameWndEx::OnCloseMiniFrame](#cmdiframewndex__oncloseminiframe)|Called by the framework when the user clicks the **Close** button on a floating mini frame window.|  
|[CMDIFrameWndEx::OnClosePopupMenu](#cmdiframewndex__onclosepopupmenu)|Called by the framework when an active pop-up menu processes a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> message.|  
|[CMDIFrameWndEx::OnCmdMsg](#cmdiframewndex__oncmdmsg)|Called by the framework to route and dispatch command messages and to update command user-interface objects.|  
|[CMDIFrameWndEx::OnDrawMenuImage](#cmdiframewndex__ondrawmenuimage)|Called by the framework when the image associated with a menu item is drawn.|  
|[CMDIFrameWndEx::OnDrawMenuLogo](#cmdiframewndex__ondrawmenulogo)|Called by the framework when a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)processes a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> message.|  
|[CMDIFrameWndEx::OnEraseMDIClientBackground](#cmdiframewndex__onerasemdiclientbackground)|Called by the framework when the MDI frame window processes a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> message.|  
|[CMDIFrameWndEx::OnMenuButtonToolHitTest](#cmdiframewndex__onmenubuttontoolhittest)|Called by the framework when a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)object processes a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> message.|  
|[CMDIFrameWndEx::OnMoveMiniFrame](#cmdiframewndex__onmoveminiframe)|Called by the framework to move a mini-frame window.|  
|[CMDIFrameWndEx::OnSetPreviewMode](#cmdiframewndex__onsetpreviewmode)|Sets the application's main frame window print-preview mode. (Overrides [CFrameWnd::OnSetPreviewMode](../vs140/cframewnd-class.md#cframewnd__onsetpreviewmode).)|  
|[CMDIFrameWndEx::OnShowCustomizePane](#cmdiframewndex__onshowcustomizepane)|Called by the framework when a Quick Customize pane is activated.|  
|[CMDIFrameWndEx::OnShowMDITabContextMenu](#cmdiframewndex__onshowmditabcontextmenu)|Called by the framework when a context menu should be displayed on one of the tabs. (Valid for MDI Tabbed Groups only.)|  
|[CMDIFrameWndEx::OnShowPanes](#cmdiframewndex__onshowpanes)|Called by the framework to show or hide panes.|  
|[CMDIFrameWndEx::OnShowPopupMenu](#cmdiframewndex__onshowpopupmenu)|Called by the framework when a pop-up menu is activated.|  
|[CMDIFrameWndEx::OnSizeMDIClient](#cmdiframewndex__onsizemdiclient)|Called by the framework when the size of the client MDI window is changing.|  
|[CMDIFrameWndEx::OnTearOffMenu](#cmdiframewndex__ontearoffmenu)|Called by the framework when a menu that has a tear-off bar is activated.|  
|[CMDIFrameWndEx::OnUpdateFrameMenu](#cmdiframewndex__onupdateframemenu)|Called by the framework to update the frame menu. (Overrides <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.)|  
|[CMDIFrameWndEx::PaneFromPoint](#cmdiframewndex__panefrompoint)|Returns the docking pane that contains the specified point.|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|Used by class [CWinApp](../vs140/cwinapp-class.md) to translate window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions.  (Overrides <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.)|  
|[CMDIFrameWndEx::RecalcLayout](#cmdiframewndex__recalclayout)|Called by the framework to recalculate the layout of the frame window. (Overrides [CFrameWnd::RecalcLayout](../vs140/cframewnd-class.md#cframewnd__recalclayout).)|  
|[CMDIFrameWndEx::RemovePaneFromDockManager](#cmdiframewndex__removepanefromdockmanager)|Unregisters a pane and removes it from the docking manager.|  
|[CMDIFrameWndEx::SaveMDIState](#cmdiframewndex__savemdistate)|Saves the current layout of MDI Tabbed Groups and the list of previously opened documents.|  
|[CMDIFrameWndEx::SetPrintPreviewFrame](#cmdiframewndex__setprintpreviewframe)|Sets the print preview frame window.|  
|[CMDIFrameWndEx::SetupToolbarMenu](#cmdiframewndex__setuptoolbarmenu)|Modifies a toolbar object by searching for dummy items and replacing them with the specified user-defined items.|  
|[CMDIFrameWndEx::ShowFullScreen](#cmdiframewndex__showfullscreen)|Switches the main frame from regular mode to full-screen mode.|  
|[CMDIFrameWndEx::ShowPane](#cmdiframewndex__showpane)|Shows or hides the specified pane.|  
|[CMDIFrameWndEx::ShowWindowsDialog](#cmdiframewndex__showwindowsdialog)|Creates a [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) box and opens it.|  
|[CMDIFrameWndEx::TabbedDocumentToPane](#cmdiframewndex__tabbeddocumenttocontrolbar)|Converts the specified tabbed document to a docking pane.|  
|[CMDIFrameWndEx::UpdateCaption](#cmdiframewndex__updatecaption)|Called by the framework to update the window frame caption.|  
|[CMDIFrameWndEx::UpdateMDITabbedBarsIcons](#cmdiframewndex__updatemditabbedbarsicons)|Sets the icon for each MDI tabbed pane.|  
|[CMDIFrameWndEx::WinHelp](#cmdiframewndex__winhelp)|Called by the framework to initiate the WinHelp application or context help. (Overrides [CWnd::WinHelp](../vs140/cwnd-class.md#cwnd__winhelp).)|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMDIFrameWndEx::m_bCanCovertControlBarToMDIChild](#cmdiframewndex__m_bcancovertcontrolbartomdichild)|Determines whether docking panes can be converted to MDI child windows.|  
|[CMDIFrameWndEx::m_bDisableSetRedraw](#cmdiframewndex__m_bdisablesetredraw)|Enables or disables redraw optimization for MDI child windows.|  
  
## Remarks  
 To take advantage of extended customization features in your MDI application, derive the MDI frame window class of the application from <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
## Example  
 The following example derives a class from <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. This code snippet comes from the [DrawClient Sample: MFC Ribbon-Based OLE Object Drawing Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DrawClient#1](../vs140/codesnippet/CPP/cmdiframewndex-class_1.h)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 [CMDIFrameWnd](../vs140/cmdiframewnd-class.md)  
  
 [CMDIFrameWndEx](../vs140/cmdiframewndex-class.md)  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
##  \<a name="cmdiframewndex__activeitemrecalclayout">\</a>  CMDIFrameWndEx::ActiveItemRecalcLayout  
 Recalculates the layout of the active item.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cmdiframewndex__addpane">\</a>  CMDIFrameWndEx::AddPane  
 Registers a pane with the docking manager.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Pointer to the pane to register.  
  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Specifies whether to add this pane to the end of the list.  
  
### Return Value  
 Returns a non-zero value if the pane is registered successfully. Returns 0 if the pane is already registered with the docking manager.  
  
### Remarks  
 Each pane must be registered with the [docking manager](../vs140/cdockingmanager-class.md) before it can take a part in the docking layout. Use this method to notify the docking manager that you want to dock a specific pane. Once that pane is registered, the docking manager aligns it based on its alignment setting and position in the list of panes maintained by the docking manager.  
  
##  \<a name="cmdiframewndex__adjustclientarea">\</a>  CMDIFrameWndEx::AdjustClientArea  
 Reduces the client area to allow for a border.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cmdiframewndex__adjustdockinglayout">\</a>  CMDIFrameWndEx::AdjustDockingLayout  
 Recalculates the layout of all docked panes.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Identifies the multiple-window-position structure. You can obtain this value by calling <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this member function to recalculate the layout of all panes docked to the frame window.  
  
##  \<a name="cmdiframewndex__aremditabs">\</a>  CMDIFrameWndEx::AreMDITabs  
 Determines whether the MDI tabs feature or the MDI tabbed groups feature is enabled.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A pointer to an integer variable that indicates which features are enabled:  
  
-   0: All features are disabled.  
  
-   1: MDI tabs is enabled.  
  
-   2: MDI tabbed groups is enabled.  
  
### Return Value  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> if MDI tabs or MDI tabbed groups is enabled.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> if none of the above features is enabled.  
  
### Remarks  
 Use this function to determine whether MDI tabs or MDI tabbed groups is enabled for the frame window. Use [EnableMDITabs](#cmdiframewndex__enablemditabs) to enable or disable the MDI tabs feature.  
  
 Use [EnableMDITabbedGroups](#cmdiframewndex__enablemditabbedgroups) to enable or disable the MDI tabbed groups feature.  
  
##  \<a name="cmdiframewndex__cancovertcontrolbartomdichild">\</a>  CMDIFrameWndEx::CanCovertControlBarToMDIChild  
 Called by the framework to determine whether the frame window can convert docking panes to tabbed documents  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> if the frame window can convert docking panes to tabbed documents; otherwise returns <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class and return <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to enable the conversion of docking panes to tabbed documents. Alternatively, you can set [m_bCanConvertControlBarToMDIChild](#cmdiframewndex__m_bcancovertcontrolbartomdichild) to <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdiframewndex__controlbartotabbeddocument">\</a>  CMDIFrameWndEx::ControlBarToTabbedDocument  
 Converts the specified docking pane to a tabbed document.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A pointer to the docking pane to convert.  
  
### Return Value  
 Returns a pointer to the new MDI child window that contains the docking pane.  
  
### Remarks  
 This method converts a docking pane to a tabbed document. When you call this method, the framework creates a [CMDIChildWndEx](../vs140/cmdichildwndex-class.md) object, removes the docking pane from the docking manager, and adds the docking pane to the new MDI child window. The MDI child window resizes the docking pane to cover the entire client area  
  
##  \<a name="cmdiframewndex__createdocumentwindow">\</a>  CMDIFrameWndEx::CreateDocumentWindow  
 Creates a child document window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A text string that contains a document identifier. Typically, it is the full path of a document file.  
  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 A pointer to a user-defined object. For example, a developer can create an application-specific data structure describing the document and telling how the document should be initialized at startup.  
  
### Return Value  
 A pointer to <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when it loads the list of documents previously saved in the registry.  
  
 Override this method in order to create documents when they are being loaded from the registry.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 In this example, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> could be the name of a "virtual document" (for example, "Start Page") that is not actually loaded from a disk file. Therefore we need special processing to handle that case.  
  
 [!code[NVC_MFC_VisualStudioDemo#13](../vs140/codesnippet/CPP/cmdiframewndex-class_2.cpp)]  
  
##  \<a name="cmdiframewndex__createnewwindow">\</a>  CMDIFrameWndEx::CreateNewWindow  
 Called by the framework to create a new window.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The document name.  
  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Reserved for future use.  
  
### Return Value  
 A pointer to the new window.  
  
##  \<a name="cmdiframewndex__dockpane">\</a>  CMDIFrameWndEx::DockPane  
 Docks the specified pane to the frame window.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Pointer to the pane to dock.  
  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Specifies which sides of the frame window to dock to.  
  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Not used.  
  
### Remarks  
 This method docks the specified the pane to one of the sides of the frame window that was specified when [CBasePane::EnableDocking](../vs140/cbasepane-class.md#cbasepane__enabledocking) and [CMDIFrameWndEx::EnableDocking](#cmdiframewndex__enabledocking) were called.  
  
### Example  
 The following example demonstrates the use of the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> method. This code snippet comes from the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#4](../vs140/codesnippet/CPP/cmdiframewndex-class_3.cpp)]  
  
##  \<a name="cmdiframewndex__dockpaneleftof">\</a>  CMDIFrameWndEx::DockPaneLeftOf  
 Docks one pane to the left of another pane.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A pointer to the docking pane.  
  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A pointer to the pane that serves as the dock site. .  
  
### Return Value  
 Returns <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> if the operation is successful. Otherwise returns <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to dock several pane objects in a predefined order. This method docks the pane specified by <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> to the left of the pane specified by <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
### Example  
 The following example shows how the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> method is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#5](../vs140/codesnippet/CPP/cmdiframewndex-class_4.cpp)]  
  
##  \<a name="cmdiframewndex__enableautohidepanes">\</a>  CMDIFrameWndEx::EnableAutoHidePanes  
 Enables auto-hide mode for panes when they are docked at the specified sides of the main frame window.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Specifies the sides of the main frame window that will be enabled. Use one or more of the following flags.  
  
-   <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
  
### Return Value  
 Call this function to enable auto-hide mode for panes when they are docked at the specified sides of the main frame window.  
  
### Example  
 The following example shows how the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> method is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#6](../vs140/codesnippet/CPP/cmdiframewndex-class_5.cpp)]  
  
### Remarks  
  
##  \<a name="cmdiframewndex__enabledocking">\</a>  CMDIFrameWndEx::EnableDocking  
 Enables docking of the panes that belong to the MDI frame window.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Specifies the docking style that you want to apply.  
  
### Return Value  
  
### Remarks  
 Call this function to enable docking of panes that belong to the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object.  
  
### Example  
 The following example shows how the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> method is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#7](../vs140/codesnippet/CPP/cmdiframewndex-class_6.cpp)]  
  
##  \<a name="cmdiframewndex__enablefullscreenmainmenu">\</a>  CMDIFrameWndEx::EnableFullScreenMainMenu  
 Shows or hides the main menu in full-screen mode.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> to show the main menu in full-screen mode, or <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> to hide it.  
  
### Remarks  
  
##  \<a name="cmdiframewndex__enablefullscreenmode">\</a>  CMDIFrameWndEx::EnableFullScreenMode  
 Enables full-screen mode for the frame window.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The ID of a command that enables or disables full-screen mode.  
  
### Remarks  
 In full-screen mode, all docking control bars, toolbars and menus are hidden and the active view is resized to occupy the full-screen.When you enable full-screen mode, you must specify an ID of the command that enables or disables it. You can call <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> from the main frame's <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> function. When a frame window is being switched to full-screen mode, the framework creates a floating toolbar with one button that has the specified command ID.If you want to keep the main menu on the screen, call [CFrameWndEx::EnableFullScreenMainMenu](#cmdiframewndex__enablefullscreenmainmenu).  
  
##  \<a name="cmdiframewndex__enableloaddockstate">\</a>  CMDIFrameWndEx::EnableLoadDockState  
 Enables or disables the loading of the docking state.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> to enable the loading of the docking state, <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> to disable the loading of the docking state.  
  
### Remarks  
  
##  \<a name="cmdiframewndex__enablemditabbedgroups">\</a>  CMDIFrameWndEx::EnableMDITabbedGroups  
 Enables or disables the MDI tabbed groups feature for the frame window.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, the MDI tabbed groups feature is enabled; if <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, the MDI tabbed groups feature is disabled.  
  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Specifies parameters that the framework applies to child windows that are created in the MDI client area.  
  
### Remarks  
 Use this method to enable or disable the MDI tabbed groups feature. This feature enables MDI applications to display child windows as tabbed windows that are aligned vertically or horizontally within the MDI client area. Groups of tabbed windows are separated by splitters. The user can resize tabbed groups by using a splitter.  
  
-   The user can:  
  
-   Drag individual tabs between groups.  
  
-   Drag individual tabs to the edge of the window to create new groups.  
  
-   Move tabs or create new groups by using a shortcut menu.  
  
-   Your application can save the current layout of tabbed windows and the list of currently opened documents.  
  
 If you call this method with <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> is ignored.  
  
 Even if MDI tabbed groups is already enabled, you can call this method again to modify the settings for child windows. Call the method with <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> and modify the members of the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object that are specified by the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> parameter.  
  
 For more information about how to use MDI tabbed groups, see [MDI Tabbed Groups](../vs140/mdi-tabbed-groups.md).  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#8](../vs140/codesnippet/CPP/cmdiframewndex-class_7.cpp)]  
  
##  \<a name="cmdiframewndex__enablemditabs">\</a>  CMDIFrameWndEx::EnableMDITabs  
 Enables or disables the MDI Tabs feature for the MDI frame window. When enabled, the frame window displays a tab for each MDI child window.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Specifies whether tabs are enabled.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Specifies whether icons should be displayed on the tabs.  
  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Specifies the location of the tab labels.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Specifies whether to display tab close buttons.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Specifies the style of tabs. Use <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> for regular tabs or <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> for Microsoft OneNote tabs.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Specifies whether custom tooltips are enabled.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>, a **Close** button will be displayed on the active tab instead of on the right corner of the tab area.  
  
### Remarks  
 Call this method to enable or disable the MDI tabs feature for the MDI frame window. When enabled, all child windows are displayed as tabs.  
  
 The tab labels can be located at the top or bottom of the frame, depending on the setting of the parameter <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>. You may specify either <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> (the default setting) or <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>, an <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> message will be sent to the main frame window. Your code can handle this message and provide the framework with custom tooltips for MDI tabs.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> is used in the [MDITabsDemo Sample: MFC Tabbed MDI Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MDITabsDemo#3](../vs140/codesnippet/CPP/cmdiframewndex-class_8.cpp)]  
  
##  \<a name="cmdiframewndex__enablemditabslastactiveactivation">\</a>  CMDIFrameWndEx::EnableMDITabsLastActiveActivation  
 Specifies whether the last active tab should be opened when the user closes the current tab.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, enable activation of the last active tab. If <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, disable activation of the last active tab.  
  
### Remarks  
 There are two ways to open a tab when the active tab is closed:  
  
-   Activate the next tab.  
  
-   Activate the previously active tab.  
  
 The default implementation uses the first way.  
  
 Use <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> to enable the second way of tab activation. It emulates the way Windows opens MDI child windows.  
  
##  \<a name="cmdiframewndex__enablepanemenu">\</a>  CMDIFrameWndEx::EnablePaneMenu  
 Enables or disables automatic creation and management of the pop-up pane menu, which displays a list of application panes.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>, automatic handling of the pane menu is enabled; if <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>, automatic handling is disabled.  
  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Command ID of the **Customize** menu item. This menu item is usually added to the end of the list of panes.  
  
 [in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 The text to be displayed for the **Customize** menu item (for localization).  
  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 Specifies the ID of a toolbar menu item that opens the pane menu. Usually this is the **Toolbars** submenu of the  **View** menu.  
  
 [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>, the pane menu displays only a list of toolbars. If <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>, the menu displays a list of toolbars and docking bars.  
  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, the pane menu displays only a list of toolbars. If <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>, the menu displays a list of toolbars and docking bars.  
  
### Remarks  
 The pop-up pane menu displays the list of the application's panes and lets the user show or hide individual panes.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#9](../vs140/codesnippet/CPP/cmdiframewndex-class_9.cpp)]  
  
##  \<a name="cmdiframewndex__enablewindowsdialog">\</a>  CMDIFrameWndEx::EnableWindowsDialog  
 Inserts a menu item whose command ID calls a [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) dialog box.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 Specifies the resource ID of a menu.  
  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 Specifies the item's text.  
  
 [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 Specifies whether to display a **Help** button on the windows management dialog box.  
  
 [in] <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 The string resource identifier that contains the item's text string.  
  
### Remarks  
 Use this method to insert a menu item whose command calls a MDI child window management dialog box ( [CBCGPWindowsManagerDlg](../vs140/cmfcwindowsmanagerdialog-class.md)). The new item is inserted into the menu specified by <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>. Call <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> when you process the <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> message.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#10](../vs140/codesnippet/CPP/cmdiframewndex-class_10.cpp)]  
  
##  \<a name="cmdiframewndex__getactivepopup">\</a>  CMDIFrameWndEx::GetActivePopup  
 Returns a pointer to the currently displayed popup menu.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the active popup menu; <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> if no popup menu is active.  
  
### Remarks  
 Use this function to obtain a pointer to the [CBCGPPopupMenu](../vs140/cmfcpopupmenu-class.md) object that is currently displayed.  
  
##  \<a name="cmdiframewndex__getdefaultresid">\</a>  CMDIFrameWndEx::GetDefaultResId  
 Returns the ID of shared resources of the MDI frame window.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A resource ID value. 0 if the frame window has no menu bar.  
  
### Remarks  
 This method returns the resource ID that was specified when the MDI frame window was loaded by [CFrameWnd::LoadFrame](../vs140/cframewnd-class.md#cframewnd__loadframe).  
  
##  \<a name="cmdiframewndex__getmditabgroups">\</a>  CMDIFrameWndEx::GetMDITabGroups  
 Returns a list of MDI tabbed windows.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a [CObList Class](../vs140/coblist-class.md) object that contains a list of tabbed windows. Do not store or modify the list.  
  
### Remarks  
 Use this method to access the list of tabbed windows. It can be helpful if you want to change or query some parameters of individual tabbed windows.  
  
##  \<a name="cmdiframewndex__getmditabs">\</a>  CMDIFrameWndEx::GetMDITabs  
 Returns a reference to the underlined tabbed window.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the underlined tabbed window.  
  
##  \<a name="cmdiframewndex__getmditabscontextmenualloweditems">\</a>  CMDIFrameWndEx::GetMDITabsContextMenuAllowedItems  
 Returns a combination of flags that determines what operations are valid when the MDI Tabbed Groups feature is enabled.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 A bitwise-OR combination of the following flags:  
  
-   <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> - can create a vertical tab group.  
  
-   <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> - can create a horizontal tab group.  
  
-   <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> - can move a tab to the previous tab group.  
  
-   <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> - can move a tab to the next tab group.  
  
### Remarks  
 When the MDI Tabbed Groups feature is enabled, you must know what operations are allowed on the tabs of a particular window. This method analyzes the current layout of tabbed windows and returns a combination of flags that can be used to build, for example, a shortcut menu.  
  
 You can create a new vertical tab group when all tabbed windows are aligned vertically, or when there is only one tabbed window.  
  
 You can create a new horizontal tab group when all tabbed windows are aligned horizontally, or when there is only one tabbed window.  
  
 You can move a tab to the previous group only if there is more than one tab in a tabbed window.  
  
 You can move a tab to the next group only if there is more than one tab in a tabbed window.  
  
##  \<a name="cmdiframewndex__getmenubar">\</a>  CMDIFrameWndEx::GetMenuBar  
 Returns a pointer to a menu bar object attached to the frame window.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a menu bar object.  
  
##  \<a name="cmdiframewndex__getpane">\</a>  CMDIFrameWndEx::GetPane  
 Returns a pointer to the pane that has the specified control ID.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The control ID.  
  
### Return Value  
 A pointer to the pane that has the specified control ID, if it exists. Otherwise, <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdiframewndex__getribbonbar">\</a>  CMDIFrameWndEx::GetRibbonBar  
 Retrieves the ribbon bar control for the frame.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to the [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md) for the frame.  
  
### Remarks  
  
##  \<a name="cmdiframewndex__gettearoffbars">\</a>  CMDIFrameWndEx::GetTearOffBars  
 Returns a list of tear-off menus.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a [CObList Class](../vs140/coblist-class.md) object that contains a collection of pointers to <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>-derived objects that are in a tear-off state.  
  
### Remarks  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> maintains a collection of tear-off menus. Use this method to retrieve a reference to this list.  
  
##  \<a name="cmdiframewndex__gettoolbarbuttontooltiptext">\</a>  CMDIFrameWndEx::GetToolbarButtonToolTipText  
 Called by the framework when the application displays the tooltip for a toolbar button.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 A pointer to a toolbar button.  
  
 [in] <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 The tooltip text to display for the button.  
  
### Return Value  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> if the tooltip has been displayed. <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
  
##  \<a name="cmdiframewndex__insertpane">\</a>  CMDIFrameWndEx::InsertPane  
 Registers the specified pane with the docking manager.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 A pointer to the pane to be inserted.  
  
 [in] <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 A pointer to the pane before or after which to insert the pane.  
  
 [in] <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> is inserted after <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> is inserted before <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> if the method successfully registers the pane, <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> if the pane was already registered with the docking manager.  
  
### Remarks  
 Use this method to tell the docking manager about a pane specified by <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>. The docking manager will align this pane according to the pane's alignment and position in the docking manager's internal list.  
  
##  \<a name="cmdiframewndex__isfullscreen">\</a>  CMDIFrameWndEx::IsFullScreen  
 Determines whether the frame window is in full-screen mode.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> if the frame window is in full screen mode; otherwise <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can set the full screen mode by calling the [CMDIFrameWndEx::EnableFullScreenMode](#cmdiframewndex__enablefullscreenmode) method.  
  
##  \<a name="cmdiframewndex__ismditabbedgroup">\</a>  CMDIFrameWndEx::IsMDITabbedGroup  
 Specifies whether the MDI Tabbed Groups feature is enabled.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> if the MDI Tabbed Groups feature is enabled; otherwise <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
### Remarks  
 To determine whether regular MDI tabs or the MDI Tabbed Groups feature is enabled, use [CMDIFrameWndEx::AreMDITabs](#cmdiframewndex__aremditabs).  
  
##  \<a name="cmdiframewndex__ismemberofmditabgroup">\</a>  CMDIFrameWndEx::IsMemberOfMDITabGroup  
 Determines whether the specified tabbed window is in the list of windows that are in MDI Tabbed Groups.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 A pointer to tabbed window.  
  
### Return Value  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> if the specified tabbed window is in the list of tabbed windows that form MDI Tabbed Groups. Otherwise <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdiframewndex__ismenubaravailable">\</a>  CMDIFrameWndEx::IsMenuBarAvailable  
 Determines whether the frame window has a menu bar.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> if the pointer to the menu bar object is not <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>; otherwise <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdiframewndex__ispointneardocksite">\</a>  CMDIFrameWndEx::IsPointNearDockSite  
 Determines whether a specified point is near the dock site.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 The specified point in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 Specifies which edge the point is near. Possible values are <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
  
 [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> if the point is near the outer border of the dock site; <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> if the point is near the dock site; otherwise <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>.  
  
### Remarks  
 The point is near the dock site when it is within the sensitivity set in the docking manager. The default sensitivity is 15 pixels.  
  
##  \<a name="cmdiframewndex__isprintpreview">\</a>  CMDIFrameWndEx::IsPrintPreview  
 Determines whether the frame window is in print-preview mode.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> if the frame window is in print-preview mode; otherwise, <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmdiframewndex__loadframe">\</a>  CMDIFrameWndEx::LoadFrame  
 Creates a frame window from resource information.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 The ID of a shared resource associated with the frame window.  
  
 [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 The style of the frame window.  
  
 [in] <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 A pointer to the frame's parent.  
  
 [in] <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 A pointer to a [CCreateContext Structure](../vs140/ccreatecontext-structure.md). This parameter can be <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> if the method succeeds, otherwise <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdiframewndex__loadmdistate">\</a>  CMDIFrameWndEx::LoadMDIState  
 Loads the specified layout of MDI Tabbed Groups and the list of previously opened documents.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 Specifies the profile name.  
  
### Return Value  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> if the load succeeded; <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> if the load failed or there is no data to load.  
  
### Remarks  
 To load or save the state of MDI tabs and groups and the list of opened documents, do the following:  
  
-   Call [CMDIFrameWndEx::SaveMDIState](#cmdiframewndex__savemdistate) when the main frame is being closed  
  
-   Call [CMDIFrameWndEx::LoadMDIState](#cmdiframewndex__loadmdistate) when the main frame is being created. The recommended place for this call is before the main frame is displayed for the first time. Add <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> Add <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> after the call to <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> to display the main frame at the position that was stored in the registry.  
  
-   Override <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>- derived class if your application displays documents that are not stored as files. The returned string will be saved in the registry as the document identifier. The base implementation of [CMDIChildWndEx::GetDocumentName](../vs140/cmdichildwndex-class.md#cmdichildwndex__getdocumentname) returns a value obtained from [CDocument::GetPathName](../vs140/cdocument-class.md#cdocument__getpathname).  
  
-   Override [CMDIFrameWndEx::CreateDocumentWindow](#cmdiframewndex__createdocumentwindow) to correctly create documents when they are being loaded from the registry. The first parameter is the string that <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> returned.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#11](../vs140/codesnippet/CPP/cmdiframewndex-class_11.cpp)]  
  
##  \<a name="cmdiframewndex__mditabmovetonextgroup">\</a>  CMDIFrameWndEx::MDITabMoveToNextGroup  
 Moves the active tab from the currently active tabbed window to the next or previous tabbed group.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>, move the tab to the next tabbed group. If <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>, move it to the previous tabbed group.  
  
##  \<a name="cmdiframewndex__mditabnewgroup">\</a>  CMDIFrameWndEx::MDITabNewGroup  
 Creates a new tabbed group that has a single window.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 Specifies the new group alignment. If <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>, the new group is aligned vertically. If <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>, the new group is aligned horizontally.  
  
### Remarks  
 Use this function to create a new tabbed window (new tabbed group) and add the first tab to it.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#12](../vs140/codesnippet/CPP/cmdiframewndex-class_12.cpp)]  
  
##  \<a name="cmdiframewndex__m_bcancovertcontrolbartomdichild">\</a>  CMDIFrameWndEx::m_bCanCovertControlBarToMDIChild  
 Specifies whether docking panes can be converted to MDI child windows.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 Indicates whether docking control bars can be converted to MDI child windows. If this flag is <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>, the framework handles the conversion automatically when the user selects the **Tabbed Document** command. The flag is protected and you must explicitly enable this option either by setting <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> in a constructor of a <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>-derived class, or by overriding <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>.  
  
 The default value is <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#13](../vs140/codesnippet/CPP/cmdiframewndex-class_2.cpp)]  
  
##  \<a name="cmdiframewndex__m_bdisablesetredraw">\</a>  CMDIFrameWndEx::m_bDisableSetRedraw  
 Enables or disables redraw optimization for MDI child windows.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 The default value is <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>.  
  
 Set this flag to <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> if you want to optimize redrawing of MDI children. In this case the framework will call <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> for the main frame when the application is changing the active tab.  
  
 This flag can cause unwanted effects (such as background applications that become visible). Therefore we recommend that you change the default only if you experience noticeable flickering during MDI tab activation.  
  
##  \<a name="cmdiframewndex__negotiateborderspace">\</a>  CMDIFrameWndEx::NegotiateBorderSpace  
 Negotiates border space in a frame window during OLE in-place activation.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 Contains one of the following values from the enum <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>:  
  
-   <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> = 1  
  
-   <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> = 2  
  
-   <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> = 3  
  
 [in, out] <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 Pointer to a [RECT Structure](../vs140/rect-structure.md) or a [CRect Class](../vs140/crect-class.md) object that specifies the coordinates of the border.  
  
### Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
### Remarks  
 This method is an implementation of OLE border space negotiation.  
  
##  \<a name="cmdiframewndex__onclosedockingpane">\</a>  CMDIFrameWndEx::OnCloseDockingPane  
 Called by the framework when the user clicks the **Close** button on a dockable pane.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 Pointer to the pane being closed.  
  
### Return Value  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> if the docking pane can be closed. Otherwise, <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method to handle hiding of docking panes. Return <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> if you want to prevent a docking pane from being hidden.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdiframewndex__oncloseminiframe">\</a>  CMDIFrameWndEx::OnCloseMiniFrame  
 Called by the framework when the user clicks the **Close** button on a floating mini-frame window.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 Pointer to the mini-frame window being closed.  
  
### Return Value  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> if the floating mini-frame window can be closed. Otherwise, <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method to handle hiding of floating mini-frame windows. Return <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> if you want to prevent a floating mini-frame window from being hidden.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdiframewndex__onclosepopupmenu">\</a>  CMDIFrameWndEx::OnClosePopupMenu  
 Called by the framework when an active pop-up menu processes a <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 Pointer to a pop-up menu.  
  
### Remarks  
 Override this method if you want to process notifications from [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) objects that belong to the MDI frame window when those objects process <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> messages.  
  
##  \<a name="cmdiframewndex__oncmdmsg">\</a>  CMDIFrameWndEx::OnCmdMsg  
 Called by the framework to route and dispatch command messages and to update command user-interface objects.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 The command ID.  
  
 [in] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 Identifies the command notification code. See [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget-class.md#ccmdtarget__oncmdmsg) for more information about values for <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
 Used according to the value of <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>. See [CCmdTarget::OnCmdMsg](../vs140/ccmdtarget-class.md#ccmdtarget__oncmdmsg) for more information about <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>.  
  
 [in, out] <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 Typically, this parameter should be <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>.If not <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> fills in the <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> members of the <CodeContentPlaceHolder>307\</CodeContentPlaceHolder> structure instead of dispatching the command.  
  
### Return Value  
 Nonzero if the message is handled; otherwise 0.  
  
##  \<a name="cmdiframewndex__ondrawmenuimage">\</a>  CMDIFrameWndEx::OnDrawMenuImage  
 Called by the framework when the image associated with a menu item is drawn.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 Pointer to the menu button.  
  
 [in] <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 Bounding rectangle of the image.  
  
### Return Value  
 <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> if the method draws the image. The default implementation returns <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method  if you want to customize image rendering for the menu items that belong to the menu bar owned by the <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>-derived object. The default implementation does nothing.  
  
##  \<a name="cmdiframewndex__ondrawmenulogo">\</a>  CMDIFrameWndEx::OnDrawMenuLogo  
 Called by the framework when a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)processes a <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 Override this function to display a logo on the pop-up menu that belongs to the menu bar owned by the <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>-derived object. The default implementation does nothing.  
  
##  \<a name="cmdiframewndex__onerasemdiclientbackground">\</a>  CMDIFrameWndEx::OnEraseMDIClientBackground  
 Called by the framework when the MDI frame window processes a <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> if the application processes the message and erases the background.  
  
### Remarks  
 Override this member function if you want to process the <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> message in a <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>-derived class.  
  
##  \<a name="cmdiframewndex__onmenubuttontoolhittest">\</a>  CMDIFrameWndEx::OnMenuButtonToolHitTest  
 Called by the framework when a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)object processes a <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>321\</CodeContentPlaceHolder>  
 The toolbar button.  
  
 [out] <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
 Pointer to a                                 [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure.  
  
### Return Value  
 <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> if the application fills the <CodeContentPlaceHolder>324\</CodeContentPlaceHolder> parameter. The default implementation returns <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method if you want to provide information about specific menu items to a tooltip. The default implementation does nothing.  
  
##  \<a name="cmdiframewndex__onmoveminiframe">\</a>  CMDIFrameWndEx::OnMoveMiniFrame  
 Called by the framework to move a mini-frame window.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 A pointer to a mini-frame window.  
  
### Return Value  
 <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> if the method succeeds, otherwise <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>.  
  
##  \<a name="cmdiframewndex__onsetpreviewmode">\</a>  CMDIFrameWndEx::OnSetPreviewMode  
 Sets the application's main frame window print-preview mode.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>, sets print-preview mode. If <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>, cancels preview mode.  
  
 [in] <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>333\</CodeContentPlaceHolder> structure.  
  
### Remarks  
 This method overrides [CFrameWnd::OnSetPreviewMode](../vs140/cframewnd-class.md#cframewnd__onsetpreviewmode).  
  
##  \<a name="cmdiframewndex__onshowcustomizepane">\</a>  CMDIFrameWndEx::OnShowCustomizePane  
 Called by the framework when a Quick Customize pane is activated.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>  
 A pointer to the Quick Customize pane.  
  
 [in] <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>  
 Control ID of the toolbar to customize.  
  
### Return Value  
 This method always returns <CodeContentPlaceHolder>336\</CodeContentPlaceHolder>.  
  
### Remarks  
 The Quick Customize pane is a menu that opens when the user clicks **Customize** on a toolbar.  
  
 Override this method in a derived class to make changes in the Quick Customize pane.  
  
##  \<a name="cmdiframewndex__onshowmditabcontextmenu">\</a>  CMDIFrameWndEx::OnShowMDITabContextMenu  
 Called by the framework before a shortcut menu is displayed on one of the tabs. Valid for MDI Tabbed Groups only.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
 The location of the menu in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
 A bitwise-OR combination of flags that indicates what actions are allowed for the current tab:  
  
-   <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> - can create a vertical tab group.  
  
-   <CodeContentPlaceHolder>340\</CodeContentPlaceHolder> - can create a horizontal tab group.  
  
-   <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> - can move a tab to the previous tab group.  
  
-   <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> - can move a tab to the next tab group.  
  
-   <CodeContentPlaceHolder>343\</CodeContentPlaceHolder> - switch a tabbed document to docked state (relevant for tabbed documents only).  
  
 [in] <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>345\</CodeContentPlaceHolder> to display the menu as a result of dragging the tab onto another tabbed group. <CodeContentPlaceHolder>346\</CodeContentPlaceHolder> to display the menu as a shortcut menu on the currently active tab.  
  
### Return Value  
 Override this method in a [CBCGPMDIFrameWnd](../vs140/cmdiframewndex-class.md)-derived class.  
  
### Remarks  
 If you do not process <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>, the shortcut menu will not be displayed. This function is generated by the **MFC Application Wizard** when you enable the MDI Tabbed Groups feature.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>348\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#14](../vs140/codesnippet/CPP/cmdiframewndex-class_13.cpp)]  
  
##  \<a name="cmdiframewndex__onshowpanes">\</a>  CMDIFrameWndEx::OnShowPanes  
 Called by the framework to show or hide panes.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>349\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> to show panes, <CodeContentPlaceHolder>351\</CodeContentPlaceHolder> to hide panes.  
  
### Return Value  
 <CodeContentPlaceHolder>352\</CodeContentPlaceHolder> if the state of the panes changes as a result of calling this method, <CodeContentPlaceHolder>353\</CodeContentPlaceHolder> if the panes are already in the state specified by <CodeContentPlaceHolder>354\</CodeContentPlaceHolder>. For example, if the panes are hidden and <CodeContentPlaceHolder>355\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>356\</CodeContentPlaceHolder>, the return value is <CodeContentPlaceHolder>357\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation removes the toolbar from the top-level frame window.  
  
 If [CDockingManager::m_bHideDockingBarsInContainerMode](../vs140/cdockingmanager-class.md#cdockingmanager__m_bhidedockingbarsincontainermode) is <CodeContentPlaceHolder>358\</CodeContentPlaceHolder> (the default), all docking panes will be hidden.  
  
##  \<a name="cmdiframewndex__onshowpopupmenu">\</a>  CMDIFrameWndEx::OnShowPopupMenu  
 Called by the framework when it opens a pop-up menu.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>359\</CodeContentPlaceHolder> if the pop-up menu is to be displayed. Otherwise, <CodeContentPlaceHolder>360\</CodeContentPlaceHolder>. The default implementation returns <CodeContentPlaceHolder>361\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method if you want to implement special processing upon pop-up menu activation. For example, if you want to change regular menu items to color menu buttons, set up tear-off bars, and so on.  
  
 The default implementation does nothing.  
  
##  \<a name="cmdiframewndex__onsizemdiclient">\</a>  CMDIFrameWndEx::OnSizeMDIClient  
 Called by the framework when the size of the client MDI window is changing.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>362\</CodeContentPlaceHolder>  
 The current size of the MDI client window.  
  
 [in] <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>  
 The new size of the MDI client window.  
  
### Remarks  
  
##  \<a name="cmdiframewndex__ontearoffmenu">\</a>  CMDIFrameWndEx::OnTearOffMenu  
 Called by the framework when a menu that has a tear-off bar is activated.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 A pointer to the pop-up menu.  
  
 [in] <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>  
 A pointer to the tear-off bar.  
  
### Return Value  
 <CodeContentPlaceHolder>366\</CodeContentPlaceHolder> to allow the pop-up menu with the tear-off bar to be made activate; otherwise <CodeContentPlaceHolder>367\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>368\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this function when you want to implement a special setup for the tear-off bar. The default implementation does nothing.  
  
##  \<a name="cmdiframewndex__onupdateframemenu">\</a>  CMDIFrameWndEx::OnUpdateFrameMenu  
 Called by the framework to update the frame menu.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
 A handle to a menu.  
  
##  \<a name="cmdiframewndex__panefrompoint">\</a>  CMDIFrameWndEx::PaneFromPoint  
 Returns the docking pane that contains the specified point.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>  
 The point (in screen coordinates).  
  
 [in] <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>  
 The window rectangle of each checked pane is enlarged in all directions by this value.  
  
 [in] <CodeContentPlaceHolder>372\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>374\</CodeContentPlaceHolder> parameter is ignored.  
  
 [in] <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>  
 If non- <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>, the method iterates over only the panes of the specified type.  
  
 [out] <CodeContentPlaceHolder>377\</CodeContentPlaceHolder>  
 If a pane is found, this parameter will specify which side of the pane is closest to the specified point.  
  
### Return Value  
 A pointer to a docking pane, or <CodeContentPlaceHolder>378\</CodeContentPlaceHolder> if no control contains the point specified by <CodeContentPlaceHolder>379\</CodeContentPlaceHolder>.  
  
### Remarks  
 The call is redirected to the [docking manager](../vs140/cdockingmanager-class.md). See [CDockingManager::ControlBarFromPoint](../vs140/cdockingmanager-class.md#cdockingmanager__panefrompoint) for more information.  
  
##  \<a name="cmdiframewndex__recalclayout">\</a>  CMDIFrameWndEx::RecalcLayout  
 Called by the framework to recalculate the layout of the frame window.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>380\</CodeContentPlaceHolder>  
 Determines whether the active in-place item for the frame window receives notification of the layout change. If <CodeContentPlaceHolder>381\</CodeContentPlaceHolder>, the item is notified; otherwise <CodeContentPlaceHolder>382\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method overrides [CFrameWnd::RecalcLayout](../vs140/cframewnd-class.md#cframewnd__recalclayout).  
  
##  \<a name="cmdiframewndex__removepanefromdockmanager">\</a>  CMDIFrameWndEx::RemovePaneFromDockManager  
 Unregisters a pane and removes it from the docking manager.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>383\</CodeContentPlaceHolder>  
 A pointer to a pane to be removed.  
  
 [in] <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>385\</CodeContentPlaceHolder> to destroy the removed pane. <CodeContentPlaceHolder>386\</CodeContentPlaceHolder> to not destroy it.  
  
 [in] <CodeContentPlaceHolder>387\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>388\</CodeContentPlaceHolder> to adjust the docking layout immediately. If <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>, the adjustment will occur only when a redraw event occurs for other reasons (the user resizes the window, drags the main frame, etc.).  
  
 [in] <CodeContentPlaceHolder>390\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>391\</CodeContentPlaceHolder> to remove the pane from the list of autohide panes. <CodeContentPlaceHolder>392\</CodeContentPlaceHolder> to remove the pane from the list of regular panes.  
  
 [in] <CodeContentPlaceHolder>393\</CodeContentPlaceHolder>  
 A pointer to a pane that replaces the removed pane.  
  
### Remarks  
 You must register each pane with the docking manager to take part in the docking layout. Use [AddPane](#cmdiframewndex__addpane) or [InsertPane](#cmdiframewndex__insertpane) to register panes.  
  
 Use this method when a pane is no longer a part of the docking layout of the frame window.  
  
##  \<a name="cmdiframewndex__savemdistate">\</a>  CMDIFrameWndEx::SaveMDIState  
 Saves the current layout of MDI Tabbed Groups and the list of previously opened documents.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>394\</CodeContentPlaceHolder>  
 Specifies the profile name.  
  
### Return Value  
 <CodeContentPlaceHolder>395\</CodeContentPlaceHolder> if the save succeeded; <CodeContentPlaceHolder>396\</CodeContentPlaceHolder> if the save failed.  
  
### Remarks  
 To load or save the state of MDI tabs and groups and the list of opened documents, do the following:  
  
-   Call <CodeContentPlaceHolder>397\</CodeContentPlaceHolder> when the main frame is being closed  
  
-   Call [CMDIFrameWndEx::LoadMDIState](#cmdiframewndex__loadmdistate) when the main frame is being created. The recommended location for this call is before the main frame is displayed for the first time.  
  
-   Call <CodeContentPlaceHolder>398\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>399\</CodeContentPlaceHolder>  
  
-   Call <CodeContentPlaceHolder>400\</CodeContentPlaceHolder> after <CodeContentPlaceHolder>401\</CodeContentPlaceHolder> to display the main frame at the position that was stored in the registry.  
  
-   Override <CodeContentPlaceHolder>402\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>403\</CodeContentPlaceHolder>- derived class if your application displays documents that are not stored as files. The returned string will be saved in the registry as a document identifier. For more information, see [CMDIChildWndEx::GetDocumentName](../vs140/cmdichildwndex-class.md#cmdichildwndex__getdocumentname).  
  
-   Override [CMDIFrameWndEx::CreateDocumentWindow](#cmdiframewndex__createdocumentwindow) to correctly create documents when they are loaded from the registry. The parameter to <CodeContentPlaceHolder>404\</CodeContentPlaceHolder> is the string that <CodeContentPlaceHolder>405\</CodeContentPlaceHolder> returned earlier.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>406\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#15](../vs140/codesnippet/CPP/cmdiframewndex-class_14.cpp)]  
  
##  \<a name="cmdiframewndex__setprintpreviewframe">\</a>  CMDIFrameWndEx::SetPrintPreviewFrame  
 Sets the print preview frame window.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>407\</CodeContentPlaceHolder>  
 Pointer to a print preview frame window.  
  
### Remarks  
  
##  \<a name="cmdiframewndex__setuptoolbarmenu">\</a>  CMDIFrameWndEx::SetupToolbarMenu  
 Modifies a toolbar object by replacing dummy items with user-defined items.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>408\</CodeContentPlaceHolder>  
 A reference to a [CMenu Class](../vs140/cmenu-class.md) object to be modified.  
  
 [in] <CodeContentPlaceHolder>409\</CodeContentPlaceHolder>  
 Specifies the first user-defined command.  
  
 [in] <CodeContentPlaceHolder>410\</CodeContentPlaceHolder>  
 Specifies the last user-defined command.  
  
##  \<a name="cmdiframewndex__showfullscreen">\</a>  CMDIFrameWndEx::ShowFullScreen  
 Switches the main frame from regular mode to full-screen mode.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmdiframewndex__showpane">\</a>  CMDIFrameWndEx::ShowPane  
 Shows or hides the specified pane.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>411\</CodeContentPlaceHolder>  
 Pointer to the pane to be shown or hidden.  
  
 [in] <CodeContentPlaceHolder>412\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>413\</CodeContentPlaceHolder> to show the pane. <CodeContentPlaceHolder>414\</CodeContentPlaceHolder> to hide the pane.  
  
 [in] <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>416\</CodeContentPlaceHolder> to delay the recalculation of the docking layout. <CodeContentPlaceHolder>417\</CodeContentPlaceHolder> to recalculate the docking layout immediately.  
  
 [in] <CodeContentPlaceHolder>418\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>419\</CodeContentPlaceHolder> to show the pane should as active. <CodeContentPlaceHolder>420\</CodeContentPlaceHolder> to show the pane as inactive.  
  
### Remarks  
 Call this method to show or hide the pane. Do not use <CodeContentPlaceHolder>421\</CodeContentPlaceHolder> for docking panes.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>422\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#16](../vs140/codesnippet/CPP/cmdiframewndex-class_15.cpp)]  
  
##  \<a name="cmdiframewndex__showwindowsdialog">\</a>  CMDIFrameWndEx::ShowWindowsDialog  
 Creates a [CMFCWindowsManagerDialog](../vs140/cmfcwindowsmanagerdialog-class.md) box and opens it.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Example  
 The following example shows how <CodeContentPlaceHolder>423\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#18](../vs140/codesnippet/CPP/cmdiframewndex-class_16.cpp)]  
  
##  \<a name="cmdiframewndex__tabbeddocumenttocontrolbar">\</a>  CMDIFrameWndEx::TabbedDocumentToControlBar  
 Converts the specified tabbed document to a docking pane.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>424\</CodeContentPlaceHolder>  
 A pointer to MDI child window that contains a docking pane.  
  
### Return Value  
 <CodeContentPlaceHolder>425\</CodeContentPlaceHolder> if the method was successful, <CodeContentPlaceHolder>426\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Use this method to convert a tabbed document to a docking pane. The tabbed document must have been created by using [PaneToTabbedDocument](#cmdiframewndex__controlbartotabbeddocument).  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>427\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#19](../vs140/codesnippet/CPP/cmdiframewndex-class_17.cpp)]  
  
##  \<a name="cmdiframewndex__updatecaption">\</a>  CMDIFrameWndEx::UpdateCaption  
 Called by the framework to update the window frame caption.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmdiframewndex__updatemditabbedbarsicons">\</a>  CMDIFrameWndEx::UpdateMDITabbedBarsIcons  
 Sets the icon for each MDI tabbed pane.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
##  \<a name="cmdiframewndex__winhelp">\</a>  CMDIFrameWndEx::WinHelp  
 Called by the framework to initiate the WinHelp application or context help.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>428\</CodeContentPlaceHolder>  
 Specifies data as required for the type of help specified by <CodeContentPlaceHolder>429\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>430\</CodeContentPlaceHolder>  
 Specifies the type of help requested. For a list of possible values and how they affect the <CodeContentPlaceHolder>431\</CodeContentPlaceHolder> parameter, see the                                 [WinHelp Function](http://msdn.microsoft.com/library/windows/desktop/bb762267) in the Windows SDK.  
  
### Remarks  
 This method overrides [CWnd::WinHelp](../vs140/cwnd-class.md#cwnd__winhelp).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMDIFrameWnd](../vs140/cframewnd-class.md)   
 [CMDIChildWndEx](../vs140/cmdichildwndex-class.md)