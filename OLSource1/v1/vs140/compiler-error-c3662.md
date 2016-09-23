---
title: "Compiler Error C3662"
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
  - C3662
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3662
ms.assetid: 61bd3e41-a86b-42c0-be89-d992d3906ff1
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3662
'member' : override specifier 'specifier' only allowed on member functions of managed or WinRT classes  
  
 An override specifier was used on a member of native type, which is not allowed.  
  
 For more information, see [Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3662.  
  
```  
// C3662.cpp  
// compile with: /clr /c  
struct S {  
   virtual void f();  
};  
  
struct S1 : S {  
   virtual void f() new;   // C3662  
};  
  
ref struct T {  
   virtual void f();  
};  
  
ref struct T1 : T {  
   virtual void f() new;   // OK  
};  
```