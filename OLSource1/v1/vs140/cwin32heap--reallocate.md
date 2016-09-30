---
title: "CWin32Heap::Reallocate"
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
  - "Reallocate"
  - "ATL::CWin32Heap::Reallocate"
  - "CWin32Heap.Reallocate"
  - "CWin32Heap::Reallocate"
  - "ATL.CWin32Heap.Reallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reallocate method"
ms.assetid: d1a3bb41-85a6-4ffd-ac1c-79728e9764bf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWin32Heap::Reallocate
Reallocates a block of memory from the heap object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the block of memory to reallocate.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new size in bytes of the allocated block. The block can be made larger or smaller.  
  
## Return Value  
 Returns a pointer to the newly allocated memory block.  
  
## Remarks  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is NULL, it's assumed that the memory block has not yet been allocated and [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md) is called, with an argument of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CWin32Heap Class](../vs140/cwin32heap-class.md)   
 [HeapReAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366704)   
 [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md)   
 [CWin32Heap::Free](../vs140/cwin32heap--free.md)