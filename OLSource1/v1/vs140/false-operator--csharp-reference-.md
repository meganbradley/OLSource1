---
title: "false Operator (C# Reference)"
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
  - "false operator keyword [C#]"
ms.assetid: 81a888fd-011e-4589-b242-6c261fea505e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# false Operator (C# Reference)
Returns the [bool](../vs140/bool--csharp-reference-.md) value <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to indicate that an operand is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> otherwise.  
  
 Prior to C# 2.0, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operators were used to create user-defined nullable value types that were compatible with types such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. However, the language now provides built-in support for nullable value types, and whenever possible you should use those instead of overloading the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operators. For more information, see [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md).  
  
 With nullable Booleans, the expression <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is not necessarily equal to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> because one or both of the values might be null. You have to overload both the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operators separately to correctly handle the null values in the expression. The following example shows how to overload and use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operators.  
  
 [!code[csrefKeywordsOperator#16](../vs140/codesnippet/CSharp/false-operator--csharp-reference-_1.cs)]  
  
 A type that overloads the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operators can be used for the controlling expression in [if](../vs140/if-else--csharp-reference-.md), [do](../vs140/do--csharp-reference-.md), [while](../vs140/while--csharp-reference-.md), and [for](../vs140/for--csharp-reference-.md) statements and in [conditional expressions](../vs140/---operator--csharp-reference-.md).  
  
 If a type defines operator <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, it must also define operator [true](../vs140/true--csharp-reference-.md).  
  
 A type cannot directly overload the conditional logical operators [&&](../vs140/---operator--csharp-reference-.md) and [&#124;&#124;](../vs140/---operator--csharp-reference-.md), but an equivalent effect can be achieved by overloading the regular logical operators and operators <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [C# Operators](../vs140/csharp-operators.md)   
 [true](../vs140/true--csharp-reference-.md)