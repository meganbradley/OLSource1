---
title: "CComBSTR::Length"
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
  - "ATL.CComBSTR.Length"
  - "CComBSTR.Length"
  - "CComBSTR::Length"
  - "ATL::CComBSTR::Length"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Length method"
ms.assetid: a2701c46-f3b2-497b-a68c-ecbacc1715ff
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::Length
Returns the number of characters in `m_str`, excluding the terminating null character.  
  
## Syntax  
  
```  
  
unsigned int Length( ) const throw( );  
  
```  
  
## Return Value  
 The length of the [m_str](../vs140/ccombstr--m_str.md) member.  
  
## Example  
 [!code[NVC_ATL_Utilities#42](../vs140/codesnippet/CPP/ccombstr--length_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)