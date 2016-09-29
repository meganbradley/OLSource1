---
title: "CDC::FrameRect"
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
  - "FrameRect"
  - "CDC::FrameRect"
  - "CDC.FrameRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, simple drawing functions"
  - "FrameRect method"
ms.assetid: 750bbdd5-cebe-4875-bf14-52db98cf7526
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::FrameRect
Draws a border around the rectangle specified by `lpRect`.  
  
## Syntax  
  
```  
  
      void FrameRect(  
   LPCRECT lpRect,  
   CBrush* pBrush   
);  
```  
  
#### Parameters  
 `lpRect`  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that contains the logical coordinates of the upper-left and lower-right corners of the rectangle. You can also pass a `CRect` object for this parameter.  
  
 `pBrush`  
 Identifies the brush to be used for framing the rectangle.  
  
## Remarks  
 The function uses the given brush to draw the border. The width and height of the border is always 1 logical unit.  
  
 If the rectangle's **bottom** coordinate is less than or equal to **top**, or if **right** is less than or equal to **left**, the rectangle is not drawn.  
  
 The border drawn by `FrameRect` is in the same position as a border drawn by the **Rectangle** member function using the same coordinates (if **Rectangle** uses a pen that is 1 logical unit wide). The interior of the rectangle is not filled by `FrameRect`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush Class](../vs140/cbrush-class.md)   
 [FrameRect](http://msdn.microsoft.com/library/windows/desktop/dd144838)   
 [CDC::Rectangle](../vs140/cdc--rectangle.md)   
 [CDC::FrameRgn](../vs140/cdc--framergn.md)   
 [RECT Structure](../vs140/rect-structure.md)