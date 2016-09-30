---
title: "F. New Features and Clarifications in Version 2.0"
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
ms.assetid: 0d4beb66-f2d5-468c-8cd3-4b00dcbab061
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# F. New Features and Clarifications in Version 2.0
This appendix summarizes the key changes made to the OpenMP C/C++ specification in moving from version 1.0 to version 2.0. The following items are new features added to the specification:  
  
-   Commas are permitted in OpenMP directives ([Section 2.1](../vs140/2.1-directive-format.md) on page 7).  
  
-   Addition of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> clause. This clause allows a user to request a specific number of threads for a parallel construct ([Section 2.3](../vs140/2.3-parallel-construct.md) on page 8).  
  
-   The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive has been extended to accept static block-scope variables ([Section 2.7.1](../vs140/2.7.1-threadprivate-directive.md) on page 23).  
  
-   C99 Variable Length Arrays are complete types, and thus can be specified anywhere complete types are allowed, for instance in the lists of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clauses ([Section 2.7.2](../vs140/2.7.2-data-sharing-attribute-clauses.md) on page 25).  
  
-   A private variable in a parallel region can be marked private again in a nested directive ([Section 2.7.2.1](../vs140/2.7.2.1-private.md) on page 25).  
  
-   The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause has been added. It provides a mechanism to use a private variable to broadcast a value from one member of a team to the other members. It is an alternative to using a shared variable for the value when providing such a shared variable would be difficult (for example, in a recursion requiring a different variable at each level). The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause can only appear on the **single** directive ([Section 2.7.2.8](../vs140/2.7.2.8-copyprivate.md) on page 32).  
  
-   Addition of timing routines <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> similar to the MPI routines. These functions are necessary for performing wall clock timings  ([Section 3.3.1](../vs140/3.3.1-omp_get_wtime-function.md) on page 44 and [Section 3.3.2](../vs140/3.3.2-omp_get_wtick-function.md) on page 45).  
  
-   An appendix with a list of implementation-defined behaviors in OpenMP C/C++ has been added. An implementation is required to define and document its behavior in these cases ([Appendix E](../vs140/e.-implementation-defined-behaviors-in-openmp-c-c--.md) on page 97).  
  
-   The following changes serve to clarify or correct features in the previous OpenMP API specification for C/C++:  
  
    -   Clarified that the behavior of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns nonzero is undefined ([Section 3.1.7](../vs140/3.1.7-omp_set_dynamic-function.md) on page 39, and [Section 3.1.9](../vs140/3.1.9-omp_set_nested-function.md) on page 40).  
  
    -   Clarified directive nesting when nested parallel is used ([Section 2.9](../vs140/2.9-directive-nesting.md) on page 33).  
  
    -   The lock initialization and lock destruction functions can be called in a parallel region ([Section 3.2.1](../vs140/3.2.1-omp_init_lock-and-omp_init_nest_lock-functions.md) on page 42 and [Section 3.2.2](../vs140/3.2.2-omp_destroy_lock-and-omp_destroy_nest_lock-functions.md) on page 42).  
  
    -   New examples have been added ([Appendix A](../vs140/a.-examples.md) on page 51).