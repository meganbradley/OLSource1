---
title: "MaxExecutionResources Constant"
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
  - "concrt/concurrency::MaxExecutionResources"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MaxExecutionResources constant"
ms.assetid: 7cef895d-f0d6-41bc-b4c3-b4254fa07898
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MaxExecutionResources Constant
Special value for the policy keys `MinConcurrency` and `MaxConcurrency`. Defaults to the number of hardware threads on the machine in the absence of other constraints.  
  
## Syntax  
  
```  
const unsigned int MaxExecutionResources = 0xFFFFFFFF;  
```  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)