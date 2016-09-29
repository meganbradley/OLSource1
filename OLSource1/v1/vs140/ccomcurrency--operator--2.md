---
title: "CComCurrency::operator -2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "CComCurrency::operator -"
f1_keywords: 
  - "ATL.CComCurrency.operator-"
  - "ATL::CComCurrency::operator-"
  - "CComCurrency.operator-"
  - "CComCurrency::operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "- operator, currency"
ms.assetid: 4051fd7c-76c9-427c-b9d6-208ce8ecb5a6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::operator -2
This operator is used to perform subtraction on a `CComCurrency` object.  
  
## Syntax  
  
```  
  
      CComCurrency operator -( ) const;   
CComCurrency operator -(  
   const CComCurrency & cur   
) const;  
```  
  
#### Parameters  
 `cur`  
 A `CComCurrency` object.  
  
## Return Value  
 Returns a `CComCurrency` object representing the result of the subtraction. In the event of an error, such as an overflow, this operator calls `AtlThrow` with an HRESULT describing the error.  
  
## Example  
 [!code[NVC_ATL_Utilities#55](../vs140/codesnippet/CPP/ccomcurrency--operator--2_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::operator -=](../vs140/ccomcurrency--operator--=1.md)   
 [CComCurrency::operator +](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator *](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator /](../vs140/ccomcurrency--operator--1.md)