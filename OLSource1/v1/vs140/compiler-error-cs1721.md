---
title: "Compiler Error CS1721"
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
  - "CS1721"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1721"
ms.assetid: f02dc9b1-8e38-4562-b013-4d752ad79061
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1721
Class 'class' cannot have multiple base classes: 'class_1' and 'class_2'  
  
 The most common cause of this error message is attempting to use multiple inheritance. A class in C# may only inherit directly from one class. However, a class can implement any number of interfaces.  
  
## Example  
 The following example shows one way in which SC1721 is generated, and then shows two possible ways to avoid the error.  
  
```  
// CS1721.cs  
public class A {}  
public class B {}  
public class MyClass : A, B {}   // CS1721  
  
// One possible fix is to use the following approach instead:  
public class A {}  
public class B : A {}  
public class C : B {}  
  
// Another possible fix is to use interfaces instead of base classes:  
public class A {}  
public interface B {}  
public class C : A, B {}  
  
```  
  
## See Also  
 [Polymorphism (C# Programming Guide)](../vs140/polymorphism--csharp-programming-guide-.md)   
 [Interfaces (C# Programming Guide)](../vs140/interfaces--csharp-programming-guide-.md)