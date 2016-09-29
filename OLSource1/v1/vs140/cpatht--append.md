---
title: "CPathT::Append"
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
  - "CPathT::Append"
  - "ATL::CPathT::Append"
  - "CPathT.Append"
  - "ATL.CPathT<StringType>.Append"
  - "ATL::CPathT<StringType>::Append"
  - "ATL.CPathT.Append"
  - "CPathT<StringType>::Append"
  - "CPathT<StringType>.Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Append method"
ms.assetid: 5bfb5ce6-ae7e-440d-af95-6ee1197215eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::Append
Call this method to append a string to the current path.  
  
## Syntax  
  
```  
  
      BOOL Append(  
   PCXSTR pszMore   
);  
```  
  
#### Parameters  
 `pszMore`  
 The string to append.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 For more information, see [PathAppend](http://msdn.microsoft.com/library/windows/desktop/bb773565).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)