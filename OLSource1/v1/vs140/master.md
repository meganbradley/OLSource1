---
title: "master"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - master
dev_langs: 
  - C++
helpviewer_keywords: 
  - master OpenMP directive
ms.assetid: 559ed974-e02a-486e-a23f-31556429b2c4
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# master
Specifies that only the master threadshould execute a section of the program.  
  
## Syntax  
  
```  
#pragma omp master  
{  
   code_block  
}  
```  
  
## Remarks  
 The **master** directive supports no OpenMP clauses.  
  
 The [single](../vs140/single.md) directive lets you specify that a section of code should be executed on a single thread, not necessarily the master thread.  
  
 For more information, see [2.6.1 master Construct](../vs140/2.6.1-master-construct.md).  
  
## Example  
  
```  
// omp_master.cpp  
// compile with: /openmp   
#include <omp.h>  
#include <stdio.h>  
  
int main( )   
{  
    int a[5], i;  
  
    #pragma omp parallel  
    {  
        // Perform some computation.  
        #pragma omp for  
        for (i = 0; i < 5; i++)  
            a[i] = i * i;  
  
        // Print intermediate results.  
        #pragma omp master  
            for (i = 0; i < 5; i++)  
                printf_s("a[%d] = %d\n", i, a[i]);  
  
        // Wait.  
        #pragma omp barrier  
  
        // Continue with the computation.  
        #pragma omp for  
        for (i = 0; i < 5; i++)  
            a[i] += i;  
    }  
}  
```  
  
 **a[0] = 0**  
**a[1] = 1**  
**a[2] = 4**  
**a[3] = 9**  
**a[4] = 16**   
## See Also  
 [Directives](../vs140/openmp-directives.md)