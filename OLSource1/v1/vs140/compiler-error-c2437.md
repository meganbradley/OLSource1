---
title: "Compiler Error C2437"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C2437
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2437
ms.assetid: 2d2b3c6c-856a-4b27-ae10-64813b3e5483
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2437
'identifier' : already initialized  
  
 An object can be initialized only once.  
  
 The following sample generates C2437:  
  
```  
// C2437.cpp  
// compile with: /c  
class A {  
public:  
   A(int i) {}  
};  
  
class B : A {  
   B() : A(1), A(2) {}   // C2437  
   B() : A(1) {}   // OK  
};  
```