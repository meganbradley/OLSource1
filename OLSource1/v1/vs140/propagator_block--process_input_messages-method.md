---
title: "propagator_block::process_input_messages Method"
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
  - agents/concurrency::propagator_block::process_input_messages
dev_langs: 
  - C++
helpviewer_keywords: 
  - process_input_messages method
ms.assetid: 680ad67a-b4bd-4ecd-b881-1ddd8bf36313
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# propagator_block::process_input_messages Method
Process input messages. This is only useful for propagator blocks, which derive from source_block  
  
## Syntax  
  
```  
virtual void process_input_messages(  
   _Inout_ message<_Target_type> * _PMessage  
);  
```  
  
#### Parameters  
 `_PMessage`  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [propagator_block Class](../vs140/propagator_block-class.md)