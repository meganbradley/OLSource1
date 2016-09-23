---
title: "Compiler Error C2107"
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
  - C2107
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2107
ms.assetid: 2866a121-884e-4bb5-8613-36de5817000e
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2107
illegal index, indirection not allowed  
  
 A subscript is applied to an expression that does not evaluate to a pointer.  
  
## Example  
 C2107 can occur if you incorrectly use the `this` pointer of a value type to access the type's default indexer. For more information, see [Semantics of the this Pointer](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Semantics_of_the_this_pointer).  
  
 The following sample generates C2107.  
  
```  
// C2107.cpp  
// compile with: /clr  
using namespace System;  
  
value struct B {  
   property String ^ default[String ^] {  
      String ^ get(String ^ data) {  
         return "abc";  
      }  
   }  
   void Test() {  
      Console::WriteLine("{0}", this["aa"]);   // C2107  
      Console::WriteLine("{0}", this->default["aa"]);   // OK  
   }  
};  
  
int main() {  
   B ^ myb = gcnew B();  
   myb->Test();  
}  
```