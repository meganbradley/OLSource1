---
title: "CComCurrency::SetInteger"
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
  - ATL.CComCurrency.SetInteger
  - SetInteger
  - CComCurrency.SetInteger
  - ATL::CComCurrency::SetInteger
  - CComCurrency::SetInteger
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetInteger method
ms.assetid: b1adea0e-8f60-4e7e-bf9e-a1e67ed60645
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComCurrency::SetInteger
Call this method to set the integer component of a `CComCurrency` object.  
  
## Syntax  
  
```  
  
      HRESULT SetInteger(  
   LONGLONG nInteger   
);  
```  
  
#### Parameters  
 `nInteger`  
 The value to be assigned to the integer component of the `m_currency` data member. The sign of the integer component must match the sign of the existing fractional component.  
  
 `nInteger` must be in the range **CY_MIN_INTEGER** to **CY_MAX_INTEGER** inclusive. These values are defined in atlcur.h.  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Example  
 [!code[NVC_ATL_Utilities#54](../vs140/codesnippet/CPP/ccomcurrency--setinteger_1.cpp)]
  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::GetInteger](../vs140/ccomcurrency--getinteger.md)   
 [CComCurrency::GetFraction](../vs140/ccomcurrency--getfraction.md)   
 [CComCurrency::SetFraction](../vs140/ccomcurrency--setfraction.md)