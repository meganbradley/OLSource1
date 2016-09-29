---
title: "CDC::StretchBlt"
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
  - "CDC::StretchBlt"
  - "CDC.StretchBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "StretchBlt method"
ms.assetid: 3823b3f3-609b-4506-915b-0f28d5d77b8f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::StretchBlt
Copies a bitmap from a source rectangle into a destination rectangle, stretching or compressing the bitmap if necessary to fit the dimensions of the destination rectangle.  
  
## Syntax  
  
```  
  
      BOOL StretchBlt(  
   int x,  
   int y,  
   int nWidth,  
   int nHeight,  
   CDC* pSrcDC,  
   int xSrc,  
   int ySrc,  
   int nSrcWidth,  
   int nSrcHeight,  
   DWORD dwRop   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the x-coordinate (in logical units) of the upper-left corner of the destination rectangle.  
  
 *y*  
 Specifies the y-coordinate (in logical units) of the upper-left corner of the destination rectangle.  
  
 `nWidth`  
 Specifies the width (in logical units) of the destination rectangle.  
  
 `nHeight`  
 Specifies the height (in logical units) of the destination rectangle.  
  
 `pSrcDC`  
 Specifies the source device context.  
  
 `xSrc`  
 Specifies the x-coordinate (in logical units) of the upper-left corner of the source rectangle.  
  
 `ySrc`  
 Specifies the y-coordinate (in logical units) of the upper-left corner of the source rectangle.  
  
 `nSrcWidth`  
 Specifies the width (in logical units) of the source rectangle.  
  
 `nSrcHeight`  
 Specifies the height (in logical units) of the source rectangle.  
  
 *dwRop*  
 Specifies the raster operation to be performed. Raster operation codes define how GDI combines colors in output operations that involve a current brush, a possible source bitmap, and a destination bitmap. This parameter may be one of the following values:  
  
-   **BLACKNESS** Turns all output black.  
  
-   **DSTINVERT** Inverts the destination bitmap.  
  
-   **MERGECOPY** Combines the pattern and the source bitmap using the Boolean AND operator.  
  
-   **MERGEPAINT** Combines the inverted source bitmap with the destination bitmap using the Boolean OR operator.  
  
-   **NOTSRCCOPY** Copies the inverted source bitmap to the destination.  
  
-   **NOTSRCERASE** Inverts the result of combining the destination and source bitmaps using the Boolean OR operator.  
  
-   **PATCOPY** Copies the pattern to the destination bitmap.  
  
-   **PATINVERT** Combines the destination bitmap with the pattern using the Boolean XOR operator.  
  
-   **PATPAINT** Combines the inverted source bitmap with the pattern using the Boolean OR operator. Combines the result of this operation with the destination bitmap using the Boolean OR operator.  
  
-   **SRCAND** Combines pixels of the destination and source bitmaps using the Boolean AND operator.  
  
-   **SRCCOPY** Copies the source bitmap to the destination bitmap.  
  
-   **SRCERASE** Inverts the destination bitmap and combines the result with the source bitmap using the Boolean AND operator.  
  
-   **SRCINVERT** Combines pixels of the destination and source bitmaps using the Boolean XOR operator.  
  
-   **SRCPAINT** Combines pixels of the destination and source bitmaps using the Boolean OR operator.  
  
-   **WHITENESS** Turns all output white.  
  
## Return Value  
 Nonzero if the bitmap is drawn; otherwise 0.  
  
## Remarks  
 The function uses the stretching mode of the destination device context (set by `SetStretchBltMode`) to determine how to stretch or compress the bitmap.  
  
 The `StretchBlt` function moves the bitmap from the source device given by `pSrcDC` to the destination device represented by the device-context object whose member function is being called. The `xSrc`, `ySrc`, `nSrcWidth`, and `nSrcHeight` parameters define the upper-left corner and dimensions of the source rectangle. The *x*, *y*, `nWidth`, and `nHeight` parameters give the upper-left corner and dimensions of the destination rectangle. The raster operation specified by *dwRop* defines how the source bitmap and the bits already on the destination device are combined.  
  
 The `StretchBlt` function creates a mirror image of a bitmap if the signs of the `nSrcWidth` and `nWidth` or `nSrcHeight` and `nHeight` parameters differ. If `nSrcWidth` and `nWidth` have different signs, the function creates a mirror image of the bitmap along the x-axis. If `nSrcHeight` and `nHeight` have different signs, the function creates a mirror image of the bitmap along the y-axis.  
  
 The `StretchBlt` function stretches or compresses the source bitmap in memory and then copies the result to the destination. If a pattern is to be merged with the result, it is not merged until the stretched source bitmap is copied to the destination. If a brush is used, it is the selected brush in the destination device context. The destination coordinates are transformed according to the destination device context; the source coordinates are transformed according to the source device context.  
  
 If the destination, source, and pattern bitmaps do not have the same color format, `StretchBlt` converts the source and pattern bitmaps to match the destination bitmaps. The foreground and background colors of the destination device context are used in the conversion.  
  
 If `StretchBlt` must convert a monochrome bitmap to color, it sets white bits (1) to the background color and black bits (0) to the foreground color. To convert color to monochrome, it sets pixels that match the background color to white (1) and sets all other pixels to black (0). The foreground and background colors of the device context with color are used.  
  
 Not all devices support the `StretchBlt` function. To determine whether a device supports `StretchBlt`, call the `GetDeviceCaps` member function with the **RASTERCAPS** index and check the return value for the **RC_STRETCHBLT** flag.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BitBlt](../vs140/cdc--bitblt.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CDC::SetStretchBltMode](../vs140/cdc--setstretchbltmode.md)   
 [StretchBlt](http://msdn.microsoft.com/library/windows/desktop/dd145120)