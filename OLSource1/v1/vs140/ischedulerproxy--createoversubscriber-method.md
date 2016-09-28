---
title: "ISchedulerProxy::CreateOversubscriber Method"
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
  - "concrtrm/concurrency::ISchedulerProxy::CreateOversubscriber"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateOversubscriber method"
ms.assetid: b6d12599-3967-44c1-87e1-b28f3ad463a8
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISchedulerProxy::CreateOversubscriber Method
Creates a new virtual processor root on the hardware thread associated with an existing execution resource.  
  
## Syntax  
  
```  
virtual IVirtualProcessorRoot * CreateOversubscriber(  
   _Inout_ IExecutionResource * pExecutionResource  
) =0;  
```  
  
#### Parameters  
 `pExecutionResource`  
 An `IExecutionResource` interface that represents the hardware thread you want to oversubscribe.  
  
## Return Value  
 An `IVirtualProcessorRoot` interface.  
  
## Remarks  
 Use this method when your scheduler wants to oversubscribe a particular hardware thread for a limited amount of time. Once you are done with the virtual processor root, you should return it to the resource manager by calling the [Remove](../vs140/iexecutionresource--remove-method.md) method on the `IVirtualProcessorRoot` interface.  
  
 You can even oversubscribe an existing virtual processor root, because the `IVirtualProcessorRoot` interface inherits from the `IExecutionResource` interface.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISchedulerProxy Structure](../vs140/ischedulerproxy-structure.md)