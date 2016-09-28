---
title: "CPathT::IsPrefix"
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
  - "ATL::CPathT<StringType>::IsPrefix"
  - "CPathT<StringType>::IsPrefix"
  - "CPathT.IsPrefix"
  - "ATL::CPathT::IsPrefix"
  - "ATL.CPathT.IsPrefix"
  - "ATL.CPathT<StringType>.IsPrefix"
  - "IsPrefix"
  - "CPathT::IsPrefix"
  - "CPathT<StringType>.IsPrefix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPrefix method"
ms.assetid: 4cd50647-1327-43e6-949d-ce86def48a4b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::IsPrefix
Call this method to determine whether a path contains a valid prefix of the type passed by `pszPrefix`.  
  
## Syntax  
  
```  
  
      BOOL IsPrefix(  
   PCXSTR pszPrefix   
) const;  
```  
  
#### Parameters  
 `pszPrefix`  
 The prefix for which to search. A prefix is one of these types: "C:\\\\", ".", "..", "..\\\\".  
  
## Return Value  
 Returns TRUE if the path contains the prefix, or FALSE otherwise.  
  
## Remarks  
 For more information, see [PathIsPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773650).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)