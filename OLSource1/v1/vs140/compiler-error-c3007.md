---
title: "Compiler Error C3007"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3007"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3007"
ms.assetid: e415ef42-bdc9-4f32-8198-5e25b289a089
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3007
'arg' : clause on OpenMP 'directive' directive does not take an argument  
  
 An OpenMP directive had an argument, but the directive does not take an argument.  
  
 The following sample generates C3007:  
  
```  
// C3007.c  
// compile with: /openmp  
int main()  
{  
   #pragma omp parallel for ordered(2)   // C3007  
}  
```