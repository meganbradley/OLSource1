---
title: "Compiler Error C2272"
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
  - C2272
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2272
ms.assetid: 1517706a-9c27-452e-9b10-3424b3d232bc
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2272
'function' : modifiers not allowed on static member functions  
  
 A `static` member function is declared with a memory-model specifier, such as [const](../vs140/const--c---.md) or [volatile](../vs140/volatile--c---.md), and such modifiers are not allowed on `static` member functions.  
  
 The following sample generates C2272:  
  
```  
// C2272.cpp  
// compile with: /c  
class CMyClass {  
public:  
   static void func1() const volatile;   // C2272  func1 is static  
   void func2() const volatile;   // OK  
};  
```