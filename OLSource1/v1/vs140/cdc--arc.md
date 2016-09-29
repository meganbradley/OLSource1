---
title: "CDC::Arc"
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
  - "Arc"
  - "CDC.Arc"
  - "CDC::Arc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, line-output functions"
  - "Arc method"
ms.assetid: 8d8ac5ad-4aef-4800-958e-ea1888ba85f6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Arc
Draws an elliptical arc.  
  
## Syntax  
  
```  
  
      BOOL Arc(  
   int x1,  
   int y1,  
   int x2,  
   int y2,  
   int x3,  
   int y3,  
   int x4,  
   int y4   
);  
BOOL Arc(  
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
 Specifies the x-coordinate of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 `y3`  
 Specifies the y-coordinate of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 `x4`  
 Specifies the x-coordinate of the point that defines the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 `y4`  
 Specifies the y-coordinate of the point that defines the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 `lpRect`  
 Specifies the bounding rectangle (in logical units). You can pass either an `LPRECT` or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 `ptStart`  
 Specifies the x- and y-coordinates of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc. You can pass either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
 `ptEnd`  
 Specifies the x- and y-coordinates of the point that defines the arc's ending point (in logical units). This point does not have to lie exactly on the arc. You can pass either a **POINT** structure or a `CPoint` object for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The arc drawn by using the function is a segment of the ellipse defined by the specified bounding rectangle.  
  
 The actual starting point of the arc is the point at which a ray drawn from the center of the bounding rectangle through the specified starting point intersects the ellipse. The actual ending point of the arc is the point at which a ray drawn from the center of the bounding rectangle through the specified ending point intersects the ellipse. The arc is drawn in a counterclockwise direction. Since an arc is not a closed figure, it is not filled. Both the width and height of the rectangle must be greater than 2 units and less than 32,767 units.  
  
## Example  
 [!code[NVC_MFCDocView#29](../vs140/codesnippet/CPP/cdc--arc_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Chord](../vs140/cdc--chord.md)   
 [Arc](http://msdn.microsoft.com/library/windows/desktop/dd183357)   
 [POINT Structure](../vs140/point-structure.md)   
 [RECT Structure](../vs140/rect-structure.md)