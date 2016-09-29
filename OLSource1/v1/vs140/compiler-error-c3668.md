---
title: "Compiler Error C3668"
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
  - "C3668"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3668"
ms.assetid: 53a96698-bde4-4447-95b5-b5108291f60c
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3668
'method' : method with override specifier 'override' did not override any base class methods  
  
 A function attempted to override a non-existent function.  
  
 For more information, see [Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3668.  
  
```  
// C3668.cpp  
// compile with: /c  
__interface I {  
   void f(int);   // virtual by default  
};  
  
class J {  
public:  
   void g(int);  
   virtual void h(int);  
};  
  
struct R : I,J {  
   virtual void f() override {}   // C3668  
   virtual void f(int) override {}   // OK  
  
   virtual void g(int) override {}   // C3668  
   virtual void h(int) override {}   // OK  
};  
```