---
title: "basic_streambuf::uflow"
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
  - "basic_streambuf.uflow"
  - "uflow"
  - "std::basic_streambuf::uflow"
  - "basic_streambuf::uflow"
  - "streambuf/std::basic_streambuf::uflow"
  - "std.basic_streambuf.uflow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uflow method"
ms.assetid: ff9163fd-5355-48ae-90a5-e3669696a8c0
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::uflow
A protected virtual function that extracts the current element from the input stream.  
  
## Syntax  
  
```  
  
virtual int  
_  
type uflow( );  
  
```  
  
## Return Value  
 The current element.  
  
## Remarks  
 The protected virtual member function tries to extract the current element **ch** from the input stream, then advance the current stream position, and return the element as **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)(**ch**). It can do so in various ways:  
  
-   If a read position is available, it takes **ch** as the element stored in the read position and advances the next pointer for the input buffer.  
  
-   It can read an element directly, from some external source, and deliver it as the value **ch**.  
  
-   For a stream buffer with common input and output streams, it can make a read position available by writing out, to some external destination, some or all of the elements between the beginning and next pointers for the output buffer. Or it can allocate new or additional storage for the input buffer. The function then reads in, from some external source, one or more elements.  
  
 If the function cannot succeed, it returns **traits_type::**[eof](../vs140/char_traits--eof.md), or throws an exception. Otherwise, it returns the current element `ch` in the input stream, converted as described above, and advances the next pointer for the input buffer. The default behavior is to call [underflow](../vs140/basic_streambuf--underflow.md) and, if that function returns **traits_type::eof**, to return **traits_type::eof**. Otherwise, the function returns the current element **ch** in the input stream, converted as previously described, and advances the next pointer for the input buffer.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)