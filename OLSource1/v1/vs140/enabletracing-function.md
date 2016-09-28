---
title: "EnableTracing Function"
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
  - "concrt/concurrency::EnableTracing"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableTracing function"
ms.assetid: 66ece37f-97f1-490f-bd78-d5ff1e43b805
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EnableTracing Function
Enables tracing in the Concurrency Runtime. This function is deprecated because ETW tracing is now on by default.  
  
## Syntax  
  
```  
__declspec(  
   deprecated("Concurrency::EnableTracing is a deprecated function.")  
) _CRTIMP HRESULT __cdecl EnableTracing();  
```  
  
## Return Value  
 If tracing was correctly initiated, `S_OK` is returned; otherwise, `E_NOT_STARTED` is returned.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)