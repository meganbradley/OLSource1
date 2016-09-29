---
title: "CStringT::Right"
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
  - "Right"
  - "ATL::CStringT::Right"
  - "ATL.CStringT.Right"
  - "CStringT.Right"
  - "CStringT::Right"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Right method"
ms.assetid: e8370eca-c6fd-4522-8683-97aebf6d2d10
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Right
Extracts the last (that is, rightmost) `nCount` characters from this `CStringT` object and returns a copy of the extracted substring.  
  
## Syntax  
  
```  
CStringT Right(  
   int nCount  
) const;  
```  
  
#### Parameters  
 `nCount`  
 The number of characters to extract from this `CStringT` object.  
  
## Return Value  
 A `CStringT` object that contains a copy of the specified range of characters. Note that the returned `CStringT` object can be empty.  
  
## Remarks  
 If `nCount` exceeds the string length, then the entire string is extracted. `Right` is similar to the Basic `Right` function (except that indexes in Basic are zero-based).  
  
 For multibyte character sets (MBCS), `nCount` refers to each 8-bit character; that is, a lead and trail byte in one multibyte character are counted as two characters.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#131](../vs140/codesnippet/CPP/cstringt--right_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)