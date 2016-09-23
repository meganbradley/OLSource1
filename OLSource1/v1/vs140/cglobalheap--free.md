---
title: "CGlobalHeap::Free"
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
  - CGlobalHeap.Free
  - ATL::CGlobalHeap::Free
  - CGlobalHeap::Free
  - ATL.CGlobalHeap.Free
dev_langs: 
  - C++
helpviewer_keywords: 
  - Free method
ms.assetid: 63d79379-83ca-4f4b-a3a0-e6b8fc11a488
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CGlobalHeap::Free
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
 Implemented using [GlobalFree](http://msdn.microsoft.com/library/windows/desktop/aa366579).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)   
 [CGlobalHeap::Allocate](../vs140/cglobalheap--allocate.md)