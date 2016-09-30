---
title: "set::const_reverse_iterator"
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
  - "set.const_reverse_iterator"
  - "std.set.const_reverse_iterator"
  - "const_reverse_iterator"
  - "set::const_reverse_iterator"
  - "set/std::set::const_reverse_iterator"
  - "std::set::const_reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reverse_iterator method"
  - "const_reverse_iterator typedef"
ms.assetid: 6691f023-2eb0-49cf-91d0-361d7fd35112
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::const_reverse_iterator
A type that provides a bidirectional iterator that can read any **const** element in the set.  
  
## Syntax  
  
```  
typedef std::reverse_iterator<const_iterator> const_reverse_iterator;  
```  
  
## Remarks  
 A type `const_reverse_iterator` cannot modify the value of an element and is use to iterate through the set in reverse.  
  
## Example  
 See the example for [rend](../vs140/set--rend.md) for an example of how to declare and use the `const_reverse_iterator`.  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)