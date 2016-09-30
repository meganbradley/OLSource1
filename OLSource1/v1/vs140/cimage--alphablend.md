---
title: "CImage::AlphaBlend"
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
  - "ATL::CImage::AlphaBlend"
  - "CImage::AlphaBlend"
  - "CImage.AlphaBlend"
  - "ATL.CImage.AlphaBlend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AlphaBlend method"
  - "AC_SRC_OVER method"
ms.assetid: 558c1937-c571-4f17-adbc-e6dfd4723005
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::AlphaBlend
Displays bitmaps that have transparent or semitransparent pixels.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the destination device context.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 *bSrcAlpha*  
 An alpha transparency value to be used on the entire source bitmap. The default 0xff (255) assumes that your image is opaque, and that you want to use per-pixel alpha values only.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The alpha-blending function for source and destination bitmaps, a global alpha value to be applied to the entire source bitmap, and format information for the source bitmap. The source and destination blend functions are currently limited to **AC_SRC_OVER**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that identifies the upper left corner of the destination rectangle, in logical units.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The logical x-coordinate of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The logical y-coordinate of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, identifying the destination.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure, identifying the source.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Alpha-blend bitmaps support color blending on a per-pixel basis.  
  
 When <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is set to the default of **AC_SRC_OVER**, the source bitmap is placed over the destination bitmap based on the alpha values of the source pixels.  
  
 This method is applicable to Microsoft Windows 2000, Windows 98, and later systems. See [AlphaBlend](http://msdn.microsoft.com/library/windows/desktop/dd183351) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [BLENDFUNCTION](http://msdn.microsoft.com/library/windows/desktop/dd183393)