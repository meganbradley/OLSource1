---
title: "scoped_allocator_adaptor::rebind Struct"
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
  - "scoped_allocator/std::scoped_allocator_adaptor::rebind"
dev_langs: 
  - "C++"
ms.assetid: 4b8ff12f-1af3-4922-95bb-68e13b8b63e4
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor::rebind Struct
Defines the type `Outer::rebind<Other>::other` as a synonym for `scoped_allocator_adaptor<Other, Inner...>`.  
  
## Syntax  
  
```cpp  
template<class Other>  
   struct rebind{  
      typedef Other_traits::rebind<Other> Other_alloc;  
      typedef scoped_allocator_adaptor<Other_alloc, Inner...> other;  
  
   };  
```  
  
## Requirements  
 **Header:** <scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)