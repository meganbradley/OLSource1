---
title: "ISource::accept Method"
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
  - "agents/concurrency::ISource::accept"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accept method"
ms.assetid: de3a1339-603d-493b-b38d-ffd3936173f6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISource::accept Method
When overridden in a derived class, accepts a message that was offered by this `ISource` block, transferring ownership to the caller.  
  
## Syntax  
  
```  
virtual message<_Type> * accept(  
   runtime_object_identity _MsgId,  
   _Inout_ ITarget<_Type> * _PTarget  
) = 0;  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the offered `message` object.  
  
 `_PTarget`  
 A pointer to the target block that is calling the `accept` method.  
  
## Return Value  
 A pointer to the message that the caller now has ownership of.  
  
## Remarks  
 The `accept` method is called by a target while a message is being offered by this `ISource` block. The message pointer returned may be different from the one passed into the `propagate` method of the `ITarget` block, if this source decides to make a copy of the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISource Class](../vs140/isource-class.md)