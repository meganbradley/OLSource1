---
title: "switch (C# Reference)"
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
  - "switch_CSharpKeyword"
  - "switch"
  - "case"
  - "case_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "switch statement [C#]"
  - "switch keyword [C#]"
  - "case statement [C#]"
  - "default keyword [C#]"
ms.assetid: 44bae8b8-8841-4d85-826b-8a94277daecb
caps.latest.revision: 51
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# switch (C# Reference)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement is a control statement that selects a *switch section* to execute from a list of candidates.  
  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement includes one or more switch sections. Each switch section contains one or more *case labels* followed by one or more statements. The following example shows a simple <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement that has three switch sections. Each switch section has one case label, such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and two statements.  
  
 [!code[csrefKeywordsSelection#7](../vs140/codesnippet/CSharp/switch--csharp-reference-_1.cs)]  
  
## Remarks  
 Each case label specifies a constant value. The switch statement transfers control to the switch section whose case label matches the value of the *switch expression* (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the example). If no case label contains a matching value, control is transferred to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> section, if there is one. If there is no <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section, no action is taken and control is transferred outside the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement. In the previous example, the statements in the first switch section are executed because <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> matches the value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement can include any number of switch sections, and each section can have one or more case labels (as shown in the string case labels example below). However, no two case labels may contain the same constant value.  
  
 Execution of the statement list in the selected switch section begins with the first statement and proceeds through the statement list, typically until a jump statement, such as a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, is reached. At that point, control is transferred outside the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement or to another case label.  
  
 Unlike C++, C# does not allow execution to continue from one switch section to the next. The following code causes an error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C# requires the end of switch sections, including the final one, to be unreachable.  That is, unlike some other languages, your code may not fall through into the next switch section.  Although this requirement is usually met by using a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement, the following case is also valid, because it ensures that the end of the statement list cannot be reached.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example illustrates the requirements and capabilities of a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement.  
  
 [!code[csrefKeywordsSelection#9](../vs140/codesnippet/CSharp/switch--csharp-reference-_2.cs)]  
  
## Example  
 In the final example, the string variable, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and string case labels control the flow of execution.  
  
 [!code[csrefKeywordsSelection#8](../vs140/codesnippet/CSharp/switch--csharp-reference-_3.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [switch Statement (C++)](../vs140/switch-statement--c---.md)   
 [if-else](../vs140/if-else--csharp-reference-.md)