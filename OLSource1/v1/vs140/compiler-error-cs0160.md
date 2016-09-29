---
title: "Compiler Error CS0160"
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
  - "CS0160"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0160"
ms.assetid: 4ef07061-8ef5-42d9-b043-3f81307d569f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0160
A previous catch clause already catches all exceptions of this or of a super type ('type')  
  
 A series of **catch** statements needs to be in decreasing order of derivation. For example, the most derived objects must appear first.  
  
 For more information, see [Exception Handling Statements](../vs140/exception-handling-statements--csharp-reference-.md) and [Exceptions and Exception Handling (C# Programmer's Reference)](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md).  
  
 The following sample generates CS0160:  
  
```  
// CS0160.cs  
public class MyClass2 : System.Exception {}  
public class MyClass  
{  
   public static void Main()  
   {  
      try {}  
  
      catch(System.Exception) {}   // Second-most derived; should be second catch  
      catch(MyClass2) {}   // CS0160  Most derived; should be first catch  
   }  
}  
```