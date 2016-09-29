---
title: "basic_istream::operator="
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
  - "std::basic_istream::operator="
  - "basic_istream.operator="
  - "="
  - "operator="
  - "basic_istream::operator="
  - "istream/std::basic_istream::operator="
  - "std.basic_istream.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
  - "operator= operator"
ms.assetid: e700a2cd-a058-4e87-9a8c-46ad5ca5549e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::operator=
Assigns the `basic_istream` on the right side of the operator to this object. This is a move assignment involving an `rvalue` reference that does not leave a copy behind.  
  
## Syntax  
  
```  
basic_istream& operator=(  
    basic_istream&& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 An `rvalue` reference to a `basic_ifstream` object.  
  
## Return Value  
 Returns *this.  
  
## Remarks  
 The member operator calls `(_Right)`.  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [basic_iostream Class](../vs140/basic_iostream-class.md)   
 [\<istream>](../vs140/-istream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)