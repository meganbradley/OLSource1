---
title: "Compiler Error CS0051"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0051"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0051"
ms.assetid: 62182e8d-c4a5-4853-a990-fd57a4f7c3b8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0051
Inconsistent accessibility: parameter type 'type' is less accessible than method 'method'  
  
 The return type and each of the types referenced in the formal parameter list of a method must be at least as accessible as the method itself. Make sure the types used in method signatures are not accidentally private due to the omission of the `public` modifier. For more information, see [Access Modifiers (C# Programmers Reference)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0051:  
  
```  
// CS0051.cs  
public class A  
{  
    // Try making B public since F is public  
    // B is implicitly private here  
    class B  
    {  
    }  
  
    public static void F(B b)  // CS0051  
    {  
    }  
  
    public static void Main()  
    {  
    }  
}  
```