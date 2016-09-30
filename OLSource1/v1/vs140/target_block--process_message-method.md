---
title: "target_block::process_message Method"
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
  - "agents/concurrency::target_block::process_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "process_message method"
ms.assetid: 991c4e5b-889e-423f-9644-8fdcd7dcdafc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::process_message Method
When overridden in a derived class, processes a message that was accepted by this `target_block` object.  
  
## Syntax  
  
```  
virtual void process_message(  
   message<_Source_type> *  
);  
```  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [target_block Class](../vs140/target_block-class.md)