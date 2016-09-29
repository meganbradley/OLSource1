---
title: "default (OpenMP)"
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
  - "default"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "default OpenMP clause"
  - "defaults, OpenMP clause"
ms.assetid: 96055106-a8f0-40b3-8319-e412b6e07bf8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# default (OpenMP)
Specifies the behavior of unscoped variables in a parallel region.  
  
## Syntax  
  
```  
default(shared | none)  
```  
  
## Remarks  
 `shared`, which is in effect if the `default` clause is not specified, means that any variable in a parallel region will be treated as if it were specified with the [shared](../VS_csharp/shared--openmp-.md) clause. `none` means that any variables used in a parallel region that are not scoped with the [private](../VS_csharp/private--openmp-.md), [shared](../VS_csharp/shared--openmp-.md), [reduction](../VS_csharp/reduction.md), [firstprivate](../VS_csharp/firstprivate.md), or [lastprivate](../VS_csharp/lastprivate.md) clause will cause a compiler error.  
  
 `default` applies to the following directives:  
  
-   [parallel](../VS_csharp/parallel.md)  
  
-   [for](../VS_csharp/for--openmp-.md)  
  
-   [sections](../VS_csharp/sections--openmp-.md)  
  
 For more information, see [2.7.2.5 default](../VS_csharp/2.7.2.5-default.md).  
  
## Example  
 See [private](../VS_csharp/private--openmp-.md) for an example of using `default`.  
  
## See Also  
 [Clauses](../VS_csharp/openmp-clauses.md)