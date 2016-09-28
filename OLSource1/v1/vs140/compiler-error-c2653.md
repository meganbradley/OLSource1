---
title: "Compiler Error C2653"
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
  - "C2653"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2653"
  - "CDaoRecordset class, adding records"
ms.assetid: 3f49e731-affd-43a0-a8d0-181db7650bc3
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2653
'identifier' : is not a class or namespace name  
  
 Syntax requires a class, structure, union, or namespace name.  
  
 The following sample generates C2653:  
  
```  
// C2653.cpp  
// compile with: /c  
class yy {  
   void func1(int i);  
};  
  
void xx::func1(int m) {}   // C2653  
void yy::func1(int m) {}   // OK  
```  
  
 C2653 is also possible if you try to define a compound namespace; compound namespaces are not allowed in C++:  
  
```  
// C2653b.cpp  
namespace a::b {int i;}   // C2653  
  
namespace a {  
   namespace b {  
      int i;  
   }  
}  
  
int main() {  
   a::b::i = 2;  
}  
```