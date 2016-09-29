---
title: "char_traits&lt;char&gt; Struct"
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
  - "string/std::char_traits<char>"
  - "std::char_traits<char >"
  - "char_traits<char >"
  - "std.char_traits<char >"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "char_traits<char> class"
ms.assetid: abd9373a-77db-4031-bf4b-f8ac15087581
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits&lt;char&gt; Struct
A struct that is a specialization of the template struct **char_traits\<CharType>** to an element of type `char`.  
  
## Syntax  
  
```  
template<> struct char_traits<char>;  
```  
  
## Remarks  
 Specialization allows the struct to take advantage of library functions that manipulate objects of this type `char`.  
  
## Example  
 See the typedefs and member functions of the template class [char_traits Class](../vs140/char_traits-struct.md)< **CharType**> for examples involving elements of type `char`.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std