---
title: "CDockSite Class"
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
  - "CDockSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDockSite class"
ms.assetid: 0fcfff79-5f50-4281-b2de-a55653bbea40
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockSite Class
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
 Provides functionality for arranging panes that are derived from the [CPane Class](../vs140/cpane-class.md) into sets of rows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDockSite::AddRow](#cdocksite__addrow)||  
|[CDockSite::AdjustDockingLayout](#cdocksite__adjustdockinglayout)|(Overrides [CBasePane::AdjustDockingLayout](../vs140/cbasepane-class.md#cbasepane__adjustdockinglayout).)|  
|[CDockSite::AdjustLayout](#cdocksite__adjustlayout)|(Overrides [CBasePane::AdjustLayout](../vs140/cbasepane-class.md#cbasepane__adjustlayout).)|  
|[CDockSite::AlignDockSite](#cdocksite__aligndocksite)||  
|[CDockSite::CalcFixedLayout](#cdocksite__calcfixedlayout)|(Overrides [CBasePane::CalcFixedLayout](../vs140/cbasepane-class.md#cbasepane__calcfixedlayout).)|  
|[CDockSite::CanAcceptPane](#cdocksite__canacceptpane)|(Overrides [CBasePane::CanAcceptPane](../vs140/cbasepane-class.md#cbasepane__canacceptpane).)|  
|[CDockSite::CreateEx](#cdocksite__createex)|(Overrides [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex).)|  
|[CDockSite::CreateRow](#cdocksite__createrow)||  
|[CDockSite::DockPane](#cdocksite__dockpane)|(Overrides [CBasePane::DockPane](../vs140/cbasepane-class.md#cbasepane__dockpane).)|  
|[CDockSite::DoesAllowDynInsertBefore](#cdocksite__doesallowdyninsertbefore)|(Overrides [CBasePane::DoesAllowDynInsertBefore](../vs140/cbasepane-class.md#cbasepane__doesallowdyninsertbefore).)|  
|[CDockSite::FindRowIndex](#cdocksite__findrowindex)||  
|[CDockSite::FixupVirtualRects](#cdocksite__fixupvirtualrects)||  
|[CDockSite::GetDockSiteID](#cdocksite__getdocksiteid)||  
|[CDockSite::GetDockSiteRowsList](#cdocksite__getdocksiterowslist)||  
|[CDockSite::IsAccessibilityCompatible](#cdocksite__isaccessibilitycompatible)|(Overrides <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.)|  
|[CDockSite::IsDragMode](#cdocksite__isdragmode)||  
|[CDockSite::IsLastRow](#cdocksite__islastrow)||  
|[CDockSite::IsRectWithinDockSite](#cdocksite__isrectwithindocksite)||  
|[CDockSite::IsResizable](#cdocksite__isresizable)|(Overrides [CBasePane::IsResizable](../vs140/cbasepane-class.md#cbasepane__isresizable).)|  
|[CDockSite::MovePane](#cdocksite__movepane)||  
|[CDockSite::OnInsertRow](#cdocksite__oninsertrow)||  
|[CDockSite::OnRemoveRow](#cdocksite__onremoverow)||  
|[CDockSite::OnResizeRow](#cdocksite__onresizerow)||  
|[CDockSite::OnSetWindowPos](#cdocksite__onsetwindowpos)||  
|[CDockSite::OnShowRow](#cdocksite__onshowrow)||  
|[CDockSite::OnSizeParent](#cdocksite__onsizeparent)||  
|[CDockSite::PaneFromPoint](#cdocksite__panefrompoint)|Returns a pane that is docked in the dock site at the point specified by the given parameter.|  
|[CDockSite::DockPaneLeftOf](#cdocksite__dockpaneleftof)|Docks a pane to the left of another pane.|  
|[CDockSite::FindPanebyID](#cdocksite__findpanebyid)|Returns the pane that is identified by the given ID.|  
|[CDockSite::GetPaneList](#cdocksite__getpanelist)|Returns a list of panes that are docked at the dock site.|  
|[CDockSite::RectSideFromPoint](#cdocksite__rectsidefrompoint)||  
|[CDockSite::RemovePane](#cdocksite__removepane)||  
|[CDockSite::RemoveRow](#cdocksite__removerow)||  
|[CDockSite::ReplacePane](#cdocksite__replacepane)||  
|[CDockSite::RepositionPanes](#cdocksite__repositionpanes)||  
|[CDockSite::ResizeDockSite](#cdocksite__resizedocksite)||  
|[CDockSite::ResizeRow](#cdocksite__resizerow)||  
|[CDockSite::ShowPane](#cdocksite__showpane)|Shows the pane.|  
|[CDockSite::ShowRow](#cdocksite__showrow)||  
|[CDockSite::SwapRows](#cdocksite__swaprows)||  
  
## Remarks  
 The framework creates <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> objects automatically when you call [CFrameWndEx::EnableDocking](../vs140/cframewndex-class.md#cframewndex__enabledocking). Dock site windows are positioned at the edge of the client area on the main frame window.  
  
 You usually do not have to call the services provided by the dock site because [CFrameWndEx](../vs140/cframewndex-class.md) handles these services.  
  
## Example  
 The following example demonstrates how to create an object of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#27](../vs140/codesnippet/CPP/cdocksite-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md) [CCmdTarget](../vs140/ccmdtarget-class.md) [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md) [CDockSite](../vs140/cdocksite-class.md)  
  
## Requirements  
 **Header:** afxDockSite.h  
  
##  \<a name="cdocksite__addrow">\</a>  CDockSite::AddRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__adjustdockinglayout">\</a>  CDockSite::AdjustDockingLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocksite__adjustlayout">\</a>  CDockSite::AdjustLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocksite__aligndocksite">\</a>  CDockSite::AlignDockSite  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__calcfixedlayout">\</a>  CDockSite::CalcFixedLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__canacceptpane">\</a>  CDockSite::CanAcceptPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__createex">\</a>  CDockSite::CreateEx  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__createrow">\</a>  CDockSite::CreateRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__dockpane">\</a>  CDockSite::DockPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__dockpaneleftof">\</a>  CDockSite::DockPaneLeftOf  
 Docks a pane to the left of another pane.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to the pane to be docked to the left of <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 [in] [out] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to the target pane.  
  
### Return Value  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> if the pane is docked successfully; otherwise, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cdocksite__doesallowdyninsertbefore">\</a>  CDockSite::DoesAllowDynInsertBefore  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__findpanebyid">\</a>  CDockSite::FindPaneByID  
 Returns the pane with the given ID.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The command ID of the pane to be found.  
  
### Return Value  
 A pointer to the pane with the specified command ID, or <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> if the pane is not found.  
  
### Remarks  
  
##  \<a name="cdocksite__findrowindex">\</a>  CDockSite::FindRowIndex  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__fixupvirtualrects">\</a>  CDockSite::FixupVirtualRects  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdocksite__getdocksiteid">\</a>  CDockSite::GetDockSiteID  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__getdocksiterowslist">\</a>  CDockSite::GetDockSiteRowsList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__getpanelist">\</a>  CDockSite::GetPaneList  
 Returns a list of panes that are docked in the dock site.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A read-only reference to the list of panes currently docked in the docking bar.  
  
##  \<a name="cdocksite__isaccessibilitycompatible">\</a>  CDockSite::IsAccessibilityCompatible  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__isdragmode">\</a>  CDockSite::IsDragMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__islastrow">\</a>  CDockSite::IsLastRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__isrectwithindocksite">\</a>  CDockSite::IsRectWithinDockSite  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__isresizable">\</a>  CDockSite::IsResizable  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__movepane">\</a>  CDockSite::MovePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__oninsertrow">\</a>  CDockSite::OnInsertRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__onremoverow">\</a>  CDockSite::OnRemoveRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__onresizerow">\</a>  CDockSite::OnResizeRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__onsizeparent">\</a>  CDockSite::OnSizeParent  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__onsetwindowpos">\</a>  CDockSite::OnSetWindowPos  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__onshowrow">\</a>  CDockSite::OnShowRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__panefrompoint">\</a>  CDockSite::PaneFromPoint  
 Returns a pane that is docked in the dock site at the point specified by the given parameter.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 A point, in screen coordinates, for the pane to retrieve.  
  
### Return Value  
 A pointer to the pane located at the specified point or <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> if no pane was present at the specified point.  
  
### Remarks  
  
##  \<a name="cdocksite__rectsidefrompoint">\</a>  CDockSite::RectSideFromPoint  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__removepane">\</a>  CDockSite::RemovePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__removerow">\</a>  CDockSite::RemoveRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__replacepane">\</a>  CDockSite::ReplacePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__repositionpanes">\</a>  CDockSite::RepositionPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__resizedocksite">\</a>  CDockSite::ResizeDockSite  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__resizerow">\</a>  CDockSite::ResizeRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdocksite__showpane">\</a>  CDockSite::ShowPane  
 Shows the pane.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 A pointer to the pane to be shown or hidden.  
  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> to specify that the pane is to be shown; <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> to specify that the pane is to be hidden.  
  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> to specify that the layout of the pane should be delayed until after the pane is shown; otherwise, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> if the pane was shown or hidden successfully. <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> if the specified pane does not belong to this dock site.  
  
### Remarks  
 Call this method to show or hide docked panes. Normally, you do not have to call <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> directly, because it is called by the parent frame window or by the base pane.  
  
##  \<a name="cdocksite__showrow">\</a>  CDockSite::ShowRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdocksite__swaprows">\</a>  CDockSite::SwapRows  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CBasePane](../vs140/cbasepane-class.md)