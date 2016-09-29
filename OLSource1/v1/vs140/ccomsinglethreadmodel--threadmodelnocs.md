---
title: "CComSingleThreadModel::ThreadModelNoCS"
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
  - "CComSingleThreadModel.ThreadModelNoCS"
  - "ThreadModelNoCS"
  - "CComSingleThreadModel::ThreadModelNoCS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ThreadModelNoCS method"
ms.assetid: ff1209bf-df35-40d0-a213-7a68969d3bdf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSingleThreadModel::ThreadModelNoCS
When using `CComSingleThreadModel`, the `typedef` name `ThreadModelNoCS` simply references `CComSingleThreadModel`.  
  
## Syntax  
  
```  
  
typedef CComSingleThreadModel ThreadModelNoCS;  
  
```  
  
## Remarks  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for `ThreadModelNoCS`. The following table shows the relationship between the threading model class and the class referenced by `ThreadModelNoCS`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComSingleThreadModel`|`CComSingleThreadModel`|  
|`CComMultiThreadModel`|`CComMultiThreadModelNoCS`|  
|`CComMultiThreadModelNoCS`|`CComMultiThreadModelNoCS`|  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComSingleThreadModel Class](../vs140/ccomsinglethreadmodel-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)