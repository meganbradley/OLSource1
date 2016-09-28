---
title: "basic_ofstream::rdbuf"
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
  - "basic_ofstream::rdbuf"
  - "fstream/std::basic_ofstream::rdbuf"
  - "basic_ofstream.rdbuf"
  - "std.basic_ofstream.rdbuf"
  - "rdbuf"
  - "std::basic_ofstream::rdbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rdbuf method"
ms.assetid: cc547550-a6b1-40a7-904a-63454d41731b
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ofstream::rdbuf
Returns the address of the stored stream buffer.  
  
## Syntax  
  
```  
  
basic  
_  
filebuf<Elem, Tr> *rdbuf( ) const  
  
```  
  
## Return Value  
 Returns the address of the stored stream buffer.  
  
## Example  
 See [basic_filebuf::close](../vs140/basic_filebuf--close.md) for an example that uses `rdbuf`.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ofstream Class](../vs140/basic_ofstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)