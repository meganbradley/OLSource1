---
title: "basic_string::const_iterator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::basic_string::const_iterator
  - const_iterator
  - basic_string.const_iterator
  - std.basic_string.const_iterator
  - xstring/std::basic_string::const_iterator
  - basic_string::const_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_iterator method
  - const_iterator typedef
ms.assetid: 67f5eaeb-ce42-420b-af38-5fca25d0613b
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_string::const_iterator
A type that provides a random-access iterator that can access and read a **const** element in the string.  
  
## Syntax  
  
```  
typedef implementation-defined const_iterator;  
```  
  
## Remarks  
 A type `const_iterator` cannot be used to modify the value of a character and is used to iterate through a string in a forward direction.  
  
## Example  
 See the example for [begin](../vs140/basic_string--begin.md) for an example of how to declare and use `const_iterator`.  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)