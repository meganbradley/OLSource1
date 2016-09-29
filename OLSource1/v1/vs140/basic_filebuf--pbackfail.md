---
title: "basic_filebuf::pbackfail"
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
  - "basic_filebuf::pbackfail"
  - "fstream/std::basic_filebuf::pbackfail"
  - "pbackfail"
  - "std::basic_filebuf::pbackfail"
  - "basic_filebuf.pbackfail"
  - "std.basic_filebuf.pbackfail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pbackfail method"
ms.assetid: f02bd575-79d3-48eb-b0bf-0454a7b4b081
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf::pbackfail
Tries to put back an element into the input stream, then make it the current element (pointed to by the next pointer).  
  
## Syntax  
  
```  
  
      virtual int  
      _  
      type pbackfail(  
   int_type _Meta = traits_type::eof  
);  
```  
  
#### Parameters  
 `_Meta`  
 The character to insert into the buffer, or **traits_type::eof**.  
  
## Return Value  
 If the function cannot succeed, it returns **traits_type::eof**. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits--not_eof.md)(_*Meta*).  
  
## Remarks  
 The protected virtual member function puts back an element into the input buffer and then makes it the current element (pointed to by the next pointer). If _*Meta* **== traits_type::**[eof](../vs140/char_traits--eof.md), the element to push back is effectively the one already in the stream before the current element. Otherwise, that element is replaced by **ch = traits_type::**[to_char_type](../vs140/char_traits--to_char_type.md)(\_*Meta*). The function can put back an element in various ways:  
  
-   If a putback position is available, and the element stored there compares equal to **ch**, it can decrement the next pointer for the input buffer.  
  
-   If the function can make a `putback` position available, it can do so, set the next pointer to point at that position, and store **ch** in that position.  
  
-   If the function can push back an element onto the input stream, it can do so, such as by calling `ungetc` for an element of type `char`*.*  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)