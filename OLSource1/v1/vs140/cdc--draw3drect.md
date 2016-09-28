---
title: "CDC::Draw3dRect"
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
  - "CDC.Draw3dRect"
  - "CDC::Draw3dRect"
  - "Draw3dRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, simple drawing functions"
  - "Draw3dRect method"
ms.assetid: d733b008-cccd-40b7-b4ee-40355e94dc64
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Draw3dRect
Call this member function to draw a three-dimensional rectangle.  
  
## Syntax  
  
```  
  
      void Draw3dRect(  
   LPCRECT lpRect,  
   COLORREF clrTopLeft,  
   COLORREF clrBottomRight   
);  
void Draw3dRect(  
   int x,  
   int y,  
   int cx,  
   int cy,  
   COLORREF clrTopLeft,  
   COLORREF clrBottomRight   
);  
```  
  
#### Parameters  
 `lpRect`  
 Specifies the bounding rectangle (in logical units). You can pass either a pointer to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 *clrTopLeft*  
 Specifies the color of the top and left sides of the three-dimensional rectangle.  
  
 `clrBottomRight`  
 Specifies the color of the bottom and right sides of the three-dimensional rectangle.  
  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the three-dimensional rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the three-dimensional rectangle.  
  
 cx  
 Specifies the width of the three-dimensional rectangle.  
  
 cy  
 Specifies the height of the three-dimensional rectangle.  
  
## Remarks  
 The rectangle will be drawn with the top and left sides in the color specified by *clrTopLeft* and the bottom and right sides in the color specified by `clrBottomRight`.  
  
## Example  
 [!code[NVC_MFCDocView#33](../vs140/codesnippet/CPP/cdc--draw3drect_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CRect Class](../vs140/crect-class.md)