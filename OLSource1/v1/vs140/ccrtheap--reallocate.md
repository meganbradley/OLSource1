---
title: "CCRTHeap::Reallocate"
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
  - "ATL.CCRTHeap.Reallocate"
  - "Reallocate"
  - "ATL::CCRTHeap::Reallocate"
  - "CCRTHeap::Reallocate"
  - "CCRTHeap.Reallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reallocate method"
ms.assetid: 0e978038-4fcf-4b6e-b9ce-69ea50fe55f8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCRTHeap::Reallocate
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
 Call [CCRTHeap::Free](../vs140/ccrtheap--free.md) to free the memory allocated by this method. Implemented using [realloc](../vs140/realloc.md).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CCRTHeap Class](../vs140/ccrtheap-class.md)   
 [CCRTHeap::Allocate](../vs140/ccrtheap--allocate.md)   
 [CCRTHeap::Free](../vs140/ccrtheap--free.md)