---
title: "basic_istringstream Class"
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
  - "std::basic_istringstream"
  - "sstream/std::basic_istringstream"
  - "basic_istringstream"
  - "std.basic_istringstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_istringstream class"
ms.assetid: 1d5bb4b5-793d-4833-98e5-14676c451915
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istringstream Class
Describes an object that controls extraction of elements and encoded objects from a stream buffer of class [basic_stringbuf](../VS_csharp/basic_stringbuf-class.md)< **Elem**, **Tr**, `Alloc`>.  
  
## Syntax  
  
```  
template <    class  Elem ,     class  Tr  = char _ traits< Elem >,     class  Alloc  = allocator< Elem >  >    class basic _ istringstream : public basic _ istream< Elem ,  Tr >  
  
```  
  
#### Parameters  
 `Alloc`  
 The allocator class.  
  
 `Elem`  
 The type of the basic element of the string.  
  
 *Tr*  
 The character traits specialized on the basic element of the string.  
  
## Remarks  
 The template class describes an object that controls extraction of elements and encoded objects from a stream buffer of class [basic_stringbuf](../VS_csharp/basic_stringbuf-class.md)< **Elem**, **Tr**, `Alloc`>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class `Alloc`. The object stores an object of class basic_stringbuf< **Elem**, **Tr**, `Alloc`>.  
  
### Constructors  
  
|||  
|-|-|  
|[basic_istringstream](#basic_istringstream__basic_istringstream)|Constructs an object of type `basic_istringstream`.|  
  
### Typedefs  
  
|||  
|-|-|  
|[allocator_type](#basic_istringstream__allocator_type)|The type is a synonym for the template parameter `Alloc`.|  
  
### Member Functions  
  
|||  
|-|-|  
|[rdbuf](#basic_istringstream__rdbuf)|Returns the address of the stored stream buffer of type `pointer` to [basic_stringbuf](../VS_csharp/basic_stringbuf-class.md)< `Elem`, `Tr`, `Alloc`>.|  
|[str](#basic_istringstream__str)|Sets or gets the text in a string buffer without changing the write position.|  
|[swap](#basic_istringstream__swap)|Exchanges the values in this `basic_istringstream` object for those of the provided object.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#basic_istringstream__operator_eq)|Assigns the values to this `basic_istringstream` object from the object parameter.|  
  
## Requirements  
 **Header:** <sstream\>  
  
 **Namespace:** std  
  
##  <a name="basic_istringstream__allocator_type"></a>  basic_istringstream::allocator_type  
 The type is a synonym for the template parameter `Alloc`.  
  
```  
typedef  Alloc  allocator_type;  
  
```  
  
##  <a name="basic_istringstream__basic_istringstream"></a>  basic_istringstream::basic_istringstream  
 Constructs an object of type `basic_istringstream`.  
  
```  
explicit basic_istringstream(  
   ios_base::openmode _Mode = ios_base::in  
);  
explicit basic_istringstream(  
   const basic_string<Elem, Tr, Alloc>& _Str,  
   ios_base::openmode _Mode = ios_base::in  
);  
basic_istringstream(  
    basic_istringstream&& _Right  
);  
```  
  
### Parameters  
 `_Mode`  
 One of the enumerations in [ios_base::openmode](../VS_csharp/ios_base-class.md#ios_base__openmode).  
  
 `_Str`  
 An object of type `basic_string`.  
  
 `_Right`  
 An rvalue reference of a `basic_istringstream` object.  
  
### Remarks  
 The first constructor initializes the base class by calling [basic_istream](../VS_csharp/basic_istream-class.md)( `sb`), where `sb` is the stored object of class [basic_stringbuf](../VS_csharp/basic_stringbuf-class.md)< `Elem`, `Tr`, `Alloc`>. It also initializes `sb` by calling `basic_stringbuf`< `Elem`, `Tr`, `Alloc`>( `_Mode` &#124; `ios_base::in`).  
  
 The second constructor initializes the base class by calling `basic_istream(sb)`. It also initializes `sb` by calling `basic_stringbuf`< `Elem`, `Tr`, `Alloc`>( `_Str`, `_Mode` &#124; `ios_base::in`).  
  
 The third constructor initializes the object with the contents of `_Right`, treated as an rvalue reference.  
  
##  <a name="basic_istringstream__operator_eq"></a>  basic_istringstream::operator=  
 Assigns the values to this `basic_istringstream` object from the object parameter.  
  
```  
basic_istringstream& operator=(  
    basic_istringstream&& _Right  
);  
```  
  
### Parameters  
 `_Right`  
 An rvalue reference to a `basic_istringstream` object.  
  
### Remarks  
 The member operator replaces the contents of the object with the contents of `_Right`, treated as an rvalue reference move assignment.  
  
##  <a name="basic_istringstream__rdbuf"></a>  basic_istringstream::rdbuf  
 Returns the address of the stored stream buffer of type **pointer** to [basic_stringbuf](../VS_csharp/basic_stringbuf-class.md)< **Elem**, **Tr**, `Alloc`>.  
  
```  
basic_stringbuf<Elem, Tr, Alloc> *rdbuf( ) const;  
```  
  
### Return Value  
 The address of the stored stream buffer of type **pointer** to basic_stringbuf< **Elem**, **Tr**, `Alloc`>.  
  
### Example  
  See [basic_filebuf::close](../VS_csharp/basic_filebuf-class.md#basic_filebuf__close) for an example that uses `rdbuf`.  
  
##  <a name="basic_istringstream__str"></a>  basic_istringstream::str  
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
 Returns an object of class [basic_string](../VS_csharp/basic_string-class.md)< **Elem**, **Tr**, `Alloc`>, whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
### Remarks  
 The first member function returns [rdbuf](#basic_istringstream__rdbuf) -> [str](../VS_csharp/basic_stringbuf-class.md#basic_stringbuf__str). The second member function calls `rdbuf` -> **str**( `_Newstr`).  
  
### Example  
  See [basic_stringbuf::str](../VS_csharp/basic_stringbuf-class.md#basic_stringbuf__str) for an example that uses **str**.  
  
##  <a name="basic_istringstream__swap"></a>  basic_istringstream::swap  
 Exchanges the values of two `basic_istringstream` objects.  
  
```  
void swap(  
    basic_istringstream& _Right  
);  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Right`|An `lvalue` reference to a `basic_istringstream` object.|  
  
### Remarks  
 The member function exchanges the values of this object and the values of `_Right`.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../VS_csharp/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../VS_csharp/iostream-programming.md)   
 [iostreams Conventions](../VS_csharp/iostreams-conventions.md)