---
title: "CLocalHeap::Free"
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
  - ATL::CLocalHeap::Free
  - CLocalHeap::Free
  - ATL.CLocalHeap.Free
  - CLocalHeap.Free
dev_langs: 
  - C++
helpviewer_keywords: 
  - Free method
ms.assetid: d1c4930d-9684-48be-af53-de1d93bd2afa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CLocalHeap::Free
Call this method to free a block of memory allocated by this memory manager.  
  
## Syntax  
  
```  
  
      virtual void Free(  
   void* p   
) throw( );  
```  
  
#### Parameters  
 `p`  
 Pointer to memory previously allocated by this memory manager. NULL is a valid value and does nothing.  
  
## Remarks  
 Implemented using [LocalFree](http://msdn.microsoft.com/library/windows/desktop/aa366730).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CLocalHeap Class](../vs140/clocalheap-class.md)   
 [CLocalHeap::Allocate](../vs140/clocalheap--allocate.md)