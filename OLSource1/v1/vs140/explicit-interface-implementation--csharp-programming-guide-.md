---
title: "Explicit Interface Implementation (C# Programming Guide)"
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
  - "explicit interfaces [C#]"
  - "interfaces [C#], explicit"
ms.assetid: 181c901f-0d4c-4f29-97fc-895079617bf2
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Interface Implementation (C# Programming Guide)
If a [class](../vs140/class--csharp-reference-.md) implements two interfaces that contain a member with the same signature, then implementing that member on the class will cause both interfaces to use that member as their implementation. In the following example, all the calls to `Paint` invoke the same method.  
  
 [!code[csProgGuideInheritance#39](../vs140/codesnippet/CSharp/explicit-interface-implementation--csharp-programming-guide-_1.cs)]  
  
 If the two [interface](../vs140/interface--csharp-reference-.md) members do not perform the same function, however, this can lead to an incorrect implementation of one or both of the interfaces. It is possible to implement an interface member explicitly—creating a class member that is only called through the interface, and is specific to that interface. This is accomplished by naming the class member with the name of the interface and a period. For example:  
  
 [!code[csProgGuideInheritance#40](../vs140/codesnippet/CSharp/explicit-interface-implementation--csharp-programming-guide-_2.cs)]  
  
 The class member `IControl.Paint` is only available through the `IControl` interface, and `ISurface.Paint` is only available through `ISurface`. Both method implementations are separate, and neither is available directly on the class. For example:  
  
 [!code[csProgGuideInheritance#41](../vs140/codesnippet/CSharp/explicit-interface-implementation--csharp-programming-guide-_3.cs)]  
  
 Explicit implementation is also used to resolve cases where two interfaces each declare different members of the same name such as a property and a method:  
  
 [!code[csProgGuideInheritance#42](../vs140/codesnippet/CSharp/explicit-interface-implementation--csharp-programming-guide-_4.cs)]  
  
 To implement both interfaces, a class has to use explicit implementation either for the property P, or the method P, or both, to avoid a compiler error. For example:  
  
 [!code[csProgGuideInheritance#43](../vs140/codesnippet/CSharp/explicit-interface-implementation--csharp-programming-guide-_5.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Interfaces (Visual C#)](../vs140/interfaces--csharp-programming-guide-.md)   
 [Inheritance (Visual C#)](../vs140/inheritance--csharp-programming-guide-.md)