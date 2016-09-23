---
title: "CDefaultHashTraits Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDefaultHashTraits
  - ATL.CDefaultHashTraits<T>
  - ATL::CDefaultHashTraits<T>
  - ATL.CDefaultHashTraits
  - ATL::CDefaultHashTraits
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDefaultHashTraits class
ms.assetid: d8ec4b37-6d58-447b-a0c1-8580c5b1ab85
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDefaultHashTraits Class
This class provides a static function for calculating hash values.  
  
## Syntax  
  
```  
  
template<  
      typename  T>  
   class CDefaultHashTraits  
  
```  
  
#### Parameters  
 `T`  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDefaultHashTraits::Hash](../vs140/cdefaulthashtraits--hash.md)|(Static) Call this function to calculate a hash value for a given element.|  
  
## Remarks  
 This class contains a single static function that returns a hash value for a given element. This class is utilized by the [CDefaultElementTraits Class](../vs140/cdefaultelementtraits-class.md).  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="cdefaulthashtraits__hash"></a>  CDefaultHashTraits::Hash  
 Call this function to calculate a hash value for a given element.  
  
```  
  
static ULONG Hash(  
      const T&  element  
   ) throw( );  
  
```  
  
### Parameters  
 `element`  
 The element.  
  
### Return Value  
 Returns the hash value.  
  
### Remarks  
 The default hashing algorithm is very simple: the return value is the element number. Override this function if a more complicated algorithm is required.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)