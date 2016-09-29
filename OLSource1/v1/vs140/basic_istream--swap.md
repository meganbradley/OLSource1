---
title: "basic_istream::swap"
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
  - "std.basic_istream.swap"
  - "basic_istream.swap"
  - "basic_istream::swap"
  - "std::basic_istream::swap"
  - "swap"
  - "istream/std::basic_istream::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: b2180ec9-95b2-426e-aa5d-8c1928bd788d
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::swap
Exchanges the contents of two `basic_istream` objects.  
  
## Syntax  
  
```  
void swap(basic_istream& _Right);  
```  
  
#### Parameters  
 `_Right`  
 An lvalue reference to a `basic_istream` object.  
  
## Remarks  
 The member function calls [swap](../vs140/basic_ios--swap.md)`(``_Right``)`. It also exchanges the extraction count with the extraction count for `_Right`.  
  
## Requirements  
 **Header:** <istream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [basic_iostream Class](../vs140/basic_iostream-class.md)   
 [<istream\>](../vs140/-istream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)