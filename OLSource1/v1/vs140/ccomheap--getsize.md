---
title: "CComHeap::GetSize"
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
  - "CComHeap::GetSize"
  - "CComHeap.GetSize"
  - "ATL.CComHeap.GetSize"
  - "ATL::CComHeap::GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: 8cd88084-97ef-4530-9eec-abc182bfdad6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComHeap::GetSize
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
 Implemented using [IMalloc::GetSize](http://msdn.microsoft.com/library/windows/desktop/ms691226).  
  
## Requirements  
 **Header:** atlcommem.h  
  
## See Also  
 [CComHeap Class](../vs140/ccomheap-class.md)