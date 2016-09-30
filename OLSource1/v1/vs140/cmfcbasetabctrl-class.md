---
title: "CMFCBaseTabCtrl Class"
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
  - "CMFCBaseTabCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCBaseTabCtrl class"
ms.assetid: 7270c55f-6f6e-4dd2-b0d2-291afeac3882
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl Class
Implements the base functionality for tabbed windows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCBaseTabCtrl::AddIcon](#cmfcbasetabctrl__addicon)||  
|[CMFCBaseTabCtrl::AddTab](#cmfcbasetabctrl__addtab)|Adds a new tab to the tabbed window.|  
|[CMFCBaseTabCtrl::ApplyRestoredTabInfo](#cmfcbasetabctrl__applyrestoredtabinfo)||  
|[CMFCBaseTabCtrl::AutoDestroyWindow](#cmfcbasetabctrl__autodestroywindow)||  
|[CMFCBaseTabCtrl::CalcRectEdit](#cmfcbasetabctrl__calcrectedit)||  
|[CMFCBaseTabCtrl::CleanUp](#cmfcbasetabctrl__cleanup)||  
|[CMFCBaseTabCtrl::ClearImageList](#cmfcbasetabctrl__clearimagelist)||  
|[CMFCBaseTabCtrl::DetachTab](#cmfcbasetabctrl__detachtab)|Detaches a tab from a tabbed window.|  
|[CMFCBaseTabCtrl::EnableActivateLastActive](#cmfcbasetabctrl__enableactivatelastactive)||  
|[CMFCBaseTabCtrl::EnableAutoColor](#cmfcbasetabctrl__enableautocolor)|Enables or disables automatic tab coloring.|  
|[CMFCBaseTabCtrl::EnableCustomToolTips](#cmfcbasetabctrl__enablecustomtooltips)|Enables or disables custom tooltips for tabs.|  
|[CMFCBaseTabCtrl::EnableInPlaceEdit](#cmfcbasetabctrl__enableinplaceedit)|Enables or disables direct editing of tab labels.|  
|[CMFCBaseTabCtrl::EnableTabDetach](#cmfcbasetabctrl__enabletabdetach)|Enables detachable tabs.|  
|[CMFCBaseTabCtrl::EnableTabSwap](#cmfcbasetabctrl__enabletabswap)|Enables or disables whether the user can change the tab order by using a mouse.|  
|[CMFCBaseTabCtrl::EnsureVisible](#cmfcbasetabctrl__ensurevisible)|Scrolls the tabs until the specified tab is visible. This method has no effect if the specified tab is already visible.|  
|[CMFCBaseTabCtrl::EnterDragMode](#cmfcbasetabctrl__enterdragmode)||  
|[CMFCBaseTabCtrl::FindTargetWnd](#cmfcbasetabctrl__findtargetwnd)|Returns a pane that contains a specified point.|  
|[CMFCBaseTabCtrl::FireChangeActiveTab](#cmfcbasetabctrl__firechangeactivetab)||  
|[CMFCBaseTabCtrl::FireChangingActiveTab](#cmfcbasetabctrl__firechangingactivetab)||  
|[CMFCBaseTabCtrl::GetActiveTab](#cmfcbasetabctrl__getactivetab)|Returns the index of the active tab.|  
|[CMFCBaseTabCtrl::GetActiveTabColor](#cmfcbasetabctrl__getactivetabcolor)|Returns the background color of the active tab.|  
|[CMFCBaseTabCtrl::GetActiveTabTextColor](#cmfcbasetabctrl__getactivetabtextcolor)|Returns the text color of the active tab.|  
|[CMFCBaseTabCtrl::GetActiveWnd](#cmfcbasetabctrl__getactivewnd)|Returns a pointer the active page of the tab control.|  
|[CMFCBaseTabCtrl::GetAutoColors](#cmfcbasetabctrl__getautocolors)|Returns a reference to the array of colors that are used for automatic coloring.|  
|[CMFCBaseTabCtrl::GetFirstVisibleTab](#cmfcbasetabctrl__getfirstvisibletab)|Returns a pointer to the first visible tab.|  
|[CMFCBaseTabCtrl::GetFirstVisibleTabNum](#cmfcbasetabctrl__getfirstvisibletabnum)||  
|[CMFCBaseTabCtrl::GetHighlightedTab](#cmfcbasetabctrl__gethighlightedtab)|Returns the index of the currently highlighted tab.|  
|[CMFCBaseTabCtrl::GetImageList](#cmfcbasetabctrl__getimagelist)||  
|[CMFCBaseTabCtrl::GetImageSize](#cmfcbasetabctrl__getimagesize)||  
|[CMFCBaseTabCtrl::GetLastVisibleTab](#cmfcbasetabctrl__getlastvisibletab)||  
|[CMFCBaseTabCtrl::GetLocation](#cmfcbasetabctrl__getlocation)|Returns a variable of the LOCATION data type that indicates where the tab area is positioned relative to the tab control. For example, on the top or on the bottom.|  
|[CMFCBaseTabCtrl::GetMaxWindowSize](#cmfcbasetabctrl__getmaxwindowsize)||  
|[CMFCBaseTabCtrl::GetTabArea](#cmfcbasetabctrl__gettabarea)|Returns the size and the position of the tab area in the tabbed window. The position of the tab area is defined by using coordinates.|  
|[CMFCBaseTabCtrl::GetTabBkColor](#cmfcbasetabctrl__gettabbkcolor)|Returns the background color of the specified tab.|  
|[CMFCBaseTabCtrl::GetTabBorderSize](#cmfcbasetabctrl__gettabbordersize)|Returns the size of the tab borders in the tab control.|  
|[CMFCBaseTabCtrl::GetTabByID](#cmfcbasetabctrl__gettabbyid)|Returns the index of the tab that is identified by a specified ID.|  
|[CMFCBaseTabCtrl::GetTabCloseButton](#cmfcbasetabctrl__gettabclosebutton)||  
|[CMFCBaseTabCtrl::GetTabFromHwnd](#cmfcbasetabctrl__gettabfromhwnd)|Returns the index of a tab that contains a specified HWND object.|  
|[CMFCBaseTabCtrl::GetTabFromPoint](#cmfcbasetabctrl__gettabfrompoint)|Returns the tab that contains a specified point.|  
|[CMFCBaseTabCtrl::GetTabFullWidth](#cmfcbasetabctrl__gettabfullwidth)||  
|[CMFCBaseTabCtrl::GetTabHicon](#cmfcbasetabctrl__gettabhicon)|Returns the icon associated with the specified tab.|  
|[CMFCBaseTabCtrl::GetTabID](#cmfcbasetabctrl__gettabid)|Returns the ID of a tab by using the index of the tab.|  
|[CMFCBaseTabCtrl::GetTabIcon](#cmfcbasetabctrl__gettabicon)|Returns the icon ID for a specified tab.|  
|[CMFCBaseTabCtrl::GetTabLabel](#cmfcbasetabctrl__gettablabel)|Returns the text of a specified tab.|  
|[CMFCBaseTabCtrl::GetTabRect](#cmfcbasetabctrl__gettabrect)|Retrieves the size and position of a specified tab.|  
|[CMFCBaseTabCtrl::GetTabsHeight](#cmfcbasetabctrl__gettabsheight)||  
|[CMFCBaseTabCtrl::GetTabsRect](#cmfcbasetabctrl__gettabsrect)||  
|[CMFCBaseTabCtrl::GetTabTextColor](#cmfcbasetabctrl__gettabtextcolor)|Returns the text color of a specified tab.|  
|[CMFCBaseTabCtrl::GetTabWnd](#cmfcbasetabctrl__gettabwnd)|Returns the pointer to a pane that resides on a specified tab page.|  
|[CMFCBaseTabCtrl::GetTabWndNoWrapper](#cmfcbasetabctrl__gettabwndnowrapper)|Returns the direct pointer to a control that resides on a specified tab page, even if the control has a wrapper.|  
|[CMFCBaseTabCtrl::GetTabsNum](#cmfcbasetabctrl__gettabsnum)|Returns the number of tabs that are contained in the tab control.|  
|[CMFCBaseTabCtrl::GetToolTipCtrl](#cmfcbasetabctrl__gettooltipctrl)|Returns a reference to the tooltip control associated with the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.|  
|[CMFCBaseTabCtrl::GetVisibleTabsNum](#cmfcbasetabctrl__getvisibletabsnum)|Returns the number of visible tabs.|  
|[CMFCBaseTabCtrl::HasImage](#cmfcbasetabctrl__hasimage)||  
|[CMFCBaseTabCtrl::HideSingleTab](#cmfcbasetabctrl__hidesingletab)|Sets an option that hides a window tab, but only if the tabbed window displays a just one visible tab.|  
|[CMFCBaseTabCtrl::InsertTab](#cmfcbasetabctrl__inserttab)|Inserts a new tab.|  
|[CMFCBaseTabCtrl::InvalidateTab](#cmfcbasetabctrl__invalidatetab)||  
|[CMFCBaseTabCtrl::IsActiveTabCloseButton](#cmfcbasetabctrl__isactivetabclosebutton)||  
|[CMFCBaseTabCtrl::IsAutoColor](#cmfcbasetabctrl__isautocolor)|Returns a value that indicates whether a tabbed window is in automatic-color mode.|  
|[CMFCBaseTabCtrl::IsAutoDestroyWindow](#cmfcbasetabctrl__isautodestroywindow)||  
|[CMFCBaseTabCtrl::IsColored](#cmfcbasetabctrl__iscolored)||  
|[CMFCBaseTabCtrl::IsDialogControl](#cmfcbasetabctrl__isdialogcontrol)||  
|[CMFCBaseTabCtrl::IsDrawNoPrefix](#cmfcbasetabctrl__isdrawnoprefix)||  
|[CMFCBaseTabCtrl::IsFlatFrame](#cmfcbasetabctrl__isflatframe)|Returns a value that indicates whether the frame for the tab area is flat or 3D.|  
|[CMFCBaseTabCtrl::IsFlatTab](#cmfcbasetabctrl__isflattab)||  
|[CMFCBaseTabCtrl::IsHideSingleTab](#cmfcbasetabctrl__ishidesingletab)|Returns a value that indicates whether the tab control is configured to hide a tab, but only if a tabbed window has just one visible tab.|  
|[CMFCBaseTabCtrl::IsIconAdded](#cmfcbasetabctrl__isiconadded)||  
|[CMFCBaseTabCtrl::IsInPlaceEdit](#cmfcbasetabctrl__isinplaceedit)|Indicates whether users can modify the label on a tab.|  
|[CMFCBaseTabCtrl::IsLeftRightRounded](#cmfcbasetabctrl__isleftrightrounded)||  
|[CMFCBaseTabCtrl::IsMDITab](#cmfcbasetabctrl__ismditab)||  
|[CMFCBaseTabCtrl::IsOneNoteStyle](#cmfcbasetabctrl__isonenotestyle)|Indicates whether a tabbed window displays tabs in Microsoft OneNote style.|  
|[CMFCBaseTabCtrl::IsPtInTabArea](#cmfcbasetabctrl__isptintabarea)|Checks whether a specified point exists in the tab area.|  
|[CMFCBaseTabCtrl::IsTabCloseButtonHighlighted](#cmfcbasetabctrl__istabclosebuttonhighlighted)||  
|[CMFCBaseTabCtrl::IsTabCloseButtonPressed](#cmfcbasetabctrl__istabclosebuttonpressed)||  
|[CMFCBaseTabCtrl::IsTabDetachable](#cmfcbasetabctrl__istabdetachable)|Indicates whether a tab is detachable.|  
|[CMFCBaseTabCtrl::IsTabIconOnly](#cmfcbasetabctrl__istabicononly)|Indicates whether tabs display icons but not labels.|  
|[CMFCBaseTabCtrl::IsTabSwapEnabled](#cmfcbasetabctrl__istabswapenabled)|Indicates whether the user can change tab positions by dragging tabs.|  
|[CMFCBaseTabCtrl::IsTabVisible](#cmfcbasetabctrl__istabvisible)|Indicates whether a specified tab is visible.|  
|[CMFCBaseTabCtrl::IsVS2005Style](#cmfcbasetabctrl__isvs2005style)||  
|[CMFCBaseTabCtrl::MoveTab](#cmfcbasetabctrl__movetab)||  
|[CMFCBaseTabCtrl::OnChangeTabs](#cmfcbasetabctrl__onchangetabs)|Called by the framework when the number of tabs changes.|  
|[CMFCBaseTabCtrl::OnDragEnter](#cmfcbasetabctrl__ondragenter)||  
|[CMFCBaseTabCtrl::OnDragLeave](#cmfcbasetabctrl__ondragleave)||  
|[CMFCBaseTabCtrl::OnDragOver](#cmfcbasetabctrl__ondragover)||  
|[CMFCBaseTabCtrl::OnDrop](#cmfcbasetabctrl__ondrop)||  
|[CMFCBaseTabCtrl::OnRenameTab](#cmfcbasetabctrl__onrenametab)||  
|[CMFCBaseTabCtrl::PreTranslateMessage](#cmfcbasetabctrl__pretranslatemessage)|Used by class [CWinApp](../vs140/cwinapp-class.md) to translate window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. (Overrides [CWnd::PreTranslateMessage](../vs140/cwnd-class.md#cwnd__pretranslatemessage).)|  
|[CMFCBaseTabCtrl::RecalcLayout](#cmfcbasetabctrl__recalclayout)|Recalculates the internal layout of a tabbed window.|  
|[CMFCBaseTabCtrl::RemoveAllTabs](#cmfcbasetabctrl__removealltabs)|Removes all tabs from the tabbed window.|  
|[CMFCBaseTabCtrl::RemoveTab](#cmfcbasetabctrl__removetab)|Removes a tab from a tabbed window.|  
|[CMFCBaseTabCtrl::RenameTab](#cmfcbasetabctrl__renametab)||  
|[CMFCBaseTabCtrl::ResetImageList](#cmfcbasetabctrl__resetimagelist)|Resets the image list that is attached to a tabbed window.|  
|[CMFCBaseTabCtrl::Serialize](#cmfcbasetabctrl__serialize)|Reads or writes this object from or to an archive. (Overrides [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize).)|  
|[CMFCBaseTabCtrl::SetActiveTab](#cmfcbasetabctrl__setactivetab)|Activates a tab.|  
|[CMFCBaseTabCtrl::SetActiveTabColor](#cmfcbasetabctrl__setactivetabcolor)|Sets the background color for the currently active tab.|  
|[CMFCBaseTabCtrl::SetActiveTabTextColor](#cmfcbasetabctrl__setactivetabtextcolor)|Sets the text color for active tabs.|  
|[CMFCBaseTabCtrl::SetAutoColors](#cmfcbasetabctrl__setautocolors)|Sets the tab control colors that are applied in automatic color mode.|  
|[CMFCBaseTabCtrl::SetDockingBarWrapperRTC](#cmfcbasetabctrl__setdockingbarwrapperrtc)|Sets the wrapper class that is used for any objects that are not derived from the [CDockablePane Class](../vs140/cdockablepane-class.md).|  
|[CMFCBaseTabCtrl::SetDrawNoPrefix](#cmfcbasetabctrl__setdrawnoprefix)|Enables and disables the processing of prefix characters when tab labels are drawn.|  
|[CMFCBaseTabCtrl::SetImageList](#cmfcbasetabctrl__setimagelist)|Sets the icon image list.|  
|[CMFCBaseTabCtrl::SetLocation](#cmfcbasetabctrl__setlocation)||  
|[CMFCBaseTabCtrl::SetTabBkColor](#cmfcbasetabctrl__settabbkcolor)|Sets the background color for a specified tab.|  
|[CMFCBaseTabCtrl::SetTabBorderSize](#cmfcbasetabctrl__settabbordersize)|Sets a new tab border size.|  
|[CMFCBaseTabCtrl::SetTabHicon](#cmfcbasetabctrl__settabhicon)|Sets a tab icon.|  
|[CMFCBaseTabCtrl::SetTabIcon](#cmfcbasetabctrl__settabicon)|Sets a tab icon ID.|  
|[CMFCBaseTabCtrl::SetTabIconOnly](#cmfcbasetabctrl__settabicononly)|Enables and disables the "icon only" mode for a specified tab.|  
|[CMFCBaseTabCtrl::SetTabLabel](#cmfcbasetabctrl__settablabel)|Sets a tab label equal to a specified string value.|  
|[CMFCBaseTabCtrl::SetTabsHeight](#cmfcbasetabctrl__settabsheight)||  
|[CMFCBaseTabCtrl::SetTabTextColor](#cmfcbasetabctrl__settabtextcolor)|Sets the text color for a specified tab.|  
|[CMFCBaseTabCtrl::SetTabsOrder](#cmfcbasetabctrl__settabsorder)|Arranges tabs in the specified order.|  
|[CMFCBaseTabCtrl::ShowTab](#cmfcbasetabctrl__showtab)|Shows or hides the specified tab.|  
|[CMFCBaseTabCtrl::StartRenameTab](#cmfcbasetabctrl__startrenametab)||  
|[CMFCBaseTabCtrl::SwapTabs](#cmfcbasetabctrl__swaptabs)||  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCBaseTabCtrl::CreateWrapper](#cmfcbasetabctrl__createwrapper)|Creates a wrapper for an object derived from [CWnd](../vs140/cwnd-class.md) that is not derived from <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>. To dock a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object, every embedded control must either have a docking wrapper or be derived from <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.\<br />\<br /> You set the class of the wrapper by using <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCBaseTabCtrl::m_bActivateTabOnRightClick](#cmfcbasetabctrl__m_bactivatetabonrightclick)|Specifies whether tabs are selected by using a left mouse click or a right mouse click.|  
|[CMFCBaseTabCtrl::m_bAutoDestroyWindow](#cmfcbasetabctrl__m_bautodestroywindow)|Specifies whether the panes that are contained in the tabs are destroyed automatically.|  
  
## Remarks  
 The <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> class is an abstract class. Therefore, it cannot be instantiated. To create a tabbed window, you must derive a class from <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>. The MFC library contains some derived class examples, two of which are [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md) and [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md).  
  
 Starting with [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)], this class supports Microsoft Active Accessibility.  
  
## Customization Tips  
 The following tips pertain to the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md) and any classes that inherit from it:  
  
-   If you enable detachable tabs, do not keep pointers to the tabbed windows. These detachable tabs can be created and destroyed dynamically. Therefore, pointers can become invalid.  
  
-   You can configure the tab control so that users can move tabs dynamically on a tab control by using the mouse. This functionality is built into the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> class. To enable it, call [CMFCBaseTabCtrl::EnableTabSwap](#cmfcbasetabctrl__enabletabswap).  
  
-   By default, tabs are detachable when you add them to a tab control. You can also add non-detachable tabs by using [CMFCBaseTabCtrl::AddTab](#cmfcbasetabctrl__addtab). If you set the parameter <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, the tab will not be detachable. You can also change whether tabs are detachable by calling the method [CMFCBaseTabCtrl::EnableTabDetach](#cmfcbasetabctrl__enabletabdetach).  
  
-   Objects that are derived from the [CWnd Class](../vs140/cwnd-class.md) can be put on a dockable control bar or dockable tab. For the whole control to be docked, you must make the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object dockable. To accomplish this, MFC uses a wrapper class. This wrapper class is the [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md). Any <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> objects that are added to a dockable control bar or dockable tab will be wrapped inside a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object. You can disable the automatic wrapping by setting the parameter <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> of your <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object to <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>. You can also change the class that your application will use as a wrapper by using the method [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](#cmfcbasetabctrl__setdockingbarwrapperrtc).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md)  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
##  \<a name="cmfcbasetabctrl__addicon">\</a>  CMFCBaseTabCtrl::AddIcon  
 Adds an icon to the list of icons in the protected <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> member.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 A handle to the icon to be added.  
  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Zero-based index of the icon in the protected <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> member.  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__addtab">\</a>  CMFCBaseTabCtrl::AddTab  
 Adds a new tab to the tab control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 A pointer to the window that this method represents as a new tab.  
  
 [in] <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 A string that contains the label for the new tab.  
  
 [in] <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 An image ID from the image list. The tab control uses this image as the icon for the new tab.  
  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The resource ID for the label.  
  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 A Boolean parameter that determines whether the new tab is detachable.  
  
### Remarks  
 If <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> points to an object that is not derived from the [CDockablePane Class](../vs140/cdockablepane-class.md) and if <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, the framework automatically creates a wrapper for the <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> object. The wrapper makes the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> object detachable. By default, the wrapper is an instance of the [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md). If the functionality offered by the default wrapper is unacceptable, use the [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](#cmfcbasetabctrl__setdockingbarwrapperrtc) method to specify a different wrapper.  
  
##  \<a name="cmfcbasetabctrl__applyrestoredtabinfo">\</a>  CMFCBaseTabCtrl::ApplyRestoredTabInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__autodestroywindow">\</a>  CMFCBaseTabCtrl::AutoDestroyWindow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__calcrectedit">\</a>  CMFCBaseTabCtrl::CalcRectEdit  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__cleanup">\</a>  CMFCBaseTabCtrl::CleanUp  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__clearimagelist">\</a>  CMFCBaseTabCtrl::ClearImageList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__createwrapper">\</a>  CMFCBaseTabCtrl::CreateWrapper  
 Creates a wrapper for a frame window that is derived from the [CWnd Class](../vs140/cwnd-class.md) but is not derived from the [CDockablePane Class](../vs140/cdockablepane-class.md).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 A pointer to the frame window that is wrapped.  
  
 [in] <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 A string that contains the label for the window.  
  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the window is detachable.  
  
### Return Value  
 A pointer to wrapper derived from the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> class if <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> successfully creates a wrapper class for <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>. If the method fails, it retruns <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
### Remarks  
 A tabbed window can dock any object derived from <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>. However, in order for a [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md) object to be dockable, each object on the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> must be detachable. Therefore, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> automatically wraps any objects that are not derived from <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
 By default, the <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> creates instances of the [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md). To change the wrapper's default class, call [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](#cmfcbasetabctrl__setdockingbarwrapperrtc).  
  
 If <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>, this method will not create a wrapper. Instead, it will fail and return <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__detachtab">\</a>  CMFCBaseTabCtrl::DetachTab  
 The framework calls this method to detach a tab from the tab control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 An enumerated data type provided by the [CBasePane Class](../vs140/cbasepane-class.md). This data type specifies the method that was used to detach the tab.  
  
 [in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 The zero-based index of the tab to be detached.  
  
 [in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the framework should hide the detached tab.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 If the tab specified by <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> is non-detachable, this function fails and returns <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__enableactivatelastactive">\</a>  CMFCBaseTabCtrl::EnableActivateLastActive  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__enableautocolor">\</a>  CMFCBaseTabCtrl::EnableAutoColor  
 Controls whether the framework uses the automatic background colors when drawing a tab.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 A Boolean parameter that determines whether the framework uses automatic colors.  
  
### Remarks  
 A tab control has an array of several predefined colors. When the framework uses automatic colors, each tab in a series of tabs is assigned the next color from this array.  
  
 By default, the automatic colors are determined by the library-defined colors. You can provide a custom array of colors by calling [CMFCBaseTabCtrl::SetAutoColors](#cmfcbasetabctrl__setautocolors).  
  
##  \<a name="cmfcbasetabctrl__enablecustomtooltips">\</a>  CMFCBaseTabCtrl::EnableCustomToolTips  
 Enables custom tooltips for the tab control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 A Boolean that determines whether to use custom tooltips.  
  
### Return Value  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>.  
  
### Remarks  
 If custom tooltips are enabled, the tab control sends the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> message to the main frame. If you want to support custom tooltips in your application, the main frame window must handle this method and provide the custom tooltip text. For more information about providing custom tooltip text, see [CMFCTabToolTipInfo Class](../vs140/cmfctabtooltipinfo-structure.md).  
  
##  \<a name="cmfcbasetabctrl__enableinplaceedit">\</a>  CMFCBaseTabCtrl::EnableInPlaceEdit  
 Enables direct editing of the tab labels by the user.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether to enable direct editing of the tab labels.  
  
### Remarks  
 By default, direct editing of the tab labels is disabled for tab controls.  
  
 You can enable direct editing for a subset of the tabs on the tab control. To do this, override the method <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> should return a nonzero value for all tabs that support direct editing of tab labels.  
  
 In the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), this method is a pure virtual function and has no implementation. If you derive a class from <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>, you must implement this function.  
  
##  \<a name="cmfcbasetabctrl__enabletabdetach">\</a>  CMFCBaseTabCtrl::EnableTabDetach  
 Enables detachable tabs.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The zero-based index of a tab.  
  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 A Boolean that indicates whether to make the tab detachable.  
  
### Return Value  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__enabletabswap">\</a>  CMFCBaseTabCtrl::EnableTabSwap  
 Enables the user to change the tab order using a mouse.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 A Boolean that indicates whether to enable tab swapping.  
  
### Remarks  
 When tab swapping is enabled, the user can drag a tab and change its relative position in the tab control.  
  
##  \<a name="cmfcbasetabctrl__ensurevisible">\</a>  CMFCBaseTabCtrl::EnsureVisible  
 Scrolls the tabs until the specified tab is visible.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 The zero-based index of a tab.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This method has no effect if the tab indicated by <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> is already visible.  
  
 By default, this method is not supported by the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md). You should implement this function in a custom class derived from <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> if that custom tab control supports tab scrolling. This method is supported by the [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md).  
  
##  \<a name="cmfcbasetabctrl__enterdragmode">\</a>  CMFCBaseTabCtrl::EnterDragMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__findtargetwnd">\</a>  CMFCBaseTabCtrl::FindTargetWnd  
 Identifies the pane that contains a specified point.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 A point that is defined by using client-area coordinates of the [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object.  
  
### Return Value  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object if successful; otherwise <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
### Remarks  
 In the <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> class, this method is a pure virtual function: you must implement it if you derive a class from <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__firechangeactivetab">\</a>  CMFCBaseTabCtrl::FireChangeActiveTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__firechangingactivetab">\</a>  CMFCBaseTabCtrl::FireChangingActiveTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__getactivetab">\</a>  CMFCBaseTabCtrl::GetActiveTab  
 Retrieves the index of the currently active tab.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of the active tab; -1 if there is no active tab.  
  
##  \<a name="cmfcbasetabctrl__getactivetabcolor">\</a>  CMFCBaseTabCtrl::GetActiveTabColor  
 Retrieves the background color of the currently active tab.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that specifies the background color of the active tab.  
  
### Remarks  
 By default, the background color of the active tab is <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>. You can change the background color for the active tab by using the method [CMFCBaseTabCtrl::SetActiveTabColor](#cmfcbasetabctrl__setactivetabcolor).  
  
##  \<a name="cmfcbasetabctrl__getactivetabtextcolor">\</a>  CMFCBaseTabCtrl::GetActiveTabTextColor  
 Retrieves the text color for the active tab.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that specifies the text color of the active tab.  
  
### Remarks  
 By default, the text color for active tabs is <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>. You can change the text color with the method [CMFCBaseTabCtrl::SetActiveTabTextColor](#cmfcbasetabctrl__setactivetabtextcolor).  
  
##  \<a name="cmfcbasetabctrl__getactivewnd">\</a>  CMFCBaseTabCtrl::GetActiveWnd  
 Retrieves a pointer to the currently active tab window.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a window.  
  
##  \<a name="cmfcbasetabctrl__getautocolors">\</a>  CMFCBaseTabCtrl::GetAutoColors  
 Retrieves the array of colors used for automatic coloring.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 A reference to an array of                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) values that the [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object uses for automatic tab coloring.  
  
### Remarks  
 By default, the framework initializes the array of colors to library-defined colors. You can provide a custom array of colors by calling the method [CMFCBaseTabCtrl::SetAutoColors](#cmfcbasetabctrl__setautocolors).  
  
##  \<a name="cmfcbasetabctrl__getfirstvisibletab">\</a>  CMFCBaseTabCtrl::GetFirstVisibleTab  
 Retrieves a pointer to the first visible tab.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 A reference to an integer. This method writes the zero-based index of the first visible tab to this parameter.  
  
 [in] <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The zero-based index of the first tab to check.  
  
### Return Value  
 A pointer to the first visible tab if successful; otherwise <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>.  
  
### Remarks  
 If this method fails, it writes the value -1 to <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> is larger than or equal to the number of tabs in the tab control, <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> automatically fails.  
  
##  \<a name="cmfcbasetabctrl__getfirstvisibletabnum">\</a>  CMFCBaseTabCtrl::GetFirstVisibleTabNum  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__gethighlightedtab">\</a>  CMFCBaseTabCtrl::GetHighlightedTab  
 Retrieves the index of the currently highlighted tab.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of the highlighted tab.  
  
##  \<a name="cmfcbasetabctrl__getimagelist">\</a>  CMFCBaseTabCtrl::GetImageList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__getimagesize">\</a>  CMFCBaseTabCtrl::GetImageSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__getlastvisibletab">\</a>  CMFCBaseTabCtrl::GetLastVisibleTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__getlocation">\</a>  CMFCBaseTabCtrl::GetLocation  
 Retrieves the location of the tab area portion of the tab control.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 The location of the tab area.  
  
### Remarks  
 Possible tab area location values are <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__getmaxwindowsize">\</a>  CMFCBaseTabCtrl::GetMaxWindowSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__gettabarea">\</a>  CMFCBaseTabCtrl::GetTabArea  
 Retrieves the size and position of the tab area of the tab control.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> uses this object to store the size and position of the top tab area.  
  
 [in] <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> uses this object to store the size and position of the bottom tab area.  
  
### Remarks  
 After <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> returns, the <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> parameters contain the size and position of the tab area in client coordinates of the tab control. If there is no tab area at the top or bottom of the tab control, <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> are empty.  
  
 In the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), this method is a pure virtual function and has no implementation. If you derive a class from <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>, you have to implement this function.  
  
##  \<a name="cmfcbasetabctrl__gettabbkcolor">\</a>  CMFCBaseTabCtrl::GetTabBkColor  
 Retrieves the background color of the specified tab.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that indicates the background color of the specified tab; -1 if <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> is out of range.  
  
##  \<a name="cmfcbasetabctrl__gettabbordersize">\</a>  CMFCBaseTabCtrl::GetTabBorderSize  
 Retrieves the size of the tab borders in the tab control.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 The size of the tab border, in pixels.  
  
### Remarks  
 The default size for the tab border is three pixels. You can change this border size with the method [CMFCBaseTabCtrl::SetTabBorderSize](#cmfcbasetabctrl__settabbordersize).  
  
##  \<a name="cmfcbasetabctrl__gettabbyid">\</a>  CMFCBaseTabCtrl::GetTabByID  
 Retrieves the index of a tab based on a tab ID.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 A tab ID.  
  
### Return Value  
 The zero-based index of a tab if it is found; -1 if the tab ID is not found.  
  
### Remarks  
 The tab IDs are assigned automatically when tabs are added to a tab control.  
  
##  \<a name="cmfcbasetabctrl__gettabclosebutton">\</a>  CMFCBaseTabCtrl::GetTabCloseButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__gettabfromhwnd">\</a>  CMFCBaseTabCtrl::GetTabFromHwnd  
 Retrieves the index of the tab that contains the specified HWND object.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 A handle to a window.  
  
### Return Value  
 The zero-based index of the tab if successful; -1 if no tab contains <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__gettabfrompoint">\</a>  CMFCBaseTabCtrl::GetTabFromPoint  
 Retrieves the tab that contains a specified point.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 A point in client coordinates of the tab control.  
  
### Return Value  
 The index of the tab that contains <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>; -1 if no tab contains <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__gettabfullwidth">\</a>  CMFCBaseTabCtrl::GetTabFullWidth  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__gettabhicon">\</a>  CMFCBaseTabCtrl::GetTabHicon  
 Returns the HICON associated with the specified tab.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 The zero-based index for the tab.  
  
### Return Value  
 The HICON associated with a tab label if successful; <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> if there is no HICON or if the method fails.  
  
##  \<a name="cmfcbasetabctrl__gettabicon">\</a>  CMFCBaseTabCtrl::GetTabIcon  
 Retrieves the icon associated with the specified tab.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
### Return Value  
 The icon ID for the specified tab if successful; -1 if the index is invalid.  
  
### Remarks  
 The [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object stores the icons in the internal [CImageList](../vs140/cimagelist-class.md) object.  
  
##  \<a name="cmfcbasetabctrl__gettabid">\</a>  CMFCBaseTabCtrl::GetTabID  
 Retrieves the ID for a tab specified by the tab index.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
### Return Value  
 An ID of the tab or -1 if <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> is out of range.  
  
##  \<a name="cmfcbasetabctrl__gettablabel">\</a>  CMFCBaseTabCtrl::GetTabLabel  
 Retrieves the text of a tab label.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
 [out] <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> object. This method stores the label of the tab in this parameter.  
  
### Return Value  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 This method fails if the index <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> is invalid.  
  
 You set the label for a tab when you create the tab by using [CMFCBaseTabCtrl::AddTab](#cmfcbasetabctrl__addtab). You can also change the label after creation with the method [CMFCBaseTabCtrl::SetTabLabel](#cmfcbasetabctrl__settablabel).  
  
##  \<a name="cmfcbasetabctrl__gettabrect">\</a>  CMFCBaseTabCtrl::GetTabRect  
 Retrieves the size and position of the specified tab.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
 [out] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> object. This method stores the size and position of the tab in this parameter.  
  
### Return Value  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> if the tab index is invalid.  
  
##  \<a name="cmfcbasetabctrl__gettabsheight">\</a>  CMFCBaseTabCtrl::GetTabsHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__gettabsnum">\</a>  CMFCBaseTabCtrl::GetTabsNum  
 Retrieves the number of tabs in the tab control.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 The number of tabs in the tab control.  
  
##  \<a name="cmfcbasetabctrl__gettabsrect">\</a>  CMFCBaseTabCtrl::GetTabsRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__gettabtextcolor">\</a>  CMFCBaseTabCtrl::GetTabTextColor  
 Retrieves the text color for the specified tab.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the text color of the specified tab; -1 if <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> is out of range.  
  
##  \<a name="cmfcbasetabctrl__gettabwnd">\</a>  CMFCBaseTabCtrl::GetTabWnd  
 Returns the pointer to the pane that resides on the specified tab.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 The zero-based index of a tab.  
  
### Return Value  
 A pointer to the [CWnd](../vs140/cwnd-class.md) object that resides on the tab that <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> specifies. <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> is invalid.  
  
### Remarks  
 The returned object is the one that the application added when it called either [CMFCBaseTabCtrl::AddTab](#cmfcbasetabctrl__addtab) or [CMFCBaseTabCtrl::InsertTab](#cmfcbasetabctrl__inserttab).  
  
 If the object on a tab has a wrapper, this method will return the wrapper for the object. For more information about wrappers, see [CMFCBaseTabCtrl::CreateWrapper](#cmfcbasetabctrl__createwrapper). If you want to access a pointer to the direct object without the wrapper, use the method [CMFCBaseTabCtrl::GetTabWndNoWrapper](#cmfcbasetabctrl__gettabwndnowrapper).  
  
##  \<a name="cmfcbasetabctrl__gettabwndnowrapper">\</a>  CMFCBaseTabCtrl::GetTabWndNoWrapper  
 Returns a pointer to the control that resides on a tab, even if the control has a wrapper.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 The zero-based index of a tab.  
  
### Return Value  
 A pointer to the [CWnd](../vs140/cwnd-class.md) object that resides on the specified tab; <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> is invalid.  
  
### Remarks  
 This method retrieves a direct pointer to the <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> object that you added by using either the method [CMFCBaseTabCtrl::AddTab](#cmfcbasetabctrl__addtab) or [CMFCBaseTabCtrl::InsertTab](#cmfcbasetabctrl__inserttab). <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> will retrieve a pointer to the added <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>, even if the framework added a wrapper for the object. For more information about wrappers and the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), see [CMFCBaseTabCtrl::CreateWrapper](#cmfcbasetabctrl__createwrapper).  
  
 Use the method [CMFCBaseTabCtrl::GetTabWnd](#cmfcbasetabctrl__gettabwnd) if you do not want to ignore the wrapper class.  
  
##  \<a name="cmfcbasetabctrl__gettooltipctrl">\</a>  CMFCBaseTabCtrl::GetToolTipCtrl  
 Retrieves a reference to the tooltip contorl.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the tooltip control.  
  
##  \<a name="cmfcbasetabctrl__getvisibletabsnum">\</a>  CMFCBaseTabCtrl::GetVisibleTabsNum  
 Retrieves the number of currently visible tabs.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 The number of visible tabs.  
  
##  \<a name="cmfcbasetabctrl__hasimage">\</a>  CMFCBaseTabCtrl::HasImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__hidesingletab">\</a>  CMFCBaseTabCtrl::HideSingleTab  
 Sets the option to hide the tabs for the tab control when there is one visible tab.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 A Boolean that specifies whether to enable hiding single tabs.  
  
### Remarks  
 When your application is configured to hide single tabs, the framework automatically displays tabs when a second tab is added to the tab control.  
  
##  \<a name="cmfcbasetabctrl__inserttab">\</a>  CMFCBaseTabCtrl::InsertTab  
 Inserts a tab into the tab control.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 A pointer to the window that this method adds as a new tab.  
  
 [in] <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 A string that contains the label for the new tab.  
  
 [in] <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 The zero-based index of the new tab.  
  
 [in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 An image ID from the image list. The tab control uses this image as the icon for the new tab.  
  
 [in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 A Boolean parameter that determines whether the new tab is detachable.  
  
 [in] <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 The resource ID for the label.  
  
### Remarks  
 If the object indicated by <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> is not derived from the [CDockablePane Class](../vs140/cdockablepane-class.md) and if the <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>, the framework creates a special wrapper for the new tab. By default, the wrapper is an instance of the [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md). Use the [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](#cmfcbasetabctrl__setdockingbarwrapperrtc) method to create a different wrapper class. Any custom wrapper class needs to be derived from <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__invalidatetab">\</a>  CMFCBaseTabCtrl::InvalidateTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__isactivetabclosebutton">\</a>  CMFCBaseTabCtrl::IsActiveTabCloseButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__isautocolor">\</a>  CMFCBaseTabCtrl::IsAutoColor  
 Determines whether the tab control is in autocolor mode.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> if the tab control is in autocolor mode; <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 You can enable or disable the autocolor mode by using the [CMFCBaseTabCtrl::EnableAutoColor](#cmfcbasetabctrl__enableautocolor) method.  
  
##  \<a name="cmfcbasetabctrl__isautodestroywindow">\</a>  CMFCBaseTabCtrl::IsAutoDestroyWindow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__iscolored">\</a>  CMFCBaseTabCtrl::IsColored  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__isdialogcontrol">\</a>  CMFCBaseTabCtrl::IsDialogControl  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__isdrawnoprefix">\</a>  CMFCBaseTabCtrl::IsDrawNoPrefix  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__isflatframe">\</a>  CMFCBaseTabCtrl::IsFlatFrame  
 Indicates whether the frame of the tab control is rendered in a flat style or in a 3D style.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> if the frame of the tab control is rendered in a flat style; <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> if the frame is rendered in a 3D style.  
  
### Remarks  
 Use [CMFCTabCtrl::SetFlatFrame](../vs140/cmfctabctrl-class.md#cmfctabctrl__setflatframe) to change the style for the frame of the tab control.  
  
 Tab controls that use the Outlook style cannot be rendered with flat frames. This includes the [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md) and any classes derived from that class.  
  
##  \<a name="cmfcbasetabctrl__isflattab">\</a>  CMFCBaseTabCtrl::IsFlatTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__ishidesingletab">\</a>  CMFCBaseTabCtrl::IsHideSingleTab  
 Determines whether the tab control hides the tab label if there is only one tab.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> if the tab control hides the tab label when it has one tab; otherwise <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use the method [CMFCBaseTabCtrl::HideSingleTab](#cmfcbasetabctrl__hidesingletab) to enable hiding the tab label when there is only one tab.  
  
##  \<a name="cmfcbasetabctrl__isiconadded">\</a>  CMFCBaseTabCtrl::IsIconAdded  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__isinplaceedit">\</a>  CMFCBaseTabCtrl::IsInPlaceEdit  
 Indicates whether the tab control is configured to enable the user to dynamically modify the tab labels.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if in-place editing is enabled; otherwise 0.  
  
### Remarks  
 You can enable or disable in-place editing by calling the method [CMFCBaseTabCtrl::EnableInPlaceEdit](#cmfcbasetabctrl__enableinplaceedit).  
  
##  \<a name="cmfcbasetabctrl__isleftrightrounded">\</a>  CMFCBaseTabCtrl::IsLeftRightRounded  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__ismditab">\</a>  CMFCBaseTabCtrl::IsMDITab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__isonenotestyle">\</a>  CMFCBaseTabCtrl::IsOneNoteStyle  
 Determines whether tabs are displayed in the style of Microsoft OneNote.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> if tabs are displayed in the style of Microsoft OneNote; otherwise  <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call the method [CMDIFrameWndEx::EnableMDITabs](../vs140/cmdiframewndex-class.md#cmdiframewndex__enablemditabs) to enable the Microsoft OneNote style. You can also enable this style when you instantiate the [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md): simply pass the style STYLE_3D_ONENOTE to the method [CMFCTabCtrl::Create](../vs140/cmfctabctrl-class.md#cmfctabctrl__create).  
  
 By default, the Microsoft OneNote style is not supported in a custom class derived from the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md). However, it is supported in the <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> class.  
  
##  \<a name="cmfcbasetabctrl__isptintabarea">\</a>  CMFCBaseTabCtrl::IsPtInTabArea  
 Determines if a point is inside the tab area.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 The point to test.  
  
### Return Value  
 Nonzero if the point is in the tab area; 0 otherwise.  
  
### Remarks  
 In the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), this method is a pure virtual function and has no implementation. If you derive a class from <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>, you have to implement this function.  
  
##  \<a name="cmfcbasetabctrl__istabclosebuttonhighlighted">\</a>  CMFCBaseTabCtrl::IsTabCloseButtonHighlighted  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__istabclosebuttonpressed">\</a>  CMFCBaseTabCtrl::IsTabCloseButtonPressed  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__istabdetachable">\</a>  CMFCBaseTabCtrl::IsTabDetachable  
 Determines whether a tab is detachable.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 The zero-based index of the tab to check.  
  
### Return Value  
 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> if the tab is detachable; <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 To make a tab detachable, use the method [CMFCBaseTabCtrl::EnableTabDetach](#cmfcbasetabctrl__enabletabdetach).  
  
##  \<a name="cmfcbasetabctrl__istabicononly">\</a>  CMFCBaseTabCtrl::IsTabIconOnly  
 Determines whether a tab label contains only icons and no text.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
### Return Value  
 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> if a tab label has only icons; <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 To set the tabs in your application to display only icons, call the method [CMFCBaseTabCtrl::SetTabIconOnly](#cmfcbasetabctrl__settabicononly).  
  
##  \<a name="cmfcbasetabctrl__istabswapenabled">\</a>  CMFCBaseTabCtrl::IsTabSwapEnabled  
 Determines whether the tab control allows the user to change tab positions by using the mouse.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if tab positions can be changed by the user; otherwise 0.  
  
### Remarks  
 By default, users cannot change the order of tabs in a tab control. Use the [CMFCBaseTabCtrl::EnableTabSwap](#cmfcbasetabctrl__enabletabswap) method to enable this functionality.  
  
##  \<a name="cmfcbasetabctrl__istabvisible">\</a>  CMFCBaseTabCtrl::IsTabVisible  
 Indicates whether the specified tab is visible.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>  
 The zero-based index of the tab to check.  
  
### Return Value  
 Nonzero if the specified tab is visible; otherwise 0.  
  
##  \<a name="cmfcbasetabctrl__isvs2005style">\</a>  CMFCBaseTabCtrl::IsVS2005Style  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__m_bactivatetabonrightclick">\</a>  CMFCBaseTabCtrl::m_bActivateTabOnRightClick  
 <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> determines whether tabs are in focus when the user clicks on a tab label by using the right mouse button.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Remarks  
 The default value for this data member is <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__m_bautodestroywindow">\</a>  CMFCBaseTabCtrl::m_bAutoDestroyWindow  
 <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> determines whether the framework automatically destroys the objects on tabs when the tabs are removed.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Remarks  
 By default, this member is <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__movetab">\</a>  CMFCBaseTabCtrl::MoveTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__onchangetabs">\</a>  CMFCBaseTabCtrl::OnChangeTabs  
 The framework calls this method when the number of tabs on a tab control changes.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Remarks  
 By default, this method does nothing. Override this method to execute custom code when the number of tabs on the tab control changes.  
  
##  \<a name="cmfcbasetabctrl__ondrop">\</a>  CMFCBaseTabCtrl::OnDrop  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__ondragover">\</a>  CMFCBaseTabCtrl::OnDragOver  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__ondragleave">\</a>  CMFCBaseTabCtrl::OnDragLeave  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__ondragenter">\</a>  CMFCBaseTabCtrl::OnDragEnter  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__onrenametab">\</a>  CMFCBaseTabCtrl::OnRenameTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__pretranslatemessage">\</a>  CMFCBaseTabCtrl::PreTranslateMessage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__recalclayout">\</a>  CMFCBaseTabCtrl::RecalcLayout  
 Recalculates the internal layout of the tab control.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Remarks  
 In the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), this method is a pure virtual function. If you derive a class from <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>, you have to implement this function.  
  
##  \<a name="cmfcbasetabctrl__removealltabs">\</a>  CMFCBaseTabCtrl::RemoveAllTabs  
 Removes all the tabs from the tab control.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Remarks  
 If [CMFCBaseTabCtrl::m_bAutoDestroyWindow](#cmfcbasetabctrl__m_bautodestroywindow) is <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>, the framework deletes all the [CWnd](../vs140/cwnd-class.md) objects attached to the removed tabs.  
  
##  \<a name="cmfcbasetabctrl__removetab">\</a>  CMFCBaseTabCtrl::RemoveTab  
 Removes a tab from the tab control.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 The zero-based index of a tab.  
  
 [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether to recalculate the layout of the tab.  
  
### Return Value  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> if the method removes the tab successfully; otherwise <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>.  
  
### Remarks  
 If [CMFCBaseTabCtrl::m_bAutoDestroyWindow](#cmfcbasetabctrl__m_bautodestroywindow) is <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> destroys the [CWnd](../vs140/cwnd-class.md) object associated with the specified tab.  
  
##  \<a name="cmfcbasetabctrl__renametab">\</a>  CMFCBaseTabCtrl::RenameTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__resetimagelist">\</a>  CMFCBaseTabCtrl::ResetImageList  
 Resets the image list for an instance of the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md).  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
##  \<a name="cmfcbasetabctrl__serialize">\</a>  CMFCBaseTabCtrl::Serialize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__setactivetab">\</a>  CMFCBaseTabCtrl::SetActiveTab  
 Activates the specified tab.  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
 The zero-based index of a tab. <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> makes the tab with this index active.  
  
### Return Value  
 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>.  
  
### Remarks  
 In the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), this method is a pure virtual function. If you derive a class from <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>, you have to implement this function.  
  
##  \<a name="cmfcbasetabctrl__setactivetabcolor">\</a>  CMFCBaseTabCtrl::SetActiveTabColor  
 Sets the background color for the active tab.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 Specifies the new background color.  
  
### Remarks  
 The framework obtains the default background color for active tabs from the                         [GetSysColor](http://msdn.microsoft.com/library/windows/desktop/ms724371)method.  
  
##  \<a name="cmfcbasetabctrl__setactivetabtextcolor">\</a>  CMFCBaseTabCtrl::SetActiveTabTextColor  
 Sets the text color for active tabs.  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 A                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that specifies the new text color.  
  
### Remarks  
 By default, the framework obtains the text color from                         [GetSysColor](http://msdn.microsoft.com/library/windows/desktop/ms724371). Override this default color by using the <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> method.  
  
##  \<a name="cmfcbasetabctrl__setautocolors">\</a>  CMFCBaseTabCtrl::SetAutoColors  
 Sets the colors of the tab control that the framework uses in automatic color mode.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
 An array of RGB colors.  
  
### Remarks  
 If you provide a custom array of colors, the default array of colors is ignored. If the parameter <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> is empty, the framework reverts to the default array of colors.  
  
 To enable autocolor mode, use the [CMFCBaseTabCtrl::EnableAutoColor](#cmfcbasetabctrl__enableautocolor) method.  
  
##  \<a name="cmfcbasetabctrl__setdockingbarwrapperrtc">\</a>  CMFCBaseTabCtrl::SetDockingBarWrapperRTC  
 Sets the wrapper class that is used for any objects that are not derived from the [CDockablePane Class](../vs140/cdockablepane-class.md).  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
 The runtime class information for the new wrapper class.  
  
### Remarks  
 You add tabs to a tab control by using the methods [CMFCBaseTabCtrl::AddTab](#cmfcbasetabctrl__addtab) and [CMFCBaseTabCtrl::InsertTab](#cmfcbasetabctrl__inserttab). When you add a tab, each control on that tab must be dockable. Any objects that are not derived from <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> must be wrapped. <CodeContentPlaceHolder>326\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> create a wrapper for these objects. The default wrapper class is the [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md). The method <CodeContentPlaceHolder>328\</CodeContentPlaceHolder> enables you to change the class that is used as a wrapper class. The wrapper class that you provide must be derived from <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__setdrawnoprefix">\</a>  CMFCBaseTabCtrl::SetDrawNoPrefix  
 Enables and disables the processing of prefix characters in tab labels.  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>331\</CodeContentPlaceHolder> if you want to process prefix characters; otherwise <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>334\</CodeContentPlaceHolder> if you want to redraw the tabbed window; otherwise <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>.  
  
### Remarks  
 A prefix character is a mnemonic character that is preceded by an ampersand (&).  
  
##  \<a name="cmfcbasetabctrl__setimagelist">\</a>  CMFCBaseTabCtrl::SetImageList  
 Sets the icon image list for the tab control.  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>336\</CodeContentPlaceHolder>  
 A bitmap resource ID. <CodeContentPlaceHolder>337\</CodeContentPlaceHolder> loads the image list from this resource.  
  
 [in] <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
 The width of each image in pixels.  
  
 [in] <CodeContentPlaceHolder>339\</CodeContentPlaceHolder>  
 A                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the transparent color of the image.  
  
 [in] <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>  
 A handle to a preloaded image list.  
  
### Return Value  
 Nonzero if the method was successful; 0 otherwise.  
  
### Remarks  
 The images from the icon image list are displayed alongside the labels for the tab. To display an icon, you must specify its index when you call [CMFCBaseTabCtrl::AddTab](#cmfcbasetabctrl__addtab).  
  
 <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> will fail if the tab control was created with a flat style. It will also fail if the framework cannot load the image indicated by <CodeContentPlaceHolder>342\</CodeContentPlaceHolder>.  
  
 This method recalculates the height of the tab according to the image and text sizes.  
  
##  \<a name="cmfcbasetabctrl__setlocation">\</a>  CMFCBaseTabCtrl::SetLocation  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__settabbkcolor">\</a>  CMFCBaseTabCtrl::SetTabBkColor  
 Sets the background color for the specified tab.  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
 [in] <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>  
 The color to set.  
  
### Return Value  
 <CodeContentPlaceHolder>346\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>347\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcbasetabctrl__settabbordersize">\</a>  CMFCBaseTabCtrl::SetTabBorderSize  
 Sets a new border size for the tab control.  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>  
 The new border size, in pixels.  
  
 [in] <CodeContentPlaceHolder>349\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the framework redraws the control.  
  
##  \<a name="cmfcbasetabctrl__settabhicon">\</a>  CMFCBaseTabCtrl::SetTabHicon  
 Sets the icon for a tab label.  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>350\</CodeContentPlaceHolder>  
 The zero-based index of a tab. This method changes the icon for this tab.  
  
 [in] <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>  
 A handle to an icon.  
  
### Return Value  
 <CodeContentPlaceHolder>352\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>353\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__settabicon">\</a>  CMFCBaseTabCtrl::SetTabIcon  
 Sets the icon for a tab.  
  
<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>354\</CodeContentPlaceHolder>  
 The zero-based index of the tab to update.  
  
 [in] <CodeContentPlaceHolder>355\</CodeContentPlaceHolder>  
 The icon ID for the new icon. This ID references the internal [CImageList](../vs140/cimagelist-class.md) object.  
  
### Return Value  
 <CodeContentPlaceHolder>356\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>357\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasetabctrl__settabicononly">\</a>  CMFCBaseTabCtrl::SetTabIconOnly  
 Enables displaying only an icon (and no text label) on a specific tab.  
  
<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>358\</CodeContentPlaceHolder>  
 The zero-based index of the tab to change.  
  
 [in] <CodeContentPlaceHolder>359\</CodeContentPlaceHolder>  
 A Boolean parameter that determines whether to display only icons.  
  
 [in] <CodeContentPlaceHolder>360\</CodeContentPlaceHolder>  
 A Boolean parameter that determines whether the framework shows tooltips for a tab label that displays only icons.  
  
### Return Value  
 <CodeContentPlaceHolder>361\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>362\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, a tab control displays the icon and text label for each tab.  
  
##  \<a name="cmfcbasetabctrl__settablabel">\</a>  CMFCBaseTabCtrl::SetTabLabel  
 Sets the text for a tab label.  
  
<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>  
 The zero-based index of the tab to update.  
  
 [in] <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 A reference to a string that contains the new text for the tab label.  
  
### Return Value  
 Nonzero if successful; 0 otherwise.  
  
##  \<a name="cmfcbasetabctrl__settabsheight">\</a>  CMFCBaseTabCtrl::SetTabsHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__settabsorder">\</a>  CMFCBaseTabCtrl::SetTabsOrder  
 Arranges the tabs in the specified order.  
  
<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>  
 An array of zero-based indexes that defines the new tab order.  
  
### Return Value  
 <CodeContentPlaceHolder>366\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>367\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The size of the <CodeContentPlaceHolder>368\</CodeContentPlaceHolder> array must be equal to the number of tabs in the tab control.  
  
##  \<a name="cmfcbasetabctrl__settabtextcolor">\</a>  CMFCBaseTabCtrl::SetTabTextColor  
 Sets the text color for a specific tab.  
  
<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
 The zero-based index of the tab.  
  
 [in] <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>  
 A                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the new text color.  
  
### Return Value  
 Nonzero if successful; 0 otherwise.  
  
##  \<a name="cmfcbasetabctrl__showtab">\</a>  CMFCBaseTabCtrl::ShowTab  
 Shows or hides the specified tab.  
  
<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>  
 The index of the tab that <CodeContentPlaceHolder>372\</CodeContentPlaceHolder> will show or hide.  
  
 [in] <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to show the tab.  
  
 [in] <CodeContentPlaceHolder>374\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to immediately recalculate the window layout.  
  
 [in] <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to select the tab specified by <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The parameter <CodeContentPlaceHolder>377\</CodeContentPlaceHolder> only applies if <CodeContentPlaceHolder>378\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>379\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>380\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>381\</CodeContentPlaceHolder> and if <CodeContentPlaceHolder>382\</CodeContentPlaceHolder> is successful, <CodeContentPlaceHolder>383\</CodeContentPlaceHolder> will send the message AFX_WM_CHANGE_ACTIVE_TAB to the parent of the tab window.  
  
##  \<a name="cmfcbasetabctrl__startrenametab">\</a>  CMFCBaseTabCtrl::StartRenameTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcbasetabctrl__swaptabs">\</a>  CMFCBaseTabCtrl::SwapTabs  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>385\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>386\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md)