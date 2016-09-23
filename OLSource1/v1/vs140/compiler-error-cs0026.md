---
title: "Compiler Error CS0026"
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
  - CS0026
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0026
ms.assetid: 8767fbc1-8ba7-4e88-a9f9-7e620411882b
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0026
Keyword 'this' is not valid in a static property, static method, or static field initializer  
  
 The [this](../vs140/this--csharp-reference-.md) keyword refers to an object, which is an instance of a type. Since static methods are independent of any instance of the containing class, the "this" keyword is meaningless and is therefore not allowed. For more information, see [Static Classes and Static Class Members (C# Programmers Reference)](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md) and [Objects (C# Programmers Reference)](../vs140/objects--csharp-programming-guide-.md).  
  
## Example  
 The following example generates CS0026:  
  
```  
// CS0026.cs  
public class A  
{  
   public static int i = 0;  
  
   public static void Main()  
   {  
// CS0026  
      this.i = this.i + 1;     
      // Try the following line instead:  
      // i = i + 1;  
   }  
}  
```