---
title: "CComAllocator::Allocate"
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
  - "ATL.CComAllocator.Allocate"
  - "CComAllocator::Allocate"
  - "CComAllocator.Allocate"
  - "ATL::CComAllocator::Allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Allocate method"
ms.assetid: 9582fcb3-4f37-4558-acc3-ebf1c9847a1a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAllocator::Allocate
Call this static function to allocate memory.  
  
## Syntax  
  
```  
  
      static void* Allocate(  
   size_t nBytes   
) throw( );  
```  
  
#### Parameters  
 `nBytes`  
 The number of bytes to allocate.  
  
## Return Value  
 Returns a void pointer to the allocated space, or NULL if there is insufficient memory available.  
  
## Remarks  
 Allocates memory. See [CoTaskMemAlloc](http://msdn.microsoft.com/library/windows/desktop/ms692727) for more details.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComAllocator Class](../vs140/ccomallocator-class.md)   
 [CComAllocator::Free](../vs140/ccomallocator--free.md)   
 [CComAllocator::Reallocate](../vs140/ccomallocator--reallocate.md)