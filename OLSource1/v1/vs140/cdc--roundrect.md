---
title: "CDC::RoundRect"
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
  - "CDC::RoundRect"
  - "RoundRect"
  - "CDC.RoundRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, ellipse and polygon functions"
  - "RoundRect method"
ms.assetid: c20e1713-7569-40a4-ac52-4c68cbc56f7c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::RoundRect
Draws a rectangle with rounded corners using the current pen.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the rectangle (in logical units).  
  
 *x3*  
 Specifies the width of the ellipse used to draw the rounded corners (in logical units).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the height of the ellipse used to draw the rounded corners (in logical units).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle in logical units. You can pass either a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object or a pointer to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure for this parameter.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The x-coordinate of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> specifies the width of the ellipse to draw the rounded corners (in logical units). The y-coordinate of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> specifies the height of the ellipse to draw the rounded corners (in logical units). You can pass either a **POINT** structure or a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The interior of the rectangle is filled using the current brush.  
  
 The figure this function draws extends up to but does not include the right and bottom coordinates. This means that the height of the figure is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and the width of the figure is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Both the height and the width of the bounding rectangle must be greater than 2 units and less than 32,767 units.  
  
## Example  
 [!code[NVC_MFCDocView#40](../vs140/codesnippet/CPP/cdc--roundrect_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Rectangle](../vs140/cdc--rectangle.md)   
 [RoundRect](http://msdn.microsoft.com/library/windows/desktop/dd162944)   
 [CRect Class](../vs140/crect-class.md)   
 [RECT Structure](../vs140/rect-structure.md)   
 [POINT Structure](../vs140/point-structure.md)   
 [CPoint Class](../vs140/cpoint-class.md)