---
title: "CSimpleArrayEqualHelper Class"
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
  - CSimpleArrayEqualHelper
dev_langs: 
  - C++
helpviewer_keywords: 
  - CSimpleArrayEqualHelper class
ms.assetid: a2b55d89-78c9-42ef-842c-5304c6d20ad6
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSimpleArrayEqualHelper Class
This class is a helper for the [CSimpleArray](../vs140/csimplearray-class.md) class.  
  
## Syntax  
  
```  
  
template <class T>  
   class CSimpleArrayEqualHelper  
  
```  
  
#### Parameters  
 `T`  
 A derived class.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleArrayEqualHelper::IsEqual](../vs140/csimplearrayequalhelper--isequal.md)|(Static) Tests two `CSimpleArray` object elements for equality.|  
  
## Remarks  
 This traits class is a supplement to the `CSimpleArray` class. It provides a method for comparing two elements stored in a `CSimpleArray` object. By default, the elements are compared using **operator=()**, but if the array contains complex data types that lack their own equality operator, you will need to override this class.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
##  <a name="csimplearrayequalhelper__isequal"></a>  CSimpleArrayEqualHelper::IsEqual  
 Tests two `CSimpleArray` object elements for equality.  
  
```  
  
static bool IsEqual(  
      const T&  t1,  
      const T&  t2  
   );  
  
```  
  
### Parameters  
 *t1*  
 An object of type T.  
  
 *t2*  
 An object of type T.  
  
### Return Value  
 Returns true if the elements are equal, false otherwise.  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)   
 [CSimpleArrayEqualHelperFalse Class](../vs140/csimplearrayequalhelperfalse-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)