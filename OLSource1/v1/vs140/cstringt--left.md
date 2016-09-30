---
title: "CStringT::Left"
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
  - "CStringT::Left"
  - "ATL::CStringT::Left"
  - "CStringT.Left"
  - "Left"
  - "ATL.CStringT.Left"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Left method"
ms.assetid: 28f33569-d50d-4787-83b4-8ffb3f05604d
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Left
Extracts the leftmost `nCount` characters from this `CStringT` object and returns a copy of the extracted substring.  
  
## Syntax  
  
```  
CStringT Left(  
   int nCount  
) const;  
```  
  
#### Parameters  
 `nCount`  
 The number of characters to extract from this `CStringT` object.  
  
## Return Value  
 A `CStringT` object that contains a copy of the specified range of characters. The returned `CStringT` object may be empty.  
  
## Remarks  
 If `nCount` exceeds the string length, then the entire string is extracted. `Left` is similar to the Basic `Left` function.  
  
 For multi-byte character sets (MBCS), `nCount` treats each 8-bit sequence as a character, so that `nCount` returns the number of multi-byte characters multiplied by two.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#123](../vs140/codesnippet/CPP/cstringt--left_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)