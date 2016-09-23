---
title: "CComAllocator::Reallocate"
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
  - CComAllocator.Reallocate
  - CComAllocator::Reallocate
  - ATL::CComAllocator::Reallocate
  - Reallocate
  - ATL.CComAllocator.Reallocate
dev_langs: 
  - C++
helpviewer_keywords: 
  - Reallocate method
ms.assetid: 367351e4-8f3a-4e68-b45f-d2f6044beb34
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComAllocator::Reallocate
Call this static function to reallocate memory.  
  
## Syntax  
  
```  
  
      static void* Reallocate(  
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
 Returns a void pointer to the allocated space, or NULL if there is insufficient memory  
  
## Remarks  
 Resizes the amount of allocated memory. See [CoTaskMemRealloc](http://msdn.microsoft.com/library/windows/desktop/ms687280) for more details.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComAllocator Class](../vs140/ccomallocator-class.md)   
 [CComAllocator::Allocate](../vs140/ccomallocator--allocate.md)   
 [CComAllocator::Free](../vs140/ccomallocator--free.md)