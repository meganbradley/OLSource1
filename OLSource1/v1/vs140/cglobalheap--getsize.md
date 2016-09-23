---
title: "CGlobalHeap::GetSize"
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
  - CGlobalHeap.GetSize
  - ATL.CGlobalHeap.GetSize
  - ATL::CGlobalHeap::GetSize
  - CGlobalHeap::GetSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSize method
ms.assetid: 82397d3a-05ba-44e4-81c0-8f9e2513f16e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CGlobalHeap::GetSize
Call this method to get the allocated size of a memory block allocated by this memory manager.  
  
## Syntax  
  
```  
  
      virtual size_t GetSize(  
   void* p   
) throw( );  
```  
  
#### Parameters  
 `p`  
 Pointer to memory previously allocated by this memory manager.  
  
## Return Value  
 Returns the size of the allocated memory block in bytes.  
  
## Remarks  
 Implemented using [GlobalSize](http://msdn.microsoft.com/library/windows/desktop/aa366593).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)