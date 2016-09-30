---
title: "DisableTracing Function"
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
  - "concrt/concurrency::DisableTracing"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DisableTracing function"
ms.assetid: deccd704-c8de-4026-81e9-9214dbb5d71e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DisableTracing Function
Disables tracing in the Concurrency Runtime. This function is deprecated because ETW tracing is unregistered by default.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If tracing was correctly disabled, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is returned. If tracing was not previously initiated, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is returned  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)