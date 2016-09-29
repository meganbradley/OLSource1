---
title: "CComMultiThreadModelNoCS::AutoCriticalSection"
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
  - "CComMultiThreadModelNoCS.AutoCriticalSection"
  - "CComMultiThreadModelNoCS::AutoCriticalSection"
  - "AutoCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AutoCriticalSection typedef"
ms.assetid: 7e8de1af-a8af-44b9-b5db-49222ebf6197
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModelNoCS::AutoCriticalSection
When using `CComMultiThreadModelNoCS`, the `typedef` name `AutoCriticalSection` references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
## Syntax  
  
```  
  
typedef CComFakeCriticalSection AutoCriticalSection;  
  
```  
  
## Remarks  
 Because `CComFakeCriticalSection` does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) also contain definitions for `AutoCriticalSection`. The following table shows the relationship between the threading model class and the critical section class referenced by `AutoCriticalSection`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModelNoCS`|`CComFakeCriticalSection`|  
|`CComMultiThreadModel`|`CComAutoCriticalSection`|  
|`CComSingleThreadModel`|`CComFakeCriticalSection`|  
  
 In addition to `AutoCriticalSection`, you can use the `typedef` name [CriticalSection](../vs140/ccommultithreadmodelnocs--criticalsection.md). You should not specify `AutoCriticalSection` in global objects or static class members if you want to eliminate the CRT startup code.  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComMultiThreadModelNoCS Class](../vs140/ccommultithreadmodelnocs-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [CComMultiThreadModelNoCS::ThreadModelNoCS](../vs140/ccommultithreadmodelnocs--threadmodelnocs.md)