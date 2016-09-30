---
title: "CImage::GetDC"
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
  - "ATL.CImage.GetDC"
  - "CImage::GetDC"
  - "ATL::CImage::GetDC"
  - "CImage.GetDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDC method"
ms.assetid: 4cbb0bc9-4545-402e-b0cd-9058097a7d1b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::GetDC
Retrieves the device context that currently has the image selected into it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A handle to a device context.  
  
## Remarks  
 For each call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, you must have a subsequent call to [ReleaseDC](../vs140/cimage--releasedc.md).  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::GetBits](../vs140/cimage--getbits.md)   
 [CImage::GetBPP](../vs140/cimage--getbpp.md)