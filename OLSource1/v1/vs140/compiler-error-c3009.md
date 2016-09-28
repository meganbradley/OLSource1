---
title: "Compiler Error C3009"
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
  - "C3009"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3009"
ms.assetid: aded5985-f5fd-4c3e-a157-16be55ec1313
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3009
'label' : jump into OpenMP structured block not allowed  
  
 Code cannot jump into or out of an OpenMP block.  
  
 The following sample generates C3009:  
  
```  
// C3009.c  
// compile with: /openmp  
int main() {  
   #pragma omp parallel   
   {  
   lbl2:;  
   }  
   goto lbl2;   // C3009  
}  
```