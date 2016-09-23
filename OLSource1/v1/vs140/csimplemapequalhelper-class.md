---
title: "CSimpleMapEqualHelper Class"
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
  - CSimpleMapEqualHelper
dev_langs: 
  - C++
helpviewer_keywords: 
  - CSimpleMapEqualHelper class
ms.assetid: 9bb2968a-d609-405c-8272-ff3b42df6164
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSimpleMapEqualHelper Class
This class is a helper for the [CSimpleMap](../vs140/csimplemap-class.md) class.  
  
## Syntax  
  
```  
  
template <class TKey,  
      class  TVal>  
   class CSimpleMapEqualHelper  
  
```  
  
#### Parameters  
 `TKey`  
 The key element.  
  
 `TVal`  
 The value element.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleMapEqualHelper::IsEqualKey](../vs140/csimplemapequalhelper--isequalkey.md)|(Static) Tests two keys for equality.|  
|[CSimpleMapEqualHelper::IsEqualValue](../vs140/csimplemapequalhelper--isequalvalue.md)|(Static) Tests two values for equality.|  
  
## Remarks  
 This traits class is a supplement to the `CSimpleMap` class. It provides methods for comparing two `CSimpleMap` object elements (specifically, the key and value components) for equality. By default, the keys and values are compared using `operator==()`, but if the map contains complex data types that lack their own equality operator, this class can be overridden to provide the extra required functionality.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
##  <a name="csimplemapequalhelper__isequalkey"></a>  CSimpleMapEqualHelper::IsEqualKey  
 Tests two keys for equality.  
  
```  
  
static bool IsEqualKey(  
      const TKey&  k1,  
      const TKey&  k2  
   );  
  
```  
  
### Parameters  
 `k1`  
 The first key.  
  
 `k2`  
 The second key.  
  
### Return Value  
 Returns true if the keys are equal, false otherwise.  
  
##  <a name="csimplemapequalhelper__isequalvalue"></a>  CSimpleMapEqualHelper::IsEqualValue  
 Tests two values for equality.  
  
```  
  
static bool IsEqualValue(  
      const TVal&  v1,  
      const TVal&  v2  
   );  
  
```  
  
### Parameters  
 *v1*  
 The first value.  
  
 *v2*  
 The second value.  
  
### Return Value  
 Returns true if the values are equal, false otherwise.  
  
## See Also  
 [CSimpleMapEqualHelperFalse Class](../vs140/csimplemapequalhelperfalse-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)