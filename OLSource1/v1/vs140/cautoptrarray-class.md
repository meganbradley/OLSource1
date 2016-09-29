---
title: "CAutoPtrArray Class"
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
  - "ATL::CAutoPtrArray<E>"
  - "CAutoPtrArray"
  - "ATL::CAutoPtrArray"
  - "ATL.CAutoPtrArray<E>"
  - "ATL.CAutoPtrArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoPtrArray class"
ms.assetid: 880a70da-8c81-4427-8ac6-49aa8d424244
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtrArray Class
This class provides methods useful when constructing an array of smart pointers.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   typename  E>  
   class CAutoPtrArray : public CAtlArray<  
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
|[CAutoPtrArray::CAutoPtrArray](../vs140/cautoptrarray--cautoptrarray.md)|The constructor.|  
  
## Remarks  
 This class provides a constructor and derives methods from [CAtlArray](../vs140/catlarray-class.md) and [CAutoPtrElementTraits](../vs140/cautoptrelementtraits-class.md) to aid the creation of a collection class object storing smart pointers.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 `CAtlArray`  
  
 `CAutoPtrArray`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="cautoptrarray__cautoptrarray"></a>  CAutoPtrArray::CAutoPtrArray  
 The constructor.  
  
```  
  
CAutoPtrArray( ) throw( );  
  
```  
  
### Remarks  
 Initializes the smart pointer array.  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAutoPtrElementTraits Class](../vs140/cautoptrelementtraits-class.md)   
 [CAutoPtrList Class](../vs140/cautoptrlist-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)