---
title: "multitype_join::unlink_target Method"
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
  - "agents/concurrency::multitype_join::unlink_target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unlink_target method"
ms.assetid: c4823484-4ad0-4984-aeaa-a8de889d1a63
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multitype_join::unlink_target Method
Unlinks a target block from this `multitype_join` messaging block.  
  
## Syntax  
  
```  
virtual void unlink_target(  
   _Inout_ ITarget<_Destination_type> * _PTarget  
);  
```  
  
#### Parameters  
 `_PTarget`  
 A pointer to an `ITarget` block to unlink from this `multitype_join` messaging block.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multitype_join Class](../vs140/multitype_join-class.md)