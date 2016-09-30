---
title: "basic_streambuf::underflow"
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
  - "underflow"
  - "std.basic_streambuf.underflow"
  - "basic_streambuf.underflow"
  - "basic_streambuf::underflow"
  - "std::basic_streambuf::underflow"
  - "streambuf/std::basic_streambuf::underflow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "underflow method"
ms.assetid: a6e98c9b-687c-4546-856b-d9835ff94bdf
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::underflow
Protected, virtual function to extract the current element from the input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The current element.  
  
## Remarks  
 The protected virtual member function endeavors to extract the current element **ch** from the input stream, without advancing the current stream position, and return it as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>[to_int_type](../vs140/char_traits--to_int_type.md)(**ch**). It can do so in various ways:  
  
-   If a read position is available, **ch** is the element stored in the read position. For more information on this, see the Remarks section of the [basic_streambuf Class](../vs140/basic_streambuf-class.md).  
  
-   It can make a read position available by allocating new or additional storage for the input buffer, then reading in, from some external source, one or more elements. For more information on this, see the Remarks section of the [basic_streambuf Class](../vs140/basic_streambuf-class.md).  
  
 If the function cannot succeed, it returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[eof](../vs140/char_traits--eof.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or throws an exception. Otherwise, it returns the current element in the input stream, converted as previously described. The default behavior is to return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The virtual <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function, with the [sync](../vs140/basic_streambuf--sync.md) and [overflow](../vs140/basic_streambuf--overflow.md) functions, defines the characteristics of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived class. Each derived class might implement <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> differently, but the interface with the calling stream class is the same.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function is most frequently called by public <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> functions like [sgetc](../vs140/basic_streambuf--sgetc.md) and [sgetn](../vs140/basic_streambuf--sgetn.md) when the get area is empty, but other classes, including the stream classes, can call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> anytime.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function supplies the get area with characters from the input source. If the get area contains characters, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns the first character. If the get area is empty, it fills the get area and returns the next character (which it leaves in the get area). If there are no more characters available, then <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and leaves the get area empty.  
  
 In the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> adjusts the [egptr](../vs140/basic_streambuf--egptr.md) pointer to access storage that was dynamically allocated by a call to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)