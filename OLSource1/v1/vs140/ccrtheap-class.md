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
This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the CRT heap functions.  
  
## Syntax  
  
```  
  
class CCRTHeap : public IAtlMemMgr  
  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CCRTHeap::Allocate](../vs140/ccrtheap--allocate.md)|Call this method to allocate a block of memory.|  
|[CCRTHeap::Free](../vs140/ccrtheap--free.md)|Call this method to free a block of memory allocated by this memory manager.|  
|[CCRTHeap::GetSize](../vs140/ccrtheap--getsize.md)|Call this method to get the allocated size of a memory block allocated by this memory manager.|  
|[CCRTHeap::Reallocate](../vs140/ccrtheap--reallocate.md)|Call this method to reallocate memory allocated by this memory manager.|  
  
## Remarks  
 `CCRTHeap` implements memory allocation functions using the CRT heap functions, including [malloc](../vs140/malloc.md), [free](../vs140/free.md), [realloc](../vs140/realloc.md), and [_msize](../vs140/_msize.md).  
  
## Example  
 See the example for [IAtlMemMgr](../vs140/iatlmemmgr-class.md).  
  
## Inheritance Hierarchy  
 `IAtlMemMgr`  
  
 `CCRTHeap`  
  
## Requirements  
 **Header:** atlmem.h  
  
##  \<a name="ccrtheap__allocate"></a>  CCRTHeap::Allocate  
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
 Call [CCRTHeap::Free](../vs140/ccrtheap--free.md) or [CCRTHeap::Reallocate](../vs140/ccrtheap--reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [malloc](../vs140/malloc.md).  
  
##  \<a name="ccrtheap__free"></a>  CCRTHeap::Free  
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
 Implemented using [free](../vs140/free.md).  
  
##  \<a name="ccrtheap__getsize"></a>  CCRTHeap::GetSize  
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
 Implemented using [_msize](../vs140/_msize.md).  
  
##  \<a name="ccrtheap__reallocate"></a>  CCRTHeap::Reallocate  
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
 Call [CCRTHeap::Free](../vs140/ccrtheap--free.md) to free the memory allocated by this method. Implemented using [realloc](../vs140/realloc.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [CComHeap Class](../vs140/ccomheap-class.md)   
 [CWin32Heap Class](../vs140/cwin32heap-class.md)   
 [CLocalHeap Class](../vs140/clocalheap-class.md)   
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)   
 [IAtlMemMgr Class](../vs140/iatlmemmgr-class.md)