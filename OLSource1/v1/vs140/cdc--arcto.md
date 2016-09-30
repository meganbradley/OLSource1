---
title: "CDC::ArcTo"
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
  - "ArcTo"
  - "CDC::ArcTo"
  - "CDC.ArcTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ArcTo method"
  - "CDC class, line-output functions"
ms.assetid: fa9021f9-30c0-4cb0-bcb6-6c40131a263f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ArcTo
Draws an elliptical arc.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 *x3*  
 Specifies the x-coordinate of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the point that defines the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle (in logical units). You can pass either a pointer to a [RECT](../vs140/rect-structure.md) data structure or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc. You can pass either a [POINT](../vs140/point-structure.md) data structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the arc's ending point (in logical units). This point does not have to lie exactly on the arc. You can pass either a **POINT** data structure or a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 This function is similar to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, except that the current position is updated. The points (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) and (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) specify the bounding rectangle. An ellipse formed by the given bounding rectangle defines the curve of the arc. The arc extends counterclockwise (the default arc direction) from the point where it intersects the radial line from the center of the bounding rectangle to (*x3*,<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>). The arc ends where it intersects the radial line from the center of the bounding rectangle to (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>). If the starting point and ending point are the same, a complete ellipse is drawn.  
  
 A line is drawn from the current position to the starting point of the arc. If no error occurs, the current position is set to the ending point of the arc. The arc is drawn using the current pen; it is not filled.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::AngleArc](../vs140/cdc--anglearc.md)   
 [CDC::Arc](../vs140/cdc--arc.md)   
 [CDC::SetArcDirection](../vs140/cdc--setarcdirection.md)   
 [ArcTo](http://msdn.microsoft.com/library/windows/desktop/dd183358)