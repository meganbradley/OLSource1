---
title: "IResourceManager::GetFirstNode Method"
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
  - "concrtrm/concurrency::IResourceManager::GetFirstNode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFirstNode method"
ms.assetid: e5ea2d5c-ae2b-4b21-85f9-5027940948cf
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IResourceManager::GetFirstNode Method
Returns the first node in enumeration order as defined by the Resource Manager.  
  
## Syntax  
  
```  
virtual ITopologyNode* GetFirstNode() const =0;  
```  
  
## Return Value  
 The first node in enumeration order as defined by the Resource Manager.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IResourceManager Structure](../VS_csharp/iresourcemanager-structure.md)   
 [ITopologyNode::GetExecutionResourceCount Method](../VS_csharp/itopologynode--getexecutionresourcecount-method.md)