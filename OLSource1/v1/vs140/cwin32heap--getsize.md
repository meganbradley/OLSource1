---
title: "CWin32Heap::GetSize"
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
  - "ATL::CWin32Heap::GetSize"
  - "CWin32Heap::GetSize"
  - "ATL.CWin32Heap.GetSize"
  - "CWin32Heap.GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: d3569dfe-9ece-4021-825a-1c1327aab8f7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWin32Heap::GetSize
Returns the size of a memory block allocated from the heap object.  
  
## Syntax  
  
```  
  
      virtual size_t GetSize(  
   void* p   
) throw( );  
```  
  
#### Parameters  
 `p`  
 Pointer to the memory block whose size the method will obtain. This is a pointer returned by [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md) or [CWin32Heap::Reallocate](../vs140/cwin32heap--reallocate.md).  
  
## Return Value  
 Returns the size, in bytes, of the allocated memory block.  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CWin32Heap Class](../vs140/cwin32heap-class.md)   
 [HeapSize](http://msdn.microsoft.com/library/windows/desktop/aa366706)