---
title: "Compiler Error C3648"
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
  - "C3648"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3648"
ms.assetid: 5d042989-41cb-4cd0-aa50-976b70146aaf
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3648
this explicit override syntax requires /clr:oldSyntax  
  
 When compiling for the latest managed syntax, the compiler found explicit override syntax for previous versions.  
  
 For more information, see [Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md). For more information on the older syntax, see [Explicit Overrides](../vs140/explicit-overrides--c---.md).  
  
 The following sample generates C3648:  
  
```  
// C3648.cpp  
// compile with: /clr  
public interface struct I {  
   void f();  
};  
  
public ref struct R : I {  
   virtual void I::f() {}   // C3648  
   // try the following line instead  
   // virtual void f() = I::f{}  
};  
```