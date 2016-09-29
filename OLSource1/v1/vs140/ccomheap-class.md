---
title: "CComHeap Class"
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
  - "CComHeap"
  - "ATL.CComHeap"
  - "ATL::CComHeap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComHeap class"
ms.assetid: c74183ce-98ae-46fb-b186-93ea4cf0222b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComHeap Class
This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the COM memory allocation functions.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CComHeap : public IAtlMemMgr  
  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComHeap::Allocate](../vs140/ccomheap--allocate.md)|Call this method to allocate a block of memory.|  
|[CComHeap::Free](../vs140/ccomheap--free.md)|Call this method to free a block of memory allocated by this memory manager.|  
|[CComHeap::GetSize](../vs140/ccomheap--getsize.md)|Call this method to get the allocated size of a memory block allocated by this memory manager.|  
|[CComHeap::Reallocate](../vs140/ccomheap--reallocate.md)|Call this method to reallocate memory allocated by this memory manager.|  
  
## Remarks  
 `CComHeap` implements memory allocation functions using the COM allocation functions, including [CoTaskMemAlloc](http://msdn.microsoft.com/library/windows/desktop/ms692727), [CoTaskMemFree](http://msdn.microsoft.com/library/windows/desktop/ms680722), [IMalloc::GetSize](http://msdn.microsoft.com/library/windows/desktop/ms691226), and [CoTaskMemRealloc](http://msdn.microsoft.com/library/windows/desktop/ms687280). The maximum amount of memory that can be allocated is equal to **INT_MAX** (2147483647) bytes.  
  
## Example  
 See the example for [IAtlMemMgr](../vs140/iatlmemmgr-class.md).  
  
## Inheritance Hierarchy  
 `IAtlMemMgr`  
  
 `CComHeap`  
  
## Requirements  
 **Header:** ATLComMem.h  
  
##  <a name="ccomheap__allocate"></a>  CComHeap::Allocate  
 Call this method to allocate a block of memory.  
  
```  
  
virtual __declspec(allocator) void* Allocate(  
      size_t  nBytes  
   ) throw( );  
  
```  
  
### Parameters  
 `nBytes`  
 The requested number of bytes in the new memory block.  
  
### Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
### Remarks  
 Call [CComHeap::Free](../vs140/ccomheap--free.md) or [CComHeap::Reallocate](../vs140/ccomheap--reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [CoTaskMemAlloc](http://msdn.microsoft.com/library/windows/desktop/ms692727).  
  
##  <a name="ccomheap__free"></a>  CComHeap::Free  
 Call this method to free a block of memory allocated by this memory manager.  
  
```  
  
virtual void Free(  
      void*  p  
   ) throw( );  
  
```  
  
### Parameters  
 `p`  
 Pointer to memory previously allocated by this memory manager. NULL is a valid value and does nothing.  
  
### Remarks  
 Implemented using [CoTaskMemFree](http://msdn.microsoft.com/library/windows/desktop/ms680722).  
  
##  <a name="ccomheap__getsize"></a>  CComHeap::GetSize  
 Call this method to get the allocated size of a memory block allocated by this memory manager.  
  
```  
  
virtual size_t GetSize(  
      void*  p  
   ) throw( );  
  
```  
  
### Parameters  
 `p`  
 Pointer to memory previously allocated by this memory manager.  
  
### Return Value  
 Returns the size of the allocated memory block in bytes.  
  
### Remarks  
 Implemented using [IMalloc::GetSize](http://msdn.microsoft.com/library/windows/desktop/ms691226).  
  
##  <a name="ccomheap__reallocate"></a>  CComHeap::Reallocate  
 Call this method to reallocate memory allocated by this memory manager.  
  
```  
  
virtual __declspec(allocator) void* Reallocate(  
      void*  p,  
      size_t  nBytes  
   ) throw( );  
  
```  
  
### Parameters  
 `p`  
 Pointer to memory previously allocated by this memory manager.  
  
 `nBytes`  
 The requested number of bytes in the new memory block.  
  
### Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
### Remarks  
 Call [CComHeap::Free](../vs140/ccomheap--free.md) to free the memory allocated by this method.  
  
 Implemented using [CoTaskMemRealloc](http://msdn.microsoft.com/library/windows/desktop/ms687280).  
  
## See Also  
 [DynamicConsumer Sample](../vs140/visual-c---samples.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [CWin32Heap Class](../vs140/cwin32heap-class.md)   
 [CLocalHeap Class](../vs140/clocalheap-class.md)   
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)   
 [CCRTHeap Class](../vs140/ccrtheap-class.md)   
 [IAtlMemMgr Class](../vs140/iatlmemmgr-class.md)