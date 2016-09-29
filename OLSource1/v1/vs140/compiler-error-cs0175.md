---
title: "Compiler Error CS0175"
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
  - "CS0175"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0175"
ms.assetid: cedd769d-8258-4235-a321-362981b9f84b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0175
Use of keyword 'base' is not valid in this context  
  
 The [base](../vs140/base--csharp-reference-.md) keyword must be used to specify a particular member of the base class. For more information, see [Constructors (C# Programmer's Reference)](../vs140/constructors--csharp-programming-guide-.md).  
  
 The following sample generates CS0175:  
  
```  
// CS0175.cs  
using System;  
class BaseClass  
{  
    public int TestInt = 0;  
}  
  
class MyClass : BaseClass  
{  
    public static void Main()  
    {  
        MyClass aClass = new MyClass();  
        aClass.BaseTest();  
    }  
  
    public void BaseTest()  
    {  
        Console.WriteLine(base); // CS0175  
        // Try the following line instead:  
        // Console.WriteLine(base.TestInt);  
        base = 9;   // CS0175  
  
        // Try the following line instead:  
        // base.TestInt = 9;  
    }  
}  
```