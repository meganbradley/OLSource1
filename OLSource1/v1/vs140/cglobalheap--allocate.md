---
title: "CGlobalHeap::Allocate"
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
  - "ATL.CGlobalHeap.Allocate"
  - "ATL::CGlobalHeap::Allocate"
  - "CGlobalHeap.Allocate"
  - "CGlobalHeap::Allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Allocate method"
ms.assetid: 99a86dbd-b3a9-435a-a263-44f490060dba
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGlobalHeap::Allocate
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
 Call [CGlobalHeap::Free](../vs140/cglobalheap--free.md) or [CGlobalHeap::Reallocate](../vs140/cglobalheap--reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [GlobalAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366574) with a flag parameter of **GMEM_FIXED**.  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)   
 [CGlobalHeap::Free](../vs140/cglobalheap--free.md)   
 [CGlobalHeap::Reallocate](../vs140/cglobalheap--reallocate.md)