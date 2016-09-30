---
title: "CStringT::FindOneOf"
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
  - "ATL.CStringT.FindOneOf"
  - "CStringT::FindOneOf"
  - "FindOneOf"
  - "CStringT.FindOneOf"
  - "ATL::CStringT::FindOneOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindOneOf method"
ms.assetid: 32a400a7-c740-472d-9ae7-bf8b874e77ac
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::FindOneOf
Searches this string for the first character that matches any character contained in `pszCharSet`.  
  
## Syntax  
  
```  
int FindOneOf(  
   PCXSTR pszCharSet  
) const throw( );  
```  
  
#### Parameters  
 `pszCharSet`  
 String containing characters for matching.  
  
## Return Value  
 The zero-based index of the first character in this string that is also in `pszCharSet`; –1 if there is no match.  
  
## Remarks  
 Finds the first occurrence of any of the characters in `pszCharSet`.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#115](../vs140/codesnippet/CPP/cstringt--findoneof_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)