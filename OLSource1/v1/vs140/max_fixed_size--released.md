---
title: "max_fixed_size::released"
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
  - "stdext.max_fixed_size.released"
  - "allocators/stdext::max_fixed_size::released"
  - "stdext::max_fixed_size::released"
  - "max_fixed_size.released"
  - "max_fixed_size::released"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "released method"
ms.assetid: 4df4b00f-199e-4b65-b323-32c62217dca7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_fixed_size::released
Decrements the count of memory blocks on the free list.  
  
## Syntax  
  
```  
void released();  
```  
  
## Remarks  
 Decrements the stored value `_Nblocks`. The `released` member function of the current [max class](../vs140/-allocators-.md) is called by `cache_freelist::allocate` whenever it removes a memory block from the free list.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_fixed_size Class](../vs140/max_fixed_size-class.md)