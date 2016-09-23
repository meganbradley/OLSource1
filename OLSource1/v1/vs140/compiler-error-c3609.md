---
title: "Compiler Error C3609"
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
  - C3609
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3609
ms.assetid: 801e7f79-4ac6-4f8f-955f-703cdf095d00
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3609
'member': a sealed or final function must be virtual  
  
 The [sealed](../vs140/sealed---c---component-extensions-.md) and [final](../vs140/final-specifier.md) keywords are only allowed on a class, struct, or member function marked `virtual`.  
  
 The following sample generates C3609:  
  
```  
// C3609.cpp  
// compile with: /clr /c  
ref class C {  
   int f() sealed;   // C3609  
   virtual int f2() sealed;   // OK  
};  
```  
  
 **Managed Extensions for C++**  
  
 The following sample generates C3609:  
  
```  
// C3609c.cpp  
// compile with: /clr:oldSyntax /c  
__gc class C {  
   __sealed int f();   // C3609  
   __sealed virtual int f2();   // OK  
};  
```