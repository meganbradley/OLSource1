---
title: "Compiler Error CS0215"
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
  - CS0215
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0215
ms.assetid: 2060440d-be22-4c10-8b26-43b08b615447
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0215
The return type of operator True or False must be bool  
  
 User-defined [true](../vs140/true--csharp-reference-.md) and [false](../vs140/false--csharp-reference-.md) operators must have a return type of [bool](../vs140/bool--csharp-reference-.md). For more information, see [Overloadable Operators (C# Programmers Reference)](../vs140/overloadable-operators--csharp-programming-guide-.md).  
  
 The following sample generates CS0215:  
  
```  
// CS0215.cs  
class MyClass  
{  
   public static int operator true (MyClass MyInt)   // CS0215  
   // try the following line instead  
   // public static bool operator true (MyClass MyInt)  
   {  
      return true;  
   }  
  
   public static int operator false (MyClass MyInt)   // CS0215  
   // try the following line instead  
   // public static bool operator false (MyClass MyInt)  
   {  
      return true;  
   }  
  
   public static void Main()  
   {  
   }  
}  
```