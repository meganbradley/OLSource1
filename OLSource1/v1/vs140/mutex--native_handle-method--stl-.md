---
title: "mutex::native_handle Method (STL)"
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
  - "mutex/std::mutex::native_handle"
dev_langs: 
  - "C++"
ms.assetid: b0ee13ee-d29a-4e8d-9915-cb2280edff77
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mutex::native_handle Method (STL)
Returns the implementation-specific type that represents the mutex handle. The mutex handle can be used in implementation-specific ways.  
  
## Syntax  
  
```  
native_handle_type native_handle();  
```  
  
## Return Value  
 `native_handle_type` is defined as a `Concurrency::critical_section *` that's cast as `void *`.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [mutex Class](../vs140/mutex-class--stl-.md)   
 [\<mutex>](../vs140/-mutex-.md)