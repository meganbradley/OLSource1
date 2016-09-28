---
title: "CDC::DrawDragRect"
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
  - "DrawDragRect"
  - "CDC.DrawDragRect"
  - "CDC::DrawDragRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, simple drawing functions"
  - "DrawDragRect method"
ms.assetid: 3efa9ebc-7ea7-42bd-9e89-3d375cbb8bcf
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DrawDragRect
Call this member function repeatedly to redraw a drag rectangle.  
  
## Syntax  
  
```  
  
      void DrawDragRect(  
   LPCRECT lpRect,  
   SIZE size,  
   LPCRECT lpRectLast,  
   SIZE sizeLast,  
   CBrush* pBrush = NULL,  
   CBrush* pBrushLast = NULL   
);  
```  
  
#### Parameters  
 `lpRect`  
 Points to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object that specifies the logical coordinates of a rectangle — in this case, the end position of the rectangle being redrawn.  
  
 `size`  
 Specifies the displacement from the top-left corner of the outer border to the top-left corner of the inner border (that is, the thickness of the border) of a rectangle.  
  
 `lpRectLast`  
 Points to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object that specifies the logical coordinates of the position of a rectangle — in this case, the original position of the rectangle being redrawn.  
  
 *sizeLast*  
 Specifies the displacement from the top-left corner of the outer border to the top-left corner of the inner border (that is, the thickness of the border) of the original rectangle being redrawn.  
  
 `pBrush`  
 Pointer to a brush object. Set to **NULL** to use the default halftone brush.  
  
 *pBrushLast*  
 Pointer to the last brush object used. Set to **NULL** to use the default halftone brush.  
  
## Remarks  
 Call it in a loop as you sample mouse position, in order to give visual feedback. When you call `DrawDragRect`, the previous rectangle is erased and a new one is drawn. For example, as the user drags a rectangle across the screen, `DrawDragRect` will erase the original rectangle and redraw a new one in its new position. By default, `DrawDragRect` draws the rectangle by using a halftone brush to eliminate flicker and to create the appearance of a smoothly moving rectangle.  
  
 The first time you call `DrawDragRect`, the `lpRectLast` parameter should be **NULL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CRect Class](../vs140/crect-class.md)   
 [CDC::GetHalftoneBrush](../vs140/cdc--gethalftonebrush.md)