---
title: "CStringT::operator +"
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
  - "ATL::CStringT::operator+"
  - "CStringT::operator+"
  - "CStringT.operator+"
  - "ATL.CStringT.operator+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+ operator, with specific objects"
ms.assetid: 39569564-290e-4b6f-a829-2919556bee32
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::operator +
Concatenates two strings or a character and a string.  
  
## Syntax  
  
```  
friend CStringT operator+(  
   const CStringT& str1,  
   const CStringT& str2  
);  
friend CStringT operator+(  
   const CStringT& str1,  
   PCXSTR psz2  
);  
friend CStringT operator+(  
   PCXSTR psz1  
   const CStringT& str2,  
);  
friend CStringT operator+(  
   char ch1  
   const CStringT& str2,  
);  
friend CStringT operator+(  
   const CStringT& str1,  
   char ch2  
);  
friend CStringT operator+(  
   const CStringT& str1,  
   wchar_t ch2  
);  
friend CStringT operator+(  
   wchar_t ch1  
   const CStringT& str2,  
);  
```  
  
#### Parameters  
 `ch1`  
 An ANSI or Unicode character to concatenate with a string.  
  
 `ch2`  
 An ANSI or Unicode character to concatenate with a string.  
  
 `str1`  
 A `CStringT` to concatenate with a string or character.  
  
 `str2`  
 A `CStringT` to concatenate with a string or character.  
  
 `psz1`  
 A pointer to a null-terminated string to concatenate with a string or character.  
  
 `psz2`  
 A pointer to a string to concatenate with a string or character.  
  
## Remarks  
 There are seven overload forms of the `CStringT::operator+` function. The first version concatenates two existing `CStringT` objects. The next two concatenate a `CStringT` object and a null-terminated string. The next two concatenate a `CStringT` object and an ANSI character. The last two concatenate a `CStringT` object and a Unicode character.  
  
> [!NOTE]
>  Although it is possible to create `CStringT` instances that contain embedded null characters, we recommend against it. Calling methods and operators on `CStringT` objects that contain embedded null characters can produce unintended results.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#140](../vs140/codesnippet/CPP/cstringt--operator--_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)