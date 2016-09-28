---
title: "call::process_message Method"
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
  - "agents/concurrency::call::process_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "process_message method"
ms.assetid: b4ef4cb4-52f3-4e88-86dd-5e37e077970e
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# call::process_message Method
Processes a message that was accepted by this `call` messaging block.  
  
## Syntax  
  
```  
virtual void process_message(  
   _Inout_ message<_Type> * _PMessage  
);  
```  
  
#### Parameters  
 `_PMessage`  
 A pointer to the message that is to be handled.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [call Class](../vs140/call-class.md)