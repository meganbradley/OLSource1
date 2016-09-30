---
title: "CImage::GetMaxColorTableEntries"
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
  - "ATL::CImage::GetMaxColorTableEntries"
  - "GetMaxColorTableEntries"
  - "CImage::GetMaxColorTableEntries"
  - "ATL.CImage.GetMaxColorTableEntries"
  - "CImage.GetMaxColorTableEntries"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMaxColorTableEntries method"
ms.assetid: 2c5cec92-8070-4c6b-b61b-3fe2d75c7f4b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::GetMaxColorTableEntries
Retrieves the maximum number of entries in the color table.  
  
## Syntax  
  
```  
  
int GetMaxColorTableEntries( ) const throw( );  
  
```  
  
## Return Value  
 The number of entries in the color table.  
  
## Remarks  
 This method supports only DIB section bitmaps.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::GetColorTable](../vs140/cimage--getcolortable.md)