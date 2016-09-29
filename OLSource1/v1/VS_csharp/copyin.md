---
title: "copyin"
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
  - "copyin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copyin OpenMP clause"
ms.assetid: 369efa88-613c-4cb1-9e11-7b9ee08a4b25
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copyin
Allows threads to access the master thread's value, for a [threadprivate](../VS_csharp/threadprivate.md) variable.  
  
## Syntax  
  
```  
copyin(var)  
```  
  
## Remarks  
 where,  
  
 `var`  
 The `threadprivate` variable that will be initialized with the value of the variable in the master thread, as it exists before the parallel construct.  
  
## Remarks  
 `copyin` applies to the following directives:  
  
-   [parallel](../VS_csharp/parallel.md)  
  
-   [for](../VS_csharp/for--openmp-.md)  
  
-   [sections](../VS_csharp/sections--openmp-.md)  
  
 For more information, see [2.7.2.7 copyin](../VS_csharp/2.7.2.7-copyin.md).  
  
## Example  
 See [threadprivate](../VS_csharp/threadprivate.md) for an example of using `copyin`.  
  
## See Also  
 [Clauses](../VS_csharp/openmp-clauses.md)