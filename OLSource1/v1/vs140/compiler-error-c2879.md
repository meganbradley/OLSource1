---
title: "Compiler Error C2879"
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
  - C2879
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2879
ms.assetid: ac92b645-2394-49de-8632-43d44e0553ed
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2879
'symbol' : only an existing namespace can be given an alternative name by a namespace alias definition  
  
 You cannot create a [namespace alias](../vs140/namespace-alias.md) to a symbol other than a namespace.  
  
 The following sample generates C2879:  
  
```  
// C2879.cpp  
int main() {  
   int i;  
   namespace A = i;   // C2879 i is not a namespace  
}  
```