---
title: "max_none::released"
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
  - "allocators/stdext::max_none::released"
  - "max_none::released"
  - "stdext::max_none::released"
  - "stdext.max_none.released"
  - "max_none.released"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "released method"
ms.assetid: c4eedf14-2810-49bf-bd9d-8d015067e739
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_none::released
Decrements the count of memory blocks on the free list.  
  
## Syntax  
  
```  
void released();  
```  
  
## Remarks  
 This member function does nothing. The `released` member function of the current max class is called by `cache_freelist::allocate` whenever it removes a memory block from the free list.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_none Class](../vs140/max_none-class.md)