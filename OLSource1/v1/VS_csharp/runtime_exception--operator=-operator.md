---
title: "runtime_exception::operator= Operator"
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
  - "amprt/Concurrency::runtime_exception::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 6d767645-b9c6-41c0-aa24-1bbb10a0952b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# runtime_exception::operator= Operator
Copies the contents of the specified [runtime_exception](../VS_csharp/runtime_exception-class.md) object into this one.  
  
## Syntax  
  
```  
runtime_exception &operator=(  
   const runtime_exception &_Other  
) throw();  
```  
  
#### Parameters  
 `_Other`  
 The `runtime_exception` object to copy.  
  
## Return Value  
 A reference to this `runtime_exception` object.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [runtime_exception Class](../VS_csharp/runtime_exception-class.md)