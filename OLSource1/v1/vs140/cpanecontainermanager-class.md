---
title: "CPaneContainerManager Class"
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
  - "CPaneContainerManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPaneContainerManager class"
ms.assetid: 3d974c15-a62f-4648-bb5b-cc31ab7950af
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneContainerManager Class
The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> class manages the storage and display of the current docking layout.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneContainerManager::AddPane](#cpanecontainermanager__addpane)||  
|[CPaneContainerManager::AddPaneContainerManager](#cpanecontainermanager__addpanecontainermanager)||  
|[CPaneContainerManager::AddPaneContainerManagerToDockablePane](#cpanecontainermanager__addpanecontainermanagertodockablepane)||  
|[CPaneContainerManager::AddPanesToList](#cpanecontainermanager__addpanestolist)||  
|[CPaneContainerManager::AddPaneToList](#cpanecontainermanager__addpanetolist)||  
|[CPaneContainerManager::AddPaneToRecentPaneContainer](#cpanecontainermanager__addpanetorecentpanecontainer)||  
|[CPaneContainerManager::CalcRects](#cpanecontainermanager__calcrects)||  
|[CPaneContainerManager::CanBeAttached](#cpanecontainermanager__canbeattached)||  
|[CPaneContainerManager::CheckAndRemoveNonValidPane](#cpanecontainermanager__checkandremovenonvalidpane)||  
|[CPaneContainerManager::CheckForMiniFrameAndCaption](#cpanecontainermanager__checkforminiframeandcaption)||  
|[CPaneContainerManager::Create](#cpanecontainermanager__create)||  
|[CPaneContainerManager::DoesAllowDynInsertBefore](#cpanecontainermanager__doesallowdyninsertbefore)||  
|[CPaneContainerManager::DoesContainFloatingPane](#cpanecontainermanager__doescontainfloatingpane)||  
|[CPaneContainerManager::EnableGrippers](#cpanecontainermanager__enablegrippers)||  
|[CPaneContainerManager::FindPaneContainer](#cpanecontainermanager__findpanecontainer)||  
|[CPaneContainerManager::FindTabbedPane](#cpanecontainermanager__findtabbedpane)||  
|[CPaneContainerManager::GetAvailableSpace](#cpanecontainermanager__getavailablespace)||  
|[CPaneContainerManager::GetDefaultPaneDivider](#cpanecontainermanager__getdefaultpanedivider)||  
|[CPaneContainerManager::GetDockSiteFrameWnd](#cpanecontainermanager__getdocksiteframewnd)||  
|[CPaneContainerManager::GetFirstPane](#cpanecontainermanager__getfirstpane)||  
|[CPaneContainerManager::GetFirstVisiblePane](#cpanecontainermanager__getfirstvisiblepane)||  
|[CPaneContainerManager::GetMinMaxOffset](#cpanecontainermanager__getminmaxoffset)||  
|[CPaneContainerManager::GetMinSize](#cpanecontainermanager__getminsize)||  
|[CPaneContainerManager::GetNodeCount](#cpanecontainermanager__getnodecount)||  
|[CPaneContainerManager::GetPaneContainerRTC](#cpanecontainermanager__getpanecontainerrtc)||  
|[CPaneContainerManager::GetPaneCount](#cpanecontainermanager__getpanecount)||  
|[CPaneContainerManager::GetTotalRefCount](#cpanecontainermanager__gettotalrefcount)||  
|[CPaneContainerManager::GetVisiblePaneCount](#cpanecontainermanager__getvisiblepanecount)||  
|[CPaneContainerManager::GetWindowRect](#cpanecontainermanager__getwindowrect)||  
|[CPaneContainerManager::HideAll](#cpanecontainermanager__hideall)||  
|[CPaneContainerManager::InsertPane](#cpanecontainermanager__insertpane)||  
|[CPaneContainerManager::IsAutoHideMode](#cpanecontainermanager__isautohidemode)||  
|[CPaneContainerManager::IsEmpty](#cpanecontainermanager__isempty)||  
|[CPaneContainerManager::IsRootPaneContainerVisible](#cpanecontainermanager__isrootpanecontainervisible)||  
|[CPaneContainerManager::NotifyPaneDivider](#cpanecontainermanager__notifypanedivider)||  
|[CPaneContainerManager::OnPaneDividerMove](#cpanecontainermanager__onpanedividermove)||  
|[CPaneContainerManager::OnShowPane](#cpanecontainermanager__onshowpane)||  
|[CPaneContainerManager::PaneFromPoint](#cpanecontainermanager__panefrompoint)||  
|[CPaneContainerManager::ReleaseEmptyPaneContainers](#cpanecontainermanager__releaseemptypanecontainers)||  
|[CPaneContainerManager::RemoveAllPanesAndPaneDividers](#cpanecontainermanager__removeallpanesandpanedividers)||  
|[CPaneContainerManager::RemoveNonValidPanes](#cpanecontainermanager__removenonvalidpanes)||  
|[CPaneContainerManager::RemovePaneDivider](#cpanecontainermanager__removepanedivider)||  
|[CPaneContainerManager::RemovePaneFromPaneContainer](#cpanecontainermanager__removepanefrompanecontainer)||  
|[CPaneContainerManager::ReplacePane](#cpanecontainermanager__replacepane)||  
|[CPaneContainerManager::ResizePaneContainers](#cpanecontainermanager__resizepanecontainers)||  
|[CPaneContainerManager::Serialize](#cpanecontainermanager__serialize)|Reads or writes this object from or to an archive. (Overrides [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize).)|  
|[CPaneContainerManager::SetDefaultPaneDividerForPanes](#cpanecontainermanager__setdefaultpanedividerforpanes)||  
|[CPaneContainerManager::SetPaneContainerRTC](#cpanecontainermanager__setpanecontainerrtc)||  
|[CPaneContainerManager::SetResizeMode](#cpanecontainermanager__setresizemode)||  
|[CPaneContainerManager::StoreRecentDockSiteInfo](#cpanecontainermanager__storerecentdocksiteinfo)||  
  
### Remarks  
 The framework automatically creates instances of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> objects and embeds them either into [CPaneDivider](../vs140/cpanedivider-class.md) objects or into [CMultiPaneFrameWnd](../vs140/cmultipaneframewnd-class.md) objects.  
  
 The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> class stores a pointer to the root of a binary tree that is built from [CPaneContainer](../vs140/cpanecontainer-class.md) objects.  
  
## Example  
 The following example demonstrates how to get a reference to a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object. This code snippet is part of the [Set Pane Size sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_SetPaneSize#5](../vs140/codesnippet/CPP/cpanecontainermanager-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CPaneContainerManager](../vs140/cpanecontainermanager-class.md)  
  
## Requirements  
 **Header:** afxpanecontainermanager.h  
  
##  \<a name="cpanecontainermanager__addpane">\</a>  CPaneContainerManager::AddPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__addpanecontainermanager">\</a>  CPaneContainerManager::AddPaneContainerManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__addpanecontainermanagertodockablepane">\</a>  CPaneContainerManager::AddPaneContainerManagerToDockablePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__addpanestolist">\</a>  CPaneContainerManager::AddPanesToList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__addpanetolist">\</a>  CPaneContainerManager::AddPaneToList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__addpanetorecentpanecontainer">\</a>  CPaneContainerManager::AddPaneToRecentPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__calcrects">\</a>  CPaneContainerManager::CalcRects  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__canbeattached">\</a>  CPaneContainerManager::CanBeAttached  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__checkandremovenonvalidpane">\</a>  CPaneContainerManager::CheckAndRemoveNonValidPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__checkforminiframeandcaption">\</a>  CPaneContainerManager::CheckForMiniFrameAndCaption  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__create">\</a>  CPaneContainerManager::Create  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__doesallowdyninsertbefore">\</a>  CPaneContainerManager::DoesAllowDynInsertBefore  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__doescontainfloatingpane">\</a>  CPaneContainerManager::DoesContainFloatingPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__enablegrippers">\</a>  CPaneContainerManager::EnableGrippers  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__findpanecontainer">\</a>  CPaneContainerManager::FindPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__findtabbedpane">\</a>  CPaneContainerManager::FindTabbedPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getavailablespace">\</a>  CPaneContainerManager::GetAvailableSpace  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getdefaultpanedivider">\</a>  CPaneContainerManager::GetDefaultPaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getdocksiteframewnd">\</a>  CPaneContainerManager::GetDockSiteFrameWnd  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getfirstpane">\</a>  CPaneContainerManager::GetFirstPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getfirstvisiblepane">\</a>  CPaneContainerManager::GetFirstVisiblePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getminmaxoffset">\</a>  CPaneContainerManager::GetMinMaxOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getminsize">\</a>  CPaneContainerManager::GetMinSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getnodecount">\</a>  CPaneContainerManager::GetNodeCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getpanecontainerrtc">\</a>  CPaneContainerManager::GetPaneContainerRTC  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getpanecount">\</a>  CPaneContainerManager::GetPaneCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__gettotalrefcount">\</a>  CPaneContainerManager::GetTotalRefCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getvisiblepanecount">\</a>  CPaneContainerManager::GetVisiblePaneCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__getwindowrect">\</a>  CPaneContainerManager::GetWindowRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__hideall">\</a>  CPaneContainerManager::HideAll  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainermanager__insertpane">\</a>  CPaneContainerManager::InsertPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__isautohidemode">\</a>  CPaneContainerManager::IsAutoHideMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__isempty">\</a>  CPaneContainerManager::IsEmpty  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__isrootpanecontainervisible">\</a>  CPaneContainerManager::IsRootPaneContainerVisible  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__notifypanedivider">\</a>  CPaneContainerManager::NotifyPaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainermanager__onpanedividermove">\</a>  CPaneContainerManager::OnPaneDividerMove  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__onshowpane">\</a>  CPaneContainerManager::OnShowPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__panefrompoint">\</a>  CPaneContainerManager::PaneFromPoint  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__releaseemptypanecontainers">\</a>  CPaneContainerManager::ReleaseEmptyPaneContainers  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainermanager__removeallpanesandpanedividers">\</a>  CPaneContainerManager::RemoveAllPanesAndPaneDividers  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainermanager__removenonvalidpanes">\</a>  CPaneContainerManager::RemoveNonValidPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cpanecontainermanager__removepanedivider">\</a>  CPaneContainerManager::RemovePaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__removepanefrompanecontainer">\</a>  CPaneContainerManager::RemovePaneFromPaneContainer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__replacepane">\</a>  CPaneContainerManager::ReplacePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__resizepanecontainers">\</a>  CPaneContainerManager::ResizePaneContainers  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__serialize">\</a>  CPaneContainerManager::Serialize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__setdefaultpanedividerforpanes">\</a>  CPaneContainerManager::SetDefaultPaneDividerForPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__setpanecontainerrtc">\</a>  CPaneContainerManager::SetPaneContainerRTC  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__setresizemode">\</a>  CPaneContainerManager::SetResizeMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cpanecontainermanager__storerecentdocksiteinfo">\</a>  CPaneContainerManager::StoreRecentDockSiteInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CObject](../vs140/cobject-class.md)   
 [CPaneContainer](../vs140/cpanecontainer-class.md)   
 [CPaneDivider](../vs140/cpanedivider-class.md)