---
title: "max_variable_size::released"
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
  - "allocators/stdext::max_variable_size::released"
  - "stdext.max_variable_size.released"
  - "max_variable_size.released"
  - "max_variable_size::released"
  - "stdext::max_variable_size::released"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "released method"
ms.assetid: 99354e81-907d-47c5-a8f2-ce5f8e8429d3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_variable_size::released
Decrements the count of memory blocks on the free list.  
  
## Syntax  
  
```  
void released();  
```  
  
## Remarks  
 This member function decrements the stored value `_Nblocks`. The `released` member function of the current max class is called by `cache_freelist::allocate` whenever it removes a memory block from the free list.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_variable_size Class](../vs140/max_variable_size-class.md)