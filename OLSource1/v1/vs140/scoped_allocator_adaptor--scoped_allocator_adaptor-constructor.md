---
title: "scoped_allocator_adaptor::scoped_allocator_adaptor Constructor"
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
  - "scoped_allocator/std::scoped_allocator_adaptor::scoped_allocator_adaptor"
dev_langs: 
  - "C++"
ms.assetid: 65b9fc46-8f64-42e1-b218-16310a76614f
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor::scoped_allocator_adaptor Constructor
Constructs a `scoped_allocator_adaptor` object.  
  
## Syntax  
  
```cpp  
scoped_allocator_adaptor();  
scoped_allocator_adaptor(const scoped_allocator_adaptor& right) noexcept;  
template<class Outer2>  
    scoped_allocator_adaptor(  
        const scoped_allocator_adaptor<Outer2, Inner...>& right) noexcept;  
template<class Outer2>  
    scoped_allocator_adaptor(  
        scoped_allocator_adaptor<Outer2, Inner...>&& right) noexcept;  
template<class Outer2>  
    scoped_allocator_adaptor(Outer2&& al,  
        const Inner&... rest) noexcept;  
```  
  
#### Parameters  
 `right`  
 An existing `scoped_allocator_adaptor`.  
  
 `al`  
 An existing allocator to be used as the outer allocator.  
  
 `rest`  
 A list of allocators to be used as the inner allocators.  
  
## Remarks  
 The first constructor default constructs its stored allocator objects. Each of the next three constructors constructs its stored allocator objects from the corresponding objects in `right`. The last constructor constructs its stored allocator objects from the corresponding arguments in the argument list.  
  
## Requirements  
 **Header:** <scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)