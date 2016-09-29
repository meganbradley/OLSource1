---
title: "CDC::GetPixel"
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
  - "CDC::GetPixel"
  - "CDC.GetPixel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "GetPixel method"
ms.assetid: 87698b87-38cc-42dc-a411-2d9d6d94c15a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetPixel
Retrieves the RGB color value of the pixel at the point specified by *x* and *y*.  
  
## Syntax  
  
```  
  
      COLORREF GetPixel(  
   int x,  
   int y   
) const;  
COLORREF GetPixel(  
   POINT point   
) const;  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point to be examined.  
  
 *y*  
 Specifies the logical y-coordinate of the point to be examined.  
  
 `point`  
 Specifies the logical x- and y-coordinates of the point to be examined.  
  
## Return Value  
 For either version of the function, an RGB color value for the color of the given point. It is –1 if the coordinates do not specify a point in the clipping region.  
  
## Remarks  
 The point must be in the clipping region. If the point is not in the clipping region, the function has no effect and returns –1.  
  
 Not all devices support the **GetPixel** function. For more information, see the **RC_BITBLT** raster capability under the [GetDeviceCaps](../vs140/cdc--getdevicecaps.md) member function.  
  
 The **GetPixel** member function has two forms. The first takes two coordinate values; the second takes either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CDC::SetPixel](../vs140/cdc--setpixel.md)   
 [GetPixel](http://msdn.microsoft.com/library/windows/desktop/dd144909)   
 [POINT Structure](../vs140/point-structure.md)   
 [CPoint Class](../vs140/cpoint-class.md)