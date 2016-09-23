---
title: "Compiler Error C2598"
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
  - C2598
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2598
ms.assetid: 40777c62-39ba-441e-b081-f49f94b43547
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2598
linkage specification must be at global scope  
  
 The linkage specifier is declared at local scope.  
  
 The following sample generates C2598:  
  
```  
// C2598.cpp  
// compile with: /c  
void func() {  
   extern "C" int func2();   // C2598  
}  
  
extern "C" int func( int i );  
```