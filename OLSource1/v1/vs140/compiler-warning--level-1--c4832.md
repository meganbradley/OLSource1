---
title: "Compiler Warning (level 1) C4832"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C4832
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4832
ms.assetid: 3b8e4b38-2e60-4385-b7fe-44a22aff6a8d
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4832
token 'token' is illegal after UDT 'type name'  
  
 A member of a UDT (user-defined type, such a class or struct) was qualified incorrectly. The compiler issues this warning when the qualification was specified incorrectly.  
  
 The following sample generates C4832:  
  
```  
// C4832.cpp  
// compile with: /W1  
struct A {  
   enum { e };  
};  
  
int main() {  
   return A.e;   // C4832   
   // try the following line instead  
   // return A::e;  
}  
```  
  
 To fix this issue, use the correct syntax to specify the qualification:  
  
```  
// C4832.cpp  
// compile with: /W1  
struct A {  
   enum { e };  
};  
  
int main() {  
   return A::e;   // Qualify the member by using scope resolution  
}  
```