---
title: "Compiler Error C2890"
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
  - C2890
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2890
ms.assetid: 49147375-182c-42b1-b170-f475cd436d47
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2890
'class' : a ref class can only have one non-interface base class  
  
 A reference class can only have one base class.  
  
 The following sample generates C2890:  
  
```  
// C2890.cpp  
// compile with: /clr /c  
ref class A {};  
ref class B {};  
ref class C : public A, public B {};   // C2890  
ref class D : public A {};   // OK  
```  
  
 **Managed Extensions for C++**  
  
 The following sample generates C2890:  
  
```  
// C2890b.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
__gc class A {};  
__gc class B {};  
  
__gc class C : public A, public B {};   // C2890  
__gc class D : public A {};   // OK  
```