---
title: "Compiler Error C3058"
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
  - "C3058"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3058"
ms.assetid: 669d08c8-0b58-4351-88aa-c6e6e1af481c
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3058
'symbol' : symbol not declared as 'threadprivate' before it is used in the 'copyin' clause  
  
 A symbol must first be declared [threadprivate](../vs140/threadprivate.md) before it can be used in a [copyin](../vs140/copyin.md) clause.  
  
 The following sample generates C3058:  
  
```  
// C3058.cpp  
// compile with: /openmp  
int x, y, z;  
#pragma omp threadprivate(x, z)  
  
void test() {  
   #pragma omp parallel copyin(x, y)   // C3058  
   {  
   }  
}  
```  
  
 Possible resolution:  
  
```  
// C3058b.cpp  
// compile with: /openmp /LD  
int x, y, z;  
#pragma omp threadprivate(x, y)  
  
void test() {  
   #pragma omp parallel copyin(x, y)  
   {  
   }  
}  
```