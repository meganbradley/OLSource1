---
title: "CComCurrency::operator CURRENCY"
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
  - "operatorCURRENCY"
  - "CComCurrency::operatorCURRENCY"
  - "CComCurrency.operatorCURRENCY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator CURRENCY"
  - "CURRENCY operator"
ms.assetid: d179aa03-eb83-4681-9f93-a8c75c0209a4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::operator CURRENCY
These operators are used to cast a `CComCurrency` object to a **CURRENCY** data type.  
  
## Syntax  
  
```  
  
      operator CURRENCY&( ) throw( );   
operator const CURRENCY&( ) const throw( );  
```  
  
## Return Value  
 Returns a reference to a **CURRENCY** object.  
  
## Example  
 [!code[NVC_ATL_Utilities#70](../vs140/codesnippet/CPP/ccomcurrency--operator-currency_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)