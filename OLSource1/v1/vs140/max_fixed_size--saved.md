---
title: "max_fixed_size::saved"
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
  - max_fixed_size.saved
  - stdext.max_fixed_size.saved
  - allocators/stdext::max_fixed_size::saved
  - stdext::max_fixed_size::saved
  - max_fixed_size::saved
dev_langs: 
  - C++
helpviewer_keywords: 
  - saved method
ms.assetid: 8b3173b2-fe21-4b61-b66e-0575df396150
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# max_fixed_size::saved
Increments the count of memory blocks on the free list.  
  
## Syntax  
  
```  
void saved();  
```  
  
## Remarks  
 This member function increments the stored value `_Nblocks`. This member function is called by `cache_freelist::deallocate` whenever it puts a memory block on the free list.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_fixed_size Class](../vs140/max_fixed_size-class.md)