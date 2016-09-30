---
title: "CImage::Create"
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
  - "ATL.CImage.Create"
  - "CImage::Create"
  - "CImage.Create"
  - "ATL::CImage::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 447f4ebf-5cf4-4862-ab4c-ee643c78c717
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::Create
Creates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> bitmap and attach it to the previously constructed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The width of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> bitmap, in pixels.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The height of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> bitmap, in pixels. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is positive, the bitmap is a bottom-up DIB and its origin is the lower left corner. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is negative, the bitmap is a top-down DIB and its origin is the upper left corner.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The numbers of bits per pixel in the bitmap. Usually 4, 8, 16, 24, or 32. Can be 1 for monochrome bitmaps or masks.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies if the bitmap object has an alpha channel. Can be a combination of zero or more of the following values:  
  
-   **createAlphaChannel** Can only be used if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is 32, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is **BI_RGB**. If specified, the created image has an alpha (transparency) value for each pixel, stored in the 4th byte of each pixel (unused in a non-alpha 32-bit image). This alpha channel is automatically used when calling [CImage::AlphaBlend](../vs140/cimage--alphablend.md).  
  
> [!NOTE]
>  In calls to [CImage::Draw](../vs140/cimage--draw.md), images with an alpha channel are automatically alpha blended to the destination.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::CImage](../vs140/cimage--cimage.md)   
 [CImage::AlphaBlend](../vs140/cimage--alphablend.md)   
 [CImage::CreateEx](../vs140/cimage--createex.md)