---
title: "using Statement (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - using statement [C#]
ms.assetid: afc355e6-f0b9-4240-94dd-0d93f17d9fc3
caps.latest.revision: 35
translation.priority.ht: 
  - de-de
  - ja-jp
---
# using Statement (C# Reference)
Provides a convenient syntax that ensures the correct use of <xref:System.IDisposable?qualifyHint=False> objects.  
  
## Example  
 The following example shows how to use the using statement.  
  
 [!code[csrefKeywordsNamespace#4](../vs140/codesnippet/CSharp/using-statement--csharp-reference-_1.cs)]
  
  
## Remarks  
 <xref:System.IO.File?qualifyHint=False> and <xref:System.Drawing.Font?qualifyHint=False> are examples of managed types that access unmanaged resources (in this case file handles and device contexts). There are many other kinds of unmanaged resources and class library types that encapsulate them. All such types must implement the <xref:System.IDisposable?qualifyHint=False> interface.  
  
 As a rule, when you use an `IDisposable` object, you should declare and instantiate it in a `using` statement. The `using` statement calls the <xref:System.IDisposable.Dispose?qualifyHint=False> method on the object in the correct way, and (when you use it as shown earlier) it also causes the object itself to go out of scope as soon as <xref:System.IDisposable.Dispose?qualifyHint=False> is called. Within the `using` block, the object is read-only and cannot be modified or reassigned.  
  
 The `using` statement ensures that <xref:System.IDisposable.Dispose?qualifyHint=False> is called even if an exception occurs while you are calling methods on the object. You can achieve the same result by putting the object inside a try block and then calling <xref:System.IDisposable.Dispose?qualifyHint=False> in a finally block; in fact, this is how the `using` statement is translated by the compiler. The code example earlier expands to the following code at compile time (note the extra curly braces to create the limited scope for the object):  
  
 [!code[csrefKeywordsNamespace#5](../vs140/codesnippet/CSharp/using-statement--csharp-reference-_2.cs)]
  
  
 Multiple instances of a type can be declared in a `using` statement, as shown in the following example.  
  
 [!code[csrefKeywordsNamespace#6](../vs140/codesnippet/CSharp/using-statement--csharp-reference-_3.cs)]
  
  
 You can instantiate the resource object and then pass the variable to the `using` statement, but this is not a best practice. In this case, the object remains in scope after control leaves the `using` block even though it will probably no longer have access to its unmanaged resources. In other words, it will no longer be fully initialized. If you try to use the object outside the `using` block, you risk causing an exception to be thrown. For this reason, it is generally better to instantiate the object in the `using` statement and limit its scope to the `using` block.  
  
 [!code[csrefKeywordsNamespace#7](../vs140/codesnippet/CSharp/using-statement--csharp-reference-_4.cs)]
  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [using Directive (C# Reference)](../vs140/using-directive--csharp-reference-.md)   
 [Garbage Collection](assetId:///22b6cb97-0c80-4eeb-a2cf-5ed7655e37f9)   
 [Implementing a Dispose Method](assetId:///eb4e1af0-3b48-4fbc-ad4e-fc2f64138bf9)