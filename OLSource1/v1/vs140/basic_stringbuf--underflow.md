---
title: "basic_stringbuf::underflow"
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
  - "underflow"
  - "basic_stringbuf::underflow"
  - "basic_stringbuf.underflow"
  - "std.basic_stringbuf.underflow"
  - "std::basic_stringbuf::underflow"
  - "sstream/std::basic_stringbuf::underflow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "underflow method"
ms.assetid: 99acc623-d38e-4e39-9c32-5a1048f0ca90
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringbuf::underflow
Protected, virtual function to extract the current element from the input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the function cannot succeed, it returns **traits_type::**[eof](../vs140/char_traits--eof.md). Otherwise, it returns the current element in the input stream, which are converted.  
  
## Remarks  
 The protected virtual member function tries to extract the current element **byte** from the input buffer, advance the current stream position, and return the element as **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)(**byte**). It can do so in one way: If a read position is available, it takes **byte** as the element stored in the read position and advances the next pointer for the input buffer.  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringbuf Class](../vs140/basic_stringbuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)