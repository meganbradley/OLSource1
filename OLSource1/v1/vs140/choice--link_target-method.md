---
title: "choice::link_target Method"
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
  - "agents/concurrency::choice::link_target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "link_target method"
ms.assetid: 66db0468-1468-4a40-b951-45aedde0dbcf
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice::link_target Method
Links a target block to this `choice` messaging block.  
  
## Syntax  
  
```  
virtual void link_target(  
   _Inout_ ITarget<size_t> * _PTarget  
);  
```  
  
#### Parameters  
 `_PTarget`  
 A pointer to an `ITarget` block to link to this `choice` messaging block.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)