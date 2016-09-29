---
title: "source_block::propagate_to_any_targets Method"
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
  - "agents/concurrency::source_block::propagate_to_any_targets"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propagate_to_any_targets method"
ms.assetid: d7e2b8e8-3788-4a44-af96-58a1a16eb1f0
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::propagate_to_any_targets Method
When overridden in a derived class, propagates the given message to any or all of the linked targets. This is the main propagation routine for message blocks.  
  
## Syntax  
  
```  
virtual void propagate_to_any_targets(  
   _Inout_opt_ message<_Target_type> * _PMessage  
);  
```  
  
#### Parameters  
 `_PMessage`  
 A pointer to the message that is to be propagated.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)