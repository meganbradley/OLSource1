---
title: "CMFCRibbonBaseElement::GetKeyTipRect"
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
  - "CMFCRibbonBaseElement.GetKeyTipRect"
  - "GetKeyTipRect"
  - "CMFCRibbonBaseElement::GetKeyTipRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetKeyTipRect method"
ms.assetid: 19ce240e-9387-4a04-9ea7-e4f9591a9f28
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::GetKeyTipRect
Retrieves the keytip boundary rectangle for the ribbon element.  
  
## Syntax  
  
```  
virtual CRect GetKeyTipRect(  
    CDC* pDC,  
    BOOL bIsMenu  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `bIsMenu`  
 `TRUE` if the ribbon element displays a pop-up menu; otherwise `FALSE`.  
  
## Return Value  
 Always returns a rectangle with 0 values.  
  
## Remarks  
 Override this method in a derived class to return the keytip boundary rectangle.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)