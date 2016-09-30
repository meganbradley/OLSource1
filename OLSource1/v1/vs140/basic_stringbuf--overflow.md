---
title: "basic_stringbuf::overflow"
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
  - "std::basic_stringbuf::overflow"
  - "std.basic_stringbuf.overflow"
  - "basic_stringbuf.overflow"
  - "overflow"
  - "sstream/std::basic_stringbuf::overflow"
  - "basic_stringbuf::overflow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overflow method"
ms.assetid: 3790fb89-e88c-4636-a6be-2f1c4908b932
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringbuf::overflow
A protected virtual function that can be called when a new character is inserted into a full buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or **traits_type::eof**.  
  
## Return Value  
 If the function cannot succeed, it returns **traits_type::eof**. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits--not_eof.md)(_*Meta*).  
  
## Remarks  
 If _*Meta* does not compare equal to **traits_type::**[eof](../vs140/char_traits--eof.md), the protected virtual member function tries to insert the element **traits_type::**[to_char_type](../vs140/char_traits--to_char_type.md)(\_*Meta*) into the output buffer. It can do so in various ways:  
  
-   If a write position is available, it can store the element into the write position and increment the next pointer for the output buffer.  
  
-   It can make a write position available by allocating new or additional storage for the output buffer. Extending the output buffer this way also extends any associated input buffer.  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringbuf Class](../vs140/basic_stringbuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)