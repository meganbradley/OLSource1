---
title: "overwrite_buffer::propagate_to_any_targets Method"
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
  - "agents/concurrency::overwrite_buffer::propagate_to_any_targets"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagate_to_any_targets method"
ms.assetid: a14937fd-500c-4070-9f7a-425d570ebdc2
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# overwrite_buffer::propagate_to_any_targets Method
Places the `message``_PMessage` in this `overwrite_buffer` messaging block and offers it to all of the linked targets.  
  
## Syntax  
  
```  
virtual void propagate_to_any_targets(  
   _Inout_ message<_Type> * _PMessage  
);  
```  
  
#### Parameters  
 `_PMessage`  
 A pointer to a `message` object that this `overwrite_buffer` has taken ownership of.  
  
## Remarks  
 This method overwrites the current message in the `overwrite_buffer` with the newly accepted message `_PMessage`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)