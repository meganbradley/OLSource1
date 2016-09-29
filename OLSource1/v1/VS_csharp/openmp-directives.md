---
title: "OpenMP Directives"
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
ms.assetid: 0562c263-344c-466d-843e-de830d918940
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OpenMP Directives
Provides links to directives used in the OpenMP API.  
  
 Visual C++ supports the following OpenMP directives:  
  
|Directive|Description|  
|---------------|-----------------|  
|[atomic](../VS_csharp/atomic.md)|Specifies that a memory location that will be updated atomically.|  
|[barrier](../VS_csharp/barrier.md)|Synchronizes all threads in a team; all threads pause at the barrier, until all threads execute the barrier.|  
|[critical](../VS_csharp/critical.md)|Specifies that code is only executed on one thread at a time.|  
|[flush](../VS_csharp/flush--openmp-.md)|Specifies that all threads have the same view of memory for all shared objects.|  
|[for](../VS_csharp/for--openmp-.md)|Causes the work done in a for loop inside a parallel region to be divided among threads.|  
|[master](../VS_csharp/master.md)|Specifies that only the master threadshould execute a section of the program.|  
|[ordered](../VS_csharp/ordered--openmp-directives-.md)|Specifies that code under a parallelized for loop should be executed like a sequential loop.|  
|[parallel](../VS_csharp/parallel.md)|Defines a parallel region, which is code that will be executed by multiple threads in parallel.|  
|[sections](../VS_csharp/sections--openmp-.md)|Identifies code sections to be divided among all threads.|  
|[single](../VS_csharp/single.md)|Lets you specify that a section of code should be executed on a single thread, not necessarily the master thread.|  
|[threadprivate](../VS_csharp/threadprivate.md)|Specifies that a variable is private to a thread.|  
  
## See Also  
 [OpenMP](../VS_csharp/openmp-in-visual-c--.md)   
 [Clauses](../VS_csharp/openmp-clauses.md)