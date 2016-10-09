---
title: "How to: Explicitly Implement Members of Two Interfaces (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "inheritance [C#], explicitly implementing interface members"
  - "interfaces [C#], explicitly implementing with inheritance"
ms.assetid: 8b402ddc-dff9-4869-89cb-d718c764e68e
caps.latest.revision: 15
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Explicitly Implement Members of Two Interfaces (C# Programming Guide)
Explicit [interface](../VS_csharp/interface--csharp-reference-.md) implementation also allows the programmer to implement two interfaces that have the same member names and give each interface member a separate implementation. This example displays the dimensions of a box in both metric and English units. The Box [class](../VS_csharp/class--csharp-reference-.md) implements two interfaces IEnglishDimensions and IMetricDimensions, which represent the different measurement systems. Both interfaces have identical member names, Length and Width.  
  
## Example  
 [!code[csProgGuideInheritance#9](../VS_csharp/codesnippet/CSharp/how-to--explicitly-implement-members-of-two-interfaces--csharp-programming-guide-_1.cs)]  
  
## Robust Programming  
 If you want to make the default measurements in English units, implement the methods Length and Width normally, and explicitly implement the Length and Width methods from the IMetricDimensions interface:  
  
 [!code[csProgGuideInheritance#10](../VS_csharp/codesnippet/CSharp/how-to--explicitly-implement-members-of-two-interfaces--csharp-programming-guide-_2.cs)]  
  
 In this case, you can access the English units from the class instance and access the metric units from the interface instance:  
  
 [!code[csProgGuideInheritance#11](../VS_csharp/codesnippet/CSharp/how-to--explicitly-implement-members-of-two-interfaces--csharp-programming-guide-_3.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Classes and Structs](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)   
 [Interfaces](../VS_csharp/interfaces--csharp-programming-guide-.md)   
 [How to: Explicitly Implement Interface Members](../VS_csharp/how-to--explicitly-implement-interface-members--csharp-programming-guide-.md)