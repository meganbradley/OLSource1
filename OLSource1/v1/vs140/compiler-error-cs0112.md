---
title: "Compiler Error CS0112"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0112"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0112"
ms.assetid: 6741c7c4-8553-4bbe-b950-4f908e8d9ba3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0112
A static member 'function' cannot be marked as override, virtual or abstract  
  
 Any method declaration that uses the `override`, **virtual**, or **abstract** keyword cannot also use the **static** keyword.  
  
 For more information, see [Class and Struct Methods (C# Programmer's Reference)](../vs140/methods--csharp-programming-guide-.md).  
  
 The following sample generates CS0112:  
  
```  
// CS0112.cs  
namespace MyNamespace  
{  
   abstract public class MyClass  
   {  
      public abstract void Foo();  
   }  
   public class MyClass2 : MyClass  
   {  
      override public static void Foo()   // CS0112, remove static keyword  
      {  
      }  
      public static int Main()  
      {  
         return 0;  
      }  
   }  
}  
```