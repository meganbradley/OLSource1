---
title: "Input-Output Streams"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Input/Output Streams"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "I/O [C++], stream"
  - "stream I/O"
ms.assetid: 21a97566-91a7-42d6-b2f8-a4c16bc926f1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Input-Output Streams
`basic_iostream`, which is defined in the header file <istream\>, is the class template for objects that handle both input and output character-based I/O streams.  
  
 There are two typedefs that define character-specific specializations of `basic_iostream` and can help make code easier to read: `iostream` (not to be confused with the header file <iostream\>) is an I/O stream that is based on `basic_iostream<char>`; `wiostream` is an I/O stream that is based on `basic_iostream<wchar_t>`.  
  
 For more information, see [basic_iostream](../vs140/basic_iostream-class.md), [iostream](../vs140/iostream.md), and [wiostream](../vs140/wiostream.md).  
  
 Deriving from `basic_iostream` is the class template `basic_fstream`, which is used to stream character data to and from files.  
  
 There also are typedefs that provide character-specific specializations of `basic_fstream`. They are `fstream`, which is a file I/O stream that is based on `char`, and `wfstream`, which is a file I/O stream that is based on `wchar_t`. For more information, see [basic_fstream](../vs140/basic_fstream-class.md), [fstream](../vs140/fstream.md), and [wfstream](../vs140/wfstream.md). Using these typedefs requires the inclusion of the header file <fstream\>.  
  
> [!NOTE]
>  When a `basic_fstream` object is used to perform file I/O, although the underlying buffer contains separately designated positions for reading and writing, the current input and current output positions are tied together, and therefore, reading some data moves the output position.  
  
 The class template `basic_stringstream` and its common specialization, `stringstream`, are often used to work with I/O stream objects to insert and extract character data. For more information, see [basic_stringstream](../vs140/basic_stringstream-class.md).  
  
## See Also  
 [stringstream](../vs140/stringstream.md)   
 [basic_stringstream](../vs140/basic_stringstream-class.md)   
 [<sstream\>](../vs140/-sstream-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [Standard C++ Library](../vs140/c---standard-library-reference.md)