---
title: "CComBSTR::operator BSTR"
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
  - "ATL::CComBSTR::operatorBSTR"
  - "operatorBSTR"
  - "CComBSTR.operatorBSTR"
  - "ATL.CComBSTR.operatorBSTR"
  - "CComBSTR::operatorBSTR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator BSTR"
ms.assetid: 111cf620-cae9-47e5-9610-e00125db7a83
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::operator BSTR
Casts a `CComBSTR` object to a `BSTR`.  
  
## Syntax  
  
```  
  
operator BSTR( ) const throw( );  
  
```  
  
## Remarks  
 Allows you to pass `CComBSTR` objects to functions that have **[in] BSTR** parameters.  
  
## Example  
 See the example for [CComBSTR::m_str](../vs140/ccombstr--m_str.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)