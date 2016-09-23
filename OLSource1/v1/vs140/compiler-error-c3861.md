---
title: "Compiler Error C3861"
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
  - C3861
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3861
ms.assetid: 0a1eee30-b3db-41b1-b1e5-35949c3924d7
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3861
'identifier': identifier not found  
  
 The compiler was not able to resolve a reference to an identifier, even using argument-dependent lookup.  
  
 To fix this error, check the identifier declaration for case and spelling. Verify that [scope resolution operators](../vs140/scope-resolution-operator----.md) and namespace [using directives](../vs140/using-directive--c---.md) are used correctly. If the identifier is declared in a header file, verify that the header is included before it is referenced. Also check that the identifier is not excluded by [conditional compilation directives](../vs140/sharpif--sharpelif--sharpelse--and-sharpendif-directives--c-c---.md).  
  
## Example  
 The following sample generates C3861.  
  
```  
// C3861.cpp  
void f2(){}  
int main() {  
   f();   // C3861  
   f2();   // OK  
}  
```  
  
## Example  
 Exception classes in the C++ Standard Library are now in the `std` namespace.  
  
```  
// C3861_b.cpp  
// compile with: /EHsc  
#include <iostream>  
int main() {  
   try {  
      throw exception("Exception");   // C3861  
      // try the following line instead  
      // throw std::exception("Exception");  
   }  
   catch (...) {  
      std::cout << "caught an exception" << std::endl;  
   }  
}  
```