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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
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
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> implements memory allocation methods using the Win32 heap allocation functions, including [HeapAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366597) and [HeapFree](http://msdn.microsoft.com/library/windows/desktop/aa366701). Unlike other Heap classes, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> requires a valid heap handle to be provided before memory is allocated: the other classes default to using the process heap. The handle can be supplied to the constructor or to the [CWin32Heap::Attach](../vs140/cwin32heap--attach.md) method. See the [CWin32Heap::CWin32Heap](../vs140/cwin32heap--cwin32heap.md) method for more details.  
  
## Example  
 See the example for [IAtlMemMgr](../vs140/iatlmemmgr-class.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlmem.h  
  
##  \<a name="cwin32heap__allocate">\</a>  CWin32Heap::Allocate  
 Allocates a block of memory from the heap object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The requested number of bytes in the new memory block.  
  
### Return Value  
 Returns a pointer to the newly allocated memory block.  
  
### Remarks  
 Call [CWin32Heap::Free](../vs140/cwin32heap--free.md) or [CWin32Heap::Reallocate](../vs140/cwin32heap--reallocate.md) to free the memory allocated by this method.  
  
 Implemented using [HeapAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366597).  
  
##  \<a name="cwin32heap__attach">\</a>  CWin32Heap::Attach  
 Attaches the heap object to an existing heap.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An existing heap handle.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A flag indicating if the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is to take ownership over the resources of the heap.  
  
### Remarks  
 If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is TRUE, the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object is responsible for deleting the heap handle.  
  
##  \<a name="cwin32heap__cwin32heap">\</a>  CWin32Heap::CWin32Heap  
 The constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An existing heap object.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Flags used in creating the heap.  
  
 *nInitialSize*  
 The initial size of the heap.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The maximum size of the heap.  
  
### Remarks  
 Before allocating memory, it is necessary to provide the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object with a valid heap handle. The simplest way to achieve this is to use the process heap:  
  
 [!code[NVC_ATL_Utilities#92](../vs140/codesnippet/CPP/cwin32heap-class_1.cpp)]  
  
 It is also possible to supply an existing heap handle to the constructor, in which case the new object does not take over ownership of the heap. The original heap handle will still be valid when the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object is deleted.  
  
 An existing heap can also be attached to the new object, using [CWin32Heap::Attach](../vs140/cwin32heap--attach.md).  
  
 If a heap is required where operations are all performed from a single thread, the best way is to create the object as follows:  
  
 [!code[NVC_ATL_Utilities#93](../vs140/codesnippet/CPP/cwin32heap-class_2.cpp)]  
  
 The parameter **HEAP_NO_SERIALIZE** specifies that mutual exclusion will not be used when the heap functions allocate and free memory, with an according increase in performance.  
  
 The third parameter defaults to 0, which allows the heap to grow as required. See [HeapCreate](http://msdn.microsoft.com/library/windows/desktop/aa366599\(v=vs.85\).aspx) for an explanation of the memory sizes and flags.  
  
##  \<a name="cwin32heap___dtorcwin32heap">\</a>  CWin32Heap::~CWin32Heap  
 The destructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Destroys the heap handle if the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object has ownership of the heap.  
  
##  \<a name="cwin32heap__detach">\</a>  CWin32Heap::Detach  
 Detaches the heap object from an existing heap.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns the handle to the heap to which the object was previously attached.  
  
##  \<a name="cwin32heap__free">\</a>  CWin32Heap::Free  
 Frees memory previously allocated from the heap by [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md) or [CWin32Heap::Reallocate](../vs140/cwin32heap--reallocate.md).  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Pointer to the block of memory to free. NULL is a valid value and does nothing.  
  
##  \<a name="cwin32heap__getsize">\</a>  CWin32Heap::GetSize  
 Returns the size of a memory block allocated from the heap object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Pointer to the memory block whose size the method will obtain. This is a pointer returned by [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md) or [CWin32Heap::Reallocate](../vs140/cwin32heap--reallocate.md).  
  
### Return Value  
 Returns the size, in bytes, of the allocated memory block.  
  
##  \<a name="cwin32heap__m_bownheap">\</a>  CWin32Heap::m_bOwnHeap  
 A flag used to determine current ownership of the heap handle stored in [m_hHeap](../vs140/cwin32heap--m_hheap.md).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="cwin32heap__m_hheap">\</a>  CWin32Heap::m_hHeap  
 Handle to the heap object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 A variable used to store a handle to the heap object.  
  
##  \<a name="cwin32heap__reallocate">\</a>  CWin32Heap::Reallocate  
 Reallocates a block of memory from the heap object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Pointer to the block of memory to reallocate.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The new size in bytes of the allocated block. The block can be made larger or smaller.  
  
### Return Value  
 Returns a pointer to the newly allocated memory block.  
  
### Remarks  
 If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is NULL, it's assumed that the memory block has not yet been allocated and [CWin32Heap::Allocate](../vs140/cwin32heap--allocate.md) is called, with an argument of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [IAtlMemMgr Class](../vs140/iatlmemmgr-class.md)   
 [CLocalHeap Class](../vs140/clocalheap-class.md)   
 [CGlobalHeap Class](../vs140/cglobalheap-class.md)   
 [CCRTHeap Class](../vs140/ccrtheap-class.md)   
 [CComHeap Class](../vs140/ccomheap-class.md)