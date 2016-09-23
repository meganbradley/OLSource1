---
title: "CStringT::Mid"
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
  - ATL.CStringT.Mid
  - CStringT::Mid
  - Mid
  - ATL::CStringT::Mid
  - CStringT.Mid
dev_langs: 
  - C++
helpviewer_keywords: 
  - Mid method
ms.assetid: dc14a0c3-b454-47d7-856e-6908cdc8d1c7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStringT::Mid
Extracts a substring of length `nCount` characters from this `CStringT` object, starting at position `iFirst` (zero-based).  
  
## Syntax  
  
```  
CStringT Mid(  
   int iFirst,  
   int nCount  
) const;  
CStringT Mid(  
   int iFirst  
) const;  
```  
  
#### Parameters  
 `iFirst`  
 The zero-based index of the first character in this `CStringT` object that is to be included in the extracted substring.  
  
 `nCount`  
 The number of characters to extract from this `CStringT` object. If this parameter is not supplied, then the remainder of the string is extracted.  
  
## Return Value  
 A `CStringT` object that contains a copy of the specified range of characters. Note that the returned `CStringT` object may be empty.  
  
## Remarks  
 The function returns a copy of the extracted substring. `Mid` is similar to the Basic Mid function (except that indexes in Basic are one-based).  
  
 For multibyte character sets (MBCS), `nCount` refers to each 8-bit character; that is, a lead and trail byte in one multibyte character are counted as two characters.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#128](../vs140/codesnippet/CPP/cstringt--mid_1.cpp)]
  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)