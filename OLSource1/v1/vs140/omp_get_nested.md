---
title: "omp_get_nested"
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
  - "omp_get_nested"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_get_nested OpenMP function"
ms.assetid: e9784847-516e-40d3-89f7-b8b6898d8667
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_get_nested
Returns a value that indicates if nested parallelism is enabled.  
  
## Syntax  
  
```  
int omp_get_nested( );  
```  
  
## Return Value  
 If nonzero, nested parallelism is enabled.  
  
## Remarks  
 Nested parallelism is specified with [omp_set_nested](../vs140/omp_set_nested.md) and [OMP_NESTED](../vs140/omp_nested.md).  
  
 For more information, see [3.1.10 omp_get_nested Function](../vs140/3.1.10-omp_get_nested-function.md).  
  
## Example  
 See [omp_set_nested](../vs140/omp_set_nested.md) for an example of using `omp_get_nested`.  
  
## See Also  
 [Functions](../vs140/openmp-functions.md)