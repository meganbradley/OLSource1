---
title: "IUMSThreadProxy::EnterCriticalRegion Method"
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
  - "concrtrm/concurrency::IUMSThreadProxy::EnterCriticalRegion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnterCriticalRegion method"
ms.assetid: e2d14c3d-8fd9-40bd-ada2-56201ebb1a2f
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IUMSThreadProxy::EnterCriticalRegion Method
Called in order to enter a critical region. When inside a critical region, the scheduler will not observe asynchronous blocking operations that happen during the region. This means that the scheduler will not be reentered for page faults, thread suspensions, kernel asynchronous procedure calls (APCs), and so forth, for a UMS thread.  
  
## Syntax  
  
```  
virtual int EnterCriticalRegion() =0;  
```  
  
## Return Value  
 The new depth of critical region. Critical regions are reentrant.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IUMSThreadProxy Structure](../vs140/iumsthreadproxy-structure.md)   
 [IUMSThreadProxy::ExitCriticalRegion Method](../vs140/iumsthreadproxy--exitcriticalregion-method.md)