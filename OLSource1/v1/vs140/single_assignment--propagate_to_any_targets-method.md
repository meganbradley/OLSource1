---
title: "single_assignment::propagate_to_any_targets Method"
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
  - agents/concurrency::single_assignment::propagate_to_any_targets
dev_langs: 
  - C++
helpviewer_keywords: 
  - propagate_to_any_targets method
ms.assetid: 1dffc7c7-f964-4cf6-aeb8-5d34dbb5a6f9
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# single_assignment::propagate_to_any_targets Method
Places the `message``_PMessage` in this `single_assignment` messaging block and offers it to all of the linked targets.  
  
## Syntax  
  
```  
virtual void propagate_to_any_targets(  
   _Inout_opt_ message<_Type> * _PMessage  
);  
```  
  
#### Parameters  
 `_PMessage`  
 A pointer to a `message` that this `single_assignment` messaging block has taken ownership of.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_assignment Class](../vs140/single_assignment-class.md)