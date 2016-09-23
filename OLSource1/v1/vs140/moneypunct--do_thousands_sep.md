---
title: "moneypunct::do_thousands_sep"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - moneypunct.do_thousands_sep
  - std.moneypunct.do_thousands_sep
  - moneypunct::do_thousands_sep
  - locale/std::moneypunct::do_thousands_sep
  - do_thousands_sep
  - std::moneypunct::do_thousands_sep
dev_langs: 
  - C++
helpviewer_keywords: 
  - do_thousands_sep method
ms.assetid: 3a6c422b-5142-4db6-8616-f43260845148
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# moneypunct::do_thousands_sep
A protected virtual member function that returns a locale-specific element to use as a group separator to the left of any decimal point.  
  
## Syntax  
  
```  
virtual CharType do_thousands_sep( ) const;  
```  
  
## Return Value  
 A locale-specific element to use as a group separator to the left of any decimal point.  
  
## Example  
 See the example for [thousands_sep](../vs140/moneypunct--thousands_sep.md), where the virtual member function is called by `thousands_sep`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)