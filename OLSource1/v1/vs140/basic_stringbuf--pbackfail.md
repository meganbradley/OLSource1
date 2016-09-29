---
title: "basic_stringbuf::pbackfail"
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
  - "pbackfail"
  - "basic_stringbuf.pbackfail"
  - "sstream/std::basic_stringbuf::pbackfail"
  - "std.basic_stringbuf.pbackfail"
  - "std::basic_stringbuf::pbackfail"
  - "basic_stringbuf::pbackfail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pbackfail method"
ms.assetid: bd344d1c-018a-4df6-b391-45421b7e1346
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringbuf::pbackfail
The protected virtual member function tries to put back an element into the input buffer, and then make it the current element (pointed to by the next pointer).  
  
## Syntax  
  
```  
  
      virtual int  
      _  
      type pbackfail(  
   int_type _Meta = traits_type::eof( )  
);  
```  
  
#### Parameters  
 `_Meta`  
 The character to insert into the buffer, or **traits_type::eof**.  
  
## Return Value  
 If the function cannot succeed, it returns **traits_type::eof**. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits--not_eof.md)(_*Meta*).  
  
## Remarks  
 If `_Meta` compares equal to **traits_type::**[eof](../vs140/char_traits--eof.md), the element to push back is effectively the one already in the stream before the current element. Otherwise, that element is replaced by **byte** = **traits_type::**[to_char_type](../vs140/char_traits--to_char_type.md)(_*Meta*). The function can put back an element in various ways:  
  
-   If a putback position is available, and the element stored there compares equal to byte, it can decrement the next pointer for the input buffer.  
  
-   If a putback position is available, and if the stringbuf mode permits the sequence to be altered (**mode & ios_base::out** is nonzero), it can store byte into the putback position and decrement the next pointer for the input buffer.  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringbuf Class](../vs140/basic_stringbuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)