---
title: "char_traits&lt;wchar_t&gt; Struct"
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
  - "std.char_traits<wchar_t>"
  - "char_traits<wchar_t>"
  - "string/std::char_traits<wchar_t>"
  - "std::char_traits<wchar_t>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "char_traits<wchar_t> class"
ms.assetid: 31f34072-04d6-4871-88fe-48e17d473484
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits&lt;wchar_t&gt; Struct
A class that is a specialization of the template struct **char_traits<CharType\>** to an element of type `wchar_t`.  
  
## Syntax  
  
```  
template<> struct char_traits<wchar_t>;  
```  
  
## Remarks  
 Specialization allows the struct to take advantage of library functions that manipulate objects of this type `wchar_t`.  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Class](../vs140/char_traits-struct.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)