---
title: "CImage::BitBlt"
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
  - "ATL.CImage.BitBlt"
  - "ATL::CImage::BitBlt"
  - "CImage.BitBlt"
  - "CImage::BitBlt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BitBlt method"
ms.assetid: 0c84bf85-7b09-40ea-8e27-06672d917a64
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::BitBlt
Copies a bitmap from the source device context to this current device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The destination **HDC**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The logical x-coordinate of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The logical y-coordinate of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The raster operation to be performed. Raster-operation codes define exactly how to combine the bits of the source, the destination, and the pattern (as defined by the currently selected brush) to form the destination. See [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of other raster-operation codes and their descriptions.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure indicating the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The logical x-coordinate of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The logical y-coordinate of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure indicating the destination rectangle.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A **POINT** structure indicating the upper left corner of the source rectangle.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 For more information, see [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::PlgBlt](../vs140/cimage--plgblt.md)   
 [CImage::StretchBlt](../vs140/cimage--stretchblt.md)   
 [CImage::MaskBlt](../vs140/cimage--maskblt.md)