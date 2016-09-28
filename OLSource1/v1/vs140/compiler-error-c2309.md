---
title: "Compiler Error C2309"
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
  - "C2309"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2309"
ms.assetid: 6303d5b5-72cf-42b8-92ce-b1eb48e80d48
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2309
catch handler expected a parenthesized exception declaration  
  
 A catch handler has no parenthesized type.  
  
 The following sample generates C2309:  
  
```  
// C2309.cpp  
// compile with: /EHsc  
#include <eh.h>  
class C {};  
int main() {  
   try {  
      throw "ooops!";  
   }  
   catch C {}   // C2309  
   // try the following line instead  
   // catch( C ) {}  
}  
```