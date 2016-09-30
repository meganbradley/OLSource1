---
title: "CComCurrency::operator -1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "CComCurrency::operator /"
f1_keywords: 
  - "CComCurrency.operator/"
  - "ATL.CComCurrency.operator/"
  - "CComCurrency::operator/"
  - "operator/"
  - "ATL::CComCurrency::operator/"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/ operator, currency objects"
ms.assetid: 59fe428d-f3a7-4caf-a420-c606409607b7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::operator -1
This operator is used to perform division on a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The divisor.  
  
## Return Value  
 Returns a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object representing the result of the division. If the divisor is 0, an assert failure will occur.  
  
## Example  
 [!code[NVC_ATL_Utilities#59](../vs140/codesnippet/CPP/ccomcurrency--operator--1_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::operator /=](../vs140/ccomcurrency--operator--=2.md)   
 [CComCurrency::operator +](../vs140/ccomcurrency--operator--.md)   
 [CComCurrency::operator -](../vs140/ccomcurrency--operator--2.md)   
 [CComCurrency::operator *](../vs140/ccomcurrency--operator--.md)