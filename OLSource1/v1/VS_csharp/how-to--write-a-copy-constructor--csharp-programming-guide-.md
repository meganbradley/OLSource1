---
title: "How to: Write a Copy Constructor (C# Programming Guide)"
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
  - "C# Language, copy constructor"
  - "copy constructor [C#]"
ms.assetid: fba899b5-fc41-428e-a745-3ebdbf37990a
caps.latest.revision: 20
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
# How to: Write a Copy Constructor (C# Programming Guide)
C# doesn't provide a copy constructor for objects, but you can write one yourself.  
  
## Example  
 In the following example, the `Person`[class](../VS_csharp/class--csharp-reference-.md) defines a copy constructor that takes, as its argument, an instance of `Person`. The values of the properties of the argument are assigned to the properties of the new instance of `Person`. The code contains an alternative copy constructor that sends the `Name` and `Age` properties of the instance that you want to copy to the instance constructor of the class.  
  
 [!code[csProgGuideObjects#16](../VS_csharp/codesnippet/CSharp/how-to--write-a-copy-constructor--csharp-programming-guide-_1.cs)]  
  
## See Also  
 \<xref:System.ICloneable>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Classes and Structs](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)   
 [Constructors](../VS_csharp/constructors--csharp-programming-guide-.md)   
 [Destructors](../VS_csharp/destructors--csharp-programming-guide-.md)