---
title: "new Constraint (C# Reference)"
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
  - new constraint keyword [C#]
ms.assetid: 58850b64-cb97-4136-be50-1f3bc7fc1da9
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# new Constraint (C# Reference)
The `new` constraint specifies that any type argument in a generic class declaration must have a public parameterless constructor. To use the new constraint, the type cannot be abstract.  
  
## Example  
 Apply the `new` constraint to a type parameter when your generic class creates new instances of the type, as shown in the following example:  
  
 [!code[csrefKeywordsOperator#5](../vs140/codesnippet/CSharp/new-constraint--csharp-reference-_1.cs)]
  
  
## Example  
 When you use the `new()` constraint with other constraints, it must be specified last:  
  
 [!code[csrefKeywordsOperator#6](../vs140/codesnippet/CSharp/new-constraint--csharp-reference-_2.cs)]
  
  
 For more information, see [Constraints on Type Parameters (C# Programming Guide)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 <xref:System.Collections.Generic?qualifyHint=False>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Operator Keywords](../vs140/operator-keywords--csharp-reference-.md)   
 [Generics (C# Programming Guide)](../vs140/generics--csharp-programming-guide-.md)