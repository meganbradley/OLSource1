---
title: "IUMSCompletionList::GetUnblockNotifications Method"
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
  - concrtrm/concurrency::IUMSCompletionList::GetUnblockNotifications
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetUnblockNotifications method
ms.assetid: 97897bbc-95e4-48ec-95f0-7a46d3a513b2
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IUMSCompletionList::GetUnblockNotifications Method
Retrieves a chain of `IUMSUnblockNotification` interfaces representing execution contexts whose associated thread proxies have unblocked since the last time this method was invoked.  
  
## Syntax  
  
```  
virtual IUMSUnblockNotification *GetUnblockNotifications() =0;  
```  
  
## Return Value  
 A chain of `IUMSUnblockNotification` interfaces.  
  
## Remarks  
 The returned notifications are invalid once the execution contexts are rescheduled.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IUMSCompletionList Structure](../vs140/iumscompletionlist-structure.md)   
 [IUMSUnblockNotification Structure](../vs140/iumsunblocknotification-structure.md)