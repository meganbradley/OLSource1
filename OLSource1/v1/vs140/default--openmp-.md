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
 `shared`, which is in effect if the `default` clause is not specified, means that any variable in a parallel region will be treated as if it were specified with the [shared](../vs140/shared--openmp-.md) clause. `none` means that any variables used in a parallel region that are not scoped with the [private](../vs140/private--openmp-.md), [shared](../vs140/shared--openmp-.md), [reduction](../vs140/reduction.md), [firstprivate](../vs140/firstprivate.md), or [lastprivate](../vs140/lastprivate.md) clause will cause a compiler error.  
  
 `default` applies to the following directives:  
  
-   [parallel](../vs140/parallel.md)  
  
-   [for](../vs140/for--openmp-.md)  
  
-   [sections](../vs140/sections--openmp-.md)  
  
 For more information, see [2.7.2.5 default](../vs140/2.7.2.5-default.md).  
  
## Example  
 See [private](../vs140/private--openmp-.md) for an example of using `default`.  
  
## See Also  
 [Clauses](../vs140/openmp-clauses.md)