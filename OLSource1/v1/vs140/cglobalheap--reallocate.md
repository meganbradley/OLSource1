---
title: "CGlobalHeap::Reallocate"
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
  - "ATL::CGlobalHeap::Reallocate"
  - "Reallocate"
  - "ATL.CGlobalHeap.Reallocate"
  - "CGlobalHeap.Reallocate"
  - "CGlobalHeap::Reallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reallocate method"
ms.assetid: 1f8508b1-9cae-44c2-9f65-2fb4ada38b2c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGlobalHeap::Reallocate
Call this method to reallocate memory allocated by this memory manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The requested number of bytes in the new memory block.  
  
## Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
## Remarks  
 Call [CGlobalHeap::Free](../vs140/cglobalheap--free.md) to free the memory allocated by this method.  
  
 Implemented using [GlobalReAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366590).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)   
 [CGlobalHeap::Allocate](../vs140/cglobalheap--allocate.md)