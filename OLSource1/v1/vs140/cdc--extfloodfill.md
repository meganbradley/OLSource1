---
title: "CDC::ExtFloodFill"
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
  - "ExtFloodFill"
  - "CDC.ExtFloodFill"
  - "CDC::ExtFloodFill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "ExtFloodFill method"
ms.assetid: 44c713e0-1f66-4aa5-8c98-8fd618d62394
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ExtFloodFill
Fills an area of the display surface with the current brush.  
  
## Syntax  
  
```  
  
      BOOL ExtFloodFill(  
   int x,  
   int y,  
   COLORREF crColor,  
   UINT nFillType   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point where filling begins.  
  
 *y*  
 Specifies the logical y-coordinate of the point where filling begins.  
  
 `crColor`  
 Specifies the color of the boundary or of the area to be filled. The interpretation of `crColor` depends on the value of `nFillType`.  
  
 `nFillType`  
 Specifies the type of flood fill to be performed. It must be either of the following values:  
  
-   **FLOODFILLBORDER** The fill area is bounded by the color specified by `crColor`. This style is identical to the filling performed by `FloodFill`.  
  
-   **FLOODFILLSURFACE** The fill area is defined by the color specified by `crColor`. Filling continues outward in all directions as long as the color is encountered. This style is useful for filling areas with multicolored boundaries.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0 if the filling could not be completed, if the given point has the boundary color specified by `crColor` (if **FLOODFILLBORDER** was requested), if the given point does not have the color specified by `crColor` (if **FLOODFILLSURFACE** was requested), or if the point is outside the clipping region.  
  
## Remarks  
 This member function offers more flexibility than `FloodFill` because you can specify a fill type in `nFillType`.  
  
 If `nFillType` is set to **FLOODFILLBORDER**, the area is assumed to be completely bounded by the color specified by `crColor`. The function begins at the point specified by *x* and *y* and fills in all directions to the color boundary.  
  
 If `nFillType` is set to **FLOODFILLSURFACE**, the function begins at the point specified by *x* and *y* and continues in all directions, filling all adjacent areas containing the color specified by `crColor`.  
  
 Only memory-device contexts and devices that support raster-display technology support `ExtFloodFill`. For more information, see the [GetDeviceCaps](../vs140/cdc--getdevicecaps.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::FloodFill](../vs140/cdc--floodfill.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [ExtFloodFill](http://msdn.microsoft.com/library/windows/desktop/dd162709)