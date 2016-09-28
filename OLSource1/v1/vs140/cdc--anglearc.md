---
title: "CDC::AngleArc"
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
  - "CDC::AngleArc"
  - "CDC.AngleArc"
  - "AngleArc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AngleArc method"
  - "CDC class, line-output functions"
ms.assetid: 348e9fcf-0f14-49c8-98b8-439a077e2718
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::AngleArc
Draws a line segment and an arc.  
  
## Syntax  
  
```  
  
      BOOL AngleArc(  
   int x,  
   int y,  
   int nRadius,  
   float fStartAngle,  
   float fSweepAngle   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the center of the circle.  
  
 *y*  
 Specifies the logical y-coordinate of the center of the circle.  
  
 *nRadius*  
 Specifies the radius of the circle in logical units. This value must be positive.  
  
 *fStartAngle*  
 Specifies the starting angle in degrees relative to the x-axis.  
  
 *fSweepAngle*  
 Specifies the sweep angle in degrees relative to the starting angle.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The line segment is drawn from the current position to the beginning of the arc. The arc is drawn along the perimeter of a circle with the given radius and center. The length of the arc is defined by the given start and sweep angles.  
  
 `AngleArc` moves the current position to the ending point of the arc. The arc drawn by this function may appear to be elliptical, depending on the current transformation and mapping mode. Before drawing the arc, this function draws the line segment from the current position to the beginning of the arc. The arc is drawn by constructing an imaginary circle with the specified radius around the specified center point. The starting point of the arc is determined by measuring counterclockwise from the x-axis of the circle by the number of degrees in the start angle. The ending point is similarly located by measuring counterclockwise from the starting point by the number of degrees in the sweep angle.  
  
 If the sweep angle is greater than 360 degrees the arc is swept multiple times. This function draws lines by using the current pen. The figure is not filled.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Arc](../vs140/cdc--arc.md)   
 [CDC::ArcTo](../vs140/cdc--arcto.md)   
 [CDC::MoveTo](../vs140/cdc--moveto.md)   
 [AngleArc](http://msdn.microsoft.com/library/windows/desktop/dd183354)