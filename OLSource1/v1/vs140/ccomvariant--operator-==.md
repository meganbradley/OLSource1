---
title: "CComVariant::operator =="
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
  - "CComVariant.operator=="
  - "ATL.CComVariant.operator=="
  - "ATL::CComVariant::operator=="
  - "CComVariant::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, variant"
  - "operator==, variant"
  - "== operator"
ms.assetid: 6e2bad80-fe08-4458-b2ef-1a7a5c6c3a93
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::operator ==
Indicates whether the `CComVariant` object equals the specified **VARIANT**.  
  
## Syntax  
  
```  
  
      bool operator ==(  
   const VARIANT& varSrc   
) const throw();  
```  
  
## Remarks  
 Returns **true** if the value and type of *varSrc* are equal to the value and type, respectively, of the `CComVariant` object. Otherwise, **false**. The operator uses the user's default locale to perform the comparison.  
  
 The operator compares only the value of the variant types. It compares strings, integers, and floating points, but not arrays or records.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)   
 [CComVariant::operator !=](../vs140/ccomvariant--operator-!=.md)