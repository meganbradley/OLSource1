---
title: "CStringT::CompareNoCase"
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
  - "CompareNoCase"
  - "ATL::CStringT::CompareNoCase"
  - "CStringT.CompareNoCase"
  - "ATL.CStringT.CompareNoCase"
  - "CStringT::CompareNoCase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompareNoCase method"
ms.assetid: 06476696-a2d4-4192-9935-44721f1dcedc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::CompareNoCase
Compares two strings (case insensitive).  
  
## Syntax  
  
```  
int CompareNoCase(  
   PCXSTR psz  
) const throw();  
```  
  
#### Parameters  
 `psz`  
 The other string used for comparison.  
  
## Return Value  
 Zero if the strings are identical (ignoring case), <0 if this `CStringT` object is less than `psz` (ignoring case), or >0 if this `CStringT` object is greater than `psz` (ignoring case).  
  
## Remarks  
 The generic-text function `_tcsicmp`, which is defined in TCHAR.H, maps to either `_stricmp`, `_wcsicmp` or `_mbsicmp`, depending on the character set that is defined at compile time. Each function performs a case-insensitive comparison of the strings. The comparison depends on the `LC_CTYPE` aspect of the locale but not `LC_COLLATE`. For more information, see [_stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l](../vs140/_stricmp--_wcsicmp--_mbsicmp--_stricmp_l--_wcsicmp_l--_mbsicmp_l.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#111](../vs140/codesnippet/CPP/cstringt--comparenocase_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)