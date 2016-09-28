---
title: "CPathT::IsUNC"
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
  - "CPathT::IsUNC"
  - "CPathT.IsUNC"
  - "ATL::CPathT::IsUNC"
  - "IsUNC"
  - "ATL.CPathT<StringType>.IsUNC"
  - "ATL.CPathT.IsUNC"
  - "ATL::CPathT<StringType>::IsUNC"
  - "CPathT<StringType>.IsUNC"
  - "CPathT<StringType>::IsUNC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsUNC method"
ms.assetid: 7aae61ec-5b2e-4b5a-a7c0-42fc0d257d5c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::IsUNC
Call this method to determine whether the path is a valid UNC (universal naming convention) path for a server and share.  
  
## Syntax  
  
```  
  
BOOL IsUNC( ) const;  
  
```  
  
## Return Value  
 Returns TRUE if the path is a valid UNC path, or FALSE otherwise.  
  
## Remarks  
 For more information, see [PathIsUNC](http://msdn.microsoft.com/library/windows/desktop/bb773712).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)