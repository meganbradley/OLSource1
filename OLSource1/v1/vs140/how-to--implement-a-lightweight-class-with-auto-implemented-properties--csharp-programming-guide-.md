---
title: "How to: Implement a Lightweight Class with Auto-Implemented Properties (C# Programming Guide)"
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
  - "auto-implemented properties [C#]"
  - "properties [C#], auto-implemented"
ms.assetid: 1dc5a8ad-a4f7-4f32-8506-3fc6d8c8bfed
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement a Lightweight Class with Auto-Implemented Properties (C# Programming Guide)
This example shows how to create an immutable lightweight class that serves only to encapsulate a set of auto-implemented properties. Use this kind of construct instead of a struct when you must use reference type semantics.  
  
 You can make an immutable property in two ways.  You can declare the [set](../vs140/set--csharp-reference-.md) accessor.to be [private](../vs140/private--csharp-reference-.md).  The property is only settable within the type, but it is immutable to consumers.  You can instead declare only the [get](../vs140/get--csharp-reference-.md) accessor, which makes the property immutable everywhere except in the type’s constructor.  
  
 When you declare a private <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> accessor, you cannot use an object initializer to initialize the property. You must use a constructor or a factory method.  
  
## Example  
 The following example shows two ways to implement an immutable class that has auto-implemented properties. Each way declares one of the properties with a private <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and one of the properties with a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> only.  The first class uses a constructor only to initialize the properties, and the second class uses a static factory method that calls a constructor.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The compiler creates backing fields for each auto-implemented property. The fields are not accessible directly from source code.  
  
## See Also  
 [Properties (C# Programming Guide)](../vs140/properties--csharp-programming-guide-.md)   
 [struct (C# Reference)](../vs140/struct--csharp-reference-.md)   
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)