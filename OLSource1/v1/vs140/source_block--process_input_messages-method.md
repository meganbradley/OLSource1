---
title: "source_block::process_input_messages Method"
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
  - "agents/concurrency::source_block::process_input_messages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "process_input_messages method"
ms.assetid: 0beae108-386f-469f-989b-f968a4172ee1
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::process_input_messages Method
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
 [source_block Class](../vs140/source_block-class.md)