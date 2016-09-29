---
title: "CAutoPtrList Class"
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
  - "ATL::CAutoPtrList"
  - "CAutoPtrList"
  - "ATL.CAutoPtrList"
  - "ATL::CAutoPtrList<E>"
  - "ATL.CAutoPtrList<E>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoPtrList class"
ms.assetid: 11de4aca-28b0-4ff2-a74a-cb602312ffbd
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtrList Class
This class provides methods useful when constructing a list of smart pointers.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   typename  E>  
   class CAutoPtrList : public CAtlList<  
   ATL::CAutoPtr<  E  
   >,  
   CAutoPtrElementTraits<  E>>  
  
```  
  
#### Parameters  
 `E`  
 The pointer type.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoPtrList::CAutoPtrList](../vs140/cautoptrlist--cautoptrlist.md)|The constructor.|  
  
## Remarks  
 This class provides a constructor and derives methods from [CAtlList](../vs140/catllist-class.md) and [CAutoPtrElementTraits](../vs140/cautoptrelementtraits-class.md) to aid the creation of a list object storing smart pointers. The class [CAutoPtrArray](../vs140/cautoptrarray-class.md) provides a similar function for an array object.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 [CAtlList](../vs140/catllist-class.md)  
  
 `CAutoPtrList`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="cautoptrlist__cautoptrlist"></a>  CAutoPtrList::CAutoPtrList  
 The constructor.  
  
```  
  
CAutoPtrList(  
      UINT  nBlockSize  
    = 10   
   ) throw( );  
  
```  
  
### Parameters  
 `nBlockSize`  
 The block size, with a default of 10.  
  
### Remarks  
 The block size is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources.  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAutoPtrElementTraits Class](../vs140/cautoptrelementtraits-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)