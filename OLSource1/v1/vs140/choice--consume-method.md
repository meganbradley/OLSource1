---
title: "choice::consume Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - agents/concurrency::choice::consume
dev_langs: 
  - C++
helpviewer_keywords: 
  - consume method
ms.assetid: 7b5f82b0-bfe8-4b0b-a1d0-28571d3c771c
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# choice::consume Method
Consumes a message previously offered by this `choice` messaging block and successfully reserved by the target, transferring ownership to the caller.  
  
## Syntax  
  
```  
virtual message<size_t> * consume(  
   runtime_object_identity _MsgId,  
   _Inout_ ITarget<size_t> * _PTarget  
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
 The `consume` method is similar to `accept`, but must always be preceded by a call to `reserve` that returned `true`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)