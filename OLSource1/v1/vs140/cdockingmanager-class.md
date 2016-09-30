---
title: "CDockingManager Class"
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
  - "CDockingManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDockingManager class"
ms.assetid: 98e69c43-55d8-4f43-b861-4fda80ec1e32
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager Class
Implements the core functionality that controls docking layout in a main frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDockingManager::AddDockSite](#cdockingmanager__adddocksite)|Creates a dock pane and adds it to the list of control bars.|  
|[CDockingManager::AddHiddenMDITabbedBar](#cdockingmanager__addhiddenmditabbedbar)|Adds a handle to a bar pane to the list of hidden MDI tabbed bar panes.|  
|[CDockingManager::AddMiniFrame](#cdockingmanager__addminiframe)|Adds a frame to the list of mini frames.|  
|[CDockingManager::AddPane](#cdockingmanager__addpane)|Registers a pane with the docking manager.|  
|[CDockingManager::AdjustDockingLayout](#cdockingmanager__adjustdockinglayout)|Recalculates and adjusts the layout of all panes in a frame window.|  
|[CDockingManager::AdjustPaneFrames](#cdockingmanager__adjustpaneframes)|Causes the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> message to be sent to all panes and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> windows.|  
|[CDockingManager::AdjustRectToClientArea](#cdockingmanager__adjustrecttoclientarea)|Adjusts the alignment of a rectangle.|  
|[CDockingManager::AlignAutoHidePane](#cdockingmanager__alignautohidepane)|Resizes a docking pane in autohide mode so that it takes the full width or height of the frame’s client area surrounded by dock sites.|  
|[CDockingManager::AutoHidePane](#cdockingmanager__autohidepane)|Creates an autohide toolbar.|  
|[CDockingManager::BringBarsToTop](#cdockingmanager__bringbarstotop)|Brings the docked bars that have the specified alignment to the top.|  
|[CDockingManager::BuildPanesMenu](#cdockingmanager__buildpanesmenu)|Adds names of docking panes and toolbars to a menu.|  
|[CDockingManager::CalcExpectedDockedRect](#cdockingmanager__calcexpecteddockedrect)|Calculates the expected rectangle of a docked window.|  
|[CDockingManager::Create](#cdockingmanager__create)|Creates a docking manager.|  
|[CDockingManager::DeterminePaneAndStatus](#cdockingmanager__determinepaneandstatus)|Determines the pane that contains a given point and its docking status.|  
|[CDockingManager::DisableRestoreDockState](#cdockingmanager__disablerestoredockstate)|Enables or disables loading of docking layout from the registry.|  
|[CDockingManager::DockPane](#cdockingmanager__dockpane)|Docks a pane to another pane or to a frame window.|  
|[CDockingManager::DockPaneLeftOf](#cdockingmanager__dockpaneleftof)|Docks a pane to the left of another pane.|  
|[CDockingManager::EnableAutoHidePanes](#cdockingmanager__enableautohidepanes)|Enables docking of the pane to the main frame, creates a dock pane, and adds it to the list of control bars.|  
|[CDockingManager::EnableDocking](#cdockingmanager__enabledocking)|Creates a dock pane and enables docking of the pane to the main frame.|  
|[CDockingManager::EnableDockSiteMenu](#cdockingmanager__enabledocksitemenu)|Displays an additional button that opens a pop-up menu on the captions of all docking panes.|  
|[CDockingManager::EnablePaneContextMenu](#cdockingmanager__enablepanecontextmenu)|Tells the library to display a special context menu that has a list of application toolbars and docking panes when the user clicks the right mouse button and the library is processing the WM_CONTEXTMENU message.|  
|[CDockingManager::FindDockSite](#cdockingmanager__finddocksite)|Retrieves the bar pane that is at the specified position and that has the specified alignment.|  
|[CDockingManager::FindDockSiteByPane](#cdockingmanager__finddocksitebypane)|Returns the bar pane that has the id of the target bar pane.|  
|[CDockingManager::FindPaneByID](#cdockingmanager__findpanebyid)|Finds a pane by the specified control ID.|  
|[CDockingManager::FixupVirtualRects](#cdockingmanager__fixupvirtualrects)|Commits all current toolbar positions to virtual rectangles.|  
|[CDockingManager::FrameFromPoint](#cdockingmanager__framefrompoint)|Returns the frame that contains the given point.|  
|[CDockingManager::GetClientAreaBounds](#cdockingmanager__getclientareabounds)|Gets the rectangle that contains the bounds of the client area.|  
|[CDockingManager::GetDockingMode](#cdockingmanager__getdockingmode)|Returns the current docking mode.|  
|[CDockingManager::GetDockSiteFrameWnd](#cdockingmanager__getdocksiteframewnd)|Gets a pointer to the parent window frame.|  
|[CDockingManager::GetEnabledAutoHideAlignment](#cdockingmanager__getenabledautohidealignment)|Returns the enabled alignment of the panes.|  
|[CDockingManager::GetMiniFrames](#cdockingmanager__getminiframes)|Gets a list of miniframes.|  
|[CDockingManager::GetOuterEdgeBounds](#cdockingmanager__getouteredgebounds)|Gets a rectangle that contains the outer edges of the frame.|  
|[CDockingManager::GetPaneList](#cdockingmanager__getpanelist)|Returns a list of panes that belong to the docking manager. This includes all floating panes.|  
|[CDockingManager::GetSmartDockingManager](#cdockingmanager__getsmartdockingmanager)|Retrieves a pointer to the smart docking manager.|  
|[CDockingManager::GetSmartDockingManagerPermanent](#cdockingmanager__getsmartdockingmanagerpermanent)|Retrieves a pointer to the smart docking manager.|  
|[CDockingManager::GetSmartDockingParams](#cdockingmanager__getsmartdockingparams)|Returns the smart docking parameters for the docking manager.|  
|[CDockingManager::GetSmartDockingTheme](#cdockingmanager__getsmartdockingtheme)|A static method that returns a theme used to display smart docking markers.|  
|[CDockingManager::HideAutoHidePanes](#cdockingmanager__hideautohidepanes)|Hides a pane that is in autohide mode.|  
|[CDockingManager::InsertDockSite](#cdockingmanager__insertdocksite)|Creates a dock pane and inserts it into the list of control bars.|  
|[CDockingManager::InsertPane](#cdockingmanager__insertpane)|Inserts a control pane into the list of control bars.|  
|[CDockingManager::IsDockSiteMenu](#cdockingmanager__isdocksitemenu)|Specifies whether a pop-up menu is displayed on the captions of all panes.|  
|[CDockingManager::IsInAdjustLayout](#cdockingmanager__isinadjustlayout)|Determines if the layouts of all panes are adjusted.|  
|[CDockingManager::IsOLEContainerMode](#cdockingmanager__isolecontainermode)|Specifies whether the docking manager is in OLE container mode.|  
|[CDockingManager::IsPointNearDockSite](#cdockingmanager__ispointneardocksite)|Determines whether a specified point is near the dock site.|  
|[CDockingManager::IsPrintPreviewValid](#cdockingmanager__isprintpreviewvalid)|Determines if the print preview mode is set.|  
|[CDockingManager::LoadState](#cdockingmanager__loadstate)|Loads the docking manager's state from the registry.|  
|[CDockingManager::LockUpdate](#cdockingmanager__lockupdate)|Locks the given window.|  
|[CDockingManager::OnActivateFrame](#cdockingmanager__onactivateframe)|Called by the framework when the frame window is made active or is deactivated.|  
|[CDockingManager::OnClosePopupMenu](#cdockingmanager__onclosepopupmenu)|Called by the framework when an active pop-up menu processes a WM_DESTROY message.|  
|[CDockingManager::OnMoveMiniFrame](#cdockingmanager__onmoveminiframe)|Called by the framework to move a mini-frame window.|  
|[CDockingManager::OnPaneContextMenu](#cdockingmanager__onpanecontextmenu)|Called by the framework when it builds a menu that has a list of panes.|  
|[CDockingManager::PaneFromPoint](#cdockingmanager__panefrompoint)|Returns the pane that contains the given point.|  
|[CDockingManager::ProcessPaneContextMenuCommand](#cdockingmanager__processpanecontextmenucommand)|Called by the framework to select or to clear a check box for the specified command and recalculate the layout of a shown pane.|  
|[CDockingManager::RecalcLayout](#cdockingmanager__recalclayout)|Recalculates the internal layout of the controls present in the list of controls.|  
|[CDockingManager::ReleaseEmptyPaneContainers](#cdockingmanager__releaseemptypanecontainers)|Releases the empty pane containers.|  
|[CDockingManager::RemoveHiddenMDITabbedBar](#cdockingmanager__removehiddenmditabbedbar)|Removes the specified hidden bar pane.|  
|[CDockingManager::RemoveMiniFrame](#cdockingmanager__removeminiframe)|Removes a specified frame from the list of mini frames.|  
|[CDockingManager::RemovePaneFromDockManager](#cdockingmanager__removepanefromdockmanager)|Unregisters a pane and removes it from the list in the docking manager.|  
|[CDockingManager::ReplacePane](#cdockingmanager__replacepane)|Replaces one pane with another.|  
|[CDockingManager::ResortMiniFramesForZOrder](#cdockingmanager__resortminiframesforzorder)|Resorts the frames in the list of mini frames.|  
|[CDockingManager::SaveState](#cdockingmanager__savestate)|Saves the docking manager's state to the registry.|  
|[CDockingManager::SendMessageToMiniFrames](#cdockingmanager__sendmessagetominiframes)|Sends the specified message to all mini frames.|  
|[CDockingManager::Serialize](#cdockingmanager__serialize)|Writes the docking manager to an archive. (Overrides [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize).)|  
|[CDockingManager::SetAutohideZOrder](#cdockingmanager__setautohidezorder)|Sets the size, width, and height of the control bars and the specified pane.|  
|[CDockingManager::SetDockingMode](#cdockingmanager__setdockingmode)|Sets the docking mode.|  
|[CDockingManager::SetDockState](#cdockingmanager__setdockstate)|Sets the docking state of the control bars, the mini frames, and the autohide bars.|  
|[CDockingManager::SetPrintPreviewMode](#cdockingmanager__setprintpreviewmode)|Sets the print preview mode of the bars that are displayed in the print preview.|  
|[CDockingManager::SetSmartDockingParams](#cdockingmanager__setsmartdockingparams)|Sets the parameters that define the behavior of smart docking.|  
|[CDockingManager::ShowDelayShowMiniFrames](#cdockingmanager__showdelayshowminiframes)|Shows or hides the windows of the mini frames.|  
|[CDockingManager::ShowPanes](#cdockingmanager__showpanes)|Shows or hides the panes of the control and autohide bars.|  
|[CDockingManager::StartSDocking](#cdockingmanager__startsdocking)|Starts the smart docking of the specified window according to the alignment of the smart docking manager.|  
|[CDockingManager::StopSDocking](#cdockingmanager__stopsdocking)|Stops smart docking.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDockingManager::m_bHideDockingBarsInContainerMode](#cdockingmanager__m_bhidedockingbarsincontainermode)|Specifies whether the docking manager hides panes in OLE container mode.|  
|[CDockingManager::m_dockModeGlobal](#cdockingmanager__m_dockmodeglobal)|Specifies the global docking mode.|  
|[CDockingManager::m_nDockSencitivity](#cdockingmanager__m_ndocksensitivity)|Specifies the docking sensitivity.|  
|[CDockingManager::m_nTimeOutBeforeDockingBarDock](#cdockingmanager__m_ntimeoutbeforedockingbardock)|Specifies the time, in milliseconds, before a docking pane is docked in immediate docking mode.|  
|[CDockingManager::m_nTimeOutBeforeToolBarDock](#cdockingmanager__m_ntimeoutbeforetoolbardock)|Specifies the time, in milliseconds, before a toolbar is docked to the main frame window.|  
  
## Remarks  
 The main frame window creates and initializes this class automatically.  
  
 The docking manager object holds a list of all panes that are in the docking layout, and also a list of all [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) windows that belong to the main frame window.  
  
 The <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> class implements some services that you can use to find a pane or a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> window. You usually do not call these services directly because they are wrapped in the main frame window object. For more information, see [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md).  
  
## Customization Tips  
 The following tips apply to <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> objects:  
  
-   [CDockingManager Class](../vs140/cdockingmanager-class.md) supports these docking modes:  
  
    -   <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
     These docking modes are defined by [CDockingManager::m_dockModeGlobal](#cdockingmanager__m_dockmodeglobal) and are set by calling [CDockingManager::SetDockingMode](#cdockingmanager__setdockingmode).  
  
-   If you want to create a non-floating, non-resizable pane, call the [CDockingManager::AddPane](#cdockingmanager__addpane) method. This method registers the pane with the docking manager, which is responsible for the layout of the pane.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> class to configure a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object. The example shows how to display an additional button that opens a pop-up menu on the captions of all docking panes and how to set the docking mode of the object. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#24](../vs140/codesnippet/CPP/cdockingmanager-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CDockingManager](../vs140/cdockingmanager-class.md)  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
##  \<a name="cdockingmanager__adddocksite">\</a>  CDockingManager::AddDockSite  
 Creates a dock pane and adds it to the list of control bars.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 A reference to an info structure that contains dock pane alignment.  
  
 [out] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A pointer to a pointer to the new dock pane.  
  
### Return Value  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> if the dock pane was created successfully; <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__addhiddenmditabbedbar">\</a>  CDockingManager::AddHiddenMDITabbedBar  
 Adds a handle to a bar pane to the list of hidden MDI tabbed bar panes.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 A pointer to a bar pane  
  
##  \<a name="cdockingmanager__addpane">\</a>  CDockingManager::AddPane  
 Registers a pane with the docking manager.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Specifies the pane to add to the docking manager.  
  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> to add the pane to the end of the list of panes for the docking manager; otherwise, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 For internal use only. Always use the default value <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 For internal use only. Always use the default value <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> if the pane was successfully registered with the docking manager; otherwise, <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to register non-floating, non-resizable panes with the docking manager. If you do not register the panes, they will not appear correctly when the docking manager is laid out.  
  
##  \<a name="cdockingmanager__adjustdockinglayout">\</a>  CDockingManager::AdjustDockingLayout  
 Recalculates and adjusts the layout of all panes in a frame window.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Specifies the deferred window position structure. For more information, see                                 [Windows Data Types](http://msdn.microsoft.com/library/windows/desktop/aa383751).  
  
### Remarks  
  
##  \<a name="cdockingmanager__addminiframe">\</a>  CDockingManager::AddMiniFrame  
 Adds a frame to the list of mini frames.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A pointer to a frame.  
  
### Return Value  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> if the frame is not in the list of mini frames and was added successfully; <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__adjustpaneframes">\</a>  CDockingManager::AdjustPaneFrames  
 Causes the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> message to be sent to all panes and <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> windows.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdockingmanager__adjustrecttoclientarea">\</a>  CDockingManager::AdjustRectToClientArea  
 Adjusts the alignment of a rectangle.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object  
  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The alignment of the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object  
  
### Return Value  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> if the alignment of the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object was adjusted; <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> parameter can have one of the following values:  
  
-   CBRS_ALIGN_TOP  
  
-   CBRS_ALIGN_BOTTOM  
  
-   CBRS_ALIGN_LEFT  
  
-   CBRS_ALIGN_RIGHT  
  
##  \<a name="cdockingmanager__alignautohidepane">\</a>  CDockingManager::AlignAutoHidePane  
 Resizes a docking pane in autohide mode so that it takes the full width or height of the frame’s client area surrounded by dock sites.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The docking slider pane.  
  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> if the docking pane is visible; <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__autohidepane">\</a>  CDockingManager::AutoHidePane  
 Creates an autohide toolbar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 A pointer to the bar pane.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 A pointer to an auto hide toolbar.  
  
### Return Value  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> if the auto hide toolbar was not created; otherwise a pointer to the new toolbar.  
  
##  \<a name="cdockingmanager__bringbarstotop">\</a>  CDockingManager::BringBarsToTop  
 Brings the docked bars that have the specified alignment to the top.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The alignment of the dock bars that are brought to the top of other windows.  
  
 [in] <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> to exclude the docked bars from being on top; otherwise  <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__buildpanesmenu">\</a>  CDockingManager::BuildPanesMenu  
 Adds names of docking panes and toolbars to a menu.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 A menu to add the names of docking panes and toolbars to.  
  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> to add only toolbar names to the menu; <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__calcexpecteddockedrect">\</a>  CDockingManager::CalcExpectedDockedRect  
 Calculates the expected rectangle of a docked window.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 A pointer to the window to dock.  
  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The mouse location.  
  
 [out] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The calculated rectangle.  
  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> to draw a tab; otherwise <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 A pointer to a pointer to the target pane.  
  
### Remarks  
 This method calculates the rectangle that a window would occupy if a user dragged the window to the point specified by <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> and docked it there.  
  
##  \<a name="cdockingmanager__create">\</a>  CDockingManager::Create  
 Creates a docking manager.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 A pointer to the parent frame of the docking manager. This value must not be <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> always.  
  
##  \<a name="cdockingmanager__determinepaneandstatus">\</a>  CDockingManager::DeterminePaneAndStatus  
 Determines the pane that contains a given point and its docking status.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The location of the pane to check.  
  
 [in] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The value to increase the window rectangle of each checked pane. A pane satisfies the search criteria if the given point is in this increased region.  
  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 The alignment of the docking pane.  
  
 [out] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 A pointer to a pointer to the target pane.  
  
 [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The pane that the method ignores.  
  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The pane that is docked.  
  
### Return Value  
 The docking status.  
  
### Remarks  
 The docking status can be one of the following values:  
  
|AFX_CS_STATUS value|Meaning|  
|---------------------------|-------------|  
|CS_NOTHING|The pointer is not over a dock site. Therefore, keep the pane floating.|  
|CS_DOCK_IMMEDIATELY|The pointer is over the dock site in the immediate mode (DT_IMMEDIATE style is enabled), so the pane must be docked immediately.|  
|CS_DELAY_DOCK|The pointer is over a dock site that is another docking pane or is an edge of the main frame.|  
|CS_DELAY_DOCK_TO_TAB|The pointer is over a dock site that causes the pane to be docked in a tabbed window. This occurs when the mouse is over a caption of another docking pane or over a tab area of a tabbed pane.|  
  
##  \<a name="cdockingmanager__disablerestoredockstate">\</a>  CDockingManager::DisableRestoreDockState  
 Enables or disables loading of docking layout from the registry.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> to disable loading of docking layout from the registry; otherwise, <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method when you must preserve the current layout of docking panes and toolbars when the application state is loading.  
  
##  \<a name="cdockingmanager__dockpane">\</a>  CDockingManager::DockPane  
 Docks a pane to another pane or to a frame window.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A pointer to a bar pane to dock to.  
  
 [in] <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 The id of the bar to dock.  
  
 [in] <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 The destination rectangle.  
  
##  \<a name="cdockingmanager__dockpaneleftof">\</a>  CDockingManager::DockPaneLeftOf  
 Docks a pane to the left of another pane.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 A pointer to the pane to be docked to the left of <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 A pointer to the target pane.  
  
### Return Value  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> if the pane was docked successfully; otherwise, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__enableautohidepanes">\</a>  CDockingManager::EnableAutoHidePanes  
 Enables docking of the pane to the main frame, creates a dock pane, and adds it to the list of control bars.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 The docking alignment.  
  
### Return Value  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if the dock pane was created successfully; <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__enabledocking">\</a>  CDockingManager::EnableDocking  
 Creates a dock pane and enables docking of the pane to the main frame.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 The docking alignment.  
  
### Return Value  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> if the dock pane was created successfully; <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__enabledocksitemenu">\</a>  CDockingManager::EnableDockSiteMenu  
 Displays an additional button that opens a pop-up menu on the captions of all docking panes.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> to enable the dock site menu; otherwise, <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>.  
  
### Remarks  
 The dock site menu displays the following options for changing the docking state of the pane:  
  
-   <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> - Floats a pane  
  
-   <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> - Docks a pane at the main frame at the location where the pane was last docked  
  
-   <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> - Switches the pane to autohide mode  
  
-   <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> - Hides a pane  
  
 By default, this menu is not displayed.  
  
##  \<a name="cdockingmanager__enablepanecontextmenu">\</a>  CDockingManager::EnablePaneContextMenu  
 Tells the library to display a special context menu that has a list of application toolbars and docking panes when the user clicks the right mouse button and the library is processing the WM_CONTEXTMENU message.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>, the library turns on the support for automatic context menu; if <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> the library turns off the support for automatic context menu.  
  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 A command id for the **Customize** item in the menu.  
  
 [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 The text of the **Customize** item.  
  
 [in] <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>, the menu displays only a list of application toolbars; if <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, the library adds application docking panes to this list.  
  
##  \<a name="cdockingmanager__finddocksite">\</a>  CDockingManager::FindDockSite  
 Retrieves the bar pane that is at the specified position and that has the specified alignment.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 The alignment of the bar pane.  
  
 [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, retrieve the bar in the head position in the list of control bars. Otherwise, retrieve the bar in the tail position in the list of control bars.  
  
### Return Value  
 The docking pane that has the specified alignment; <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__findpanebyid">\</a>  CDockingManager::FindPaneByID  
 Finds a pane by the specified control ID.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 Specifies the control ID of the pane to find.  
  
 [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> to include all floating panes in the search. <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> to include only the docked panes.  
  
### Return Value  
 The [CBasePane](../vs140/cbasepane-class.md) object that has the specified control ID, or <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> if the specified pane cannot be found.  
  
### Remarks  
  
##  \<a name="cdockingmanager__finddocksitebypane">\</a>  CDockingManager::FindDockSiteByPane  
 Returns the bar pane that has the id of the target bar pane.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 A pointer to the target bar pane.  
  
### Return Value  
 The bar pane that has the id of the target bar pane; <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> if no such bar pane exists.  
  
##  \<a name="cdockingmanager__fixupvirtualrects">\</a>  CDockingManager::FixupVirtualRects  
 Commits all current toolbar positions to virtual rectangles.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 When the user starts to drag a toolbar, the application remembers its original position in the *virtual rectangle*. When the user moves a toolbar across its dock site, the toolbar may shift other toolbars. The original positions of the other toolbars are stored in the corresponding virtual rectangles.  
  
##  \<a name="cdockingmanager__framefrompoint">\</a>  CDockingManager::FrameFromPoint  
 Returns the frame that contains the given point.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 Specifies the point, in screen coordinates, to check.  
  
 [in] <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 A pointer to a frame to exclude.  
  
 [in] <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> to exclude frames that are not instances of <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 The frame that contains the given point; <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__getclientareabounds">\</a>  CDockingManager::GetClientAreaBounds  
 Gets the rectangle that contains the bounds of the client area.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 A reference to the rectangle that contains the bounds of the client area.  
  
### Return Value  
 The rectangle that contains the bounds of the client area.  
  
##  \<a name="cdockingmanager__getdockingmode">\</a>  CDockingManager::GetDockingMode  
 Returns the current docking mode.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 An enumerator value that represents the current docking mode. It can be one of the following values:  
  
-   <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
  
### Remarks  
 To set the docking mode, call [CDockingManager::SetDockingMode](#cdockingmanager__setdockingmode).  
  
##  \<a name="cdockingmanager__getdocksiteframewnd">\</a>  CDockingManager::GetDockSiteFrameWnd  
 Gets a pointer to the parent window frame.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent window frame.  
  
##  \<a name="cdockingmanager__getenabledautohidealignment">\</a>  CDockingManager::GetEnabledAutoHideAlignment  
 Returns the enabled alignment of the panes.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 A bitwise combination of <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> flags, or 0 if autohide panes are not enabled. For more information, see [CFrameWnd::EnableDocking](../vs140/cframewnd-class.md#cframewnd__enabledocking).  
  
### Remarks  
 The method returns the enabled alignment for autohide control bars. To enable autohide bars, call [CFrameWndEx::EnableAutoHidePanes](../vs140/cframewndex-class.md#cframewndex__enableautohidepanes).  
  
##  \<a name="cdockingmanager__getminiframes">\</a>  CDockingManager::GetMiniFrames  
 Gets a list of miniframes.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 A list of miniframes that contain the control bars that belong to the docking manager.  
  
##  \<a name="cdockingmanager__getouteredgebounds">\</a>  CDockingManager::GetOuterEdgeBounds  
 Gets a rectangle that contains the outer edges of the frame.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 A rectangle that contains the outer edges of the frame.  
  
##  \<a name="cdockingmanager__getpanelist">\</a>  CDockingManager::GetPaneList  
 Returns a list of panes that belong to the docking manager. This includes all floating panes.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 Contains all the panes of the current docking manager.  
  
 [in] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> to include the panes that are in autohide mode; otherwise, <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>, the returned list contains panes only of the specified runtime class.  
  
 [in] <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> to include tabs; otherwise, <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>.  
  
### Remarks  
 If there are any tabbed panes in the docking manager, the method returns pointers to [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md) objects and you must enumerate the tabs explicitly.  
  
 Use <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> to obtain a particular class of panes. For example, you can obtain only toolbars by setting this value appropriately.  
  
##  \<a name="cdockingmanager__getsmartdockingmanager">\</a>  CDockingManager::GetSmartDockingManager  
 Retrieves a pointer to the smart docking manager.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the [smart docking manager](assetId:///f537a1a6-fb9e-41d7-952f-0f25d5ee7534).  
  
##  \<a name="cdockingmanager__getsmartdockingmanagerpermanent">\</a>  CDockingManager::GetSmartDockingManagerPermanent  
 Retrieves a pointer to the smart docking manager.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the smart docking manager.  
  
##  \<a name="cdockingmanager__getsmartdockingparams">\</a>  CDockingManager::GetSmartDockingParams  
 Returns the smart docking parameters for the docking manager.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 The class that contains the smart docking parameters for the current docking manager. For more information, see [CSmartDockingInfo Class](../vs140/csmartdockinginfo-class.md).  
  
### Remarks  
  
##  \<a name="cdockingmanager__hideautohidepanes">\</a>  CDockingManager::HideAutoHidePanes  
 Hides a pane that is in autohide mode.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 A pointer to a bar to exclude from hiding.  
  
 [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> to hide the pane immediately; <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> to hide the pane with the autohide effect.  
  
##  \<a name="cdockingmanager__insertdocksite">\</a>  CDockingManager::InsertDockSite  
 Creates a dock pane and inserts it into the list of control bars.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 A structure that contains the alignment information about the dock pane.  
  
 [in] <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 Alignment of the dock pane.  
  
 [out] <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 A pointer to a pointer to a dock pane.  
  
### Return Value  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> if the dock pane was created successfully; <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__insertpane">\</a>  CDockingManager::InsertPane  
 Inserts a control pane into the list of control bars.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 A pointer to a control pane.  
  
 [in] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 A pointer to a target pane.  
  
 [in] <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> to insert the pane after the position of the target pane; <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> if the control pane is successfully added to the list of control bars;  <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 This method returns false if the control pane is already in the list of control bars or if the target pane does not exist in the list of control bars.  
  
##  \<a name="cdockingmanager__isdocksitemenu">\</a>  CDockingManager::IsDockSiteMenu  
 Specifies whether a pop-up menu is displayed on the captions of all panes.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> if a dock site menu is displayed on the captions of all docking panes; otherwise <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can enable the dock site menu by calling [CDockingManager::EnableDockSiteMenu](#cdockingmanager__enabledocksitemenu).  
  
##  \<a name="cdockingmanager__isinadjustlayout">\</a>  CDockingManager::IsInAdjustLayout  
 Determines if the layouts of all panes are adjusted.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> if the layouts of all panes are adjusted; <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__isolecontainermode">\</a>  CDockingManager::IsOLEContainerMode  
 Specifies whether the docking manager is in OLE container mode.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> if the docking manager is in OLE container mode; otherwise, <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>.  
  
### Remarks  
 In OLE container mode, all docking panes and application toolbars are hidden. The panes are also hidden in this mode if you have set [CDockingManager::m_bHideDockingBarsInContainerMode](#cdockingmanager__m_bhidedockingbarsincontainermode) to <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__ispointneardocksite">\</a>  CDockingManager::IsPointNearDockSite  
 Determines whether a specified point is near the dock site.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 The specified point.  
  
 [out] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 Specifies which edge the point is near. Possible values are <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> if the point is near the outer border of the dock site; <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> if the point is near the dock site; otherwise <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__isprintpreviewvalid">\</a>  CDockingManager::IsPrintPreviewValid  
 Determines if the print preview mode is set.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> if the print preview mode is set; <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__loadstate">\</a>  CDockingManager::LoadState  
 Loads the docking manager's state from the registry.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 Profile name.  
  
 [in] <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 The id of the docking manager.  
  
### Return Value  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> if the docking manager state was loaded successfully; otherwise <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__lockupdate">\</a>  CDockingManager::LockUpdate  
 Locks the given window.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> if the window is locked; <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 When a window is locked, it cannot be moved and it cannot be redrawn.  
  
##  \<a name="cdockingmanager__m_bhidedockingbarsincontainermode">\</a>  CDockingManager::m_bHideDockingBarsInContainerMode  
 Specifies whether the docking manager hides panes in OLE container mode.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Remarks  
 Set this value to <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> if you want to keep all panes docked to the main frame visible when the application is in OLE container mode. By default, this value is <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__m_dockmodeglobal">\</a>  CDockingManager::m_dockModeGlobal  
 Specifies the global docking mode.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 By default, each docking pane uses this docking mode. For more information about the values that this field can be set to, see [CBasePane::GetDockingMode](../vs140/cbasepane-class.md#cbasepane__getdockingmode).  
  
##  \<a name="cdockingmanager__m_ndocksensitivity">\</a>  CDockingManager::m_nDockSensitivity  
 Specifies the docking sensitivity.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Remarks  
 The docking sensitivity defines how close a floating pane can approach a docking pane, docking site, or another pane before the framework changes its state to docked.  
  
##  \<a name="cdockingmanager__m_ntimeoutbeforedockingbardock">\</a>  CDockingManager::m_nTimeOutBeforeDockingBarDock  
 Specifies the time, in milliseconds, before a docking pane is docked in immediate docking mode.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
 Before a pane is docked, the framework waits the specified length of time. This prevents the pane from being accidentally docked to a location while the user is still dragging it.  
  
##  \<a name="cdockingmanager__m_ntimeoutbeforetoolbardock">\</a>  CDockingManager::m_nTimeOutBeforeToolBarDock  
 Specifies the time, in milliseconds, before a toolbar is docked to the main frame window.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Remarks  
 Before a toolbar is docked, the framework waits the specified length of time. This prevents the toolbar from being accidentally docked to a location while the user is still dragging it.  
  
##  \<a name="cdockingmanager__onactivateframe">\</a>  CDockingManager::OnActivateFrame  
 Called by the framework when the frame window is made active or is deactivated.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>, the frame window is made active; if <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>, the frame window is deactivated.  
  
##  \<a name="cdockingmanager__onclosepopupmenu">\</a>  CDockingManager::OnClosePopupMenu  
 Called by the framework when an active pop-up menu processes a WM_DESTROY message.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Remarks  
 The framework sends a WM_DESTROY message when it is about to close the current main window. Override this method to handle notifications from <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> objects that belong to the frame window when a <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> object processes a <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> message.  
  
##  \<a name="cdockingmanager__onmoveminiframe">\</a>  CDockingManager::OnMoveMiniFrame  
 Called by the framework to move a mini-frame window.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 A pointer to a mini-frame window.  
  
### Return Value  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> if the method succeeds; otherwise <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__onpanecontextmenu">\</a>  CDockingManager::OnPaneContextMenu  
 Called by the framework when it builds a menu that has a list of panes.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 Specifies the location of the menu.  
  
##  \<a name="cdockingmanager__panefrompoint">\</a>  CDockingManager::PaneFromPoint  
 Returns the pane that contains the given point.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 Specifies the point, in screen coordinates, to check.  
  
 [in] <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 The value to inflate the window rectangle of each checked pane. A pane satisfies the search criteria if the given point is in this inflated region.  
  
 [in] <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> to ignore the <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>, the method searches only the panes of the specified type.  
  
 [in] <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> to check only visible panes; otherwise, <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 If a pane is found at the specified point, this parameter contains the side of the pane that was closest to the specified point. For more information, see the Remarks section.  
  
 [in] <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>, the method ignores panes specified by this parameter.  
  
### Return Value  
 The [CBasePane](../vs140/cbasepane-class.md)-derived object that contains the given point, or <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> if no pane was found.  
  
### Remarks  
 When the function returns and a pane was found, <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> contains the alignment of the specified point. For example, if the point was closest to the top of the pane, <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__processpanecontextmenucommand">\</a>  CDockingManager::ProcessPaneContextMenuCommand  
 Called by the framework to select or to clear a check box for the specified command and recalculate the layout of a shown pane.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 The id of a control bar in the menu.  
  
 [in] <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 The command notification code.  
  
 [in] <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
 A pointer to void that is casted to a pointer to <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> is CN_UPDATE_COMMAND_UI.  
  
 [in] <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 A pointer to an info structure. This parameter is not used.  
  
### Return Value  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> is not NULL and <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> equals CN_UPDATE_COMMAND_UI, or if there is a control bar with the specified <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__recalclayout">\</a>  CDockingManager::RecalcLayout  
 Recalculates the internal layout of the controls present in the list of controls.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
##  \<a name="cdockingmanager__releaseemptypanecontainers">\</a>  CDockingManager::ReleaseEmptyPaneContainers  
 Releases the empty pane containers.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
##  \<a name="cdockingmanager__removehiddenmditabbedbar">\</a>  CDockingManager::RemoveHiddenMDITabbedBar  
 Removes the specified hidden bar pane.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
 A pointer to a bar pane to remove.  
  
##  \<a name="cdockingmanager__removeminiframe">\</a>  CDockingManager::RemoveMiniFrame  
 Removes a specified frame from the list of mini frames.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 A pointer to a frame to remove.  
  
### Return Value  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> if the specified frame is removed; <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__removepanefromdockmanager">\</a>  CDockingManager::RemovePaneFromDockManager  
 Unregisters a pane and removes it from the list in the docking manager.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 A pointer to a pane to be removed.  
  
 [in] <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>, the removed pane is destroyed.  
  
 [in] <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>, adjust the docking layout immediately.  
  
 [in] <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>, the pane is removed from the list of autohide bars. If <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>, the pane is removed from the list of regular panes.  
  
 [in] <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 A pointer to a pane that replaces the removed pane.  
  
##  \<a name="cdockingmanager__replacepane">\</a>  CDockingManager::ReplacePane  
 Replaces one pane with another.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
 A pointer to the original pane.  
  
 [in] <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>  
 A pointer to the pane that replaces the original pane.  
  
### Return Value  
 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> if the pane is successfully replaced; <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cdockingmanager__resortminiframesforzorder">\</a>  CDockingManager::ResortMiniFramesForZOrder  
 Resorts the frames in the list of mini frames.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
##  \<a name="cdockingmanager__savestate">\</a>  CDockingManager::SaveState  
 Saves the docking manager's state to the registry.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
 A path to a registry key.  
  
 [in] <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
 The docking manager ID.  
  
### Return Value  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> if the state was saved successfully; otherwise <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>.  
  
### Remarks  
 Saving the docking manager's state to the registry involves saving the states of the control bars, the states of the autohide bars, and the states of the mini frames present in the docking manager.  
  
##  \<a name="cdockingmanager__sendmessagetominiframes">\</a>  CDockingManager::SendMessageToMiniFrames  
 Sends the specified message to all mini frames.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 The message to be sent.  
  
 [in] <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 Additional message dependent information.  
  
 [in] <CodeContentPlaceHolder>321\</CodeContentPlaceHolder>  
 Additional message dependent information.  
  
### Return Value  
 <CodeContentPlaceHolder>322\</CodeContentPlaceHolder> always.  
  
##  \<a name="cdockingmanager__serialize">\</a>  CDockingManager::Serialize  
 Writes the docking manager to an archive.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>  
 A reference to an archive object.  
  
### Remarks  
 Writing the docking manager to an archive involves determining the number of docking control bars and sliders, and writing the control bars, the mini frames, the autohide bars, and the MDI tabbed bars to the archive.  
  
##  \<a name="cdockingmanager__setautohidezorder">\</a>  CDockingManager::SetAutohideZOrder  
 Sets the size, width, and height of the control bars and the specified pane.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
 A pointer to a dockable pane.  
  
##  \<a name="cdockingmanager__setdockingmode">\</a>  CDockingManager::SetDockingMode  
 Sets the docking mode.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>  
 Specifies the new docking mode. For more information, see the Remarks section.  
  
 <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 Specifies the theme to be used for smart docking markers. It can be  one of the following enumerated values: AFX_SDT_DEFAULT, AFX_SDT_VS2005, AFX_SDT_VS2008.  
  
### Remarks  
 Call this static method to set the docking mode.  
  
 <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> can be one of following values:  
  
-   <CodeContentPlaceHolder>328\</CodeContentPlaceHolder> - Standard docking mode as implemented in Visual Studio .NET 2003. Panes are dragged without a dragging context.  
  
-   <CodeContentPlaceHolder>329\</CodeContentPlaceHolder> - Immediate docking mode as implemented in Microsoft Visio. Panes are dragged with a dragging context, but no markers are displayed.  
  
-   <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> - Smart docking mode as implemented in Visual Studio 2005. Panes are dragged with a dragging context and smart markers are displayed that show where the pane can be docked.  
  
##  \<a name="cdockingmanager__setdockstate">\</a>  CDockingManager::SetDockState  
 Sets the docking state of the control bars, the mini frames, and the autohide bars.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
##  \<a name="cdockingmanager__setprintpreviewmode">\</a>  CDockingManager::SetPrintPreviewMode  
 Sets the print preview mode of the bars that are displayed in the print preview.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> if print preview mode is set; <CodeContentPlaceHolder>333\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>  
 A pointer to a preview state. This parameter is not used.  
  
##  \<a name="cdockingmanager__setsmartdockingparams">\</a>  CDockingManager::SetSmartDockingParams  
 Sets the parameters that define the behavior of smart docking.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>  
 Defines the parameters for smart docking.  
  
### Remarks  
 Call this method if you want to customize the appearance, color, or shape of the smart docking markers.  
  
 To use the default look for smart docking markers, pass an uninitialized instance of [CSmartDockingInfo Class](../vs140/csmartdockinginfo-class.md) to <CodeContentPlaceHolder>336\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__showdelayshowminiframes">\</a>  CDockingManager::ShowDelayShowMiniFrames  
 Shows or hides the windows of the mini frames.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>338\</CodeContentPlaceHolder> to make the window of the shown frame active; <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> hide the window of the frame.  
  
##  \<a name="cdockingmanager__showpanes">\</a>  CDockingManager::ShowPanes  
 Shows or hides the panes of the control and autohide bars.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> to show the panes; <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> hide the panes.  
  
### Return Value  
 Always <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingmanager__startsdocking">\</a>  CDockingManager::StartSDocking  
 Starts the smart docking of the specified window according to the alignment of the smart docking manager.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>  
 A pointer to a window to dock.  
  
##  \<a name="cdockingmanager__stopsdocking">\</a>  CDockingManager::StopSDocking  
 Stops smart docking.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
##  \<a name="cdockingmanager__getsmartdockingtheme">\</a>  CDockingManager::GetSmartDockingTheme  
 A static method that returns a theme used to display smart docking markers.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Return Value  
 Returns one of the following enumerated values: AFX_SDT_DEFAULT, AFX_SDT_VS2005, AFX_SDT_VS2008.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CObject Class](../vs140/cobject-class.md)   
 [CFrameWndEx](../vs140/cframewndex-class.md)   
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)