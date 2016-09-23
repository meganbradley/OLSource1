---
title: "Compiler Error C3049"
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
  - C3049
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3049
ms.assetid: 6ddf54f6-2c30-4d04-b637-98c6c922c533
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3049
'arg' : invalid argument in OpenMP 'default' clause  
  
 An incorrect value was passed to a [default](../vs140/default--openmp-.md) clause.  
  
 The following sample generates C3049:  
  
```  
// C3049.cpp  
// compile with: /openmp /c  
int main() {  
   int n1 = 1;  
  
   #pragma omp parallel default(private)   // C3049   
   // try the following line instead  
   // #pragma omp parallel default(shared)  
   {  
      ++n1;  
   }  
}  
```