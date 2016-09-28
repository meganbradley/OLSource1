---
title: "Contents"
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
ms.assetid: b7858099-7d7f-4cd9-9fa0-fba4832f2dd2
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Contents
[1. Introduction](../vs140/1.-introduction.md)  
  
 [1.1 Scope](../vs140/1.1-scope.md)  
  
 [1.2 Definition of Terms](../vs140/1.2-definition-of-terms.md)  
  
 [1.3 Execution Model](../vs140/1.3-execution-model.md)  
  
 [1.4 Compliance](../vs140/1.4-compliance.md)  
  
 [1.5 Normative References](../vs140/1.5-normative-references.md)  
  
 [1.6 Organization](../vs140/1.6-organization.md)  
  
 [2. Directives](../vs140/2.-directives.md)  
  
 [2.1 Directive Format](../vs140/2.1-directive-format.md)  
  
 [2.2 Conditional Compilation](../vs140/2.2-conditional-compilation.md)  
  
 [2.3 parallel Construct](../vs140/2.3-parallel-construct.md)  
  
 [2.4 Work-sharing Constructs](../vs140/2.4-work-sharing-constructs.md)  
  
 [2.4.1 for Construct](../vs140/2.4.1-for-construct.md)  
  
 [2.4.2 sections Construct](../vs140/2.4.2-sections-construct.md)  
  
 [2.4.3 single Construct](../vs140/2.4.3-single-construct.md)  
  
 [2.5 Combined Parallel Work-sharing Constructs](../vs140/2.5-combined-parallel-work-sharing-constructs.md)  
  
 [2.5.1 parallel for Construct](../vs140/2.5.1-parallel-for-construct.md)  
  
 [2.5.2 parallel sections Construct](../vs140/2.5.2-parallel-sections-construct.md)  
  
 [2.6 Master and Synchronization Directives](../vs140/2.6-master-and-synchronization-directives.md)  
  
 [2.6.1 master Construct](../vs140/2.6.1-master-construct.md)  
  
 [2.6.2 critical Construct](../vs140/2.6.2-critical-construct.md)  
  
 [2.6.3 barrier Directive](../vs140/2.6.3-barrier-directive.md)  
  
 [2.6.4 atomic Construct](../vs140/2.6.4-atomic-construct.md)  
  
 [2.6.5 flush Directive](../vs140/2.6.5-flush-directive.md)  
  
 [2.6.6 ordered Construct](../vs140/2.6.6-ordered-construct.md)  
  
 [2.7 Data Environment](../vs140/2.7-data-environment.md)  
  
 [2.7.1 threadprivate Directive](../vs140/2.7.1-threadprivate-directive.md)  
  
 [2.7.2 Data-Sharing Attribute Clauses](../vs140/2.7.2-data-sharing-attribute-clauses.md)  
  
 [2.7.2.1 private](../vs140/2.7.2.1-private.md)  
  
 [2.7.2.2 firstprivate](../vs140/2.7.2.2-firstprivate.md)  
  
 [2.7.2.3 lastprivate](../vs140/2.7.2.3-lastprivate.md)  
  
 [2.7.2.4 shared](../vs140/2.7.2.4-shared.md)  
  
 [2.7.2.5 default](../vs140/2.7.2.5-default.md)  
  
 [2.7.2.6 reduction](../vs140/2.7.2.6-reduction.md)  
  
 [2.7.2.7 copyin](../vs140/2.7.2.7-copyin.md)  
  
 [2.7.2.8 copyprivate](../vs140/2.7.2.8-copyprivate.md)  
  
 [2.8 Directive Binding](../vs140/2.8-directive-binding.md)  
  
 [2.9 Directive Nesting](../vs140/2.9-directive-nesting.md)  
  
 [3. Run-time Library Functions](../vs140/3.-run-time-library-functions.md)  
  
 [3.1 Execution Environment Functions](../vs140/3.1-execution-environment-functions.md)  
  
 [3.1.1 omp_set_num_threads Function](../vs140/3.1.1-omp_set_num_threads-function.md)  
  
 [3.1.2 omp_get_num_threads Function](../vs140/3.1.2-omp_get_num_threads-function.md)  
  
 [3.1.3 omp_get_max_threads Function](../vs140/3.1.3-omp_get_max_threads-function.md)  
  
 [3.1.4 omp_get_thread_num Function](../vs140/3.1.4-omp_get_thread_num-function.md)  
  
 [3.1.5 omp_get_num_procs Function](../vs140/3.1.5-omp_get_num_procs-function.md)  
  
 [3.1.6 omp_in_parallel Function](../vs140/3.1.6-omp_in_parallel-function.md)  
  
 [3.1.7 omp_set_dynamic Function](../vs140/3.1.7-omp_set_dynamic-function.md)  
  
 [3.1.8 omp_get_dynamic Function](../vs140/3.1.8-omp_get_dynamic-function.md)  
  
 [3.1.9 omp_set_nested Function](../vs140/3.1.9-omp_set_nested-function.md)  
  
 [3.1.10 omp_get_nested Function](../vs140/3.1.10-omp_get_nested-function.md)  
  
 [3.2 Lock Functions](../vs140/3.2-lock-functions.md)  
  
 [3.2.1 omp_init_lock and omp_init_nest_lock Functions](../vs140/3.2.1-omp_init_lock-and-omp_init_nest_lock-functions.md)  
  
 [3.2.2 omp_destroy_lock and omp_destroy_nest_lock Functions](../vs140/3.2.2-omp_destroy_lock-and-omp_destroy_nest_lock-functions.md)  
  
 [3.2.3 omp_set_lock and omp_set_nest_lock Functions](../vs140/3.2.3-omp_set_lock-and-omp_set_nest_lock-functions.md)  
  
 [3.2.4 omp_unset_lock and omp_unset_nest_lock Functions](../vs140/3.2.4-omp_unset_lock-and-omp_unset_nest_lock-functions.md)  
  
 [3.2.5 omp_test_lock and omp_test_nest_lock Functions](../vs140/3.2.5-omp_test_lock-and-omp_test_nest_lock-functions.md)  
  
 [3.3 Timing Routines](../vs140/3.3-timing-routines.md)  
  
 [3.3.1 omp_get_wtime Function](../vs140/3.3.1-omp_get_wtime-function.md)  
  
 [3.3.2 omp_get_wtick Function](../vs140/3.3.2-omp_get_wtick-function.md)  
  
 [4. Environment Variables](../vs140/4.-environment-variables.md)  
  
 [4.1 OMP_SCHEDULE](../vs140/4.1-omp_schedule.md)  
  
 [4.2 OMP_NUM_THREADS](../vs140/4.2-omp_num_threads.md)  
  
 [4.3 OMP_DYNAMIC](../vs140/4.3-omp_dynamic.md)  
  
 [4.4 OMP_NESTED](../vs140/4.4-omp_nested.md)  
  
 [A. Examples](../vs140/a.-examples.md)  
  
 [A.1 Executing a Simple Loop in Parallel](../vs140/a.1---executing-a-simple-loop-in-parallel.md)  
  
 [A.2 Specifying Conditional Compilation](../vs140/a.2---specifying-conditional-compilation.md)  
  
 [A.3 Using Parallel Regions](../vs140/a.3---using-parallel-regions.md)  
  
 [A.4 Using the nowait Clause](../vs140/a.4---using-the-nowait-clause.md)  
  
 [A.5 Using the critical Directive](../vs140/a.5---using-the-critical-directive.md)  
  
 [A.6 Using the lastprivate Clause](../vs140/a.6---using-the-lastprivate-clause.md)  
  
 [A.7 Using the reduction Clause](../vs140/a.7---using-the-reduction-clause.md)  
  
 [A.8 Specifying Parallel Sections](../vs140/a.8---specifying-parallel-sections.md)  
  
 [A.9 Using single Directives](../vs140/a.9---using-single-directives.md)  
  
 [A.10 Specifying Sequential Ordering](../vs140/a.10---specifying-sequential-ordering.md)  
  
 [A.11 Specifying a Fixed Number of Threads](../vs140/a.11---specifying-a-fixed-number-of-threads.md)  
  
 [A.12 Using the atomic Directive](../vs140/a.12---using-the-atomic-directive.md)  
  
 [A.13 Using the flush Directive with a List](../vs140/a.13---using-the-flush-directive-with-a-list.md)  
  
 [A.14 Using the flush Directive without a List](../vs140/a.14---using-the-flush-directive-without-a-list.md)  
  
 [A.15 Determining the Number of Threads Used](../vs140/a.15---determining-the-number-of-threads-used.md)  
  
 [A.16 Using Locks](../vs140/a.16---using-locks.md)  
  
 [A.17 Using Nestable Locks](../vs140/a.17---using-nestable-locks.md)  
  
 [A.18 Nested for Directives](../vs140/a.18---nested-for-directives.md)  
  
 [A.19 Examples Showing Incorrect Nesting of Work-sharing Directives](../vs140/a.19---examples-showing-incorrect-nesting-of-work-sharing-directives.md)  
  
 [A.20 Binding of barrier Directives](../vs140/a.20---binding-of-barrier-directives.md)  
  
 [A.21 Scoping Variables with the private Clause](../vs140/a.21---scoping-variables-with-the-private-clause.md)  
  
 [A.22 Using the default(none) Clause](../vs140/a.22---using-the-default-none--clause.md)  
  
 [A.23 Examples of the ordered Directive](../vs140/a.23---examples-of-the-ordered-directive.md)  
  
 [A.24 Example of the private Clause](../vs140/a.24---example-of-the-private-clause.md)  
  
 [A.25 Examples of the copyprivate Data Attribute Clause](../vs140/a.25---examples-of-the-copyprivate-data-attribute-clause.md)  
  
 [A.26 Using the threadprivate Directive](../vs140/a.26---using-the-threadprivate-directive.md)  
  
 [A.27 Use of C99 Variable Length Arrays](../vs140/a.27---use-of-c99-variable-length-arrays.md)  
  
 [A.28 Use of num_threads Clause](../vs140/a.28---use-of-num_threads-clause.md)  
  
 [A.29 Use of Work-Sharing Constructs Inside a critical Construct](../vs140/a.29---use-of-work-sharing-constructs-inside-a-critical-construct.md)  
  
 [A.30 Use of Reprivatization](../vs140/a.30---use-of-reprivatization.md)  
  
 [A.31 Thread-Safe Lock Functions](../vs140/a.31---thread-safe-lock-functions.md)  
  
 [B. Stubs for Run-time Library Functions](../vs140/b.-stubs-for-run-time-library-functions.md)  
  
 [C. OpenMP C and C++ Grammar](../vs140/c.-openmp-c-and-c---grammar.md)  
  
 [C.1 Notation](../vs140/c.1-notation.md)  
  
 [C.2 Rules](../vs140/c.2-rules.md)  
  
 [D. Using the schedule Clause](../vs140/d.-using-the-schedule-clause.md)  
  
 [E. Implementation-Defined Behaviors in OpenMP C/C++](../vs140/e.-implementation-defined-behaviors-in-openmp-c-c--.md)  
  
 [F. New Features and Clarifications in Version 2.0](../vs140/f.-new-features-and-clarifications-in-version-2.0.md)  
  
## See Also  
 [C and C++ Application Program Interface](../vs140/openmp-c-and-c---application-program-interface.md)