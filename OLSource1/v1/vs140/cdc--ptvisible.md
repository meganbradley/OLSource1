---
title: "CDC::PtVisible"
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
  - CDC::PtVisible
  - CDC.PtVisible
  - PtVisible
dev_langs: 
  - C++
helpviewer_keywords: 
  - PtVisible method
  - CDC class, clipping functions
ms.assetid: 04775cc7-0002-41e5-bba8-e1e075648d01
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::PtVisible
Determines whether the given point is within the clipping region of the device context.  
  
## Syntax  
  
```  
  
      virtual BOOL PtVisible(  
   int x,  
   int y   
) const;  
BOOL PtVisible(  
   POINT point   
) const;  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point.  
  
 *y*  
 Specifies the logical y-coordinate of the point.  
  
 `point`  
 Specifies the point to check in logical coordinates. You can pass either a **POINT** structure or a `CPoint` object for this parameter.  
  
## Return Value  
 Nonzero if the specified point is within the clipping region; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::RectVisible](../vs140/cdc--rectvisible.md)   
 [CDC::SelectClipRgn](../vs140/cdc--selectcliprgn.md)   
 [CPoint Class](../vs140/cpoint-class.md)   
 [PtVisible](http://msdn.microsoft.com/library/windows/desktop/dd162890)   
 [POINT Structure](../vs140/point-structure.md)