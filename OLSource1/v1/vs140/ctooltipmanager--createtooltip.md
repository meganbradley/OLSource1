---
title: "CTooltipManager::CreateToolTip"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CTooltipManager::CreateToolTip
  - CreateToolTip
  - CTooltipManager.CreateToolTip
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateToolTip method
ms.assetid: e50f1776-3b6f-48f0-a761-df5acb94909d
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTooltipManager::CreateToolTip
Creates a tooltip control.  
  
## Syntax  
  
```  
static BOOL CreateToolTip(  
   CToolTipCtrl*& pToolTip,  
   CWnd* pWndParent,  
   UINT nType   
);  
```  
  
#### Parameters  
 [out] `pToolTip`  
 A reference to a tooltip pointer. It is set to point to the newly created tooltip when the function returns.  
  
 [in] `pWndParent`  
 Parent of the tooltip.  
  
 [in] `nType`  
 Type of the tooltip.  
  
## Return Value  
 Nonzero if a tooltip has been created successfully.  
  
## Remarks  
 You must call [CTooltipManager::DeleteTooltip](../vs140/ctooltipmanager--deletetooltip.md) to delete the tooltip control that is passed back in `pToolTip`.  
  
 The [CTooltipManager](../vs140/ctooltipmanager-class.md) sets the visual display parameters of each tooltip it creates based on the tooltip type that  `nType` specifies. To change the parameters for one or more tooltip types, call [CTooltipManager::SetTooltipParams](../vs140/ctooltipmanager--settooltipparams.md).  
  
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
  
## Requirements  
 **Header:** afxtooltipmanager.h  
  
## See Also  
 [CTooltipManager Class](../vs140/ctooltipmanager-class.md)   
 [CMFCToolTipCtrl Class](../vs140/cmfctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)