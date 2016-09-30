---
title: "basic_fstream::operator="
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
  - "basic_fstream.operator="
  - "operator="
  - "basic_fstream::operator="
  - "std.basic_fstream.operator="
  - "std::basic_fstream::operator="
  - "fstream/std::basic_fstream::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
  - "operator= operator"
ms.assetid: f330843e-cdac-4043-a1de-bb8bb5c358b6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_fstream::operator=
Assigns to this object the content from a specified stream object. This is a move assignment that involves an rvalue that does not leave a copy behind.  
  
## Syntax  
  
```  
basic_fstream& operator=(basic_fstream&& _Right);  
```  
  
#### Parameters  
 `_Right`  
 An lvalue reference to a `basic_fstream` object.  
  
## Return Value  
 Returns `*this`.  
  
## Remarks  
 The member operator replaces the contents of the object by using the contents of `_Right`, treated as an rvalue reference.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_fstream Class](../vs140/basic_fstream-class.md)   
 [\<fstream>](../vs140/-fstream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)