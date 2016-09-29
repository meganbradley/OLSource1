---
title: "Interface Properties (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "properties [C#], on interfaces"
  - "interfaces [C#], properties"
ms.assetid: 6503e9ed-33d7-44ec-b4c1-cc16c084b795
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interface Properties (C# Programming Guide)
Properties can be declared on an [interface (C# Reference)](../vs140/interface--csharp-reference-.md). The following is an example of an interface indexer accessor:  
  
 [!code[csProgGuideProperties#14](../vs140/codesnippet/CSharp/interface-properties--csharp-programming-guide-_1.cs)]  
  
 The accessor of an interface property does not have a body. Thus, the purpose of the accessors is to indicate whether the property is read-write, read-only, or write-only.  
  
## Example  
 In this example, the interface `IEmployee` has a read-write property, `Name`, and a read-only property, `Counter`. The class `Employee` implements the `IEmployee` interface and uses these two properties. The program reads the name of a new employee and the current number of employees and displays the employee name and the computed employee number.  
  
 You could use the fully qualified name of the property, which references the interface in which the member is declared. For example:  
  
 [!code[csProgGuideProperties#16](../vs140/codesnippet/CSharp/interface-properties--csharp-programming-guide-_2.cs)]  
  
 This is called [Explicit Interface Implementation (C# Programmers Reference)](../vs140/explicit-interface-implementation--csharp-programming-guide-.md). For example, if the class `Employee` is implementing two interfaces `ICitizen` and `IEmployee` and both interfaces have the `Name` property, the explicit interface member implementation will be necessary. That is, the following property declaration:  
  
 [!code[csProgGuideProperties#16](../vs140/codesnippet/CSharp/interface-properties--csharp-programming-guide-_2.cs)]  
  
 implements the `Name` property on the `IEmployee` interface, while the following declaration:  
  
 [!code[csProgGuideProperties#17](../vs140/codesnippet/CSharp/interface-properties--csharp-programming-guide-_3.cs)]  
  
 implements the `Name` property on the `ICitizen` interface.  
  
 [!code[csProgGuideProperties#15](../vs140/codesnippet/CSharp/interface-properties--csharp-programming-guide-_4.cs)]  
  
  **`210 Hazem Abolrous`**    
## Sample Output  
 `Enter number of employees: 210`  
  
 `Enter the name of the new employee: Hazem Abolrous`  
  
 `The employee information:`  
  
 `Employee number: 211`  
  
 `Employee name: Hazem Abolrous`  
  
## See Also  
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Properties (C# Programmer's Reference)](../vs140/properties--csharp-programming-guide-.md)   
 [Using Properties (C# Programmer's Reference)](../vs140/using-properties--csharp-programming-guide-.md)   
 [Comparison Between Properties and Indexers](../vs140/comparison-between-properties-and-indexers--csharp-programming-guide-.md)   
 [Indexers](../vs140/indexers--csharp-programming-guide-.md)   
 [Interfaces (C# Programming Guide)](../vs140/interfaces--csharp-programming-guide-.md)