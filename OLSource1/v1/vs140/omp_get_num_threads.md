---
title: "omp_get_num_threads"
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
  - "omp_get_num_threads"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_get_num_threads OpenMP function"
ms.assetid: e7c3cea1-44ac-435d-866e-2b7bc477e807
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_get_num_threads
Returns the number of threads in the parallel region.  
  
## Syntax  
  
```  
int omp_get_num_threads( );  
```  
  
## Remarks  
 For more information, see [3.1.2 omp_get_num_threads Function](../vs140/3.1.2-omp_get_num_threads-function.md).  
  
## Example  
  
```  
// omp_get_num_threads.cpp  
// compile with: /openmp  
#include <stdio.h>  
#include <omp.h>  
  
int main()  
{  
    omp_set_num_threads(4);  
    printf_s("%d\n", omp_get_num_threads( ));  
    #pragma omp parallel  
        #pragma omp master  
        {  
            printf_s("%d\n", omp_get_num_threads( ));  
        }  
  
    printf_s("%d\n", omp_get_num_threads( ));  
  
    #pragma omp parallel num_threads(3)  
        #pragma omp master  
        {  
            printf_s("%d\n", omp_get_num_threads( ));  
        }  
  
    printf_s("%d\n", omp_get_num_threads( ));  
}  
```  
  
 **1**  
**4**  
**1**  
**3**  
**1**   
## See Also  
 [Functions](../vs140/openmp-functions.md)