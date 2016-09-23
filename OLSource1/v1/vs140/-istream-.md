---
title: "&lt;istream&gt;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - istream/std::<istream>
  - std.<istream>
  - <istream>
  - std::<istream>
dev_langs: 
  - C++
helpviewer_keywords: 
  - istream header
ms.assetid: efcf24e4-05d1-4719-ab0b-9e7ebe845d89
caps.latest.revision: 22
translation.priority.mt: 
  - de-de
  - ja-jp
---
# &lt;istream&gt;
Defines the template class basic_istream, which mediates extractions for the iostreams, and the template class basic_iostream, which mediates both insertions and extractions. The header also defines a related manipulator. This header file is typically included for you by another iostreams header; you rarely have to include it directly.  
  
## Syntax  
  
```  
#include <istream>  
  
```  
  
### Typedefs  
  
|||  
|-|-|  
|[iostream](../vs140/-istream--typedefs.md#iostream)|A type `basic_iostream` specialized on `char`.|  
|[istream](../vs140/-istream--typedefs.md#istream)|A type `basic_istream` specialized on `char`.|  
|[wiostream](../vs140/-istream--typedefs.md#wiostream)|A type `basic_iostream` specialized on **wchar**.|  
|[wistream](../vs140/-istream--typedefs.md#wistream)|A type `basic_istream` specialized on **wchar**.|  
  
### Manipulators  
  
|||  
|-|-|  
|[ws](../vs140/-istream--functions.md#ws)|Skips white space in the stream.|  
|[swap](../vs140/-istream--functions.md#istream_swap)|Exchanges two stream objects.|  
  
### Operators  
  
|||  
|-|-|  
|[operator>>](../vs140/-istream--operators.md#operator_gt__gt_)|Extracts characters and strings from the stream.|  
  
### Classes  
  
|||  
|-|-|  
|[basic_iostream](../vs140/basic_iostream-class.md)|A stream class that can do both input and output.|  
|[basic_istream](../vs140/basic_istream-class.md)|The template class describes an object that controls extraction of elements and encoded objects from a stream buffer with elements of type **Elem**, also known as [char_type](../vs140/basic_ios-class.md#basic_ios__char_type), whose character traits are determined by the class **Tr**, also known as [traits_type](../vs140/basic_ios-class.md#basic_ios__traits_type).|  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)