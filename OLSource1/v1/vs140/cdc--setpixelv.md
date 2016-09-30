---
title: "CDC::SetPixelV"
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
  - "CDC::SetPixelV"
  - "CDC.SetPixelV"
  - "SetPixelV"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "SetPixelV method"
ms.assetid: 9dbd4d4f-151d-463f-b57d-acd69fd37c79
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetPixelV
Sets the pixel at the specified coordinates to the closest approximation of the specified color.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the x-coordinate, in logical units, of the point to be set.  
  
 *y*  
 Specifies the y-coordinate, in logical units, of the point to be set.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the color to be used to paint the point.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the logical x- and y-coordinates of the point to be set. You can pass either a [POINT](../vs140/point-structure.md) data structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The point must be in both the clipping region and the visible part of the device surface. Not all devices support the member function. For more information, see the **RC_BITBLT** capability in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is faster than <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> because it does not need to return the color value of the point actually painted.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CDC::SetPixel](../vs140/cdc--setpixel.md)   
 [SetPixelV](http://msdn.microsoft.com/library/windows/desktop/dd145079)