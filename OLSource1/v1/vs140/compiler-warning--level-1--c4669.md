---
title: "Compiler Warning (level 1) C4669"
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
  - "C4669"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4669"
ms.assetid: 97730679-e3dc-44d4-b2a8-aa65badc17f2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4669
'cast' : unsafe conversion: 'class' is a managed or WinRT type object  
  
 A cast contains a Windows Runtime or managed type. The compiler completes the cast by performing a bit-wise copy of one pointer to the other, but provides no other checking. To resolve this warning, do not cast classes containing managed members or Windows Runtime types.  
  
 The following sample generates C4669 and shows how to fix it:  
  
```  
// C4669.cpp  
// compile with: /clr /W1  
ref struct A {  
   int i;  
   Object ^ pObj;   // remove the managed member to fix the warning  
};  
  
ref struct B {  
   int j;  
};  
  
int main() {  
   A ^ a = gcnew A;  
   B ^ b = reinterpret_cast<B ^>(a);   // C4669  
}  
```