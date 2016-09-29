---
title: "CHeapPtrBase Class"
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
  - "ATL.CHeapPtrBase"
  - "ATL::CHeapPtrBase"
  - "CHeapPtrBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHeapPtrBase class"
ms.assetid: 501ac1b2-fb34-4c72-b7e6-a4f1fc8fda21
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeapPtrBase Class
This class forms the basis for several smart heap pointer classes.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template <  
   class  T,  
   class  Allocator  
   = CCRTAllocator   
   > class CHeapPtrBase  
  
```  
  
#### Parameters  
 `T`  
 The object type to be stored on the heap.  
  
 `Allocator`  
 The memory allocation class to use. By default CRT routines are used to allocate and free memory.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtrBase::~CHeapPtrBase](../vs140/cheapptrbase--~cheapptrbase.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtrBase::AllocateBytes](../vs140/cheapptrbase--allocatebytes.md)|Call this method to allocate memory.|  
|[CHeapPtrBase::Attach](../vs140/cheapptrbase--attach.md)|Call this method to take ownership of an existing pointer.|  
|[CHeapPtrBase::Detach](../vs140/cheapptrbase--detach.md)|Call this method to release ownership of a pointer.|  
|[CHeapPtrBase::Free](../vs140/cheapptrbase--free.md)|Call this method to delete an object pointed to by a `CHeapPtrBase`.|  
|[CHeapPtrBase::ReallocateBytes](../vs140/cheapptrbase--reallocatebytes.md)|Call this method to reallocate memory.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtrBase::operator T*](../vs140/cheapptrbase--operator-t-.md)|The cast operator.|  
|[CHeapPtrBase::operator &](../vs140/cheapptrbase--operator--.md)|The & operator.|  
|[CHeapPtrBase::operator ->](../vs140/cheapptrbase--operator---.md)|The pointer-to-member operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md)|The pointer data member variable.|  
  
## Remarks  
 This class forms the basis for several smart heap pointer classes. The derived classes, for example, [CHeapPtr](../vs140/cheapptr-class.md) and [CComHeapPtr](../vs140/ccomheapptr-class.md), add their own constructors and operators. See these classes for implementation examples.  
  
## Requirements  
 **Header:** atlcore.h  
  
##  <a name="cheapptrbase__allocatebytes"></a>  CHeapPtrBase::AllocateBytes  
 Call this method to allocate memory.  
  
```  
  
bool AllocateBytes(  
      size_t  nBytes  
   ) throw( );  
  
```  
  
### Parameters  
 `nBytes`  
 The number of bytes of memory to allocate.  
  
### Return Value  
 Returns true if the memory is successfully allocated, false otherwise.  
  
### Remarks  
 In debug builds, an assertion failure will occur if the [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md) member variable currently points to an existing value; that is, it is not equal to NULL.  
  
##  <a name="cheapptrbase__attach"></a>  CHeapPtrBase::Attach  
 Call this method to take ownership of an existing pointer.  
  
```  
  
void Attach(  
      T*  pData  
   ) throw( );  
  
```  
  
### Parameters  
 `pData`  
 The `CHeapPtrBase` object will take ownership of this pointer.  
  
### Remarks  
 When a `CHeapPtrBase` object takes ownership of a pointer, it will automatically delete the pointer and any allocated data when it goes out of scope.  
  
 In debug builds, an assertion failure will occur if the [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md) member variable currently points to an existing value; that is, it is not equal to NULL.  
  
##  <a name="cheapptrbase___dtorcheapptrbase"></a>  CHeapPtrBase::~CHeapPtrBase  
 The destructor.  
  
```  
  
~CHeapPtrBase( ) throw( );  
  
```  
  
### Remarks  
 Frees all allocated resources.  
  
##  <a name="cheapptrbase__detach"></a>  CHeapPtrBase::Detach  
 Call this method to release ownership of a pointer.  
  
```  
  
T* Detach( ) throw( );  
  
```  
  
### Return Value  
 Returns a copy of the pointer.  
  
### Remarks  
 Releases ownership of a pointer, sets the [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md) member variable to NULL, and returns a copy of the pointer.  
  
##  <a name="cheapptrbase__free"></a>  CHeapPtrBase::Free  
 Call this method to delete an object pointed to by a `CHeapPtrBase`.  
  
```  
  
void Free( ) throw( );  
  
```  
  
### Remarks  
 The object pointed to by the `CHeapPtrBase` is freed, and the [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md) member variable is set to NULL.  
  
##  <a name="cheapptrbase__m_pdata"></a>  CHeapPtrBase::m_pData  
 The pointer data member variable.  
  
```  
  
T* m_pData;  
  
```  
  
### Remarks  
 This member variable holds the pointer information.  
  
##  <a name="cheapptrbase__operator__amp_"></a>  CHeapPtrBase::operator &amp;  
 The & operator.  
  
```  
  
T** operator&( ) throw( );  
  
```  
  
### Return Value  
 Returns the address of the object pointed to by the `CHeapPtrBase` object.  
  
##  <a name="cheapptrbase__operator_-_gt_"></a>  CHeapPtrBase::operator -&gt;  
 The pointer-to-member operator.  
  
```  
  
T* operator ->( ) const throw( );  
  
```  
  
### Return Value  
 Returns the value of the [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md) member variable.  
  
### Remarks  
 Use this operator to call a method in a class pointed to by the `CHeapPtrBase` object. In debug builds, an assertion failure will occur if the `CHeapPtrBase` points to NULL.  
  
##  <a name="cheapptrbase__operator_t_star"></a>  CHeapPtrBase::operator T*  
 The cast operator.  
  
```  
  
operator T*( ) const throw( );  
  
```  
  
### Remarks  
 Returns [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md).  
  
##  <a name="cheapptrbase__reallocatebytes"></a>  CHeapPtrBase::ReallocateBytes  
 Call this method to reallocate memory.  
  
```  
  
bool ReallocateBytes(  
      size_t  nBytes  
   ) throw( );  
  
```  
  
### Parameters  
 `nBytes`  
 The new amount of memory to allocate, in bytes.  
  
### Return Value  
 Returns true if the memory is successfully allocated, false otherwise.  
  
## See Also  
 [CHeapPtr Class](../vs140/cheapptr-class.md)   
 [CComHeapPtr Class](../vs140/ccomheapptr-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)