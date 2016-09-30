---
title: "CDC::Rectangle"
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
  - "CDC.Rectangle"
  - "CDC::Rectangle"
  - "Rectangle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, ellipse and polygon functions"
  - "Rectangle method"
ms.assetid: 63a3f745-7815-4747-b96d-7c6e7374a274
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Rectangle
Draws a rectangle using the current pen.  
  
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
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the rectangle in logical units. You can pass either a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object or a pointer to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The interior of the rectangle is filled using the current brush.  
  
 The rectangle extends up to, but does not include, the right and bottom coordinates. This means that the height of the rectangle is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the width of the rectangle is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Both the width and the height of a rectangle must be greater than 2 units and less than 32,767 units.  
  
## Example  
 [!code[NVC_MFCDocView#39](../vs140/codesnippet/CPP/cdc--rectangle_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Rectangle](http://msdn.microsoft.com/library/windows/desktop/dd162898)   
 [CDC::Polyline](../vs140/cdc--polyline.md)   
 [CDC::RoundRect](../vs140/cdc--roundrect.md)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CRect Class](../vs140/crect-class.md)