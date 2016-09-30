---
title: "CPathT::SkipRoot"
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
  - "CPathT.SkipRoot"
  - "ATL::CPathT::SkipRoot"
  - "SkipRoot"
  - "CPathT<StringType>::SkipRoot"
  - "ATL.CPathT<StringType>.SkipRoot"
  - "ATL::CPathT<StringType>::SkipRoot"
  - "CPathT<StringType>.SkipRoot"
  - "ATL.CPathT.SkipRoot"
  - "CPathT::SkipRoot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SkipRoot method"
ms.assetid: 0bc07c1e-5faa-4442-a68b-af487f9bab12
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::SkipRoot
Call this method to parse a path, ignoring the drive letter or UNC (universal naming convention) server/share path parts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the position of the beginning of the subpath that follows the root (drive letter or UNC server/share).  
  
## Remarks  
 For more information, see [PathSkipRoot](http://msdn.microsoft.com/library/windows/desktop/bb773754).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)