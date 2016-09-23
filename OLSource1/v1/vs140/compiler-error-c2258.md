---
title: "Compiler Error C2258"
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
  - C2258
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2258
ms.assetid: 105eaa87-befb-4ecb-9a3f-e09e14d2f5bf
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2258
illegal pure syntax, must be '= 0'  
  
 A pure virtual function is declared with incorrect syntax.  
  
 The following sample generates C2258:  
  
```  
// C2258.cpp  
// compile with: /c  
class A {  
public:  
   void virtual func1() = 1; // C2258  
   void virtual func2() = 0;   // OK  
};  
```