---
title: "CWin32Heap Class"
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
  - "ATL::CWin32Heap"
  - "ATL.CWin32Heap"
  - "CWin32Heap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWin32Heap class"
ms.assetid: 69176022-ed98-4e3b-96d8-116b0c58ac95
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWin32Heap Class
This class implements [IAtlMemMgr](../vs140/iatlmemmgr-class.md) using the Win32 heap allocation functions.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CWin32Heap : public IAtlMemMgr  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CWin32Heap::CWin32Heap](../vs140/cwin32heap--cwin32heap.md)|The constructor.|  
|[CWin32Heap::~CWin32Heap](../vs140/cwin32heap--~cwin32heap.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md)|Allocates a block of memory from the heap object.|  
|[CWin32Heap::Attach](../vs140/cwin32heap--attach.md)|Attaches the heap object to an existing heap.|  
|[CWin32Heap::Detach](../vs140/cwin32heap--detach.md)|Detaches the heap object from an existing heap.|  
|[CWin32Heap::Free](../vs140/cwin32heap--free.md)|Frees memory previously allocated from the heap.|  
|[CWin32Heap::GetSize](../vs140/cwin32heap--getsize.md)|Returns the size of a memory block allocated from the heap object.|  
|[CWin32Heap::Reallocate](../vs140/cwin32heap--reallocate.md)|Reallocates a block of memory from the heap object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CWin32Heap::m_bOwnHeap](../vs140/cwin32heap--m_bownheap.md)|A flag used to determine current ownership of the heap handle.|  
|[CWin32Heap::m_hHeap](../vs140/cwin32heap--m_hheap.md)|Handle to the heap object.|  
  
## Remarks  
 `CWin32Heap` implements memory allocation methods using the Win32 heap allocation functions, including [HeapAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366597) and [HeapFree](http://msdn.microsoft.com/library/windows/desktop/aa366701). Unlike other Heap classes, `CWin32Heap` requires a valid heap handle to be provided before memory is allocated: the other classes default to using the process heap. The handle can be supplied to the constructor or to the [CWin32Heap::Attach](../vs140/cwin32heap--attach.md) method. See the [CWin32Heap::CWin32Heap](../vs140/cwin32heap--cwin32heap.md) method for more details.  
  
## Example  
 See the example for [IAtlMemMgr](../vs140/iatlmemmgr-class.md).  
  
## Inheritance Hierarchy  
 `IAtlMemMgr`  
  
 `CWin32Heap`  
  
## Requirements  
 **Header:** atlmem.h  
  
##  <a name="cwin32heap__allocate"></a>  CWin32Heap::Allocate  
 Allocates a block of memory from the heap object.  
  
```  
  
virtual __declspec(allocator) void* Allocate(  
      size_t  nBytes  
   ) throw( );  
  
```  
  
### Parameters  
 `nBytes`  
 The requested number of bytes in the new memory block.  
  
### Return Value  
 Returns a pointer to the newly allocated memory block.  
  
### Remarks  
 Call [CWin32Heap::Free](../vs140/cwin32heap--free.md) or [CWin32Heap::Reallocate](../vs140/cwin32heap--reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [HeapAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366597).  
  
##  <a name="cwin32heap__attach"></a>  CWin32Heap::Attach  
 Attaches the heap object to an existing heap.  
  
```  
  
void Attach(  
      HANDLE  hHeap,  
      bool  bTakeOwnership  
   ) throw( );  
  
```  
  
### Parameters  
 `hHeap`  
 An existing heap handle.  
  
 `bTakeOwnership`  
 A flag indicating if the `CWin32Heap` object is to take ownership over the resources of the heap.  
  
### Remarks  
 If `bTakeOwnership` is TRUE, the `CWin32Heap` object is responsible for deleting the heap handle.  
  
##  <a name="cwin32heap__cwin32heap"></a>  CWin32Heap::CWin32Heap  
 The constructor.  
  
```  
  
CWin32Heap( ) throw( );   
   CWin32Heap(  
      HANDLE  hHeap  
   ) throw( );  
   CWin32Heap(  
      DWORD  dwFlags,  
      size_t  nInitialSize,  
      size_t  nMaxSize  
    = 0   
   );  
  
```  
  
### Parameters  
 `hHeap`  
 An existing heap object.  
  
 `dwFlags`  
 Flags used in creating the heap.  
  
 *nInitialSize*  
 The initial size of the heap.  
  
 `nMaxSize`  
 The maximum size of the heap.  
  
### Remarks  
 Before allocating memory, it is necessary to provide the `CWin32Heap` object with a valid heap handle. The simplest way to achieve this is to use the process heap:  
  
 [!code[NVC_ATL_Utilities#92](../vs140/codesnippet/CPP/cwin32heap-class_1.cpp)]  
  
 It is also possible to supply an existing heap handle to the constructor, in which case the new object does not take over ownership of the heap. The original heap handle will still be valid when the `CWin32Heap` object is deleted.  
  
 An existing heap can also be attached to the new object, using [CWin32Heap::Attach](../vs140/cwin32heap--attach.md).  
  
 If a heap is required where operations are all performed from a single thread, the best way is to create the object as follows:  
  
 [!code[NVC_ATL_Utilities#93](../vs140/codesnippet/CPP/cwin32heap-class_2.cpp)]  
  
 The parameter **HEAP_NO_SERIALIZE** specifies that mutual exclusion will not be used when the heap functions allocate and free memory, with an according increase in performance.  
  
 The third parameter defaults to 0, which allows the heap to grow as required. See [HeapCreate](http://msdn.microsoft.com/library/windows/desktop/aa366599\(v=vs.85\).aspx) for an explanation of the memory sizes and flags.  
  
##  <a name="cwin32heap___dtorcwin32heap"></a>  CWin32Heap::~CWin32Heap  
 The destructor.  
  
```  
  
~CWin32Heap( ) throw( );  
  
```  
  
### Remarks  
 Destroys the heap handle if the `CWin32Heap` object has ownership of the heap.  
  
##  <a name="cwin32heap__detach"></a>  CWin32Heap::Detach  
 Detaches the heap object from an existing heap.  
  
```  
  
HANDLE Detach( ) throw( );  
  
```  
  
### Return Value  
 Returns the handle to the heap to which the object was previously attached.  
  
##  <a name="cwin32heap__free"></a>  CWin32Heap::Free  
 Frees memory previously allocated from the heap by [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md) or [CWin32Heap::Reallocate](../vs140/cwin32heap--reallocate.md).  
  
```  
  
virtual void Free(  
      void*  p  
   ) throw( );  
  
```  
  
### Parameters  
 `p`  
 Pointer to the block of memory to free. NULL is a valid value and does nothing.  
  
##  <a name="cwin32heap__getsize"></a>  CWin32Heap::GetSize  
 Returns the size of a memory block allocated from the heap object.  
  
```  
  
virtual size_t GetSize(  
      void*  p  
   ) throw( );  
  
```  
  
### Parameters  
 `p`  
 Pointer to the memory block whose size the method will obtain. This is a pointer returned by [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md) or [CWin32Heap::Reallocate](../vs140/cwin32heap--reallocate.md).  
  
### Return Value  
 Returns the size, in bytes, of the allocated memory block.  
  
##  <a name="cwin32heap__m_bownheap"></a>  CWin32Heap::m_bOwnHeap  
 A flag used to determine current ownership of the heap handle stored in [m_hHeap](../vs140/cwin32heap--m_hheap.md).  
  
```  
  
bool m_bOwnHeap;  
  
```  
  
##  <a name="cwin32heap__m_hheap"></a>  CWin32Heap::m_hHeap  
 Handle to the heap object.  
  
```  
  
HANDLE m_hHeap;  
  
```  
  
### Remarks  
 A variable used to store a handle to the heap object.  
  
##  <a name="cwin32heap__reallocate"></a>  CWin32Heap::Reallocate  
 Reallocates a block of memory from the heap object.  
  
```  
  
virtual __declspec(allocator) void* Reallocate(  
      void*  p,  
      size_t  nBytes  
   ) throw( );  
  
```  
  
### Parameters  
 `p`  
 Pointer to the block of memory to reallocate.  
  
 `nBytes`  
 The new size in bytes of the allocated block. The block can be made larger or smaller.  
  
### Return Value  
 Returns a pointer to the newly allocated memory block.  
  
### Remarks  
 If `p` is NULL, it's assumed that the memory block has not yet been allocated and [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md) is called, with an argument of `nBytes`.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [IAtlMemMgr Class](../vs140/iatlmemmgr-class.md)   
 [CLocalHeap Class](../vs140/clocalheap-class.md)   
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)   
 [CCRTHeap Class](../vs140/ccrtheap-class.md)   
 [CComHeap Class](../vs140/ccomheap-class.md)