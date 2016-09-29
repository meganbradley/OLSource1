---
title: "CStringT::operator &lt;="
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
  - "CStringT::operator<="
  - "ATL::CStringT::operator<="
  - "CStringT.operator<="
  - "ATL.CStringT.operator<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<=, strings"
  - "operator <=, strings"
  - "<= operator, comparing specific objects"
ms.assetid: 4722801c-a31a-4e6d-be86-cab67a085e8c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::operator &lt;=
Determines whether the string on the left side of the operator is less than or equal to the string on the right side.  
  
## Syntax  
  
```  
friend bool operator<=(  
   const CStringT& str1,  
   const CStringT& str2  
) throw();  
friend bool operator<=(  
   const CStringT& str1  
   PCXSTR psz2  
) throw();  
friend bool operator<=(  
   PCXSTR psz1  
   const CStringT& str2  
) throw();  
```  
  
#### Parameters  
 `str1`  
 A `CStringT` for comparison.  
  
 `str2`  
 A `CStringT` for comparison.  
  
 `psz1`  
 A pointer to a null-terminated string for comparison.  
  
 `psz2`  
 A pointer to a null-terminated string for comparison.  
  
## Remarks  
 A lexicographical comparison between strings, character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, so the strings are equal.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#146](../vs140/codesnippet/CPP/cstringt--operator--=_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)