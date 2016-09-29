---
title: "basic_stringstream::str"
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
  - "basic_stringstream.str"
  - "Str"
  - "std.basic_stringstream.str"
  - "str"
  - "std::basic_stringstream::str"
  - "sstream/std::basic_stringstream::str"
  - "basic_stringstream::str"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "str method"
ms.assetid: 1bd0e97b-0c80-4bdf-9d72-1bd75bdcf95d
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringstream::str
Sets or gets the text in a string buffer without changing the write position.  
  
## Syntax  
  
```  
basic_string<Elem, Tr, Alloc> str( ) const;  
void str(  
    const basic_string<Elem, Tr, Alloc>& _Newstr  
);  
```  
  
#### Parameters  
 `_Newstr`  
 The new string.  
  
## Return Value  
 Returns an object of class [basic_string](../vs140/basic_string-class.md)<**Elem**, **Tr**, `Alloc`>, whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
## Remarks  
 The first member function returns [rdbuf](../vs140/basic_stringstream--rdbuf.md) -> [str](../vs140/basic_stringbuf--str.md). The second member function calls `rdbuf` -> **str**(`_Newstr`).  
  
## Example  
 See [basic_stringbuf::str](../vs140/basic_stringbuf--str.md) for an example that uses **str**.  
  
## Requirements  
 **Header:** <sstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringstream Class](../vs140/basic_stringstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)