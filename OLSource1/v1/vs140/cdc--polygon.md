---
title: "CDC::Polygon"
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
  - "CDC::Polygon"
  - "Polygon"
  - "CDC.Polygon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, ellipse and polygon functions"
  - "Polygon method"
ms.assetid: a2621785-7f54-49fd-8ef1-3fa558e9b6fd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Polygon
Draws a polygon consisting of two or more points (vertices) connected by lines, using the current pen.  
  
## Syntax  
  
```  
  
      BOOL Polygon(  
   LPPOINT lpPoints,  
   int nCount   
);  
```  
  
#### Parameters  
 `lpPoints`  
 Points to an array of points that specifies the vertices of the polygon. Each point in the array is a **POINT** structure or a `CPoint` object.  
  
 `nCount`  
 Specifies the number of vertices in the array.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The system closes the polygon automatically, if necessary, by drawing a line from the last vertex to the first.  
  
 The current polygon-filling mode can be retrieved or set by using the `GetPolyFillMode` and `SetPolyFillMode` member functions.  
  
## Example  
 [!code[NVC_MFCDocView#38](../vs140/codesnippet/CPP/cdc--polygon_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetPolyFillMode](../vs140/cdc--getpolyfillmode.md)   
 [CDC::Polyline](../vs140/cdc--polyline.md)   
 [CDC::PolyPolygon](../vs140/cdc--polypolygon.md)   
 [CDC::SetPolyFillMode](../vs140/cdc--setpolyfillmode.md)   
 [CPoint Class](../vs140/cpoint-class.md)   
 [Polygon](http://msdn.microsoft.com/library/windows/desktop/dd162814)