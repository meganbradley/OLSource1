---
title: "Compiler Error CS0059"
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
  - "CS0059"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0059"
ms.assetid: 25a8624b-7f7b-4487-ba80-413d57f9132b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0059
Inconsistent accessibility: parameter type 'type' is less accessible than delegate 'delegate'  
  
 The return type and each of the types referenced in the formal parameter list of a method must be at least as accessible as the method itself. For more information, see [Access Modifiers (C# Programmer's Reference)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0059:  
  
```  
// CS0059.cs  
class MyClass //defaults to private accessibility  
// try the following line instead  
// public class MyClass  
{  
}  
  
public delegate void MyClassDel( MyClass myClass);   // CS0059  
  
public class Program  
{  
    public static void Main()  
    {  
    }  
}  
```