---
title: "basic_ostringstream::rdbuf"
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
  - "basic_ostringstream::rdbuf"
  - "std::basic_ostringstream::rdbuf"
  - "basic_ostringstream.rdbuf"
  - "std.basic_ostringstream.rdbuf"
  - "rdbuf"
  - "sstream/std::basic_ostringstream::rdbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rdbuf method"
ms.assetid: e55c6eb7-b717-4679-b348-c005b6c8f55d
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostringstream::rdbuf
Returns the address of the stored stream buffer of type **pointer** to [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, `Alloc`>.  
  
## Syntax  
  
```  
basic_stringbuf<Elem, Tr, Alloc> *rdbuf( ) const;  
```  
  
## Return Value  
 The address of the stored stream buffer, of type **pointer** to basic_stringbuf<**Elem**, **Tr**, `Alloc`>.  
  
## Remarks  
 The member function returns the address of the stored stream buffer of type **pointer** to basic_stringbuf<**Elem**, **Tr**, `Alloc`>.  
  
## Example  
 See [basic_filebuf::close](../vs140/basic_filebuf--close.md) for an example that uses `rdbuf`.  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostringstream Class](../vs140/basic_ostringstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)