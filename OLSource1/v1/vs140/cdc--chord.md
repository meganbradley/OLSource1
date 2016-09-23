---
title: "CDC::Chord"
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
  - Chord
  - CDC.Chord
  - CDC::Chord
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, ellipse and polygon functions
  - Chord method
ms.assetid: ea4b1556-25fd-4d21-ae7e-569323098dae
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::Chord
Draws a chord (a closed figure bounded by the intersection of an ellipse and a line segment).  
  
## Syntax  
  
```  
  
      BOOL Chord(  
   int x1,  
   int y1,  
   int x2,  
   int y2,  
   int x3,  
   int y3,  
   int x4,  
   int y4   
);  
BOOL Chord(  
   LPCRECT lpRect,  
   POINT ptStart,  
   POINT ptEnd   
);  
```  
  
#### Parameters  
 `x1`  
 Specifies the x-coordinate of the upper-left corner of the chord's bounding rectangle (in logical units).  
  
 `y1`  
 Specifies the y-coordinate of the upper-left corner of the chord's bounding rectangle (in logical units).  
  
 `x2`  
 Specifies the x-coordinate of the lower-right corner of the chord's bounding rectangle (in logical units).  
  
 `y2`  
 Specifies the y-coordinate of the lower-right corner of the chord's bounding rectangle (in logical units).  
  
 *x3*  
 Specifies the x-coordinate of the point that defines the chord's starting point (in logical units).  
  
 `y3`  
 Specifies the y-coordinate of the point that defines the chord's starting point (in logical units).  
  
 `x4`  
 Specifies the x-coordinate of the point that defines the chord's endpoint (in logical units).  
  
 `y4`  
 Specifies the y-coordinate of the point that defines the chord's endpoint (in logical units).  
  
 `lpRect`  
 Specifies the bounding rectangle (in logical units). You can pass either a `LPRECT` or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 `ptStart`  
 Specifies the x- and y-coordinates of the point that defines the chord's starting point (in logical units). This point does not have to lie exactly on the chord. You can pass either a **POINT** structure or a `CPoint` object for this parameter.  
  
 `ptEnd`  
 Specifies the x- and y-coordinates of the point that defines the chord's ending point (in logical units). This point does not have to lie exactly on the chord. You can pass either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The (`x1`, `y1`) and (`x2`, `y2`) parameters specify the upper-left and lower-right corners, respectively, of a rectangle bounding the ellipse that is part of the chord. The (*x3*, `y3`) and (`x4`, `y4`) parameters specify the endpoints of a line that intersects the ellipse. The chord is drawn by using the selected pen and filled by using the selected brush.  
  
 The figure drawn by the `Chord` function extends up to, but does not include the right and bottom coordinates. This means that the height of the figure is `y2` – `y1` and the width of the figure is `x2` – `x1`.  
  
## Example  
 [!code[NVC_MFCDocView#31](../vs140/codesnippet/CPP/cdc--chord_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Arc](../vs140/cdc--arc.md)   
 [Chord](http://msdn.microsoft.com/library/windows/desktop/dd183428)   
 [POINT Structure](../vs140/point-structure.md)