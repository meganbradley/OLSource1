---
title: "set_task_execution_resources Function"
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
  - "concrt/concurrency::set_task_execution_resources"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_task_execution_resources function"
ms.assetid: 25f7fc36-cd2b-4245-9738-3a33fdef31fa
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_task_execution_resources Function
Restricts the execution resources used by the Concurrency Runtime internal worker threads to the affinity set specified.  
  
 It is valid to call this method only before the Resource Manager has been created, or between two Resource Manager lifetimes. It can be invoked multiple times as long as the Resource Manager does not exist at the time of invocation. After an affinity limit has been set, it remains in effect until the next valid call to the `set_task_execution_resources` method.  
  
 The affinity mask provided need not be a subset of the process affinity mask. The process affinity will be updated if necessary.  
  
## Syntax  
  
```  
void __cdecl set_task_execution_resources(  
   DWORD_PTR _ProcessAffinityMask  
);  
  
void __cdecl set_task_execution_resources(  
   unsigned short _Count,  
   PGROUP_AFFINITY _PGroupAffinity  
);  
```  
  
#### Parameters  
 `_ProcessAffinityMask`  
 The affinity mask that the Concurrency Runtime worker threads are to be restricted to. Use this method on a system with greater than 64 hardware threads only if you want to limit the Concurrency Runtime to a subset of the current processor group. In general, you should use the version of the method that accepts an array of group affinities as a parameter, to restrict affinity on machines with greater than 64 hardware threads.  
  
 `_Count`  
 The number of `GROUP_AFFINITY` entries in the array specified by the parameter `_PGroupAffinity`.  
  
 `_PGroupAffinity`  
 An array of `GROUP_AFFINITY` entries.  
  
## Remarks  
 The method will throw an [invalid_operation](../vs140/invalid_operation-class.md) exception if a Resource Manager is present at the time it is invoked, and an [invalid_argument](../vs140/invalid_argument-class.md) exception if the affinity specified results in an empty set of resources.  
  
 The version of the method that takes an array of group affinities as a parameter should only be used on operating systems with version Windows 7 or higher. Otherwise, an [invalid_operation](../vs140/invalid_operation-class.md) exception is thrown.  
  
 Programatically modifying the process affinity after this method has been invoked will not cause the Resource Manager to re-evaluate the affinity it is restricted to. Therefore, all changes to process affinity should be made before calling this method.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)