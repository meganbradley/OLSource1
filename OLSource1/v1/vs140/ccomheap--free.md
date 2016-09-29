---
title: "CComHeap::Free"
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
  - "ATL.CComHeap.Free"
  - "CComHeap::Free"
  - "ATL::CComHeap::Free"
  - "CComHeap.Free"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Free method"
ms.assetid: d59c8a95-6064-48ab-8660-49962bd3f502
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComHeap::Free
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
 Implemented using [CoTaskMemFree](http://msdn.microsoft.com/library/windows/desktop/ms680722).  
  
## Requirements  
 **Header:** atlcommem.h  
  
## See Also  
 [CComHeap Class](../vs140/ccomheap-class.md)   
 [CComHeap::Allocate](../vs140/ccomheap--allocate.md)   
 [CComHeap::Reallocate](../vs140/ccomheap--reallocate.md)