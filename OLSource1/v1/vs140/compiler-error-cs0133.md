---
title: "Compiler Error CS0133"
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
  - CS0133
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0133
ms.assetid: b5be456f-824d-4e6d-802b-0b1b5889efbd
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0133
The expression being assigned to 'variable' must be constant  
  
 A [const](../vs140/const--csharp-reference-.md) variable cannot take as its value an expression that is not constant. For more information, see [Constants (C# Programmer's Reference)](../vs140/constants--csharp-programming-guide-.md).  
  
 The following sample generates CS0133:  
  
```  
// CS0133.cs  
public class MyClass  
{  
   public const int i = c;   // CS0133, c is not constant  
   public static int c = i;  
   // try the following line instead  
   // public const int i = 6;  
  
   public static void Main()  
   {  
   }  
}  
```