---
title: "CComSingleThreadModel::AutoCriticalSection"
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
  - CComSingleThreadModel::AutoCriticalSection
  - AutoCriticalSection
  - CComSingleThreadModel.AutoCriticalSection
dev_langs: 
  - C++
helpviewer_keywords: 
  - AutoCriticalSection typedef
ms.assetid: 4fbddeb1-f1a5-400e-be40-cca9c3c00f6a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComSingleThreadModel::AutoCriticalSection
When using `CComSingleThreadModel`, the `typedef` name `AutoCriticalSection` references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
## Syntax  
  
```  
  
typedef CComFakeCriticalSection AutoCriticalSection;  
  
```  
  
## Remarks  
 Because `CComFakeCriticalSection` does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for `AutoCriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `AutoCriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
|`CComMultiThreadModel`|`CComAutoCriticalSection`|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
  
 In addition to `AutoCriticalSection`, you can use the `typedef` name [CriticalSection](../vs140/ccomsinglethreadmodel--criticalsection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComSingleThreadModel Class](../vs140/ccomsinglethreadmodel-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [CComSingleThreadModel::ThreadModelNoCS](../vs140/ccomsinglethreadmodel--threadmodelnocs.md)