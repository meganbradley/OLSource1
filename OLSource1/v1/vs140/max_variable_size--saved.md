---
title: "max_variable_size::saved"
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
  - "stdext.max_variable_size.saved"
  - "stdext::max_variable_size::saved"
  - "allocators/stdext::max_variable_size::saved"
  - "max_variable_size.saved"
  - "max_variable_size::saved"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "saved method"
ms.assetid: d856f204-fa94-4699-b96e-dde8f13424d9
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# max_variable_size::saved
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
 [max_variable_size Class](../vs140/max_variable_size-class.md)