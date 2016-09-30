---
title: "CPaneContainer Class"
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
  - "CPaneContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPaneContainer class"
ms.assetid: beb79e08-f611-4d66-ba04-053baa79bf86
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneContainer Class
The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> class is a basic component of the docking model implemented by MFC. An object of this class stores pointers to two docking panes or to two instances of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> It also stores a pointer to the divider that separates the panes (or the containers). By nesting containers inside containers, the framework can build a binary tree that represents complex docking layouts. The root of the binary tree is stored in a [CPaneContainerManager](../vs140/cpanecontainermanager-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneContainer::CPaneContainer](#cpanecontainer__cpanecontainer)|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneContainer::AddPane](#cpanecontainer__addpane)||  
|[CPaneContainer::AddRef](#cpanecontainer__addref)||  
|[CPaneContainer::AddSubPaneContainer](#cpanecontainer__addsubpanecontainer)||  
|[CPaneContainer::CalcAvailablePaneSpace](#cpanecontainer__calcavailablepanespace)||  
|[CPaneContainer::CalcAvailableSpace](#cpanecontainer__calcavailablespace)||  
|[CPaneContainer::CalculateRecentSize](#cpanecontainer__calculaterecentsize)||  
|[CPaneContainer::CheckPaneDividerVisibility](#cpanecontainer__checkpanedividervisibility)||  
|[CPaneContainer::Copy](#cpanecontainer__copy)||  
|[CPaneContainer::DeletePane](#cpanecontainer__deletepane)||  
|[CPaneContainer::FindSubPaneContainer](#cpanecontainer__findsubpanecontainer)||  
|[CPaneContainer::FindTabbedPane](#cpanecontainer__findtabbedpane)||  
|[CPaneContainer::GetAssociatedSiblingPaneIDs](#cpanecontainer__getassociatedsiblingpaneids)||  
|[CPaneContainer::GetLeftPane](#cpanecontainer__getleftpane)||  
|[CPaneContainer::GetLeftPaneContainer](#cpanecontainer__getleftpanecontainer)||  
|[CPaneContainer::GetMinSize](#cpanecontainer__getminsize)||  
|[CPaneContainer::GetMinSizeLeft](#cpanecontainer__getminsizeleft)||  
|[CPaneContainer::GetMinSizeRight](#cpanecontainer__getminsizeright)||  
|[CPaneContainer::GetNodeCount](#cpanecontainer__getnodecount)||  
|[CPaneContainer::GetPaneDivider](#cpanecontainer__getpanedivider)||  
|[CPaneContainer::GetParentPaneContainer](#cpanecontainer__getparentpanecontainer)||  
|[CPaneContainer::GetRecentPaneDividerRect](#cpanecontainer__getrecentpanedividerrect)||  
|[CPaneContainer::GetRecentPaneDividerStyle](#cpanecontainer__getrecentpanedividerstyle)||  
|[CPaneContainer::GetRecentPercent](#cpanecontainer__getrecentpercent)||  
|[CPaneContainer::GetRefCount](#cpanecontainer__getrefcount)||  
|[CPaneContainer::GetResizeStep](#cpanecontainer__getresizestep)||  
|[CPaneContainer::GetRightPane](#cpanecontainer__getrightpane)||  
|[CPaneContainer::GetRightPaneContainer](#cpanecontainer__getrightpanecontainer)||  
|[CPaneContainer::GetTotalReferenceCount](#cpanecontainer__gettotalreferencecount)||  
|[CPaneContainer::GetWindowRect](#cpanecontainer__getwindowrect)||  
|[CPaneContainer::IsDisposed](#cpanecontainer__isdisposed)||  
|[CPaneContainer::IsEmpty](#cpanecontainer__isempty)||  
|[CPaneContainer::IsLeftPane](#cpanecontainer__isleftpane)||  
|[CPaneContainer::IsLeftPaneContainer](#cpanecontainer__isleftpanecontainer)||  
|[CPaneContainer::IsLeftPartEmpty](#cpanecontainer__isleftpartempty)||  
|[CPaneContainer::IsRightPartEmpty](#cpanecontainer__isrightpartempty)||  
|[CPaneContainer::IsVisible](#cpanecontainer__isvisible)||  
|[CPaneContainer::Move](#cpanecontainer__move)||  
|[CPaneContainer::OnDeleteHidePane](#cpanecontainer__ondeletehidepane)||  
|[CPaneContainer::OnMoveInternalPaneDivider](#cpanecontainer__onmoveinternalpanedivider)||  
|[CPaneContainer::OnShowPane](#cpanecontainer__onshowpane)||  
|[CPaneContainer::Release](#cpanecontainer__release)||  
|[CPaneContainer::ReleaseEmptyPaneContainer](#cpanecontainer__releaseemptypanecontainer)||  
|[CPaneContainer::RemoveNonValidPanes](#cpanecontainer__removenonvalidpanes)||  
|[CPaneContainer::RemovePane](#cpanecontainer__removepane)||  
|[CPaneContainer::Resize](#cpanecontainer__resize)||  
|[CPaneContainer::ResizePane](#cpanecontainer__resizepane)||  
|[CPaneContainer::ResizePartOfPaneContainer](#cpanecontainer__resizepartofpanecontainer)||  
|[CPaneContainer::Serialize](#cpanecontainer__serialize)|Reads or writes this object from or to an archive. (Overrides [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize).)|  
|[CPaneContainer::SetPane](#cpanecontainer__setpane)||  
|[CPaneContainer::SetPaneContainer](#cpanecontainer__setpanecontainer)||  
|[CPaneContainer::SetPaneDivider](#cpanecontainer__setpanedivider)||  
|[CPaneContainer::SetParentPaneContainer](#cpanecontainer__setparentpanecontainer)||  
|[CPaneContainer::SetRecentPercent](#cpanecontainer__setrecentpercent)||  
|[CPaneContainer::SetUpByID](#cpanecontainer__setupbyid)||  
|[CPaneContainer::StoreRecentDockSiteInfo](#cpanecontainer__storerecentdocksiteinfo)||  
|[CPaneContainer::StretchPaneContainer](#cpanecontainer__stretchpanecontainer)||  
  
### Remarks  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> objects are created automatically by the framework.  
  
## Example  
 The following example demonstrates how to construct an instance of the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> class. This code snippet is part of the [Set Pane Size sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_SetPaneSize#2](../vs140/codesnippet/CPP/cpanecontainer-class_1.h)]  
[!code[NVC_MFC_SetPaneSize#1](../vs140/codesnippet/CPP/cpanecontainer-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CPaneContainer](../vs140/cpanecontainer-class.md)  
  
## Requirements  
 **Header:** afxpanecontainer.h  
  
##  \<a name="cpanecontainer__addpane">\</a>  CPaneContainer::AddPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__addref">\</a>  CPaneContainer::AddRef  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainer__addsubpanecontainer">\</a>  CPaneContainer::AddSubPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__calcavailablepanespace">\</a>  CPaneContainer::CalcAvailablePaneSpace  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__calcavailablespace">\</a>  CPaneContainer::CalcAvailableSpace  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__calculaterecentsize">\</a>  CPaneContainer::CalculateRecentSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainer__checkpanedividervisibility">\</a>  CPaneContainer::CheckPaneDividerVisibility  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainer__copy">\</a>  CPaneContainer::Copy  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__cpanecontainer">\</a>  CPaneContainer::CPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__deletepane">\</a>  CPaneContainer::DeletePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__findsubpanecontainer">\</a>  CPaneContainer::FindSubPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__findtabbedpane">\</a>  CPaneContainer::FindTabbedPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getassociatedsiblingpaneids">\</a>  CPaneContainer::GetAssociatedSiblingPaneIDs  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getleftpane">\</a>  CPaneContainer::GetLeftPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getleftpanecontainer">\</a>  CPaneContainer::GetLeftPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getminsize">\</a>  CPaneContainer::GetMinSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__getminsizeleft">\</a>  CPaneContainer::GetMinSizeLeft  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__getminsizeright">\</a>  CPaneContainer::GetMinSizeRight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__getnodecount">\</a>  CPaneContainer::GetNodeCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getpanedivider">\</a>  CPaneContainer::GetPaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getparentpanecontainer">\</a>  CPaneContainer::GetParentPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getrecentpanedividerrect">\</a>  CPaneContainer::GetRecentPaneDividerRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getrecentpanedividerstyle">\</a>  CPaneContainer::GetRecentPaneDividerStyle  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getrecentpercent">\</a>  CPaneContainer::GetRecentPercent  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getrefcount">\</a>  CPaneContainer::GetRefCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getresizestep">\</a>  CPaneContainer::GetResizeStep  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getrightpane">\</a>  CPaneContainer::GetRightPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getrightpanecontainer">\</a>  CPaneContainer::GetRightPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__gettotalreferencecount">\</a>  CPaneContainer::GetTotalReferenceCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__getwindowrect">\</a>  CPaneContainer::GetWindowRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__isdisposed">\</a>  CPaneContainer::IsDisposed  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__isempty">\</a>  CPaneContainer::IsEmpty  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__isleftpane">\</a>  CPaneContainer::IsLeftPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__isleftpanecontainer">\</a>  CPaneContainer::IsLeftPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__isleftpartempty">\</a>  CPaneContainer::IsLeftPartEmpty  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__isrightpartempty">\</a>  CPaneContainer::IsRightPartEmpty  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__isvisible">\</a>  CPaneContainer::IsVisible  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__move">\</a>  CPaneContainer::Move  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__ondeletehidepane">\</a>  CPaneContainer::OnDeleteHidePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__onmoveinternalpanedivider">\</a>  CPaneContainer::OnMoveInternalPaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__onshowpane">\</a>  CPaneContainer::OnShowPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__release">\</a>  CPaneContainer::Release  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__releaseemptypanecontainer">\</a>  CPaneContainer::ReleaseEmptyPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainer__removenonvalidpanes">\</a>  CPaneContainer::RemoveNonValidPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainer__removepane">\</a>  CPaneContainer::RemovePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__resize">\</a>  CPaneContainer::Resize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__resizepane">\</a>  CPaneContainer::ResizePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__resizepartofpanecontainer">\</a>  CPaneContainer::ResizePartOfPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__serialize">\</a>  CPaneContainer::Serialize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__setpane">\</a>  CPaneContainer::SetPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__setpanecontainer">\</a>  CPaneContainer::SetPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__setpanedivider">\</a>  CPaneContainer::SetPaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__setparentpanecontainer">\</a>  CPaneContainer::SetParentPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__setrecentpercent">\</a>  CPaneContainer::SetRecentPercent  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__setupbyid">\</a>  CPaneContainer::SetUpByID  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainer__storerecentdocksiteinfo">\</a>  CPaneContainer::StoreRecentDockSiteInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainer__stretchpanecontainer">\</a>  CPaneContainer::StretchPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CObject](../vs140/cobject-class.md)   
 [CPaneContainerManager](../vs140/cpanecontainermanager-class.md)