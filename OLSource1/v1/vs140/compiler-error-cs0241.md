---
title: "Compiler Error CS0241"
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
  - "CS0241"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "default method parameter values"
  - "defaults, parameter values"
  - "defaults, method parameter values"
  - "default parameter values"
  - "CS0241"
ms.assetid: be31b194-3de5-4aab-b23a-6cf790f940ab
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0241
Default parameter specifiers are not permitted  
  
 [Method parameters](../vs140/method-parameters--csharp-reference-.md) cannot have default values. Use method overloads if you want to achieve the same effect. For more information, see [Passing Parameters (C# Programmer's Reference)](../vs140/passing-parameters--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0241. In addition, the sample shows how to simulate, with overloading, a method with default arguments.  
  
```  
// CS0241.cs  
public class A  
{  
   public void Test(int i = 9) {}   // CS0241  
}  
  
public class B  
{  
   public void Test() { Test(9); }  
   public void Test(int i)  {}  
}  
  
public class C  
{  
   public static void Main()  
   {   
      B x = new B();  
      x.Test();  
   }  
}  
```