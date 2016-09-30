---
title: "omp_get_max_threads"
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
  - "omp_get_max_threads"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_get_max_threads OpenMP function"
ms.assetid: f47c3725-3e40-469f-8bc8-a1e47f264cc3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_get_max_threads
Returns an integer that is equal to or greater than the number of threads that would be available if a parallel region without [num_threads](../vs140/num_threads.md) were defined at that point in the code.  
  
## Syntax  
  
```  
int omp_get_max_threads( )  
```  
  
## Remarks  
 For more information, see [3.1.3 omp_get_max_threads Function](../vs140/3.1.3-omp_get_max_threads-function.md).  
  
## Example  
  
```  
// omp_get_max_threads.cpp  
// compile with: /openmp  
#include <stdio.h>  
#include <omp.h>  
  
int main( )   
{  
    omp_set_num_threads(8);  
    printf_s("%d\n", omp_get_max_threads( ));  
    #pragma omp parallel  
        #pragma omp master  
        {  
            printf_s("%d\n", omp_get_max_threads( ));  
        }  
  
    printf_s("%d\n", omp_get_max_threads( ));  
  
    #pragma omp parallel num_threads(3)  
        #pragma omp master  
        {  
            printf_s("%d\n", omp_get_max_threads( ));  
        }  
  
    printf_s("%d\n", omp_get_max_threads( ));  
}  
```  
  
 **8**  
**8**  
**8**  
**8**  
**8**   
## See Also  
 [Functions](../vs140/openmp-functions.md)