---
title: "basic_streambuf::pbackfail"
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
  - "std.basic_streambuf.pbackfail"
  - "pbackfail"
  - "basic_streambuf.pbackfail"
  - "basic_streambuf::pbackfail"
  - "std::basic_streambuf::pbackfail"
  - "streambuf/std::basic_streambuf::pbackfail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pbackfail method"
ms.assetid: 2426bda4-619c-4136-a482-b5b313fb742f
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::pbackfail
A protected virtual member function that tries to put back an element into the input stream, then make it the current element (pointed to by the next pointer).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or **traits_type::**[eof](../vs140/char_traits--eof.md).  
  
## Return Value  
 If the function cannot succeed, it returns **traits_type::eof** or throws an exception. Otherwise, it returns some other value. The default behavior is to return **traits_type::eof**.  
  
## Remarks  
 If _*Meta* compares equal to **traits_type::eof**, the element to push back is effectively the one already in the stream before the current element. Otherwise, that element is replaced by **traits_type::**[to_char_type](../vs140/char_traits--to_char_type.md)(\_*Meta*). The function can put back an element in various ways:  
  
-   If a putback position is available, it can store the element into the putback position and decrement the next pointer for the input buffer.  
  
-   It can make a putback position available by allocating new or additional storage for the input buffer.  
  
-   For a stream buffer with common input and output streams, it can make a putback position available by writing out, to some external destination, some or all of the elements between the beginning and next pointers for the output buffer.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)