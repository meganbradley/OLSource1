---
title: "Compiler Error C3042"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3042
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3042
ms.assetid: bf73f61e-5bd2-40a8-9b06-6244e6a15a41
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3042
'copyprivate' and 'nowait' clauses cannot appear together on OpenMP 'directive' directive  
  
 The [copyprivate](../vs140/copyprivate.md) and [nowait](../vs140/nowait.md) clauses are mutually exclusive on the specified directive. To fix this error, remove one or both of the `copyprivate` or `nowait` clauses.  
  
 The following sample generates C3042:  
  
```  
// C3042.cpp  
// compile with: /openmp /c  
#include <stdio.h>  
#include "omp.h"  
  
double d;  
  
int main() {  
    #pragma omp parallel private(d)  
   {  
      #pragma omp single copyprivate(d) nowait   // C3042  
      {  
      }  
   }  
}  
```