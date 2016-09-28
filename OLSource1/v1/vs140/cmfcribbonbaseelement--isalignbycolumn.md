---
title: "CMFCRibbonBaseElement::IsAlignByColumn"
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
  - "IsAlignByColumn"
  - "CMFCRibbonBaseElement.IsAlignByColumn"
  - "CMFCRibbonBaseElement::IsAlignByColumn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAlignByColumn method"
ms.assetid: 2220b882-ec7b-4bf7-9487-c2c47245da8f
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::IsAlignByColumn
Indicates whether the ribbon element is aligned vertically with other ribbon elements.  
  
## Syntax  
  
```  
virtual BOOL IsAlignByColumn() const;  
```  
  
## Return Value  
 Always returns `TRUE`.  
  
## Remarks  
 By default this method always returns `TRUE`. Override this method in a derived class to indicate whether the derived ribbon element is aligned vertically with other ribbon elements.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)