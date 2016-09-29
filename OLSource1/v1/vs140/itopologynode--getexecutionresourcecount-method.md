---
title: "ITopologyNode::GetExecutionResourceCount Method"
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
  - "concrtrm/concurrency::ITopologyNode::GetExecutionResourceCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExecutionResourceCount method"
ms.assetid: 595684c8-130f-4c27-a132-5fb6c03985e2
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITopologyNode::GetExecutionResourceCount Method
Returns the number of execution resources grouped together under this node.  
  
## Syntax  
  
```  
virtual unsigned int GetExecutionResourceCount() const =0;  
```  
  
## Return Value  
 The number of execution resources grouped together under this node.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITopologyNode Structure](../vs140/itopologynode-structure.md)   
 [ITopologyNode::GetFirstExecutionResource Method](../vs140/itopologynode--getfirstexecutionresource-method.md)