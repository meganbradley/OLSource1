---
title: "CElementTraits Class"
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
  - "ATL.CElementTraits<T>"
  - "ATL::CElementTraits"
  - "ATL.CElementTraits"
  - "ATL::CElementTraits<T>"
  - "CElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CElementTraits class"
ms.assetid: 496528e5-7f80-4b45-be0c-6f646feb43c5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CElementTraits Class
This class is used by collection classes to provide methods and functions for moving, copying, comparison, and hashing operations.  
  
## Syntax  
  
```  
  
template<  
      typename  T>  
   class CElementTraits : public CDefaultElementTraits<  T  
    >  
  
```  
  
#### Parameters  
 `T`  
 The type of data to be stored in the collection.  
  
## Remarks  
 This class provides default static functions and methods for moving, copying, comparing, and hashing elements stored in a collection class object. `CElementTraits` is specified as the default provider of these operations by the collection classes [CAtlArray](../vs140/catlarray-class.md), [CAtlList](../vs140/catllist-class.md), [CRBMap](../vs140/crbmap-class.md), [CRBMultiMap](../vs140/crbmultimap-class.md), and [CRBTree](../vs140/crbtree-class.md).  
  
 The default implementations will suffice for simple data types, but if the collection classes are used to store more complex objects, the functions and methods must be overridden by user-supplied implementations.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CDefaultElementTraits Class](../vs140/cdefaultelementtraits-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)