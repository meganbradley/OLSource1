---
title: "omp_get_wtime"
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
  - "omp_get_wtime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_get_wtime OpenMP function"
ms.assetid: c8dee105-ec1b-42e5-a6e3-edeedcf9854c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_get_wtime
Returns a value in seconds of the time elapsed from some point.  
  
## Syntax  
  
```  
double omp_get_wtime( );  
```  
  
## Return Value  
 Returns a value in seconds of the time elapsed from some arbitrary, but consistent point.  
  
## Remarks  
 That point will remain consistent during program execution, making subsequent comparisons possible.  
  
 For more information, see [3.3.1 omp_get_wtime Function](../VS_csharp/3.3.1-omp_get_wtime-function.md).  
  
## Example  
  
```  
// omp_get_wtime.cpp  
// compile with: /openmp  
#include "omp.h"  
#include <stdio.h>  
#include <windows.h>  
  
int main() {  
    double start = omp_get_wtime( );  
    Sleep(1000);  
    double end = omp_get_wtime( );  
    double wtick = omp_get_wtick( );  
  
    printf_s("start = %.16g\nend = %.16g\ndiff = %.16g\n",  
             start, end, end - start);  
  
    printf_s("wtick = %.16g\n1/wtick = %.16g\n",  
             wtick, 1.0 / wtick);  
}  
```  
  
 **start = 594255.3671159324**  
**end = 594256.3664474116**  
**diff = 0.9993314791936427**  
**wtick = 2.793651148400146e-007**  
**1/wtick = 3579545**   
## See Also  
 [Functions](../VS_csharp/openmp-functions.md)