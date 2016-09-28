---
title: "CDC::Pie"
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
  - "CDC::Pie"
  - "Pie"
  - "CDC.Pie"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Pie method"
  - "CDC class, ellipse and polygon functions"
ms.assetid: 1cf0e870-973c-471e-aec9-1822a2e6f51b
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Pie
Draws a pie-shaped wedge by drawing an elliptical arc whose center and two endpoints are joined by lines.  
  
## Syntax  
  
```  
  
      BOOL Pie(  
   int x1,  
   int y1,  
   int x2,  
   int y2,  
   int x3,  
   int y3,  
   int x4,  
   int y4   
);  
BOOL Pie(  
   LPCRECT lpRect,  
   POINT ptStart,  
   POINT ptEnd   
);  
```  
  
#### Parameters  
 `x1`  
 Specifies the x-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 `y1`  
 Specifies the y-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 `x2`  
 Specifies the x-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 `y2`  
 Specifies the y-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 *x3*  
 Specifies the x-coordinate of the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 `y3`  
 Specifies the y-coordinate of the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 `x4`  
 Specifies the x-coordinate of the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 `y4`  
 Specifies the y-coordinate of the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 `lpRect`  
 Specifies the bounding rectangle. You can pass either a `CRect` object or a pointer to a `RECT` structure for this parameter.  
  
 `ptStart`  
 Specifies the starting point of the arc. This point does not have to lie exactly on the arc. You can pass either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
 `ptEnd`  
 Specifies the endpoint of the arc. This point does not have to lie exactly on the arc. You can pass either a **POINT** structure or a `CPoint` object for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The center of the arc is the center of the bounding rectangle specified by `x1`, `y1`, `x2`, and `y2` (or by `lpRect`). The starting and ending points of the arc are specified by *x3*, `y3`, `x4`, and `y4` (or by `ptStart` and `ptEnd`).  
  
 The arc is drawn with the selected pen, moving in a counterclockwise direction. Two additional lines are drawn from each endpoint to the arc's center. The pie-shaped area is filled with the current brush. If *x3* equals `x4` and `y3` equals `y4`, the result is an ellipse with a single line from the center of the ellipse to the point (*x3*, `y3`) or (`x4`, `y4`).  
  
 The figure drawn by this function extends up to but does not include the right and bottom coordinates. This means that the height of the figure is `y2` – `y1` and the width of the figure is `x2` – `x1`. Both the width and the height of the bounding rectangle must be greater than 2 units and less than 32,767 units.  
  
## Example  
 [!code[NVC_MFCDocView#37](../vs140/codesnippet/CPP/cdc--pie_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Chord](../vs140/cdc--chord.md)   
 [Pie](http://msdn.microsoft.com/library/windows/desktop/dd162799)   
 [RECT Structure](../vs140/rect-structure.md)   
 [POINT Structure](../vs140/point-structure.md)   
 [CRect Class](../vs140/crect-class.md)   
 [CPoint Class](../vs140/cpoint-class.md)