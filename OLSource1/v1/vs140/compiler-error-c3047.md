---
title: "Compiler Error C3047"
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
  - C3047
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3047
ms.assetid: 91c14566-5958-433d-8549-0e8bc3196f76
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3047
Structured block in an OpenMP 'sections' region must be preceded by '#pragma omp section'  
  
 Any code in a code block introduced by a [sections](../vs140/sections--openmp-.md) directive must be in a code block introduced by a `section` directive.  
  
 The following sample generates C3047:  
  
```  
// C3047.cpp  
// compile with: /openmp /c  
#include "omp.h"  
  
int main() {  
   int n2 = 2, n3 = 3;  
  
   #pragma omp parallel  
   {  
      ++n2;  
  
      #pragma omp sections  
      {  
  
         #pragma omp section  
         {  
            ++n3;  
         }  
  
         ++n2;   // C3047 not enclosed in #pragma omp section  
      }  
   }  
}  
```