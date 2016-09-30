---
title: "basic_ostringstream Class"
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
  - "basic_ostringstream"
  - "std.basic_ostringstream"
  - "sstream/std::basic_ostringstream"
  - "std::basic_ostringstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ostringstream class"
ms.assetid: aea699f7-350f-432a-acca-adbae7b483fb
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostringstream Class
Describes an object that controls insertion of elements and encoded objects into a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>>.  
  
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
 The class describes an object that controls insertion of elements and encoded objects into a stream buffer, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The object stores an object of class basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>>.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_ostringstream](#basic_ostringstream__basic_ostringstream)|Constructs an object of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#basic_ostringstream__allocator_type)|The type is a synonym for the template parameter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[rdbuf](#basic_ostringstream__rdbuf)|Returns the address of the stored stream buffer of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to [basic_stringbuf](../vs140/basic_stringbuf-class.md)< <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>>.|  
|[str](#basic_ostringstream__str)|Sets or gets the text in a string buffer without changing the write position.|  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
##  \<a name="basic_ostringstream__allocator_type">\</a>  basic_ostringstream::allocator_type  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="basic_ostringstream__basic_ostringstream">\</a>  basic_ostringstream::basic_ostringstream  
 Constructs an object of type basic_ostringstream.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first constructor initializes the base class by calling [basic_ostream](../vs140/basic_ostream-class.md)( **sb**), where **sb** is the stored object of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>>. It also initializes **sb** by calling basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>>( <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>).  
  
 The second constructor initializes the base class by calling basic_ostream( **sb**). It also initializes **sb** by calling basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>>(_                        *Str*, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>).  
  
##  \<a name="basic_ostringstream__rdbuf">\</a>  basic_ostringstream::rdbuf  
 Returns the address of the stored stream buffer of type **pointer** to [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The address of the stored stream buffer, of type **pointer** to basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>>.  
  
### Remarks  
 The member function returns the address of the stored stream buffer of type **pointer** to basic_stringbuf< **Elem**, **Tr**, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>>.  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example that uses <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_ostringstream__str">\</a>  basic_ostringstream::str  
 Sets or gets the text in a string buffer without changing the write position.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The new string.  
  
### Return Value  
 Returns an object of class [basic_string](../vs140/basic_string-class.md)< **Elem**, **Tr**, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>>, whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
### Remarks  
 The first member function returns [rdbuf](#basic_ostringstream__rdbuf) -> [str](../vs140/basic_stringbuf-class.md#basic_stringbuf__str). The second member function calls <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> -> **str**( <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>).  
  
### Example  
  See [basic_stringbuf::str](../vs140/basic_stringbuf-class.md#basic_stringbuf__str) for an example that uses **str**.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)