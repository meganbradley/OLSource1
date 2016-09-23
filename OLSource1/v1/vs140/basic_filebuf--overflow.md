---
title: "basic_filebuf::overflow"
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
  - std::basic_filebuf::overflow
  - basic_filebuf.overflow
  - overflow
  - basic_filebuf::overflow
  - fstream/std::basic_filebuf::overflow
  - std.basic_filebuf.overflow
dev_langs: 
  - C++
helpviewer_keywords: 
  - overflow method
ms.assetid: f5b3ebb2-faa7-4aa2-9bd6-b8bbe98022b9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_filebuf::overflow
Called when a new character is inserted into a full buffer.  
  
## Syntax  
  
```  
  
      virtual int  
      _  
      type overflow(  
   int_type _Meta = traits_type::eof  
);  
```  
  
#### Parameters  
 `_Meta`  
 The character to insert into the buffer or **traits_type::eof**.  
  
## Return Value  
 If the function cannot succeed, it returns **traits_type::eof**. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits--not_eof.md)(_*Meta*).  
  
## Remarks  
 If _*Meta* **!= traits_type::**[eof](../vs140/char_traits--eof.md), the protected virtual member function endeavors to insert the element **ch = traits_type::**[to_char_type](../vs140/char_traits--to_char_type.md)(\_*Meta*) into the output buffer. It can do so in various ways:  
  
-   If a write position is available, it can store the element into the write position and increment the next pointer for the output buffer.  
  
-   It can make a write position available by allocating new or additional storage for the output buffer.  
  
-   It can convert any pending output in the output buffer, followed by **ch**, by using the file conversion facet **fac** to call **fac.out** as needed. Each element `ch` of type *char* thus produced is written to the associated stream designated by the file pointer **fp** as if by successive calls of the form `fputc`(**ch**, **fp**). If any conversion or write fails, the function does not succeed.  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)