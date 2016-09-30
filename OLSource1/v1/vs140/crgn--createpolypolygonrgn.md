---
title: "CRgn::CreatePolyPolygonRgn"
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
  - "CRgn.CreatePolyPolygonRgn"
  - "CRgn::CreatePolyPolygonRgn"
  - "CreatePolyPolygonRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CreatePolyPolygonRgn method"
ms.assetid: 09520a83-d59f-4ac7-9b7f-8ec063b58149
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CreatePolyPolygonRgn
Creates a region consisting of a series of closed polygons.  
  
## Syntax  
  
```  
  
      BOOL CreatePolyPolygonRgn(  
   LPPOINT lpPoints,  
   LPINT lpPolyCounts,  
   int nCount,  
   int nPolyFillMode   
);  
```  
  
#### Parameters  
 `lpPoints`  
 Points to an array of **POINT** structures or an array of `CPoint` objects that defines the vertices of the polygons. Each polygon must be explicitly closed because the system does not close them automatically. The polygons are specified consecutively. The **POINT** structure has the following form:  
  
 `typedef struct tagPOINT {`  
  
 `int x;`  
  
 `int y;`  
  
 `} POINT;`  
  
 `lpPolyCounts`  
 Points to an array of integers. The first integer specifies the number of vertices in the first polygon in the `lpPoints` array, the second integer specifies the number of vertices in the second polygon, and so on.  
  
 `nCount`  
 Specifies the total number of integers in the `lpPolyCounts` array.  
  
 `nPolyFillMode`  
 Specifies the polygon-filling mode. This value may be either **ALTERNATE** or **WINDING**.  
  
## Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
## Remarks  
 The resulting region is stored in the `CRgn` object.  
  
 The polygons may be disjoint, or they may overlap.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When the polygon-filling mode is **ALTERNATE**, the system fills the area between odd-numbered and even-numbered polygon sides on each scan line. That is, the system fills the area between the first and second side, between the third and fourth side, and so on.  
  
 When the polygon-filling mode is **WINDING**, the system uses the direction in which a figure was drawn to determine whether to fill an area. Each line segment in a polygon is drawn in either a clockwise or a counterclockwise direction. Whenever an imaginary line drawn from an enclosed area to the outside of a figure passes through a clockwise line segment, a count is incremented. When the line passes through a counterclockwise line segment, the count is decremented. The area is filled if the count is nonzero when the line reaches the outside of the figure.  
  
 When an application has finished using a region created with the `CreatePolyPolygonRgn` function, it should select the region out of the device context and use the [CGDIObject::DeleteObject](../vs140/cgdiobject--deleteobject.md) member function to remove it.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRgn::CreatePolygonRgn](../vs140/crgn--createpolygonrgn.md)   
 [CDC::SetPolyFillMode](../vs140/cdc--setpolyfillmode.md)   
 [CreatePolyPolygonRgn](http://msdn.microsoft.com/library/windows/desktop/dd183512)