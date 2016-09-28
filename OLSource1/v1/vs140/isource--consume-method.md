---
title: "ISource::consume Method"
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
  - "agents/concurrency::ISource::consume"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume method"
ms.assetid: 075b670e-7ca1-4ae6-86ea-78d05b3d82a7
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISource::consume Method
When overridden in a derived class, consumes a message previously offered by this `ISource` block and successfully reserved by the target, transferring ownership to the caller.  
  
## Syntax  
  
```  
virtual message<_Type> * consume(  
   runtime_object_identity _MsgId,  
   _Inout_ ITarget<_Type> * _PTarget  
) = 0;  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the reserved `message` object.  
  
 `_PTarget`  
 A pointer to the target block that is calling the `consume` method.  
  
## Return Value  
 A pointer to the `message` object that the caller now has ownership of.  
  
## Remarks  
 The `consume` method is similar to `accept`, but must always be preceded by a call to `reserve` that returned `true`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISource Class](../vs140/isource-class.md)