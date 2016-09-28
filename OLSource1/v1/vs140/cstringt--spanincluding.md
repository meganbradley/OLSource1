---
title: "CStringT::SpanIncluding"
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
  - "SpanIncluding"
  - "CStringT::SpanIncluding"
  - "CStringT.SpanIncluding"
  - "ATL::CStringT::SpanIncluding"
  - "ATL.CStringT.SpanIncluding"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SpanIncluding method"
ms.assetid: a73660c8-1ec0-4b6d-8571-a032de370cc7
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::SpanIncluding
Extracts characters from the string, starting with the first character, that are in the set of characters identified by `pszCharSet`.  
  
## Syntax  
  
```  
CStringT SpanIncluding(  
   PCXSTR pszCharSet  
) const;  
```  
  
#### Parameters  
 `pszCharSet`  
 A string interpreted as a set of characters.  
  
## Return Value  
 A substring that contains characters in the string that are in `pszCharSet`, beginning with the first character in the string and ending when a character is found in the string that is not in `pszCharSet.``SpanIncluding` returns an empty substring if the first character in the string is not in the specified set.  
  
## Remarks  
 If the first character of the string is not in the character set, then `SpanIncluding` returns an empty string. Otherwise, it returns a sequence of consecutive characters that are in the set.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#134](../vs140/codesnippet/CPP/cstringt--spanincluding_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)