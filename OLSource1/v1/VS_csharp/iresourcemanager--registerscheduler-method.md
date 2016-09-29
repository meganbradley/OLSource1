---
title: "IResourceManager::RegisterScheduler Method"
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
  - "concrtrm/concurrency::IResourceManager::RegisterScheduler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterScheduler method"
ms.assetid: c7010591-4513-4cb9-96cf-606ac1af77a3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IResourceManager::RegisterScheduler Method
Registers a scheduler with the Resource Manager. Once the scheduler is registered, it should communicate with the Resource Manager using the `ISchedulerProxy` interface that is returned.  
  
## Syntax  
  
```  
virtual ISchedulerProxy *RegisterScheduler(  
   _Inout_ IScheduler * pScheduler,  
   unsigned int version  
) =0;  
```  
  
#### Parameters  
 `pScheduler`  
 An `IScheduler` interface to the scheduler to be registered.  
  
 `version`  
 The version of communication interface the scheduler is using to communicate with the Resource Manager. Using a version allows the Resource Manager to evolve the communication interface while allowing schedulers to obtain access to older features. Schedulers that wish to use Resource Manager features present in Visual Studio 2010 should use the version `CONCRT_RM_VERSION_1`.  
  
## Return Value  
 The `ISchedulerProxy` interface the Resource Manager has associated with your scheduler. Your scheduler should use this interface to communicate with Resource Manager from this point on.  
  
## Remarks  
 Use this method to initiate communication with the Resource Manager. The method associates the `IScheduler` interface for your scheduler with an `ISchedulerProxy` interface and hands it back to you. You can use the returned interface to request execution resources for use by your scheduler, or to subscribe threads with the Resource Manager. The Resource Manager will use policy elements from the scheduler policy returned by the [IScheduler::GetPolicy](../VS_csharp/ischeduler--getpolicy-method.md) method to determine what type of threads the scheduler will need to execute work. If your `SchedulerKind` policy key has the value `UmsThreadDefault` and the value is read back out of the policy as the value `UmsThreadDefault`, the `IScheduler` interface passed to the method must be an `IUMSScheduler` interface.  
  
 The method throws an `invalid_argument` exception if the parameter `pScheduler` has the value `NULL` or if the parameter `version` is not a valid version for the communication interface.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IResourceManager Structure](../VS_csharp/iresourcemanager-structure.md)   
 [IScheduler Structure](../VS_csharp/ischeduler-structure.md)   
 [ISchedulerProxy Structure](../VS_csharp/ischedulerproxy-structure.md)   
 [SchedulerPolicy Class](../VS_csharp/schedulerpolicy-class.md)   
 [PolicyElementKey Enumeration](../VS_csharp/policyelementkey-enumeration.md)