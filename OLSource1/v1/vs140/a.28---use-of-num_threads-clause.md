---
title: "A.28   Use of num_threads Clause"
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
ms.assetid: 26238da1-902c-49b4-9559-0fbc9eaf7f36
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# A.28   Use of num_threads Clause
The following example demonstrates the `num_threads` clause ([Section 2.3](../vs140/2.3-parallel-construct.md) on page 8). The parallel region is executed with a maximum of 10 threads.  
  
```  
#include <omp.h>  
main()  
{  
    omp_set_dynamic(1);  
    ...  
    #pragma omp parallel num_threads(10)  
    {  
        ... parallel region ...  
    }  
}  
```