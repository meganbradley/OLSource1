---
title: "scoped_allocator_adaptor::select_on_container_copy_construction Method"
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
  - "scoped_allocator/std::scoped_allocator_adaptor::select_on_container_copy_construction"
dev_langs: 
  - "C++"
ms.assetid: 426a6384-629f-4ab9-8b95-4c243dbfd6f7
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor::select_on_container_copy_construction Method
Creates a new `scoped_allocator_adaptor` object with each stored allocator object initialized by calling `select_on_container_copy_construction` for each corresponding allocator.  
  
## Syntax  
  
```cpp  
scoped_allocator_adaptor select_on_container_copy_construction();  
```  
  
## Return Value  
 This method effectively returns `scoped_allocator_adaptor(Outer_traits::select_on_container_copy_construction(*this), inner_allocator().select_on_container_copy_construction())`. The result is a new `scoped_allocator_adaptor` object with each stored allocator object initialized by calling `al.select_on_container_copy_construction()` for the corresponding allocator `al`.  
  
## Requirements  
 **Header:** \<scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)   
 [allocator_traits::select_on_container_copy_construction Method](../vs140/allocator_traits--select_on_container_copy_construction-method.md)