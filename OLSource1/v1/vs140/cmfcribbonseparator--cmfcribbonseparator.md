---
title: "CMFCRibbonSeparator::CMFCRibbonSeparator"
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
  - CMFCRibbonSeparator.CMFCRibbonSeparator
  - CMFCRibbonSeparator
  - CMFCRibbonSeparator::CMFCRibbonSeparator
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCRibbonSeparator class, constructor
ms.assetid: 3cfaeeaf-d405-4653-a110-755a5e531f29
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonSeparator::CMFCRibbonSeparator
Constructs a `CMFCRibbonSeparator` object.  
  
## Syntax  
  
```  
CMFCRibbonSeparator(  
   BOOL bIsHoriz = FALSE  
);  
```  
  
#### Parameters  
 [in] `bIsHoriz`  
 If `TRUE`, the separator is horizontal; if `FALSE`, the separator is vertical.  
  
## Remarks  
 Horizontal separators are used in application menus. Vertical separators are used in toolbars.  
  
## Example  
 The following example demonstrates how to construct an object of the `CMFCRibbonSeparator` class.  
  
 [!code[NVC_MFC_RibbonApp#19](../vs140/codesnippet/CPP/cmfcribbonseparator--cmfcribbonseparator_1.cpp)]
  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonSeparator Class](../vs140/cmfcribbonseparator-class.md)