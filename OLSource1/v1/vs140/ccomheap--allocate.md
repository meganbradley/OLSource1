---
title: "CComHeap::Allocate"
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
  - "CComHeap.Allocate"
  - "CComHeap::Allocate"
  - "ATL.CComHeap.Allocate"
  - "ATL::CComHeap::Allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Allocate method"
ms.assetid: 70676059-be1c-4915-94a7-3ab39d4f202a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComHeap::Allocate
Call this method to allocate a block of memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The requested number of bytes in the new memory block.  
  
## Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
## Remarks  
 Call [CComHeap::Free](../vs140/ccomheap--free.md) or [CComHeap::Reallocate](../vs140/ccomheap--reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [CoTaskMemAlloc](http://msdn.microsoft.com/library/windows/desktop/ms692727).  
  
## Requirements  
 **Header:** atlcommem.h  
  
## See Also  
 [CComHeap Class](../vs140/ccomheap-class.md)   
 [CComHeap::Free](../vs140/ccomheap--free.md)   
 [CComHeap::Reallocate](../vs140/ccomheap--reallocate.md)