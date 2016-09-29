---
title: "OpenMP Environment Variables"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 2178ce2b-ffa1-45ec-a455-64437711d15d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OpenMP Environment Variables
Provides links to environment variables used in the OpenMP API.  
  
 The Visual C++ implementation of the OpenMP standard includes the following environment variables. These environment variables are read at program startup and modifications to their values are ignored at runtime (for example, using [_putenv](../vs140/_putenv--_wputenv.md)).  
  
|Environment variable|Description|  
|--------------------------|-----------------|  
|[OMP_DYNAMIC](../vs140/omp_dynamic.md)|Specifies whether the OpenMP run time can adjust the number of threads in a parallel region.|  
|[OMP_NESTED](../vs140/omp_nested.md)|Specifies whether nested parallelism is enabled, unless nested parallelism is enabled or disabled with `omp_set_nested`.|  
|[OMP_NUM_THREADS](../vs140/omp_num_threads.md)|Sets the maximum number of threads in the parallel region, unless overridden by [omp_set_num_threads](../vs140/omp_set_num_threads.md) or [num_threads](../vs140/num_threads.md).|  
|[OMP_SCHEDULE](../vs140/omp_schedule.md)|Modifies the behavior of the [schedule](../vs140/schedule.md) clause when `schedule(runtime)` is specified in a `for` or `parallel for` directive.|  
  
## See Also  
 [Library Reference](../vs140/openmp-library-reference.md)