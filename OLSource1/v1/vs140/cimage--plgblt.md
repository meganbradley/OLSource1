---
title: "CImage::PlgBlt"
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
  - "CImage.PlgBlt"
  - "CImage::PlgBlt"
  - "ATL::CImage::PlgBlt"
  - "ATL.CImage.PlgBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PlgBlt method"
ms.assetid: 6ea1f21d-39d0-48e7-824d-25adf81c8743
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::PlgBlt
Performs a bit-block transfer from a rectangle in a source device context into a parallelogram in a destination device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to the destination device context.  
  
 *pPoints*  
 A pointer to an array of three points in logical space that identify three corners of the destination parallelogram. The upper left corner of the source rectangle is mapped to the first point in this array, the upper-right corner to the second point in this array, and the lower left corner to the third point. The lower-right corner of the source rectangle is mapped to the implicit fourth point in the parallelogram.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A handle to an optional monochrome bitmap that is used to mask the colors of the source rectangle.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The x-coordinate of the upper left corner of the monochrome bitmap.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The y-coordinate of the upper left corner of the monochrome bitmap.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the coordinates of the source rectangle.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure indicating the upper left corner of the mask bitmap.  
  
## Return Value  
 Nonzero if successful, otherwise 0.  
  
## Remarks  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> identifies a valid monochrome bitmap, **PlgBit** uses this bitmap to mask the bits of color data from the source rectangle.  
  
 This method applies to Windows NT, versions 4.0 and later only. See [PlgBlt](http://msdn.microsoft.com/library/windows/desktop/dd162804) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::BitBlt](../vs140/cimage--bitblt.md)   
 [CImage::MaskBlt](../vs140/cimage--maskblt.md)