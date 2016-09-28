---
title: "SwitchingProxyState Enumeration"
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
  - "concrtrm/concurrency::SwitchingProxyState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SwitchingProxyState enumeration"
ms.assetid: fe292c59-1257-499d-9a04-0d95f9a618ab
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SwitchingProxyState Enumeration
Used to denote the state a thread proxy is in, when it is executing a cooperative context switch to a different thread proxy.  
  
## Syntax  
  
```  
enum SwitchingProxyState;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`Blocking`|Indicates that the calling thread is cooperatively blocking and should be exclusively owned by the caller until subsequently running again and performing other action.|  
|`Idle`|Indicates that the calling thread is no longer needed by the scheduler and is being returned to the Resource Manager. The context which was being dispatched is no longer able to be utilized by the Resource Manager.|  
|`Nesting`|Indicates that the calling thread is nesting a child scheduler and is needed by the caller, in order to attach to a different scheduler.|  
  
## Remarks  
 A parameter of type `SwitchingProxyState` is passed in to the method `IThreadProxy::SwitchTo` to instruct the Resource Manager how to treat the thread proxy that is making the call.  
  
 For more information on how this type is used, see [IThreadProxy::SwitchTo](../vs140/ithreadproxy--switchto-method.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)