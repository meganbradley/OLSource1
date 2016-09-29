---
title: "target_block::process_input_messages Method"
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
  - "agents/concurrency::target_block::process_input_messages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "process_input_messages method"
ms.assetid: 49af4a27-6a19-4525-9e12-ae08e0df84c7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# target_block::process_input_messages Method
Processes messages that are received as inputs.  
  
## Syntax  
  
```  
virtual void process_input_messages(  
   _Inout_ message<_Source_type> * _PMessage  
);  
```  
  
#### Parameters  
 `_PMessage`  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [target_block Class](../vs140/target_block-class.md)