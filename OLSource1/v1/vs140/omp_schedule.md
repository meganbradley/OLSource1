---
title: "OMP_SCHEDULE"
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
  - "OMP_SCHEDULE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OMP_SCHEDULE OpenMP environment variable"
ms.assetid: 2295a801-e584-4d2f-826f-7ca4c88846a6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OMP_SCHEDULE
Modifies the behavior of the [schedule](../vs140/schedule.md) clause when `schedule(runtime)` is specified in a `for` or `parallel for` directive.  
  
## Syntax  
  
```  
set OMP_SCHEDULE[=type[,size]]  
```  
  
## Remarks  
 where,  
  
 `size` (optional)  
 Specifies the size of iterations. `size` must be a positive integer. The default is 1, except when `type` is static. Not valid when `type` is `runtime`.  
  
 `type`  
 The kind of scheduling:  
  
-   `dynamic`  
  
-   `guided`  
  
-   `runtime`  
  
-   `static`  
  
## Remarks  
 The default value in the Visual C++ implementation of the OpenMP standard is `OMP_SCHEDULE=static,0`.  
  
 For more information, see [4.1 OMP_SCHEDULE](../vs140/4.1-omp_schedule.md).  
  
## Example  
 The following command sets the **OMP_SCHEDULE** environment variable:  
  
```  
set OMP_SCHEDULE="guided,2"  
```  
  
 The following command displays the current setting of the **OMP_SCHEDULE** environment variable:  
  
```  
set OMP_SCHEDULE  
```  
  
## See Also  
 [Environment Variables](../vs140/openmp-environment-variables.md)