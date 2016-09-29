---
title: "list::const_reverse_iterator"
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
  - "list::const_reverse_iterator"
  - "list/std::list::const_reverse_iterator"
  - "const_reverse_iterator"
  - "std::list::const_reverse_iterator"
  - "std.list.const_reverse_iterator"
  - "list.const_reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reverse_iterator method"
  - "const_reverse_iterator typedef"
ms.assetid: 6ed5190a-b1d5-4507-8d5d-36d41a8078ef
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::const_reverse_iterator
A type that provides a bidirectional iterator that can read any **const** element in a list.  
  
## Syntax  
  
```  
typedef std::reverse_iterator<const_iterator> const_reverse_iterator;  
```  
  
## Remarks  
 A type `const_reverse_iterator` cannot modify the value of an element and is used to iterate through the list in reverse.  
  
## Example  
 See the example for [rbegin](../vs140/list--rbegin.md).  
  
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)