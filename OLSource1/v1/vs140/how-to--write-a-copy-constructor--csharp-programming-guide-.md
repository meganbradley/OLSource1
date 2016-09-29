---
title: "How to: Write a Copy Constructor (C# Programming Guide)"
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
  - "C# Language, copy constructor"
  - "copy constructor [C#]"
ms.assetid: fba899b5-fc41-428e-a745-3ebdbf37990a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write a Copy Constructor (C# Programming Guide)
C# doesn't provide a copy constructor for objects, but you can write one yourself.  
  
## Example  
 In the following example, the `Person`[class](../vs140/class--csharp-reference-.md) defines a copy constructor that takes, as its argument, an instance of `Person`. The values of the properties of the argument are assigned to the properties of the new instance of `Person`. The code contains an alternative copy constructor that sends the `Name` and `Age` properties of the instance that you want to copy to the instance constructor of the class.  
  
 [!code[csProgGuideObjects#16](../vs140/codesnippet/CSharp/how-to--write-a-copy-constructor--csharp-programming-guide-_1.cs)]  
  
## See Also  
 <xref:System.ICloneable*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes, and Structs (Visual C#)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Constructors](../vs140/constructors--csharp-programming-guide-.md)   
 [Destructors (C# Programmer's Reference)](../vs140/destructors--csharp-programming-guide-.md)