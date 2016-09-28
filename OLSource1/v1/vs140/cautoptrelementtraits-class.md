---
title: "CAutoPtrElementTraits Class"
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
  - "ATL.CAutoPtrElementTraits"
  - "CAutoPtrElementTraits"
  - "ATL::CAutoPtrElementTraits<T>"
  - "ATL.CAutoPtrElementTraits<T>"
  - "ATL::CAutoPtrElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoPtrElementTraits class"
ms.assetid: 777c1b14-6ab7-491f-b9a5-be149e71d4a2
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtrElementTraits Class
This class provides methods, static functions, and typedefs useful when creating collections of smart pointers.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   typename  T>  
   class CAutoPtrElementTraits : public CDefaultElementTraits<  
   ATL::CAutoPtr<  T>>  
  
```  
  
#### Parameters  
 `T`  
 The pointer type.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoPtrElementTraits::INARGTYPE](../vs140/cautoptrelementtraits--inargtype.md)|The data type to use for adding elements to the collection class object.|  
|[CAutoPtrElementTraits::OUTARGTYPE](../vs140/cautoptrelementtraits--outargtype.md)|The data type to use for retrieving elements from the collection class object.|  
  
## Remarks  
 This class provides methods, static functions, and typedefs for aiding the creation of collection class objects containing smart pointers. The classes [CAutoPtrArray](../vs140/cautoptrarray-class.md) and [CAutoPtrList](../vs140/cautoptrlist-class.md) derive from `CAutoPtrElementTraits`. If building a collection of smart pointers that requires vector new and delete operators, use [CAutoVectorPtrElementTraits](../vs140/cautovectorptrelementtraits-class.md) instead.  
  
## Inheritance Hierarchy  
 [CDefaultCompareTraits](../vs140/cdefaultcomparetraits-class.md)  
  
 [CDefaultHashTraits](../vs140/cdefaulthashtraits-class.md)  
  
 [CElementTraitsBase](../vs140/celementtraitsbase-class.md)  
  
 [CDefaultElementTraits](../vs140/cdefaultelementtraits-class.md)  
  
 `CAutoPtrElementTraits`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="cautoptrelementtraits__inargtype"></a>  CAutoPtrElementTraits::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
```  
  
typedef CAutoPtr<T> & INARGTYPE;  
  
```  
  
##  <a name="cautoptrelementtraits__outargtype"></a>  CAutoPtrElementTraits::OUTARGTYPE  
 The data type to use for retrieving elements from the collection class object.  
  
```  
  
typedef T *& OUTARGTYPE;  
  
```  
  
## See Also  
 [CDefaultElementTraits Class](../vs140/cdefaultelementtraits-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)