---
title: "CComMultiThreadModelNoCS::ThreadModelNoCS"
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
  - "ThreadModelNoCS"
  - "CComMultiThreadModelNoCS::ThreadModelNoCS"
  - "CComMultiThreadModelNoCS.ThreadModelNoCS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ThreadModelNoCS typedef"
ms.assetid: 5dec6e36-0742-457e-acaa-1a820d751d3b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComMultiThreadModelNoCS::ThreadModelNoCS
When using `CComMultiThreadModelNoCS`, the `typedef` name `ThreadModelNoCS` simply references `CComMultiThreadModelNoCS`.  
  
## Syntax  
  
```  
  
typedef CComMultiThreadModelNoCS ThreadModelNoCS;  
  
```  
  
## Remarks  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) also contain definitions for `ThreadModelNoCS`. The following table shows the relationship between the threading model class and the class referenced by `ThreadModelNoCS`:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|`CComMultiThreadModelNoCS`|`CComMultiThreadModelNoCS`|  
|`CComMultiThreadModel`|`CComMultiThreadModelNoCS`|  
|`CComSingleThreadModel`|`CComSingleThreadModel`|  
  
 Note that the definition of `ThreadModelNoCS` in `CComMultiThreadModelNoCS` provides symmetry with `CComMultiThreadModel` and `CComSingleThreadModel`. For example, suppose the sample code in `CComMultiThreadModel::AutoCriticalSection` declared the following `typedef`:  
  
 [!code[NVC_ATL_COM#37](../vs140/codesnippet/CPP/ccommultithreadmodelnocs--threadmodelnocs_1.h)]  
  
 Regardless of the class specified for `ThreadModel` (such as `CComMultiThreadModelNoCS`), `_ThreadModel` resolves accordingly.  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComMultiThreadModelNoCS Class](../vs140/ccommultithreadmodelnocs-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)