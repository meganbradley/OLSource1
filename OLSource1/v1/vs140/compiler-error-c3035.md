---
title: "Compiler Error C3035"
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
  - C3035
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3035
ms.assetid: af34fad2-2b45-42d0-a9ff-04eab3e91c37
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3035
OpenMP 'ordered' directive must bind directly to a 'for' or 'parallel for' directive with the 'ordered' clause  
  
 An ordered clause was ill formed.  
  
 The following sample generates C3035:  
  
```  
// C3035.cpp  
// compile with: /openmp /link vcomps.lib  
int main() {  
   int n = 0, x, i;  
  
   #pragma omp parallel private(n)  
   {  
      #pragma omp ordered   // C3035  
      // Try the following line instead:  
      // #pragma omp for ordered  
       for (i = 0 ; i < 10 ; ++i)  
         ;  
   }  
}  
```