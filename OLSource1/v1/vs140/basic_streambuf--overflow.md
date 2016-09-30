---
title: "basic_streambuf::overflow"
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
  - "std.basic_streambuf.overflow"
  - "std::basic_streambuf::overflow"
  - "basic_streambuf::overflow"
  - "overflow"
  - "basic_streambuf.overflow"
  - "streambuf/std::basic_streambuf::overflow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overflow method"
ms.assetid: 91c4f0ca-df11-4dec-b21a-ff705e703b98
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::overflow
A protected virtual function that can be called when a new character is inserted into a full buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The character to insert into the buffer, or **traits_type::**[eof](../vs140/char_traits--eof.md).  
  
## Return Value  
 If the function cannot succeed, it returns **traits_type::eof** or throws an exception. Otherwise, it returns **traits_type::**[not_eof](../vs140/char_traits--not_eof.md)(_*Meta*). The default behavior is to return **traits_type::eof**.  
  
## Remarks  
 If _*Meta* does not compare equal to **traits_type::eof**, the protected virtual member function endeavors to insert the element **traits_type::**[to_char_type](../vs140/char_traits--to_char_type.md)(\_*Meta*) into the output stream. It can do so in various ways:  
  
-   If a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is available, it can store the element into the write position and increment the next pointer for the output buffer.  
  
-   It can make a write position available by allocating new or additional storage for the output buffer.  
  
-   It can make a write position available by writing out, to some external destination, some or all of the elements between the beginning and next pointers for the output buffer.  
  
 The virtual overflow function, together with the [sync](../vs140/basic_streambuf--sync.md) and [underflow](../vs140/basic_streambuf--underflow.md) functions, defines the characteristics of the streambuf-derived class. Each derived class might implement overflow differently, but the interface with the calling stream class is the same.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function is most frequently called by public <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions like <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when the put area is full, but other classes, including the stream classes, can call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> anytime.  
  
 The function consumes the characters in the put area between the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointers and then reinitializes the put area. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function must also consume <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>), or it might choose to put that character in the new put area so that it will be consumed on the next call.  
  
 The definition of consume varies among derived classes. For example, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class writes its characters to a file, while the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class keeps them in its buffer and (if the buffer is designated as dynamic) expands the buffer in response to a call to overflow. This expansion is achieved by freeing the old buffer and replacing it with a new, larger one. The pointers are adjusted as necessary.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)