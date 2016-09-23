---
title: "CDC::RectVisible"
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
  - CDC.RectVisible
  - CDC::RectVisible
  - RectVisible
dev_langs: 
  - C++
helpviewer_keywords: 
  - RectVisible method
  - CDC class, clipping functions
ms.assetid: d2935997-9948-476e-a682-d193e83597de
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::RectVisible
Determines whether any part of the given rectangle lies within the clipping region of the display context.  
  
## Syntax  
  
```  
  
      virtual BOOL RectVisible(  
   LPCRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 Points to a `RECT` structure or a `CRect` object that contains the logical coordinates of the specified rectangle.  
  
## Return Value  
 Nonzero if any portion of the given rectangle lies within the clipping region; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::PtVisible](../vs140/cdc--ptvisible.md)   
 [CDC::SelectClipRgn](../vs140/cdc--selectcliprgn.md)   
 [CRect Class](../vs140/crect-class.md)   
 [RectVisible](http://msdn.microsoft.com/library/windows/desktop/dd162908)   
 [RECT Structure](../vs140/rect-structure.md)