---
title: "scoped_allocator_adaptor::inner_allocator Method"
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
  - "scoped_allocator/std::scoped_allocator_adaptor::inner_allocator"
dev_langs: 
  - "C++"
ms.assetid: e590ec24-2e99-47b0-b40e-866bf65f51bc
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor::inner_allocator Method
Retrieves a reference to the stored object of type `inner_allocator_type`.  
  
## Syntax  
  
```cpp  
inner_allocator_type& inner_allocator() noexcept;  
const inner_allocator_type& inner_allocator() const noexcept;  
```  
  
## Return Value  
 A reference to the stored object of type `inner_allocator_type`.  
  
## Requirements  
 **Header:** <scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)