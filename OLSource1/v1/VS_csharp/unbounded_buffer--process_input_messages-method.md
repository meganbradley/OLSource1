---
title: "unbounded_buffer::process_input_messages Method"
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
  - "agents/concurrency::unbounded_buffer::process_input_messages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "process_input_messages method"
ms.assetid: 79725aaa-674c-4d78-8a00-759749b9c6a0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unbounded_buffer::process_input_messages Method
Places the `message``_PMessage` in this `unbounded_buffer` messaging block and tries to offer it to all of the linked targets.  
  
## Syntax  
  
```  
virtual void process_input_messages(  
   _Inout_ message<_Type> * _PMessage  
);  
```  
  
#### Parameters  
 `_PMessage`  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [unbounded_buffer Class](../VS_csharp/unbounded_buffer-class.md)