---
title: "basic_ofstream::close"
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
  - basic_ofstream::close
  - Close
  - close
  - basic_ofstream.close
  - std::basic_ofstream::close
  - std.basic_ofstream.close
  - fstream/std::basic_ofstream::close
dev_langs: 
  - C++
helpviewer_keywords: 
  - close method
ms.assetid: 08e236c2-49cc-4f80-9d45-489e54b91100
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_ofstream::close
Closes a file.  
  
## Syntax  
  
```  
  
void close( );  
  
```  
  
## Remarks  
 The member function calls [rdbuf](../vs140/basic_ifstream--rdbuf.md) **->** [close](../vs140/basic_filebuf--close.md).  
  
## Example  
 See [basic_filebuf::close](../vs140/basic_filebuf--close.md) for an example that uses **close**.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ofstream Class](../vs140/basic_ofstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)