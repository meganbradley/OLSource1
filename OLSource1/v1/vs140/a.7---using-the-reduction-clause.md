---
title: "A.7   Using the reduction Clause"
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
ms.assetid: e71e65bc-a25c-4f02-b507-66b52bf950a4
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# A.7   Using the reduction Clause
The following example demonstrates the reduction clause ([Section 2.7.2.6](../vs140/2.7.2.6-reduction.md) on page 28):  
  
```  
#pragma omp parallel for private(i) shared(x, y, n) \  
                         reduction(+: a, b)  
    for (i=0; i<n; i++) {  
        a = a + x[i];  
        b = b + y[i];  
    }  
```