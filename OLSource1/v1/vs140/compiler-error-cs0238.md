---
title: "Compiler Error CS0238"
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
  - "CS0238"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0238"
ms.assetid: 9b50c6e2-2c3f-431d-bdb7-557b0ec51626
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0238
'member' cannot be sealed because it is not an override  
  
 [sealed](../vs140/sealed--csharp-reference-.md) was used on a member that was not also marked with [override](../vs140/override--csharp-reference-.md). For more information, see [Inheritance (C# Programmer's Reference)](../vs140/inheritance--csharp-programming-guide-.md).  
  
 The following sample generates CS0238:  
  
```  
// CS0238.cs  
abstract class MyClass  
{  
   public abstract void f();  
}  
  
class MyClass2 : MyClass  
{  
   public static void Main()  
   {  
   }  
  
   public sealed void f() // CS0238  
   // Try the following definition instead:  
   // public override sealed void f()  
   {  
   }  
}  
```