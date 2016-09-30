---
title: "BITMAP Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "BITMAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BITMAP structure"
ms.assetid: 05d33b4d-7232-4643-a108-87dda8ff5f22
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BITMAP Structure
The **BITMAP** structure defines the height, width, color format, and bit values of a logical bitmap**.**  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *bmType*  
 Specifies the bitmap type. For logical bitmaps, this member must be 0.  
  
 *bmWidth*  
 Specifies the width of the bitmap in pixels. The width must be greater than 0.  
  
 *bmHeight*  
 Specifies the height of the bitmap in raster lines. The height must be greater than 0.  
  
 *bmWidthBytes*  
 Specifies the number of bytes in each raster line. This value must be an even number since the graphics device interface (GDI) assumes that the bit values of a bitmap form an array of integer (2-byte) values. In other words, **bmWidthBytes** \* 8 must be the next multiple of 16 greater than or equal to the value obtained when the **bmWidth** member is multiplied by the **bmBitsPixel** member.  
  
 *bmPlanes*  
 Specifies the number of color planes in the bitmap.  
  
 *bmBitsPixel*  
 Specifies the number of adjacent color bits on each plane needed to define a pixel.  
  
 *bmBits*  
 Points to the location of the bit values for the bitmap. The **bmBits** member must be a long pointer to an array of 1-byte values.  
  
## Remarks  
 The currently used bitmap formats are monochrome and color. The monochrome bitmap uses a 1-bit, 1-plane format. Each scan is a multiple of 16 bits.  
  
 Scans are organized as follows for a monochrome bitmap of height *n*:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 The pixels on a monochrome device are either black or white. If the corresponding bit in the bitmap is 1, the pixel is turned on (white). If the corresponding bit in the bitmap is 0, the pixel is turned off (black).  
  
 All devices support bitmaps that have the **RC_BITBLT** bit set in the **RASTERCAPS** index of the [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md) member function.  
  
 Each device has its own unique color format. In order to transfer a bitmap from one device to another, use the [GetDIBits](http://msdn.microsoft.com/library/windows/desktop/dd144879) and [SetDIBits](http://msdn.microsoft.com/library/windows/desktop/dd162973) Windows functions.  
  
## Requirements  
 **Header:** wingdi.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CBitmap::CreateBitmapIndirect](../vs140/cbitmap--createbitmapindirect.md)