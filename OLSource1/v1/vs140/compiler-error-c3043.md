---
title: "Compiler Error C3043"
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
  - C3043
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3043
ms.assetid: 0ef55e63-e82b-48eb-9d44-690950ac34c6
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3043
OpenMP 'critical' directive cannot be nested in 'critical' directive with same name  
  
 A [critical](../vs140/critical.md) directive cannot be nested in a `critical` directive that uses the same name.  
  
 The following sample generates C3043:  
  
```  
// C3043.cpp  
// compile with: /openmp /c  
#include "omp.h"  
  
int main() {  
   int n1 = 1, n2 = 2, n3 = 3;  
  
   #pragma omp parallel  
   {  
      ++n2;  
  
      #pragma omp critical(MyTest)  
      {  
         ++n2;  
  
         #pragma omp critical(MyTest)   // C3043  
         // try the following line instead  
         // #pragma omp critical(MyTest2)  
         {  
            ++n3;  
         }  
      }  
   }  
}  
```