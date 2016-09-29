---
title: "CMFCRibbonBaseElement::Find"
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
  - "Find"
  - "CMFCRibbonBaseElement.Find"
  - "CMFCRibbonBaseElement::Find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Find method"
ms.assetid: 4ece95b8-c86a-45b9-94d4-177e10cd7f0e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::Find
Returns the specified pointer if it points to the current object.  
  
## Syntax  
  
```  
virtual CMFCRibbonBaseElement* Find(  
   const CMFCRibbonBaseElement* pElement  
);  
```  
  
#### Parameters  
 [in] `pElement`  
 Pointer to a ribbon element.  
  
## Return Value  
 A pointer to the ribbon element if `pElement` points to the current object; otherwise `NULL`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)