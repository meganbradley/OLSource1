---
title: "CMFCVisualManager::OnDrawRibbonButtonBorder"
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
  - "CMFCVisualManager::OnDrawRibbonButtonBorder"
  - "CMFCVisualManager.OnDrawRibbonButtonBorder"
  - "OnDrawRibbonButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonButtonBorder method"
ms.assetid: 991e9c93-2a4d-4da0-aea6-a4690613e529
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonButtonBorder
The framework calls this method when it draws the border of a button on the ribbon.  
  
## Syntax  
  
```  
virtual void OnDrawRibbonButtonBorder(  
   CDC* pDC,  
   CMFCRibbonButton* pButton  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pButton`  
 A pointer to a [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md) object. The framework draws the border for this ribbon button.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a `CMFCRibbonButton`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)