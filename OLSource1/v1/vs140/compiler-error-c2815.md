---
title: "Compiler Error C2815"
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
  - C2815
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2815
ms.assetid: d0256fd6-0721-4c99-b03c-52d96e77a613
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2815
'operator delete' : first formal parameter must be 'void *', but 'param' was used  
  
 Any user-defined [operator delete](../vs140/operator-delete---new--.md) function must take a first formal parameter of type `void *`.  
  
 The following sample generates C2815:  
  
```  
// C2815.cpp  
// compile with: /c  
class CMyClass {  
public:  
   void mf1(int *a);  
   void operator delete(CMyClass *);   // C2815  
   void operator delete(void *);   
};  
```