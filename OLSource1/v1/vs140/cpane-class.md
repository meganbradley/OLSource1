---
title: "CPane Class"
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
  - "CPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPane class"
ms.assetid: 5c651a64-3c79-4d94-9676-45f6402a6bc5
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane Class
The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> class is an enhancement of the [CControlBar Class](../vs140/ccontrolbar-class.md). If you are upgrading an existing MFC project, replace all occurrences of <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPane::AdjustSizeImmediate](#cpane__adjustsizeimmediate)|Immediately recalculates the layout of a pane.|  
|[CPane::AllocElements](#cpane__allocelements)|Allocates storage for internal use.|  
|[CPane::AllowShowOnPaneMenu](#cpane__allowshowonpanemenu)|Specifies whether the pane is listed in the runtime-generated list of panes for the application.|  
|[CPane::CalcAvailableSize](#cpane__calcavailablesize)|Calculates the difference in size between a specified rectangle and the current window rectangle.|  
|[CPane::CalcInsideRect](#cpane__calcinsiderect)|Calculates the inside rectangle of a pane, taking into account the borders and grippers.|  
|[CPane::CalcRecentDockedRect](#cpane__calcrecentdockedrect)|Calculates the recently docked rectangle.|  
|[CPane::CalcSize](#cpane__calcsize)|Calculates the size of the pane.|  
|[CPane::CanBeDocked](#cpane__canbedocked)|Determines whether the pane can be docked at the specified base pane.|  
|[CPane::CanBeTabbedDocument](#cpane__canbetabbeddocument)|Determines whether the pane can be converted to a tabbed document.|  
|[CPane::ConvertToTabbedDocument](#cpane__converttotabbeddocument)|Converts a dockable pane to a tabbed document.|  
|[CPane::CopyState](#cpane__copystate)|Copies the state of a pane. (Overrides [CBasePane::CopyState](../vs140/cbasepane-class.md#cbasepane__copystate).)|  
|[CPane::Create](#cpane__create)|Creates a control bar and attaches it to the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object.|  
|[CPane::CreateDefaultMiniframe](#cpane__createdefaultminiframe)|Creates a mini-frame window for a floating pane.|  
|[CPane::CreateEx](#cpane__createex)|Creates a control bar and attaches it to the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CPane::DockByMouse](#cpane__dockbymouse)|Docks a pane by using the mouse docking method.|  
|[CPane::DockPane](#cpane__dockpane)|Docks the floating pane to a base pane.|  
|[CPane::DockPaneStandard](#cpane__dockpanestandard)|Docks a pane by using outline (standard) docking.|  
|[CPane::DockToFrameWindow](#cpane__docktoframewindow)|Docks a dockable pane to a frame. (Overrides <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.)|  
|[CPane::DoesAllowSiblingBars](#cpane__doesallowsiblingbars)|Indicates whether you can dock another pane at the same row where the current pane is docked.|  
|[CPane::FloatPane](#cpane__floatpane)|Floats the pane.|  
|[CPane::GetAvailableExpandSize](#cpane__getavailableexpandsize)|Returns the amount, in pixels, that the pane can expand.|  
|[CPane::GetAvailableStretchSize](#cpane__getavailablestretchsize)|Returns the amount, in pixels, that the pane can shrink.|  
|[CPane::GetBorders](#cpane__getborders)|Returns the width of the borders of the pane.|  
|[CPane::GetClientHotSpot](#cpane__getclienthotspot)|Returns the *hot spot* for the pane.|  
|[CPane::GetDockSiteRow](#cpane__getdocksiterow)|Returns the dock row in which the pane is docked.|  
|[CPane::GetExclusiveRowMode](#cpane__getexclusiverowmode)|Determines whether the pane is in exclusive row mode.|  
|[CPane::GetHotSpot](#cpane__gethotspot)|Returns the hot spot that is stored in an underlying <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object.|  
|[CPane::GetMinSize](#cpane__getminsize)|Retrieves the minimum allowed size for the pane.|  
|[CPane::GetPaneName](#cpane__getpanename)|Retrieves the title for the pane.|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|Used internally.|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CPane::GetVirtualRect](#cpane__getvirtualrect)|Retrieves the *virtual rectangle* of the pane.|  
|[CPane::IsChangeState](#cpane__ischangestate)|As the pane is being moved, this method analyzes the position of the pane relative to other panes, dock rows, and mini-frame windows, and returns the appropriate <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> value.|  
|[CPane::IsDragMode](#cpane__isdragmode)|Specifies whether the pane is being dragged.|  
|[CPane::IsInFloatingMultiPaneFrameWnd](#cpane__isinfloatingmultipaneframewnd)|Specifies whether the pane is in a multi-pane frame window. (Overrides <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.)|  
|[CPane::IsLeftOf](#cpane__isleftof)|Determines whether the pane is left of (or above) the specified rectangle.|  
|[CPane::IsResizable](#cpane__isresizable)|Determines whether the pane can be resized. (Overrides [CBasePane::IsResizable](../vs140/cbasepane-class.md#cbasepane__isresizable).)|  
|[CPane::IsTabbed](#cpane__istabbed)|Determines whether the pane has been inserted in the tab control of a tabbed window. (Overrides [CBasePane::IsTabbed](../vs140/cbasepane-class.md#cbasepane__istabbed).)|  
|[CPane::LoadState](#cpane__loadstate)|Loads the state of the pane from the registry. (Overrides [CBasePane::LoadState](../vs140/cbasepane-class.md#cbasepane__loadstate).)|  
|[CPane::MoveByAlignment](#cpane__movebyalignment)|Moves the pane and the virtual rectangle by the specified amount.|  
|[CPane::MovePane](#cpane__movepane)|Moves the pane to the specified rectangle.|  
|[CPane::OnAfterChangeParent](#cpane__onafterchangeparent)|Called by the framework when the parent of a pane has changed.|  
|[CPane::OnBeforeChangeParent](#cpane__onbeforechangeparent)|Called by the framework when the parent of the pane is about to change.|  
|[CPane::OnPressCloseButton](#cpane__onpressclosebutton)|Called by the framework when the user chooses the Close button on the caption for the pane.|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Used internally.|  
|[CPane::OnShowControlBarMenu](#cpane__onshowcontrolbarmenu)|Called by the framework when a special pane menu is about to be displayed.|  
|[CPane::OnShowPaneMenu](#cpane__onshowcontrolbarmenu)|Called by the framework when a special pane menu is about to be displayed.|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Used internally.|  
|[CPane::RecalcLayout](#cpane__recalclayout)|Recalculates layout information for the pane. (Overrides [CBasePane::RecalcLayout](../vs140/cbasepane-class.md#cbasepane__recalclayout).)|  
|[CPane::SaveState](#cpane__savestate)|Saves the state of the pane to the registry. (Overrides [CBasePane::SaveState](../vs140/cbasepane-class.md#cbasepane__savestate).)|  
|[CPane::SetActiveInGroup](#cpane__setactiveingroup)|Flags a pane as active.|  
|[CPane::SetBorders](#cpane__setborders)|Sets the border values of the pane.|  
|[CPane::SetClientHotSpot](#cpane__setclienthotspot)|Sets the hot spot for the pane.|  
|[CPane::SetDockState](#cpane__setdockstate)|Restores docking state information for the pane.|  
|[CPane::SetExclusiveRowMode](#cpane__setexclusiverowmode)|Enables or disables the exclusive row mode.|  
|[CPane::SetMiniFrameRTC](#cpane__setminiframertc)|Sets the runtime class information for the default mini-frame window.|  
|[CPane::SetMinSize](#cpane__setminsize)|Sets the minimum allowed size for the pane.|  
|[CPane::SetVirtualRect](#cpane__setvirtualrect)|Sets the *virtual rectangle* of the pane.|  
|[CPane::StretchPaneDeferWndPos](#cpane__stretchpanedeferwndpos)|Stretches the pane vertically or horizontally based on docking style.|  
|[CPane::ToggleAutoHide](#cpane__toggleautohide)|Toggles auto-hide mode.|  
|[CPane::UndockPane](#cpane__undockpane)|Removes the pane from the dock site, default slider, or mini-frame window where it is currently docked. (Overrides [CBasePane::UndockPane](../vs140/cbasepane-class.md#cbasepane__undockpane).)|  
|[CPane::UpdateVirtualRect](#cpane__updatevirtualrect)|Updates the virtual rectangle.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPane::OnAfterDock](#cpane__onafterdock)|Called by the framework when a pane has been docked.|  
|[CPane::OnAfterFloat](#cpane__onafterfloat)|Called by the framework when a pane has been floated.|  
|[CPane::OnBeforeDock](#cpane__onbeforedock)|Called by the framework when the pane is about to be docked.|  
|[CPane::OnBeforeFloat](#cpane__onbeforefloat)|Called by the framework when a pane is about to be floated.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPane::m_bHandleMinSize](#cpane__m_bhandleminsize)|Enables consistent handling of the minimal size for panes.|  
|[CPane::m_recentDockInfo](#cpane__m_recentdockinfo)|Contains recent docking information.|  
  
## Remarks  
 Typically, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> objects are not instantiated directly. If you require a pane that has docking functionality, derive your object from [CDockablePane](../vs140/cdockablepane-class.md). If you require toolbar functionality, derive your object from [CMFCToolBar](../vs140/cmfctoolbar-class.md).  
  
 When you derive a class from <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, it can be docked in a [CDockSite](../vs140/cdocksite-class.md) and it can be floated in a [CPaneFrameWnd](../vs140/cpaneframewnd-class.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
## Requirements  
 **Header:** afxPane.h  
  
##  \<a name="cpane__adjustsizeimmediate">\</a>  CPane::AdjustSizeImmediate  
 Immediately recalculates the layout of a pane.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to automatically recalculate the layout of the pane; otherwise, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method when you dynamically change the layout of a pane. For example, you may want to call this method when you hide or show toolbar buttons.  
  
##  \<a name="cpane__allocelements">\</a>  CPane::AllocElements  
 Allocates storage for internal use.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The number of elements for which to allocate storage.  
  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The size, in bytes, of an element.  
  
### Return Value  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> if memory allocation fails; otherwise, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__allowshowonpanemenu">\</a>  CPane::AllowShowOnPaneMenu  
 Specifies whether the pane is listed in the runtime-generated list of panes for the application.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> if the pane is displayed in the list; otherwise, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. The base implementation always returns <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
### Remarks  
 The AppWizard-generated application contains a menu option that lists panes that it contains. This method determines whether the pane is displayed in the list.  
  
##  \<a name="cpane__calcavailablesize">\</a>  CPane::CalcAvailableSize  
 Calculates the difference in size between a specified rectangle and the current window rectangle.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The required rectangle.  
  
### Return Value  
 The difference in width and height between <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> and the current window rectangle.  
  
##  \<a name="cpane__calcinsiderect">\</a>  CPane::CalcInsideRect  
 Calculates the inside rectangle of a pane, including the borders and grippers.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Contains the size and offset of the client area of the pane.  
  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> if the pane is oriented horizontally; otherwise, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is called by the framework when it has to recalculate the layout for a pane. The <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> parameter is filled with the size and offset of the client area of the pane. This includes its borders and grippers.  
  
##  \<a name="cpane__calcrecentdockedrect">\</a>  CPane::CalcRecentDockedRect  
 Calculates the recently docked rectangle.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This method updates [CPane::m_recentDockInfo](#cpane__m_recentdockinfo).  
  
##  \<a name="cpane__calcsize">\</a>  CPane::CalcSize  
 Calculates the size of the pane.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> if the pane is being docked vertically, <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 The default implementation of this method returns a size of (0, 0).  
  
### Remarks  
 Derived classes should override this method.  
  
##  \<a name="cpane__canbedocked">\</a>  CPane::CanBeDocked  
 Determines if the pane can be docked at the specified base pane.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Specifies the pane where this pane is to be docked.  
  
### Return Value  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if this pane can be docked at the specified docking pane; otherwise, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is usually called by the framework to determine whether a pane can be docked at the specified docking pane. To determine whether the pane can be docked, the method evaluates the pane's currently enabled docking alignment.  
  
 You enable docking to the various sides of the frame window by calling [CBasePane::EnableDocking](../vs140/cbasepane-class.md#cbasepane__enabledocking).  
  
##  \<a name="cpane__canbetabbeddocument">\</a>  CPane::CanBeTabbedDocument  
 Determines if the pane can be converted to a tabbed document.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> if the pane can be converted to a tabbed document; otherwise, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class and return <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> if you want to prevent a pane from being converted to a tabbed document. A tabbed document will not be listed in the Window Position menu.  
  
##  \<a name="cpane__converttotabbeddocument">\</a>  CPane::ConvertToTabbedDocument  
 Converts a dockable pane to a tabbed document.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Not used in <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Remarks  
 Only dockable panes can be converted to tabbed documents. For information, see [CDockablePane::ConvertToTabbedDocument](../vs140/cdockablepane-class.md#cdockablepane__converttotabbeddocument).  
  
##  \<a name="cpane__copystate">\</a>  CPane::CopyState  
 Copies the state of a pane.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A pointer to a pane.  
  
### Remarks  
 This method copies the state of <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> to the current pane.  
  
##  \<a name="cpane__create">\</a>  CPane::Create  
 Creates a control bar and attaches it to the [CPane](../vs140/cpane-class.md) object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Specifies the name of the Windows class.  
  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Specifies the window style attributes. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> window, in client coordinates.  
  
 [in] [out] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Specifies the parent window of this pane.  
  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Specifies the ID of the pane.  
  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 Specifies the style for the pane. For more information, see [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex).  
  
 [in] [out] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Specifies the create context of the pane.  
  
### Return Value  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> if the pane was created successfully; otherwise, <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method creates a Windows pane and attaches it to the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object.  
  
 If you have not explicitly initialized [CPane::m_recentDockInfo](#cpane__m_recentdockinfo) before you call <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, the parameter <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> will be used as the rectangle when floating or docking the pane.  
  
##  \<a name="cpane__createdefaultminiframe">\</a>  CPane::CreateDefaultMiniframe  
 Creates a mini-frame window for a floating pane.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Specifies the initial size and position, in screen coordinates, of the mini-frame window to create.  
  
### Return Value  
 The newly created mini-frame window.  
  
### Remarks  
 This method is called by the framework to create a mini-frame window when a pane is floated. The mini-frame window can be of type [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) or of type [CMultiPaneFrameWnd](../vs140/cmultipaneframewnd-class.md). A multi mini-frame window is created if the pane has the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> style.  
  
 The runtime class information for the mini-frame window is stored in the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> member. You can use a derived class to set this member if you decide to create customized mini-frame windows.  
  
##  \<a name="cpane__createex">\</a>  CPane::CreateEx  
 Creates a control bar and attaches it to the [CPane](../vs140/cpane-class.md) object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Specifies extended window style attributes. For more information, see [Extended Window Styles](../vs140/extended-window-styles.md).  
  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Specifies the name of the Windows class.  
  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Specifies window style attributes. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> window, in client coordinates.  
  
 [in] [out] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 Specifies the parent window of this pane.  
  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Specifies the ID of the pane.  
  
 [in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 Specifies the style for the pane. For more information, see [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex).  
  
 [in] [out] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Specifies the create context for the pane.  
  
### Return Value  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> if the pane was created successfully; otherwise, <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method creates a Windows pane and attaches it to the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object.  
  
 If you have not explicitly initialized [CPane::m_recentDockInfo](#cpane__m_recentdockinfo) before you call <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, the parameter <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> will be used as the rectangle when floating or docking the pane.  
  
##  \<a name="cpane__dockbymouse">\</a>  CPane::DockByMouse  
 Docks a pane by using the mouse.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Specifies the base pane to which to dock this pane.  
  
### Return Value  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> if the pane was docked successfully; otherwise, <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__dockpane">\</a>  CPane::DockPane  
 Docks the floating pane to a base pane.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 Specifies the base pane to dock this pane to.  
  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Specifies the rectangle on the base pane where this pane is to be docked.  
  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Specifies the docking method to use. Available options are as follows:  
  
|Option|Description|  
|------------|-----------------|  
|<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>|The framework uses this option when the docking method is unknown. The pane does not store its most recent floating position. You can also use this option to programmatically dock a pane when you do not have to store the recent floating position.|  
|<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>|Used internally.|  
|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|This option is used when the gripper is double-clicked. The pane is repositioned at its most recent docking position. If the pane is undocked by double-clicking, the pane is repositioned at its most recent floating position.|  
|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|This option can be used to programmatically dock the pane. The pane stores its most recent floating position.|  
|<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|The pane is docked in the region that is specified by <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>|When you use this option, the framework draws the pane as an outline frame while it is being moved.|  
  
### Return Value  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> if the pane was docked successfully; otherwise, <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method docks the pane to the base pane that is specified by the <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> parameter. You must first enable docking by calling [CBasePane::EnableDocking](../vs140/cbasepane-class.md#cbasepane__enabledocking).  
  
##  \<a name="cpane__dockpanestandard">\</a>  CPane::DockPaneStandard  
 Docks a pane by using outline (standard) docking.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> if the pane was successfully docked; otherwise, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  
  
### Return Value  
 This method always returns the <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> pointer.  
  
### Remarks  
 This method is used only for panes that are derived from the [CDockablePane Class](../vs140/cdockablepane-class.md). For more information, see [CDockablePane::DockPaneStandard](../vs140/cdockablepane-class.md#cdockablepane__dockpanestandard).  
  
##  \<a name="cpane__docktoframewindow">\</a>  CPane::DockToFrameWindow  
 Docks a dockable pane to a frame.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 The side of the parent frame that you want to dock the pane to.  
  
 [in] <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 The specified size.  
  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 Ignored.  
  
 [in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> and there are other dockable panes at the side that are specified by <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, the pane is docked outside the other panes, closer to the edge of the parent frame. If <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, the pane is docked closer to the center of the client area.  
  
### Return Value  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> if a pane divider ( [CPaneDivider Class](../vs140/cpanedivider-class.md)) cannot be created; otherwise, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cpane__doesallowsiblingbars">\</a>  CPane::DoesAllowSiblingBars  
 Indicates whether you can dock another pane at the same row where the current pane is docked.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> if this pane can dock to another pane on the same row as itself; otherwise, <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can enable or disable this behavior by calling [CPane::SetExclusiveRowMode](#cpane__setexclusiverowmode).  
  
 By default, toolbars have exclusive row mode disabled and the menu bar has exclusive row mode enabled.  
  
##  \<a name="cpane__floatpane">\</a>  CPane::FloatPane  
 Floats the pane.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Specifies the location, in screen coordinates, to position the pane when it is floated.  
  
 [in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 Specifies the docking method to use when the pane is floated. For a list of possible values, see [CPane::DockPane](#cpane__dockpane).  
  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> to show the pane when floated; otherwise, <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> if the pane was floated successfully or if the pane cannot be floated because [CBasePane::CanFloat](../vs140/cbasepane-class.md#cbasepane__canfloat) returns <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to float the pane at the position that is specified by the <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> parameter. This method automatically creates a parent mini-frame window for the pane.  
  
##  \<a name="cpane__getavailableexpandsize">\</a>  CPane::GetAvailableExpandSize  
 Returns the amount, in pixels, that the pane can expand.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 If the pane is docked horizontally, the return value is the available width; otherwise, the return value is the available height.  
  
### Remarks  
  
##  \<a name="cpane__getavailablestretchsize">\</a>  CPane::GetAvailableStretchSize  
 Returns the amount, in pixels, that the pane can shrink.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The amount, in pixels, that the pane can shrink. If the pane is docked horizontally, this amount is the available width; otherwise, it is the available height.  
  
### Remarks  
 The available stretch size is calculated by subtracting the minimum allowed size for the pane ( [CPane::GetMinSize](#cpane__getminsize)) from the current size ( [CWnd::GetWindowRect](../vs140/cwnd-class.md#cwnd__getwindowrect)).  
  
##  \<a name="cpane__getborders">\</a>  CPane::GetBorders  
 Returns the width of the borders of the pane.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A [CRect](../vs140/crect-class.md) object that contains the current width, in pixels, of each side of the pane. For example, the value of the <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> object is the width of the left border.  
  
### Remarks  
 To set the size of the borders, call [CPane::SetBorders](#cpane__setborders).  
  
##  \<a name="cpane__getclienthotspot">\</a>  CPane::GetClientHotSpot  
 Returns the *hot spot* for the pane.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
 The *hot spot* is the point on the pane that the user selects and holds to move the pane. A hot spot is used for smooth animation when the pane is moved from a docked position.  
  
##  \<a name="cpane__getdocksiterow">\</a>  CPane::GetDockSiteRow  
 Returns the dock row ( [CDockingPanesRow Class](../vs140/cdockingpanesrow-class.md)) in which the pane is docked.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>* that points to the dock row in which the pane is docked, or <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> if the pane is not docked.  
  
##  \<a name="cpane__getexclusiverowmode">\</a>  CPane::GetExclusiveRowMode  
 Determines if the pane is in exclusive row mode.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> if the pane is in exclusive row mode; otherwise, <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information about exclusive row mode, see [CPane::SetExclusiveRowMode](#cpane__setexclusiverowmode).  
  
##  \<a name="cpane__gethotspot">\</a>  CPane::GetHotSpot  
 Returns the hot spot that is stored in an underlying <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
 The <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> class contains a <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>, that is responsible for drawing the rectangle that appears when the user moves a pane in the standard docking mode. The hot spot is used to draw the rectangle relative to the current mouse position as the user moves the pane.  
  
##  \<a name="cpane__getminsize">\</a>  CPane::GetMinSize  
 Retrieves the minimum allowed size for the pane.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> object that is filled with the minimum allowed size.  
  
### Remarks  
  
##  \<a name="cpane__getpanename">\</a>  CPane::GetPaneName  
 Retrieves the title for the pane.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> object that is filled with the caption name.  
  
### Remarks  
 The pane title is displayed in the caption area when the pane is docked or floating. If the pane is part of a tabbed group, the title is displayed in the tab area. If the pane is in auto-hide mode, the title is displayed on a <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__getvirtualrect">\</a>  CPane::GetVirtualRect  
 Retrieves the *virtual rectangle* of the pane.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> object that is filled with the virtual rectangle.  
  
### Remarks  
 When a pane is moved, the framework stores the original position of the pane in a virtual rectangle. The framework can use the virtual rectangle to restore the original position of the pane.  
  
 Do not call methods that are related to virtual rectangles unless you are moving panes programmatically.  
  
##  \<a name="cpane__ischangestate">\</a>  CPane::IsChangeState  
 As the pane is being moved, this method analyzes its position relative to other panes, dock rows, and mini-frame windows, and returns the appropriate <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> value.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 Specifies docking sensitivity. For example, a pane that is moved within <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> pixels from a dock row will be docked.  
  
 [in] <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 When the method returns, <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> contains either a pointer to the object to which the current pane should be docked, or <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> if no docking should occur.  
  
### Return Value  
 One of the following <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> values:  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>207\</CodeContentPlaceHolder>|The pane is not near a dock site. The framework does not dock the pane.|  
|<CodeContentPlaceHolder>208\</CodeContentPlaceHolder>|The pane is over a dock site, and the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> style is enabled. The framework docks the pane immediately.|  
|<CodeContentPlaceHolder>210\</CodeContentPlaceHolder>|The pane is over a dock site that is either another docking pane or an edge of the main frame. The framework docks the pane when the user releases the move.|  
|<CodeContentPlaceHolder>211\</CodeContentPlaceHolder>|The pane is over a dock site that causes the pane to be docked in a tabbed window. This occurs when the pane is either over the caption of another docking pane or over the tab area of a tabbed pane. The framework docks the pane when the user releases the move.|  
  
##  \<a name="cpane__isdragmode">\</a>  CPane::IsDragMode  
 Specifies whether the pane is being moved.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> if the pane is being moved; otherwise, <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cpane__isinfloatingmultipaneframewnd">\</a>  CPane::IsInFloatingMultiPaneFrameWnd  
 Specifies whether the pane is in a multi-pane frame window ( [CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)).  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> if the pane is in a multi-pane frame window; otherwise, <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>.  
  
### Remarks  
 Only dockable panes can float in a multi-pane frame window. Therefore, <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__isleftof">\</a>  CPane::IsLeftOf  
 Determines whether the pane is left of (or above) the specified rectangle.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> object that is used for comparison.  
  
 [in] <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> is assumed to contain screen coordinates; if <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> is assumed to contain client coordinates.  
  
### Return Value  
  
### Remarks  
 If the pane is docked horizontally, this method checks whether its location is left of <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>. Otherwise, this method checks whether the location is above <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__isresizable">\</a>  CPane::IsResizable  
 Specifies whether the pane is resizable.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> if the pane is resizable; otherwise, <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
### Remarks  
 Base <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> objects are not resizable.  
  
 The docking manager uses the resizable flag to determine pane layout. Non-resizable panes are always located at the outer edges of the parent frame.  
  
 Non-resizable panes cannot reside in docking containers.  
  
##  \<a name="cpane__istabbed">\</a>  CPane::IsTabbed  
 Determines whether the pane has been inserted into the tab control of a tabbed window.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> if the pane is tabbed; otherwise, <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
### Remarks  
 The tabbed state is treated separately from the floating, docked, and auto-hide states.  
  
##  \<a name="cpane__loadstate">\</a>  CPane::LoadState  
 Loads the state of the pane from the registry.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 Profile name.  
  
 [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 Profile index.  
  
 [in] <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
 Pane ID.  
  
### Return Value  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> if the pane state was loaded successfully; otherwise, <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to load the pane state from the registry. Override it in a derived class to load additional information that is saved by [CPane::SaveState](#cpane__savestate).  
  
 When you override this method, also call the base method, and return <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> if the base method returns <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__m_bhandleminsize">\</a>  CPane::m_bHandleMinSize  
 Enables consistent handling of minimum pane sizes.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Remarks  
 If one or more docking panes in your application override <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>, or if your application calls <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>, you may want to set this static member to <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> in order to enable the framework to consistently handle how panes are sized.  
  
 If this value is set to <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>, all panes whose size should be reduced below their minimum size are clipped, not stretched. Because the framework uses window regions for pane sizing purposes, do not change the size of the window region for docking panes if this value is set to <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__m_recentdockinfo">\</a>  CPane::m_recentDockInfo  
 Contains recent docking information.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
 The framework stores the latest docking state information for the pane in this member.  
  
##  \<a name="cpane__movebyalignment">\</a>  CPane::MoveByAlignment  
 Moves the pane and the virtual rectangle by the specified amount.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 Specifies pane alignment.  
  
 [in] <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 The amount, in pixels, by which to move the pane and the virtual rectangle.  
  
### Return Value  
  
### Remarks  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> can be any of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>247\</CodeContentPlaceHolder>|Enables the pane to be docked to the top of the client area of a frame window.|  
|<CodeContentPlaceHolder>248\</CodeContentPlaceHolder>|Enables the pane to be docked to the bottom of the client area of a frame window.|  
|<CodeContentPlaceHolder>249\</CodeContentPlaceHolder>|Enables the pane to be docked to the left side of the client area of a frame window.|  
|<CodeContentPlaceHolder>250\</CodeContentPlaceHolder>|Enables the pane to be docked to the right side of the client area of a frame window.|  
|<CodeContentPlaceHolder>251\</CodeContentPlaceHolder>|Enables the pane to be docked to any side of the client area of a frame window.|  
  
 If <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> contains the <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> flag, the pane and virtual rectangle are moved horizontally; otherwise, if <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> contains the <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> flag, the pane and virtual rectangle are moved vertically.  
  
##  \<a name="cpane__movepane">\</a>  CPane::MovePane  
 Moves the pane to the specified rectangle.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 Specifies the new rectangle for the pane.  
  
 [in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>, this method ignores the minimum allowed pane size ( [CPane::GetMinSize](#cpane__getminsize)); otherwise, the pane is adjusted, if necessary, to ensure that it is at least the minimum allowed size.  
  
 [in] <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 Not used.  
  
### Return Value  
 A <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> object that contains the differences in width and height between the new and old rectangles (old rectangle – <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>).  
  
### Remarks  
 This method is used only for dockable panes.  
  
##  \<a name="cpane__onafterchangeparent">\</a>  CPane::OnAfterChangeParent  
 Called by the framework when the parent of a pane has changed.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
 The pane's previous parent window.  
  
### Remarks  
 This method is called by the framework when the parent of a pane has changed because of a docking or floating operation.  
  
##  \<a name="cpane__onafterdock">\</a>  CPane::OnAfterDock  
 Called by the framework when a pane has been docked.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
##  \<a name="cpane__onafterfloat">\</a>  CPane::OnAfterFloat  
 Called by the framework after a pane floats.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 You can override this method in a derived class if you want to perform any processing after a pane floats.  
  
##  \<a name="cpane__onbeforechangeparent">\</a>  CPane::OnBeforeChangeParent  
 Called by the framework when the parent of the pane is about to change.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 Specifies the new parent window.  
  
 [in] <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> to delay the global docking layout adjustment; otherwise, <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is called by the framework when the parent of the pane is about to change because the pane is being docked or floated.  
  
 By default, the pane is unregistered with the docking pane by calling <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__onbeforedock">\</a>  CPane::OnBeforeDock  
 Called by the framework when the pane is about to dock.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 Specifies the pane that this pane is docking to.  
  
 [in] <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 Specifies the docking rectangle.  
  
 [in] <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
 Specifies the docking method.  
  
### Return Value  
 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> if the pane can be docked. If the function returns <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>, the docking operation will be aborted.  
  
### Remarks  
 This method is called by the framework when a pane is about to be docked. You can override this method in a derived class if you want to perform any processing before a pane is finally docked.  
  
##  \<a name="cpane__onbeforefloat">\</a>  CPane::OnBeforeFloat  
 Called by the framework when a pane is about to float.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 Specifies the position and size of the pane when it is in a floating state.  
  
 [in] <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 Specifies the docking method of the pane.  
  
### Return Value  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> if the pane can be floated; otherwise, <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is called by the framework when a pane is about to float. You can override this method in a derived class if you want to perform any processing before the pane finally floats.  
  
##  \<a name="cpane__onpressclosebutton">\</a>  CPane::OnPressCloseButton  
 Called by the framework when the user presses the close button on the caption for the pane.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 This method is called by the framework when a user presses the **Close** button on the pane's caption. To receive notifications about the **Close** event, you can override this method in a derived class.  
  
##  \<a name="cpane__onshowcontrolbarmenu">\</a>  CPane::OnShowControlBarMenu  
 Called by the framework when a special pane menu is about to be displayed.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 Specifies the menu location.  
  
### Return Value  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> if the menu can be displayed; otherwise, <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>.  
  
### Remarks  
 The menu contains several items that enable you to specify the pane's behavior, namely: **Floating**, **Docking**, **AutoHide**, and **Hide**. You can enable this menu for all panes by calling [CDockingManager::EnableDockSiteMenu](../vs140/cdockingmanager-class.md#cdockingmanager__enabledocksitemenu).  
  
##  \<a name="cpane__recalclayout">\</a>  CPane::RecalcLayout  
 Recalculates layout information for the pane.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
 If the pane is docked, this method updates the virtual rectangle for the pane by setting its size to the current size of the pane.  
  
 If the pane is floating, this method notifies the parent mini-frame to adjust the size of the pane to the size of the mini-frame. The framework ensures that the mini-frame is at least the minimum allowed size for the pane ( [CPane::GetMinSize](#cpane__getminsize)) and resizes the mini-frame if necessary.  
  
##  \<a name="cpane__savestate">\</a>  CPane::SaveState  
 Saves the state of the pane to the registry.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 Profile name.  
  
 [in] <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>  
 Profile index.  
  
 [in] <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 Pane ID.  
  
### Return Value  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> if the state was saved successfully; otherwise, <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when it saves the state of the pane to the registry. Override <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> in a derived class to store additional information.  
  
 When you override this method, also call the base method, and return <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> if the base method returns <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>.  
  
##  \<a name="cpane__setactiveingroup">\</a>  CPane::SetActiveInGroup  
 Flags a pane as active.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> that specifies whether the pane is flagged as active.  
  
### Remarks  
 When a dockable pane is shown or an auto-hide button is chosen, the corresponding auto-hide pane is marked as active.  
  
 The appearance of an auto-hide button that is associated with the pane is based on two factors. If the pane is active, and the <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>, the framework displays the auto-hide button as an icon and a label. For an inactive pane, the framework displays only the auto-hide icon.  
  
 If <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>, or if the pane is not located in a group, the framework displays the associated auto-hide button as an icon and a label.  
  
##  \<a name="cpane__setborders">\</a>  CPane::SetBorders  
 Sets the border values of the pane.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the left border of the pane.  
  
 [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the top border of the pane.  
  
 [in] <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the right border of the pane.  
  
 [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the bottom border of the pane.  
  
 [in] <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 A [CRect](../vs140/crect-class.md) object that contains the width, in pixels, of each border of the pane.  
  
### Remarks  
 Call this function to set the sizes of the pane's borders.  
  
##  \<a name="cpane__setclienthotspot">\</a>  CPane::SetClientHotSpot  
 Sets the *hot spot* for the pane.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> object that specifies the new hot spot.  
  
### Remarks  
 The *hot spot* is the point on the pane that the user selects and holds to move the pane. A hot spot is used for smooth animation when the pane is dragged from a docked position.  
  
##  \<a name="cpane__setdockstate">\</a>  CPane::SetDockState  
 Restores docking state information for the pane.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
 Pointer to the docking manager for the main frame window.  
  
### Remarks  
 This method is called by the framework to restore recent docking state information for the pane. A pane stores recent docking state information in [CPane::m_recentDockInfo](#cpane__m_recentdockinfo). For more information, see the [CRecentDockSiteInfo Class](../vs140/crecentdocksiteinfo-class.md).  
  
 You can also call this method to set the docking state when you load pane information from an external source.  
  
##  \<a name="cpane__setexclusiverowmode">\</a>  CPane::SetExclusiveRowMode  
 Enables or disables the exclusive row mode.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>308\</CodeContentPlaceHolder> to enable exclusive row mode; otherwise, <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to enable or disable exclusive row mode. When a pane is in exclusive row mode, it cannot share the same row with any other toolbars.  
  
 By default, all toolbars have exclusive row mode disabled and the menu bar has exclusive row mode enabled.  
  
##  \<a name="cpane__setminsize">\</a>  CPane::SetMinSize  
 Sets the minimum allowed size for the pane.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> object that contains the minimum allowed size for the pane.  
  
### Remarks  
  
##  \<a name="cpane__setvirtualrect">\</a>  CPane::SetVirtualRect  
 Sets the *virtual rectangle* of the pane.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> object that specifies the virtual rectangle to be set.  
  
 [in] <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
 Specify <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> contains points relative to the parent window.  
  
### Remarks  
 A *virtual rectangle* stores the original position of a pane when it is moved. The framework can use the virtual rectangle to restore the original position.  
  
 Do not call methods that are related to virtual rectangles unless you are moving panes programmatically.  
  
##  \<a name="cpane__setminiframertc">\</a>  CPane::SetMiniFrameRTC  
 Sets the runtime class information for the default mini-frame window.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>  
 Specifies the runtime class information for the mini-frame window.  
  
### Remarks  
 When a pane is floated, it is put on a [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) (mini-frame) window. You can provide a custom <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>-derived class that will be used when [CPane::CreateDefaultMiniframe](#cpane__createdefaultminiframe) is called.  
  
##  \<a name="cpane__stretchpanedeferwndpos">\</a>  CPane::StretchPaneDeferWndPos  
 Stretches the pane vertically or horizontally based on docking style.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 The amount, in pixels, to stretch the pane. Use a negative value to shrink the pane.  
  
 [in] <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 Not used.  
  
### Return Value  
 The actual amount, in pixels, that the pane was stretched.  
  
### Remarks  
 If necessary, this method modifies <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> to ensure that the pane does not exceed size limits. These limits are obtained by calling [CPane::GetAvailableStretchSize](#cpane__getavailablestretchsize) and [CPane::GetAvailableExpandSize](#cpane__getavailableexpandsize).  
  
##  \<a name="cpane__toggleautohide">\</a>  CPane::ToggleAutoHide  
 Toggles auto-hide mode.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Remarks  
 Call this method to toggle auto-hide mode. A pane must be docked to a main frame window in order to be switch to auto-hide mode.  
  
##  \<a name="cpane__undockpane">\</a>  CPane::UndockPane  
 Removes the pane from the dock site, default slider, or mini-frame window where it is currently docked.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>, the framework calls [CBasePane::AdjustDockingLayout](../vs140/cbasepane-class.md#cbasepane__adjustdockinglayout) to adjust the docking layout.  
  
### Remarks  
 Use this method to programmatically undock a pane.  
  
##  \<a name="cpane__updatevirtualrect">\</a>  CPane::UpdateVirtualRect  
 Updates the virtual rectangle.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> object that specifies an offset by which to shift the pane.  
  
 [in] <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> object that specifies a new size for the  pane.  
  
### Remarks  
 The first overload sets the virtual rectangle by using the current position and size of the pane.  
  
 The second overload shifts the virtual rectangle by the amount that is specified by <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>.  
  
 The third overload sets the virtual rectangle by using the current position of the pane and the size that is specified by <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CBasePane](../vs140/cbasepane-class.md)