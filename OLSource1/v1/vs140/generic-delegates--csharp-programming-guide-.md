---
title: "Generic Delegates (C# Programming Guide)"
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
  - "generics [C#], delegates"
  - "delegates [C#], generic"
ms.assetid: bdea509c-44c1-4309-aaa9-15c7aee009df
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Delegates (C# Programming Guide)
A [delegate](../vs140/delegate--csharp-reference-.md) can define its own type parameters. Code that references the generic delegate can specify the type argument to create a closed constructed type, just like when instantiating a generic class or calling a generic method, as shown in the following example:  
  
 [!code[csProgGuideGenerics#36](../vs140/codesnippet/CSharp/generic-delegates--csharp-programming-guide-_1.cs)]  
  
 C# version 2.0 has a new feature called method group conversion, which applies to concrete as well as generic delegate types, and enables you to write the previous line with this simplified syntax:  
  
 [!code[csProgGuideGenerics#37](../vs140/codesnippet/CSharp/generic-delegates--csharp-programming-guide-_2.cs)]  
  
 Delegates defined within a generic class can use the generic class type parameters in the same way that class methods do.  
  
 [!code[csProgGuideGenerics#38](../vs140/codesnippet/CSharp/generic-delegates--csharp-programming-guide-_3.cs)]  
  
 Code that references the delegate must specify the type argument of the containing class, as follows:  
  
 [!code[csProgGuideGenerics#39](../vs140/codesnippet/CSharp/generic-delegates--csharp-programming-guide-_4.cs)]  
  
 Generic delegates are especially useful in defining events based on the typical design pattern because the sender argument can be strongly typed and no longer has to be cast to and from \<xref:System.Object*>.  
  
 [!code[csProgGuideGenerics#40](../vs140/codesnippet/CSharp/generic-delegates--csharp-programming-guide-_5.cs)]  
  
## See Also  
 \<xref:System.Collections.Generic*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics (C#)](../vs140/introduction-to-generics--csharp-programming-guide-.md)   
 [Generic Methods (C#)](../vs140/generic-methods--csharp-programming-guide-.md)   
 [Generic Classes (C#)](../vs140/generic-classes--csharp-programming-guide-.md)   
 [Generic Interfaces (C#)](../vs140/generic-interfaces--csharp-programming-guide-.md)   
 [Delegates (Visual C#)](../vs140/delegates--csharp-programming-guide-.md)   
 [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)