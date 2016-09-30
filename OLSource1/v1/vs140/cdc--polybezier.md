---
title: "CDC::PolyBezier"
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
  - "CDC.PolyBezier"
  - "CDC::PolyBezier"
  - "PolyBezier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PolyBezier method"
  - "CDC class, line-output functions"
ms.assetid: 2c57937a-348d-48d3-a027-961466df9366
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::PolyBezier
Draws one or more Bzier splines.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) data structures that contain the endpoints and control points of the spline(s).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of points in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array. This value must be one more than three times the number of splines to be drawn, because each Bzier spline requires two control points and an endpoint, and the initial spline requires an additional starting point.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 This function draws cubic Bzier splines by using the endpoints and control points specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter. The first spline is drawn from the first point to the fourth point by using the second and third points as control points. Each subsequent spline in the sequence needs exactly three more points: the end point of the previous spline is used as the starting point, the next two points in the sequence are control points, and the third is the end point.  
  
 The current position is neither used nor updated by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. The figure is not filled. This function draws lines by using the current pen.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::PolyBezierTo](../vs140/cdc--polybezierto.md)   
 [PolyBezier](http://msdn.microsoft.com/library/windows/desktop/dd162811)