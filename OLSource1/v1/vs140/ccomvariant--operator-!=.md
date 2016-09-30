---
title: "CComVariant::operator !="
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
  - "CComVariant.operator!="
  - "ATL::CComVariant::operator!="
  - "ATL.CComVariant.operator!="
  - "CComVariant::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator!=, variant"
  - "operator !=, variant"
ms.assetid: e690f3de-ce2c-45d2-a46d-a488478364be
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::operator !=
Indicates whether the `CComVariant` object does not equal the specified **VARIANT**.  
  
## Syntax  
  
```  
  
      bool operator !=(  
   const VARIANT& varSrc   
) const throw();  
```  
  
## Remarks  
 Returns **true** if either the value or type of *varSrc* is not equal to the value or type, respectively, of the `CComVariant` object. Otherwise, **false**. The operator uses the user's default locale to perform the comparison.  
  
 The operator compares only the value of the variant types. It compares strings, integers, and floating points, but not arrays or records.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)   
 [CComVariant::operator ==](../vs140/ccomvariant--operator-==.md)   
 [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118)