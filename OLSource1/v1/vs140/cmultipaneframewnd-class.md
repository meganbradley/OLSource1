---
title: "CMultiPaneFrameWnd Class"
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
  - "CMultiPaneFrameWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMultiPaneFrameWnd class"
ms.assetid: 989a548e-0d70-46b7-a513-8cf740e1be3e
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMultiPaneFrameWnd Class
The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class extends [CPaneFrameWnd](../vs140/cpaneframewnd-class.md). It can support multiple panes. Instead of a single embedded handle to a control bar, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> contains a [CPaneContainerManager](../vs140/cpanecontainermanager-class.md) object that enables the user to dock one <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to another and dynamically create multiple floating, tabbed windows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMultiPaneFrameWnd::AddPane](#cmultipaneframewnd__addpane)|Adds a pane. (Overrides [CPaneFrameWnd::AddPane](../vs140/cpaneframewnd-class.md#cpaneframewnd__addpane).)|  
|[CMultiPaneFrameWnd::AddRecentPane](#cmultipaneframewnd__addrecentpane)||  
|[CMultiPaneFrameWnd::AdjustLayout](#cmultipaneframewnd__adjustlayout)|Adjusts the layout of the mini-frame window. (Overrides [CPaneFrameWnd::AdjustLayout](../vs140/cpaneframewnd-class.md#cpaneframewnd__adjustlayout).)|  
|[CMultiPaneFrameWnd::AdjustPaneFrames](#cmultipaneframewnd__adjustpaneframes)|(Overrides [CPaneFrameWnd::AdjustPaneFrames](../vs140/cpaneframewnd-class.md#cpaneframewnd__adjustpaneframes).)|  
|[CMultiPaneFrameWnd::CalcExpectedDockedRect](#cmultipaneframewnd__calcexpecteddockedrect)|Calculates the expected rectangle of a docked window. (Overrides [CPaneFrameWnd::CalcExpectedDockedRect](../vs140/cpaneframewnd-class.md#cpaneframewnd__calcexpecteddockedrect).)|  
|[CMultiPaneFrameWnd::CanBeAttached](#cmultipaneframewnd__canbeattached)|Determines whether the current pane can dock to another pane or frame window. (Overrides [CPaneFrameWnd::CanBeAttached](../vs140/cpaneframewnd-class.md#cpaneframewnd__canbeattached).)|  
|[CMultiPaneFrameWnd::CanBeDockedToPane](#cmultipaneframewnd__canbedockedtopane)|Determines whether the mini-frame window can dock to a pane. (Overrides [CPaneFrameWnd::CanBeDockedToPane](../vs140/cpaneframewnd-class.md#cpaneframewnd__canbedockedtopane).)|  
|[CMultiPaneFrameWnd::CheckGripperVisibility](#cmultipaneframewnd__checkgrippervisibility)|(Overrides [CPaneFrameWnd::CheckGripperVisibility](../vs140/cpaneframewnd-class.md#cpaneframewnd__checkgrippervisibility).)|  
|[CMultiPaneFrameWnd::CloseMiniFrame](#cmultipaneframewnd__closeminiframe)|(Overrides <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.)|  
|[CMultiPaneFrameWnd::ConvertToTabbedDocument](#cmultipaneframewnd__converttotabbeddocument)|Converts the pane to a tabbed document. (Overrides [CPaneFrameWnd::ConvertToTabbedDocument](../vs140/cpaneframewnd-class.md#cpaneframewnd__converttotabbeddocument).)|  
|[CMultiPaneFrameWnd::DockFrame](#cmultipaneframewnd__dockframe)||  
|[CMultiPaneFrameWnd::DockPane](#cmultipaneframewnd__dockpane)|Docks the pane. (Overrides [CPaneFrameWnd::DockPane](../vs140/cpaneframewnd-class.md#cpaneframewnd__dockpane).)|  
|[CMultiPaneFrameWnd::DockRecentPaneToMainFrame](#cmultipaneframewnd__dockrecentpanetomainframe)||  
|[CMultiPaneFrameWnd::GetCaptionText](#cmultipaneframewnd__getcaptiontext)|Returns the caption text. (Overrides [CPaneFrameWnd::GetCaptionText](../vs140/cpaneframewnd-class.md#cpaneframewnd__getcaptiontext).)|  
|[CMultiPaneFrameWnd::GetContainerManager](#cmultipaneframewnd__getpanecontainermanager)|Returns a reference to the internal container manager object.|  
|[CMultiPaneFrameWnd::GetFirstVisiblePane](#cmultipaneframewnd__getfirstvisiblepane)|Returns the first visible pane that is contained in a mini-frame window. (Overrides [CPaneFrameWnd::GetFirstVisiblePane](../vs140/cpaneframewnd-class.md#cpaneframewnd__getfirstvisiblepane).)|  
|[CMultiPaneFrameWnd::GetPane](#cmultipaneframewnd__getpane)|Returns a pane that is contained in the mini-frame window. (Overrides [CPaneFrameWnd::GetPane](../vs140/cpaneframewnd-class.md#cpaneframewnd__getpane).)|  
|[CMultiPaneFrameWnd::GetPaneCount](#cmultipaneframewnd__getpanecount)|Returns the number of panes that are contained in a mini-frame window. (Overrides [CPaneFrameWnd::GetPaneCount](../vs140/cpaneframewnd-class.md#cpaneframewnd__getpanecount).)|  
|[CMultiPaneFrameWnd::GetVisiblePaneCount](#cmultipaneframewnd__getvisiblepanecount)|Returns the number of visible panes that are contained in a mini-frame window. (Overrides [CPaneFrameWnd::GetVisiblePaneCount](../vs140/cpaneframewnd-class.md#cpaneframewnd__getvisiblepanecount).)|  
|[CMultiPaneFrameWnd::InsertPane](#cmultipaneframewnd__insertpane)||  
|[CMultiPaneFrameWnd::LoadState](#cmultipaneframewnd__loadstate)|Loads the pane's state from the registry. (Overrides [CPaneFrameWnd::LoadState](../vs140/cpaneframewnd-class.md#cpaneframewnd__loadstate).)|  
|[CMultiPaneFrameWnd::OnDockToRecentPos](#cmultipaneframewnd__ondocktorecentpos)|Docks the mini-frame window at its most recent position. (Overrides [CPaneFrameWnd::OnDockToRecentPos](../vs140/cpaneframewnd-class.md#cpaneframewnd__ondocktorecentpos).)|  
|[CMultiPaneFrameWnd::OnKillRollUpTimer](#cmultipaneframewnd__onkillrolluptimer)|Stops the rollup timer. (Overrides [CPaneFrameWnd::OnKillRollUpTimer](../vs140/cpaneframewnd-class.md#cpaneframewnd__onkillrolluptimer).)|  
|[CMultiPaneFrameWnd::OnPaneRecalcLayout](#cmultipaneframewnd__onpanerecalclayout)|Adjusts the layout of a pane inside a mini-frame window. (Overrides [CPaneFrameWnd::OnPaneRecalcLayout](../vs140/cpaneframewnd-class.md#cpaneframewnd__onpanerecalclayout).)|  
|[CMultiPaneFrameWnd::OnSetRollUpTimer](#cmultipaneframewnd__onsetrolluptimer)|Sets the rollup timer. (Overrides [CPaneFrameWnd::OnSetRollUpTimer](../vs140/cpaneframewnd-class.md#cpaneframewnd__onsetrolluptimer).)|  
|[CMultiPaneFrameWnd::OnShowPane](#cmultipaneframewnd__onshowpane)|Called by the framework when a pane in the mini-frame window is hidden or displayed. (Overrides [CPaneFrameWnd::OnShowPane](../vs140/cpaneframewnd-class.md#cpaneframewnd__onshowpane).)|  
|[CMultiPaneFrameWnd::PaneFromPoint](#cmultipaneframewnd__panefrompoint)|Returns a pane if it contains a user-supplied point inside a mini-frame window. (Overrides [CPaneFrameWnd::PaneFromPoint](../vs140/cpaneframewnd-class.md#cpaneframewnd__panefrompoint).)|  
|[CMultiPaneFrameWnd::RemoveNonValidPanes](#cmultipaneframewnd__removenonvalidpanes)|Called by the framework to remove non-valid panes. (Overrides [CPaneFrameWnd::RemoveNonValidPanes](../vs140/cpaneframewnd-class.md#cpaneframewnd__removenonvalidpanes).)|  
|[CMultiPaneFrameWnd::RemovePane](#cmultipaneframewnd__removepane)|Removes a pane from the mini-frame window. (Overrides [CPaneFrameWnd::RemovePane](../vs140/cpaneframewnd-class.md#cpaneframewnd__removepane).)|  
|[CMultiPaneFrameWnd::ReplacePane](#cmultipaneframewnd__replacepane)|Replaces one pane with another. (Overrides [CPaneFrameWnd::ReplacePane](../vs140/cpaneframewnd-class.md#cpaneframewnd__replacepane).)|  
|[CMultiPaneFrameWnd::SaveState](#cmultipaneframewnd__savestate)|Saves the pane's state to the registry. (Overrides [CPaneFrameWnd::SaveState](../vs140/cpaneframewnd-class.md#cpaneframewnd__savestate).)|  
|[CMultiPaneFrameWnd::Serialize](#cmultipaneframewnd__serialize)|(Overrides <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.)|  
|[CMultiPaneFrameWnd::SetDockState](#cmultipaneframewnd__setdockstate)|Sets the docking state. (Overrides [CPaneFrameWnd::SetDockState](../vs140/cpaneframewnd-class.md#cpaneframewnd__setdockstate).)|  
|[CMultiPaneFrameWnd::SetLastFocusedPane](#cmultipaneframewnd__setlastfocusedpane)||  
|[CMultiPaneFrameWnd::SetPreDockState](#cmultipaneframewnd__setpredockstate)|Sets the predocking state. (Overrides [CPaneFrameWnd::SetPreDockState](../vs140/cpaneframewnd-class.md#cpaneframewnd__setpredockstate).)|  
|[CMultiPaneFrameWnd::StoreRecentDockSiteInfo](#cmultipaneframewnd__storerecentdocksiteinfo)|(Overrides [CPaneFrameWnd::StoreRecentDockSiteInfo](../vs140/cpaneframewnd-class.md#cpaneframewnd__storerecentdocksiteinfo).)|  
|[CMultiPaneFrameWnd::StoreRecentTabRelatedInfo](#cmultipaneframewnd__storerecenttabrelatedinfo)|(Overrides [CPaneFrameWnd::StoreRecentTabRelatedInfo](../vs140/cpaneframewnd-class.md#cpaneframewnd__storerecenttabrelatedinfo).)|  
  
## Remarks  
 Most of the methods in this class override methods in the [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) class.  
  
 If a pane uses the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> style and the user docks that pane to a multi-pane frame window, the user can roll up the window regardless of the style settings of the other docked panes.  
  
 The framework automatically creates a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object when the user floats a pane that uses the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> style.  
  
 For information about deriving a class from the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> class and creating it dynamically, see [CPaneFrameWnd](../vs140/cpaneframewnd-class.md).  
  
## Example  
 The following example demonstrates how to retrieve a pointer to a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. This code snippet is part of the [Set Pane Size sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_SetPaneSize#4](../vs140/codesnippet/CPP/cmultipaneframewnd-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CPaneFrameWnd](../vs140/cpaneframewnd-class.md)  
  
 [CMultiPaneFrameWnd](../vs140/cmultipaneframewnd-class.md)  
  
## Requirements  
 **Header:** afxMultiPaneFrameWnd.h  
  
##  \<a name="cmultipaneframewnd__addpane">\</a>  CMultiPaneFrameWnd::AddPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__addrecentpane">\</a>  CMultiPaneFrameWnd::AddRecentPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__adjustlayout">\</a>  CMultiPaneFrameWnd::AdjustLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__adjustpaneframes">\</a>  CMultiPaneFrameWnd::AdjustPaneFrames  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__calcexpecteddockedrect">\</a>  CMultiPaneFrameWnd::CalcExpectedDockedRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__canbeattached">\</a>  CMultiPaneFrameWnd::CanBeAttached  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__canbedockedtopane">\</a>  CMultiPaneFrameWnd::CanBeDockedToPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__checkgrippervisibility">\</a>  CMultiPaneFrameWnd::CheckGripperVisibility  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__closeminiframe">\</a>  CMultiPaneFrameWnd::CloseMiniFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__converttotabbeddocument">\</a>  CMultiPaneFrameWnd::ConvertToTabbedDocument  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__dockframe">\</a>  CMultiPaneFrameWnd::DockFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__dockpane">\</a>  CMultiPaneFrameWnd::DockPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__dockrecentpanetomainframe">\</a>  CMultiPaneFrameWnd::DockRecentPaneToMainFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__getcaptiontext">\</a>  CMultiPaneFrameWnd::GetCaptionText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__getfirstvisiblepane">\</a>  CMultiPaneFrameWnd::GetFirstVisiblePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__getpane">\</a>  CMultiPaneFrameWnd::GetPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__getpanecontainermanager">\</a>  CMultiPaneFrameWnd::GetPaneContainerManager  
 Returns a reference to the internal container manager object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the internal container manager object.  
  
### Remarks  
 This method can be used to access the internal [container manager](../vs140/cpanecontainermanager-class.md) object.  
  
##  \<a name="cmultipaneframewnd__getpanecount">\</a>  CMultiPaneFrameWnd::GetPaneCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__getvisiblepanecount">\</a>  CMultiPaneFrameWnd::GetVisiblePaneCount  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__insertpane">\</a>  CMultiPaneFrameWnd::InsertPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__loadstate">\</a>  CMultiPaneFrameWnd::LoadState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__ondocktorecentpos">\</a>  CMultiPaneFrameWnd::OnDockToRecentPos  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__onkillrolluptimer">\</a>  CMultiPaneFrameWnd::OnKillRollUpTimer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__onpanerecalclayout">\</a>  CMultiPaneFrameWnd::OnPaneRecalcLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__onsetrolluptimer">\</a>  CMultiPaneFrameWnd::OnSetRollUpTimer  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__onshowpane">\</a>  CMultiPaneFrameWnd::OnShowPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__panefrompoint">\</a>  CMultiPaneFrameWnd::PaneFromPoint  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__removenonvalidpanes">\</a>  CMultiPaneFrameWnd::RemoveNonValidPanes  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmultipaneframewnd__removepane">\</a>  CMultiPaneFrameWnd::RemovePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__replacepane">\</a>  CMultiPaneFrameWnd::ReplacePane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__savestate">\</a>  CMultiPaneFrameWnd::SaveState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__serialize">\</a>  CMultiPaneFrameWnd::Serialize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__setdockstate">\</a>  CMultiPaneFrameWnd::SetDockState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__setlastfocusedpane">\</a>  CMultiPaneFrameWnd::SetLastFocusedPane  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__setpredockstate">\</a>  CMultiPaneFrameWnd::SetPreDockState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__storerecentdocksiteinfo">\</a>  CMultiPaneFrameWnd::StoreRecentDockSiteInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmultipaneframewnd__storerecenttabrelatedinfo">\</a>  CMultiPaneFrameWnd::StoreRecentTabRelatedInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CPaneFrameWnd](../vs140/cpaneframewnd-class.md)