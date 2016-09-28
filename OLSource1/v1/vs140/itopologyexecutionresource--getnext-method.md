---
title: "ITopologyExecutionResource::GetNext Method"
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
  - "concrtrm/concurrency::ITopologyExecutionResource::GetNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNext method"
ms.assetid: 303b411f-9a89-46e9-8a71-325d12acd75a
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITopologyExecutionResource::GetNext Method
Returns an interface to the next execution resource in enumeration order.  
  
## Syntax  
  
```  
virtual ITopologyExecutionResource *GetNext() const =0;  
```  
  
## Return Value  
 An interface to the next execution resource in enumeration order. If there are no more nodes in enumeration order of the node to which this execution resource belongs, this method will return the value `NULL`.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ITopologyExecutionResource Structure](../vs140/itopologyexecutionresource-structure.md)   
 [ITopologyNode::GetFirstExecutionResource Method](../vs140/itopologynode--getfirstexecutionresource-method.md)   
 [ITopologyNode Structure](../vs140/itopologynode-structure.md)