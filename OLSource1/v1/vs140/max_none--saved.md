---
title: "max_none::saved"
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
  - "allocators/stdext::max_none::saved"
  - "max_none.saved"
  - "stdext::max_none::saved"
  - "stdext.max_none.saved"
  - "max_none::saved"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "saved method"
ms.assetid: 6548e8a7-b184-4295-96d0-331f1adad03b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_none::saved
Increments the count of memory blocks on the free list.  
  
## Syntax  
  
```  
void saved();  
```  
  
## Remarks  
 This member function does nothing. It is called by `cache_freelist::deallocate` whenever it puts a memory block on the free list.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_none Class](../vs140/max_none-class.md)