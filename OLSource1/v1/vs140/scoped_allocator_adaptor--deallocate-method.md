---
title: "scoped_allocator_adaptor::deallocate Method"
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
  - "scoped_allocator/std::scoped_allocator_adaptor::deallocate"
dev_langs: 
  - "C++"
ms.assetid: ca7f3e72-7c19-4adb-af6e-f2ae7fdb7a07
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor::deallocate Method
Deallocates objects by using the outer allocator.  
  
## Syntax  
  
```cpp  
void deallocate(pointer ptr, size_type count);  
```  
  
#### Parameters  
 `ptr`  
 A pointer to the starting location of the objects to be deallocated.  
  
 `count`  
 The number of objects to deallocate.  
  
## Requirements  
 **Header:** <scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)   
 [allocator_traits::deallocate Method](../vs140/allocator_traits--deallocate-method.md)