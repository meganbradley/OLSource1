---
title: "CLocalHeap::Allocate"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL.CLocalHeap.Allocate"
  - "CLocalHeap::Allocate"
  - "ATL::CLocalHeap::Allocate"
  - "CLocalHeap.Allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Allocate method"
ms.assetid: 562e18c4-da61-470d-8c5e-915081fba3e6
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLocalHeap::Allocate
Call this method to allocate a block of memory.  
  
## Syntax  
  
```  
  
      virtual __declspec(allocator) void* Allocate(  
   size_t nBytes   
) throw( );  
```  
  
#### Parameters  
 `nBytes`  
 The requested number of bytes in the new memory block.  
  
## Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
## Remarks  
 Call [CLocalHeap::Free](../vs140/clocalheap--free.md) or [CLocalHeap::Reallocate](../vs140/clocalheap--reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [LocalAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366723) with a flag parameter of **LMEM_FIXED**.  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CLocalHeap Class](../vs140/clocalheap-class.md)   
 [CLocalHeap::Free](../vs140/clocalheap--free.md)   
 [CLocalHeap::Reallocate](../vs140/clocalheap--reallocate.md)