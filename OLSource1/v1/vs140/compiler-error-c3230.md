---
title: "Compiler Error C3230"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3230"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3230"
ms.assetid: 5ec53f25-59f6-4801-81e7-7b68bf04994d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3230
'function' : template type argument for 'template' cannot contain a generic type parameter: 'param'  
  
 Templates are instantiated at compile time, but generics are instantiated at run time. Therefore, it is not possible to generate generic code that can call the template because the template cannot be instantiated at run time when the generic type is finally known.  
  
 The following sample generates C3230:  
  
```  
// C3230.cpp  
// compile with: /clr /LD  
template <class S>   
void f(S t);  
  
generic <class U>  
ref class C {  
   void f1(U x) {  
      f(x);   // C3230  
   }  
};  
```