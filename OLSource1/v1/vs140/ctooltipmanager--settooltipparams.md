---
title: "CTooltipManager::SetTooltipParams"
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
  - "CTooltipManager.SetTooltipParams"
  - "SetTooltipParams"
  - "CTooltipManager::SetTooltipParams"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTooltipParams method"
ms.assetid: 8c046c2c-b00a-4773-9c68-0c31e04a8cd9
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTooltipManager::SetTooltipParams
Customizes the appearance of the tooltip control for the specified Windows control types.  
  
## Syntax  
  
```  
void SetTooltipParams(  
   UINT nTypes,  
   CRuntimeClass* pRTC=RUNTIME_CLASS(CMFCToolTipCtrl),  
   CMFCToolTipInfo* pParams=NULL   
);  
```  
  
#### Parameters  
 [in] `nTypes`  
 Specifies control types.  
  
 [in] `pRTC`  
 Runtime class of custom tooltip.  
  
 [in] `pParams`  
 Tooltip parameters.  
  
## Remarks  
 This method sets the runtime class and initial parameters that the [CToolTipManager](../vs140/ctooltipmanager-class.md) uses when it creates tooltips. When a control calls [CMFCTooltipManager::CreateToolTip](../vs140/ctooltipmanager--createtooltip.md) and passes in a tooltip type that is one of the types indicated by `nTypes`, the tooltip manager creates a tooltip control that is an instance of the runtime class specified by `pRTC` and passes the parameters specified by `pParams` to the new tooltip.  
  
 When you call this method, all existing tooltip owners receive the AFX_WM_UPDATETOOLTIPS message and they must re-create their tooltips by using [CMFCTooltipManager::CreateToolTip](../vs140/ctooltipmanager--createtooltip.md).  
  
 `nTypes` can be any combination of the valid tooltip types that [CreateToolTip](../vs140/ctooltipmanager--createtooltip.md) uses, or it can be AFX_TOOLTIP_TYPE_ALL. If you pass AFX_TOOLTIP_TYPE_ALL, all tooltip types are affected.  
  
## Example  
 The following example demonstrates how to use the `SetTooltipParams` method of the `CTooltipManager` class. This code snippet is part of the [Draw Client sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DrawClient#11](../vs140/codesnippet/CPP/ctooltipmanager--settooltipparams_1.cpp)]  
  
## Requirements  
 **Header:** afxtooltipmanager.h  
  
## See Also  
 [CToolTipManager Class](../vs140/ctooltipmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)