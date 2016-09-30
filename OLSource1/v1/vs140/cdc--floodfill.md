---
title: "CDC::FloodFill"
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
  - "CDC::FloodFill"
  - "CDC.FloodFill"
  - "FloodFill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "FloodFill method"
ms.assetid: 2a66a229-d1e7-44b1-9c98-420c9bb6bcb9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::FloodFill
Fills an area of the display surface with the current brush.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point where filling begins.  
  
 *y*  
 Specifies the logical y-coordinate of the point where filling begins.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the color of the boundary.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0 is returned if the filling could not be completed, the given point has the boundary color specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or the point is outside the clipping region.  
  
## Remarks  
 The area is assumed to be bounded as specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function begins at the point specified by *x* and *y* and continues in all directions to the color boundary.  
  
 Only memory-device contexts and devices that support raster-display technology support the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function. For information about **RC_BITBLT** capability, see the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function provides similar capability but greater flexibility.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::ExtFloodFill](../vs140/cdc--extfloodfill.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [FloodFill](http://msdn.microsoft.com/library/windows/desktop/dd162726)