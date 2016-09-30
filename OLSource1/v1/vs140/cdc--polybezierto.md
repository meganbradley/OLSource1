---
title: "CDC::PolyBezierTo"
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
  - "PolyBezierTo"
  - "CDC::PolyBezierTo"
  - "CDC.PolyBezierTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PolyBezierTo method"
  - "CDC class, line-output functions"
ms.assetid: c7783261-ff4e-4fa8-9d78-0c91071c4898
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::PolyBezierTo
Draws one or more Bzier splines.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) data structures that contains the endpoints and control points.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of points in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array. This value must be three times the number of splines to be drawn, because each Bzier spline requires two control points and an end point.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 This function draws cubic Bzier splines by using the control points specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter. The first spline is drawn from the current position to the third point by using the first two points as control points. For each subsequent spline, the function needs exactly three more points, and uses the end point of the previous spline as the starting point for the next. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> moves the current position to the end point of the last Bzier spline. The figure is not filled. This function draws lines by using the current pen.  
  
## Example  
 See the example for [CDC::BeginPath](../vs140/cdc--beginpath.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::MoveTo](../vs140/cdc--moveto.md)   
 [CDC::PolyBezier](../vs140/cdc--polybezier.md)   
 [PolyBezierTo](http://msdn.microsoft.com/library/windows/desktop/dd162812)