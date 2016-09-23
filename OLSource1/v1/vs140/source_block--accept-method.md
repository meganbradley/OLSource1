---
title: "source_block::accept Method"
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
  - agents/concurrency::source_block::accept
dev_langs: 
  - C++
helpviewer_keywords: 
  - accept method
ms.assetid: 8380d558-06f3-4ae7-a8a4-536e7b6fa069
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# source_block::accept Method
Accepts a message that was offered by this `source_block` object, transferring ownership to the caller.  
  
## Syntax  
  
```  
virtual message<_Target_type> * accept(  
   runtime_object_identity _MsgId,  
   _Inout_ ITarget<_Target_type> * _PTarget  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the offered `message` object.  
  
 `_PTarget`  
 A pointer to the target block that is calling the `accept` method.  
  
## Return Value  
 A pointer to the `message` object that the caller now has ownership of.  
  
## Remarks  
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter `_PTarget` is `NULL`.  
  
 The `accept` method is called by a target while a message is being offered by this `ISource` block. The message pointer returned may be different from the one passed into the `propagate` method of the `ITarget` block, if this source decides to make a copy of the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)