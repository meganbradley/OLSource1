---
title: "accelerator::get_supports_double_precision Method"
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
  - "amprt/Concurrency::accelerator::get_supports_double_precision"
dev_langs: 
  - "C++"
ms.assetid: 53344011-0b90-4d7a-8c2b-e10d00144c5c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::get_supports_double_precision Method
Returns a Boolean value that indicates whether the accelerator supports double precision math, including fused multiply add (FMA), division, reciprocal, and casting between `int` and `double`.  
  
## Syntax  
  
```  
bool get_supports_double_precision() const;  
```  
  
## Return Value  
 `true` if the accelerator supports double precision math; otherwise, `false`.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)