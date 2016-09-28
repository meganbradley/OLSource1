---
title: "CHeapPtrElementTraits Class"
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
  - "ATL.CHeapPtrElementTraits"
  - "CHeapPtrElementTraits"
  - "ATL::CHeapPtrElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHeapPtrElementTraits class"
ms.assetid: 910e0e06-3c8b-4242-bf00-b57eb74fbc77
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeapPtrElementTraits Class
This class provides methods, static functions, and typedefs useful when creating collections of heap pointers.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   typename  T,  
   class  Allocator  
   = ATL::CCRTAllocator>  
   class CHeapPtrElementTraits : public CDefaultElementTraits<  
   ATL::CHeapPtr<  T  
   ,  Allocator>>  
  
```  
  
#### Parameters  
 `T`  
 The object type to be stored in the collection class.  
  
 `Allocator`  
 The memory allocation class to use. The default is [CCRTAllocator](../vs140/ccrtallocator-class.md).  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtrElementTraits::INARGTYPE](../vs140/cheapptrelementtraits--inargtype.md)|The data type to use for adding elements to the collection class object.|  
|[CHeapPtrElementTraits::OUTARGTYPE](../vs140/cheapptrelementtraits--outargtype.md)|The data type to use for retrieving elements from the collection class object.|  
  
## Remarks  
 This class provides methods, static functions, and typedefs for aiding the creation of collection class objects containing heap pointers. The class `CHeapPtrList` derives from `CHeapPtrElementTraits`.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 [CDefaultCompareTraits](../vs140/cdefaultcomparetraits-class.md)  
  
 [CDefaultHashTraits](../vs140/cdefaulthashtraits-class.md)  
  
 [CElementTraitsBase](../vs140/celementtraitsbase-class.md)  
  
 [CDefaultElementTraits](../vs140/cdefaultelementtraits-class.md)  
  
 `CHeapPtrElementTraits`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="cheapptrelementtraits__inargtype"></a>  CHeapPtrElementTraits::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
```  
  
typedef CHeapPtr<T,  
   Allocator> & INARGTYPE;  
  
```  
  
##  <a name="cheapptrelementtraits__outargtype"></a>  CHeapPtrElementTraits::OUTARGTYPE  
 The data type to use for retrieving elements from the collection class object.  
  
```  
  
typedef T *& OUTARGTYPE;  
  
```  
  
## See Also  
 [CDefaultElementTraits Class](../vs140/cdefaultelementtraits-class.md)   
 [CComHeapPtr Class](../vs140/ccomheapptr-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)