---
title: "Compiler Error C2276"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2276"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2276"
ms.assetid: 62005ad9-6cb9-4b1f-965d-b875adaf695e
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2276
'operator' : illegal operation on bound member function expression  
  
 The compiler found a problem with the syntax to create a pointer-to-member.  
  
 The following sample generates C2276:  
  
```  
// C2276.cpp  
class A {  
public:  
   int func(){return 0;}  
} a;  
  
int (*pf)() = &a.func;   // C2276  
// try the following line instead  
// int (A::*pf3)() = &A::func;  
  
class B {  
public:  
   void mf() {  
      &this -> mf;   // C2276  
      // try the following line instead  
      // &B::mf;  
   }  
};  
  
int main() {  
   A a;  
   &a.func;   // C2276  
   // try the following line instead  
   // &A::func;  
}  
```