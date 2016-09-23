---
title: "CLocalHeap::GetSize"
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
  - ATL::CLocalHeap::GetSize
  - CLocalHeap.GetSize
  - CLocalHeap::GetSize
  - ATL.CLocalHeap.GetSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSize method
ms.assetid: b504ab68-ae15-4e92-a61d-f9a74c4c29d6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CLocalHeap::GetSize
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
 Implemented using [LocalSize](http://msdn.microsoft.com/library/windows/desktop/aa366745).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CLocalHeap Class](../vs140/clocalheap-class.md)