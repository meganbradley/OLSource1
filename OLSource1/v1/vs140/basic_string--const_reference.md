---
title: "basic_string::const_reference"
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
  - "basic_string::const_reference"
  - "std::basic_string::const_reference"
  - "const_reference"
  - "xstring/std::basic_string::const_reference"
  - "basic_string.const_reference"
  - "std.basic_string.const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference method"
  - "const_reference typedef"
ms.assetid: 8a96f59d-150d-44de-8e9e-dfa62c45fb29
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::const_reference
A type that provides a reference to a **const** element stored in a string for reading and performing **const** operations.  
  
## Syntax  
  
```  
typedef typename allocator_type::const_reference const_reference;  
```  
  
## Remarks  
 A type `const_reference` cannot be used to modify the value of an element.  
  
 The type is a synonym for **allocator_type::const_reference**. For string **type**, it is equivalent to const **char&**.  
  
## Example  
 See the example for [at](../vs140/basic_string--at.md) for an example of how to declare and use `const_reference`.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)