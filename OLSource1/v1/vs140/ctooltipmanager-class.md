---
title: "CTooltipManager Class"
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
  - "CTooltipManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTooltipManager class"
ms.assetid: c71779d7-8b6e-47ef-8500-d4552731fe86
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTooltipManager Class
Maintains runtime information about tooltips. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class is instantiated one time per application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CTooltipManager::CreateToolTip](#ctooltipmanager__createtooltip)|Creates a tooltip control for the specified Windows control type(s).|  
|[CTooltipManager::DeleteToolTip](#ctooltipmanager__deletetooltip)|Deletes a tooltip control.|  
|[CTooltipManager::SetTooltipParams](#ctooltipmanager__settooltipparams)|Customizes the visual appearance of the tooltip control for the specified Windows control type(s).|  
|[CTooltipManager::SetTooltipText](#ctooltipmanager__settooltiptext)|Sets the text and description for a tooltip control.|  
|[CTooltipManager::UpdateTooltips](#ctooltipmanager__updatetooltips)||  
  
## Remarks  
 Use [CMFCToolTipCtrl](../vs140/cmfctooltipctrl-class.md), <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> together to implement customized tooltips in your application. For an example of how to use these tooltip classes, see the [CMFCToolTipCtrl](../vs140/cmfctooltipctrl-class.md) topic.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CTooltipManager](../vs140/ctooltipmanager-class.md)  
  
## Requirements  
 **Header:** afxtooltipmanager.h  
  
##  \<a name="ctooltipmanager__createtooltip">\</a>  CTooltipManager::CreateToolTip  
 Creates a tooltip control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [out]  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A reference to a tooltip pointer. It is set to point to the newly created tooltip when the function returns.  
  
 [in]  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Parent of the tooltip.  
  
 [in]  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Type of the tooltip.  
  
### Return Value  
 Nonzero if a tooltip has been created successfully.  
  
### Remarks  
 You must call [CTooltipManager::DeleteTooltip](#ctooltipmanager__deletetooltip) to delete the tooltip control that is passed back in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The [CTooltipManager](../vs140/ctooltipmanager-class.md) sets the visual display parameters of each tooltip it creates based on the tooltip type that <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> specifies. To change the parameters for one or more tooltip types, call [CTooltipManager::SetTooltipParams](#ctooltipmanager__settooltipparams).  
  
 Valid tooltip types are listed in the following table:  
  
|Tooltip type|Control category|Example types|  
|------------------|----------------------|-------------------|  
|AFX_TOOLTIP_TYPE_BUTTON|A button.|CMFCButton|  
|AFX_TOOLTIP_TYPE_CAPTIONBAR|A caption bar.|CMFCCaptionBar|  
|AFX_TOOLTIP_TYPE_DEFAULT|Any control that does not fit another category.|None.|  
|AFX_TOOLTIP_TYPE_DOCKBAR|A dockable pane.|CDockablePane|  
|AFX_TOOLTIP_TYPE_EDIT|A text box.|None.|  
|AFX_TOOLTIP_TYPE_MINIFRAME|A miniframe.|CPaneFrameWnd|  
|AFX_TOOLTIP_TYPE_PLANNER|A planner.|None.|  
|AFX_TOOLTIP_TYPE_RIBBON|A ribbon bar.|CMFCRibbonBar, CMFCRibbonPanelMenuBar|  
|AFX_TOOLTIP_TYPE_TAB|A tab control.|CMFCTabCtrl|  
|AFX_TOOLTIP_TYPE_TOOLBAR|A toolbar.|CMFCToolBar, CMFCPopupMenuBar|  
|AFX_TOOLTIP_TYPE_TOOLBOX|A toolbox.|None.|  
  
##  \<a name="ctooltipmanager__deletetooltip">\</a>  CTooltipManager::DeleteToolTip  
 Deletes a tooltip control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in, out]  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A reference to a pointer to a tooltip to be destroyed.  
  
### Remarks  
 Call this method for each [CToolTipCtrl](../vs140/ctooltipctrl-class.md) that was created by [CTooltipManager::CreateToolTip](#ctooltipmanager__createtooltip). The parent control should call this method from its <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> handler. This is required to correctly remove the tooltip from the framework. This method sets <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> before it returns.  
  
##  \<a name="ctooltipmanager__settooltipparams">\</a>  CTooltipManager::SetTooltipParams  
 Customizes the appearance of the tooltip control for the specified Windows control types.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies control types.  
  
 [in]  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Runtime class of custom tooltip.  
  
 [in]  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Tooltip parameters.  
  
### Remarks  
 This method sets the runtime class and initial parameters that the [CToolTipManager](../vs140/ctooltipmanager-class.md) uses when it creates tooltips. When a control calls [CMFCTooltipManager::CreateToolTip](#ctooltipmanager__createtooltip) and passes in a tooltip type that is one of the types indicated by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the tooltip manager creates a tooltip control that is an instance of the runtime class specified by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and passes the parameters specified by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to the new tooltip.  
  
 When you call this method, all existing tooltip owners receive the AFX_WM_UPDATETOOLTIPS message and they must re-create their tooltips by using [CMFCTooltipManager::CreateToolTip](#ctooltipmanager__createtooltip).  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> can be any combination of the valid tooltip types that [CreateToolTip](#ctooltipmanager__createtooltip) uses, or it can be AFX_TOOLTIP_TYPE_ALL. If you pass AFX_TOOLTIP_TYPE_ALL, all tooltip types are affected.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class. This code snippet is part of the [Draw Client sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DrawClient#11](../vs140/codesnippet/CPP/ctooltipmanager-class_1.cpp)]  
  
##  \<a name="ctooltipmanager__settooltiptext">\</a>  CTooltipManager::SetTooltipText  
 Sets the text and description for a tooltip.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A pointer to a TOOLINFO object.  
  
 [in, out]  <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A pointer to the tooltip control for which to set the text and description.  
  
 [in]  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies the type of control with which this tooltip is associated.  
  
 [in]  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The text to set as the tooltip text.  
  
 [in]  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A pointer to the tooltip description. Can be <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
### Remarks  
 The value of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> must be the same value as the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter of [CMFCTooltipManager::CreateToolTip](#ctooltipmanager__createtooltip) when you created the tooltip.  
  
##  \<a name="ctooltipmanager__updatetooltips">\</a>  CTooltipManager::UpdateTooltips  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolTipCtrl](../vs140/cmfctooltipctrl-class.md)   
 [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md)