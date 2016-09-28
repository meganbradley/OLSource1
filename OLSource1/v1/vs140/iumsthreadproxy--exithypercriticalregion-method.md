---
title: "IUMSThreadProxy::ExitHyperCriticalRegion Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concrtrm/concurrency::IUMSThreadProxy::ExitHyperCriticalRegion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExitHyperCriticalRegion method"
ms.assetid: 78259765-a74a-498f-84f3-903fd9c585c8
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IUMSThreadProxy::ExitHyperCriticalRegion Method
Called in order to exit a hyper-critical region.  
  
## Syntax  
  
```  
virtual int ExitHyperCriticalRegion() =0;  
```  
  
## Return Value  
 The new depth of hyper-critical region. Hyper-critical regions are reentrant.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IUMSThreadProxy Structure](../vs140/iumsthreadproxy-structure.md)   
 [IUMSThreadProxy::EnterHyperCriticalRegion Method](../vs140/iumsthreadproxy--enterhypercriticalregion-method.md)