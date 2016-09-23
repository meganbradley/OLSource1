---
title: "CDC::GetPath"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDC.GetPath
  - GetPath
  - CDC::GetPath
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPath method
  - CDC class, path functions
ms.assetid: 4290e500-7ccc-4590-87e7-e688b2b8e938
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetPath
Retrieves the coordinates defining the endpoints of lines and the control points of curves found in the path that is selected into the device context.  
  
## Syntax  
  
```  
  
      int GetPath(  
   LPPOINT lpPoints,  
   LPBYTE lpTypes,  
   int nCount   
) const;  
```  
  
#### Parameters  
 `lpPoints`  
 Points to an array of [POINT](../vs140/point-structure.md) data structures or `CPoint` objects where the line endpoints and curve control points are placed.  
  
 `lpTypes`  
 Points to an array of bytes where the vertex types are placed. Values are one of the following:  
  
-   **PT_MOVETO** Specifies that the corresponding point in `lpPoints` starts a disjoint figure.  
  
-   **PT_LINETO** Specifies that the previous point and the corresponding point in `lpPoints` are the endpoints of a line.  
  
-   **PT_BEZIERTO** Specifies that the corresponding point in `lpPoints` is a control point or ending point for a Bzier curve.  
  
     **PT_BEZIERTO** types always occur in sets of three. The point in the path immediately preceding them defines the starting point for the Bzier curve. The first two **PT_BEZIERTO** points are the control points, and the third **PT_BEZIERTO** point is the end point (if hard-coded).  
  
     A **PT_LINETO** or **PT_BEZIERTO** type may be combined with the following flag (by using the bitwise operator `OR`) to indicate that the corresponding point is the last point in a figure and that the figure should be closed:  
  
-   **PT_CLOSEFIGURE** Specifies that the figure is automatically closed after the corresponding line or curve is drawn. The figure is closed by drawing a line from the line or curve endpoint to the point corresponding to the last **PT_MOVETO**.  
  
 `nCount`  
 Specifies the total number of [POINT](../vs140/point-structure.md) data structures that may be placed in the `lpPoints` array. This value must be the same as the number of bytes that may be placed in the `lpTypes` array.  
  
## Return Value  
 If the `nCount` parameter is nonzero, the number of points enumerated. If `nCount` is 0, the total number of points in the path (and `GetPath` writes nothing to the buffers). If `nCount` is nonzero and is less than the number of points in the path, the return value is -1.  
  
## Remarks  
 The device context must contain a closed path. The points of the path are returned in logical coordinates. Points are stored in the path in device coordinates, so `GetPath` changes the points from device coordinates to logical coordinates by using the inverse of the current transformation. The `FlattenPath` member function may be called before `GetPath`, to convert all curves in the path into line segments.  
  
## Example  
 See the example for [CDC::BeginPath](../vs140/cdc--beginpath.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::FlattenPath](../vs140/cdc--flattenpath.md)   
 [CDC::PolyDraw](../vs140/cdc--polydraw.md)   
 [CDC::WidenPath](../vs140/cdc--widenpath.md)