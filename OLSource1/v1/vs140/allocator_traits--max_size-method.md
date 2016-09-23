---
title: "allocator_traits::max_size Method"
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
  - memory/std::allocator_traits::max_size
dev_langs: 
  - C++
ms.assetid: 728265ef-0df3-4538-913b-829c23012918
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# allocator_traits::max_size Method
Static method that uses a specified allocator to determine the maximum number of objects that can be allocated.  
  
## Syntax  
  
```cpp  
static size_type max_size(const Alloc& al);  
```  
  
#### Parameters  
 `al`  
 An allocator object.  
  
## Remarks  
 This method returns `al.max_size()`, if that expression is well formed; otherwise it returns `numeric_limits<size_type>::max()`.  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [allocator::max_size](../vs140/allocator--max_size.md)   
 [allocator_traits Class](../vs140/allocator_traits-class.md)