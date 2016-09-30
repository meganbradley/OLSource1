---
title: "CBasePane Class"
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
  - "CBasePane::get_accKeyboardShortcut"
  - "CBasePane.get_accKeyboardShortcut"
  - "CBasePane.accSelect"
  - "get_accDefaultAction"
  - "accSelect"
  - "CBasePane.accHitTest"
  - "CBasePane.get_accRole"
  - "get_accKeyboardShortcut"
  - "CBasePane::Serialize"
  - "CBasePane"
  - "CBasePane::get_accDefaultAction"
  - "get_accParent"
  - "CBasePane::accSelect"
  - "accLocation"
  - "CBasePane.get_accDescription"
  - "get_accName"
  - "CBasePane::get_accChildCount"
  - "CBasePane.get_accChild"
  - "CBasePane::accHitTest"
  - "accHitTest"
  - "get_accHelp"
  - "CBasePane.get_accChildCount"
  - "CBasePane.get_accValue"
  - "CBasePane::get_accDescription"
  - "get_accChildCount"
  - "CBasePane.accLocation"
  - "CBasePane.PreTranslateMessage"
  - "CBasePane.get_accName"
  - "PreTranslateMessage"
  - "CBasePane::get_accFocus"
  - "get_accDescription"
  - "CBasePane::get_accRole"
  - "get_accValue"
  - "CBasePane.Serialize"
  - "CBasePane::accLocation"
  - "get_accRole"
  - "CBasePane::get_accChild"
  - "get_accFocus"
  - "CBasePane::get_accHelp"
  - "CBasePane.get_accDefaultAction"
  - "CBasePane.get_accHelp"
  - "CBasePane::PreTranslateMessage"
  - "CBasePane::get_accState"
  - "CBasePane.get_accParent"
  - "CBasePane::get_accParent"
  - "get_accChild"
  - "CBasePane::get_accValue"
  - "Serialize"
  - "get_accState"
  - "CBasePane.get_accState"
  - "CBasePane.get_accFocus"
  - "CBasePane::get_accName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_accState method"
  - "get_accHelp method"
  - "CBasePane class"
  - "accLocation method"
  - "accHitTest method"
  - "get_accDescription method"
  - "get_accDefaultAction method"
  - "get_accName method"
  - "get_accFocus method"
  - "get_accRole method"
  - "get_accValue method"
  - "get_accChild method"
  - "accSelect method"
  - "get_accKeyboardShortcut method"
  - "get_accChildCount method"
  - "Serialize method"
  - "PreTranslateMessage method"
  - "get_accParent method"
ms.assetid: 8163dd51-d7c7-4def-9c74-61f8ecdfad82
caps.latest.revision: 43
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane Class
Base class for all panes in MFC.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|Called by the framework to retrieve the child element or child object at a given point on the screen. (Overrides [CWnd::accHitTest](../vs140/cwnd-class.md#cwnd__acchittest).)|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|Called by the framework to retrieve the current screen location for the specified object. (Overrides [CWnd::accLocation](../vs140/cwnd-class.md#cwnd__acclocation).)|  
|[CBasePane::AccNotifyObjectFocusEvent](#cbasepane__accnotifyobjectfocusevent)|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder> does not use this method.|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|Called by the framework to modify the selection or move the keyboard focus of the specified object. (Overrides [CWnd::accSelect](../vs140/cwnd-class.md#cwnd__accselect).)|  
|[CBasePane::AddPane](#cbasepane__addpane)|Adds a pane to the docking manager.|  
|[CBasePane::AdjustDockingLayout](#cbasepane__adjustdockinglayout)|Redirects a call to the docking manager to adjust the docking layout.|  
|[CBasePane::AdjustLayout](#cbasepane__adjustlayout)|Called by the framework when the pane should adjust its internal layout.|  
|[CBasePane::CalcFixedLayout](#cbasepane__calcfixedlayout)|Calculates the horizontal size of a control bar.|  
|[CBasePane::CanAcceptPane](#cbasepane__canacceptpane)|Determines whether another pane can be docked to the pane.|  
|[CBasePane::CanAutoHide](#cbasepane__canautohide)|Determines whether the pane supports auto-hide mode.|  
|[CBasePane::CanBeAttached](#cbasepane__canbeattached)|Determines whether the pane can be docked to another pane.|  
|[CBasePane::CanBeClosed](#cbasepane__canbeclosed)|Determines whether the pane can be closed.|  
|[CBasePane::CanBeDocked](#cbasepane__canbedocked)|Determines whether the pane can be docked to another pane.|  
|[CBasePane::CanBeResized](#cbasepane__canberesized)|Determines whether the pane can be resized.|  
|[CBasePane::CanBeTabbedDocument](#cbasepane__canbetabbeddocument)|Specifies whether the pane can be converted to an MDI tabbed document.|  
|[CBasePane::CanFloat](#cbasepane__canfloat)|Determines whether the pane can float.|  
|[CBasePane::CanFocus](#cbasepane__canfocus)|Specifies whether the pane can receive focus.|  
|[CBasePane::CopyState](#cbasepane__copystate)|Copies the state of a given pane.|  
|[CBasePane::CreateDefaultMiniframe](#cbasepane__createdefaultminiframe)|If the pane can float, creates a mini-frame window.|  
|[CBasePane::CreateEx](#cbasepane__createex)|Creates the pane control.|  
|[CBasePane::DockPane](#cbasepane__dockpane)|Docks a pane to another pane or to a frame window.|  
|[CBasePane::DockPaneUsingRTTI](#cbasepane__dockpaneusingrtti)|Docks the pane by using run-time type information.|  
|[CBasePane::DockToFrameWindow](#cbasepane__docktoframewindow)|Docks a dockable pane to a frame.|  
|[CBasePane::DoesAllowDynInsertBefore](#cbasepane__doesallowdyninsertbefore)|Determines whether another pane can be dynamically inserted between this pane and the parent frame.|  
|[CBasePane::EnableDocking](#cbasepane__enabledocking)|Enables docking of the pane to the main frame.|  
|[CBasePane::EnableGripper](#cbasepane__enablegripper)|Enables or disables the gripper. If the gripper is enabled, the user can drag it to reposition the pane.|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|Used internally.|  
|[CBasePane::FloatPane](#cbasepane__floatpane)|Floats the pane.|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|Called by the framework to retrieve the address of an <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> interface for the specified child. (Overrides [CWnd::get_accChild](../vs140/cwnd-class.md#cwnd__get_accchild).)|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|Called by the framework to retrieve the number of children that belong to this object. (Overrides [CWnd::get_accChildCount](../vs140/cwnd-class.md#cwnd__get_accchildcount).)|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|Called by the framework to retrieve a string that describes the default action for the object. (Overrides [CWnd::get_accDefaultAction](../vs140/cwnd-class.md#cwnd__get_accdefaultaction).)|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|Called by framework to retrieve a string that describes the visual appearance of the specified object. (Overrides [CWnd::get_accDescription](../vs140/cwnd-class.md#cwnd__get_accdescription).)|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|Called by the framework to retrieve the object that has the keyboard focus. (Overrides [CWnd::get_accFocus](../vs140/cwnd-class.md#cwnd__get_accfocus).)|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|Called by the framework to retrieve a  Help property string for the object. (Overrides [CWnd::get_accHelp](../vs140/cwnd-class.md#cwnd__get_acchelp).)|  
|[CBasePane::get_accHelpTopic](#cbasepane__get_acchelptopic)|Called by the framework to retrieve the full path of the WinHelp file that is associated with the specified object and the identifier of the appropriate topic in that file. (Overrides [CWnd::get_accHelpTopic](../vs140/cwnd-class.md#cwnd__get_acchelptopic).)|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|Called by the framework to retrieve the specified shortcut key for the object. (Overrides [CWnd::get_accKeyboardShortcut](../vs140/cwnd-class.md#cwnd__get_acckeyboardshortcut).)|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|Called by the framework to retrieve the name of the specified object. (Overrides [CWnd::get_accName](../vs140/cwnd-class.md#cwnd__get_accname).)|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|Called by the framework to retrieve the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> interface for the parent of the object. (Overrides [CWnd::get_accParent](../vs140/cwnd-class.md#cwnd__get_accparent).)|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|Called by the framework to retrieve information that describes the role of the specified object. (Overrides [CWnd::get_accRole](../vs140/cwnd-class.md#cwnd__get_accrole).)|  
|[CBasePane::get_accSelection](#cbasepane__get_accselection)|Called by the framework to retrieve the selected children of this object. (Overrides [CWnd::get_accSelection](../vs140/cwnd-class.md#cwnd__get_accselection).)|  
|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|Called by the framework to retrieve the current state of the specified object. (Overrides [CWnd::get_accState](../vs140/cwnd-class.md#cwnd__get_accstate).)|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|Called by the framework to retrieve the value of the specified object. (Overrides [CWnd::get_accValue](../vs140/cwnd-class.md#cwnd__get_accvalue).)|  
|[CBasePane::GetCaptionHeight](#cbasepane__getcaptionheight)|Returns the caption height.|  
|[CBasePane::GetControlBarStyle](#cbasepane__getcontrolbarstyle)|Returns the control bar style.|  
|[CBasePane::GetCurrentAlignment](#cbasepane__getcurrentalignment)|Returns the current pane alignment.|  
|[CBasePane::GetDockingMode](#cbasepane__getdockingmode)|Returns the current docking mode for the pane.|  
|[CBasePane::GetDockSiteFrameWnd](#cbasepane__getdocksiteframewnd)|Returns a pointer to the window that is the dock site for the pane.|  
|[CBasePane::GetEnabledAlignment](#cbasepane__getenabledalignment)|Returns the CBRS_ALIGN_ styles that are applied to the pane.|  
|[CBasePane::GetMFCStyle](#cbasepane__getmfcstyle)|Returns the pane styles specific to MFC.|  
|[CBasePane::GetPaneIcon](#cbasepane__getpaneicon)|Returns a handle to the pane icon.|  
|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|Used internally.|  
|[CBasePane::GetPaneRow](#cbasepane__getpanerow)|Returns a pointer to the [CDockingPanesRow](../vs140/cdockingpanesrow-class.md)object where the pane is docked.|  
|[CBasePane::GetPaneStyle](#cbasepane__getpanestyle)|Returns the pane style.|  
|[CBasePane::GetParentDockSite](#cbasepane__getparentdocksite)|Returns a pointer to the parent dock site.|  
|[CBasePane::GetParentMiniFrame](#cbasepane__getparentminiframe)|Returns a pointer to the parent mini-frame window.|  
|[CBasePane::GetParentTabbedPane](#cbasepane__getparenttabbedpane)|Returns a pointer to the parent tabbed pane.|  
|[CBasePane::GetParentTabWnd](#cbasepane__getparenttabwnd)|Returns a pointer to the parent window that is inside a tab.|  
|[CBasePane::GetRecentVisibleState](#cbasepane__getrecentvisiblestate)|The framework calls this method when a pane is restored from an archive.|  
|[CBasePane::HideInPrintPreviewMode](#cbasepane__hideinprintpreviewmode)|Specifies whether the pane is hidden in print preview.|  
|[CBasePane::InsertPane](#cbasepane__insertpane)|Registers the specified pane with the docking manager.|  
|[CBasePane::IsAccessibilityCompatible](#cbasepane__isaccessibilitycompatible)|Specifies whether the pane supports Active Accessibility.|  
|[CBasePane::IsAutoHideMode](#cbasepane__isautohidemode)|Determines whether a pane is in auto-hide mode.|  
|[CBasePane::IsDialogControl](#cbasepane__isdialogcontrol)|Specifies whether the pane is a dialog control.|  
|[CBasePane::IsDocked](#cbasepane__isdocked)|Determines whether the pane is docked.|  
|[CBasePane::IsFloating](#cbasepane__isfloating)|Determines whether the pane is floating.|  
|[CBasePane::IsHorizontal](#cbasepane__ishorizontal)|Determines whether the pane is docked horizontally.|  
|[CBasePane::IsInFloatingMultiPaneFrameWnd](#cbasepane__isinfloatingmultipaneframewnd)|Specifies whether the pane is in a multi-pane frame window.|  
|[CBasePane::IsMDITabbed](#cbasepane__ismditabbed)|Determines whether the pane has been added to an MDI child window as a tabbed document.|  
|[CBasePane::IsPaneVisible](#cbasepane__ispanevisible)|Specifies whether the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> flag is set for the pane.|  
|[CBasePane::IsPointNearDockSite](#cbasepane__ispointneardocksite)|Determines whether a specified point is near the dock site.|  
|[CBasePane::IsResizable](#cbasepane__isresizable)|Determines whether the pane can be resized.|  
|[CBasePane::IsRestoredFromRegistry](#cbasepane__isrestoredfromregistry)|Determines whether the pane is restored from the registry.|  
|[CBasePane::IsTabbed](#cbasepane__istabbed)|Determines whether the pane has been inserted in the tab control of a tabbed window.|  
|<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|Used internally.|  
|[CBasePane::IsVisible](#cbasepane__isvisible)|Determines whether the pane is visible.|  
|[CBasePane::LoadState](#cbasepane__loadstate)|Loads the pane state from the registry.|  
|[CBasePane::MoveWindow](#cbasepane__movewindow)|Moves the pane.|  
|[CBasePane::OnAfterChangeParent](#cbasepane__onafterchangeparent)|Called by the framework when the pane's parent has been changed.|  
|[CBasePane::OnBeforeChangeParent](#cbasepane__onbeforechangeparent)|Called by the framework just before the pane changes its parent window.|  
|[CBasePane::OnDrawCaption](#cbasepane__ondrawcaption)|The framework calls this method when the caption is drawn.|  
|[CBasePane::OnMovePaneDivider](#cbasepane__onmovepanedivider)|This method is currently not used.|  
|[CBasePane::OnPaneContextMenu](#cbasepane__onpanecontextmenu)|Called by the framework when it builds a menu that has a list of panes.|  
|[CBasePane::OnRemoveFromMiniFrame](#cbasepane__onremovefromminiframe)|Called by the framework when a pane is removed from its parent mini frame window.|  
|[CBasePane::OnSetAccData](#cbasepane__onsetaccdata)|<CodeContentPlaceHolder>105\</CodeContentPlaceHolder> does not use this method.|  
|<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|Used internally.|  
|[CBasePane::PaneFromPoint](#cbasepane__panefrompoint)|Returns the pane that contains the given point.|  
|<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>|Used by class [CWinApp](../vs140/cwinapp-class.md) to translate window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. (Overrides [CWnd::PreTranslateMessage](../vs140/cwnd-class.md#cwnd__pretranslatemessage).)|  
|[CBasePane::RecalcLayout](#cbasepane__recalclayout)|<CodeContentPlaceHolder>108\</CodeContentPlaceHolder> does not use this method.|  
|[CBasePane::RemovePaneFromDockManager](#cbasepane__removepanefromdockmanager)|Unregisters a pane and removes it from the list in the docking manager.|  
|[CBasePane::SaveState](#cbasepane__savestate)|Saves the pane's state to the registry.|  
|[CBasePane::SelectDefaultFont](#cbasepane__selectdefaultfont)|Selects the default font for a given device context.|  
|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|Reads or writes this object from or to an archive. (Overrides [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize).)|  
|[CBasePane::SetControlBarStyle](#cbasepane__setcontrolbarstyle)|Sets the control bar style.|  
|[CBasePane::SetDockingMode](#cbasepane__setdockingmode)|Sets the docking mode for the pane.|  
|<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|Used internally.|  
|[CBasePane::SetPaneAlignment](#cbasepane__setpanealignment)|Sets the alignment for the pane.|  
|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|Used internally.|  
|[CBasePane::SetPaneStyle](#cbasepane__setpanestyle)|Sets the style of the pane.|  
|<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>|Used internally.|  
|[CBasePane::SetWindowPos](#cbasepane__setwindowpos)|Changes the size, position, and Z-order of a pane.|  
|[CBasePane::ShowPane](#cbasepane__showpane)|Shows or hides the pane.|  
|[CBasePane::StretchPane](#cbasepane__stretchpane)|Stretches a pane vertically or horizontally.|  
|[CBasePane::UnDockPane](#cbasepane__undockpane)|Removes the pane from the dock site, default slider, or mini-frame window where it is currently docked.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CBasePane::DoPaint](#cbasepane__dopaint)|Fills the background of the pane.|  
  
## Remarks  
 If you want to create a pane class that supports the extended docking features available in MFC, you must derive it from <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> or from [CPane](../vs140/cpane-class.md).  
  
## Customization Tips  
 The following customization tips pertain to the [CBasePane Class](../vs140/cbasepane-class.md) and any classes that inherit from it:  
  
-   When you create a pane, you can apply several new styles:  
  
    -   <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> makes the pane float.  
  
    -   <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> enables auto-hide mode.  
  
    -   <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> enables the pane to be closed (hidden).  
  
     These are flags that you can combine with a bitwise-OR operation.  
  
     <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> implements the following virtual Boolean methods to reflect these flags: [CBasePane::CanBeClosed](#cbasepane__canbeclosed), [CBasePane::CanAutoHide](#cbasepane__canautohide), [CBasePane::CanFloat](#cbasepane__canfloat). You can override them in derived classes to customize their behavior.  
  
-   You can customize docking behavior by overriding [CBasePane::CanAcceptPane](#cbasepane__canacceptpane). Have your pane return <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> from this method to prevent another pane from docking to it.  
  
-   If you want to create a static pane that cannot float and that prevents any other pane from docking before it (similar to the Outlook bar in the OutlookDemo example), create it as non-floating and override [CBasePane::DoesAllowDynInsertBefore](#cbasepane__doesallowdyninsertbefore) to return <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. The default implementation returns <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> if the pane is created without the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> style.  
  
-   Create all panes with IDs other than -1.  
  
-   To determine pane visibility, use [CBasePane::IsVisible](#cbasepane__isvisible). It correctly handles the visibility state in tabbed and auto-hide modes.  
  
-   If you want to create a non-floating resizable pane, create it without the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> style and call [CFrameWnd::DockControlBar](../vs140/cframewnd-class.md#cframewnd__dockcontrolbar).  
  
-   To exclude a pane from a docking layout or to remove a toolbar from its dock bar, call [CBasePane::UnDockPane](#cbasepane__undockpane). Do not call this method for panes in auto-hide mode or for panes that reside in tabs of tabbed windows.  
  
-   If you want to float or undock a pane that is in auto-hide mode, you must call [CDockablePane::SetAutoHideMode](../vs140/cdockablepane-class.md#cdockablepane__setautohidemode) with <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> as the first argument before you call [CBasePane::FloatPane](#cbasepane__floatpane) or [CBasePane::UnDockPane](#cbasepane__undockpane).  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> class. The example demonstrates how to retrieve a pane from the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> class and how to set the docking mode, the pane alignment, and the pane style. The code is from the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#2](../vs140/codesnippet/CPP/cbasepane-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
## Requirements  
 **Header:** afxbasepane.h  
  
##  \<a name="cbasepane__accnotifyobjectfocusevent">\</a>  CBasePane::AccNotifyObjectFocusEvent  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> does not use this method.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Not used.  
  
##  \<a name="cbasepane__addpane">\</a>  CBasePane::AddPane  
 Adds a pane to the docking manager.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 A pointer to a pane to add.  
  
### Remarks  
 This is a convenience method that adds a pane to a docking manager. By using this method, you do not have to write code that analyzes the type of the parent frame.  
  
 For more information, see [CBCGPDockManager](../vs140/cdockingmanager-class.md) and [CMDIFrameWndEx::AddControlBar](../vs140/cmdiframewndex-class.md#cmdiframewndex__addpane).  
  
##  \<a name="cbasepane__adjustdockinglayout">\</a>  CBasePane::AdjustDockingLayout  
 Redirects a call to the docking manager to adjust the docking layout.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 A handle to a structure containing multiple window positions.  
  
### Remarks  
 This is a convenience method that adjusts the docking layout. By using this method, you do not have to write code that analyzes the type of the parent frame.  
  
 For more information, see [CDockingManager::AdjustDockingLayout](../vs140/cdockingmanager-class.md#cdockingmanager__adjustdockinglayout)  
  
##  \<a name="cbasepane__adjustlayout">\</a>  CBasePane::AdjustLayout  
 Called by the framework to adjust the internal layout of a pane.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when a pane has to adjust its internal layout. The base implementation does nothing.  
  
##  \<a name="cbasepane__calcfixedlayout">\</a>  CBasePane::CalcFixedLayout  
 Calculates the horizontal size of a control bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Indicates whether the bar should be stretched to the size of the frame. The <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> parameter is nonzero when the bar is not a docking bar (not available for docking) and is 0 when it is docked or floating (available for docking).  
  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 Indicates that the bar is horizontally or vertically oriented. The <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> parameter is nonzero if the bar is horizontally oriented and is 0 if it is vertically oriented.  
  
### Return Value  
 The control bar size, in pixels, of a <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> object.  
  
### Remarks  
 See the remarks section in [CControlBar::CalcFixedLayout](../vs140/ccontrolbar-class.md#ccontrolbar__calcfixedlayout)  
  
##  \<a name="cbasepane__canacceptpane">\</a>  CBasePane::CanAcceptPane  
 Determines whether another pane can be docked to the pane.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A pointer to the pane to dock.  
  
### Return Value  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> if another pane can be accepted; otherwise <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method before it docks the pane specified by <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> to the current pane.  
  
 Use this method and the [CanBeDocked](#cbasepane__canbedocked) method to control how panes dock to other panes in your application.  
  
 The default implementation returns <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__canautohide">\</a>  CBasePane::CanAutoHide  
 Determines whether the pane supports auto-hide mode.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> if this pane supports auto-hide mode; otherwise <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this function to determine whether the pane supports auto-hide mode.  
  
 During construction, you can set this ability by passing the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> flag to [CreateEx](#cbasepane__createex).  
  
 The default implementation checks for the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> flag. Override this method in a derived class to customize this behavior.  
  
##  \<a name="cbasepane__canbeattached">\</a>  CBasePane::CanBeAttached  
 Determines whether the pane can be docked to another pane or frame window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> if the pane can be docked to another pane or frame window; otherwise <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation returns <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>. Override this method in a derived class to enable or disable the ability to dock without calling [EnableDocking](#cbasepane__enabledocking).  
  
##  \<a name="cbasepane__canbeclosed">\</a>  CBasePane::CanBeClosed  
 Determines whether the pane can be closed.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> if the pane can be closed; otherwise <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to determine whether the pane can be closed. If the method returns <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, a **Close** button is added to the pane's title bar or, if the pane is floating, to the title bar of the pane's miniframe window.  
  
 During construction, you can set this ability by passing the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> flag to [CreateEx](#cbasepane__createex).  
  
 The default implementation checks for the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> flag.  
  
##  \<a name="cbasepane__canbedocked">\</a>  CBasePane::CanBeDocked  
 Determines whether the pane can be docked to another pane.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A pointer to another pane.  
  
### Return Value  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> if this pane can be docked to another pane; otherwise <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method before it docks the pane specified by <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> to the current pane.  
  
 Use this method and the [CanAcceptPane](#cbasepane__canacceptpane) method to control how panes dock to other panes in your application.  
  
 The default implementation returns <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__canberesized">\</a>  CBasePane::CanBeResized  
 Determines whether the pane can be resized.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> if the pane can be resized; otherwise, <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method checks for the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> flag, which is specified by default in <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>. If this flag is not specified, the docking manager flags the pane internally as immovable instead of docking it.  
  
##  \<a name="cbasepane__canbetabbeddocument">\</a>  CBasePane::CanBeTabbedDocument  
 Specifies whether the pane can be converted to an MDI tabbed document.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if the pane can be converted to a tabbed document; otherwise, <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
### Remarks  
 Only objects of certain <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>-derived types, such as the [CDockablePane Class](../vs140/cdockablepane-class.md), can be converted to tabbed documents.  
  
##  \<a name="cbasepane__canfloat">\</a>  CBasePane::CanFloat  
 Determines whether the pane can float.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> if the pane can float; otherwise <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to determine whether the pane can float.  
  
 During construction, you can set this ability by passing the <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> flag to [CreateEx](#cbasepane__createex).  
  
> [!NOTE]
>  The framework assumes that non-floating panes are static and that their docking state cannot change. Therefore, the framework does not save the docking state of non-floating panes.  
  
 The default implementation checks for the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> style.  
  
##  \<a name="cbasepane__canfocus">\</a>  CBasePane::CanFocus  
 Specifies whether the pane can receive focus.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> if the pane can receive focus; otherwise <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class to control focus. For example, because toolbars cannot receive focus, this method returns <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> when it is called on toolbar objects.  
  
 The framework tries to set the input focus when a pane is docked or floated.  
  
##  \<a name="cbasepane__copystate">\</a>  CBasePane::CopyState  
 Copies the state of a given pane.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 A pointer to another pane.  
  
### Remarks  
 This method copies the state from <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> to this pane.  
  
##  \<a name="cbasepane__createdefaultminiframe">\</a>  CBasePane::CreateDefaultMiniframe  
 If the pane can float, this method creates a mini-frame window for it.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 Specifies the initial coordinates of the mini-frame window.  
  
### Return Value  
 A pointer to the new mini-frame window or <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> if the creation failed.  
  
### Remarks  
 The framework calls this method when a pane switches to a floating state. The method creates a mini-frame window and attaches the pane to this window.  
  
 The default implementation returns <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__createex">\</a>  CBasePane::CreateEx  
 Creates the pane control.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 The extended styles (see [CWnd::CreateEx](../vs140/cwnd-class.md#cwnd__createex) for more information).  
  
 [in] <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The window class name.  
  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The window name.  
  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 The window style (see [CWnd::CreateEx](../vs140/cwnd-class.md#cwnd__createex)).  
  
 [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 The initial rectangle.  
  
 [in] <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 Specifies the pane ID. Must be unique.  
  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 Style flags for panes.  
  
 [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 A pointer to <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
  
### Return Value  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> if the pane is created successfully; otherwise <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
### Remarks  
 Creates a window of class <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>. If you specify <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>, this method clears the <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> style bit and sets <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>, because the library does not support panes with captions.  
  
 You can use any combination of child window styles and MFC control bar (CBRS_) styles.  
  
 The library adds several new styles for panes. The following table describes the new styles:  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>195\</CodeContentPlaceHolder>|The pane can float.|  
|<CodeContentPlaceHolder>196\</CodeContentPlaceHolder>|The pane supports auto-hide mode|  
|<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>|The pane can be resized. **Important:**  This style is not implemented.|  
|<CodeContentPlaceHolder>198\</CodeContentPlaceHolder>|The pane can be closed.|  
|<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>|The pane can be rolled up when it floats.|  
|<CodeContentPlaceHolder>200\</CodeContentPlaceHolder>|When one pane docks to another pane that has this style, a regular tabbed window is created. (For more information, see [CBCGTabbedControlBar](../vs140/ctabbedpane-class.md).)|  
|<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>|When one pane docks to another pane that has this style, an Outlook-style tabbed window is created. (For more information, see [CBCGPOutlookBar](../vs140/cmfcoutlookbar-class.md).)|  
  
 To use the new styles, specify them in <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__dockpane">\</a>  CBasePane::DockPane  
 Docks a pane to another pane or to a frame window.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 A pointer to another pane.  
  
 [in] <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 Specifies the destination rectangle.  
  
 [in] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 Specifies the docking method.  
  
### Return Value  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> if the control bar was docked successfully; otherwise, <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this function to dock a pane to another pane or a dock bar ( [BCGPDockBar](../vs140/cdocksite-class.md)) that is specified by <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>, or to a main frame if <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> specifies how the pane is docked. See [CPane::DockPane](../vs140/cpane-class.md#cpane__dockpane) for a list of possible values.  
  
##  \<a name="cbasepane__dockpaneusingrtti">\</a>  CBasePane::DockPaneUsingRTTI  
 Docks the pane by using run-time type information.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>, dock to the docking site. If <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>, dock to the parent frame.  
  
##  \<a name="cbasepane__docktoframewindow">\</a>  CBasePane::DockToFrameWindow  
 Docks a dockable pane to a frame.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The side of the parent frame that you want to dock the pane to.  
  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 The desired size.  
  
 [in] <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> and there are other dockable panes at the side specified by <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>, the pane is docked outside the other panes, closer to the edge of the parent frame. If <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>, the pane is docked closer to the center of the client area.  
  
### Return Value  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method fails if a pane divider ( [CPaneDivider Class](../vs140/cpanedivider-class.md)) cannot be created. Otherwise, it always returns <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__doesallowdyninsertbefore">\</a>  CBasePane::DoesAllowDynInsertBefore  
 Determines whether another pane can be dynamically inserted between this pane and the parent frame.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> if a user can insert another pane; otherwise <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to determine whether a user can dynamically insert a pane before this pane.  
  
 For example, suppose your application creates a pane docked at the left side of the frame (such as the Outlook bar). To prevent the user from docking another pane to the left of the first pane, override this method and return <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.  
  
 We recommend that you override this method and return <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> for non-floating panes derived from [CBCGPDockingControlBar](../vs140/cdockablepane-class.md).  
  
 The default implementation returns <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__dopaint">\</a>  CBasePane::DoPaint  
 Fills the background of the pane.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Remarks  
 The default implementation calls the current visual manager to fill the background ( [CMFCVisualManager::OnFillBarBackground](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onfillbarbackground)).  
  
##  \<a name="cbasepane__enabledocking">\</a>  CBasePane::EnableDocking  
 Enables docking of the pane to the main frame.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 Specifies the docking alignment to enable.  
  
### Remarks  
 Call this method to enable docking alignment to the main frame. You can pass a combination of <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> flags (for more information, see [CControlBar::EnableDocking](../vs140/ccontrolbar-class.md#ccontrolbar__enabledocking)).  
  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> sets the internal flag <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> and the framework checks this flag when a pane is docked.  
  
 Call [GetEnabledAlignment](#cbasepane__getenabledalignment) to determine the docking alignment for a pane.  
  
##  \<a name="cbasepane__enablegripper">\</a>  CBasePane::EnableGripper  
 Enables or disables the gripper. If the gripper is enabled, the user can drag it to reposition the pane.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> to enable the gripper; <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> to disable it.  
  
### Remarks  
 The framework uses this method to enable a gripper instead of using the <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> style.  
  
##  \<a name="cbasepane__floatpane">\</a>  CBasePane::FloatPane  
 Floats the pane.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 Specifies the screen coordinates where the floating pane appears.  
  
 [in] <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 Specifies the dock method to use to float the pane.  
  
 [in] <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 Specifies whether the floating pane is visible ( <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>) or hidden ( <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>).  
  
### Return Value  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> if the pane was floated successfully; otherwise <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to float a pane at the screen position specified by <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__get_acchelptopic">\</a>  CBasePane::get_accHelpTopic  
 The framework calls this method to retrieve the full path of the <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> file that is associated with the specified object and the identifier of the appropriate topic in that file.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 Address of a <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> that receives the full path of the <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> file that is associated with the specified object, if any.  
  
 [in] <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 Specifies whether the Help topic to be retrieved is that of the object or one of the child elements of the object. This parameter can be either <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> (to obtain a Help topic for the object) or a child ID (to obtain a Help topic for one of the child elements of the object).  
  
 [in] <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 Identifies the <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> file topic that is associated with the specified object.  
  
### Return Value  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> does not implement this method. Therefore, <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function is part of the Active Accessibility support in MFC. Override this function in a derived class to provide help information about your object.  
  
##  \<a name="cbasepane__get_accselection">\</a>  CBasePane::get_accSelection  
 The framework calls this method to retrieve the selected children of this object.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 Receives information that identifies the selected children.  
  
### Return Value  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> does not implement this method. If <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>. Otherwise, this method returns <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function is part of the Active Accessibility support in MFC. Override this function in a derived class if you have non-windowed user interface elements other than windowless ActiveX controls.  
  
##  \<a name="cbasepane__getcaptionheight">\</a>  CBasePane::GetCaptionHeight  
 Returns the caption height.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 The caption height.  
  
##  \<a name="cbasepane__getcontrolbarstyle">\</a>  CBasePane::GetControlBarStyle  
 Returns the control bar style.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A bitwise-OR combination of AFX_CBRS_ flags.  
  
### Remarks  
 The return value is a combination of the following possible values.  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>266\</CodeContentPlaceHolder>|Makes the control bar float.|  
|<CodeContentPlaceHolder>267\</CodeContentPlaceHolder>|Enables auto-hide mode.|  
|<CodeContentPlaceHolder>268\</CodeContentPlaceHolder>|Enables resizing of the control bar. When this flag is set, the control bar can be placed in a dockable pane.|  
|<CodeContentPlaceHolder>269\</CodeContentPlaceHolder>|Enables hiding of the control bar.|  
  
##  \<a name="cbasepane__getcurrentalignment">\</a>  CBasePane::GetCurrentAlignment  
 Returns the current pane alignment.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 The current alignment of the control bar. The following table shows the possible values:  
  
|Value|Alignment|  
|-----------|---------------|  
|<CodeContentPlaceHolder>270\</CodeContentPlaceHolder>|Left alignment.|  
|<CodeContentPlaceHolder>271\</CodeContentPlaceHolder>|Right alignment.|  
|<CodeContentPlaceHolder>272\</CodeContentPlaceHolder>|Top alignment.|  
|<CodeContentPlaceHolder>273\</CodeContentPlaceHolder>|Bottom alignment.|  
  
##  \<a name="cbasepane__getdockingmode">\</a>  CBasePane::GetDockingMode  
 Returns the current docking mode for the pane.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 DT_STANDARD if dragging the pane is indicated on the screen by a drag rectangle. DT_IMMEDIATE if the contents of the pane are dragged.  
  
### Remarks  
 The framework calls this method to determine the current docking mode of the pane.  
  
 If <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> is undefined (DT_UNDEFINED), then the docking mode is taken from the global docking mode ( <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>).  
  
 By setting <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> or overriding <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> you can control the docking mode for each pane.  
  
##  \<a name="cbasepane__getdocksiteframewnd">\</a>  CBasePane::GetDockSiteFrameWnd  
 Returns a pointer to the [CDockingPanesRow](../vs140/cdockingpanesrow-class.md)object where the pane is docked.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the dock site of the pane.  
  
### Remarks  
 Call this method to retrieve a pointer to the dock site of the pane. The dock site can be either a main frame window if the pane is docked to the main frame, or a mini-frame window if the pane is floating.  
  
##  \<a name="cbasepane__getenabledalignment">\</a>  CBasePane::GetEnabledAlignment  
 Returns the CBRS_ALIGN_ styles that are applied to the pane.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 A combination of CBRS_ALIGN_ styles. The following table shows the possible styles:  
  
|Flag|Enabled alignment|  
|----------|-----------------------|  
|<CodeContentPlaceHolder>278\</CodeContentPlaceHolder>|Left.|  
|<CodeContentPlaceHolder>279\</CodeContentPlaceHolder>|Right.|  
|<CodeContentPlaceHolder>280\</CodeContentPlaceHolder>|Top.|  
|<CodeContentPlaceHolder>281\</CodeContentPlaceHolder>|Bottom.|  
|<CodeContentPlaceHolder>282\</CodeContentPlaceHolder>|Combination of all flags.|  
  
### Remarks  
 Call this method to determine the enabled alignment for the pane. Enabled alignment means the sides of the main frame window that a pane can be docked to.  
  
 Enable docking alignment by using [EnableDocking](#cbasepane__enabledocking).  
  
##  \<a name="cbasepane__getmfcstyle">\</a>  CBasePane::GetMFCStyle  
 Returns the pane styles that are specific to MFC.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 A combination of library-specific (AFX_CBRS_) pane styles.  
  
##  \<a name="cbasepane__getpaneicon">\</a>  CBasePane::GetPaneIcon  
 Returns a handle to the pane icon.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 Specifies a 32 pixel by 32 pixel icon if <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>; specifies a 16 pixel by 16 pixel icon if <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>.  
  
### Return Value  
 A handle to the pane icon. If unsuccessful, returns <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation calls [CWnd::GetIcon](../vs140/cwnd-class.md#cwnd__geticon).  
  
##  \<a name="cbasepane__getpanerow">\</a>  CBasePane::GetPaneRow  
 Returns a pointer to the [CDockingPanesRow](../vs140/cdockingpanesrow-class.md)object where the pane is docked.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> if the pane is docked, or <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> if it is floating.  
  
### Remarks  
 Call this method to access the row where a pane is docked. For example, to arrange the panes in a particular row, call <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> and then call [CDockingPanesRow::ArrangePanes](../vs140/cdockingpanesrow-class.md#cdockingpanesrow__arrangepanes).  
  
##  \<a name="cbasepane__getpanestyle">\</a>  CBasePane::GetPaneStyle  
 Returns the pane style.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 A combination of control bar styles (including CBRS_ styles) that was set by the [SetBarStyle](#cbasepane__setpanestyle) method at creation time.  
  
##  \<a name="cbasepane__getparentdocksite">\</a>  CBasePane::GetParentDockSite  
 Returns a pointer to the parent dock site.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 The parent dock site.  
  
##  \<a name="cbasepane__getparentminiframe">\</a>  CBasePane::GetParentMiniFrame  
 Returns a pointer to the parent mini-frame window.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>, this method does not check for non-valid pointers. If you call this method when your application exits, set this parameter to <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>.  
  
### Return Value  
 A valid pointer to the parent mini-frame window if the pane is floating; otherwise <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this function to retrieve a pointer to the parent mini-frame window. This method iterates through all parents and checks for an object derived from [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md).  
  
 Use <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> to determine whether the pane is floating.  
  
##  \<a name="cbasepane__getparenttabbedpane">\</a>  CBasePane::GetParentTabbedPane  
 Returns a pointer to the parent tabbed pane.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent tabbed pane if it exists; otherwise <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__getparenttabwnd">\</a>  CBasePane::GetParentTabWnd  
 Returns a pointer to the parent window that is inside a tab.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 If the return value is not <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>, this parameter contains the handle to the parent tabbed window.  
  
### Return Value  
 A valid pointer to the parent tabbed window or <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this function to retrieve a pointer to the parent tabbed window. Sometimes it is not enough to call <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>, because a pane may be inside a docking wrapper ( [CBCGPDockingCBWrapper](../vs140/cdockablepaneadapter-class.md)) or inside a pane adapter ( [CDockablePaneAdapter](../vs140/cdockablepaneadapter-class.md)). By using <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> you will be able to retrieve a valid pointer in those cases (assuming that the parent is a tabbed window).  
  
##  \<a name="cbasepane__getrecentvisiblestate">\</a>  CBasePane::GetRecentVisibleState  
 The framework calls this method when a pane is restored from an archive.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> that specifies the recent visible state. If <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>, the pane was visible when serialized and should be visible when restored. If <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>, the pane was hidden when serialized and should be hidden when restored.  
  
##  \<a name="cbasepane__hideinprintpreviewmode">\</a>  CBasePane::HideInPrintPreviewMode  
 Specifies whether the pane is hidden in print preview.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> if the pane is not shown in print preview; otherwise, <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>.  
  
### Remarks  
 Base panes are not shown in print preview. Therefore, this method always returns <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__insertpane">\</a>  CBasePane::InsertPane  
 Registers the specified pane with the docking manager.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 A pointer to the pane to insert.  
  
 [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 A pointer to the adjacent pane.  
  
 [in] <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> is inserted after <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> is inserted before <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> if the method succeeds, <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cbasepane__isaccessibilitycompatible">\</a>  CBasePane::IsAccessibilityCompatible  
 Specifies whether the pane supports Active Accessibility.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> if the pane supports Active Accessibility; otherwise, <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__isautohidemode">\</a>  CBasePane::IsAutoHideMode  
 Determines whether a pane is in auto-hide mode.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> if the pane is in auto-hide mode; otherwise, <CodeContentPlaceHolder>321\</CodeContentPlaceHolder>.  
  
### Remarks  
 Base panes cannot auto-hide. This method always returns <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__isdialogcontrol">\</a>  CBasePane::IsDialogControl  
 Specifies whether the pane is a dialog box control.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> if the pane is a dialog box control; otherwise, <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework uses this method to ensure layout consistency for all panes.  
  
##  \<a name="cbasepane__isdocked">\</a>  CBasePane::IsDocked  
 Determines whether the pane is docked.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> if the parent of the pane is not a mini-frame or if the pane is floating in a mini-frame with another pane; otherwise, <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__isfloating">\</a>  CBasePane::IsFloating  
 Determines whether the pane is floating.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> if the pane is floating; otherwise, <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method returns the opposite value of [CBasePane::IsDocked](#cbasepane__isdocked).  
  
##  \<a name="cbasepane__ishorizontal">\</a>  CBasePane::IsHorizontal  
 Determines whether the pane is docked horizontally.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>329\</CodeContentPlaceHolder> if the pane is docked horizontally; otherwise <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation checks the current docking alignment for <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__isinfloatingmultipaneframewnd">\</a>  CBasePane::IsInFloatingMultiPaneFrameWnd  
 Specifies whether the pane is in a multi-pane frame window ( [CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)).  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> if the pane is in a multi-pane frame window; otherwise, <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>.  
  
### Remarks  
 Only dockable panes can float in a multi-pane frame window. Therefore, <CodeContentPlaceHolder>334\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__ismditabbed">\</a>  CBasePane::IsMDITabbed  
 Determines whether the pane has been added to an MDI child window as a tabbed document.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> if the pane was added to an MDI child window as a tabbed document; otherwise, <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__ispanevisible">\</a>  CBasePane::IsPaneVisible  
 Specifies whether the <CodeContentPlaceHolder>338\</CodeContentPlaceHolder> flag is set for the pane.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>340\</CodeContentPlaceHolder> is set; otherwise, <CodeContentPlaceHolder>341\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use [CBasePane::IsVisible](#cbasepane__isvisible) to determine pane visibility.  
  
##  \<a name="cbasepane__ispointneardocksite">\</a>  CBasePane::IsPointNearDockSite  
 Determines whether a specified point is near the dock site.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>342\</CodeContentPlaceHolder>  
 The specified point.  
  
 [out] <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>  
 Specifies which edge the point is near. Possible values are <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>  
  
 [out] <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> if the point is near the outer border of the dock site; <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 <CodeContentPlaceHolder>351\</CodeContentPlaceHolder> if the point is near the dock site; otherwise <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>.  
  
### Remarks  
 The point is near the dock site when it is within the sensitivity set in the docking manager. The default sensitivity is 15 pixels.  
  
##  \<a name="cbasepane__isresizable">\</a>  CBasePane::IsResizable  
 Determines whether the pane can be resized.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>353\</CodeContentPlaceHolder> if the pane can be resized by the user; otherwise, <CodeContentPlaceHolder>354\</CodeContentPlaceHolder>.  
  
### Remarks  
 Panes of [CDockablePane Class](../vs140/cdockablepane-class.md) can be resized.  
  
 The status bar ( [CBCGPStatusBar](../vs140/cmfcstatusbar-class.md)) and the dock bar ( [CBCGPDockBar](../vs140/cdocksite-class.md)) cannot be resized.  
  
##  \<a name="cbasepane__isrestoredfromregistry">\</a>  CBasePane::IsRestoredFromRegistry  
 Determines whether the pane is restored from the registry.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>355\</CodeContentPlaceHolder> if the pane is restored from the registry; otherwise, <CodeContentPlaceHolder>356\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__istabbed">\</a>  CBasePane::IsTabbed  
 Determines whether the pane has been inserted in the tab control of a tabbed window.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>357\</CodeContentPlaceHolder> if the control bar is inserted in a tab of a tabbed window; otherwise <CodeContentPlaceHolder>358\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method retrieves a pointer to the immediate parent and determines if the parent's runtime class is [CBCGPBaseTabWnd](../vs140/cmfcbasetabctrl-class.md).  
  
##  \<a name="cbasepane__isvisible">\</a>  CBasePane::IsVisible  
 Determines whether the pane is visible.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>359\</CodeContentPlaceHolder> if the pane is visible; otherwise <CodeContentPlaceHolder>360\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to determine the visibility of a pane. Do not use <CodeContentPlaceHolder>361\</CodeContentPlaceHolder>.  
  
 If the pane is not tabbed (see [IsTabbed](#cbasepane__istabbed)), this method checks for the <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> style. If the pane is tabbed, this method checks the visibility of the parent tabbed window. If the parent window is visible, the function checks the visibility of the pane tab using [CMFCBaseTabCtrl::IsTabVisible](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__istabvisible).  
  
##  \<a name="cbasepane__loadstate">\</a>  CBasePane::LoadState  
 Loads the pane's state from the registry.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>  
 Profile name.  
  
 [in] <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 Profile index.  
  
 [in] <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>  
 Pane ID.  
  
### Return Value  
 <CodeContentPlaceHolder>366\</CodeContentPlaceHolder> if the pane state was loaded successfully; otherwise <CodeContentPlaceHolder>367\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to load the pane state from the registry. Override it in a derived class to load additional information saved by [SaveState](#cbasepane__savestate).  
  
##  \<a name="cbasepane__movewindow">\</a>  CBasePane::MoveWindow  
 Moves the pane.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>368\</CodeContentPlaceHolder>  
 A rectangle specifying the new location and size of the pane.  
  
 [in] <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>, the pane is repainted. If <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>, the pane is not repainted.  
  
 [in] <CodeContentPlaceHolder>372\</CodeContentPlaceHolder>  
 Handle to a deferred window position structure.  
  
### Return Value  
 A handle to a deferred window position structure, or <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>.  
  
### Remarks  
 If you pass <CodeContentPlaceHolder>374\</CodeContentPlaceHolder> as the <CodeContentPlaceHolder>375\</CodeContentPlaceHolder> parameter, this method moves the window normally. If you pass a handle, this method performs a deferred window move. You can obtain a handle by calling                         [BeginDeferWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms632672) or by storing the return value of a previous call to this method.  
  
##  \<a name="cbasepane__onafterchangeparent">\</a>  CBasePane::OnAfterChangeParent  
 Called by the framework after the pane's parent changes.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>  
 A pointer to the previous parent.  
  
### Remarks  
 The framework calls this method after the pane's parent changes, usually because of a docking or floating operation.  
  
 The default implementation does nothing.  
  
##  \<a name="cbasepane__onbeforechangeparent">\</a>  CBasePane::OnBeforeChangeParent  
 Called by the framework just before the pane changes its parent window.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>377\</CodeContentPlaceHolder>  
 A pointer to a new parent window.  
  
 [in] <CodeContentPlaceHolder>378\</CodeContentPlaceHolder>  
 Specifies whether layout adjustments must be delayed.  
  
### Remarks  
 The framework calls this method just before the pane's parent changes, usually because of a docking, floating, or auto-hide operation.  
  
 The default implementation does nothing.  
  
##  \<a name="cbasepane__ondrawcaption">\</a>  CBasePane::OnDrawCaption  
 The framework calls this method when the caption is drawn.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Remarks  
 This method has no functionality for the <CodeContentPlaceHolder>379\</CodeContentPlaceHolder> class.  
  
##  \<a name="cbasepane__onmovepanedivider">\</a>  CBasePane::OnMovePaneDivider  
 This method is currently not used.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>380\</CodeContentPlaceHolder>  
 Not used.  
  
##  \<a name="cbasepane__onpanecontextmenu">\</a>  CBasePane::OnPaneContextMenu  
 Called by the framework when it builds a menu that has a list of panes.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>381\</CodeContentPlaceHolder>  
 A pointer to the parent frame.  
  
 [in] <CodeContentPlaceHolder>382\</CodeContentPlaceHolder>  
 Specifies the location of the shortcut menu.  
  
### Remarks  
 <CodeContentPlaceHolder>383\</CodeContentPlaceHolder> calls the docking manager, which maintains the list of panes that belong to the current frame window. This method adds the names of the panes to a shortcut menu and displays it. The commands on the menu show or hide individual panes.  
  
 Override this method to customize this behavior.  
  
##  \<a name="cbasepane__onremovefromminiframe">\</a>  CBasePane::OnRemoveFromMiniFrame  
 Called by the framework when a pane is removed from its parent mini frame window.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>  
 A pointer to a mini-frame window from which the pane is removed.  
  
### Remarks  
 The framework calls this method when a pane is removed from its parent mini-frame window (as a result of docking, for example).  
  
 The default implementation does nothing.  
  
##  \<a name="cbasepane__onsetaccdata">\</a>  CBasePane::OnSetAccData  
 <CodeContentPlaceHolder>385\</CodeContentPlaceHolder> does not use this method.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>386\</CodeContentPlaceHolder>  
 Not used.  
  
### Return Value  
 This method always returns <CodeContentPlaceHolder>387\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cbasepane__panefrompoint">\</a>  CBasePane::PaneFromPoint  
 Returns the pane that contains the given point.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>388\</CodeContentPlaceHolder>  
 Specifies the point, in screen coordinates, to check.  
  
 [in] <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>  
 Increase the search area by this amount. A pane will satisfy the search criteria if the given point falls in the increased area.  
  
 [in] <CodeContentPlaceHolder>390\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>391\</CodeContentPlaceHolder> to ignore the <CodeContentPlaceHolder>392\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>393\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>394\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>395\</CodeContentPlaceHolder>, the method searches only panes of the specified type.  
  
### Return Value  
 The <CodeContentPlaceHolder>396\</CodeContentPlaceHolder>-derived object that contains the given point, or <CodeContentPlaceHolder>397\</CodeContentPlaceHolder> if no pane was found.  
  
##  \<a name="cbasepane__recalclayout">\</a>  CBasePane::RecalcLayout  
 <CodeContentPlaceHolder>398\</CodeContentPlaceHolder> does not use this method.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
##  \<a name="cbasepane__removepanefromdockmanager">\</a>  CBasePane::RemovePaneFromDockManager  
 Unregisters a pane and removes it from the list in the docking manager.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>399\</CodeContentPlaceHolder>  
 A pointer to a pane to be removed.  
  
 [in] <CodeContentPlaceHolder>400\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>401\</CodeContentPlaceHolder>, the removed pane is destroyed.  
  
 [in] <CodeContentPlaceHolder>402\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>403\</CodeContentPlaceHolder>, adjust the docking layout immediately.  
  
 [in] <CodeContentPlaceHolder>404\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>405\</CodeContentPlaceHolder>, the docking layout is related to the list of autohide bars. If <CodeContentPlaceHolder>406\</CodeContentPlaceHolder>, the docking layout is related to the list of regular panes.  
  
 [in] <CodeContentPlaceHolder>407\</CodeContentPlaceHolder>  
 A pointer to a pane that replaces the removed pane.  
  
##  \<a name="cbasepane__savestate">\</a>  CBasePane::SaveState  
 Saves the pane's state to the registry.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>408\</CodeContentPlaceHolder>  
 Profile name.  
  
 [in] <CodeContentPlaceHolder>409\</CodeContentPlaceHolder>  
 Profile index.  
  
 [in] <CodeContentPlaceHolder>410\</CodeContentPlaceHolder>  
 Pane ID.  
  
### Return Value  
 <CodeContentPlaceHolder>411\</CodeContentPlaceHolder> if the state was saved successfully; otherwise <CodeContentPlaceHolder>412\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when it saves the pane's state to the registry. Override <CodeContentPlaceHolder>413\</CodeContentPlaceHolder> in a derived class to store additional information.  
  
##  \<a name="cbasepane__selectdefaultfont">\</a>  CBasePane::SelectDefaultFont  
 Selects the default font for a given device context.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>414\</CodeContentPlaceHolder>  
 A device context.  
  
### Return Value  
 A pointer to the default [CFont Class](../vs140/cfont-class.md) object.  
  
##  \<a name="cbasepane__setcontrolbarstyle">\</a>  CBasePane::SetControlBarStyle  
 Sets the control bar style.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>  
 A bitwise-OR combination of the following possible values.  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>416\</CodeContentPlaceHolder>|Makes the control bar float.|  
|<CodeContentPlaceHolder>417\</CodeContentPlaceHolder>|Enables auto-hide mode.|  
|<CodeContentPlaceHolder>418\</CodeContentPlaceHolder>|Enables resizing of the control bar. When this flag is set, the control bar can be placed in a dockable pane.|  
|<CodeContentPlaceHolder>419\</CodeContentPlaceHolder>|Enables hiding of the control bar.|  
  
##  \<a name="cbasepane__setdockingmode">\</a>  CBasePane::SetDockingMode  
 Sets the docking mode for the pane.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>420\</CodeContentPlaceHolder>  
 Specifies the new docking mode for the pane.  
  
### Remarks  
 The framework supports two docking modes: standard and immediate.  
  
 In the standard docking mode, panes and mini-frame windows are moved around using a drag rectangle. In the immediate docking mode, control bars and mini-frame windows are moved immediately with their context.  
  
 Initially, the docking mode is defined globally by [CDockingManager::m_dockModeGlobal](../vs140/cdockingmanager-class.md#cdockingmanager__m_dockmodeglobal). You can set the docking mode for each pane individually using the <CodeContentPlaceHolder>421\</CodeContentPlaceHolder> method.  
  
##  \<a name="cbasepane__setpanealignment">\</a>  CBasePane::SetPaneAlignment  
 Sets the alignment for the pane.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>422\</CodeContentPlaceHolder>  
 Specifies the new alignment.  
  
### Remarks  
 Usually, the framework calls this method when a pane is docked from one side of the main frame to another.  
  
 The following table shows the possible values for <CodeContentPlaceHolder>423\</CodeContentPlaceHolder>:  
  
|Value|Alignment|  
|-----------|---------------|  
|<CodeContentPlaceHolder>424\</CodeContentPlaceHolder>|Left alignment.|  
|<CodeContentPlaceHolder>425\</CodeContentPlaceHolder>|Right alignment.|  
|<CodeContentPlaceHolder>426\</CodeContentPlaceHolder>|Top alignment.|  
|<CodeContentPlaceHolder>427\</CodeContentPlaceHolder>|Bottom alignment.|  
  
##  \<a name="cbasepane__setpanestyle">\</a>  CBasePane::SetPaneStyle  
 Sets the style of the pane.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>428\</CodeContentPlaceHolder>  
 Specifies the new style to set.  
  
### Remarks  
 This method can be used to set any of the CBRS_ styles that are defined in afxres.h. Because pane style and pane alignment are stored together, set the new style by combining it with the current alignment as follows.  
  
 <CodeContentPlaceHolder>429\</CodeContentPlaceHolder>  
  
##  \<a name="cbasepane__setwindowpos">\</a>  CBasePane::SetWindowPos  
 Changes the size, position, and Z-order of a pane.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>430\</CodeContentPlaceHolder>  
 Identifies the <CodeContentPlaceHolder>431\</CodeContentPlaceHolder> object that comes before this <CodeContentPlaceHolder>432\</CodeContentPlaceHolder> object in the Z-order. For more information, see [CWnd::SetWindowPos](../vs140/cwnd-class.md#cwnd__setwindowpos).  
  
 [in] <CodeContentPlaceHolder>433\</CodeContentPlaceHolder>  
 Specifies the position of the left side of the window.  
  
 [in] <CodeContentPlaceHolder>434\</CodeContentPlaceHolder>  
 Specifies the position of the top of the window.  
  
 [in] <CodeContentPlaceHolder>435\</CodeContentPlaceHolder>  
 Specifies the width of the window.  
  
 [in] <CodeContentPlaceHolder>436\</CodeContentPlaceHolder>  
 Specifies the height of the window.  
  
 [in] <CodeContentPlaceHolder>437\</CodeContentPlaceHolder>  
 Specifies size and position options. For more information, see [CWnd::SetWindowPos](../vs140/cwnd-class.md#cwnd__setwindowpos).  
  
 [in] <CodeContentPlaceHolder>438\</CodeContentPlaceHolder>  
 Handle to a structure that contains size and position information for one or more windows.  
  
### Return Value  
 A handle to an updated deferred window position structure, or <CodeContentPlaceHolder>439\</CodeContentPlaceHolder>.  
  
### Remarks  
 If <CodeContentPlaceHolder>440\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>441\</CodeContentPlaceHolder>, this method calls [CWnd::SetWindowPos](../vs140/cwnd-class.md#cwnd__setwindowpos). If <CodeContentPlaceHolder>442\</CodeContentPlaceHolder> is non- <CodeContentPlaceHolder>443\</CodeContentPlaceHolder>, this method calls <CodeContentPlaceHolder>444\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasepane__showpane">\</a>  CBasePane::ShowPane  
 Shows or hides the pane.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>445\</CodeContentPlaceHolder>  
 Specifies whether to show ( <CodeContentPlaceHolder>446\</CodeContentPlaceHolder>) or hide ( <CodeContentPlaceHolder>447\</CodeContentPlaceHolder>) a pane.  
  
 [in] <CodeContentPlaceHolder>448\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>449\</CodeContentPlaceHolder>, recalculating the docking layout is delayed.  
  
 [in] <CodeContentPlaceHolder>450\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>451\</CodeContentPlaceHolder>, the pane is active when shown.  
  
### Remarks  
 This method shows or hides a pane. Use this method instead of <CodeContentPlaceHolder>452\</CodeContentPlaceHolder> because this method notifies the relevant docking managers about changes in the pane's visibility.  
  
 Use [CBasePane::IsVisible](#cbasepane__isvisible) to determine the current visibility of a pane.  
  
##  \<a name="cbasepane__stretchpane">\</a>  CBasePane::StretchPane  
 Stretches a pane vertically or horizontally.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>453\</CodeContentPlaceHolder>  
 The length by which to stretch the pane.  
  
 [in] <CodeContentPlaceHolder>454\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>455\</CodeContentPlaceHolder>, stretch the pane vertically. If <CodeContentPlaceHolder>456\</CodeContentPlaceHolder>, stretch the pane horizontally.  
  
### Return Value  
 The size of the stretched pane.  
  
##  \<a name="cbasepane__undockpane">\</a>  CBasePane::UndockPane  
 Removes the pane from the dock site, default slider, or mini-frame window where it is currently docked.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>457\</CodeContentPlaceHolder>  
 If TRUE, the docking layout is not recalculated immediately.  
  
### Remarks  
 Call this method to manipulate the pane state or exclude the pane from the docking layout.  
  
 If you want to continue to use this pane, call either [CBasePane::DockPane](#cbasepane__dockpane) or [CBasePane::FloatPane](#cbasepane__floatpane) before calling this method.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CPane](../vs140/cbasepane-class.md)   
 [CWnd](../vs140/cwnd-class.md)