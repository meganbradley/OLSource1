---
title: "CComCurrency::operator -=2"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: CComCurrency::operator /=
f1_keywords: 
  - CComCurrency.operator/=
  - operator/=
  - ATL.CComCurrency.operator/=
  - CComCurrency::operator/=
  - ATL::CComCurrency::operator/=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator/=
  - operator /=
  - /= operator
ms.assetid: 41ad5f89-b795-40f0-94c9-6792d3487712
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComCurrency::operator -=2
This operator is used to perform division on a `CComCurrency` object and assign it the result.  
  
## Syntax  
  
```  
  
      const CComCurrency & operator /=(  
   long nOperand   
);  
```  
  
#### Parameters  
 `nOperand`  
 The divisor.  
  
## Return Value  
 Returns the updated `CComCurrency` object. If the divisor is 0, an assert failure will occur.  
  
## Example  
 [!code[NVC_ATL_Utilities#60](../vs140/codesnippet/CPP/ccomcurrency--operator--=2_1.cpp)]
  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::operator /](../vs140/ccomcurrency--operator--1.md)   
 [CComCurrency::operator +](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator -](../vs140/ccomcurrency--operator--2.md)   
 [CComCurrency::operator *](../vs140/ccomcurrency--operator--.md)