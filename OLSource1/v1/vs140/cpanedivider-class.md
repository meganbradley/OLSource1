---
title: "CPaneDivider Class"
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
  - "CPaneDivider"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPaneDivider class"
ms.assetid: 8e828a5d-232f-4127-b8e3-7fa45a7a476e
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneDivider Class
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
 The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> class divides two panes, divides two groups of panes, or separates a group of panes from the client area of the main frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneDivider::CPaneDivider](#cpanedivider__cpanedivider)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneDivider::AddPaneContainer](#cpanedivider__addpanecontainer)||  
|[CPaneDivider::AddPane](#cpanedivider__addpane)||  
|[CPaneDivider::AddRecentPane](#cpanedivider__addrecentpane)||  
|[CPaneDivider::CalcExpectedDockedRect](#cpanedivider__calcexpecteddockedrect)||  
|[CPaneDivider::CalcFixedLayout](#cpanedivider__calcfixedlayout)|(Overrides [CBasePane::CalcFixedLayout](../vs140/cbasepane-class.md#cbasepane__calcfixedlayout).)|  
|[CPaneDivider::CheckVisibility](#cpanedivider__checkvisibility)||  
|[CPaneDivider::CreateEx](#cpanedivider__createex)|(Overrides [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex).)|  
|[CPaneDivider::DoesAllowDynInsertBefore](#cpanedivider__doesallowdyninsertbefore)|(Overrides [CBasePane::DoesAllowDynInsertBefore](../vs140/cbasepane-class.md#cbasepane__doesallowdyninsertbefore).)|  
|[CPaneDivider::DoesContainFloatingPane](#cpanedivider__doescontainfloatingpane)||  
|[CPaneDivider::FindPaneContainer](#cpanedivider__findpanecontainer)||  
|[CPaneDivider::FindTabbedPane](#cpanedivider__findtabbedpane)||  
|[CPaneDivider::GetDefaultWidth](#cpanedivider__getdefaultwidth)||  
|[CPaneDivider::GetFirstPane](#cpanedivider__getfirstpane)||  
|[CPaneDivider::GetPaneDividerStyle](#cpanedivider__getpanedividerstyle)||  
|[CPaneDivider::GetRootContainerRect](#cpanedivider__getrootcontainerrect)||  
|[CPaneDivider::GetWidth](#cpanedivider__getwidth)||  
|[CPaneDivider::Init](#cpanedivider__init)||  
|[CPaneDivider::InsertPane](#cpanedivider__insertpane)||  
|[CPaneDivider::IsAutoHideMode](#cpanedivider__isautohidemode)|(Overrides [CBasePane::IsAutoHideMode](../vs140/cbasepane-class.md#cbasepane__isautohidemode).)|  
|[CPaneDivider::IsDefault](#cpanedivider__isdefault)||  
|[CPaneDivider::IsHorizontal](#cpanedivider__ishorizontal)|(Overrides [CBasePane::IsHorizontal](../vs140/cbasepane-class.md#cbasepane__ishorizontal).)|  
|[CPaneDivider::Move](#cpanedivider__move)||  
|[CPaneDivider::NotifyAboutRelease](#cpanedivider__notifyaboutrelease)||  
|[CPaneDivider::OnShowPane](#cpanedivider__onshowpane)||  
|[CPaneDivider::ReleaseEmptyPaneContainers](#cpanedivider__releaseemptypanecontainers)||  
|[CPaneDivider::RemovePane](#cpanedivider__removepane)||  
|[CPaneDivider::ReplacePane](#cpanedivider__replacepane)||  
|[CPaneDivider::RepositionPanes](#cpanedivider__repositionpanes)||  
|[CPaneDivider::Serialize](#cpanedivider__serialize)|(Overrides <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.)|  
|[CPaneDivider::SetAutoHideMode](#cpanedivider__setautohidemode)||  
|[CPaneDivider::SetPaneContainerManager](#cpanedivider__setpanecontainermanager)||  
|[CPaneDivider::ShowWindow](#cpanedivider__showwindow)||  
|[CPaneDivider::StoreRecentDockSiteInfo](#cpanedivider__storerecentdocksiteinfo)||  
|[CPaneDivider::StoreRecentTabRelatedInfo](#cpanedivider__storerecenttabrelatedinfo)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneDivider::GetPanes](#cpanedivider__getpanes)|Returns the list of panes that reside in the [CPaneContainer](../vs140/cpanecontainer-class.md). This method should be called only for default pane dividers.|  
|[CPaneDivider::GetPaneDividers](#cpanedivider__getpanedividers)|Returns the list of pane dividers that reside in the [CPaneContainer](../vs140/cpanecontainer-class.md). This method should be called only for default pane dividers.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneDivider::m_nDefaultWidth](#cpanedivider__m_ndefaultwidth)|Specifies the default width in pixels of all pane dividers in the application.|  
|[CPaneDivider::m_pSliderRTC](#cpanedivider__m_psliderrtc)|Holds a pointer to the runtime class information about a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>-derived object.|  
  
## Remarks  
 The framework creates <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> objects automatically when a pane is docked.  
  
 There are two types of pane dividers:  
  
-   a default pane divider is created when a group of panes is docked to a side of the main frame window. The default pane divider holds a pointer to the [CPaneContainerManager](../vs140/cpanecontainermanager-class.md) and redirects most operations on the group of panes (such as resizing a pane, or docking another pane or container) to the container manager. Each docking pane maintains a pointer to its default pane divider.  
  
-   A regular pane divider just divides two panes in a container. For more information, see [CPaneContainer](../vs140/cpanecontainer-class.md).  
  
## Example  
 The following example demonstrates how to get a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object. This code snippet is part of the [MDI Tabs Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MDITabsDemo#5](../vs140/codesnippet/CPP/cpanedivider-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md) [CCmdTarget](../vs140/ccmdtarget-class.md) [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md) [CPaneDivider](../vs140/cpanedivider-class.md)  
  
## Requirements  
 **Header:** afxPaneDivider.h  
  
##  \<a name="cpanedivider__setautohidemode">\</a>  CPaneDivider::SetAutoHideMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__setpanecontainermanager">\</a>  CPaneDivider::SetPaneContainerManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__addpane">\</a>  CPaneDivider::AddPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__addpanecontainer">\</a>  CPaneDivider::AddPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__addrecentpane">\</a>  CPaneDivider::AddRecentPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__calcexpecteddockedrect">\</a>  CPaneDivider::CalcExpectedDockedRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__calcfixedlayout">\</a>  CPaneDivider::CalcFixedLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__checkvisibility">\</a>  CPaneDivider::CheckVisibility  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__cpanedivider">\</a>  CPaneDivider::CPaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__createex">\</a>  CPaneDivider::CreateEx  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__doesallowdyninsertbefore">\</a>  CPaneDivider::DoesAllowDynInsertBefore  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__doescontainfloatingpane">\</a>  CPaneDivider::DoesContainFloatingPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__findpanecontainer">\</a>  CPaneDivider::FindPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__findtabbedpane">\</a>  CPaneDivider::FindTabbedPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__getdefaultwidth">\</a>  CPaneDivider::GetDefaultWidth  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__getfirstpane">\</a>  CPaneDivider::GetFirstPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__getpanedividers">\</a>  CPaneDivider::GetPaneDividers  
 Returns the list of pane dividers that reside in the [CPaneContainer](../vs140/cpanecontainer-class.md). This method should be called only for default pane dividers.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Contains the list of pane dividers that reside in the pane container.  
  
### Remarks  
 This method should be called for default pane dividers only. A default pane divider is a divider that resizes the entire pane container.  
  
##  \<a name="cpanedivider__getpanedividerstyle">\</a>  CPaneDivider::GetPaneDividerStyle  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__getpanes">\</a>  CPaneDivider::GetPanes  
 Returns the list of panes that reside in the [CPaneContainer](../vs140/cpanecontainer-class.md). This method should be called only to retrieve default pane dividers.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Contains the list of panes that reside in the pane container.  
  
### Remarks  
 This method should be called for default pane dividers only. A default pane divider is a divider that resizes the entire pane container.  
  
##  \<a name="cpanedivider__getrootcontainerrect">\</a>  CPaneDivider::GetRootContainerRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__getwidth">\</a>  CPaneDivider::GetWidth  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__init">\</a>  CPaneDivider::Init  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__insertpane">\</a>  CPaneDivider::InsertPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__isautohidemode">\</a>  CPaneDivider::IsAutoHideMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__isdefault">\</a>  CPaneDivider::IsDefault  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__ishorizontal">\</a>  CPaneDivider::IsHorizontal  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__m_ndefaultwidth">\</a>  CPaneDivider::m_nDefaultWidth  
 Specifies the default width, in pixels, of all pane dividers in the application.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
##  \<a name="cpanedivider__move">\</a>  CPaneDivider::Move  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__m_psliderrtc">\</a>  CPaneDivider::m_pSliderRTC  
 Holds a pointer to runtime class information about a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>-derived object.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 Set this member variable if you create a custom pane divider. This enables the framework to create your pane divider when the pane is drawn.  
  
### Example  
 The following example shows how to set the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> member variable:  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
##  \<a name="cpanedivider__notifyaboutrelease">\</a>  CPaneDivider::NotifyAboutRelease  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanedivider__onshowpane">\</a>  CPaneDivider::OnShowPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__releaseemptypanecontainers">\</a>  CPaneDivider::ReleaseEmptyPaneContainers  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanedivider__removepane">\</a>  CPaneDivider::RemovePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__replacepane">\</a>  CPaneDivider::ReplacePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanedivider__repositionpanes">\</a>  CPaneDivider::RepositionPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__serialize">\</a>  CPaneDivider::Serialize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__showwindow">\</a>  CPaneDivider::ShowWindow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__storerecentdocksiteinfo">\</a>  CPaneDivider::StoreRecentDockSiteInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanedivider__storerecenttabrelatedinfo">\</a>  CPaneDivider::StoreRecentTabRelatedInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CPaneContainerManager](../vs140/cpanecontainermanager-class.md)   
 [CPaneContainer](../vs140/cpanecontainer-class.md)   
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [CBasePane](../vs140/cbasepane-class.md)