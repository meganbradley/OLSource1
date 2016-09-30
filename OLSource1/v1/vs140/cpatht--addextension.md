---
title: "CPathT::AddExtension"
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
  - "CPathT::AddExtension"
  - "CPathT<StringType>.AddExtension"
  - "AddExtension"
  - "ATL::CPathT<StringType>::AddExtension"
  - "ATL.CPathT<StringType>.AddExtension"
  - "CPathT<StringType>::AddExtension"
  - "CPathT.AddExtension"
  - "ATL::CPathT::AddExtension"
  - "ATL.CPathT.AddExtension"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddExtension method"
ms.assetid: 21b0c253-6ea3-4976-b9ea-16ab7b94d37b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::AddExtension
Call this method to add a file extension to a path.  
  
## Syntax  
  
```  
  
      BOOL AddExtension(  
   PCXSTR pszExtension   
);  
```  
  
#### Parameters  
 `pszExtension`  
 The file extension to add.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 For more information, see [PathAddExtension](http://msdn.microsoft.com/library/windows/desktop/bb773563).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)