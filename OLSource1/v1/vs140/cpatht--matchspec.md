---
title: "CPathT::MatchSpec"
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
  - "CPathT<StringType>::MatchSpec"
  - "ATL::CPathT<StringType>::MatchSpec"
  - "ATL.CPathT.MatchSpec"
  - "CPathT::MatchSpec"
  - "MatchSpec"
  - "CPathT.MatchSpec"
  - "ATL.CPathT<StringType>.MatchSpec"
  - "CPathT<StringType>.MatchSpec"
  - "ATL::CPathT::MatchSpec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MatchSpec method"
ms.assetid: 25882732-9d58-41e3-ab6c-a22fab8cc2c1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::MatchSpec
Call this method to search the path for a string containing a wildcard match type.  
  
## Syntax  
  
```  
  
      BOOL MatchSpec(  
   PCXSTR pszSpec   
) const;  
```  
  
#### Parameters  
 `pszSpec`  
 Pointer to a null-terminated string with the file type for which to search. For example, to test whether the file at the current path is a DOC file, `pszSpec` should be set to "*.doc".  
  
## Return Value  
 Returns TRUE if the string matches, or FALSE otherwise.  
  
## Remarks  
 For more information, see [PathMatchSpec](http://msdn.microsoft.com/library/windows/desktop/bb773727).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)