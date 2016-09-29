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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostringstream Class
Describes an object that controls insertion of elements and encoded objects into a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, `Alloc`>.  
  
## Syntax  
  
```  
template <    class  Elem ,     class  Tr  = char _ traits< Elem >,     class  Alloc  = allocator< Elem >  >    class basic _ ostringstream : public basic _ ostream< Elem ,  Tr >  
  
```  
  
#### Parameters  
 `Alloc`  
 The allocator class.  
  
 `Elem`  
 The type of the basic element of the string.  
  
 *Tr*  
 The character traits specialized on the basic element of the string.  
  
## Remarks  
 The class describes an object that controls insertion of elements and encoded objects into a stream buffer, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class `Alloc`. The object stores an object of class basic_stringbuf< **Elem**, **Tr**, `Alloc`>.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_ostringstream](#basic_ostringstream__basic_ostringstream)|Constructs an object of type `basic_ostringstream`.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#basic_ostringstream__allocator_type)|The type is a synonym for the template parameter `Alloc`.|  
  
### Member Functions  
  
|||  
|-|-|  
|[rdbuf](#basic_ostringstream__rdbuf)|Returns the address of the stored stream buffer of type `pointer` to [basic_stringbuf](../vs140/basic_stringbuf-class.md)< `Elem`, `Tr`, `Alloc`>.|  
|[str](#basic_ostringstream__str)|Sets or gets the text in a string buffer without changing the write position.|  
  
## Requirements  
 **Header:** <sstream\>  
  
 **Namespace:** std  
  
##  <a name="basic_ostringstream__allocator_type"></a>  basic_ostringstream::allocator_type  
 The type is a synonym for the template parameter `Alloc`.  
  
```  
typedef  Alloc  allocator_type;  
  
```  
  
##  <a name="basic_ostringstream__basic_ostringstream"></a>  basic_ostringstream::basic_ostringstream  
 Constructs an object of type basic_ostringstream.  
  
```  
explicit basic _ ostringstream(    ios _ base::openmode  _Mode  = ios _ base::out ); explicit basic _ ostringstream(    const basic _ string<Elem, Tr, Alloc>&  _Str ,    ios _ base::openmode  _Mode  = ios _ base::out );  
  
```  
  
### Parameters  
 `_Mode`  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base-class.md#ios_base__openmode).  
  
 `_Str`  
 An object of type `basic_string`.  
  
### Remarks  
 The first constructor initializes the base class by calling [basic_ostream](../vs140/basic_ostream-class.md)( **sb**), where **sb** is the stored object of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, `Alloc`>. It also initializes **sb** by calling basic_stringbuf< **Elem**, **Tr**, `Alloc`>( `_Mode` &#124; `ios_base::out`).  
  
 The second constructor initializes the base class by calling basic_ostream( **sb**). It also initializes **sb** by calling basic_stringbuf< **Elem**, **Tr**, `Alloc`>(_                        *Str*, `_Mode` &#124; `ios_base::out`).  
  
##  <a name="basic_ostringstream__rdbuf"></a>  basic_ostringstream::rdbuf  
 Returns the address of the stored stream buffer of type **pointer** to [basic_stringbuf](../vs140/basic_stringbuf-class.md)< **Elem**, **Tr**, `Alloc`>.  
  
```  
basic_stringbuf<Elem, Tr, Alloc> *rdbuf( ) const;  
```  
  
### Return Value  
 The address of the stored stream buffer, of type **pointer** to basic_stringbuf< **Elem**, **Tr**, `Alloc`>.  
  
### Remarks  
 The member function returns the address of the stored stream buffer of type **pointer** to basic_stringbuf< **Elem**, **Tr**, `Alloc`>.  
  
### Example  
  See [basic_filebuf::close](../vs140/basic_filebuf-class.md#basic_filebuf__close) for an example that uses `rdbuf`.  
  
##  <a name="basic_ostringstream__str"></a>  basic_ostringstream::str  
 Sets or gets the text in a string buffer without changing the write position.  
  
```  
basic_string<Elem, Tr, Alloc> str( ) const;  
void str(  
    const basic_string<Elem, Tr, Alloc>& _Newstr  
);  
```  
  
### Parameters  
 `_Newstr`  
 The new string.  
  
### Return Value  
 Returns an object of class [basic_string](../vs140/basic_string-class.md)< **Elem**, **Tr**, `Alloc`>, whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
### Remarks  
 The first member function returns [rdbuf](#basic_ostringstream__rdbuf) -> [str](../vs140/basic_stringbuf-class.md#basic_stringbuf__str). The second member function calls `rdbuf` -> **str**( `_Newstr`).  
  
### Example  
  See [basic_stringbuf::str](../vs140/basic_stringbuf-class.md#basic_stringbuf__str) for an example that uses **str**.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)