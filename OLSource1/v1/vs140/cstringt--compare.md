---
title: "CStringT::Compare"
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
  - "ATL::CStringT::Compare"
  - "CStringT.Compare"
  - "ATL.CStringT.Compare"
  - "CStringT::Compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Compare method"
ms.assetid: 108b8c35-628f-430d-96f1-d3a925e1513e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Compare
Compares two strings (case sensitive).  
  
## Syntax  
  
```  
int Compare(  
   PCXSTR psz  
) const;  
```  
  
#### Parameters  
 `psz`  
 The other string used for comparison.  
  
## Return Value  
 Zero if the strings are identical, < 0 if this `CStringT` object is less than `psz`, or > 0 if this `CStringT` object is greater than `psz`.  
  
## Remarks  
 The generic-text function `_tcscmp`, which is defined in TCHAR.H, maps to either `strcmp`, `wcscmp`, or `_mbscmp`, depending on the character set that is defined at compile time. Each function performs a case-sensitive comparison of the strings and is not affected by locale. For more information, see [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md).  
  
 If the string contains embedded nulls, for purposes of comparison the string is considered to be truncated at the first embedded null character.  
  
## Example  
 The following example demonstrates the use of `CStringT::Compare`.  
  
 [!code[NVC_ATLMFC_Utilities#110](../vs140/codesnippet/CPP/cstringt--compare_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)