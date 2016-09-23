---
title: "COleServerDoc::ScrollContainerBy"
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
  - COleServerDoc.ScrollContainerBy
  - ScrollContainerBy
  - COleServerDoc::ScrollContainerBy
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerDoc class, operations
  - ScrollContainerBy method
ms.assetid: 9e15ae59-69b1-4bf5-8ae0-adaca68950e4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerDoc::ScrollContainerBy
Call the `ScrollContainerBy` member function to scroll the container document by the amount, in pixels, indicated by `sizeScroll`.  
  
## Syntax  
  
```  
  
      BOOL ScrollContainerBy(  
   CSize sizeScroll   
);  
```  
  
#### Parameters  
 `sizeScroll`  
 Indicates how far the container document is to scroll.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Positive values indicate scrolling down and to the right; negative values indicate scrolling up and to the left.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnScrollBy](../vs140/coleclientitem--onscrollby.md)