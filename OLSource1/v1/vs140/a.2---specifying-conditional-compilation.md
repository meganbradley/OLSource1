---
title: "A.2   Specifying Conditional Compilation"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: de4a21b9-f987-4738-9f13-c4795f6f2dff
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# A.2   Specifying Conditional Compilation
The following examples illustrate the use of conditional compilation using the OpenMP macro `_OPENMP` ([Section 2.2](../vs140/2.2-conditional-compilation.md) on page 8). With OpenMP compilation, the `_OPENMP` macro becomes defined.  
  
```  
# ifdef _OPENMP   
    printf_s("Compiled by an OpenMP-compliant implementation.\n");  
# endif  
```  
  
 The defined preprocessor operator allows more than one macro to be tested in a single directive.  
  
```  
# if defined(_OPENMP) && defined(VERBOSE)  
    printf_s("Compiled by an OpenMP-compliant implementation.\n");  
# endif  
```