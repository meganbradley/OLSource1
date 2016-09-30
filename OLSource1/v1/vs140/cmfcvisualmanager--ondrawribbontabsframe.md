---
title: "CMFCVisualManager::OnDrawRibbonTabsFrame"
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
  - "OnDrawRibbonTabsFrame"
  - "CMFCVisualManager::OnDrawRibbonTabsFrame"
  - "CMFCVisualManager.OnDrawRibbonTabsFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonTabsFrame method"
ms.assetid: 33ddcd1b-c17f-410a-a3f2-49d459e870cf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonTabsFrame
The framework calls this method when it draws the frame around a set of ribbon tabs.  
  
## Syntax  
  
```  
virtual COLORREF OnDrawRibbonTabsFrame(  
   CDC* pDC,  
   CMFCRibbonBar* pWndRibbonBar,  
   CRect rectTab  
);  
```  
  
#### Parameters  
 `pDC`  
 A pointer to a device context.  
  
 `pWndRibbonBar`  
 A pointer to a [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md) object. The framework draws the frame for this ribbon bar.  
  
 `rectTab`  
 A rectangle that specifies the boundaries of the ribbon tabs.  
  
## Return Value  
 A reserved value. By default, this method returns -1.  
  
## Remarks  
 Override this method in a derived visual manager to customize the frame around a set of tabs on the ribbon.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)