---
title: "CStringT::CollateNoCase"
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
  - "CStringT::CollateNoCase"
  - "ATL::CStringT::CollateNoCase"
  - "CollateNoCase"
  - "CStringT.CollateNoCase"
  - "ATL.CStringT.CollateNoCase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CollateNoCase method"
ms.assetid: 649daeee-9d30-428b-9bfa-91b6614694fe
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::CollateNoCase
Compares two strings using the generic-text function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The other string used for comparison.  
  
## Return Value  
 Zero if the strings are identical (ignoring case), < 0 if this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is less than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (ignoring case), or > 0 if this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is greater than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (ignoring case).  
  
## Remarks  
 The generic-text function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which is defined in TCHAR.H, maps to either <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, depending on the character set that is defined at compile time. Each function performs a case-insensitive comparison of the strings, according to the code page currently in use. For more information, see [strcoll, wcscoll, _mbscoll, _strcoll_l, _wcscoll_l, _mbscoll_l](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#109](../vs140/codesnippet/CPP/cstringt--collatenocase_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)