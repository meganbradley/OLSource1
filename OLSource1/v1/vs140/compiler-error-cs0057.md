---
title: "Compiler Error CS0057"
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
  - "CS0057"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0057"
ms.assetid: 0bdd628f-7a1f-4209-bb28-c4a66eb3bf1d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0057
Inconsistent accessibility: parameter type 'type' is less accessible than operator 'operator'  
  
 A public construct must return a publicly accessible object. For more information, see [Access Modifiers (C# Programmer's Reference)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
 The following sample generates CS0057:  
  
```  
// CS0057.cs  
class MyClass //defaults to private accessibility  
// try the following line instead  
// public class MyClass  
{  
}  
  
public class MyClass2  
{  
   public static implicit operator MyClass2(MyClass iii)   // CS0057  
   {  
      return new MyClass2();  
   }  
  
   public static void Main()  
   {  
   }  
}  
```