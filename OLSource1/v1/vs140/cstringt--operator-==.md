---
title: "CStringT::operator =="
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
  - "CStringT.operator=="
  - "ATL.CStringT.operator=="
  - "ATL::CStringT::operator=="
  - "CStringT::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, strings"
  - "operator ==, strings"
  - "== operator"
ms.assetid: 1edc0f09-00e2-4760-8723-cc399112d4b3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::operator ==
Determines whether two strings are logically equal.  
  
## Syntax  
  
```  
friend bool operator==(  
   const CStringT& str1,  
   const CStringT& str2  
) throw();  
friend bool operator==(  
   const CStringT& str1  
   PCXSTR psz2  
) throw();  
friend bool operator==(  
   const CStringT& str1,  
   PCYSTR psz2  
) throw();  
friend bool operator==(  
   const CStringT& str1,  
   XCHAR ch2  
) throw();  
friend bool operator==(  
   PCXSTR psz1  
   const CStringT& str2  
) throw();  
friend bool operator==(  
   PCYSTR psz1  
   const CStringT& str2,  
) throw();  
friend bool operator==(  
   XCHAR ch1  
   const CStringT& str2,  
) throw();  
```  
  
#### Parameters  
 `ch1`  
 An ANSI or Unicode character for comparison.  
  
 `ch2`  
 An ANSI or Unicode character for comparison.  
  
 `str1`  
 A `CStringT` for comparison.  
  
 `str2`  
 A `CStringT` for comparison.  
  
 `psz1`  
 A pointer to a null-terminated string for comparison.  
  
 `psz2`  
 A pointer to a null-terminated string for comparison.  
  
## Remarks  
 Tests whether a string or character on the left side is equal to a string or character on the right side, and returns TRUE or FALSE accordingly.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#142](../vs140/codesnippet/CPP/cstringt--operator-==_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)