---
title: "CComCurrency::operator *="
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
  - "CComCurrency.operator*="
  - "ATL.CComCurrency.operator*="
  - "ATL::CComCurrency::operator*="
  - "CComCurrency::operator*="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator *="
  - "*= operator"
  - "operator*="
ms.assetid: 2912c7c4-9abe-48a8-9f1e-2cecd11f592f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::operator *=
This operator is used to perform multiplication on a `CComCurrency` object and assign it the result.  
  
## Syntax  
  
```  
  
      const CComCurrency & operator *=(  
   long nOperand   
);  
const CComCurrency & operator *=(  
   const CComCurrency & cur   
);  
```  
  
#### Parameters  
 `nOperand`  
 The multiplier.  
  
 `cur`  
 The `CComCurrency` object used as the multiplier.  
  
## Return Value  
 Returns the updated `CComCurrency` object. In the event of an error, such as an overflow, this operator calls `AtlThrow` with an HRESULT describing the error.  
  
## Example  
 [!code[NVC_ATL_Utilities#58](../vs140/codesnippet/CPP/ccomcurrency--operator--=_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::operator *](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator +](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator -](../vs140/ccomcurrency--operator--2.md)   
 [CComCurrency::operator /](../vs140/ccomcurrency--operator--1.md)