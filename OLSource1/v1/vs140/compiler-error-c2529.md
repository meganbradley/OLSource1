---
title: "Compiler Error C2529"
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
  - C2529
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2529
ms.assetid: 73a99e55-b91e-488d-9b72-cc80faaeb436
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2529
'name' : reference to reference is illegal  
  
 This error may be fixed by using pointer syntax and declaring a reference to a pointer.  
  
 The following sample generates C2529:  
  
```  
// C2529.cpp  
// compile with: /c  
int i;  
int &ri = i;  
int &(&rri) = ri;   // C2529  
```