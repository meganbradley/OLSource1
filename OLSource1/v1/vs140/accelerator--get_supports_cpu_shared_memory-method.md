---
title: "accelerator::get_supports_cpu_shared_memory Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: e9946a1c-b467-4344-94e3-3f7b7705944c
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# accelerator::get_supports_cpu_shared_memory Method
Returns a boolean value indicating whether the accelerator supports memory accessible both by the accelerator and the CPU.  
  
## Syntax  
  
```  
bool get_supports_cpu_shared_memory() const;  
```  
  
## Return Value  
 `true` if the accelerator supports CPU shared memory; otherwise, `false`.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)