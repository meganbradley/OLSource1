---
title: "readonly (C# Reference)"
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
  - "readonly_CSharpKeyword"
  - "readonly"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "readonly keyword [C#]"
ms.assetid: 2f8081f6-0de2-4903-898d-99696c48d2f4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# readonly (C# Reference)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword is a modifier that you can use on fields. When a field declaration includes a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier, assignments to the fields introduced by the declaration can only occur as part of the declaration or in a constructor in the same class.  
  
## Example  
 In this example, the value of the field <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be changed in the method <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, even though it is assigned a value in the class constructor:  
  
 [!code[csrefKeywordsModifiers#14](../vs140/codesnippet/CSharp/readonly--csharp-reference-_1.cs)]  
  
 You can assign a value to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field only in the following contexts:  
  
-   When the variable is initialized in the declaration, for example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   For an instance field, in the instance constructors of the class that contains the field declaration, or for a static field, in the static constructor of the class that contains the field declaration. These are also the only contexts in which it is valid to pass a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field as an [out](../vs140/out--csharp-reference-.md) or [ref](../vs140/ref--csharp-reference-.md) parameter.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword is different from the [const](../vs140/const--csharp-reference-.md) keyword. A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field can only be initialized at the declaration of the field. A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> field can be initialized either at the declaration or in a constructor. Therefore, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> fields can have different values depending on the constructor used. Also, while a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> field is a compile-time constant, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field can be used for runtime constants as in the following example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 [!code[csrefKeywordsModifiers#15](../vs140/codesnippet/CSharp/readonly--csharp-reference-_2.cs)]  
  
 In the preceding example, if you use a statement like this:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 you will get the compiler error message:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 which is the same error you get when you attempt to assign a value to a constant.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [const (C# Programmer's Reference)](../vs140/const--csharp-reference-.md)   
 [Properties and Fields (C#)](../vs140/fields--csharp-programming-guide-.md)