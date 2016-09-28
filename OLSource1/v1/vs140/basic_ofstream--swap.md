---
title: "basic_ofstream::swap"
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
  - "fstream/std::basic_ofstream::swap"
  - "basic_ofstream.swap"
  - "basic_ofstream::swap"
  - "std.basic_ofstream.swap"
  - "swap"
  - "std::basic_ofstream::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: e0c90696-4d58-4c4a-b7df-34e2ab97b921
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ofstream::swap
Exchanges the contents of two `basic_ofstream` objects.  
  
## Syntax  
  
```  
void swap(  
    basic_ofstream& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 An `lvalue` reference to another `basic_ofstream` object.  
  
## Remarks  
 The member function exchanges the contents of this object for the contents of `_Right`.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ofstream Class](../vs140/basic_ofstream-class.md)   
 [basic_ostream Class](../vs140/basic_ostream-class.md)   
 [<fstream\>](../vs140/-fstream-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)