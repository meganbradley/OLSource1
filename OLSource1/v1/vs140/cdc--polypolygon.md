---
title: "CDC::PolyPolygon"
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
  - "CDC::PolyPolygon"
  - "PolyPolygon"
  - "CDC.PolyPolygon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, ellipse and polygon functions"
  - "PolyPolygon method"
ms.assetid: 168d7220-637a-4ccf-8fb1-0b9f09a01fef
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::PolyPolygon
Creates two or more polygons that are filled using the current polygon-filling mode.  
  
## Syntax  
  
```  
  
      BOOL PolyPolygon(  
   LPPOINT lpPoints,  
   LPINT lpPolyCounts,  
   int nCount   
);  
```  
  
#### Parameters  
 `lpPoints`  
 Points to an array of **POINT** structures or `CPoint` objects that define the vertices of the polygons.  
  
 `lpPolyCounts`  
 Points to an array of integers, each of which specifies the number of points in one of the polygons in the `lpPoints` array.  
  
 `nCount`  
 The number of entries in the `lpPolyCounts` array. This number specifies the number of polygons to be drawn. This value must be at least 2.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The polygons may be disjoint or overlapping.  
  
 Each polygon specified in a call to the `PolyPolygon` function must be closed. Unlike polygons created by the **Polygon** member function, the polygons created by `PolyPolygon` are not closed automatically.  
  
 The function creates two or more polygons. To create a single polygon, an application should use the **Polygon** member function.  
  
 The current polygon-filling mode can be retrieved or set by using the `GetPolyFillMode` and `SetPolyFillMode` member functions.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetPolyFillMode](../vs140/cdc--getpolyfillmode.md)   
 [CDC::Polygon](../vs140/cdc--polygon.md)   
 [CDC::Polyline](../vs140/cdc--polyline.md)   
 [CDC::SetPolyFillMode](../vs140/cdc--setpolyfillmode.md)   
 [PolyPolygon](http://msdn.microsoft.com/library/windows/desktop/dd162818)   
 [POINT Structure](../vs140/point-structure.md)   
 [CPoint Class](../vs140/cpoint-class.md)