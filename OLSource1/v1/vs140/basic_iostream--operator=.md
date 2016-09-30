---
title: "basic_iostream::operator="
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
  - "basic_iostream.operator="
  - "operator="
  - "std::basic_iostream::operator="
  - "std.basic_iostream.operator="
  - "istream/std::basic_iostream::operator="
  - "basic_iostream::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
  - "operator= operator"
ms.assetid: 99402aa7-7606-4580-9740-3c66cd92f615
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_iostream::operator=
Assign the value of a specified `basic_iostream` object to this object. This is a move assignment involving an `rvalue` that does not leave a copy behind.  
  
## Syntax  
  
```  
basic_iostream& operator=(basic_iostream&& _Right);  
```  
  
#### Parameters  
 `_Right`  
 An `rvalue` reference to a `basic_iostream` object to assign from.  
  
## Property Value/Return Value  
  
## Exceptions  
  
## Remarks  
 The member operator calls `(``_Right``)`.  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_iostream Class](../vs140/basic_iostream-class.md)   
 [\<istream>](../vs140/-istream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)