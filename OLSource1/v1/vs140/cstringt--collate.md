---
title: "CStringT::Collate"
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
  - "CStringT::Collate"
  - "ATL::CStringT::Collate"
  - "CStringT.Collate"
  - "ATL.CStringT.Collate"
  - "Collate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Collate constructor"
ms.assetid: 6ad2c609-422a-4f18-8859-b54f67d75535
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Collate
Compares two strings using the generic-text function `_tcscoll`.  
  
## Syntax  
  
```  
int Collate(  
   PCXSTR psz  
) const throw();  
```  
  
#### Parameters  
 `psz`  
 The other string used for comparison.  
  
## Return Value  
 Zero if the strings are identical, < 0 if this `CStringT` object is less than `psz`, or > 0 if this `CStringT` object is greater than `psz`.  
  
## Remarks  
 The generic-text function `_tcscoll`, which is defined in TCHAR.H, maps to either `strcoll`, `wcscoll`, or `_mbscoll`, depending on the character set that is defined at compile time. Each function performs a case-sensitive comparison of the strings according to the code page currently in use. For more information, see [strcoll, wcscoll, _mbscoll, _strcoll_l, _wcscoll_l, _mbscoll_l](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md).  
  
## Requirements  
 `Header:` cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)