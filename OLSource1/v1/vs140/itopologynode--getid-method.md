---
title: "ITopologyNode::GetId Method"
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
  - "concrtrm/concurrency::ITopologyNode::GetId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetId method"
ms.assetid: cd53ec4a-6f32-4e46-8187-a61191f9ef69
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITopologyNode::GetId Method
Returns the Resource Manager's unique identifier for this node.  
  
## Syntax  
  
```  
virtual unsigned int GetId() const =0;  
```  
  
## Return Value  
 The Resource Manager's unique identifier for this node.  
  
## Remarks  
 The Concurrency Runtime represents hardware threads on the system in groups of processor nodes. Nodes are usually derived from the hardware topology of the system. For example, all processors on a specific socket or a specific NUMA node may belong to the same processor node. The Resource Manager assigns unique identifiers to these nodes starting with `0` up to and including `nodeCount - 1`, where `nodeCount` represents the total number of processor nodes on the system.  
  
 The count of nodes can be obtained from the function [GetProcessorNodeCount](../vs140/getprocessornodecount-function.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITopologyNode Structure](../vs140/itopologynode-structure.md)