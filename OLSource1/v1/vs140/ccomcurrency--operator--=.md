---
title: "CComCurrency::operator +="
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
  - CComCurrency.operator+=
  - CComCurrency::operator+=
  - ATL.CComCurrency.operator+=
  - ATL::CComCurrency::operator+=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator+=, currency
  - += operator, currency
  - operator +=, currency
ms.assetid: 18047ca7-1717-4cfa-b09e-6c1a5d5ed871
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComCurrency::operator +=
This operator is used to perform addition on a `CComCurrency` object and assign the result to the current object.  
  
## Syntax  
  
```  
  
      const CComCurrency & operator +=(  
   const CComCurrency & cur   
);  
```  
  
#### Parameters  
 `cur`  
 The `CComCurrency` object.  
  
## Return Value  
 Returns the updated `CComCurrency` object. In the event of an error, such as an overflow, this operator calls `AtlThrow` with an HRESULT describing the error.  
  
## Example  
 [!code[NVC_ATL_Utilities#62](../vs140/codesnippet/CPP/ccomcurrency--operator--=_1.cpp)]
  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::operator *=](../vs140/ccomcurrency--operator--=.md)   
 [CComCurrency::operator +](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator -](../vs140/ccomcurrency--operator--2.md)   
 [CComCurrency::operator /](../vs140/ccomcurrency--operator--1.md)