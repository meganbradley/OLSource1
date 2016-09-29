---
title: "vector::const_iterator"
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
  - "vector::const_iterator"
  - "const_iterator"
  - "std.vector.const_iterator"
  - "std::vector::const_iterator"
  - "vector.const_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_iterator method"
ms.assetid: 6431d5a4-f7cf-44a6-be0d-ff2b2d21d374
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::const_iterator
A type that provides a random-access iterator that can read a **const** element in a vector.  
  
## Syntax  
  
```  
typedef implementation-defined const_iterator;  
```  
  
## Remarks  
 A type `const_iterator` cannot be used to modify the value of an element.  
  
## Example  
 See the example for [back](../vs140/vector--back.md) for an example that uses `const_iterator`.  
  
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)