---
title: "max_unbounded::saved"
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
  - "allocators/stdext::max_unbounded::saved"
  - "stdext.max_unbounded.saved"
  - "stdext::max_unbounded::saved"
  - "max_unbounded.saved"
  - "max_unbounded::saved"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "saved method"
ms.assetid: 376c000a-7dff-48b1-83d7-d13ac778043d
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_unbounded::saved
Increments the count of memory blocks on the free list.  
  
## Syntax  
  
```  
void saved();  
```  
  
## Remarks  
 This member function does nothing. It is called by `cache_freelist::deallocate` whenever it puts a memory block on the free list.  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_unbounded Class](../vs140/max_unbounded-class.md)