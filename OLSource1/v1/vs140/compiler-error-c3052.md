---
title: "Compiler Error C3052"
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
  - "C3052"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3052"
ms.assetid: 87480c42-1ceb-4775-8d20-88c54a7bb6a6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3052
'var' : variable doesn't appear in a data-sharing clause under a default(none) clause  
  
 If [default(none)](../vs140/default--openmp-.md) is used, any variable used in the structured block must be explicitly specified as either [shared](../vs140/shared--openmp-.md) or [private](../vs140/private--openmp-.md).  
  
 The following sample generates C3052:  
  
```  
// C3052.cpp  
// compile with: /openmp /c  
int main() {  
   int n1 = 1;  
  
   #pragma omp parallel default(none) // shared(n1) private(n1)  
   {  
      n1 = 0;   // C3052 use either a shared or private clause  
   }  
}  
```