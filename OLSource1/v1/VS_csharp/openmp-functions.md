---
title: "OpenMP Functions"
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
ms.assetid: a55a2e5c-a260-44ee-bbd6-de7e2351b384
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OpenMP Functions
Provides links to functions used in the OpenMP API.  
  
 The Visual C++ implementation of the OpenMP standard includes the following functions.  
  
|Function|Description|  
|--------------|-----------------|  
|[omp_destroy_lock](../VS_csharp/omp_destroy_lock.md)|Uninitializes a lock.|  
|[omp_destroy_nest_lock](../VS_csharp/omp_destroy_nest_lock.md)|Uninitializes a nestable lock.|  
|[omp_get_dynamic](../VS_csharp/omp_get_dynamic.md)|Returns a value that indicates if the number of threads available in subsequent parallel region can be adjusted by the run time.|  
|[omp_get_max_threads](../VS_csharp/omp_get_max_threads.md)|Returns an integer that is equal to or greater than the number of threads that would be available if a parallel region without [num_threads](../VS_csharp/num_threads.md) were defined at that point in the code.|  
|[omp_get_nested](../VS_csharp/omp_get_nested.md)|Returns a value that indicates if nested parallelism is enabled.|  
|[omp_get_num_procs](../VS_csharp/omp_get_num_procs.md)|Returns the number of processors that are available when the function is called.|  
|[omp_get_num_threads](../VS_csharp/omp_get_num_threads.md)|Returns the number of threads in the parallel region.|  
|[omp_get_thread_num](../VS_csharp/omp_get_thread_num.md)|Returns the thread number of the thread executing within its thread team.|  
|[omp_get_wtick](../VS_csharp/omp_get_wtick.md)|Returns the number of seconds between processor clock ticks.|  
|[omp_get_wtime](../VS_csharp/omp_get_wtime.md)|Returns a value in seconds of the time elapsed from some point.|  
|[omp_in_parallel](../VS_csharp/omp_in_parallel.md)|Returns nonzero if called from within a parallel region.|  
|[omp_init_lock](../VS_csharp/omp_init_lock.md)|Initializes a simple lock.|  
|[omp_init_nest_lock](../VS_csharp/omp_init_nest_lock.md)|Initializes a lock.|  
|[omp_set_dynamic](../VS_csharp/omp_set_dynamic.md)|Indicates that the number of threads available in subsequent parallel region can be adjusted by the run time.|  
|[omp_set_lock](../VS_csharp/omp_set_lock.md)|Blocks thread execution until a lock is available.|  
|[omp_set_nest_lock](../VS_csharp/omp_set_nest_lock.md)|Blocks thread execution until a lock is available.|  
|[omp_set_nested](../VS_csharp/omp_set_nested.md)|Enables nested parallelism.|  
|[omp_set_num_threads](../VS_csharp/omp_set_num_threads.md)|Sets the number of threads in subsequent parallel regions, unless overridden by a [num_threads](../VS_csharp/num_threads.md) clause.|  
|[omp_test_lock](../VS_csharp/omp_test_lock.md)|Attempts to set a lock but does not block thread execution.|  
|[omp_test_nest_lock](../VS_csharp/omp_test_nest_lock.md)|Attempts to set a nestable lock but does not block thread execution.|  
|[omp_unset_lock](../VS_csharp/omp_unset_lock.md)|Releases a lock.|  
|[omp_unset_nest_lock](../VS_csharp/omp_unset_nest_lock.md)|Releases a nestable lock.|  
  
## See Also  
 [Library Reference](../VS_csharp/openmp-library-reference.md)