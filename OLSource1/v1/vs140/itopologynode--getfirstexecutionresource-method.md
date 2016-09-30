---
title: "ITopologyNode::GetFirstExecutionResource Method"
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
  - "concrtrm/concurrency::ITopologyNode::GetFirstExecutionResource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFirstExecutionResource method"
ms.assetid: 3cb07fc8-71d4-4180-86e4-27f47af39efd
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITopologyNode::GetFirstExecutionResource Method
Returns the first execution resource grouped under this node in enumeration order.  
  
## Syntax  
  
```  
virtual ITopologyExecutionResource *GetFirstExecutionResource() const =0;  
```  
  
## Return Value  
 The first execution resource grouped under this node in enumeration order.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITopologyNode Structure](../vs140/itopologynode-structure.md)   
 [ITopologyNode::GetExecutionResourceCount Method](../vs140/itopologynode--getexecutionresourcecount-method.md)