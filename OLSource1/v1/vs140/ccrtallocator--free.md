---
title: "CCRTAllocator::Free"
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
  - ATL::CCRTAllocator::Free
  - ATL.CCRTAllocator.Free
  - CCRTAllocator::Free
  - CCRTAllocator.Free
dev_langs: 
  - C++
helpviewer_keywords: 
  - Free method
ms.assetid: f18168bc-5970-4167-8e1b-980c7b2b31ce
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCRTAllocator::Free
Call this static function to free memory.  
  
## Syntax  
  
```  
  
      static void Free(  
   void* p   
) throw( );  
```  
  
#### Parameters  
 `p`  
 Pointer to the allocated memory.  
  
## Remarks  
 Frees the allocated memory. See [free](../vs140/free.md) for more details.  
  
## Requirements  
 **Header:** atlalloc.h  
  
## See Also  
 [CCRTAllocator Class](../vs140/ccrtallocator-class.md)   
 [CCRTAllocator::Allocate](../vs140/ccrtallocator--allocate.md)   
 [CCRTAllocator::Reallocate](../vs140/ccrtallocator--reallocate.md)