---
title: "u16string"
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
  - "std::u16string"
  - "std.u16string"
  - "xstring/std::u16string"
  - "u16string"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "u16string typedef"
ms.assetid: 5e1dcd3a-b1e4-4ee0-8389-629f7c2061c1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# u16string
A type that describes a specialization of the template class [basic_string](../vs140/basic_string-class.md) with elements of type `char16_t`.  
  
 Other typedefs that specialize `basic_string` include [wstring](../vs140/wstring.md), [string](../vs140/string--c---stl--string--.md), and [u32string](../vs140/u32string.md).  
  
## Syntax  
  
```cpp  
typedef basic_string<char16_t, char_traits<char16_t>, allocator<char16_t>> u16string;  
```  
  
## Remarks  
 For a list of string constructors, see [basic_string::basic_string](../vs140/basic_string--basic_string.md).  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [<string\>](../vs140/-string-.md)   
 [basic_string Class](../vs140/basic_string-class.md)