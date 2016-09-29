---
title: "join::accept_message Method"
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
  - "agents/concurrency::join::accept_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accept_message method"
ms.assetid: 1ba9ffc4-73bc-4552-8a63-11636cd01f9c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# join::accept_message Method
Accepts a message that was offered by this `join` messaging block, transferring ownership to the caller.  
  
## Syntax  
  
```  
virtual message<_OutputType> * accept_message(  
   runtime_object_identity _MsgId  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the offered `message` object.  
  
## Return Value  
 A pointer to the `message` object that the caller now has ownership of.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [join Class](../vs140/join-class.md)