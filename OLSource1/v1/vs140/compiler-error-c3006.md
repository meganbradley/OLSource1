---
title: "Compiler Error C3006"
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
  - "C3006"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3006"
ms.assetid: 449082ec-fd45-4c47-8ab3-ba6a719e4dc4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3006
'clause' : clause on OpenMP 'directive' directive is missing an expected argument  
  
 An OpenMP directive did not have an expected argument.  
  
 The following sample generates C3006:  
  
```  
// C3006.c  
// compile with: /openmp  
int main()  
{  
   #pragma omp parallel shared   // C3006  
   // Try the following line instead:  
   // #pragma omp parallel shared(x) {}  
  
}  
```