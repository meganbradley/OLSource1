---
title: "E. Implementation-Defined Behaviors in OpenMP C-C++"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "E. Implementation-Defined Behaviors in OpenMP C/C++"
dev_langs: 
  - "C++"
ms.assetid: b8d660ca-9bb3-4b6b-87af-45c67d43a731
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# E. Implementation-Defined Behaviors in OpenMP C-C++
This appendix summarizes the behaviors that are described as "implementation-defined" in this API.  Each behavior is cross-referenced back to its description in the main specification.  
  
## Remarks  
 An implementation is required to define and document its behavior in these cases, but this list may be incomplete.  
  
-   **Number of threads:** If a parallel region is encountered while dynamic adjustment of the number of threads is disabled, and the number of threads requested for the parallel region exceeds the number that the run-time system can supply, the behavior of the program is implementation-defined (see page 9).  
  
     In Visual C++, for a non-nested parallel region, 64 threads (the maximum) will be provided.  
  
-   **Number of processors:** The number of physical processors actually hosting the threads at any given time is implementation-defined (see page 10).  
  
     In Visual C++, this number is not constant, and is controlled by the operating system.  
  
-   **Creating teams of threads:** The number of threads in a team that execute a nested parallel region is implementation-defined.(see page 10).  
  
     In Visual C++, this is determined by the operating system.  
  
-   **schedule(runtime):** The decision regarding scheduling is deferred until run time. The schedule type and chunk size can be chosen at run time by setting the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> environment variable. If this environment variable is not set, the resulting schedule is implementation-defined (see page 13).  
  
     In Visual C++, schedule type is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with no chunk size.  
  
-   **Default scheduling:** In the absence of the schedule clause, the default schedule is implementation-defined (see page 13).  
  
     In Visual C++, the default schedule type is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with no chunk size.  
  
-   **ATOMIC:** It is implementation-defined whether an implementation replaces all <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directives with **critical** directives that have the same unique name (see page 20).  
  
     In Visual C++, if data modified by [atomic](../vs140/atomic.md) is not on a natural alignment or if it is 1 or 2 bytes long all atomic operations that satisfy that property will use one critical section. Otherwise, critical sections will not be used.  
  
-   **omp_get_num_threads:** If the number of threads has not been explicitly set by the user, the default is implementation-defined (see page 9, and [Section 3.1.2](../vs140/3.1.2-omp_get_num_threads-function.md) on page 37).  
  
     In Visual C++, the default number of threads is equal to the number of processors.  
  
-   **omp_set_dynamic:** The default for dynamic thread adjustment is implementation-defined (see [Section 3.1.7](../vs140/3.1.7-omp_set_dynamic-function.md) on page 39).  
  
     In Visual C++, the default is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
-   **omp_set_nested:** When nested parallelism is enabled, the number of threads used to execute nested parallel regions is implementation-defined (see [Section 3.1.9](../vs140/3.1.9-omp_set_nested-function.md) on page 40).  
  
     In Visual C++, the number of threads is determined by the operating system.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> environment variable: The default value for this environment variable is implementation-defined (see [Section 4.1](../vs140/4.1-omp_schedule.md) on page 48).  
  
     In Visual C++, schedule type is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with no chunk size.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> environment variable: If no value is specified for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> environment variable, or if the value specified is not a positive integer, or if the value is greater than the maximum number of threads the system can support, the number of threads to use is implementation-defined (see [Section 4.2](../vs140/4.2-omp_num_threads.md) on page 48).  
  
     In Visual C++, if value specified is zero or less, the number of threads is equal to the number of processors.  If value is greater than 64, the number of threads is 64.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> environment variable: The default value is implementation-defined (see [Section 4.3](../vs140/4.3-omp_dynamic.md) on page 49).  
  
     In Visual C++, the default is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.