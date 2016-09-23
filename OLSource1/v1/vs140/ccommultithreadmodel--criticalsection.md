---
title: "CComMultiThreadModel::CriticalSection"
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
  - CComMultiThreadModel::CriticalSection
  - CComMultiThreadModel.CriticalSection
  - CriticalSection
dev_langs: 
  - C++
helpviewer_keywords: 
  - CriticalSection typedef
ms.assetid: ecf6edcb-a1cd-4054-800c-5f2614e9b9f3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComMultiThreadModel::CriticalSection
When using `CComMultiThreadModel`, the `typedef` name `CriticalSection` references class [CComCriticalSection](../vs140/ccomcriticalsection-class.md), which provides methods for obtaining and releasing ownership of a critical section object.  
  
## Syntax  
  
```  
  
typedef CComCriticalSection CriticalSection;  
  
```  
  
## Remarks  
 [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) also contain definitions for `CriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `CriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModel`|`CComCriticalSection`|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
  
 In addition to `CriticalSection`, you can use the `typedef` name [AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComMultiThreadModel Class](../vs140/ccommultithreadmodel-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [CComMultiThreadModel::ThreadModelNoCS](../vs140/ccommultithreadmodel--threadmodelnocs.md)