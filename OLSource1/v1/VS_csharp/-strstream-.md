---
title: "&lt;strstream&gt;"
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
  - "std.<strstream>"
  - "std::<strstream>"
  - "<strstream>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strstream header"
ms.assetid: eaa9d0d4-d217-4f28-8a68-9b9ad7b1c0f5
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;strstream&gt;
Defines several classes that support iostreams operations on sequences stored in an allocated array of `char` object. Such sequences are easily converted to and from C strings.  
  
## Syntax  
  
```  
#include <strstream>  
  
```  
  
## Remarks  
 Objects of type `strstream` work with `char` *, which are C strings. Use [<sstream\>](../VS_csharp/-sstream-.md) to work with objects of type [basic_string](../VS_csharp/basic_string-class.md).  
  
> [!NOTE]
>  The classes in `<strstream>` are deprecated. Consider using the classes in `<sstream>` instead.  
  
### Classes  
  
|||  
|-|-|  
|[strstreambuf Class](../VS_csharp/strstreambuf-class.md)|The class describes a stream buffer that controls the transmission of elements to and from a sequence of elements stored in a `char` array object.|  
|[istrstream Class](../VS_csharp/istrstream-class.md)|The class describes an object that controls extraction of elements and encoded objects from a stream buffer of class [strstreambuf](../VS_csharp/strstreambuf-class.md).|  
|[ostrstream Class](../VS_csharp/ostrstream-class.md)|The class describes an object that controls insertion of elements and encoded objects into a stream buffer of class [strstreambuf](../VS_csharp/strstreambuf-class.md).|  
|[strstream Class](../VS_csharp/strstream-class.md)|The class describes an object that controls insertion and extraction of elements and encoded objects using a stream buffer of class [strstreambuf](../VS_csharp/strstreambuf-class.md).|  
  
## See Also  
 [<strstream\>](../VS_csharp/-strstream-.md)   
 [Header Files](../VS_csharp/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../VS_csharp/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../VS_csharp/iostream-programming.md)   
 [iostreams Conventions](../VS_csharp/iostreams-conventions.md)