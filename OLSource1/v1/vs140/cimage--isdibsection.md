---
title: "CImage::IsDIBSection"
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
  - "ATL::CImage::IsDIBSection"
  - "CImage::IsDIBSection"
  - "CImage.IsDIBSection"
  - "IsDIBSection"
  - "ATL.CImage.IsDIBSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDIBSection method"
ms.assetid: 9be37711-be46-42bb-8caa-3b7fe0349ebd
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::IsDIBSection
Determines if the attached bitmap is a DIB section.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 **true** if the attached bitmap is a DIB section. Otherwise **false**.  
  
## Remarks  
 If the bitmap is not a DIB section, you cannot use the following <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> methods, which support only DIB section bitmaps:  
  
-   [GetBits](../vs140/cimage--getbits.md)  
  
-   [GetColorTable](../vs140/cimage--getcolortable.md)  
  
-   [GetMaxColorTableEntries](../vs140/cimage--getmaxcolortableentries.md)  
  
-   [GetPitch](../vs140/cimage--getpitch.md)  
  
-   [GetPixelAddress](../vs140/cimage--getpixeladdress.md)  
  
-   [IsIndexed](../vs140/cimage--isindexed.md)  
  
-   [SetColorTable](../vs140/cimage--setcolortable.md)  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::Attach](../vs140/cimage--attach.md)