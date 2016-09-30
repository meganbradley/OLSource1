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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ExtFloodFill
Fills an area of the display surface with the current brush.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point where filling begins.  
  
 *y*  
 Specifies the logical y-coordinate of the point where filling begins.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the color of the boundary or of the area to be filled. The interpretation of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> depends on the value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the type of flood fill to be performed. It must be either of the following values:  
  
-   **FLOODFILLBORDER** The fill area is bounded by the color specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This style is identical to the filling performed by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
-   **FLOODFILLSURFACE** The fill area is defined by the color specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Filling continues outward in all directions as long as the color is encountered. This style is useful for filling areas with multicolored boundaries.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0 if the filling could not be completed, if the given point has the boundary color specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (if **FLOODFILLBORDER** was requested), if the given point does not have the color specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (if **FLOODFILLSURFACE** was requested), or if the point is outside the clipping region.  
  
## Remarks  
 This member function offers more flexibility than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> because you can specify a fill type in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to **FLOODFILLBORDER**, the area is assumed to be completely bounded by the color specified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The function begins at the point specified by *x* and *y* and fills in all directions to the color boundary.  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set to **FLOODFILLSURFACE**, the function begins at the point specified by *x* and *y* and continues in all directions, filling all adjacent areas containing the color specified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 Only memory-device contexts and devices that support raster-display technology support <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For more information, see the [GetDeviceCaps](../vs140/cdc--getdevicecaps.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::FloodFill](../vs140/cdc--floodfill.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [ExtFloodFill](http://msdn.microsoft.com/library/windows/desktop/dd162709)