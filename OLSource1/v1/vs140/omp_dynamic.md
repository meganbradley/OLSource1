---
title: "OMP_DYNAMIC"
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
  - "OMP_DYNAMIC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OMP_DYNAMIC OpenMP environment variable"
ms.assetid: e306049d-b644-4b73-8b63-46c835bff98b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OMP_DYNAMIC
Specifies whether the OpenMP run time can adjust the number of threads in a parallel region.  
  
## Syntax  
  
```  
set OMP_DYNAMIC[=TRUE | =FALSE]  
```  
  
## Remarks  
 The `OMP_DYNAMIC` environment variable can be overridden by the [omp_set_dynamic](../vs140/omp_set_dynamic.md) function.  
  
 The default value in the Visual C++ implementation of the OpenMP standard is `OMP_DYNAMIC=FALSE`.  
  
 For more information, see [4.3 OMP_DYNAMIC](../vs140/4.3-omp_dynamic.md).  
  
## Example  
 The following command sets the `OMP_DYNAMIC` environment variable to TRUE:  
  
```  
set OMP_DYNAMIC=TRUE  
```  
  
 The following command displays the current setting of the `OMP_DYNAMIC` environment variable:  
  
```  
set OMP_DYNAMIC  
```  
  
## See Also  
 [Environment Variables](../vs140/openmp-environment-variables.md)