---
title: "CLocalHeap Class"
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
  - "ATL.CLocalHeap"
  - "ATL::CLocalHeap"
  - "CLocalHeap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLocalHeap class"
ms.assetid: 1ffa87a5-5fc8-4f8d-8809-58e87e963bd2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLocalHeap Class
This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the Win32 local heap functions.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CLocalHeap::Allocate](../vs140/clocalheap--allocate.md)|Call this method to allocate a block of memory.|  
|[CLocalHeap::Free](../vs140/clocalheap--free.md)|Call this method to free a block of memory allocated by this memory manager.|  
|[CLocalHeap::GetSize](../vs140/clocalheap--getsize.md)|Call this method to get the allocated size of a memory block allocated by this memory manager.|  
|[CLocalHeap::Reallocate](../vs140/clocalheap--reallocate.md)|Call this method to reallocate memory allocated by this memory manager.|  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> implements memory allocation functions using the Win32 local heap functions.  
  
> [!NOTE]
>  The local heap functions are slower than other memory management functions and do not provide as many features. Therefore, new applications should use the [heap functions](http://msdn.microsoft.com/library/windows/desktop/aa366711). These are available in the [CWin32Heap](../vs140/cwin32heap-class.md) class.  
  
## Example  
 See the example for [IAtlMemMgr](../vs140/iatlmemmgr-class.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlmem.h  
  
##  \<a name="clocalheap__allocate">\</a>  CLocalHeap::Allocate  
 Call this method to allocate a block of memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The requested number of bytes in the new memory block.  
  
### Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
### Remarks  
 Call [CLocalHeap::Free](../vs140/clocalheap--free.md) or [CLocalHeap::Reallocate](../vs140/clocalheap--reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [LocalAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366723) with a flag parameter of **LMEM_FIXED**.  
  
##  \<a name="clocalheap__free">\</a>  CLocalHeap::Free  
 Call this method to free a block of memory allocated by this memory manager.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager. NULL is a valid value and does nothing.  
  
### Remarks  
 Implemented using [LocalFree](http://msdn.microsoft.com/library/windows/desktop/aa366730).  
  
##  \<a name="clocalheap__getsize">\</a>  CLocalHeap::GetSize  
 Call this method to get the allocated size of a memory block allocated by this memory manager.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
### Return Value  
 Returns the size of the allocated memory block in bytes.  
  
### Remarks  
 Implemented using [LocalSize](http://msdn.microsoft.com/library/windows/desktop/aa366745).  
  
##  \<a name="clocalheap__reallocate">\</a>  CLocalHeap::Reallocate  
 Call this method to reallocate memory allocated by this memory manager.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The requested number of bytes in the new memory block.  
  
### Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
### Remarks  
 Call [CLocalHeap::Free](../vs140/clocalheap--free.md) to free the memory allocated by this method.  
  
 Implemented using [LocalReAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366742).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [CComHeap Class](../vs140/ccomheap-class.md)   
 [CWin32Heap Class](../vs140/cwin32heap-class.md)   
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)   
 [CCRTHeap Class](../vs140/ccrtheap-class.md)   
 [IAtlMemMgr Class](../vs140/iatlmemmgr-class.md)