---
title: "CDC::PolylineTo"
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
  - "PolylineTo"
  - "CDC::PolylineTo"
  - "CDC.PolylineTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PolylineTo method"
  - "CDC class, line-output functions"
ms.assetid: 94e4a0db-78f0-4e28-9621-94d9647038f3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::PolylineTo
Draws one or more straight lines.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) data structures that contains the vertices of the line.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of points in the array.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 A line is drawn from the current position to the first point specified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter by using the current pen. For each additional line, the function draws from the ending point of the previous line to the next point specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> moves the current position to the ending point of the last line. If the line segments drawn by this function form a closed figure, the figure is not filled.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::LineTo](../vs140/cdc--lineto.md)   
 [CDC::Polyline](../vs140/cdc--polyline.md)   
 [CDC::MoveTo](../vs140/cdc--moveto.md)   
 [PolylineTo](http://msdn.microsoft.com/library/windows/desktop/dd162816)