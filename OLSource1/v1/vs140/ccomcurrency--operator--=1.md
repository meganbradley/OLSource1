---
title: "CComCurrency::operator -=1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "CComCurrency::operator -="
f1_keywords: 
  - "ATL::CComCurrency::operator-="
  - "CComCurrency::operator-="
  - "ATL.CComCurrency.operator-="
  - "CComCurrency.operator-="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-="
  - "-= operator"
ms.assetid: f826a7f1-d6bb-4495-a31a-513a1e2e6b3f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::operator -=1
This operator is used to perform subtraction on a `CComCurrency` object and assign it the result.  
  
## Syntax  
  
```  
  
      const CComCurrency & operator -=(  
   const CComCurrency & cur   
);  
```  
  
#### Parameters  
 `cur`  
 A `CComCurrency` object.  
  
## Return Value  
 Returns the updated `CComCurrency` object. In the event of an error, such as an overflow, this operator calls `AtlThrow` with an HRESULT describing the error.  
  
## Example  
 [!code[NVC_ATL_Utilities#66](../vs140/codesnippet/CPP/ccomcurrency--operator--=1_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::operator -](../vs140/ccomcurrency--operator--2.md)   
 [CComCurrency::operator +](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator *](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator /](../vs140/ccomcurrency--operator--1.md)