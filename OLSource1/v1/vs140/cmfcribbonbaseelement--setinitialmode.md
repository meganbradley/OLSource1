---
title: "CMFCRibbonBaseElement::SetInitialMode"
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
  - "CMFCRibbonBaseElement.SetInitialMode"
  - "SetInitialMode"
  - "CMFCRibbonBaseElement::SetInitialMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetInitialMode method"
ms.assetid: 58ec4eb7-37fa-4a34-8ef1-c6f6b4d04bd0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::SetInitialMode
Sets the initial display size for the ribbon element.  
  
## Syntax  
  
```  
virtual void SetInitialMode(  
   BOOL bOneRow = FALSE  
);  
```  
  
#### Parameters  
 [in] `bOneRow`  
 `TRUE` to limit the display size for the ribbon element to compact or intermediate; otherwise, `FALSE`.  
  
## Remarks  
 The display size of ribbon elements can be compact, intermediate, or large.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)