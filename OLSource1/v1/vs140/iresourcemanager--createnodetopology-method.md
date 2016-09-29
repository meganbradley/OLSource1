---
title: "IResourceManager::CreateNodeTopology Method"
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
  - "concrtrm/concurrency::IResourceManager::CreateNodeTopology"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateNodeTopology method"
ms.assetid: ecf9c4d4-5a11-48e4-9e50-e3ca864c4c8e
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IResourceManager::CreateNodeTopology Method
Present only in debug builds of the runtime, this method is a test hook designed to facilitate testing of the Resource Manager on varying hardware topologies, without requiring actual hardware matching the configuration. With retail builds of the runtime, this method will return without performing any action.  
  
## Syntax  
  
```  
virtual void CreateNodeTopology(  
   unsigned int nodeCount,  
   _In_reads_(nodeCount) unsigned int * pCoreCount,  
   _In_reads_opt_(nodeCount) unsigned int ** pNodeDistance,  
   _In_reads_(nodeCount) unsigned int * pProcessorGroups  
) =0;  
```  
  
#### Parameters  
 `nodeCount`  
 The number of processor nodes being simulated.  
  
 `pCoreCount`  
 An array that specifies the number of cores on each node.  
  
 `pNodeDistance`  
 A matrix specifying the node distance between any two nodes. This parameter can have the value `NULL`.  
  
 `pProcessorGroups`  
 An array that specifies the processor group each node belongs to.  
  
## Remarks  
 [invalid_argument](../vs140/invalid_argument-class.md) is thrown if the parameter `nodeCount` has the value `0` was passed in, or if the parameter `pCoreCount` has the value `NULL`.  
  
 [invalid_operation](../vs140/invalid_operation-class.md) is thrown if this method is called while other schedulers exist in the process.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IResourceManager Structure](../vs140/iresourcemanager-structure.md)