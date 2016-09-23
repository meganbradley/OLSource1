---
title: "Compiler Error C3670"
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
  - C3670
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3670
ms.assetid: d0fa9c6e-8f90-48c7-9066-31b4fa5942eb
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3670
'override' : cannot override inaccessible base class method 'method'  
  
 An override can only take place on a function whose access level makes it available in a derived type. For more information, see [Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md).  
  
 The following sample generates C3670:  
  
```  
// C3670.cpp  
// compile with: /clr /c  
public ref class C {  
// Uncomment the following line to resolve.  
// public:  
   virtual void g() { }  
};  
  
public ref class D : public C {  
public:  
   virtual void f() new sealed = C::g {};   // C3670  
};  
```