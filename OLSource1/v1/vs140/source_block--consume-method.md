---
title: "source_block::consume Method"
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
  - "agents/concurrency::source_block::consume"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume method"
ms.assetid: 878b910d-b686-427a-8aa4-a292ce8a72fb
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::consume Method
Consumes a message previously offered by this `source_block` object and successfully reserved by the target, transferring ownership to the caller.  
  
## Syntax  
  
```  
virtual message<_Target_type> * consume(  
   runtime_object_identity _MsgId,  
   _Inout_ ITarget<_Target_type> * _PTarget  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the reserved `message` object.  
  
 `_PTarget`  
 A pointer to the target block that is calling the `consume` method.  
  
## Return Value  
 A pointer to the `message` object that the caller now has ownership of.  
  
## Remarks  
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter `_PTarget` is `NULL`.  
  
 The method throws a [bad_target](../vs140/bad_target-class.md) exception if the parameter `_PTarget` does not represent the target that called `reserve`.  
  
 The `consume` method is similar to `accept`, but must always be preceded by a call to `reserve` that returned `true`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)