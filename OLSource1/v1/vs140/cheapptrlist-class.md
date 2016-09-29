---
title: "CHeapPtrList Class"
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
  - "ATL::CHeapPtrList"
  - "CHeapPtrList"
  - "ATL.CHeapPtrList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHeapPtrList class"
ms.assetid: cc70e585-362a-4007-81db-c705eb181226
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeapPtrList Class
This class provides methods useful when constructing a list of heap pointers.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   typename  E,  
   class  Allocator   
   = ATL::CCRTAllocator>  
   class CHeapPtrList : public CAtlList<  
   ATL::CHeapPtr<  E  
   ,  Allocator  
   >,  
   CHeapPtrElementTraits<  E  
   ,  Allocator>>  
  
```  
  
#### Parameters  
 `E`  
 The object type to be stored in the collection class.  
  
 `Allocator`  
 The memory allocation class to use. The default is [CCRTAllocator](../vs140/ccrtallocator-class.md).  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtrList::CHeapPtrList](../vs140/cheapptrlist--cheapptrlist.md)|The constructor.|  
  
## Remarks  
 This class provides a constructor and derives methods from [CAtlList](../vs140/catllist-class.md) and [CHeapPtrElementTraits](../vs140/cheapptrelementtraits-class.md) to aid the creation of a collection class object storing heap pointers.  
  
## Inheritance Hierarchy  
 [CAtlList](../vs140/catllist-class.md)  
  
 `CHeapPtrList`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="cheapptrlist__cheapptrlist"></a>  CHeapPtrList::CHeapPtrList  
 The constructor.  
  
```  
  
CHeapPtrList(  
      UINT  nBlockSize  
    = 10   
   ) throw( );  
  
```  
  
### Parameters  
 `nBlockSize`  
 The block size.  
  
### Remarks  
 The block size is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources.  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CHeapPtr Class](../vs140/cheapptr-class.md)   
 [CHeapPtrElementTraits Class](../vs140/cheapptrelementtraits-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)