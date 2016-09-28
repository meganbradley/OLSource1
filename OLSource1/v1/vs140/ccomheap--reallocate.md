---
title: "CComHeap::Reallocate"
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
  - "CComHeap::Reallocate"
  - "Reallocate"
  - "ATL.CComHeap.Reallocate"
  - "CComHeap.Reallocate"
  - "ATL::CComHeap::Reallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reallocate method"
ms.assetid: 5b0cff90-3581-41a6-953d-ade36bf2c5a4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComHeap::Reallocate
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
 Call [CComHeap::Free](../vs140/ccomheap--free.md) to free the memory allocated by this method.  
  
 Implemented using [CoTaskMemRealloc](http://msdn.microsoft.com/library/windows/desktop/ms687280).  
  
## Requirements  
 **Header:** atlcommem.h  
  
## See Also  
 [CComHeap Class](../vs140/ccomheap-class.md)   
 [CComHeap::Free](../vs140/ccomheap--free.md)