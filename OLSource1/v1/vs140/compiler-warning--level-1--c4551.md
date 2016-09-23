---
title: "Compiler Warning (level 1) C4551"
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
  - C4551
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4551
ms.assetid: 458b59bd-e2d7-425f-9ba6-268ff200424f
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4551
function call missing argument list  
  
 A function call must include the open and close parentheses after the function name even if the function takes no parameters.  
  
 The following sample generates C4551:  
  
```  
// C4551.cpp  
// compile with: /W1  
void function1() {  
}  
  
int main() {  
   function1;   // C4551  
   function1();   // OK  
}  
```