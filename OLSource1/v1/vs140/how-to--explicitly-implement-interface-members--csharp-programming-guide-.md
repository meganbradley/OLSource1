---
title: "How to: Explicitly Implement Interface Members (C# Programming Guide)"
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
  - interfaces [C#], explicitly implementing
ms.assetid: 514cde76-f981-474e-8b40-9493619f899c
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Explicitly Implement Interface Members (C# Programming Guide)
This example declares an [interface](../vs140/interface--csharp-reference-.md), `IDimensions`, and a class, `Box`, which explicitly implements the interface members `getLength` and `getWidth`. The members are accessed through the interface instance `dimensions`.  
  
## Example  
 [!code[csProgGuideInheritance#8](../vs140/codesnippet/CSharp/how-to--explicitly-implement-interface-members--csharp-programming-guide-_1.cs)]
  
  
## Robust Programming  
  
-   Notice that the following lines, in the `Main` method, are commented out because they would produce compilation errors. An interface member that is explicitly implemented cannot be accessed from a [class](../vs140/class--csharp-reference-.md) instance:  
  
     [!code[csProgGuideInheritance#45](../vs140/codesnippet/CSharp/how-to--explicitly-implement-interface-members--csharp-programming-guide-_2.cs)]
  
  
-   Notice also that the following lines, in the `Main` method, successfully print out the dimensions of the box because the methods are being called from an instance of the interface:  
  
     [!code[csProgGuideInheritance#46](../vs140/codesnippet/CSharp/how-to--explicitly-implement-interface-members--csharp-programming-guide-_3.cs)]
  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Interfaces (Visual C#)](../vs140/interfaces--csharp-programming-guide-.md)   
 [How to: Explicitly Implement Interface Members with Inheritance (C#)](../vs140/how-to--explicitly-implement-members-of-two-interfaces--csharp-programming-guide-.md)