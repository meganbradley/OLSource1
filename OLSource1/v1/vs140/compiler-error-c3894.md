---
title: "Compiler Error C3894"
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
  - "C3894"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3894"
ms.assetid: 6d5ac903-1dea-431d-8e3a-cebca4342983
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3894
'var' : l-value use of initonly static data member is only allowed in the class constructor of class 'class'  
  
 Static [initonly](../vs140/initonly--c---cli-.md) data members can only be used as l-values at their point of declaration, or in a static constructor.  
  
 Instance (non-static) initonly data members can only be used as l-values at their point of declaration, or in instance (non-static) constructors.  
  
 The following sample generates C3894:  
  
```  
// C3894.cpp  
// compile with: /clr  
ref struct Y1 {  
   initonly static int data_var = 0;  
  
public:  
   // class constructor  
   static Y1() {  
      data_var = 99;   // OK  
      System::Console::WriteLine("in static constructor");  
   }  
  
   // not the class constructor  
   Y1(int i) {  
      data_var = i;   // C3894  
   }  
  
   static void Test() {}  
  
};  
  
int main() {  
   Y1::data_var = 88;   // C3894  
   int i = Y1::data_var;  
   Y1 ^ MyY1 = gcnew Y1(99);  
   Y1::Test();  
}  
```