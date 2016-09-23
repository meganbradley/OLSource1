---
title: "CMFCRibbonBaseElement::IsWholeRowHeight"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCRibbonBaseElement::IsWholeRowHeight
  - IsWholeRowHeight
  - CMFCRibbonBaseElement.IsWholeRowHeight
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsWholeRowHeight method
ms.assetid: df3d3553-a1ff-4957-8dff-50f7db08c837
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBaseElement::IsWholeRowHeight
Indicates whether the display height of the ribbon element is the same as the display height of the ribbon panel that contains it.  
  
## Syntax  
  
```  
virtual BOOL IsWholeRowHeight() const;  
```  
  
## Return Value  
 Always returns `FALSE`.  
  
## Remarks  
 By default this method always returns `FALSE`. Override this method to indicate whether the display height of the ribbon element is the same as the display height of the ribbon panel that contains it.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)