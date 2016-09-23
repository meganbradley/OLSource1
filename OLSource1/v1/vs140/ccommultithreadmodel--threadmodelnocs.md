---
title: "CComMultiThreadModel::ThreadModelNoCS"
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
  - ThreadModelNoCS
  - CComMultiThreadModel.ThreadModelNoCS
  - CComMultiThreadModel::ThreadModelNoCS
dev_langs: 
  - C++
helpviewer_keywords: 
  - ThreadModelNoCS typedef
ms.assetid: 71f64205-4edd-4322-95cd-9e1757a06c0e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComMultiThreadModel::ThreadModelNoCS
When using `CComMultiThreadModel`, the `typedef` name `ThreadModelNoCS` references class [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md).  
  
## Syntax  
  
```  
  
typedef CComMultiThreadModelNoCS ThreadModelNoCS;  
  
```  
  
## Remarks  
 `CComMultiThreadModelNoCS` provides thread-safe methods for incrementing and decrementing a variable; however, it does not provide a critical section.  
  
 [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) and `CComMultiThreadModelNoCS` also contain definitions for `ThreadModelNoCS`. The following table shows the relationship between the threading model class and the class referenced by `ThreadModelNoCS`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModel`|`CComMultiThreadModelNoCS`|  
|`CComSingleThreadModel`|`CComSingleThreadModel`|  
|`CComMultiThreadModelNoCS`|`CComMultiThreadModelNoCS`|  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComMultiThreadModel Class](../vs140/ccommultithreadmodel-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)