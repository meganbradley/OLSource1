---
title: "CMFCAutoHideBar Class"
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
  - "CMFCAutoHideBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCAutoHideToolBar class"
ms.assetid: 54c8d84f-de64-4efd-8a47-3ea0ade40a70
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideBar Class
The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class is a special toolbar class that implements the auto-hide feature.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCAutoHideBar::CMFCAutoHideBar](#cmfcautohidebar__cmfcautohidebar)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCAutoHideBar::AddAutoHideWindow](#cmfcautohidebar__addautohidewindow)||  
|[CMFCAutoHideBar::AllowShowOnPaneMenu](#cmfcautohidebar__allowshowonpanemenu)|(Overrides <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.)|  
|[CMFCAutoHideBar::CalcFixedLayout](#cmfcautohidebar__calcfixedlayout)|(Overrides [CBasePane::CalcFixedLayout](../vs140/cbasepane-class.md#cbasepane__calcfixedlayout).)|  
|[CMFCAutoHideBar::Create](#cmfcautohidebar__create)|Creates a control bar and attaches it to the [CPane](../vs140/cpane-class.md) object. (Overrides [CPane::Create](../vs140/cpane-class.md#cpane__create).)|  
|[CMFCAutoHideBar::GetFirstAHWindow](#cmfcautohidebar__getfirstahwindow)||  
|[CMFCAutoHideBar::GetVisibleCount](#cmfcautohidebar__getvisiblecount)||  
|[CMFCAutoHideBar::OnShowControlBarMenu](#cmfcautohidebar__onshowcontrolbarmenu)|Called by the framework when a special pane menu is about to be displayed. (Overrides [CPane::OnShowControlBarMenu](../vs140/cpane-class.md#cpane__onshowcontrolbarmenu).)|  
|[CMFCAutoHideBar::RemoveAutoHideWindow](#cmfcautohidebar__removeautohidewindow)||  
|[CMFCAutoHideBar::SetActiveInGroup](#cmfcautohidebar__setactiveingroup)|(Overrides [CPane::SetActiveInGroup](../vs140/cpane-class.md#cpane__setactiveingroup).)|  
|[CMFCAutoHideBar::SetRecentVisibleState](#cmfcautohidebar__setrecentvisiblestate)||  
|[CMFCAutoHideBar::ShowAutoHideWindow](#cmfcautohidebar__showautohidewindow)||  
|[CMFCAutoHideBar::StretchPane](#cmfcautohidebar__stretchpane)|Stretches a pane vertically or horizontally. (Overrides [CBasePane::StretchPane](../vs140/cbasepane-class.md#cbasepane__stretchpane).)|  
|[CMFCAutoHideBar::UnSetAutoHideMode](#cmfcautohidebar__unsetautohidemode)||  
|[CMFCAutoHideBar::UpdateVisibleState](#cmfcautohidebar__updatevisiblestate)||  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCAutoHideBar::m_nShowAHWndDelay](#cmfcautohidebar__m_nshowahwnddelay)|The time delay between the moment when the user places the mouse cursor over a [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md) and the moment when the framework shows the associated window.|  
  
## Remarks  
 When the user switches a dock pane to auto-hide mode, the framework automatically creates a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object. It also creates the necessary [CAutoHideDockSite](../vs140/cautohidedocksite-class.md) and [CMFCAutoHideButton](../vs140/cmfcautohidebutton-class.md) objects. Each <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object is associated with an individual <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class implements the display of a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> when a user's mouse hovers over a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. When the toolbar receives a WM_MOUSEMOVE message, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> starts a timer. When the timer finishes, it sends the toolbar a WM_TIMER event notification. The toolbar handles this event by checking whether the mouse pointer is positioned over the same auto-hide button that it was positioned over when the timer started. If it is, the attached <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is displayed.  
  
 You can control the length of the timer's delay by setting <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. The default value is 400 ms.  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object and use its <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method.  
  
 [!code[NVC_MFC_RibbonApp#26](../vs140/codesnippet/CPP/cmfcautohidebar-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md)  
  
## Requirements  
 **Header:** afxautohidebar.h  
  
##  \<a name="cmfcautohidebar__addautohidewindow">\</a>  CMFCAutoHideBar::AddAutoHideWindow  
 Adds functionality to a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> window that enables it to auto-hide.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The window that you want to hide.  
  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A value that specifies the alignment of the auto-hide button with the application window.  
  
### Return Value  
  
### Remarks  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter indicates where the auto-hide button resides in the application. The parameter can be any one of the following values:  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
##  \<a name="cmfcautohidebar__allowshowonpanemenu">\</a>  CMFCAutoHideBar::AllowShowOnPaneMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__calcfixedlayout">\</a>  CMFCAutoHideBar::CalcFixedLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__cmfcautohidebar">\</a>  CMFCAutoHideBar::CMFCAutoHideBar  
 Constructs a CMFCAutoHideBar object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcautohidebar__create">\</a>  CMFCAutoHideBar::Create  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__getfirstahwindow">\</a>  CMFCAutoHideBar::GetFirstAHWindow  
 Returns a pointer to the first auto-hide window in the application.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The first auto-hide window in the application, or NULL if there isn't one.  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__getvisiblecount">\</a>  CMFCAutoHideBar::GetVisibleCount  
 Gets the number of visible auto-hide buttons.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of visible auto-hide buttons.  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__m_nshowahwnddelay">\</a>  CMFCAutoHideBar::m_nShowAHWndDelay  
 The time delay between the moment when the user places the mouse cursor over a [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md) and the moment when the framework shows the associated window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 When the user places the mouse cursor over a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, there is a slight delay before the framework displays the associated window. This parameter determines the length of that delay in milliseconds.  
  
##  \<a name="cmfcautohidebar__onshowcontrolbarmenu">\</a>  CMFCAutoHideBar::OnShowControlBarMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__removeautohidewindow">\</a>  CMFCAutoHideBar::RemoveAutoHideWindow  
 Removes and destroys the auto-hide window.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 CDockablePane* <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The auto-hide window to remove.  
  
### Return Value  
 TRUE if successful; otherwise FALSE.  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__setactiveingroup">\</a>  CMFCAutoHideBar::SetActiveInGroup  
 Flags an auto-hide bar as active.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] BOOL <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 TRUE to set to active; otherwise FALSE.  
  
### Remarks  
 See [CPane::SetActiveInGroup](../vs140/cpane-class.md#cpane__setactiveingroup).  
  
##  \<a name="cmfcautohidebar__setrecentvisiblestate">\</a>  CMFCAutoHideBar::SetRecentVisibleState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__showautohidewindow">\</a>  CMFCAutoHideBar::ShowAutoHideWindow  
 Shows the auto-hide window.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] CDockablePane* <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  [in] BOOL <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 TRUE to show the window.  
  
 [in] BOOL <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 This parameter is ignored.  
  
### Return Value  
 TRUE if successful; otherwise FALSE.  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__stretchpane">\</a>  CMFCAutoHideBar::StretchPane  
 Resizes the auto-hide bar in its collapsed state to fit the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The value is unused in the base implementation. In derived implementations, use this value to indicate the length of the resized pane.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The value is unused in the base implementation. In derived implementations, use <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to handle the case where the auto-hide bar is collapsed vertically, and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> for the case where the auto-hide bar is collapsed horizontally.  
  
### Return Value  
 The resulting size of the resized pane.  
  
### Remarks  
 Derived classes can override this method to customize the behavior.  
  
##  \<a name="cmfcautohidebar__unsetautohidemode">\</a>  CMFCAutoHideBar::UnSetAutoHideMode  
 Disables auto-hide mode for a group of auto-hide bars.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] pFirstBarInGroup  
 A pointer to the first auto-hide bar in the group.  
  
### Remarks  
  
##  \<a name="cmfcautohidebar__updatevisiblestate">\</a>  CMFCAutoHideBar::UpdateVisibleState  
 Called by the framework when the auto-hide bar needs to be redrawn.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CPane Class](../vs140/cpane-class.md)   
 [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md)   
 [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md)