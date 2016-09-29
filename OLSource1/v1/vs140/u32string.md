---
title: "u32string"
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
  - "string/std::u32string"
  - "xstring/std::u32string"
  - "std.u32string"
  - "u32string"
  - "std::u32string"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "std::u32string"
  - "u32string typedef"
  - "std.u32string"
ms.assetid: fd3970a3-a8b2-42ff-aadd-1cc99045f88a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# u32string
A type that describes a specialization of the template class [basic_string](../vs140/basic_string-class.md) with elements of type `char32_t`.  
  
 Other typedefs that specialize `basic_string` include [string](../vs140/string--c---stl--string--.md), [u16string](../vs140/u16string.md), and [wstring](../vs140/wstring.md).  
  
## Syntax  
  
```cpp  
typedef basic_string<char32_t, char_traits<char32_t>, allocator<char32_t>> u32string;  
```  
  
## Remarks  
 For a list of string constructors, see [basic_string::basic_string](../vs140/basic_string--basic_string.md).  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [<string\>](../vs140/-string-.md)   
 [basic_string Class](../vs140/basic_string-class.md)