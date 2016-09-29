---
title: "timer::pause Method"
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
  - "agents/concurrency::timer::pause"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pause method"
ms.assetid: ad9c3611-173c-441f-ac8f-0a29f65475be
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timer::pause Method
Stops the `timer` messaging block. If it is a repeating `timer` messaging block, it can be restarted with a subsequent `start()` call. For non-repeating timers, this has the same effect as a `stop` call.  
  
## Syntax  
  
```  
void pause();  
```  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [timer Class](../VS_csharp/timer-class.md)