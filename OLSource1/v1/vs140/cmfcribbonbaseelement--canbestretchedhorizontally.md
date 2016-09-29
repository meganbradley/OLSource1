---
title: "CMFCRibbonBaseElement::CanBeStretchedHorizontally"
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
  - "CMFCRibbonBaseElement::CanBeStretchedHorizontally"
  - "CanBeStretchedHorizontally"
  - "CMFCRibbonBaseElement.CanBeStretchedHorizontally"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeStretchedHorizontally method"
ms.assetid: 8c5305fa-7efc-499a-a8c1-7e6888d92e4c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement::CanBeStretchedHorizontally
Indicates whether the width of the ribbon element can change.  
  
## Syntax  
  
```  
virtual BOOL CanBeStretchedHorizontally();  
```  
  
## Return Value  
 Always returns `FALSE`.  
  
## Remarks  
 By default this method always returns `FALSE`. Override this method to indicate whether the width of the ribbon element can change.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)