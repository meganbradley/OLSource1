---
title: "ordered_message_processor::initialize_batched_processing Method"
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
  - "agents/concurrency::ordered_message_processor::initialize_batched_processing"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "initialize_batched_processing method"
ms.assetid: f401193b-6c86-46be-ba27-d03747993a63
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ordered_message_processor::initialize_batched_processing Method
Initialize batched message processing  
  
## Syntax  
  
```  
virtual void initialize_batched_processing(  
   _Handler_method const& _Processor,  
   _Propagator_method const& _Propagator  
);  
```  
  
#### Parameters  
 `_Processor`  
 The processor functor invoked during callback.  
  
 `_Propagator`  
 The propagator functor invoked during callback.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ordered_message_processor Class](../vs140/ordered_message_processor-class.md)