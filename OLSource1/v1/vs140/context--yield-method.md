---
title: "Context::Yield Method"
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
  - "concrt/concurrency::Context::Yield"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Yield method"
ms.assetid: 5759ad0a-b97a-4f86-8015-cd8d40256383
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context::Yield Method
Yields execution so that another context can execute. If no other context is available to yield to, the scheduler can yield to another operating system thread.  
  
## Syntax  
  
```  
static void __cdecl Yield();  
```  
  
## Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../vs140/context-class.md)   
 [Context::Block Method](../vs140/context--block-method.md)   
 [Context::Unblock Method](../vs140/context--unblock-method.md)