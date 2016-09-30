---
title: "Compiler Error C2577"
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
  - "C2577"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2577"
ms.assetid: fc79ef83-8362-40a2-9257-8037c3195ce4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2577
'member' : destructor/finalizer cannot have a return type  
  
 A destructor or finalizer cannot return a value of `void` or any other type. Remove the `return` statement from the destructor definition.  
  
## Example  
 The following sample generates C2577.  
  
```  
// C2577.cpp  
// compile with: /c  
class A {  
public:  
   A() {}  
   ~A(){  
      return 0;   // C2577  
   }  
};  
```