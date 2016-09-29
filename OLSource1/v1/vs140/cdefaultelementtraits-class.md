---
title: "CDefaultElementTraits Class"
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
  - "ATL::CDefaultElementTraits<T>"
  - "ATL.CDefaultElementTraits"
  - "ATL::CDefaultElementTraits"
  - "ATL.CDefaultElementTraits<T>"
  - "CDefaultElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDefaultElementTraits class"
ms.assetid: ac5ee610-7957-4b7c-92b6-38ff72e4118e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDefaultElementTraits Class
This class provides default methods and functions for a collection class.  
  
## Syntax  
  
```  
  
template<  
      typename  T>  
   class CDefaultElementTraits : public CElementTraitsBase<  T  
    >,  
      public CDefaultHashTraits<  T  
    >,  
      public CDefaultCompareTraits<  T  
    >  
  
```  
  
#### Parameters  
 `T`  
 The type of data to be stored in the collection.  
  
## Remarks  
 This class provides default static functions and methods for moving, copying, comparing, and hashing elements stored in a collection class object. This class derives its functions and methods from [CElementTraitsBase](../vs140/celementtraitsbase-class.md), [CDefaultHashTraits](../vs140/cdefaulthashtraits-class.md), and [CDefaultCompareTraits](../vs140/cdefaultcomparetraits-class.md), and is utilized by [CElementTraits](../vs140/celementtraits-class.md), [CPrimitiveElementTraits](../vs140/cprimitiveelementtraits-class.md), and [CHeapPtrElementTraits](../vs140/cheapptrelementtraits-class.md).  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)