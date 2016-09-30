---
title: "&lt;sstream&gt;"
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
  - "std.<sstream>"
  - "std::<sstream>"
  - "<sstream>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sstream header"
ms.assetid: 56f55bc5-549d-4e7f-aaad-99e0ffa49c9e
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;sstream&gt;
Defines several template classes that support iostreams operations on sequences stored in an allocated array object. Such sequences are easily converted to and from objects of template class [basic_string](../vs140/basic_string-class.md).  
  
## Syntax  
  
```  
namespace std {  
template<class CharType,  
    class Traits = char_traits<CharType>,  
    class Allocator = allocator<CharType> >  
    class basic_stringbuf;  
typedef basic_stringbuf<char> stringbuf;  
typedef basic_stringbuf<wchar_t> wstringbuf;  
  
template<class CharType,  
    class Traits = char_traits<CharType>,  
    class Allocator = allocator<CharType> >  
    class basic_istringstream;  
typedef basic_istringstream<char> istringstream;  
typedef basic_istringstream<wchar_t> wistringstream;  
  
template<class CharType,  
    class Traits = char_traits<CharType>,  
    class Allocator = allocator<CharType> >  
    class basic_ostringstream;  
typedef basic_ostringstream<char> ostringstream;  
typedef basic_ostringstream<wchar_t> wostringstream;  
  
template<class CharType,  
    class Traits = char_traits<CharType>,  
    class Allocator = allocator<CharType> >  
    class basic_stringstream;  
typedef basic_stringstream<char> stringstream;  
typedef basic_stringstream<wchar_t> wstringstream;  
  
        // TEMPLATE FUNCTIONS  
template<class CharType, class Traits, class Allocator>  
    void swap(  
        basic_stringbuf<CharType, Traits, Allocator>& _Left,  
        basic_stringbuf<CharType, Traits, Allocator>& _Right  
    );   
template<class CharType, class Traits, class Allocator>  
    void swap(  
        basic_istringstream<CharType, Traits, Allocator>& _Left,  
        basic_istringstream<CharType, Traits, Allocator>& _Right  
    );  
template<class CharType, class Traits, class Allocator>  
    void swap(  
        basic_ostringstream<CharType, Traits, Allocator>& _Left,  
        basic_ostringstream<CharType, Traits, Allocator>& _Right  
    );  
template<class CharType, class Traits, class Allocator>  
    void swap (  
        basic_stringstream<CharType, Traits, Allocator>& _Left,  
        basic_stringstream<CharType, Traits, Allocator>& _Right  
    );  
}  // namespace std  
  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|Reference to an `sstream` object.|  
|`_Right`|Reference to an `sstream` object.|  
  
## Remarks  
 Objects of type `char *` can use the functionality in [\<strstream>](../vs140/-strstream-.md) for streaming. However, `<strstream>` is deprecated and the use of `<sstream>` is encouraged.  
  
### Typedefs  
  
|||  
|-|-|  
|[istringstream](../vs140/-sstream--typedefs.md#istringstream)|Creates a type `basic_istringstream` specialized on a `char` template parameter.|  
|[ostringstream](../vs140/-sstream--typedefs.md#ostringstream)|Creates a type `basic_ostringstream` specialized on a `char` template parameter.|  
|[stringbuf](../vs140/-sstream--typedefs.md#stringbuf)|Creates a type `basic_stringbuf` specialized on a `char` template parameter.|  
|[stringstream](../vs140/-sstream--typedefs.md#stringstream)|Creates a type `basic_stringstream` specialized on a `char` template parameter.|  
|[wistringstream](../vs140/-sstream--typedefs.md#wistringstream)|Creates a type `basic_istringstream` specialized on a `wchar_t` template parameter.|  
|[wostringstream](../vs140/-sstream--typedefs.md#wostringstream)|Creates a type `basic_ostringstream` specialized on a `wchar_t` template parameter.|  
|[wstringbuf](../vs140/-sstream--typedefs.md#wstringbuf)|Creates a type `basic_stringbuf` specialized on a `wchar_t` template parameter.|  
|[wstringstream](../vs140/-sstream--typedefs.md#wstringstream)|Creates a type `basic_stringstream` specialized on a `wchar_t` template parameter.|  
  
### Manipulators  
  
|||  
|-|-|  
|[swap](../vs140/-sstream--functions.md#sstream_swap)|Exchanges the values between two `sstream` objects.|  
  
### Classes  
  
|||  
|-|-|  
|[basic_stringbuf](../vs140/basic_stringbuf-class.md)|Describes a stream buffer that controls the transmission of elements of type **Elem**, whose character traits are determined by the class **Tr**, to and from a sequence of elements stored in an array object.|  
|[basic_istringstream](../vs140/basic_istringstream-class.md)|Describes an object that controls extraction of elements and encoded objects from a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, `Alloc`>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class `Alloc`.|  
|[basic_ostringstream](../vs140/basic_ostringstream-class.md)|Describes an object that controls insertion of elements and encoded objects into a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, `Alloc`>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class `Alloc`.|  
|[basic_stringstream](../vs140/basic_stringstream-class.md)|Describes an object that controls insertion and extraction of elements and encoded objects using a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, `Alloc`>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class `Alloc`.|  
  
## Requirements  
  
-   **Header:** \<sstream>  
  
-   **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)