---
title: "Compiler Warning (level 3) C4265"
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
  - "C4265"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4265"
ms.assetid: 20547159-6f30-4cc4-83aa-927884c8bb4c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4265
'class' : class has virtual functions, but destructor is not virtual  
  
 When a class has virtual functions but a nonvirtual destructor, objects of the type might not be destroyed properly when the class is destroyed through a base class pointer.  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
 The following sample generates C4265:  
  
```  
// C4265.cpp  
// compile with: /W3 /c  
#pragma warning(default : 4265)  
class B  
{  
public:  
   virtual void vmf();  
  
   ~B();  
   // try the following line instead  
   // virtual ~B();  
};   // C4265  
  
int main()  
{  
   B b;  
}  
```