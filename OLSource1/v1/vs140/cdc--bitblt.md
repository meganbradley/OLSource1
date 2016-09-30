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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::BitBlt
Copies a bitmap from the source device context to this current device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the destination rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the width (in logical units) of the destination rectangle and source bitmap.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the height (in logical units) of the destination rectangle and source bitmap.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that identifies the device context from which the bitmap will be copied. It must be **NULL** if *dwRop* specifies a raster operation that does not include a source.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the source bitmap.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the source bitmap.  
  
 *dwRop*  
 Specifies the raster operation to be performed. Raster-operation codes define how the GDI combines colors in output operations that involve a current brush, a possible source bitmap, and a destination bitmap. See [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of the raster-operation codes for *dwRop* and their descriptions  
  
 For a complete list of raster-operation codes, see [About Raster Operation Codes](http://msdn.microsoft.com/library/windows/desktop/dd162892) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The application can align the windows or client areas on byte boundaries to ensure that the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operations occur on byte-aligned rectangles. (Set the **CS_BYTEALIGNWINDOW** or **CS_BYTEALIGNCLIENT** flags when you register the window classes.)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operations on byte-aligned rectangles are considerably faster than <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operations on rectangles that are not byte aligned. If you want to specify class styles such as byte-alignment for your own device context, you will have to register a window class rather than relying on the Microsoft Foundation classes to do it for you. Use the global function [AfxRegisterWndClass](../vs140/afxregisterwndclass.md).  
  
 GDI transforms <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, once by using the destination device context, and once by using the source device context. If the resulting extents do not match, GDI uses the Windows <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function to compress or stretch the source bitmap as necessary.  
  
 If destination, source, and pattern bitmaps do not have the same color format, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function converts the source and pattern bitmaps to match the destination. The foreground and background colors of the destination bitmap are used in the conversion.  
  
 When the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function converts a monochrome bitmap to color, it sets white bits (1) to the background color and black bits (0) to the foreground color. The foreground and background colors of the destination device context are used. To convert color to monochrome, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> sets pixels that match the background color to white and sets all other pixels to black. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> uses the foreground and background colors of the color device context to convert from color to monochrome.  
  
 Note that not all device contexts support <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. To check whether a given device context does support <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member function and specify the **RASTERCAPS** index.  
  
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