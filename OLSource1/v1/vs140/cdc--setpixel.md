---
title: "CDC::SetPixel"
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
  - "CDC::SetPixel"
  - "CDC.SetPixel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "SetPixel method"
ms.assetid: ee50da62-f0c5-46fc-bfdc-6411db207a11
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetPixel
Sets the pixel at the point specified to the closest approximation of the color specified by `crColor`.  
  
## Syntax  
  
```  
  
      COLORREF SetPixel(  
   int x,  
   int y,  
   COLORREF crColor   
);  
COLORREF SetPixel(  
   POINT point,  
   COLORREF crColor   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point to be set.  
  
 *y*  
 Specifies the logical y-coordinate of the point to be set.  
  
 `crColor`  
 A **COLORREF** RGB value that specifies the color used to paint the point. See [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description of this value.  
  
 `point`  
 Specifies the logical x- and y-coordinates of the point to be set. You can pass either a **POINT** structure or a `CPoint` object for this parameter.  
  
## Return Value  
 An RGB value for the color that the point is actually painted. This value can be different from that specified by `crColor` if an approximation of that color is used. If the function fails (if the point is outside the clipping region), the return value is –1.  
  
## Remarks  
 The point must be in the clipping region. If the point is not in the clipping region, the function does nothing.  
  
 Not all devices support the `SetPixel` function. To determine whether a device supports `SetPixel`, call the `GetDeviceCaps` member function with the **RASTERCAPS** index and check the return value for the **RC_BITBLT** flag.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CDC::GetPixel](../vs140/cdc--getpixel.md)   
 [SetPixel](http://msdn.microsoft.com/library/windows/desktop/dd145078)   
 [POINT Structure](../vs140/point-structure.md)   
 [CPoint Class](../vs140/cpoint-class.md)