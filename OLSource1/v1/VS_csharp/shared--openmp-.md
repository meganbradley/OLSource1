---
title: "shared (OpenMP)"
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
  - "Shared"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared OpenMP clause"
ms.assetid: 7887dc95-67a2-462f-a3a2-8e0632bf5d04
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared (OpenMP)
Specifies that one or more variables should be shared among all threads.  
  
## Syntax  
  
```  
shared(var)  
```  
  
## Remarks  
 where,  
  
 `var`  
 One more more variables to share. If more than one variable is specified, separate variable names with a comma.  
  
## Remarks  
 Another way to share variables among threads is with the [copyprivate](../VS_csharp/copyprivate.md) clause.  
  
 `shared` applies to the following directives:  
  
-   [for](../VS_csharp/for--openmp-.md)  
  
-   [parallel](../VS_csharp/parallel.md)  
  
-   [sections](../VS_csharp/sections--openmp-.md)  
  
 For more information, see [2.7.2.4 shared](../VS_csharp/2.7.2.4-shared.md).  
  
## Example  
 See [private](../VS_csharp/private--openmp-.md) for an example of using `shared`.  
  
## See Also  
 [Clauses](../VS_csharp/openmp-clauses.md)