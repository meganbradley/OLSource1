---
title: "basic_ifstream::rdbuf"
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
  - basic_ifstream.rdbuf
  - std.basic_ifstream.rdbuf
  - fstream/std::basic_ifstream::rdbuf
  - std::basic_ifstream::rdbuf
  - basic_ifstream::rdbuf
  - rdbuf
dev_langs: 
  - C++
helpviewer_keywords: 
  - rdbuf method
ms.assetid: 256ca6a4-5997-439b-8b6d-32db41f3b318
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_ifstream::rdbuf
Returns the address of the stored stream buffer.  
  
## Syntax  
  
```  
basic_filebuf<Elem, Tr> *rdbuf( ) const  
```  
  
## Return Value  
 A pointer to a [basic_filebuf](../vs140/basic_filebuf-class.md) object representing the stored stream buffer.  
  
## Example  
 See [basic_filebuf::close](../vs140/basic_filebuf--close.md) for an example that uses `rdbuf`.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ifstream Class](../vs140/basic_ifstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)