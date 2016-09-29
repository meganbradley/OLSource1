---
title: "Compiler Error C2698"
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
  - "C2698"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2698"
ms.assetid: 3ebfe395-c20b-4c56-9980-ca9ed8653382
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2698
the using-declaration for 'declaration 1' cannot co-exist with the existing using-declaration for 'declaration 2'  
  
 Once you have a [using declaration](../vs140/using-declaration.md) for a data member, any using declaration in the same scope that uses the same name is not permitted, as only functions can be overloaded.  
  
 The following sample generates C2698:  
  
```  
// C2698.cpp  
struct A {  
   int x;  
};  
  
struct B {  
   int x;  
};  
  
struct C : A, B {  
   using A::x;  
   using B::x;   // C2698  
}  
```