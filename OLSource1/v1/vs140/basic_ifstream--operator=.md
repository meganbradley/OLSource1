---
title: "basic_ifstream::operator="
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
  - "basic_ifstream.operator="
  - "operator="
  - "basic_ifstream::operator="
  - "std::basic_ifstream::operator="
  - "fstream/std::basic_ifstream::operator="
  - "std.basic_ifstream.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
  - "operator= operator"
ms.assetid: ed6f2fec-5a25-4b49-a938-10701ce1ff7a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ifstream::operator=
Assigns the content of this stream object. This is a move assignment involving an rvalue that does not leave a copy behind.  
  
## Syntax  
  
```  
basic_ifstream& operator=(  
    basic_ifstream&& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 An rvalue reference to a `basic_ifstream` object.  
  
## Return Value  
 Returns `*this`.  
  
## Remarks  
 The member operator replaces the contents of the object by using the contents of `_Right`, treated as an rvalue reference. For more information, see [Lvalues and Rvalues](../vs140/lvalues-and-rvalues--visual-c---.md).  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ifstream Class](../vs140/basic_ifstream-class.md)   
 [\<fstream>](../vs140/-fstream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)