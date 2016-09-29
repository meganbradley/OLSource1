---
title: "allocator_base::difference_type"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "allocator_base.difference_type"
  - "allocators::allocator_base::difference_type"
  - "stdext::allocators::allocator_base::difference_type"
  - "stdext::allocator_base::difference_type"
  - "allocator_base::difference_type"
  - "stdext.allocator_base.difference_type"
  - "allocators/stdext::allocator_base::difference_type"
  - "difference_type"
  - "stdext.allocators.allocator_base.difference_type"
  - "allocators.allocator_base.difference_type"
  - "allocators/stdext::allocators::allocator_base::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: e3a5f646-b5fa-4d99-bf3c-439c034610d6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator_base::difference_type
A signed integral type that can represent the difference between values of pointers to the type of object managed by the allocator.  
  
## Syntax  
  
```  
typedef std::ptrdiff_t difference_type;  
```  
  
## Remarks  
 The integer type implements  as a typedef for `std::ptrdiff_t`.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext