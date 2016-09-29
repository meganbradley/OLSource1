---
title: "Compiler Error C3379"
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
  - "C3379"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3379"
ms.assetid: a66c2c4e-091c-4426-9cde-7c4cfb2ffce1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3379
'class' : a nested class cannot have an assembly access specifier as part of its declaration  
  
 When applied to a managed type, such as class or struct, the [public](../vs140/public--c---.md) and [private](../vs140/private--c---.md) keywords indicate whether the class will be exposed through assembly metadata. `public` or `private` cannot be applied to a nested class, which will inherit the assembly access of the enclosing class.  
  
 When used with [/clr](../vs140/-clr--common-language-runtime-compilation-.md), the `ref` and `value` keywords indicate that a class is managed (see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)).  
  
 The following sample generates C3379:  
  
```  
// C3379a.cpp  
// compile with: /clr  
using namespace System;  
  
public ref class A {  
public:  
   static int i = 9;  
  
   public ref class BA {   // C3379  
   // try the following line instead  
   // ref class BA {  
   public:  
      static int ii = 8;  
   };  
};  
  
int main() {  
  
   A^ myA = gcnew A;  
   Console::WriteLine(myA->i);  
  
   A::BA^ myBA = gcnew A::BA;  
   Console::WriteLine(myBA->ii);  
}  
```  
  
 The following sample generates C3379:  
  
```  
// C3379b.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
  
public __gc class A {  
public:  
   static int i = 9;  
  
   public __gc class BA {   // C3379  
   // try the following line instead  
   // __gc class BA {  
   public:  
      static int ii = 8;  
   };  
};  
  
int main() {  
  
   A *myA = new A;  
   Console::WriteLine(myA->i);  
  
   A::BA *myBA = new A::BA;  
   Console::WriteLine(myBA->ii);  
}  
```