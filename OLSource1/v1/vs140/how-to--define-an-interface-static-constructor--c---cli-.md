---
title: "How to: Define an Interface Static Constructor (C++-CLI)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: How to: Define an Interface Static Constructor (C++/CLI)
dev_langs: 
  - C++
helpviewer_keywords: 
  - constructors [C++]
  - static constructors, interface
  - interface static constructor
ms.assetid: 1f031cb2-e94f-43dc-819b-44cf2faaaa49
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Define an Interface Static Constructor (C++-CLI)
An interface can have a static constructor, which can be used to initialize static data members.  A static constructor will be called at most once, and will be called before the first time a static interface member is accessed.  
  
 For more information on static constructors, see [Static Constructors in a Class or Struct](../vs140/how-to--define-static-constructors-in-a-class-or-struct.md).  
  
## Example  
  
```  
// mcppv2_interface_class2.cpp  
// compile with: /clr  
using namespace System;  
  
interface struct MyInterface {  
   static int i;  
   static void Test() {  
      Console::WriteLine(i);  
   }  
  
   static MyInterface() {   
      Console::WriteLine("in MyInterface static constructor");  
      i = 99;  
   }  
};  
  
ref class MyClass : public MyInterface {};  
  
int main() {  
   MyInterface::Test();  
   MyClass::MyInterface::Test();  
  
   MyInterface ^ mi = gcnew MyClass;  
   mi->Test();  
}  
```  
  
 **in MyInterface static constructor**  
**99**  
**99**  
**99**   
## See Also  
 [interface class](../vs140/interface-class---c---component-extensions-.md)