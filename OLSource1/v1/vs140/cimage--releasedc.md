---
title: "CImage::ReleaseDC"
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
  - "CImage.ReleaseDC"
  - "ATL.CImage.ReleaseDC"
  - "ATL::CImage::ReleaseDC"
  - "CImage::ReleaseDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReleaseDC method"
ms.assetid: 58ce99a6-f514-4f2d-a762-6d506aa37b33
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::ReleaseDC
Releases the device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Because only one bitmap can be selected into a device context at a time, you must call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for each call to [GetDC](../vs140/cimage--getdc.md).  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)