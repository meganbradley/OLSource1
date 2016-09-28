---
title: "CStringT::ReverseFind"
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
  - "ReverseFind"
  - "CStringT::ReverseFind"
  - "ATL::CStringT::ReverseFind"
  - "ATL.CStringT.ReverseFind"
  - "CStringT.ReverseFind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReverseFind method"
ms.assetid: fa953807-03ce-4169-9683-7d922511ae9b
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::ReverseFind
Searches this `CStringT` object for the last match of a character.  
  
## Syntax  
  
```  
int ReverseFind(  
   XCHAR ch  
) const throw();  
```  
  
#### Parameters  
 `ch`  
 The character to search for.  
  
## Return Value  
 The zero-based index of the last character in this `CStringT` object that matches the requested character, or –1 if the character is not found.  
  
## Remarks  
 The function is similar to the run-time function `strrchr`.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#130](../vs140/codesnippet/CPP/cstringt--reversefind_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)