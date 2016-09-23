---
title: "Compiler-Generated Exceptions (C# Programming Guide)"
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
  - exceptions [C#], compiler-generated
ms.assetid: 53b52f97-b366-4ed7-b05b-9eb78096b7f9
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler-Generated Exceptions (C# Programming Guide)
Some exceptions are thrown automatically by the .NET Framework's common language runtime (CLR) when basic operations fail. These exceptions and their error conditions are listed in the following table.  
  
|Exception|Description|  
|---------------|-----------------|  
|<xref:System.ArithmeticException?qualifyHint=False>|A base class for exceptions that occur during arithmetic operations, such as <xref:System.DivideByZeroException?qualifyHint=False> and <xref:System.OverflowException?qualifyHint=False>.|  
|<xref:System.ArrayTypeMismatchException?qualifyHint=False>|Thrown when an array cannot store a given element because the actual type of the element is incompatible with the actual type of the array.|  
|<xref:System.DivideByZeroException?qualifyHint=False>|Thrown when an attempt is made to divide an integral value by zero.|  
|<xref:System.IndexOutOfRangeException?qualifyHint=False>|Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.|  
|<xref:System.InvalidCastException?qualifyHint=False>|Thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime.|  
|<xref:System.NullReferenceException?qualifyHint=False>|Thrown when you attempt to reference an object whose value is [null](../vs140/null--csharp-reference-.md).|  
|<xref:System.OutOfMemoryException?qualifyHint=False>|Thrown when an attempt to allocate memory using the [new](../vs140/new-operator--csharp-reference-.md) operator fails. This indicates that the memory available to the common language runtime has been exhausted.|  
|<xref:System.OverflowException?qualifyHint=False>|Thrown when an arithmetic operation in a `checked` context overflows.|  
|<xref:System.StackOverflowException?qualifyHint=False>|Thrown when the execution stack is exhausted by having too many pending method calls; usually indicates a very deep or infinite recursion.|  
|<xref:System.TypeInitializationException?qualifyHint=False>|Thrown when a static constructor throws an exception and no compatible `catch` clause exists to catch it.|  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Exceptions and Exception Handling (Visual C#)](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md)   
 [Handling Exceptions (Visual C#)](../vs140/exception-handling--csharp-programming-guide-.md)   
 [try-catch (C# Reference)](../vs140/try-catch--csharp-reference-.md)   
 [try-finally (C# Reference)](../vs140/try-finally--csharp-reference-.md)   
 [try-catch-finally (C# Reference)](../vs140/try-catch-finally--csharp-reference-.md)