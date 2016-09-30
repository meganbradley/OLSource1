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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Reference to an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Reference to an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 Objects of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can use the functionality in [\<strstream>](../vs140/-strstream-.md) for streaming. However, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is deprecated and the use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is encouraged.  
  
### Typedefs  
  
|||  
|-|-|  
|[istringstream](../vs140/-sstream--typedefs.md#istringstream)|Creates a type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> specialized on a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> template parameter.|  
|[ostringstream](../vs140/-sstream--typedefs.md#ostringstream)|Creates a type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> specialized on a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> template parameter.|  
|[stringbuf](../vs140/-sstream--typedefs.md#stringbuf)|Creates a type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> specialized on a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> template parameter.|  
|[stringstream](../vs140/-sstream--typedefs.md#stringstream)|Creates a type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specialized on a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> template parameter.|  
|[wistringstream](../vs140/-sstream--typedefs.md#wistringstream)|Creates a type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> specialized on a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> template parameter.|  
|[wostringstream](../vs140/-sstream--typedefs.md#wostringstream)|Creates a type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> specialized on a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> template parameter.|  
|[wstringbuf](../vs140/-sstream--typedefs.md#wstringbuf)|Creates a type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> specialized on a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> template parameter.|  
|[wstringstream](../vs140/-sstream--typedefs.md#wstringstream)|Creates a type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> specialized on a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> template parameter.|  
  
### Manipulators  
  
|||  
|-|-|  
|[swap](../vs140/-sstream--functions.md#sstream_swap)|Exchanges the values between two <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> objects.|  
  
### Classes  
  
|||  
|-|-|  
|[basic_stringbuf](../vs140/basic_stringbuf-class.md)|Describes a stream buffer that controls the transmission of elements of type **Elem**, whose character traits are determined by the class **Tr**, to and from a sequence of elements stored in an array object.|  
|[basic_istringstream](../vs140/basic_istringstream-class.md)|Describes an object that controls extraction of elements and encoded objects from a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[basic_ostringstream](../vs140/basic_ostringstream-class.md)|Describes an object that controls insertion of elements and encoded objects into a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
|[basic_stringstream](../vs140/basic_stringstream-class.md)|Describes an object that controls insertion and extraction of elements and encoded objects using a stream buffer of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<**Elem**, **Tr**, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>>, with elements of type **Elem**, whose character traits are determined by the class **Tr**, and whose elements are allocated by an allocator of class <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
  
## Requirements  
  
-   **Header:** \<sstream>  
  
-   **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)