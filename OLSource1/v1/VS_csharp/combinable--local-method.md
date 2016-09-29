---
title: "combinable::local Method"
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
  - "ppl/concurrency::combinable::local"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "local method"
ms.assetid: 496c298e-f159-44f3-8c25-ebf8f5b175be
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# combinable::local Method
Returns a reference to the thread-private sub-computation.  
  
## Syntax  
  
```  
_Ty& local();  
  
_Ty& local(  
   bool& _Exists  
);  
```  
  
#### Parameters  
 `_Exists`  
 A reference to a boolean. The boolean value referenced by this argument will be set to `true` if the sub-computation already existed on this thread, and set to `false` if this was the first sub-computation on this thread.  
  
## Return Value  
 A reference to the thread-private sub-computation.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [combinable Class](../VS_csharp/combinable-class.md)   
 [Parallel Containers and Objects](../VS_csharp/parallel-containers-and-objects.md)