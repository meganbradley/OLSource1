---
title: "CComCurrency::GetInteger"
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
  - "GetInteger"
  - "ATL::CComCurrency::GetInteger"
  - "ATL.CComCurrency.GetInteger"
  - "CComCurrency::GetInteger"
  - "CComCurrency.GetInteger"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInteger method"
ms.assetid: e3aa4c45-d25a-4b3c-a6f0-1a952d83a69f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::GetInteger
Call this method to get the integer component of a `CComCurrency` object.  
  
## Syntax  
  
```  
  
LONGLONG GetInteger( ) const;  
  
```  
  
## Return Value  
 Returns the integer component of the `m_currency` data member.  
  
## Example  
 [!code[NVC_ATL_Utilities#51](../vs140/codesnippet/CPP/ccomcurrency--getinteger_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::SetInteger](../vs140/ccomcurrency--setinteger.md)   
 [CComCurrency::GetFraction](../vs140/ccomcurrency--getfraction.md)   
 [CComCurrency::SetFraction](../vs140/ccomcurrency--setfraction.md)