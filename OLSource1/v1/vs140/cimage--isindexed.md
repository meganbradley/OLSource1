---
title: "CImage::IsIndexed"
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
  - "CImage.IsIndexed"
  - "ATL.CImage.IsIndexed"
  - "CImage::IsIndexed"
  - "ATL::CImage::IsIndexed"
  - "IsIndexed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsIndexed method"
ms.assetid: e8ece079-9431-4f01-9742-1607bc160756
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::IsIndexed
Determines whether a bitmap's pixels are mapped to a color palette.  
  
## Syntax  
  
```  
  
bool IsIndexed( ) const throw( );  
  
```  
  
## Return Value  
 **true** if indexed; otherwise **false**.  
  
## Remarks  
 This method returns **true** only if the bitmap is 8-bit (256 colors) or less.  
  
> [!NOTE]
>  This method supports only DIB section bitmaps.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::GetColorTable](../vs140/cimage--getcolortable.md)