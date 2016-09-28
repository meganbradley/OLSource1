---
title: "CMFCVisualManager::OnDrawRibbonButtonsGroup"
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
  - "CMFCVisualManager.OnDrawRibbonButtonsGroup"
  - "OnDrawRibbonButtonsGroup"
  - "CMFCVisualManager::OnDrawRibbonButtonsGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonButtonsGroup method"
ms.assetid: 9776f9a5-7337-4ec0-9190-a2ce4276f4dc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonButtonsGroup
The framework calls this method when it draws a group of buttons on the ribbon.  
  
## Syntax  
  
```  
virtual COLORREF OnDrawRibbonButtonsGroup(  
   CDC* pDC,  
   CMFCRibbonButtonsGroup* pGroup,  
   CRect rectGroup  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pGroup`  
 A pointer to a group of buttons on the ribbon. The framework draws this group of buttons.  
  
 [in] `rectGroup`  
 A rectangle that specifies the boundaries of the group.  
  
## Return Value  
 A reserved value. The default implementation returns -1.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a group of buttons on the ribbon.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonButtonsGroup Class](../vs140/cmfcribbonbuttonsgroup-class.md)