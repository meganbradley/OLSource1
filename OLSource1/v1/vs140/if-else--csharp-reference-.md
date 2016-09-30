---
title: "if-else (C# Reference)"
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
  - "if_CSharpKeyword"
  - "else"
  - "else_CSharpKeyword"
  - "if"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "else keyword [C#]"
  - "if keyword [C#]"
ms.assetid: d9a1d562-8cf5-4bd4-9ba7-8ad970cd25b2
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# if-else (C# Reference)
An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement identifies which statement to run based on the value of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> expression. In the following example, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and then checked in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement. The output is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[csrefKeywordsSelection#1](../vs140/codesnippet/CSharp/if-else--csharp-reference-_1.cs)]  
  
 You can run the examples in this topic by placing them in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method of a console app.  
  
 An <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement in C# can take two forms, as the following example shows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement, if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> evaluates to true, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> runs. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is false, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> runs. Because <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can’t be simultaneously true and false, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> of an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement can never both run. After the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> runs, control is transferred to the next statement after the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement.  
  
 In an <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement that doesn’t include an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement, if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is true, the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> runs. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is false, control is transferred to the next statement after the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement.  
  
 Both the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> can consist of a single statement or multiple statements that are enclosed in braces (<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>). For a single statement, the braces are optional but recommended.  
  
 The statement or statements in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> can be of any kind, including another <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statement nested inside the original <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> statement. In nested <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statements, each <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> clause belongs to the last <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> that doesn’t have a corresponding <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. In the following example, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> appears if both <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> evaluate to true. If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is true but <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is false, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> appears.  
  
 [!code[csrefKeywordsSelection#2](../vs140/codesnippet/CSharp/if-else--csharp-reference-_2.cs)]  
  
 If, instead, you want <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to appear when <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is false, you can specify that association by using braces to establish the start and end of the nested <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> statement, as the following example shows.  
  
 [!code[csrefKeywordsSelection#3](../vs140/codesnippet/CSharp/if-else--csharp-reference-_3.cs)]  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> appears if the condition <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> evaluates to false.  
  
## Example  
 In the following example, you enter a character from the keyboard, and the program uses a nested <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> statement to determine whether the input character is an alphabetic character. If the input character is an alphabetic character, the program checks whether the input character is lowercase or uppercase. A message appears for each case.  
  
 [!code[csrefKeywordsSelection#4](../vs140/codesnippet/CSharp/if-else--csharp-reference-_4.cs)]  
  
## Example  
 You also can nest an <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> statement inside an else block, as the following partial code shows. The example nests <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> statements inside two else blocks and one then block. The comments specify which conditions are true or false in each block.  
  
 [!code[csrefKeywordsSelection#5](../vs140/codesnippet/CSharp/if-else--csharp-reference-_5.cs)]  
  
## Example  
 The following example determines whether an input character is a lowercase letter, an uppercase letter, or a number. If all three conditions are false, the character isn’t an alphanumeric character. The example displays a message for each case.  
  
 [!code[csrefKeywordsSelection#6](../vs140/codesnippet/CSharp/if-else--csharp-reference-_6.cs)]  
  
 Just as a statement in the else block or the then block can be any valid statement, you can use any valid Boolean expression for the condition. You can use logical operators such as [&&](../vs140/---operator--csharp-reference-.md), [&](../vs140/--operator--csharp-reference-.md), [&#124;&#124;](../vs140/---operator--csharp-reference-.md), [&#124;](../vs140/--operator--csharp-reference-.md) and [!](../vs140/!-operator--csharp-reference-.md) to make compound conditions. The following code shows examples.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [?: Operator](../vs140/---operator--csharp-reference-.md)   
 [if-else Statement (C++)](../vs140/if-else-statement--c---.md)   
 [switch](../vs140/switch--csharp-reference-.md)