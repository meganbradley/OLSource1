---
title: "CMFCRibbonStatusBar::AddElement"
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
  - "CMFCRibbonStatusBar.AddElement"
  - "CMFCRibbonStatusBar::AddElement"
  - "AddElement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddElement method"
ms.assetid: 662cbe35-4760-4901-b003-545c727fc679
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonStatusBar::AddElement
Adds a new ribbon element to the ribbon status bar.  
  
## Syntax  
  
```  
void AddElement(  
   CMFCRibbonBaseElement* pElement,  
   LPCTSTR lpszLabel,  
   BOOL bIsVisible=TRUE   
);  
```  
  
#### Parameters  
 [in] `pElement`  
 A pointer to the added element.  
  
 [in] `lpszLabel`  
 A text label of the element.  
  
 [in] `bIsVisible`  
 `TRUE` if you want to add the element as visible, `FALSE` if you want to add the element as hidden.  
  
## Requirements  
 **Header:** afxribbonstatusbar.h  
  
## See Also  
 [CMFCRibbonStatusBar Class](../vs140/cmfcribbonstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)