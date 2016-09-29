---
title: "CCRTHeap Class"
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
  - "ATL::CCRTHeap"
  - "ATL.CCRTHeap"
  - "CCRTHeap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCRTHeap class"
ms.assetid: 321bd6c5-1856-4ff7-8590-95044a1209f7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCRTHeap Class
This class implements [IAtlMemMgr](../VS_csharp/iatlmemmgr-class.md) using the CRT heap functions.  
  
## Syntax  
  
```  
  
class CCRTHeap : public IAtlMemMgr  
  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CCRTHeap::Allocate](../Topic/CCRTHeap::Allocate.md)|Call this method to allocate a block of memory.|  
|[CCRTHeap::Free](../Topic/CCRTHeap::Free.md)|Call this method to free a block of memory allocated by this memory manager.|  
|[CCRTHeap::GetSize](../Topic/CCRTHeap::GetSize.md)|Call this method to get the allocated size of a memory block allocated by this memory manager.|  
|[CCRTHeap::Reallocate](../Topic/CCRTHeap::Reallocate.md)|Call this method to reallocate memory allocated by this memory manager.|  
  
## Remarks  
 `CCRTHeap` implements memory allocation functions using the CRT heap functions, including [malloc](../VS_csharp/malloc.md), [free](../VS_csharp/free.md), [realloc](../VS_csharp/realloc.md), and [_msize](../VS_csharp/_msize.md).  
  
## Example  
 See the example for [IAtlMemMgr](../VS_csharp/iatlmemmgr-class.md).  
  
## Inheritance Hierarchy  
 `IAtlMemMgr`  
  
 `CCRTHeap`  
  
## Requirements  
 **Header:** atlmem.h  
  
##  <a name="ccrtheap__allocate"></a>  CCRTHeap::Allocate  
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
 Call [CCRTHeap::Free](../Topic/CCRTHeap::Free.md) or [CCRTHeap::Reallocate](../Topic/CCRTHeap::Reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [malloc](../VS_csharp/malloc.md).  
  
##  <a name="ccrtheap__free"></a>  CCRTHeap::Free  
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
 Implemented using [free](../VS_csharp/free.md).  
  
##  <a name="ccrtheap__getsize"></a>  CCRTHeap::GetSize  
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
 Implemented using [_msize](../VS_csharp/_msize.md).  
  
##  <a name="ccrtheap__reallocate"></a>  CCRTHeap::Reallocate  
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
 Call [CCRTHeap::Free](../Topic/CCRTHeap::Free.md) to free the memory allocated by this method. Implemented using [realloc](../VS_csharp/realloc.md).  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [CComHeap Class](../VS_csharp/ccomheap-class.md)   
 [CWin32Heap Class](../VS_csharp/cwin32heap-class.md)   
 [CLocalHeap Class](../VS_csharp/clocalheap-class.md)   
 [CGlobalHeap Class](../VS_csharp/cglobalheap-class.md)   
 [IAtlMemMgr Class](../VS_csharp/iatlmemmgr-class.md)