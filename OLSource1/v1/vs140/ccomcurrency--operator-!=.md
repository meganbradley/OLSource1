---
title: "CComCurrency::operator !="
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
  - "CComCurrency::operator!="
  - "ATL.CComCurrency.operator!="
  - "ATL::CComCurrency::operator!="
  - "CComCurrency.operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator!=, currency"
  - "operator !=, currency"
ms.assetid: d1776841-b1c9-4fcc-bbc5-5e7df27d06d6
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::operator !=
This operator compares two objects for inequality.  
  
## Syntax  
  
```  
  
      bool operator !=(  
   const CComCurrency & cur   
) const;  
```  
  
#### Parameters  
 `cur`  
 The `CComCurrency` object to be compared.  
  
## Return Value  
 Returns **true** if the item being compared is not equal to the `CComCurrency` object; otherwise, **false**.  
  
## Example  
 [!code[NVC_ATL_Utilities#56](../vs140/codesnippet/CPP/ccomcurrency--operator-!=_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::operator ==](../vs140/ccomcurrency--operator-==.md)