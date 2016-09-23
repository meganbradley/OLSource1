---
title: "basic_ofstream::operator="
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
  - operator=
  - fstream/std::basic_ofstream::operator=
  - std::basic_ofstream::operator=
  - std.basic_ofstream.operator=
  - basic_ofstream::operator=
  - basic_ofstream.operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator=
  - operator= operator
ms.assetid: 15ce7854-f874-4246-ad9a-21f05ca9ed7a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_ofstream::operator=
Assigns the content of this stream object. This is a move assignment involving an `rvalue reference` that does not leave a copy behind.  
  
## Syntax  
  
```  
basic_ofstream& operator=(  
    basic_ofstream&& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 An rvalue reference to a `basic_ofstream` object.  
  
## Return Value  
 Returns `*this`.  
  
## Exceptions  
  
## Remarks  
 The member operator replaces the contents of the object by using the contents of `_Right`, treated as an rvalue reference.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ofstream Class](../vs140/basic_ofstream-class.md)   
 [<fstream\>](../vs140/-fstream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)