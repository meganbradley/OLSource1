---
title: "string (C++ STL &lt;string&gt;)"
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
  - "string"
  - "std.string"
  - "string/std::string"
  - "std::string"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "string typedef"
ms.assetid: d1165585-d2be-4ccc-a53d-4bd6e1c558ad
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# string (C++ STL &lt;string&gt;)
A type that describes a specialization of the template class [basic_string](../vs140/basic_string-class.md) with elements of type `char`.  
  
 Other typedefs that specialize `basic_string` include [wstring](../vs140/wstring.md), [u16string](../vs140/u16string.md), and [u32string](../vs140/u32string.md).  
  
## Syntax  
  
```cpp  
typedef basic_string<char, char_traits<char>, allocator<char>> string;  
```  
  
## Remarks  
 The following are equivalent declarations:  
  
```cpp  
string str("");  
  
basic_string<char> str("");  
```  
  
 For a list of string constructors, see [basic_string::basic_string](../vs140/basic_string--basic_string.md).  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [<string\>](../vs140/-string-.md)   
 [basic_string Class](../vs140/basic_string-class.md)