---
title: "CDockingPanesRow Class"
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
  - "CDockingPanesRow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDockingPanesRow class"
ms.assetid: e7a17832-0ebb-4bce-b799-cec9b60f76fe
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingPanesRow Class
Manages a list of panes that are located in the same horizontal or vertical row (column) of a dock site.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDockingPanesRow::AddPane](#cdockingpanesrow__addpane)||  
|[CDockingPanesRow::AddPaneFromRow](#cdockingpanesrow__addpanefromrow)||  
|[CDockingPanesRow::ArrangePanes](#cdockingpanesrow__arrangepanes)|Arranges the panes in a row according to the specified margin and spacing parameters.|  
|[CDockingPanesRow::CalcFixedLayout](#cdockingpanesrow__calcfixedlayout)||  
|[CDockingPanesRow::Create](#cdockingpanesrow__create)||  
|[CDockingPanesRow::ExpandStretchedPanes](#cdockingpanesrow__expandstretchedpanes)||  
|[CDockingPanesRow::ExpandStretchedPanesRect](#cdockingpanesrow__expandstretchedpanesrect)||  
|[CDockingPanesRow::FixupVirtualRects](#cdockingpanesrow__fixupvirtualrects)||  
|[CDockingPanesRow::GetAvailableLength](#cdockingpanesrow__getavailablelength)||  
|[CDockingPanesRow::GetAvailableSpace](#cdockingpanesrow__getavailablespace)||  
|[CDockingPanesRow::GetClientRect](#cdockingpanesrow__getclientrect)||  
|[CDockingPanesRow::GetDockSite](#cdockingpanesrow__getdocksite)||  
|[CDockingPanesRow::GetExtraSpace](#cdockingpanesrow__getextraspace)||  
|[CDockingPanesRow::GetGroupFromPane](#cdockingpanesrow__getgroupfrompane)||  
|[CDockingPanesRow::GetID](#cdockingpanesrow__getid)||  
|[CDockingPanesRow::GetMaxPaneSize](#cdockingpanesrow__getmaxpanesize)||  
|[CDockingPanesRow::GetPaneCount](#cdockingpanesrow__getpanecount)||  
|[CDockingPanesRow::GetPaneList](#cdockingpanesrow__getpanelist)||  
|[CDockingPanesRow::GetRowAlignment](#cdockingpanesrow__getrowalignment)||  
|[CDockingPanesRow::GetRowHeight](#cdockingpanesrow__getrowheight)||  
|[CDockingPanesRow::GetRowOffset](#cdockingpanesrow__getrowoffset)||  
|[CDockingPanesRow::GetVisibleCount](#cdockingpanesrow__getvisiblecount)||  
|[CDockingPanesRow::GetWindowRect](#cdockingpanesrow__getwindowrect)||  
|[CDockingPanesRow::HasPane](#cdockingpanesrow__haspane)||  
|[CDockingPanesRow::IsEmpty](#cdockingpanesrow__isempty)||  
|[CDockingPanesRow::IsExclusiveRow](#cdockingpanesrow__isexclusiverow)||  
|[CDockingPanesRow::IsHorizontal](#cdockingpanesrow__ishorizontal)||  
|[CDockingPanesRow::IsVisible](#cdockingpanesrow__isvisible)||  
|[CDockingPanesRow::Move](#cdockingpanesrow__move)||  
|[CDockingPanesRow::MovePane](#cdockingpanesrow__movepane)||  
|[CDockingPanesRow::OnResizePane](#cdockingpanesrow__onresizepane)||  
|[CDockingPanesRow::RedrawAll](#cdockingpanesrow__redrawall)||  
|[CDockingPanesRow::RemovePane](#cdockingpanesrow__removepane)||  
|[CDockingPanesRow::ReplacePane](#cdockingpanesrow__replacepane)||  
|[CDockingPanesRow::RepositionPanes](#cdockingpanesrow__repositionpanes)||  
|[CDockingPanesRow::Resize](#cdockingpanesrow__resize)||  
|[CDockingPanesRow::ResizeByPaneDivider](#cdockingpanesrow__resizebypanedivider)||  
|[CDockingPanesRow::ScreenToClient](#cdockingpanesrow__screentoclient)||  
|[CDockingPanesRow::SetExtra](#cdockingpanesrow__setextra)||  
|[CDockingPanesRow::ShowDockSiteRow](#cdockingpanesrow__showdocksiterow)||  
|[CDockingPanesRow::ShowPane](#cdockingpanesrow__showpane)||  
|[CDockingPanesRow::UpdateVisibleState](#cdockingpanesrow__updatevisiblestate)||  
  
## Remarks  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> objects are created internally by dock site objects.  
  
## Example  
 The following example demonstrates how to get a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
 [!code[NVC_MFC_RibbonApp#26](../vs140/codesnippet/CPP/cdockingpanesrow-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CDockingPanesRow](../vs140/cdockingpanesrow-class.md)  
  
## Requirements  
 **Header:** afxDockingPanesRow.h  
  
##  \<a name="cdockingpanesrow__addpane">\</a>  CDockingPanesRow::AddPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__addpanefromrow">\</a>  CDockingPanesRow::AddPaneFromRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__arrangepanes">\</a>  CDockingPanesRow::ArrangePanes  
 Arranges docking panes in a row according to the specified margin and spacing parameters.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Specifies the offset, in pixels, of the first pane from the upper-left corner of the row.  
  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Specifies the spacing, in pixels, between panes.  
  
### Remarks  
 Call this method to arrange panes in the row where they will dock. After calling this method, you must call <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
##  \<a name="cdockingpanesrow__calcfixedlayout">\</a>  CDockingPanesRow::CalcFixedLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__cdockingpanesrow">\</a>  CDockingPanesRow::CDockingPanesRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__create">\</a>  CDockingPanesRow::Create  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__expandstretchedpanes">\</a>  CDockingPanesRow::ExpandStretchedPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdockingpanesrow__expandstretchedpanesrect">\</a>  CDockingPanesRow::ExpandStretchedPanesRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdockingpanesrow__fixupvirtualrects">\</a>  CDockingPanesRow::FixupVirtualRects  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getavailablelength">\</a>  CDockingPanesRow::GetAvailableLength  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getavailablespace">\</a>  CDockingPanesRow::GetAvailableSpace  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getclientrect">\</a>  CDockingPanesRow::GetClientRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getdocksite">\</a>  CDockingPanesRow::GetDockSite  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getextraspace">\</a>  CDockingPanesRow::GetExtraSpace  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getgroupfrompane">\</a>  CDockingPanesRow::GetGroupFromPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getid">\</a>  CDockingPanesRow::GetID  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getmaxpanesize">\</a>  CDockingPanesRow::GetMaxPaneSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getpanecount">\</a>  CDockingPanesRow::GetPaneCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getpanelist">\</a>  CDockingPanesRow::GetPaneList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getrowalignment">\</a>  CDockingPanesRow::GetRowAlignment  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getrowheight">\</a>  CDockingPanesRow::GetRowHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getrowoffset">\</a>  CDockingPanesRow::GetRowOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getvisiblecount">\</a>  CDockingPanesRow::GetVisibleCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__getwindowrect">\</a>  CDockingPanesRow::GetWindowRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__haspane">\</a>  CDockingPanesRow::HasPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__isempty">\</a>  CDockingPanesRow::IsEmpty  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__isexclusiverow">\</a>  CDockingPanesRow::IsExclusiveRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__ishorizontal">\</a>  CDockingPanesRow::IsHorizontal  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__isvisible">\</a>  CDockingPanesRow::IsVisible  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__move">\</a>  CDockingPanesRow::Move  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__movepane">\</a>  CDockingPanesRow::MovePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__onresizepane">\</a>  CDockingPanesRow::OnResizePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__redrawall">\</a>  CDockingPanesRow::RedrawAll  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cdockingpanesrow__removepane">\</a>  CDockingPanesRow::RemovePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__replacepane">\</a>  CDockingPanesRow::ReplacePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__repositionpanes">\</a>  CDockingPanesRow::RepositionPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__resize">\</a>  CDockingPanesRow::Resize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__resizebypanedivider">\</a>  CDockingPanesRow::ResizeByPaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__screentoclient">\</a>  CDockingPanesRow::ScreenToClient  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__setextra">\</a>  CDockingPanesRow::SetExtra  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__showdocksiterow">\</a>  CDockingPanesRow::ShowDockSiteRow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__showpane">\</a>  CDockingPanesRow::ShowPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdockingpanesrow__updatevisiblestate">\</a>  CDockingPanesRow::UpdateVisibleState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CObject Class](../vs140/cobject-class.md)   
 [CDockSite Class](../vs140/cdocksite-class.md)   
 [CPane Class](../vs140/cpane-class.md)