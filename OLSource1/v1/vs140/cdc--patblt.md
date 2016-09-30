---
title: "CDC::PatBlt"
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
  - "CDC.PatBlt"
  - "CDC::PatBlt"
  - "PatBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "PatBlt method"
ms.assetid: 7d90adc1-4beb-4e9c-ac94-3e345a70f0d1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::PatBlt
Creates a bit pattern on the device.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the rectangle that is to receive the pattern.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the rectangle that is to receive the pattern.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the width (in logical units) of the rectangle that is to receive the pattern.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the height (in logical units) of the rectangle that is to receive the pattern.  
  
 *dwRop*  
 Specifies the raster-operation code. Raster-operation codes (ROPs) define how GDI combines colors in output operations that involve a current brush, a possible source bitmap, and a destination bitmap. This parameter can be one of the following values:  
  
-   **PATCOPY** Copies pattern to destination bitmap.  
  
-   **PATINVERT** Combines destination bitmap with pattern using the Boolean XOR operator.  
  
-   **DSTINVERT** Inverts the destination bitmap.  
  
-   **BLACKNESS** Turns all output black.  
  
-   **WHITENESS** Turns all output white.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The pattern is a combination of the selected brush and the pattern already on the device. The raster-operation code specified by *dwRop* defines how the patterns are to be combined. The raster operations listed for this function are a limited subset of the full 256 ternary raster-operation codes; in particular, a raster-operation code that refers to a source cannot be used.  
  
 Not all device contexts support the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function. To determine whether a device context supports <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function with the **RASTERCAPS** index and check the return value for the **RC_BITBLT** flag.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [PatBlt](http://msdn.microsoft.com/library/windows/desktop/dd162778)