---
title: "source_block::reserve Method"
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
  - "agents/concurrency::source_block::reserve"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve method"
ms.assetid: 818ac8ee-5e75-41ed-bb54-3d94b80a8c56
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::reserve Method
Reserves a message previously offered by this `source_block` object.  
  
## Syntax  
  
```  
virtual bool reserve(  
   runtime_object_identity _MsgId,  
   _Inout_ ITarget<_Target_type> * _PTarget  
);  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the offered `message` object.  
  
 `_PTarget`  
 A pointer to the target block that is calling the `reserve` method.  
  
## Return Value  
 `true` if the message was successfully reserved, `false` otherwise. Reservations can fail for many reasons, including: the message was already reserved or accepted by another target, the source could deny reservations, and so forth.  
  
## Remarks  
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter `_PTarget` is `NULL`.  
  
 After you call `reserve`, if it succeeds, you must call either `consume` or `release` in order to take or give up possession of the message, respectively.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)