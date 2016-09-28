---
title: "char_traits::int_type"
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
  - "std::char_traits::int_type"
  - "char_traits::int_type"
  - "std.char_traits.int_type"
  - "int_type"
  - "char_traits.int_type"
  - "iosfwd/std::char_traits::int_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "int_type typedef"
ms.assetid: 7d709bb8-31f6-4033-8c35-7105d3c31f22
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::int_type
An integer type that can represent a character of type `char_type` or an end-of-file (EOF) character.  
  
## Syntax  
  
```  
typedef long int_type;  
```  
  
## Remarks  
 It must be possible to type cast a value of type **CharType** to `int_type` then back to **CharType** without altering the original value.  
  
## Example  
 See the example for [eq_int_type](../vs140/char_traits--eq_int_type.md) for an example of how to declare and use `int_type`.  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)