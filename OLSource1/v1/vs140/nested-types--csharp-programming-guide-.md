---
title: "Nested Types (C# Programming Guide)"
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
  - "nested types [C#]"
ms.assetid: f2e1b315-e3d1-48ce-977f-7bae0960ba99
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nested Types (C# Programming Guide)
A type defined within a [class](../vs140/class--csharp-reference-.md) or [struct](../vs140/struct--csharp-reference-.md) is called a nested type. For example:  
  
 [!code[csProgGuideObjects#68](../vs140/codesnippet/CSharp/nested-types--csharp-programming-guide-_1.cs)]  
  
 Regardless of whether the outer type is a class or a struct, nested types default to [private](../vs140/private--csharp-reference-.md), but can be made [public](../vs140/public--csharp-reference-.md), protected internal, [protected](../vs140/protected--csharp-reference-.md), [internal](../vs140/internal--csharp-reference-.md), or [private](../vs140/private--csharp-reference-.md). In the previous example, `Nested` is inaccessible to external types, but can be made public like this:  
  
 [!code[csProgGuideObjects#69](../vs140/codesnippet/CSharp/nested-types--csharp-programming-guide-_2.cs)]  
  
 The nested, or inner type can access the containing, or outer type. To access the containing type, pass it as a constructor to the nested type. For example:  
  
 [!code[csProgGuideObjects#70](../vs140/codesnippet/CSharp/nested-types--csharp-programming-guide-_3.cs)]  
  
 A nested type has access to all of the members that are accessible to its containing type. It can access private and protected members of the containing type, including any inherited protected members.  
  
 In the previous declaration, the full name of class `Nested` is `Container.Nested`. This is the name used to create a new instance of the nested class, as follows:  
  
 [!code[csProgGuideObjects#71](../vs140/codesnippet/CSharp/nested-types--csharp-programming-guide-_4.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Classes and Structs (Visual C#)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Access Modifiers (Visual C#)](../vs140/access-modifiers--csharp-programming-guide-.md)   
 [Constructors (C# Programming Guide)](../vs140/constructors--csharp-programming-guide-.md)