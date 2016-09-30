---
title: "const (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "const_CSharpKeyword"
  - "const"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "const keyword [C#]"
ms.assetid: 79eb447c-117b-4418-933f-97c50aa472db
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# const (C# Reference)
You use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword to declare a constant field or a constant local. Constant fields and locals aren't variables and may not be modified. Constants can be numbers, Boolean values, strings, or a null reference. Don’t create a constant to represent information that you expect to change at any time. For example, don’t use a constant field to store the price of a service, a product version number, or the brand name of a company. These values can change over time, and because compilers propagate constants, other code compiled with your libraries will have to be recompiled to see the changes. See also the [readonly](../vs140/readonly--csharp-reference-.md) keyword. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type of a constant declaration specifies the type of the members that the declaration introduces. The initializer of a constant local or a constant field must be a constant expression that can be implicitly converted to the target type.  
  
 A constant expression is an expression that can be fully evaluated at compile time. Therefore, the only possible values for constants of reference types are <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and a null reference.  
  
 The constant declaration can declare multiple constants, such as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> modifier is not allowed in a constant declaration.  
  
 A constant can participate in a constant expression, as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
> [!NOTE]
>  The [readonly](../vs140/readonly--csharp-reference-.md) keyword differs from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword. A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field can only be initialized at the declaration of the field. A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> field can be initialized either at the declaration or in a constructor. Therefore, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> fields can have different values depending on the constructor used. Also, although a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> field is a compile-time constant, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> field can be used for run-time constants, as in this line: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Example  
 [!code[csrefKeywordsModifiers#5](../vs140/codesnippet/CSharp/const--csharp-reference-_1.cs)]  
  
## Example  
 This example demonstrates how to use constants as local variables.  
  
 [!code[csrefKeywordsModifiers#6](../vs140/codesnippet/CSharp/const--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [readonly](../vs140/readonly--csharp-reference-.md)