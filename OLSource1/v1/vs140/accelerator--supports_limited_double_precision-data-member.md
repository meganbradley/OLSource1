---
title: "accelerator::supports_limited_double_precision Data Member"
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
  - "amprt/Concurrency::accelerator::supports_limited_double_precision"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "amprt/Concurrency::accelerator::supports_limited_double_precision"
ms.assetid: 3ffb9199-87c9-4da1-a46c-b93e2dadc578
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::supports_limited_double_precision Data Member
Gets a Boolean value that indicates whether the accelerator has limited support for double precision math. If the accelerator has only limited support, then fused multiply add (FMA), division, reciprocal, and casting between `int` and `double` are not supported.  
  
## Syntax  
  
```  
__declspec(property(get=get_supports_limited_double_precision)) bool supports_limited_double_precision;  
```  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)