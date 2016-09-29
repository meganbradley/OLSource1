---
title: "CAutoVectorPtrElementTraits Class"
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
  - "ATL::CAutoVectorPtrElementTraits<T>"
  - "ATL.CAutoVectorPtrElementTraits"
  - "ATL.CAutoVectorPtrElementTraits<T>"
  - "ATL::CAutoVectorPtrElementTraits"
  - "CAutoVectorPtrElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoVectorPtrElementTraits class"
ms.assetid: 16b81a56-55fb-46ca-b376-66a1884231a6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoVectorPtrElementTraits Class
This class provides methods, static functions, and typedefs useful when creating collections of smart pointers using vector new and delete operators.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
template<  
   typename  T>  
   class CAutoVectorPtrElementTraits : public CDefaultElementTraits<  
   ATL::CAutoVectorPtr<  T>>  
  
```  
  
#### Parameters  
 `T`  
 The pointer type.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoVectorPtrElementTraits::INARGTYPE](../Topic/CAutoVectorPtrElementTraits::INARGTYPE.md)|The data type to use for adding elements to the collection class object.|  
|[CAutoVectorPtrElementTraits::OUTARGTYPE](../Topic/CAutoVectorPtrElementTraits::OUTARGTYPE.md)|The data type to use for retrieving elements from the collection class object.|  
  
## Remarks  
 This class provides methods, static functions, and typedefs for aiding the creation of collection class objects containing smart pointers. Unlike [CAutoPtrElementTraits](../VS_csharp/cautoptrelementtraits-class.md), this class uses vector new and delete operators.  
  
## Inheritance Hierarchy  
 [CDefaultCompareTraits](../VS_csharp/cdefaultcomparetraits-class.md)  
  
 [CDefaultHashTraits](../VS_csharp/cdefaulthashtraits-class.md)  
  
 [CElementTraitsBase](../VS_csharp/celementtraitsbase-class.md)  
  
 [CDefaultElementTraits](../VS_csharp/cdefaultelementtraits-class.md)  
  
 `CAutoVectorPtrElementTraits`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="cautovectorptrelementtraits__inargtype"></a>  CAutoVectorPtrElementTraits::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
```  
  
typedef CAutoVectorPtr<T> & INARGTYPE;  
  
```  
  
##  <a name="cautovectorptrelementtraits__outargtype"></a>  CAutoVectorPtrElementTraits::OUTARGTYPE  
 The data type to use for retrieving elements from the collection class object.  
  
```  
  
typedef T *& OUTARGTYPE;  
  
```  
  
## See Also  
 [CDefaultElementTraits Class](../VS_csharp/cdefaultelementtraits-class.md)   
 [CAutoVectorPtr Class](../VS_csharp/cautovectorptr-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)