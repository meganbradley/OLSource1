---
title: "scoped_allocator_adaptor::max_size Method"
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
  - "scoped_allocator/std::scoped_allocator_adaptor::max_size"
dev_langs: 
  - "C++"
ms.assetid: 45c164f3-c1e1-4a35-812a-fff0bcac7102
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor::max_size Method
Determines the maximum number of objects that can be allocated by the outer allocator.  
  
## Syntax  
  
```cpp  
size_type max_size();  
```  
  
## Return Value  
 `Outer_traits::max_size(outer_allocator())`  
  
## Requirements  
 **Header:** <scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)   
 [allocator_traits::max_size Method](../vs140/allocator_traits--max_size-method.md)