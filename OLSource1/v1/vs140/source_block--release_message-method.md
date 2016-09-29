---
title: "source_block::release_message Method"
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
  - "agents/concurrency::source_block::release_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "release_message method"
ms.assetid: c48db15b-5bc8-4f73-86d4-ade1bc076392
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::release_message Method
When overridden in a derived class, releases a previous message reservation.  
  
## Syntax  
  
```  
virtual void release_message(  
   runtime_object_identity _MsgId  
) = 0;  
```  
  
#### Parameters  
 `_MsgId`  
 The `runtime_object_identity` of the `message` object being released.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)