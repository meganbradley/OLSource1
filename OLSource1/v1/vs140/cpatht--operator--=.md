---
title: "CPathT::operator +="
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
  - "CPathT<StringType>.operator+="
  - "ATL.CPathT.operator+="
  - "CPathT.operator+="
  - "ATL::CPathT<StringType>::operator+="
  - "ATL.CPathT<StringType>.operator+="
  - "CPathT::operator+="
  - "ATL::CPathT::operator+="
  - "CPathT<StringType>::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+= operator, appending strings"
  - "operator+=, appending string to path"
  - "operator +=, appending string to path"
ms.assetid: 094917ac-99e6-489f-bc34-4249bab60f3e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::operator +=
This operator appends a string to the path.  
  
## Syntax  
  
```  
  
      CPathT< StringType >& operator +=(  
   PCXSTR pszMore   
);  
```  
  
#### Parameters  
 `pszMore`  
 The string to append.  
  
## Return Value  
 Returns the updated path.  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)