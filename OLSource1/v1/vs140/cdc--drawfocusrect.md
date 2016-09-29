---
title: "CDC::DrawFocusRect"
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
  - "DrawFocusRect"
  - "CDC.DrawFocusRect"
  - "CDC::DrawFocusRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, ellipse and polygon functions"
  - "DrawFocusRect method"
ms.assetid: 69ef59fb-5522-48ac-83ba-bf1325e4dd9e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DrawFocusRect
Draws a rectangle in the style used to indicate that the rectangle has the focus.  
  
## Syntax  
  
```  
  
      void DrawFocusRect(  
   LPCRECT lpRect   
);  
```  
  
#### Parameters  
 `lpRect`  
 Points to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object that specifies the logical coordinates of the rectangle to be drawn.  
  
## Remarks  
 Since this is a Boolean XOR function, calling this function a second time with the same rectangle removes the rectangle from the display. The rectangle drawn by this function cannot be scrolled. To scroll an area containing a rectangle drawn by this function, first call `DrawFocusRect` to remove the rectangle from the display, then scroll the area, and then call `DrawFocusRect` again to draw the rectangle in the new position.  
  
> [!CAUTION]
>  `DrawFocusRect` works only in `MM_TEXT` mode. In other modes, this function does not draw the focus rectangle correctly, but it does not return error values.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::FrameRect](../vs140/cdc--framerect.md)   
 [DrawFocusRect](http://msdn.microsoft.com/library/windows/desktop/dd162479)   
 [RECT Structure](../vs140/rect-structure.md)