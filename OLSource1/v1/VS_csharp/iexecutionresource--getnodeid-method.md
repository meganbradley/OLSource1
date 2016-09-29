---
title: "IExecutionResource::GetNodeId Method"
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
  - "concrtrm/concurrency::IExecutionResource::GetNodeId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNodeId method"
ms.assetid: d9243769-f6ab-4e25-8c31-0756a9d30f91
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IExecutionResource::GetNodeId Method
Returns a unique identifier for the processor node that this execution resource belongs to.  
  
## Syntax  
  
```  
virtual unsigned int GetNodeId() const =0;  
```  
  
## Return Value  
 A unique identifier for a processor node.  
  
## Remarks  
 The Concurrency Runtime represents hardware threads on the system in groups of processor nodes. Nodes are usually derived from the hardware topology of the system. For example, all processors on a specific socket or a specific NUMA node may belong to the same processor node. The Resource Manager assigns unique identifiers to these nodes starting with `0` up to and including `nodeCount - 1`, where `nodeCount` represents the total number of processor nodes on the system.  
  
 The count of nodes can be obtained from the function [GetProcessorNodeCount](../VS_csharp/getprocessornodecount-function.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IExecutionResource Structure](../VS_csharp/iexecutionresource-structure.md)