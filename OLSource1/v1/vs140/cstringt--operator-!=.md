---
title: "CStringT::operator !="
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CStringT.operator!=
  - ATL.CStringT.operator!=
  - ATL::CStringT::operator!=
  - CStringT::operator!=
dev_langs: 
  - C++
helpviewer_keywords: 
  - != operator
  - operator !=, strings
  - operator!=, strings
ms.assetid: 09cf0f54-900f-4b7c-b12e-46f4a8e9feb4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStringT::operator !=
Determines whether two strings are logically not equal.  
  
## Syntax  
  
```  
friend bool operator!=(  
   const CStringT& str1,  
   const CStringT& str2  
) throw();  
friend bool operator!=(  
   const CStringT& str1  
   PCXSTR psz2  
) throw();  
friend bool operator!=(  
   const CStringT& str1,  
   PCYSTR psz2  
) throw();  
friend bool operator!=(  
   const CStringT& str1,  
   XCHAR ch2  
) throw();  
friend bool operator!=(  
   PCXSTR psz1  
   const CStringT& str2  
) throw();  
friend bool operator!=(  
   PCYSTR psz1  
   const CStringT& str2,  
) throw();  
friend bool operator!=(  
   XCHAR ch1  
   const CStringT& str2,  
) throw();  
```  
  
#### Parameters  
 `ch1`  
 An ANSI or Unicode character to concatenate with a string.  
  
 `ch2`  
 An ANSI or Unicode character to concatenate with a string.  
  
 `str1`  
 A `CStringT` for comparison.  
  
 `str2`  
 A `CStringT` for comparison.  
  
 `psz1`  
 A pointer to a null-terminated string for comparison.  
  
 `psz2`  
 A pointer to a null-terminated string for comparison.  
  
## Remarks  
 Tests if a string or character on the left side is not equal to a string or character on the right side.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#143](../vs140/codesnippet/CPP/cstringt--operator-!=_1.cpp)]
  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)