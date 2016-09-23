---
title: "Compiler Error CS1534"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS1534
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1534
ms.assetid: afb28c3a-a74c-4e47-b016-9e3245a5a1b1
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1534
Overloaded binary operator 'operator' takes two parameters  
  
 The definition of a binary [overloadable operator](../vs140/overloadable-operators--csharp-programming-guide-.md) must take two parameters.  
  
 The following sample generates CS1534:  
  
```  
// CS1534.cs  
class MyClass  
{  
   public static MyClass operator - (MyClass MC1, MyClass MC2, MyClass MC3)   // CS1534  
   // try the following line instead  
   // public static MyClass operator - (MyClass MC1, MyClass MC2)  
   {  
      return new MyClass();  
   }  
  
   public static int Main()  
   {  
      return 1;  
   }  
}  
```