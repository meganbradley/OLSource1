---
title: "How to: Explicitly Implement Members of Two Interfaces (C# Programming Guide)"
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
  - inheritance [C#], explicitly implementing interface members
  - interfaces [C#], explicitly implementing with inheritance
ms.assetid: 8b402ddc-dff9-4869-89cb-d718c764e68e
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Explicitly Implement Members of Two Interfaces (C# Programming Guide)
Explicit [interface](../vs140/interface--csharp-reference-.md) implementation also allows the programmer to implement two interfaces that have the same member names and give each interface member a separate implementation. This example displays the dimensions of a box in both metric and English units. The Box [class](../vs140/class--csharp-reference-.md) implements two interfaces IEnglishDimensions and IMetricDimensions, which represent the different measurement systems. Both interfaces have identical member names, Length and Width.  
  
## Example  
 [!code[csProgGuideInheritance#9](../vs140/codesnippet/CSharp/how-to--explicitly-implement-members-of-two-interfaces--csharp-programming-guide-_1.cs)]
  
  
## Robust Programming  
 If you want to make the default measurements in English units, implement the methods Length and Width normally, and explicitly implement the Length and Width methods from the IMetricDimensions interface:  
  
 [!code[csProgGuideInheritance#10](../vs140/codesnippet/CSharp/how-to--explicitly-implement-members-of-two-interfaces--csharp-programming-guide-_2.cs)]
  
  
 In this case, you can access the English units from the class instance and access the metric units from the interface instance:  
  
 [!code[csProgGuideInheritance#11](../vs140/codesnippet/CSharp/how-to--explicitly-implement-members-of-two-interfaces--csharp-programming-guide-_3.cs)]
  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Interfaces (Visual C#)](../vs140/interfaces--csharp-programming-guide-.md)   
 [How to: Explicitly Implement Interface Members (C#)](../vs140/how-to--explicitly-implement-interface-members--csharp-programming-guide-.md)