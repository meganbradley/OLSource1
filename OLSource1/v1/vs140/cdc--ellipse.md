---
title: "CDC::Ellipse"
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
  - "CDC.Ellipse"
  - "Ellipse"
  - "CDC::Ellipse"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, ellipse and polygon functions"
  - "Ellipse method"
ms.assetid: a77eaab4-a1b7-4108-a611-a242a97c4377
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Ellipse
Draws an ellipse.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the ellipse's bounding rectangle.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the ellipse's bounding rectangle.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the ellipse's bounding rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the ellipse's bounding rectangle.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the ellipse's bounding rectangle. You can also pass a [CRect](../vs140/crect-class.md) object for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The center of the ellipse is the center of the bounding rectangle specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The ellipse is drawn with the current pen, and its interior is filled with the current brush.  
  
 The figure drawn by this function extends up to, but does not include, the right and bottom coordinates. This means that the height of the figure is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and the width of the figure is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 If either the width or the height of the bounding rectangle is 0, no ellipse is drawn.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Arc](../vs140/cdc--arc.md)   
 [CDC::Chord](../vs140/cdc--chord.md)   
 [Ellipse](http://msdn.microsoft.com/library/windows/desktop/dd162510)