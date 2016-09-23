---
title: "A.12   Using the atomic Directive"
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
ms.assetid: d3ba3c87-413d-4efa-8a45-8a7f28ab0164
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# A.12   Using the atomic Directive
The following example avoids race conditions (simultaneous updates of an element of *x* by multiple threads) by using the `atomic` directive ([Section 2.6.4](../vs140/2.6.4-atomic-construct.md) on page 19):  
  
```  
#pragma omp parallel for shared(x, y, index, n)  
    for (i=0; i<n; i++)   
    {  
        #pragma omp atomic  
            x[index[i]] += work1(i);  
        y[i] += work2(i);  
    }  
```  
  
 The advantage of using the `atomic` directive in this example is that it allows updates of two different elements of x to occur in parallel. If a `critical` directive  ([Section 2.6.2](../vs140/2.6.2-critical-construct.md) on page 18) were used instead, then all updates to elements of *x* would be executed serially (though not in any guaranteed order).  
  
 Note that the `atomic` directive applies only to the C or C++ statement immediately following it.  As a result, elements of *y* are not updated atomically in this example.