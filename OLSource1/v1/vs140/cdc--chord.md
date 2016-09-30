---
title: "CDC::Chord"
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
  - "Chord"
  - "CDC.Chord"
  - "CDC::Chord"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, ellipse and polygon functions"
  - "Chord method"
ms.assetid: ea4b1556-25fd-4d21-ae7e-569323098dae
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Chord
Draws a chord (a closed figure bounded by the intersection of an ellipse and a line segment).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the chord's bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the chord's bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the chord's bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the chord's bounding rectangle (in logical units).  
  
 *x3*  
 Specifies the x-coordinate of the point that defines the chord's starting point (in logical units).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the chord's starting point (in logical units).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the point that defines the chord's endpoint (in logical units).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the chord's endpoint (in logical units).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle (in logical units). You can pass either a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the chord's starting point (in logical units). This point does not have to lie exactly on the chord. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the chord's ending point (in logical units). This point does not have to lie exactly on the chord. You can pass either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) and (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) parameters specify the upper-left and lower-right corners, respectively, of a rectangle bounding the ellipse that is part of the chord. The (*x3*, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) and (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) parameters specify the endpoints of a line that intersects the ellipse. The chord is drawn by using the selected pen and filled by using the selected brush.  
  
 The figure drawn by the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function extends up to, but does not include the right and bottom coordinates. This means that the height of the figure is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and the width of the figure is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
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