---
title: "CImage::GetPitch"
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
  - "CImage.GetPitch"
  - "GetPitch"
  - "ATL::CImage::GetPitch"
  - "CImage::GetPitch"
  - "ATL.CImage.GetPitch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPitch method"
ms.assetid: 9756ad0b-904f-48ba-b7bd-5a56662362cb
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::GetPitch
Retrieves the pitch of an image.  
  
## Syntax  
  
```  
  
int GetPitch( ) const throw( );  
  
```  
  
## Return Value  
 The pitch of the image. If the return value is negative, the bitmap is a bottom-up DIB and its origin is the lower left corner. If the return value is positive, the bitmap is a top-down DIB and its origin is the upper left corner.  
  
## Remarks  
 The pitch is the distance, in bytes, between two memory addresses that represent the beginning of one bitmap line and the beginning of the next bitmap line. Because pitch is measured in bytes, the pitch of an image helps you to determine the pixel format. The pitch can also include additional memory, reserved for the bitmap.  
  
 Use `GetPitch` with [GetBits](../vs140/cimage--getbits.md) to find individual pixels of an image.  
  
> [!NOTE]
>  This method supports only DIB section bitmaps.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::GetPixelAddress](../vs140/cimage--getpixeladdress.md)   
 [CImage::GetWidth](../vs140/cimage--getwidth.md)   
 [CImage::GetHeight](../vs140/cimage--getheight.md)