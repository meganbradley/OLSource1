---
title: "CPaneFrameWnd Class"
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
  - "CPaneFrameWnd.Serialize"
  - "CPaneFrameWnd.PreTranslateMessage"
  - "CPaneFrameWnd"
  - "CPaneFrameWnd::Serialize"
  - "PreTranslateMessage"
  - "CPaneFrameWnd::PreTranslateMessage"
  - "Serialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPaneFrameWnd class"
  - "Serialize method"
  - "PreTranslateMessage method"
ms.assetid: ea3423a3-2763-482e-b763-817036ded10d
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd Class
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
 Implements a mini-frame window that contains one pane. The pane fills the client area of the window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneFrameWnd::AddPane](#cpaneframewnd__addpane)|Adds a pane.|  
|[CPaneFrameWnd::AddRemovePaneFromGlobalList](#cpaneframewnd__addremovepanefromgloballist)|Adds or removes a pane from the global list.|  
|[CPaneFrameWnd::AdjustLayout](#cpaneframewnd__adjustlayout)|Adjusts the layout of the mini-frame window.|  
|[CPaneFrameWnd::AdjustPaneFrames](#cpaneframewnd__adjustpaneframes)||  
|[CPaneFrameWnd::CalcBorderSize](#cpaneframewnd__calcbordersize)|Calculates the size of the borders for a mini-frame window.|  
|[CPaneFrameWnd::CalcExpectedDockedRect](#cpaneframewnd__calcexpecteddockedrect)|Calculate the expected rectangle of a docked window.|  
|[CPaneFrameWnd::CanBeAttached](#cpaneframewnd__canbeattached)|Determines whether the current pane can be docked to another pane or frame window.|  
|[CPaneFrameWnd::CanBeDockedToPane](#cpaneframewnd__canbedockedtopane)|Determines whether the mini-frame window can be docked to a pane.|  
|[CPaneFrameWnd::CheckGripperVisibility](#cpaneframewnd__checkgrippervisibility)||  
|[CPaneFrameWnd::ConvertToTabbedDocument](#cpaneframewnd__converttotabbeddocument)|Converts the pane to a tabbed document.|  
|[CPaneFrameWnd::Create](#cpaneframewnd__create)|Creates a mini-frame window and attaches it to the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.|  
|[CPaneFrameWnd::CreateEx](#cpaneframewnd__createex)|Creates a mini-frame window and attaches it to the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.|  
|[CPaneFrameWnd::DockPane](#cpaneframewnd__dockpane)|Docks the pane.|  
|[CPaneFrameWnd::FindFloatingPaneByID](#cpaneframewnd__findfloatingpanebyid)|Finds a pane with the specified control ID in the global list of floating panes.|  
|[CPaneFrameWnd::FrameFromPoint](#cpaneframewnd__framefrompoint)|Finds the mini-frame window containing a user-supplied point.|  
|[CPaneFrameWnd::GetCaptionHeight](#cpaneframewnd__getcaptionheight)|Returns the height of the mini-frame window caption.|  
|[CPaneFrameWnd::GetCaptionRect](#cpaneframewnd__getcaptionrect)|Calculates the bounding rectangle of a mini-frame window caption.|  
|[CPaneFrameWnd::GetCaptionText](#cpaneframewnd__getcaptiontext)|Returns the caption text.|  
|[CPaneFrameWnd::GetDockingManager](#cpaneframewnd__getdockingmanager)||  
|[CPaneFrameWnd::GetDockingMode](#cpaneframewnd__getdockingmode)|Returns the docking mode.|  
|[CPaneFrameWnd::GetFirstVisiblePane](#cpaneframewnd__getfirstvisiblepane)|Returns the first visible pane that is contained in a mini-frame window.|  
|[CPaneFrameWnd::GetHotPoint](#cpaneframewnd__gethotpoint)||  
|[CPaneFrameWnd::GetPane](#cpaneframewnd__getpane)|Returns a pane that is contained in the mini-frame window.|  
|[CPaneFrameWnd::GetPaneCount](#cpaneframewnd__getpanecount)|Returns the number of panes that are contained in a mini-frame window.|  
|[CPaneFrameWnd::GetParent](#cpaneframewnd__getparent)||  
|[CPaneFrameWnd::GetPinState](#cpaneframewnd__getpinstate)||  
|[CPaneFrameWnd::GetRecentFloatingRect](#cpaneframewnd__getrecentfloatingrect)||  
|[CPaneFrameWnd::GetVisiblePaneCount](#cpaneframewnd__getvisiblepanecount)|Returns the number of visible panes that are contained in a mini-frame window.|  
|[CPaneFrameWnd::HitTest](#cpaneframewnd__hittest)|Determines what part of a mini-frame window is at a given point.|  
|[CPaneFrameWnd::IsCaptured](#cpaneframewnd__iscaptured)||  
|[CPaneFrameWnd::IsDelayShow](#cpaneframewnd__isdelayshow)||  
|[CPaneFrameWnd::IsRollDown](#cpaneframewnd__isrolldown)|Determines whether a mini-frame window should be rolled down.|  
|[CPaneFrameWnd::IsRollUp](#cpaneframewnd__isrollup)|Determines whether a mini-frame window should be rolled up.|  
|[CPaneFrameWnd::KillDockingTimer](#cpaneframewnd__killdockingtimer)|Stops the docking timer.|  
|[CPaneFrameWnd::LoadState](#cpaneframewnd__loadstate)|Loads the pane's state from the registry.|  
|[CPaneFrameWnd::OnBeforeDock](#cpaneframewnd__onbeforedock)|Determines if docking is possible.|  
|[CPaneFrameWnd::OnDockToRecentPos](#cpaneframewnd__ondocktorecentpos)|Docks the mini-frame window at its most recent position.|  
|[CPaneFrameWnd::OnKillRollUpTimer](#cpaneframewnd__onkillrolluptimer)|Stops the rollup timer.|  
|[CPaneFrameWnd::OnMovePane](#cpaneframewnd__onmovepane)|Moves the mini-frame window by a specified offset.|  
|[CPaneFrameWnd::OnPaneRecalcLayout](#cpaneframewnd__onpanerecalclayout)|Adjusts the layout of a contained pane.|  
|[CPaneFrameWnd::OnSetRollUpTimer](#cpaneframewnd__onsetrolluptimer)|Sets the rollup timer.|  
|[CPaneFrameWnd::OnShowPane](#cpaneframewnd__onshowpane)|Called by the framework when a pane in the mini-frame window is hidden or displayed.|  
|[CPaneFrameWnd::PaneFromPoint](#cpaneframewnd__panefrompoint)|Returns a pane if it contains a user-supplied point inside a mini-frame window.|  
|[CPaneFrameWnd::Pin](#cpaneframewnd__pin)||  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Used by class [CWinApp](../vs140/cwinapp-class.md) to translate window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions.|  
|[CPaneFrameWnd::RedrawAll](#cpaneframewnd__redrawall)|Redraws all mini-frame windows.|  
|[CPaneFrameWnd::RemoveNonValidPanes](#cpaneframewnd__removenonvalidpanes)|Called by the framework to remove non-valid panes.|  
|[CPaneFrameWnd::RemovePane](#cpaneframewnd__removepane)|Removes a pane from the mini-frame window.|  
|[CPaneFrameWnd::ReplacePane](#cpaneframewnd__replacepane)|Replaces one pane with another.|  
|[CPaneFrameWnd::SaveState](#cpaneframewnd__savestate)|Saves the pane's state to the registry.|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Reads or writes this object from or to an archive.|  
|[CPaneFrameWnd::SetCaptionButtons](#cpaneframewnd__setcaptionbuttons)|Sets caption buttons.|  
|[CPaneFrameWnd::SetDelayShow](#cpaneframewnd__setdelayshow)||  
|[CPaneFrameWnd::SetDockingManager](#cpaneframewnd__setdockingmanager)||  
|[CPaneFrameWnd::SetDockingTimer](#cpaneframewnd__setdockingtimer)|Sets the docking timer.|  
|[CPaneFrameWnd::SetDockState](#cpaneframewnd__setdockstate)|Sets the docking state.|  
|[CPaneFrameWnd::SetHotPoint](#cpaneframewnd__sethotpoint)||  
|[CPaneFrameWnd::SetPreDockState](#cpaneframewnd__setpredockstate)|Called by the framework to set the predocking state.|  
|[CPaneFrameWnd::SizeToContent](#cpaneframewnd__sizetocontent)|Adjusts the size of a mini-frame window so that it is equivalent in size to a contained pane.|  
|[CPaneFrameWnd::StartTearOff](#cpaneframewnd__starttearoff)|Tears off a menu.|  
|[CPaneFrameWnd::StoreRecentDockSiteInfo](#cpaneframewnd__storerecentdocksiteinfo)||  
|[CPaneFrameWnd::StoreRecentTabRelatedInfo](#cpaneframewnd__storerecenttabrelatedinfo)||  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneFrameWnd::OnCheckRollState](#cpaneframewnd__oncheckrollstate)|Determines whether a mini-frame window should be rolled up or down.|  
|[CPaneFrameWnd::OnDrawBorder](#cpaneframewnd__ondrawborder)|Draws the borders of a mini-frame window.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneFrameWnd::m_bUseSaveBits](#cpaneframewnd__m_busesavebits)|Specifies whether to register the window class with the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> class style.|  
  
## Remarks  
 The framework automatically creates a <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object when a pane is switched from a docked state to a floating state.  
  
 A mini-frame window can be dragged with its contents visible (immediate docking) or using a drag rectangle (standard docking). The docking mode of the mini-frame's container pane determines the mini-frame's dragging behavior. For more information, see [CBasePane::GetDockingMode](../vs140/cbasepane-class.md#cbasepane__getdockingmode).  
  
 A mini-frame window displays buttons on the caption in accordance with the contained pane style. If the pane can be closed ( [CBasePane::CanBeClosed](../vs140/cbasepane-class.md#cbasepane__canbeclosed)), it displays a Close button. If the pane has the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> style, it displays a pin.  
  
 If you derive a class from <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, you must tell the framework how to create it. Either create the class by overriding [CPane::CreateDefaultMiniframe](../vs140/cpane-class.md#cpane__createdefaultminiframe), or set the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> member so that it points to the runtime class information for your class.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CPaneFrameWnd](../vs140/cpaneframewnd-class.md)  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
##  \<a name="cpaneframewnd__addpane">\</a>  CPaneFrameWnd::AddPane  
 Adds a pane.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The pane to add.  
  
##  \<a name="cpaneframewnd__addremovepanefromgloballist">\</a>  CPaneFrameWnd::AddRemovePaneFromGlobalList  
 Adds or removes a pane from the global list.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The pane to add or remove.  
  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 If non-zero, add the pane. If 0, remove the pane.  
  
### Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
##  \<a name="cpaneframewnd__adjustlayout">\</a>  CPaneFrameWnd::AdjustLayout  
 Adjusts the layout of the mini-frame window.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cpaneframewnd__adjustpaneframes">\</a>  CPaneFrameWnd::AdjustPaneFrames  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpaneframewnd__calcbordersize">\</a>  CPaneFrameWnd::CalcBorderSize  
 Calculates the size of the borders for a miniframe window.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Contains the size, in pixels, of the border of the miniframe window.  
  
### Remarks  
 This method is called by the framework to calculate the size of the border of a miniframe window. The returned size depends on whether a miniframe window contains a toolbar or a [CDockablePane](../vs140/cdockablepane-class.md).  
  
##  \<a name="cpaneframewnd__calcexpecteddockedrect">\</a>  CPaneFrameWnd::CalcExpectedDockedRect  
 Calculate the expected rectangle of a docked window.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 A pointer to the window to dock.  
  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The mouse location.  
  
 [out] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The calculated rectangle.  
  
 [out] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, draw a tab. If <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, do not draw a tab.  
  
 [out] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A pointer to the target pane.  
  
### Remarks  
 This method calculates the rectangle that a window would occupy if a user dragged the window to the point specified by <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> and docked it there.  
  
##  \<a name="cpaneframewnd__canbeattached">\</a>  CPaneFrameWnd::CanBeAttached  
 Determines whether the current pane can be docked to another pane or frame window.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> if the pane can be docked to another pane or frame window; otherwise <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
##  \<a name="cpaneframewnd__canbedockedtopane">\</a>  CPaneFrameWnd::CanBeDockedToPane  
 Determines whether the mini-frame window can be docked to a pane.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A pane.  
  
### Return Value  
 Nonzero if the mini-frame can be docked to <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>; otherwise 0.  
  
##  \<a name="cpaneframewnd__checkgrippervisibility">\</a>  CPaneFrameWnd::CheckGripperVisibility  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpaneframewnd__converttotabbeddocument">\</a>  CPaneFrameWnd::ConvertToTabbedDocument  
 Converts the pane to a tabbed document.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cpaneframewnd__create">\</a>  CPaneFrameWnd::Create  
 Creates a miniframe window and attaches it to the [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Specifies the text to display on the miniframe window.  
  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Specifies the window style. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the miniframe window.  
  
 [in] [out] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Specifies the parent frame of the miniframe window. This value must not be <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
 [in] [out] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Specifies user-defined context.  
  
### Return Value  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> if the window was created successfully; otherwise, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
### Remarks  
 A miniframe window is created in two steps. First, the framework creates a [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object. Second, it calls <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> to create the Windows miniframe window and attach it to the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object.  
  
##  \<a name="cpaneframewnd__createex">\</a>  CPaneFrameWnd::CreateEx  
 Creates a miniframe window and attaches it to the [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 Specifies the extended window style. For more information, see [Extended Window Styles](../vs140/extended-window-styles.md)  
  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Specifies the text to display on the miniframe window.  
  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Specifies the window style. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the miniframe window.  
  
 [in] [out] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Specifies the parent frame of the miniframe window. This value must not be <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
 [in] [out] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Specifies user-defined context.  
  
### Return Value  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> if the window was created successfully; otherwise, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
### Remarks  
 A miniframe window is created in two steps. First, the framework creates a [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object. Second, it calls <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> to create the Windows miniframe window and attach it to the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.  
  
##  \<a name="cpaneframewnd__dockpane">\</a>  CPaneFrameWnd::DockPane  
 Docks the pane.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> if the pane was already docked; otherwise <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
### Return Value  
 If the operation was successful, the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> that the pane was docked to; otherwise <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
##  \<a name="cpaneframewnd__findfloatingpanebyid">\</a>  CPaneFrameWnd::FindFloatingPaneByID  
 Finds a pane with the specified control ID in the global list of floating panes.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Represents the control ID of the pane to find.  
  
### Return Value  
 The pane with the specified control ID; otherwise, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, if no pane has the specified control ID.  
  
##  \<a name="cpaneframewnd__framefrompoint">\</a>  CPaneFrameWnd::FrameFromPoint  
 Finds the mini-frame window that contains the specified point.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The point, in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Increase the search area of the mini-frame window by this size. A mini-frame window satisfies the search criteria if the given point falls in the increased area.  
  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 Specifies a mini-frame window to exclude from the search.  
  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, only search mini-frame windows that have the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> style. If <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, search all mini-frame windows.  
  
### Return Value  
 A pointer to the mini-frame window that contains <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>; otherwise <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
##  \<a name="cpaneframewnd__getcaptionheight">\</a>  CPaneFrameWnd::GetCaptionHeight  
 Returns the height of the mini-frame window caption.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The height, in pixels, of the mini-frame window.  
  
### Remarks  
 Call this method to determine the height of a mini-frame window. By default, the height is set to <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>. For more information, see                         [GetSystemMetrics Function](http://msdn.microsoft.com/library/windows/desktop/ms724385).  
  
##  \<a name="cpaneframewnd__getcaptionrect">\</a>  CPaneFrameWnd::GetCaptionRect  
 Calculates the bounding rectangle of a mini-frame window caption.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Contains the size and position of the mini-frame window caption, in screen coordinates.  
  
### Remarks  
 This method is called by the framework to calculate the bounding rectangle of a mini-frame window caption.  
  
##  \<a name="cpaneframewnd__getcaptiontext">\</a>  CPaneFrameWnd::GetCaptionText  
 Returns the caption text.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The caption text of the mini-frame window.  
  
### Remarks  
 This method is called by the framework when it displays the caption text.  
  
##  \<a name="cpaneframewnd__getdockingmanager">\</a>  CPaneFrameWnd::GetDockingManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpaneframewnd__getdockingmode">\</a>  CPaneFrameWnd::GetDockingMode  
 Returns the docking mode.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The docking mode. One of the following values:  
  
-   <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
  
##  \<a name="cpaneframewnd__getfirstvisiblepane">\</a>  CPaneFrameWnd::GetFirstVisiblePane  
 Returns the first visible pane that is contained in a mini-frame window.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 The first pane in the mini-frame window, or <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> if the mini-frame window contains no panes.  
  
##  \<a name="cpaneframewnd__gethotpoint">\</a>  CPaneFrameWnd::GetHotPoint  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpaneframewnd__getpane">\</a>  CPaneFrameWnd::GetPane  
 Returns a pane that is contained in the mini-frame window.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 The pane that is contained in the mini-frame, or <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> if the mini-frame window contains no panes.  
  
### Remarks  
  
##  \<a name="cpaneframewnd__getpanecount">\</a>  CPaneFrameWnd::GetPaneCount  
 Returns the number of panes that are contained in a mini-frame window.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 The number of panes in the mini-frame window. This value can be zero.  
  
### Remarks  
  
##  \<a name="cpaneframewnd__getparent">\</a>  CPaneFrameWnd::GetParent  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpaneframewnd__getpinstate">\</a>  CPaneFrameWnd::GetPinState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpaneframewnd__getrecentfloatingrect">\</a>  CPaneFrameWnd::GetRecentFloatingRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpaneframewnd__getvisiblepanecount">\</a>  CPaneFrameWnd::GetVisiblePaneCount  
 Returns the number of visible panes that are contained in a mini-frame window.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 The number of visible panes.  
  
### Remarks  
  
##  \<a name="cpaneframewnd__hittest">\</a>  CPaneFrameWnd::HitTest  
 Determines what part of a mini-frame window is at a given point.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The point to test.  
  
 [in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>, check the point against the caption. If <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>, ignore the caption.  
  
### Return Value  
 One of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>|The point is outside the mini-frame window.|  
|<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>|The point is in the client area.|  
|<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>|The point is on the caption.|  
|<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>|The point is at the top.|  
|<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>|The point is at the top left.|  
|<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>|The point is at the top right.|  
|<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>|The point is at the left.|  
|<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>|The point is at the right.|  
|<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>|The point is at the bottom.|  
|<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>|The point is at the bottom left.|  
|<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>|The point is at the bottom right.|  
  
##  \<a name="cpaneframewnd__iscaptured">\</a>  CPaneFrameWnd::IsCaptured  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpaneframewnd__isdelayshow">\</a>  CPaneFrameWnd::IsDelayShow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpaneframewnd__isrolldown">\</a>  CPaneFrameWnd::IsRollDown  
 Determines whether a mini-frame window should be rolled down.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> if the mini-frame window must be rolled down; otherwise, <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is called by the framework to determine whether a mini-frame window should be rolled down. The rollup/rolldown feature is enabled for a mini-frame window if it contains at least one pane that has the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> flag. This flag is set when a pane is created. For more information, see [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex).  
  
 By default, the framework checks whether the mouse pointer is inside the mini-frame window bounding rectangle to determine whether the window has to be rolled down. You can override this behavior in a derived class.  
  
##  \<a name="cpaneframewnd__isrollup">\</a>  CPaneFrameWnd::IsRollUp  
 Determines whether a mini-frame window should be rolled up.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> if the mini-frame window must be rolled up; otherwise, <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is called by the framework to determine whether a mini-frame window should be rolled up. The rollup/rolldown feature is enabled for a mini-frame window if it contains at least one pane that has the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> flag. This flag is set when a pane is created. For more information, see [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex).  
  
 By default, the framework checks whether the mouse pointer is inside the mini-frame window bounding rectangle to determine whether the window has to be rolled up. You can override this behavior in a derived class.  
  
##  \<a name="cpaneframewnd__killdockingtimer">\</a>  CPaneFrameWnd::KillDockingTimer  
 Stops the docking timer.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
##  \<a name="cpaneframewnd__loadstate">\</a>  CPaneFrameWnd::LoadState  
 Loads the pane's state from the registry.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 The profile name.  
  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 The pane ID.  
  
### Return Value  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> if the pane state was loaded successfully; otherwise <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
##  \<a name="cpaneframewnd__m_busesavebits">\</a>  CPaneFrameWnd::m_bUseSaveBits  
 Specifies whether to register the window class that has the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> class style.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 Set this static member to <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> to register the mini-frame window class that has the <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> style. This may help reduce flickering when a user drags the mini-frame window.  
  
##  \<a name="cpaneframewnd__onbeforedock">\</a>  CPaneFrameWnd::OnBeforeDock  
 Determines if docking is possible.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if docking is possible; otherwise, <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
##  \<a name="cpaneframewnd__oncheckrollstate">\</a>  CPaneFrameWnd::OnCheckRollState  
 Determines whether a mini-frame window should be rolled up or down.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Remarks  
 This method is called by the framework to determine whether a mini-frame window should be rolled up or down.  
  
 By default, the framework calls [CPaneFrameWnd::IsRollUp](#cpaneframewnd__isrollup) and [CPaneFrameWnd::IsRollDown](#cpaneframewnd__isrolldown) and just stretches or restores the mini-frame window. You can override this method in a derived class to use a different visual effect.  
  
##  \<a name="cpaneframewnd__ondocktorecentpos">\</a>  CPaneFrameWnd::OnDockToRecentPos  
 Docks the mini-frame window at its most recent position.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
##  \<a name="cpaneframewnd__ondrawborder">\</a>  CPaneFrameWnd::OnDrawBorder  
 Draws the borders of a mini-frame window.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 The device context used to draw the border.  
  
### Remarks  
 This method is called by the framework to draw the borders of the mini-frame window.  
  
##  \<a name="cpaneframewnd__onkillrolluptimer">\</a>  CPaneFrameWnd::OnKillRollUpTimer  
 Stops the rollup timer.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
##  \<a name="cpaneframewnd__onmovepane">\</a>  CPaneFrameWnd::OnMovePane  
 Moves the mini-frame window by a specified offset.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 A pointer to a pane (ignored).  
  
 [in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 The offset by which to move the pane.  
  
##  \<a name="cpaneframewnd__onpanerecalclayout">\</a>  CPaneFrameWnd::OnPaneRecalcLayout  
 Adjusts the layout of a pane inside a mini-frame window.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when it must adjust the layout of a pane inside the mini-frame window.  
  
 By default, the pane is positioned to cover the complete client area of the mini-frame window.  
  
##  \<a name="cpaneframewnd__onsetrolluptimer">\</a>  CPaneFrameWnd::OnSetRollUpTimer  
 Sets the rollup timer.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
##  \<a name="cpaneframewnd__onshowpane">\</a>  CPaneFrameWnd::OnShowPane  
 Called by the framework when a pane in the mini-frame window is hidden or displayed.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 The pane that is being shown or hidden.  
  
 [in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> if the pane is being shown; <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> if the pane is being hidden.  
  
### Remarks  
 Called by the framework when a pane in the mini-frame window is shown or hidden. The default implementation does nothing.  
  
##  \<a name="cpaneframewnd__pin">\</a>  CPaneFrameWnd::Pin  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpaneframewnd__panefrompoint">\</a>  CPaneFrameWnd::PaneFromPoint  
 Returns a pane if it contains a user-supplied point inside a mini-frame window.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 The point that the user clicked, in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> to specify that only visible panes should be returned; otherwise, <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>.  
  
### Return Value  
 The pane that the user clicked, or <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> if no pane exists at that location.  
  
### Remarks  
 Call this method to obtain a pane that contains the given point.  
  
##  \<a name="cpaneframewnd__redrawall">\</a>  CPaneFrameWnd::RedrawAll  
 Redraws all mini-frame windows.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 This method updates all mini-frame windows by calling [CWnd::RedrawWindow](../vs140/cwnd-class.md#cwnd__redrawwindow) for each window.  
  
##  \<a name="cpaneframewnd__removenonvalidpanes">\</a>  CPaneFrameWnd::RemoveNonValidPanes  
 Called by the framework to remove non-valid panes.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
##  \<a name="cpaneframewnd__removepane">\</a>  CPaneFrameWnd::RemovePane  
 Removes a pane from the mini-frame window.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 A pointer to the pane to remove.  
  
 [in] <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 Specifies what happens to the mini-frame window. If <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>, this method destroys the mini-frame window immediately. If it is <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, this method destroys the mini-frame window after a certain delay.  
  
 [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, delayed destruction is disabled. If <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>, delayed destruction is enabled.  
  
### Remarks  
 The framework can destroy mini-frame windows immediately or after a certain delay. If you want to delay destruction of mini-frame windows, pass <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> parameter. Delayed destruction occurs when the framework processes the <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> message.  
  
##  \<a name="cpaneframewnd__replacepane">\</a>  CPaneFrameWnd::ReplacePane  
 Replaces one pane with another.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 A pointer to the original pane.  
  
 [in] <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 A pointer to the pane that replaces the original pane.  
  
##  \<a name="cpaneframewnd__savestate">\</a>  CPaneFrameWnd::SaveState  
 Saves the pane's state to the registry.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The profile name.  
  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The pane ID.  
  
### Return Value  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> if the pane state was saved successfully; otherwise <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>.  
  
##  \<a name="cpaneframewnd__setcaptionbuttons">\</a>  CPaneFrameWnd::SetCaptionButtons  
 Sets caption buttons.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Bitwise-OR combination of the following values:  
  
-   <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
  
##  \<a name="cpaneframewnd__setdelayshow">\</a>  CPaneFrameWnd::SetDelayShow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpaneframewnd__setdockingmanager">\</a>  CPaneFrameWnd::SetDockingManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpaneframewnd__setdockingtimer">\</a>  CPaneFrameWnd::SetDockingTimer  
 Sets the docking timer.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 Timeout value in milliseconds.  
  
##  \<a name="cpaneframewnd__setdockstate">\</a>  CPaneFrameWnd::SetDockState  
 Sets the docking state.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 A pointer to a docking manager.  
  
##  \<a name="cpaneframewnd__sethotpoint">\</a>  CPaneFrameWnd::SetHotPoint  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpaneframewnd__setpredockstate">\</a>  CPaneFrameWnd::SetPreDockState  
 Called by the framework to set the predocking state.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 Possible values:  
  
-   <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>,  
  
-   <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>,  
  
-   <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
  
 [in] <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 A pointer to the pane to dock.  
  
 [in] <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 The docking method. (This parameter is ignored.)  
  
### Return Value  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> if the mini-frame window is undocked; <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> if it is docked.  
  
##  \<a name="cpaneframewnd__sizetocontent">\</a>  CPaneFrameWnd::SizeToContent  
 Adjusts the size of a mini-frame window so that it is equivalent to a contained pane.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Remarks  
 Call this method to adjust the size of a mini-frame window to the size of a contained pane.  
  
##  \<a name="cpaneframewnd__starttearoff">\</a>  CPaneFrameWnd::StartTearOff  
 Tears off a menu.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 A pointer to a menu.  
  
### Return Value  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> if the method was successful; otherwise, <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>.  
  
##  \<a name="cpaneframewnd__storerecentdocksiteinfo">\</a>  CPaneFrameWnd::StoreRecentDockSiteInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpaneframewnd__storerecenttabrelatedinfo">\</a>  CPaneFrameWnd::StoreRecentTabRelatedInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CWnd Class](../vs140/cwnd-class.md)