---
title: "source_block::link_target Method"
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
  - "agents/concurrency::source_block::link_target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "link_target method"
ms.assetid: e6d20504-6b38-4af1-8f97-c6e71b520829
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::link_target Method
Links a target block to this `source_block` object.  
  
## Syntax  
  
```  
virtual void link_target(  
   _Inout_ ITarget<_Target_type> * _PTarget  
);  
```  
  
#### Parameters  
 `_PTarget`  
 A pointer to an `ITarget` block to link to this `source_block` object.  
  
## Remarks  
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter `_PTarget` is `NULL`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)