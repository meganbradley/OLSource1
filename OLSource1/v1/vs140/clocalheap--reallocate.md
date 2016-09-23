---
title: "CLocalHeap::Reallocate"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CLocalHeap.Reallocate
  - ATL::CLocalHeap::Reallocate
  - Reallocate
  - CLocalHeap.Reallocate
  - CLocalHeap::Reallocate
dev_langs: 
  - C++
helpviewer_keywords: 
  - Reallocate method
ms.assetid: 40e03987-39e4-46ea-ae5f-5170f0592056
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CLocalHeap::Reallocate
Call this method to reallocate memory allocated by this memory manager.  
  
## Syntax  
  
```  
  
      virtual __declspec(allocator) void* Reallocate(  
   void* p,  
   size_t nBytes   
) throw( );  
```  
  
#### Parameters  
 `p`  
 Pointer to memory previously allocated by this memory manager.  
  
 `nBytes`  
 The requested number of bytes in the new memory block.  
  
## Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
## Remarks  
 Call [CLocalHeap::Free](../vs140/clocalheap--free.md) to free the memory allocated by this method.  
  
 Implemented using [LocalReAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366742).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CLocalHeap Class](../vs140/clocalheap-class.md)   
 [CLocalHeap::Free](../vs140/clocalheap--free.md)   
 [CLocalHeap::Allocate](../vs140/clocalheap--allocate.md)