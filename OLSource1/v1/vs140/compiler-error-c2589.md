---
title: "Compiler Error C2589"
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
  - "C2589"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2589"
ms.assetid: 1d7942c7-8a81-4bb4-b272-76a0019e8513
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2589
'identifier' : illegal token on right side of '::'  
  
 If a class, structure, or union name appears to the left of the scope-resolution operator (double colons), the token on the right must be a class, structure, or union member. Otherwise, any global identifier can appear on the right.  
  
 The scope-resolution operator cannot be overloaded.  
  
 The following sample generates C2589:  
  
```  
// C2589.cpp  
void Test(){}  
class A {};  
void operator :: ();   // C2589  
  
int main() {  
   ::Test();  
}  
```