---
title: "Compiler Error CS0199"
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
  - "CS0199"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0199"
ms.assetid: 9eede3f2-b55a-4b85-a05d-6bf177e1c602
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0199
Fields of static readonly field 'name' cannot be passed ref or out (except in a static constructor)  
  
 A [readonly](../vs140/readonly--csharp-reference-.md) variable must have the same [static](../vs140/static--csharp-reference-.md) usage as the constructor in which you want to pass it as a [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameter. For more information, see [Passing Parameters (C# Programmer's Reference)](../vs140/passing-parameters--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0199:  
  
```  
// CS0199.cs  
class MyClass  
{  
    public static readonly int TestInt = 6;  
  
    static void TestMethod(ref int testInt)  
    {  
        testInt = 0;  
    }  
  
    MyClass()  
    {  
        TestMethod(ref TestInt);   // CS0199, TestInt is static  
    }  
  
    public static void Main()  
    {  
    }  
}  
```