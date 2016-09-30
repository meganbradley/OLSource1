---
title: "CComCurrency::operator =="
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
  - "ATL::CComCurrency::operator=="
  - "ATL.CComCurrency.operator=="
  - "CComCurrency.operator=="
  - "CComCurrency::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, currency"
  - "== operator"
  - "operator==, currency"
ms.assetid: 2ad9bb56-5e9d-4696-aa66-1f4a767c4b51
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::operator ==
This operator compares two <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects for equality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to compare.  
  
## Return Value  
 Returns **true** if the objects are equal (that is, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data members, both integer and fractional, in both objects have the same value), **false** otherwise.  
  
## Example  
 [!code[NVC_ATL_Utilities#67](../vs140/codesnippet/CPP/ccomcurrency--operator-==_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::operator !=](../vs140/ccomcurrency--operator-!=.md)