---
title: "CRgn::RectInRegion"
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
  - CRgn.RectInRegion
  - RectInRegion
  - CRgn::RectInRegion
dev_langs: 
  - C++
helpviewer_keywords: 
  - RectInRegion method
  - CRgn class, operations
ms.assetid: 0c5e355b-29f6-48cc-950f-b38e0fcfd480
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRgn::RectInRegion
Determines whether any part of the rectangle specified by `lpRect` is within the boundaries of the region stored in the `CRgn` object.  
  
## Syntax  
  
```  
  
      BOOL RectInRegion(  
   LPCRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 Points to a `RECT` structure or `CRect` object. The `RECT` structure has the following form:  
  
 `typedef struct tagRECT {`  
  
 `int left;`  
  
 `int top;`  
  
 `int right;`  
  
 `int bottom;`  
  
 `} RECT;`  
  
## Return Value  
 Nonzero if any part of the specified rectangle lies within the boundaries of the region; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [RectInRegion](http://msdn.microsoft.com/library/windows/desktop/dd162906)