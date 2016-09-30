---
title: "moneypunct::do_decimal_point"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "do_decimal_point"
  - "std.moneypunct.do_decimal_point"
  - "locale/std::moneypunct::decimal_point"
  - "locale/std::moneypunct::do_decimal_point"
  - "std::moneypunct::do_decimal_point"
  - "moneypunct.do_decimal_point"
  - "moneypunct::do_decimal_point"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_decimal_point method"
ms.assetid: 800fe536-df63-4b1b-88b2-b96351e7f51e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::do_decimal_point
A protected virtual member function that returns a locale-specific sequence of elements to use as a decimal point symbol.  
  
## Syntax  
  
```  
virtual CharType do_decimal_point( ) const;  
```  
  
## Return Value  
 A locale-specific sequence of elements to use as a decimal point symbol.  
  
## Example  
 See the example for [decimal_point](../vs140/moneypunct--decimal_point.md), where the virtual member function is called by `decimal_point`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)