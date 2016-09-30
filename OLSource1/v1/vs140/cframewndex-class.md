---
title: "CFrameWndEx Class"
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
  - "CFrameWndEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFrameWndEx class"
ms.assetid: 5830aca8-4a21-4f31-91f1-dd5477ffcc8d
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx Class
Implements the functionality of a Windows single document interface (SDI) overlapped or popup frame window, and provides members for managing the window. It extends the [CFrameWnd](../vs140/cframewnd-class.md) class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFrameWndEx::ActiveItemRecalcLayout](#cframewndex__activeitemrecalclayout)|Adjusts the layout of the OLE client item and the frame's client area.|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|This method is not used.|  
|[CFrameWndEx::AddPane](#cframewndex__addpane)|Registers a control bar with the docking manager.|  
|[CFrameWndEx::AdjustDockingLayout](#cframewndex__adjustdockinglayout)|Recalculates the layout of all panes that are docked to the frame window.|  
|[CFrameWndEx::DelayUpdateFrameMenu](#cframewndex__delayupdateframemenu)|Sets the frame menu and then updates it when command processing is idle.|  
|[CFrameWndEx::DockPane](#cframewndex__dockpane)|Docks the specified pane to the frame window.|  
|[CFrameWndEx::DockPaneLeftOf](#cframewndex__dockpaneleftof)|Docks one pane to the left of another pane.|  
|[CFrameWndEx::EnableAutoHideBars](#cframewndex__enableautohidepanes)|Enables the auto-hide mode for the panes when they are docked to the specified sides of the main frame window.|  
|[CFrameWndEx::EnableDocking](#cframewndex__enabledocking)|Enables the docking of the panes that belong to the frame window.|  
|[CFrameWndEx::EnableFullScreenMainMenu](#cframewndex__enablefullscreenmainmenu)|Shows or hides the main menu in a full screen mode.|  
|[CFrameWndEx::EnableFullScreenMode](#cframewndex__enablefullscreenmode)|Enables the full screen mode for the frame window.|  
|[CFrameWndEx::EnableLoadDockState](#cframewndex__enableloaddockstate)|Enables or disables the loading of the docking state.|  
|[CFrameWndEx::EnablePaneMenu](#cframewndex__enablepanemenu)|Enables or disables the automatic handling of the pane menu.|  
|[CFrameWndEx::GetActivePopup](#cframewndex__getactivepopup)|Returns a pointer to the currently displayed pop-up menu.|  
|[CFrameWndEx::GetDefaultResId](#cframewndex__getdefaultresid)|Returns the resource ID that you specified when the framework loaded the frame window.|  
|[CFrameWndEx::GetDockingManager](#cframewndex__getdockingmanager)|Retrieves the [CDockingManager](../vs140/cdockingmanager-class.md) object for the frame window.|  
|[CFrameWndEx::GetMenuBar](#cframewndex__getmenubar)|Returns a pointer to the menu bar object attached to the frame window.|  
|[CFrameWndEx::GetPane](#cframewndex__getpane)|Returns a pointer to the pane that has the specified ID.|  
|[CFrameWndEx::GetRibbonBar](#cframewndex__getribbonbar)|Retrieves the ribbon bar control for the frame.|  
|[CFrameWndEx::GetTearOffBars](#cframewndex__gettearoffbars)|Returns a list of pane objects that are in a tear-off state.|  
|[CFrameWndEx::GetToolbarButtonToolTipText](#cframewndex__gettoolbarbuttontooltiptext)|Called by the framework when the application displays the tooltip for a toolbar button.|  
|[CFrameWndEx::InsertPane](#cframewndex__insertpane)|Registers a pane with the docking manager.|  
|[CFrameWndEx::IsFullScreen](#cframewndex__isfullscreen)|Determines whether the frame window is in full screen mode.|  
|[CFrameWndEx::IsMenuBarAvailable](#cframewndex__ismenubaravailable)|Determines whether the pointer to the menu bar object is valid.|  
|[CFrameWndEx::IsPointNearDockSite](#cframewndex__ispointneardocksite)|Indicates whether the point is located in an alignment zone.|  
|[CFrameWndEx::IsPrintPreview](#cframewndex__isprintpreview)|Indicates whether the frame window is in print preview mode.|  
|[CFrameWndEx::LoadFrame](#cframewndex__loadframe)|This method is called after construction to create the frame window and load its resources.|  
|[CFrameWndEx::NegotiateBorderSpace](#cframewndex__negotiateborderspace)|Implements OLE client border negotiation.|  
|[CFrameWndEx::OnActivate](#cframewndex__onactivate)|The framework calls this method when user input is switched to or away from the frame.|  
|[CFrameWndEx::OnActivateApp](#cframewndex__onactivateapp)|Called by the framework when the application is either selected or deselected.|  
|[CFrameWndEx::OnChangeVisualManager](#cframewndex__onchangevisualmanager)|Called by the framework when a change to the frame requires a change to the visual manager.|  
|[CFrameWndEx::OnClose](#cframewndex__onclose)|The framework calls this method to close the frame.|  
|[CFrameWndEx::OnCloseDockingPane](#cframewndex__onclosedockingpane)|Called by the framework when the user clicks the **Close** button on a docking pane.|  
|[CFrameWndEx::OnCloseMiniFrame](#cframewndex__oncloseminiframe)|Called by the framework when the user clicks the **Close** button on a floating mini frame window.|  
|[CFrameWndEx::OnClosePopupMenu](#cframewndex__onclosepopupmenu)|Called by the framework when an active pop-up menu processes a WM_DESTROY message.|  
|[CFrameWndEx::OnCmdMsg](#cframewndex__oncmdmsg)|Dispatches command messages.|  
|[CFrameWndEx::OnContextHelp](#cframewndex__oncontexthelp)|Called by the framework to display context related help.|  
|[CFrameWndEx::OnCreate](#cframewndex__oncreate)|Called by the framework after the frame is created.|  
|[CFrameWndEx::OnDestroy](#cframewndex__ondestroy)|Called by the framework when the frame is destroyed.|  
|[CFrameWndEx::OnDrawMenuImage](#cframewndex__ondrawmenuimage)|Called by the framework when the application draws the image associated with a menu item.|  
|[CFrameWndEx::OnDrawMenuLogo](#cframewndex__ondrawmenulogo)|Called by the framework when a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object processes a                                         [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message.|  
|[CFrameWndEx::OnDWMCompositionChanged](#cframewndex__ondwmcompositionchanged)|Called by the framework when Desktop Window Manager (DWM) composition has been enabled or disabled.|  
|[CFrameWndEx::OnExitSizeMove](#cframewndex__onexitsizemove)|Called by the framework when the frame stops moving or resizing.|  
|[CFrameWndEx::OnGetMinMaxInfo](#cframewndex__ongetminmaxinfo)|Called by the framework when the frame is resized to set window dimension limits.|  
|[CFrameWndEx::OnIdleUpdateCmdUI](#cframewndex__onidleupdatecmdui)|Called by the framework to update the frame display when command processing is idle.|  
|[CFrameWndEx::OnLButtonDown](#cframewndex__onlbuttondown)|The framework calls this method when the user presses the left mouse button.|  
|[CFrameWndEx::OnLButtonUp](#cframewndex__onlbuttonup)|The framework calls this method when the user releases the left mouse button.|  
|[CFrameWndEx::OnMenuButtonToolHitTest](#cframewndex__onmenubuttontoolhittest)|Called by the framework when a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object processes a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> message.|  
|[CFrameWndEx::OnMenuChar](#cframewndex__onmenuchar)|Called by the framework when a menu is displayed and the user presses a key that does not correspond to a command.|  
|[CFrameWndEx::OnMouseMove](#cframewndex__onmousemove)|The framework calls this method when the pointer moves.|  
|[CFrameWndEx::OnMoveMiniFrame](#cframewndex__onmoveminiframe)|Called by the framework when a pane window moves.|  
|[CFrameWndEx::OnNcActivate](#cframewndex__onncactivate)|Called by the framework when the non-client area of the frame must be redrawn to indicate a change in the active state.|  
|[CFrameWndEx::OnNcCalcSize](#cframewndex__onnccalcsize)|Called by the framework when the size and position of the client area must be calculated.|  
|[CFrameWndEx::OnNcHitTest](#cframewndex__onnchittest)|Called by the framework when the pointer moves or when a mouse button is pressed or released.|  
|[CFrameWndEx::OnNcMouseMove](#cframewndex__onncmousemove)|Called by the framework when the pointer moves in a non-client area.|  
|[CFrameWndEx::OnNcPaint](#cframewndex__onncpaint)|Called by the framework when the non-client area must be painted.|  
|[CFrameWndEx::OnPaneCheck](#cframewndex__onpanecheck)|Called by the framework to control the visibility of a pane.|  
|[CFrameWndEx::OnPostPreviewFrame](#cframewndex__onpostpreviewframe)|Called by the framework when the user has changed the print preview mode.|  
|[CFrameWndEx::OnPowerBroadcast](#cframewndex__onpowerbroadcast)|Called by the framework when a power management event occurs.|  
|[CFrameWndEx::OnSetMenu](#cframewndex__onsetmenu)|Called by the framework to replace the frame window menu.|  
|[CFrameWndEx::OnSetPreviewMode](#cframewndex__onsetpreviewmode)|Called by the framework to set the print preview mode for the frame.|  
|[CFrameWndEx::OnSetText](#cframewndex__onsettext)|Called by the framework to set the text of a window.|  
|[CFrameWndEx::OnShowCustomizePane](#cframewndex__onshowcustomizepane)|Called by the framework when a quick customize pane is enabled.|  
|[CFrameWndEx::OnShowPanes](#cframewndex__onshowpanes)|Called by the framework to show or hide panes.|  
|[CFrameWndEx::OnShowPopupMenu](#cframewndex__onshowpopupmenu)|Called by the framework when a pop-up menu is enabled.|  
|[CFrameWndEx::OnSize](#cframewndex__onsize)|The framework calls this method after the frame's size changes.|  
|[CFrameWndEx::OnSizing](#cframewndex__onsizing)|The framework calls this method when the user resizes the frame.|  
|[CFrameWndEx::OnSysColorChange](#cframewndex__onsyscolorchange)|Called by the framework when the system colors change.|  
|[CFrameWndEx::OnTearOffMenu](#cframewndex__ontearoffmenu)|Called by the framework when a menu that has a tear-off bar is enabled.|  
|[CFrameWndEx::OnToolbarContextMenu](#cframewndex__ontoolbarcontextmenu)|Called by the framework to build a toolbar context menu.|  
|[CFrameWndEx::OnToolbarCreateNew](#cframewndex__ontoolbarcreatenew)|The framework calls this method to create a new toolbar.|  
|[CFrameWndEx::OnToolbarDelete](#cframewndex__ontoolbardelete)|Called by the framework when a toolbar is deleted.|  
|[CFrameWndEx::OnUpdateFrameMenu](#cframewndex__onupdateframemenu)|Called by the framework to set the frame menu.|  
|[CFrameWndEx::OnUpdateFrameTitle](#cframewndex__onupdateframetitle)|The framework calls this method to update the title bar of the frame window.|  
|[CFrameWndEx::OnUpdatePaneMenu](#cframewndex__onupdatepanemenu)|Called by the framework to update the pane menu.|  
|[CFrameWndEx::OnWindowPosChanged](#cframewndex__onwindowposchanged)|Called by the framework when the frame size, position, or z-order has changed because of a call to a window management method.|  
|[CFrameWndEx::PaneFromPoint](#cframewndex__panefrompoint)|Returns the docking pane that contains the specified point.|  
|[CFrameWndEx::PreTranslateMessage](#cframewndex__pretranslatemessage)|Handles specific window messages before they are dispatched.|  
|[CFrameWndEx::RecalcLayout](#cframewndex__recalclayout)|Adjusts the layout of the frame and its child windows.|  
|[CFrameWndEx::RemovePaneFromDockManager](#cframewndex__removepanefromdockmanager)|Unregisters a pane and removes it from the internal list in the docking manager.|  
|[CFrameWndEx::SetDockState](#cframewndex__setdockstate)|Restores the docking layout to the docking state stored in the registry.|  
|[CFrameWndEx::SetPrintPreviewFrame](#cframewndex__setprintpreviewframe)|Sets the print preview frame window.|  
|[CFrameWndEx::SetupToolbarMenu](#cframewndex__setuptoolbarmenu)|Inserts user-defined commands into a toolbar menu.|  
|[CFrameWndEx::ShowFullScreen](#cframewndex__showfullscreen)|Switches the main frame between the full screen and the regular modes.|  
|[CFrameWndEx::ShowPane](#cframewndex__showpane)|Shows or hides the specified pane.|  
|[CFrameWndEx::UpdateCaption](#cframewndex__updatecaption)|Called by the framework to update the window frame caption.|  
|[CFrameWndEx::WinHelp](#cframewndex__winhelp)|Invokes either the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> application or context related help.|  
  
## Example  
 The following example demonstrates how to inherit a class from the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> class. The example illustrates the method signatures in the subclass, and how to override the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> method. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#3](../vs140/codesnippet/CPP/cframewndex-class_1.h)]  
[!code[NVC_MFC_WordPad#4](../vs140/codesnippet/CPP/cframewndex-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 [CFrameWndEx](../vs140/cframewndex-class.md)  
  
## Requirements  
 **Header:** afxframewndex.h  
  
##  \<a name="cframewndex__activeitemrecalclayout">\</a>  CFrameWndEx::ActiveItemRecalcLayout  
 Adjusts the layout of the OLE client item and the frame's client area.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cframewndex__addpane">\</a>  CFrameWndEx::AddPane  
 Registers a control bar with the docking manager.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A control bar pane to register.  
  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> if you want to add the control bar pane to the end of the list; <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> if the control bar was successfully registered; <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cframewndex__adjustdockinglayout">\</a>  CFrameWndEx::AdjustDockingLayout  
 Recalculates the layout of all panes that are docked to the frame window.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A handle to a structure that contains the positions of multiple windows. .  
  
### Remarks  
 The hdwp structure is initialized by the                         [BeginDeferWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms632672) method.  
  
##  \<a name="cframewndex__delayupdateframemenu">\</a>  CFrameWndEx::DelayUpdateFrameMenu  
 Sets the frame menu and then updates it when command processing is idle.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Handle to an alternative menu.  
  
### Remarks  
  
##  \<a name="cframewndex__dockpane">\</a>  CFrameWndEx::DockPane  
 Docks the specified pane to the frame window.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A pointer to the control bar to be docked.  
  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The ID of the side of the frame window to dock to.  
  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A pointer to a constant Rect structure that specifies the window's screen position and size.  
  
### Remarks  
 The <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> parameter can have one of the following values:  
  
-   AFX_IDW_DOCKBAR_TOP  
  
-   AFX_IDW_DOCKBAR_BOTTOM  
  
-   AFX_IDW_DOCKBAR_LEFT  
  
-   AFX_IDW_DOCKBAR_RIGHT  
  
##  \<a name="cframewndex__dockpaneleftof">\</a>  CFrameWndEx::DockPaneLeftOf  
 Docks the specified pane to the left of another pane.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A pointer to the pane object to be docked.  
  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 A pointer to the pane to the left of which to dock the pane specified by <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> is docked successfully. <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The method takes the toolbar specified by the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> parameter and docks it at the left side of the toolbar specified by <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cframewndex__enableautohidepanes">\</a>  CFrameWndEx::EnableAutoHidePanes  
 Enables auto-hide mode for the pane when it is docked to the specified side of the main frame window.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 Specifies the side of the main frame window to which to dock the pane.  
  
### Return Value  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> if a bar pane is successfully docked to the frame window side that is specified by <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> can have one of the following values:  
  
-   CBRS_ALIGN_TOP: allows the control bar to be docked to the top of the client area of a frame window.  
  
-   CBRS_ALIGN_BOTTOM: allows the control bar to be docked to the bottom of the client area of a frame window.  
  
-   CBRS_ALIGN_LEFT: allows the control bar to be docked to the left side of the client area of a frame window.  
  
-   CBRS_ALIGN_RIGHT: allows the control bar to be docked to the right side of the client area of a frame window.  
  
##  \<a name="cframewndex__enabledocking">\</a>  CFrameWndEx::EnableDocking  
 Enables the docking of the panes of the frame window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 Specifies the side of the main frame window where the pane bar docks.  
  
### Return Value  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> if a bar pane can be successfully docked at the specified side. <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> parameter can have one of the following values:  
  
-   CBRS_ALIGN_TOP  
  
-   CBRS_ALIGN_BOTTOM  
  
-   CBRS_ALIGN_LEFT  
  
-   CBRS_ALIGN_RIGHT  
  
##  \<a name="cframewndex__enablefullscreenmainmenu">\</a>  CFrameWndEx::EnableFullScreenMainMenu  
 Shows or hides the main menu in a full screen mode.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> to show the main menu in a full screen mode, <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cframewndex__enablefullscreenmode">\</a>  CFrameWndEx::EnableFullScreenMode  
 Enables the full-screen mode for the frame window.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The ID of a command that enables and disables the full screen mode.  
  
### Remarks  
 In the full-screen mode, all docking control bars, toolbars and menu are hidden and the active view is resized to occupy the full-screen.  
  
 When you enable the full-screen mode, you must specify an ID of the command that enables or disables the full-screen mode. You can call <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> from the main frame's <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> function. When a frame window is being switched to a full-screen mode, the framework creates a floating toolbar with one button that has the specified command ID.  
  
 If you want to keep the main menu on the screen, call [EnableFullScreenMainMenu](#cframewndex__enablefullscreenmainmenu).  
  
##  \<a name="cframewndex__enableloaddockstate">\</a>  CFrameWndEx::EnableLoadDockState  
 Enables or disables the loading of the docking state.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> to enable the loading of the docking state, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> to disable the loading of the docking state.  
  
##  \<a name="cframewndex__enablepanemenu">\</a>  CFrameWndEx::EnablePaneMenu  
 Enables or disables the automatic handling of the pane menu.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> to enable the automatic handling of the control bar pop-up menus; <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> to disable the automatic handling of the control bar pop-up menus.  
  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 The command ID of the **Customize** menu item.  
  
 [in] <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The label to be displayed for the **Customize** menu item  
  
 [in] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The ID of a toolbar menu item that opens the pop-up menu in the control bar.  
  
 [in] <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, the control bar context menu displays the list of toolbars only. If <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, the menu displays the list of the toolbars and the docking bars.  
  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>, the control bar menu displays the list of the toolbars only. If <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, the menu displays the list of the toolbars and the docking bars.  
  
##  \<a name="cframewndex__getactivepopup">\</a>  CFrameWndEx::GetActivePopup  
 Returns a pointer to the currently displayed pop-up menu.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the currently displayed pop-up menu; otherwise <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
##  \<a name="cframewndex__getdefaultresid">\</a>  CFrameWndEx::GetDefaultResId  
 Returns the resource ID that you specified when the framework loaded the frame window.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The resource ID value that the user specified when the framework loaded the frame window. Zero if the frame window does not have a menu bar.  
  
##  \<a name="cframewndex__getdockingmanager">\</a>  CFrameWndEx::GetDockingManager  
 Retrieves the [CDockingManager](../vs140/cdockingmanager-class.md) object for the frame window.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the [CDockingManager](../vs140/cdockingmanager-class.md).  
  
### Remarks  
 The frame window creates and uses a [CDockingManager](../vs140/cdockingmanager-class.md) object to manage child window docking.  
  
##  \<a name="cframewndex__getmenubar">\</a>  CFrameWndEx::GetMenuBar  
 Returns a pointer to the menu bar object attached to the frame window.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the menu bar object attached to the frame window.  
  
##  \<a name="cframewndex__getpane">\</a>  CFrameWndEx::GetPane  
 Returns a pointer to the pane that has the specified ID.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 The control ID.  
  
### Return Value  
 A pointer to the pane that has the specified ID. <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> if no such pane exists.  
  
##  \<a name="cframewndex__getribbonbar">\</a>  CFrameWndEx::GetRibbonBar  
 Retrieves the ribbon bar control for the frame.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to the [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md) for the frame.  
  
### Remarks  
  
##  \<a name="cframewndex__gettearoffbars">\</a>  CFrameWndEx::GetTearOffBars  
 Returns a list of pane objects that are in a tear-off state.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A reference to <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object that contains a collection of pointers to the pane objects that are in a tear-off state.  
  
##  \<a name="cframewndex__gettoolbarbuttontooltiptext">\</a>  CFrameWndEx::GetToolbarButtonToolTipText  
 Called by the framework when the application displays the tooltip for a toolbar button.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 A pointer to a toolbar button.  
  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 The tooltip text to display for the button.  
  
### Return Value  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> if the tooltip has been displayed. <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 By default, this method does nothing. Override this method if you want to display the tooltip for the toolbar button.  
  
##  \<a name="cframewndex__insertpane">\</a>  CFrameWndEx::InsertPane  
 Inserts a pane into a list of control bars and registers it with the docking manager.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A pointer to a control bar to be inserted into the list of control bars and registered with the docking manager.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 A pointer to a control bar before or after which to insert the pane.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> if you want to insert <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> after <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> if the control bar was successfully inserted and registered, <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 You must register each control bar by using the [CDockingManager Class](../vs140/cdockingmanager-class.md) to take a part in the docking layout.  
  
##  \<a name="cframewndex__isfullscreen">\</a>  CFrameWndEx::IsFullScreen  
 Determines whether the frame window is in full screen mode.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if the frame window is in full screen mode; otherwise <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can set the full screen mode by calling the [EnableFullScreenMode](#cframewndex__enablefullscreenmode) method.  
  
##  \<a name="cframewndex__ismenubaravailable">\</a>  CFrameWndEx::IsMenuBarAvailable  
 Determines whether the pointer to the menu bar object is valid.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> if the frame window has a menu bar; otherwise <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
##  \<a name="cframewndex__ispointneardocksite">\</a>  CFrameWndEx::IsPointNearDockSite  
 Determines whether the point is located in an alignment zone.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 The position of the point.  
  
 [out] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 Where the point is aligned. See the table in the Remarks section for possible values.  
  
 [out] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> if the point is located close to the frame border; <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> if the point is located in a client area.  
  
### Return Value  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> if the point is located in an alignment zone; otherwise, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Remarks  
 The following table lists the possible values for the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 Aligned to the top.  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Aligned to the right.  
  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 Aligned to the bottom.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 Aligned to the left.  
  
##  \<a name="cframewndex__isprintpreview">\</a>  CFrameWndEx::IsPrintPreview  
 Determines whether the frame window is in print preview mode.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> if the frame window is in print preview mode; otherwise, <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cframewndex__loadframe">\</a>  CFrameWndEx::LoadFrame  
 This method is called after construction to create the frame window and load its resources.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The resource ID that is used to load all frame resources.  
  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The default frame window style.  
  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 Pointer to the parent window of the frame.  
  
 [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 Pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) class that is used by the framework during application creation.  
  
### Return Value  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> if the method was successful; otherwise, <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cframewndex__negotiateborderspace">\</a>  CFrameWndEx::NegotiateBorderSpace  
 Implements OLE client border negotiation.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 The border negotiation command. See the Remarks section for possible values.  
  
 [in, out] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 Dimensions of the border.  
  
### Return Value  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> if the layout must be recalculated; otherwise, <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>.  
  
### Remarks  
 The following table lists the possible values for the <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 Get available OLE client space.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 Request OLE client space.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 Set OLE client space.  
  
##  \<a name="cframewndex__onactivate">\</a>  CFrameWndEx::OnActivate  
 The framework calls this method when user input is switched to or away from the frame.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 Whether the frame is active or inactive. See the table in the Remarks section for possible values.  
  
 [in] <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Pointer to another window that is switching user input with the current one.  
  
 [in] <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The minimized state of the frame. <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> if the frame is minimized; otherwise, <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
### Remarks  
 The following table lists the possible values for the <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 The frame is selected by a method other than a mouse click.  
  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 The frame is selected by a mouse click.  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 The frame is not selected.  
  
##  \<a name="cframewndex__onactivateapp">\</a>  CFrameWndEx::OnActivateApp  
 Called by the framework when the application is either selected or deselected.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> if the application is selected; <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> if the application is not selected.  
  
 [in] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
  
##  \<a name="cframewndex__onchangevisualmanager">\</a>  CFrameWndEx::OnChangeVisualManager  
 Called by the framework when a change to the frame requires a change to the visual manager.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns 0.  
  
### Remarks  
  
##  \<a name="cframewndex__onclose">\</a>  CFrameWndEx::OnClose  
 The framework calls this method to close the frame.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 If the frame is in print preview mode, it sends a Windows message to close the print preview; otherwise, if the frame hosts an OLE client, the client is deactivated.  
  
##  \<a name="cframewndex__onclosedockingpane">\</a>  CFrameWndEx::OnCloseDockingPane  
 Called by the framework when the user clicks the **Close** button on a docking pane.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> if the docking bar can be closed. <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> otherwise  
  
### Remarks  
 The default implement does nothing. Override this method if you want to handle the hiding of the docking bar.  
  
##  \<a name="cframewndex__oncloseminiframe">\</a>  CFrameWndEx::OnCloseMiniFrame  
 Called by the framework when the user clicks the **Close** button on a floating mini frame window.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> if a floating mini frame window can be closed. <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The default implementation does nothing. Override this method if you want to process the hiding of a floating mini frame window.  
  
##  \<a name="cframewndex__onclosepopupmenu">\</a>  CFrameWndEx::OnClosePopupMenu  
 Called by the framework when an active pop-up menu processes a WM_DESTROY message.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 A pointer to a pop-up menu.  
  
### Remarks  
 The framework sends a WM_DESTROY message when it is about to close the window. Override this method if you want to handle notifications from <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> objects that belong to the frame window when a <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> object is processing a <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> message sent by the framework when the window is being closed.  
  
##  \<a name="cframewndex__oncmdmsg">\</a>  CFrameWndEx::OnCmdMsg  
 Dispatches command messages.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 The command ID.  
  
 [in] <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 Command message category.  
  
 [in, out] <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 Pointer to a command object.  
  
 [in, out] <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 Pointer to a command handler structure.  
  
### Return Value  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> if the command message was handled; otherwise, <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cframewndex__oncontexthelp">\</a>  CFrameWndEx::OnContextHelp  
 Called by the framework to display context-related help.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cframewndex__oncreate">\</a>  CFrameWndEx::OnCreate  
 Called by the framework after the frame is created.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 A pointer to the [CREATESTRUCT](../vs140/createstruct-structure.md) for the new frame.  
  
### Return Value  
 0 to continue with the frame creation; -1 to destroy the frame.  
  
### Remarks  
  
##  \<a name="cframewndex__ondestroy">\</a>  CFrameWndEx::OnDestroy  
 Called by the framework when the frame is destroyed.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Remarks  
 The accelerator table and all windows are destroyed.  
  
##  \<a name="cframewndex__ondrawmenuimage">\</a>  CFrameWndEx::OnDrawMenuImage  
 Called by the framework when the application draws the image associated with a menu item.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 A pointer to a menu button whose image is being rendered.  
  
 [in] <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> structure that specifies the screen position and size of the image.  
  
### Return Value  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> if the framework successfully renders the image; <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 Override this method if you want to customize the image rendering for the menu items that belong to the menu bar owned by the <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> derived object.  
  
##  \<a name="cframewndex__ondrawmenulogo">\</a>  CFrameWndEx::OnDrawMenuLogo  
 Called by the framework when a <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> object processes a WM_PAINT message.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 A pointer to the menu item.  
  
 [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 A reference to a constant <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> structure that specifies the screen position and size of the menu logo.  
  
### Remarks  
 Override this function if you want to display a logo on the pop-up menu that belongs to the menu bar owned by the <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> derived object.  
  
##  \<a name="cframewndex__ondwmcompositionchanged">\</a>  CFrameWndEx::OnDWMCompositionChanged  
 Called by the framework when Desktop Window Manager (DWM) composition has been enabled or disabled.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns 0.  
  
### Remarks  
  
##  \<a name="cframewndex__onexitsizemove">\</a>  CFrameWndEx::OnExitSizeMove  
 Called by the framework when the frame stops moving or resizing.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns 0.  
  
### Remarks  
  
##  \<a name="cframewndex__ongetminmaxinfo">\</a>  CFrameWndEx::OnGetMinMaxInfo  
 Called by the framework when the frame is resized to set window dimension limits.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 Pointer to a                                 [MINMAXINFO](http://msdn.microsoft.com/library/windows/desktop/ms632605) structure.  
  
### Remarks  
  
##  \<a name="cframewndex__onidleupdatecmdui">\</a>  CFrameWndEx::OnIdleUpdateCmdUI  
 Called by the framework to update the frame display when command processing is idle.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns 0.  
  
### Remarks  
  
##  \<a name="cframewndex__onlbuttondown">\</a>  CFrameWndEx::OnLButtonDown  
 The framework calls this method when the user presses the left mouse button.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 Indicates whether the user pressed modifier keys. For possible values see the parameter <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> in                                 [WM_LBUTTONDOWN Notification](http://msdn.microsoft.com/library/windows/desktop/ms645607).  
  
 [in] <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 Specifies the x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
### Remarks  
  
##  \<a name="cframewndex__onlbuttonup">\</a>  CFrameWndEx::OnLButtonUp  
 The framework calls this method when the user releases the left mouse button.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 Indicates whether the user pressed modifier keys. For possible values see the parameter <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> in                                 [WM_LBUTTONUP Notification](http://msdn.microsoft.com/library/windows/desktop/ms645608).  
  
 [in] <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 Specifies the x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
### Remarks  
  
##  \<a name="cframewndex__onmenubuttontoolhittest">\</a>  CFrameWndEx::OnMenuButtonToolHitTest  
 Called by the framework when a <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> object processes a <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 A pointer to the tool bar button.  
  
 [out] <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 A pointer to a tool information structure.  
  
### Return Value  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> if the application fills the <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> parameter. <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 Override this method if you want to provide a tooltip information about a specific menu item.  
  
##  \<a name="cframewndex__onmenuchar">\</a>  CFrameWndEx::OnMenuChar  
 Called by the framework when a menu is displayed and the user presses a key that does not correspond to a command.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 Character code of the pressed key.  
  
 [in] <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 Contains the <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> flag if the menu displayed is a submenu; contains the <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> flag if the menu displayed is a control menu.  
  
 [in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 Pointer to a menu.  
  
### Return Value  
 The high-order word must be one of the following values.  
  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 The framework should ignore the keystroke.  
  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
 The framework should close the menu.  
  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 The framework should select one of the items displayed in the menu. The low-order word contains the ID of the command to select.  
  
### Remarks  
  
##  \<a name="cframewndex__onmousemove">\</a>  CFrameWndEx::OnMouseMove  
 The framework calls this method when the pointer moves.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
 Indicates whether a user pressed modifier keys. For possible values see the parameter <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> in                                 [WM_MOUSEMOVE Notification](http://msdn.microsoft.com/library/windows/desktop/ms645616).  
  
 [in] <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
 Specifies the x and y coordinates of the pointer relative to the upper-left corner of the window.  
  
### Remarks  
  
##  \<a name="cframewndex__onmoveminiframe">\</a>  CFrameWndEx::OnMoveMiniFrame  
 Called by the framework when a pane window moves.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 Pointer to the [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) pane window.  
  
### Return Value  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> if the pane window was not docked; <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> if the pane window was docked.  
  
### Remarks  
  
##  \<a name="cframewndex__onncactivate">\</a>  CFrameWndEx::OnNcActivate  
 Called by the framework when the non-client area of the frame must be redrawn to indicate a change in the active state.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> to draw the frame active; <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> to draw the frame inactive.  
  
### Return Value  
 Nonzero to continue with default processing; 0 to prevent the non-client area from being deactivated.  
  
### Remarks  
  
##  \<a name="cframewndex__onnccalcsize">\</a>  CFrameWndEx::OnNcCalcSize  
 Called by the framework when the size and position of the client area must be calculated.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> when the application must specify a valid client area; otherwise, <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> structure that contains frame dimension changes.  
  
### Remarks  
  
##  \<a name="cframewndex__onnchittest">\</a>  CFrameWndEx::OnNcHitTest  
 Called by the framework when the pointer moves or when a mouse button is pressed or released.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 The location of the pointer in screen coordinates.  
  
### Return Value  
 A pointer hit enumerated value. For a list of possible values see                         [WM_NCHITTEST Notification](http://msdn.microsoft.com/library/windows/desktop/ms645618).  
  
### Remarks  
  
##  \<a name="cframewndex__onncmousemove">\</a>  CFrameWndEx::OnNcMouseMove  
 Called by the framework when the pointer moves in a non-client area.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 A pointer hit enumerated value. For a list of possible values see                                 [WM_NCHITTEST Notification](http://msdn.microsoft.com/library/windows/desktop/ms645618).  
  
 [in] <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 The location of the pointer in screen coordinates.  
  
### Remarks  
  
##  \<a name="cframewndex__onncpaint">\</a>  CFrameWndEx::OnNcPaint  
 Called by the framework when the non-client area must be painted.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cframewndex__onpanecheck">\</a>  CFrameWndEx::OnPaneCheck  
 Called by the framework to control the visibility of a pane.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 Control ID of a pane.  
  
### Return Value  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> if the command was handled; <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> to continue with command processing.  
  
### Remarks  
  
##  \<a name="cframewndex__onpostpreviewframe">\</a>  CFrameWndEx::OnPostPreviewFrame  
 Called by the framework when the user changes the print preview mode.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> when the frame is in print preview mode; <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> when print preview mode is off.  
  
### Return Value  
 Always returns 0.  
  
### Remarks  
  
##  \<a name="cframewndex__onpowerbroadcast">\</a>  CFrameWndEx::OnPowerBroadcast  
 Called by the framework when a power management event occurs.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 The power management event. For a list of possible values see                                 [WM_POWERBROADCAST Message](http://msdn.microsoft.com/library/windows/desktop/aa373247).  
  
 [in] <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Result from calling the default window procedure.  
  
### Remarks  
  
##  \<a name="cframewndex__onsetmenu">\</a>  CFrameWndEx::OnSetMenu  
 Called by the framework to replace the frame window menu.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 Handle to the new frame window menu.  
  
 [in] <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 Handle to the new window menu.  
  
 [in] <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 Handle to the new frame window menu.  
  
### Return Value  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> is the result from calling the default window procedure.  
  
 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> if the event was handled; otherwise, <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cframewndex__onsetpreviewmode">\</a>  CFrameWndEx::OnSetPreviewMode  
 Called by the framework to set the print preview mode for the frame.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> to enable print preview; <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> to disable print preview.  
  
 [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> frame state structure.  
  
### Remarks  
  
##  \<a name="cframewndex__onsettext">\</a>  CFrameWndEx::OnSetText  
 Called by the framework to set the text of a window.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 Pointer to the text for the window.  
  
### Return Value  
 Return value from a call to                         [DefWindowProc](http://msdn.microsoft.com/library/windows/desktop/ms633572).  
  
### Remarks  
  
##  \<a name="cframewndex__onshowcustomizepane">\</a>  CFrameWndEx::OnShowCustomizePane  
 Called by the framework when it displays a <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
 A pointer to the quick customize pane.  
  
 [in] <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
 The control ID of the toolbar to customize.  
  
### Return Value  
 This method always return <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>.  
  
### Remarks  
 The quick customize menu is a pop-up menu that appears when you click the toolbar’s customize button  
  
##  \<a name="cframewndex__onshowpanes">\</a>  CFrameWndEx::OnShowPanes  
 Called by the framework to show or hide panes.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> if the application shows the panes; <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 This method always return <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation shows the panes if <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> and the panes are hidden or when <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> and the panes are visible.  
  
 The default implementation hides the panes if <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> and the panes are visible or when <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>319\</CodeContentPlaceHolder> and the panes are hidden.  
  
 Override this method in a derived class to execute custom code when the framework shows or hides panes.  
  
##  \<a name="cframewndex__onshowpopupmenu">\</a>  CFrameWndEx::OnShowPopupMenu  
 Called by the framework when it displays a pop-up menu.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 A pointer to a pop-up menu.  
  
### Return Value  
 <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> if the pop-up menu is visible; otherwise <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class to execute custom code when the framework displays a pop-up menu. For example, override this method to change the background color of the commands in a pop-up menu.  
  
##  \<a name="cframewndex__onsize">\</a>  CFrameWndEx::OnSize  
 Called by the framework after the frame's size changes.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>  
 The type of resizing. For possible values see the parameter <CodeContentPlaceHolder>324\</CodeContentPlaceHolder> in                                 [WM_SIZE Notification](http://msdn.microsoft.com/library/windows/desktop/ms632646).  
  
 [in] <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>  
 New width of the frame in pixels.  
  
 [in] <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 New height of the frame in pixels.  
  
### Remarks  
  
##  \<a name="cframewndex__onsizing">\</a>  CFrameWndEx::OnSizing  
 Called by the framework when the user resizes the frame.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>327\</CodeContentPlaceHolder>  
 The edge of the frame that is moved. See the parameter <CodeContentPlaceHolder>328\</CodeContentPlaceHolder> in                                 [WM_SIZING Notification](http://msdn.microsoft.com/library/windows/desktop/ms632647).  
  
 [in, out] <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>  
 Pointer to a [CRect](../vs140/crect-class.md) or [RECT](../vs140/rect-structure.md) structure that contains the frame's coordinates.  
  
### Remarks  
  
##  \<a name="cframewndex__onsyscolorchange">\</a>  CFrameWndEx::OnSysColorChange  
 Called by the framework when the system colors change.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cframewndex__ontearoffmenu">\</a>  CFrameWndEx::OnTearOffMenu  
 Called by the framework when the application displays a menu that has a tear-off bar.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>  
 A pointer to a pop-up menu.  
  
 [in] <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>  
 A pointer to a tear-off bar.  
  
### Return Value  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> if the pop-up menu with the tear-off bar is enabled; otherwise <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class to execute custom code when the framework displays a control bar.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>.  
  
##  \<a name="cframewndex__ontoolbarcontextmenu">\</a>  CFrameWndEx::OnToolbarContextMenu  
 Called by the framework to build a toolbar pop-up menu.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>336\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns 1.  
  
### Remarks  
  
##  \<a name="cframewndex__ontoolbarcreatenew">\</a>  CFrameWndEx::OnToolbarCreateNew  
 The framework calls this method to create a new toolbar.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
 Pointer to the text for the title bar of the toolbar.  
  
### Return Value  
 Pointer to the new toolbar; or <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> if a toolbar was not created.  
  
### Remarks  
  
##  \<a name="cframewndex__ontoolbardelete">\</a>  CFrameWndEx::OnToolbarDelete  
 Called by the framework when a toolbar is deleted.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 [in]  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>  
 Pointer to a toolbar.  
  
### Return Value  
 <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> if the toolbar was deleted; otherwise, <CodeContentPlaceHolder>342\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cframewndex__onupdateframemenu">\</a>  CFrameWndEx::OnUpdateFrameMenu  
 Called by the framework to set the frame menu.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>  
 Handle to the alternative menu.  
  
### Remarks  
  
##  \<a name="cframewndex__onupdateframetitle">\</a>  CFrameWndEx::OnUpdateFrameTitle  
 The framework calls this method to update the title bar of the frame window.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>345\</CodeContentPlaceHolder> to add the active document title to the frame window title bar; otherwise <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cframewndex__onupdatepanemenu">\</a>  CFrameWndEx::OnUpdatePaneMenu  
 Called by the framework to update the pane menu.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>  
 Pointer to the pane user interface object.  
  
### Remarks  
  
##  \<a name="cframewndex__onwindowposchanged">\</a>  CFrameWndEx::OnWindowPosChanged  
 Called by the framework when the frame size, position, or z-order has changed because of a call to a window management method.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>  
 Pointer to a [WINDOWPOS](../vs140/windowpos-structure.md) structure that contains the new size and position.  
  
### Remarks  
  
##  \<a name="cframewndex__panefrompoint">\</a>  CFrameWndEx::PaneFromPoint  
 Searches each pane for the given point.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>349\</CodeContentPlaceHolder>  
 The screen coordinates of the point to check.  
  
 [in] <CodeContentPlaceHolder>350\</CodeContentPlaceHolder>  
 Expand the bounding rectangle of each control bar by this amount when searching for point.  
  
 [in] <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>352\</CodeContentPlaceHolder> to ignore the <CodeContentPlaceHolder>353\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>354\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>355\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>356\</CodeContentPlaceHolder>, the method searches only the control bars of the specified type.  
  
 [out] <CodeContentPlaceHolder>357\</CodeContentPlaceHolder>  
 If successful, this parameter contains the side of the control bar that is closest to the specified point. Otherwise, this parameter is not initialized.  
  
### Return Value  
 A pointer to a control bar that contains the <CodeContentPlaceHolder>358\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>359\</CodeContentPlaceHolder> if no control is found.  
  
### Remarks  
 This method searches all the control bars in your application for a <CodeContentPlaceHolder>360\</CodeContentPlaceHolder>.  
  
 Use <CodeContentPlaceHolder>361\</CodeContentPlaceHolder> to increase the size of the search area. Use <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> to restrict the types of control bars that the method searches.  
  
##  \<a name="cframewndex__pretranslatemessage">\</a>  CFrameWndEx::PreTranslateMessage  
 Handles specific window messages before they are dispatched.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>  
 A pointer to a [MSG](../vs140/msg-structure.md) structure that contains the message to process.  
  
### Return Value  
 Non-zero if the message was handled and should not be dispatched; 0 if the message was not handled and should be dispatched.  
  
### Remarks  
  
##  \<a name="cframewndex__recalclayout">\</a>  CFrameWndEx::RecalcLayout  
 Adjusts the layout of the frame and its child windows.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 Specifies whether to notify the OLE client item about the layout change.  
  
### Remarks  
 This method is called when the size of the frame window has changed or when control bars are displayed or hidden.  
  
##  \<a name="cframewndex__removepanefromdockmanager">\</a>  CFrameWndEx::RemovePaneFromDockManager  
 Unregisters a pane and removes it from the docking manager.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>  
 A pointer to the control bar pane to remove.  
  
 [in] <CodeContentPlaceHolder>366\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>367\</CodeContentPlaceHolder> to destroy the control bar after removing it; <CodeContentPlaceHolder>368\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>370\</CodeContentPlaceHolder> to adjust the docking layout; <CodeContentPlaceHolder>371\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>372\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>373\</CodeContentPlaceHolder> if the control bar is in auto-hide mode; <CodeContentPlaceHolder>374\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>  
 A pointer to a pane that replaces the removed pane.  
  
### Remarks  
 Use this method to remove a control bar from the docking layout of the frame window.  
  
 The [docking manager](../vs140/cdockingmanager-class.md) handles the layout of control bars. You must register each control bar with the docking manager by using the [AddControlBar](#cframewndex__addpane) method or the [InsertControlBar](#cframewndex__insertpane) method.  
  
##  \<a name="cframewndex__setdockstate">\</a>  CFrameWndEx::SetDockState  
 Restores the docking layout to the docking state stored in the registry.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>  
 The docking state. This parameter is ignored.  
  
##  \<a name="cframewndex__setprintpreviewframe">\</a>  CFrameWndEx::SetPrintPreviewFrame  
 Sets the print preview frame window.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>377\</CodeContentPlaceHolder>  
 Pointer to a print preview frame window.  
  
### Remarks  
  
##  \<a name="cframewndex__setuptoolbarmenu">\</a>  CFrameWndEx::SetupToolbarMenu  
 Inserts user-defined commands into a toolbar menu.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>378\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>379\</CodeContentPlaceHolder> object to be modified.  
  
 [in] <CodeContentPlaceHolder>380\</CodeContentPlaceHolder>  
 The first user-defined command.  
  
 [in] <CodeContentPlaceHolder>381\</CodeContentPlaceHolder>  
 The last user-defined command.  
  
### Remarks  
 The framework stores user-defined commands in a list. Use <CodeContentPlaceHolder>382\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>383\</CodeContentPlaceHolder> to specify the indexes of the commands to insert.  
  
##  \<a name="cframewndex__showfullscreen">\</a>  CFrameWndEx::ShowFullScreen  
 Switches the main frame between full-screen mode and regular mode.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
##  \<a name="cframewndex__showpane">\</a>  CFrameWndEx::ShowPane  
 Shows or hides the specified pane.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>  
 A pointer to the control bar to show or hide.  
  
 [in] <CodeContentPlaceHolder>385\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>386\</CodeContentPlaceHolder>, the application shows the control bar. Otherwise, the application hides the control bar.  
  
 [in] <CodeContentPlaceHolder>387\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>388\</CodeContentPlaceHolder>, delay the adjustment of the docking layout until the framework calls [AdjustDockingLayout](#cframewndex__adjustdockinglayout). Otherwise, recalculate the docking layout immediately.  
  
 [in] <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>390\</CodeContentPlaceHolder>, make the control bar active. Otherwise, display the control bar in an inactive state.  
  
##  \<a name="cframewndex__updatecaption">\</a>  CFrameWndEx::UpdateCaption  
 Called by the framework to update the window frame caption.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cframewndex__winhelp">\</a>  CFrameWndEx::WinHelp  
 Invokes either the WinHelp application or context related help.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>391\</CodeContentPlaceHolder>  
 Data that depends on the <CodeContentPlaceHolder>392\</CodeContentPlaceHolder> parameter. For a list of possible values see                                 [WinHelp](http://msdn.microsoft.com/library/windows/desktop/bb762267).  
  
 <CodeContentPlaceHolder>393\</CodeContentPlaceHolder>  
 The help command. For a list of possible values see                                 [WinHelp](http://msdn.microsoft.com/library/windows/desktop/bb762267).  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CFrameWnd](../vs140/cframewnd-class.md)