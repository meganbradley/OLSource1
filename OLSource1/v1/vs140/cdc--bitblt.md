---
title: "CDC::BitBlt"
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
  - "CDC::BitBlt"
  - "CDC.BitBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, bitmap functions"
  - "BitBlt method"
ms.assetid: 0baab743-3040-45d4-99bf-470cc6780041
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::BitBlt
Copies a bitmap from the source device context to this current device context.  
  
## Syntax  
  
```  
  
      BOOL BitBlt(  
   int x,  
   int y,  
   int nWidth,  
   int nHeight,  
   CDC* pSrcDC,  
   int xSrc,  
   int ySrc,  
   DWORD dwRop   
);  
```  
  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the destination rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the destination rectangle.  
  
 `nWidth`  
 Specifies the width (in logical units) of the destination rectangle and source bitmap.  
  
 `nHeight`  
 Specifies the height (in logical units) of the destination rectangle and source bitmap.  
  
 `pSrcDC`  
 Pointer to a `CDC` object that identifies the device context from which the bitmap will be copied. It must be **NULL** if *dwRop* specifies a raster operation that does not include a source.  
  
 `xSrc`  
 Specifies the logical x-coordinate of the upper-left corner of the source bitmap.  
  
 `ySrc`  
 Specifies the logical y-coordinate of the upper-left corner of the source bitmap.  
  
 *dwRop*  
 Specifies the raster operation to be performed. Raster-operation codes define how the GDI combines colors in output operations that involve a current brush, a possible source bitmap, and a destination bitmap. See [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of the raster-operation codes for *dwRop* and their descriptions  
  
 For a complete list of raster-operation codes, see [About Raster Operation Codes](http://msdn.microsoft.com/library/windows/desktop/dd162892) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The application can align the windows or client areas on byte boundaries to ensure that the `BitBlt` operations occur on byte-aligned rectangles. (Set the **CS_BYTEALIGNWINDOW** or **CS_BYTEALIGNCLIENT** flags when you register the window classes.)  
  
 `BitBlt` operations on byte-aligned rectangles are considerably faster than `BitBlt` operations on rectangles that are not byte aligned. If you want to specify class styles such as byte-alignment for your own device context, you will have to register a window class rather than relying on the Microsoft Foundation classes to do it for you. Use the global function [AfxRegisterWndClass](../vs140/afxregisterwndclass.md).  
  
 GDI transforms `nWidth` and `nHeight`, once by using the destination device context, and once by using the source device context. If the resulting extents do not match, GDI uses the Windows `StretchBlt` function to compress or stretch the source bitmap as necessary.  
  
 If destination, source, and pattern bitmaps do not have the same color format, the `BitBlt` function converts the source and pattern bitmaps to match the destination. The foreground and background colors of the destination bitmap are used in the conversion.  
  
 When the `BitBlt` function converts a monochrome bitmap to color, it sets white bits (1) to the background color and black bits (0) to the foreground color. The foreground and background colors of the destination device context are used. To convert color to monochrome, `BitBlt` sets pixels that match the background color to white and sets all other pixels to black. `BitBlt` uses the foreground and background colors of the color device context to convert from color to monochrome.  
  
 Note that not all device contexts support `BitBlt`. To check whether a given device context does support `BitBlt`, use the `GetDeviceCaps` member function and specify the **RASTERCAPS** index.  
  
## Example  
 See the example for [CDC::CreateCompatibleDC](../vs140/cdc--createcompatibledc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CDC::PatBlt](../vs140/cdc--patblt.md)   
 [CDC::SetTextColor](../vs140/cdc--settextcolor.md)   
 [CDC::StretchBlt](../vs140/cdc--stretchblt.md)   
 [StretchDIBits](http://msdn.microsoft.com/library/windows/desktop/dd145121)   
 [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370)