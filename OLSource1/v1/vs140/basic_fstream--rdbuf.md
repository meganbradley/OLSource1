---
title: "basic_fstream::rdbuf"
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
  - "std.basic_fstream.rdbuf"
  - "basic_fstream::rdbuf"
  - "std::basic_fstream::rdbuf"
  - "rdbuf"
  - "fstream/std::basic_fstream::rdbuf"
  - "basic_fstream.rdbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rdbuf method"
ms.assetid: 6ca9bf21-1ab9-459a-8f9d-5212909c241a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_fstream::rdbuf
Returns the address of the stored stream buffer, of type pointer to [basic_filebuf](../vs140/basic_filebuf-class.md)<**Elem**, **Tr**>.  
  
## Syntax  
  
```  
  
basic  
_  
filebuf<Elem, Tr> *rdbuf( ) const  
```  
  
## Return Value  
 The address of the stored stream buffer.  
  
## Example  
 See [basic_filebuf::close](../vs140/basic_filebuf--close.md) for an example of how to use `rdbuf`.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_fstream Class](../vs140/basic_fstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)