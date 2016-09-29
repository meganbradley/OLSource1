---
title: "CCRTAllocator::Reallocate"
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
  - "CCRTAllocator::Reallocate"
  - "ATL::CCRTAllocator::Reallocate"
  - "CCRTAllocator.Reallocate"
  - "Reallocate"
  - "ATL.CCRTAllocator.Reallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reallocate method"
ms.assetid: b4f549c5-cf06-45aa-8e84-7ce55fbc80ec
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCRTAllocator::Reallocate
Call this static function to reallocate memory.  
  
## Syntax  
  
```  
  
      static __declspec(allocator) void* Reallocate(  
   void* p,  
   size_t nBytes   
) throw( );  
```  
  
#### Parameters  
 `p`  
 Pointer to the allocated memory.  
  
 `nBytes`  
 The number of bytes to reallocate.  
  
## Return Value  
 Returns a void pointer to the allocated space, or NULL if there is insufficient memory.  
  
## Remarks  
 Resizes the amount of allocated memory. See [realloc](../vs140/realloc.md) for more details.  
  
## Requirements  
 **Header:** atlalloc.h  
  
## See Also  
 [CCRTAllocator Class](../vs140/ccrtallocator-class.md)   
 [CCRTAllocator::Allocate](../vs140/ccrtallocator--allocate.md)   
 [CCRTAllocator::Free](../vs140/ccrtallocator--free.md)