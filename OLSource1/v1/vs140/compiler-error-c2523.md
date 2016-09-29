---
title: "Compiler Error C2523"
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
  - "C2523"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2523"
ms.assetid: 7951b700-8f37-45a0-beb4-a79ae0ced72e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2523
'class::~identifier' : destructor/finalizer tag mismatch  
  
 The name of the destructor must be the class name preceded by a tilde (`~`). The constructor and destructor are the only members that have the same name as the class.  
  
 The following sample generates C2523:  
  
```  
// C2523.cpp  
// compile with: /c  
class A {  
   ~B();    // C2523  
   ~A();   // OK  
};  
```