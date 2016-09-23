---
title: "IUMSUnblockNotification::GetContext Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concrtrm/concurrency::IUMSUnblockNotification::GetContext
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetContext method
ms.assetid: 187b3e3f-3d50-4a2d-b41c-3733d5cf35a9
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IUMSUnblockNotification::GetContext Method
Returns the `IExecutionContext` interface for the execution context associated with the thread proxy which has unblocked. Once this method returns and the underlying execution context has been rescheduled via a call to the `IThreadProxy::SwitchTo` method, this interface is no longer valid.  
  
## Syntax  
  
```  
virtual IExecutionContext* GetContext() =0;  
```  
  
## Return Value  
 An `IExecutionContext` interface for the execution context to a thread proxy which has unblocked.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IUMSUnblockNotification Structure](../vs140/iumsunblocknotification-structure.md)