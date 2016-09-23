---
title: "Compiler Error C3239"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3239
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3239
ms.assetid: 22a518b7-020f-4f3c-9963-a094667fd1ac
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3239
'type' : pointer to interior/pin pointer is disallowed by the common language runtime  
  
 The compiler encountered an invalid type.  
  
 The following sample generates C3229:  
  
```  
// C3239.cpp  
// compile with: /clr  
int main() {  
   interior_ptr<int>* pip0;   // C3239  
  
   // OK  
   int * pip1;  
   interior_ptr<int> pip2;  
   int ** pip;  
}  
```