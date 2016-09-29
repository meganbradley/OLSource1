---
title: "CComSingleThreadModel::CriticalSection"
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
  - "CComSingleThreadModel::CriticalSection"
  - "CComSingleThreadModel.CriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CriticalSection typedef"
ms.assetid: 80adef91-1ff7-4b9b-8a58-6c343cb7cd56
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSingleThreadModel::CriticalSection
When using `CComSingleThreadModel`, the `typedef` name `CriticalSection` references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
## Syntax  
  
```  
  
typedef CComFakeCriticalSection CriticalSection;  
  
```  
  
## Remarks  
 Because `CComFakeCriticalSection` does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for `CriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `CriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
|`CComMultiThreadModel`|`CComCriticalSection`|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
  
 In addition to `CriticalSection`, you can use the `typedef` name [AutoCriticalSection](../vs140/ccomsinglethreadmodel--autocriticalsection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComSingleThreadModel Class](../vs140/ccomsinglethreadmodel-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [CComSingleThreadModel::ThreadModelNoCS](../vs140/ccomsinglethreadmodel--threadmodelnocs.md)