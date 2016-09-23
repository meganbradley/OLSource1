---
title: "multitype_join::accept Method"
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
  - agents/concurrency::multitype_join::accept
dev_langs: 
  - C++
helpviewer_keywords: 
  - accept method
ms.assetid: 63e7e8e6-cddb-440a-b94e-afe18cff295a
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multitype_join::accept Method
Accepts a message that was offered by this `multitype_join` block, transferring ownership to the caller.  
  
## Syntax  
  
```  
virtual message<_Destination_type> * accept(  
   runtime_object_identity _MsgId,  
   _Inout_ ITarget<_Destination_type> * _PTarget  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the offered `message` object.  
  
 `_PTarget`  
 A pointer to the target block that is calling the `accept` method.  
  
## Return Value  
 A pointer to the message that the caller now has ownership of.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multitype_join Class](../vs140/multitype_join-class.md)