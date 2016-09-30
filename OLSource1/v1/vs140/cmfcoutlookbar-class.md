---
title: "CMFCOutlookBar Class"
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
  - "CMFCOutlookBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCOutlookBar class"
ms.assetid: 2b335f71-ce99-4efd-b103-e65ba43ffc36
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBar Class
A tabbed pane with the visual appearance of the **Navigation Pane** in Microsoft Outlook 2000 or Outlook 2003. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object contains a [CMFCOutlookBarTabCtrl](../vs140/cmfcoutlookbartabctrl-class.md) object and a series of tabs. The tabs can be either [CMFCOutlookBarPane](../vs140/cmfcoutlookbarpane-class.md) objects or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>-derived objects. To the user, the Outlook bar appears as a series of buttons and a display area. When the user clicks a button, the corresponding control or button pane is displayed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCOutlookBar::AllowDestroyEmptyTabbedPane](#cmfcoutlookbar__allowdestroyemptytabbedpane)|Specifies whether an empty tabbed pane can be destroyed. (Overrides [CBaseTabbedPane::AllowDestroyEmptyTabbedPane](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__allowdestroyemptytabbedpane).)|  
|[CMFCOutlookBar::CanAcceptPane](#cmfcoutlookbar__canacceptpane)|Determines whether another pane can be docked to the Outlook bar pane. (Overrides CDockablePane::CanAcceptPane.)|  
|[CMFCOutlookBar::CanSetCaptionTextToTabName](#cmfcoutlookbar__cansetcaptiontexttotabname)|Determines whether the caption for the tabbed pane displays the same text as the active tab. (Overrides [CBaseTabbedPane::CanSetCaptionTextToTabName](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__cansetcaptiontexttotabname).)|  
|[CMFCOutlookBar::Create](#cmfcoutlookbar__create)|Creates the Outlook bar control.|  
|[CMFCOutlookBar::CreateCustomPage](#cmfcoutlookbar__createcustompage)|Creates a custom Outlook bar tab.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCOutlookBar::DoesAllowDynInsertBefore](#cmfcoutlookbar__doesallowdyninsertbefore)|Determines whether a user can dock a control bar at the outer edge of the Outlook bar.|  
|[CMFCOutlookBar::FloatTab](#cmfcoutlookbar__floattab)|Floats a pane, but only if the pane currently resides in a detachable tab. (Overrides [CBaseTabbedPane::FloatTab](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__floattab).)|  
|[CMFCOutlookBar::GetButtonsFont](#cmfcoutlookbar__getbuttonsfont)|Returns the font of the text on the buttons of the Outlook bar.|  
|[CMFCOutlookBar::GetTabArea](#cmfcoutlookbar__gettabarea)|Returns the size and position of the tab areas on the Outlook bar. (Overrides [CBaseTabbedPane::GetTabArea](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__gettabarea).)|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCOutlookBar::IsMode2003](#cmfcoutlookbar__ismode2003)|Determines whether the behavior of the Outlook bar mimics that of Microsoft Office Outlook 2003 (see Remarks).|  
|[CMFCOutlookBar::OnAfterAnimation](#cmfcoutlookbar__onafteranimation)|Called by [CMFCOutlookBarTabCtrl::SetActiveTab](../vs140/cmfcoutlookbartabctrl-class.md#cmfcoutlookbartabctrl__setactivetab) after the active tab has been set using animation.|  
|[CMFCOutlookBar::OnBeforeAnimation](#cmfcoutlookbar__onbeforeanimation)|Called by [CMFCOutlookBarTabCtrl::SetActiveTab](../vs140/cmfcoutlookbartabctrl-class.md#cmfcoutlookbartabctrl__setactivetab) before a tab page is set as the active tab using animation.|  
|[CMFCOutlookBar::OnScroll](#cmfcoutlookbar__onscroll)|Called by the framework if the Outlook bar is scrolling up or down.|  
|[CMFCOutlookBar::RemoveCustomPage](#cmfcoutlookbar__removecustompage)|Removes a custom Outlook bar tab.|  
|[CMFCOutlookBar::SetButtonsFont](#cmfcoutlookbar__setbuttonsfont)|Sets the font of the text on the buttons of the Outlook bar.|  
|[CMFCOutlookBar::SetMode2003](#cmfcoutlookbar__setmode2003)|Specifies whether the behavior of the Outlook bar mimics that of Outlook 2003 (see Remarks).|  
  
## Remarks  
 For an example of an Outlook bar, see the [OutlookDemo Sample: MFC OutlookDemo Application](../vs140/visual-c---samples.md).  
  
## Implementing the Outlook Bar  
 To use the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> control in your application, follow these steps:  
  
1.  Embed a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object into the main frame window class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  When processing the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> message in the main frame, call the [CMFCOutlookBar::Create](#cmfcoutlookbar__create) method to create the Outlook bar tab control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Obtain a pointer to the underlying <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> by using [CBaseTabbedPane::GetUnderlyingWindow](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__getunderlyingwindow).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  Create a [CMFCOutlookBarPane](../vs140/cmfcoutlookbarpane-class.md) object for each tab that contains buttons.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
5.  Call [CMFCOutlookBarTabCtrl::AddTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__addtab) to add each new tab. Set the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to make a page non-detachable. Or, use [CMFCOutlookBarTabCtrl::AddControl](../vs140/cmfcoutlookbartabctrl-class.md#cmfcoutlookbartabctrl__addcontrol) to add detachable pages.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
6.  To add a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>-derived control (for example, [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md)) as a tab, create the control and call [CMFCOutlookBarTabCtrl::AddTab](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__addtab) to add it to the Outlook bar.  
  
> [!NOTE]
>  You should use unique control IDs for each [CMFCOutlookBarPane](../vs140/cmfcoutlookbarpane-class.md) object and for each <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>-derived object.  
  
 To dynamically add or delete new pages at runtime, use [CreateCustomPage](#cmfcoutlookbar__createcustompage) and [RemoveCustomPage](#cmfcoutlookbar__removecustompage).  
  
## Outlook 2003 Mode  
 In Outlook 2003 mode, the tab buttons are positioned at the bottom of the Outlook bar pane. When there is not sufficient room to display the buttons, they are displayed as icons in a toolbar-like area along the bottom of the pane.  
  
 Use [SetMode2003](#cmfcoutlookbar__setmode2003) to enable Outlook 2003 mode. Use [CMFCOutlookBarTabCtrl::SetToolbarImageList](../vs140/cmfcoutlookbartabctrl-class.md#cmfcoutlookbartabctrl__settoolbarimagelist) to set the bitmap that contains the icons that are displayed on the bottom of the Outlook bar. The icons in the bitmap must be ordered by tab index.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CDockablePane](../vs140/cdockablepane-class.md)  
  
 [CBaseTabbedPane](../vs140/cbasetabbedpane-class.md)  
  
 [CMFCOutlookBar](../vs140/cmfcoutlookbar-class.md)  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
##  \<a name="cmfcoutlookbar__allowdestroyemptytabbedpane">\</a>  CMFCOutlookBar::AllowDestroyEmptyTabbedPane  
 Specifies whether an empty tabbed pane can be destroyed.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> if an empty tabbed pane can be destroyed; otherwise, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The default implementation always returns <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Remarks  
 If an empty tabbed pane cannot be destroyed, the framework hides it instead.  
  
##  \<a name="cmfcoutlookbar__canacceptpane">\</a>  CMFCOutlookBar::CanAcceptPane  
 Determines whether another pane can be docked to the Outlook bar pane.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to another pane that is being docked to this pane.  
  
### Return Value  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if another pane can be docked to the Outlook bar pane; otherwise <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the Outlook bar is in Outlook 2003 mode, docking is not supported, so the return value is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 If the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 Otherwise, this method behaves as the base method [CBasePane::CanAcceptPane](../vs140/cbasepane-class.md#cbasepane__canacceptpane), except that even if docking is not enabled, an Outlook bar can still enable another Outlook bar to be docked over it.  
  
##  \<a name="cmfcoutlookbar__cansetcaptiontexttotabname">\</a>  CMFCOutlookBar::CanSetCaptionTextToTabName  
 Determines whether the caption for the tabbed pane displays the same text as the active tab.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if the Outlook bar window caption is automatically set to the text of the active tab; otherwise <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use [CBaseTabbedPane::EnableSetCaptionTextToTabName](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__enablesetcaptiontexttotabname) to enable or disable this functionality.  
  
 In Outlook 2003 mode, this setting is always enabled.  
  
##  \<a name="cmfcoutlookbar__create">\</a>  CMFCOutlookBar::Create  
 Creates the Outlook bar control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Specifies the window caption.  
  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies a pointer to a parent window. It must not be NULL.  
  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies the outlook bar size and position in pixels.  
  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Specifies the control ID. Must be distinct from other control IDs used in the application.  
  
 [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Specifies the desired control bar style. For possible values, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Specifies the special library-defined styles.  
  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Create context.  
  
### Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object in two steps. First call the constructor, and then call <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, which creates the outlook bar control and attaches it to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
 See [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex) for the list of the available library-defined styles to be specified by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> class. This code snippet is part of the [Outlook Multi Views sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_OutlookMultiViews#1](../vs140/codesnippet/CPP/cmfcoutlookbar-class_1.h)]  
[!code[NVC_MFC_OutlookMultiViews#2](../vs140/codesnippet/CPP/cmfcoutlookbar-class_2.cpp)]  
  
##  \<a name="cmfcoutlookbar__createcustompage">\</a>  CMFCOutlookBar::CreateCustomPage  
 Creates a custom Outlook bar tab.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The page label.  
  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, the page becomes active upon creation.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A combination of CBRS_ALIGN_ flags that specifies the enabled docking sides when the page is detached.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, the text labels are enabled for the buttons that reside on the page.  
  
### Return Value  
 A pointer to the newly created page, or <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> if the creation failed.  
  
### Remarks  
 Use this method to enable the users to create custom Outlook bar pages. You can create up to 100 pages per application. The page control IDs start from 0xF000. The creation fails if the total number of custom Outlook bar pages exceeds 100.  
  
 Use [RemoveCustomPage](#cmfcoutlookbar__removecustompage) to delete custom pages.  
  
##  \<a name="cmfcoutlookbar__doesallowdyninsertbefore">\</a>  CMFCOutlookBar::DoesAllowDynInsertBefore  
 Specifies whether a user can dock a pane at the outer edge of the Outlook bar.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The default implementation returns <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> method when it looks for a location to dock a dynamic pane. If the function returns <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, the framework does not allow the docking of any dynamic pane at the outer edges of the pane.  
  
 Usually, you create an Outlook bar as a static non-floating control. You can override this function in a derived class and return <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to change this behavior.  
  
> [!NOTE]
>  Because dynamic panes check the status of docked static panes when docking, you should dock dynamic panes after static panes whenever possible.  
  
##  \<a name="cmfcoutlookbar__floattab">\</a>  CMFCOutlookBar::FloatTab  
 Floats a pane.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A pointer to the pane to float.  
  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The zero-based index of the tab to float.  
  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Specifies the method to use to make the pane float.  For more information, see [CBaseTabbedPane::FloatTab](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__floattab).  
  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> to hide the pane before floating; otherwise, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>. Unlike the base class version of this method, this parameter does not have a default value.  
  
### Return Value  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> if the pane floated; otherwise, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is like [CBaseTabbedPane::FloatTab](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__floattab) except that it does not enable the last remaining tab on an Outlook bar control to float.  
  
##  \<a name="cmfcoutlookbar__getbuttonsfont">\</a>  CMFCOutlookBar::GetButtonsFont  
 Returns the font of the text on the page button tabs of the Outlook bar.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the font object that is used to display text on Outlook bar page button tabs.  
  
### Remarks  
 Use this function to retrieve the font that is used to display the text on Outlook page button tabs. You can set the font by calling on [SetButtonsFont](#cmfcoutlookbar__setbuttonsfont).  
  
##  \<a name="cmfcoutlookbar__gettabarea">\</a>  CMFCOutlookBar::GetTabArea  
 Determines the size and position of the tab areas on the Outlook bar.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Contains the size and position (in the client coordinates) of the top tab area when the function returns.  
  
 [out] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 Contains the size and position (in the client coordinates) of the bottom tab area when the function returns.  
  
### Remarks  
 The framework calls this method to determine the type of docking to the target pane. When the framework determines that the user drags the pane to be docked over the tab area of the target pane, it tries to add the first pane as a new tab of the target pane. Otherwise, it tries to dock the first pane at an appropriate side of the target pane. The framework creates a new container with a slider to accommodate the additional docked pane.  
  
 The default implementation of <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> returns the whole client area of the Outlook bar if the Outlook bar is static; that is, if the Outlook bar cannot float. Otherwise, it returns the area that page buttons take at the top and bottom of the Outlook bar control.  
  
 Override this method in class derived from <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to change this behavior.  
  
##  \<a name="cmfcoutlookbar__ismode2003">\</a>  CMFCOutlookBar::IsMode2003  
 Specifies whether the behavior of the Outlook bar mimics that of Microsoft Office Outlook 2003.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the Outlook bar is running in Microsoft Office 2003 mode; otherwise 0.  
  
### Remarks  
 You can enable this mode by using [SetMode2003](#cmfcoutlookbar__setmode2003).  
  
##  \<a name="cmfcoutlookbar__onafteranimation">\</a>  CMFCOutlookBar::OnAfterAnimation  
 Called by [CMFCOutlookBarTabCtrl::SetActiveTab](../vs140/cmfcoutlookbartabctrl-class.md#cmfcoutlookbartabctrl__setactivetab) after the active tab has been set using animation.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The zero-based index of the tab page that has been made active.  
  
### Remarks  
 The visual effect of setting the active tab depends on whether you have enabled animation. For more information, see [CMFCOutlookBarTabCtrl::EnableAnimation](../vs140/cmfcoutlookbartabctrl-class.md#cmfcoutlookbartabctrl__enableanimation).  
  
##  \<a name="cmfcoutlookbar__onbeforeanimation">\</a>  CMFCOutlookBar::OnBeforeAnimation  
 Called by [CMFCOutlookBarTabCtrl::SetActiveTab](../vs140/cmfcoutlookbartabctrl-class.md#cmfcoutlookbartabctrl__setactivetab) before a tab page is set as the active tab using animation.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The zero-based index of the tab page that is about to be set active.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> if animation should be used in setting the new active tab, or <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if animation should be disabled.  
  
### Remarks  
  
##  \<a name="cmfcoutlookbar__onscroll">\</a>  CMFCOutlookBar::OnScroll  
 Called by the framework if the Outlook bar is scrolling up or down.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> if the Outlook bar is scrolling down, or <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> if it is scrolling up.  
  
### Remarks  
  
##  \<a name="cmfcoutlookbar__removecustompage">\</a>  CMFCOutlookBar::RemoveCustomPage  
 Removes a custom Outlook bar tab page.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Zero-based index of the page in the parent Outlook window.  
  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Pointerto the parent Outlook window.  
  
### Return Value  
 Nonzero if the custom page has been removed successfully; otherwise 0.  
  
### Remarks  
 Call this function to delete custom pages. When the page is removed its control ID is returned to the pool of available IDs.  
  
 You must provide a pointer to [CMFCOutlookBarTabCtrl](../vs140/cmfcoutlookbartabctrl-class.md) object in which the page to be removed currently resides. Note that a user can move detachable pages between different Outlook bars, but the information about a custom page resides in the Outlook bar object for which you have called [CreateCustomPage](#cmfcoutlookbar__createcustompage).  
  
 Use [CBaseTabbedPane::GetUnderlyingWindow](../vs140/cbasetabbedpane-class.md#cbasetabbedpane__getunderlyingwindow) to obtain a pointer to the Outlook window.  
  
##  \<a name="cmfcoutlookbar__setbuttonsfont">\</a>  CMFCOutlookBar::SetButtonsFont  
 Sets the font of the text on the buttons of the Outlook bar.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Specifies the new font.  
  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, the Outlook bar will be redrawn.  
  
### Remarks  
 Use this method to set a font for the text displayed on outlook tab page buttons.  
  
##  \<a name="cmfcoutlookbar__setmode2003">\</a>  CMFCOutlookBar::SetMode2003  
 Specifies whether the behavior of the Outlook bar mimics that of Outlook 2003.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 If TRUE, Office 2003 mode is enabled.  
  
### Remarks  
 Use this function to enable or disable Office 2003 mode. In this mode, the Outlook bar has an additional toolbar with a customization button. The behavior of the Outlook bar conforms to the behavior of the Outlook bar in Microsoft Office 2003.  
  
 By default, this mode is disabled.  
  
> [!NOTE]
>  This function must be called before [Create](#cmfcoutlookbar__create).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CBaseTabbedPane](../vs140/cbasetabbedpane-class.md)   
 [CMFCOutlookBarTabCtrl](../vs140/cmfcoutlookbartabctrl-class.md)   
 [CMFCOutlookBarPane](../vs140/cmfcoutlookbarpane-class.md)