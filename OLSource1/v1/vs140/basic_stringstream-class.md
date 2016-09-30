---
title: "basic_stringstream Class"
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
  - "std.basic_stringstream"
  - "basic_stringstream"
  - "std::basic_stringstream"
  - "sstream/std::basic_stringstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_stringstream class"
ms.assetid: 49629814-ca37-45c5-931b-4ff894e6ebd2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringstream Class
Describes an object that controls insertion and extraction of elements and encoded objects using a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The allocator class.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type of the basic element of the string.  
  
 *Tr*  
 The character traits specialized on the basic element of the string.  
  
## Remarks  
 The template class describes an object that controls insertion and extraction of elements and encoded objects using a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The object stores an object of class basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>>.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_stringstream](#basic_stringstream__basic_stringstream)|Constructs an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#basic_stringstream__allocator_type)|The type is a synonym for the template parameter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[rdbuf](#basic_stringstream__rdbuf)|Returns the address of the stored stream buffer of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to [basic_stringbuf](../vs140/basic_stringbuf-class.md)< <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>>.|  
|[str](#basic_stringstream__str)|Sets or gets the text in a string buffer without changing the write position.|  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
##  \<a name="basic_stringstream__allocator_type">\</a>  basic_stringstream::allocator_type  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="basic_stringstream__basic_stringstream">\</a>  basic_stringstream::basic_stringstream  
 Constructs an object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first constructor initializes the base class by calling [basic_iostream](../vs140/basic_iostream-class.md)( **sb**), where **sb** is the stored object of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>>. It also initializes **sb** by calling basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>>( <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>).  
  
 The second constructor initializes the base class by calling basic_iostream( **sb**). It also initializes **sb** by calling basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>>(_                        *Str*, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>).  
  
##  \<a name="basic_stringstream__rdbuf">\</a>  basic_stringstream::rdbuf  
 Returns the address of the stored stream buffer of type **pointer** to [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The address of the stored stream buffer of type **pointer** to basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>>.  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example that uses <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_stringstream__str">\</a>  basic_stringstream::str  
 Sets or gets the text in a string buffer without changing the write position.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The new string.  
  
### Return Value  
 Returns an object of class [basic_string](../vs140/basic_string-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>>, whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
### Remarks  
 The first member function returns [rdbuf](#basic_stringstream__rdbuf) -> [str](../vs140/basic_stringbuf-class.md#basic_stringbuf__str). The second member function calls <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> -> **str**( <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>).  
  
### Example  
  See [basic_stringbuf::str](../vs140/basic_stringbuf-class.md#basic_stringbuf__str) for an example that uses **str**.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)