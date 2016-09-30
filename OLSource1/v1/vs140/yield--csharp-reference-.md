---
title: "yield (C# Reference)"
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
  - "yield"
  - "yield_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "yield keyword [C#]"
ms.assetid: 1089194f-9e53-46a2-8642-53ccbe9d414d
caps.latest.revision: 50
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# yield (C# Reference)
When you use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword in a statement, you indicate that the method, operator, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> accessor in which it appears is an iterator. Using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to define an iterator removes the need for an explicit extra class (the class that holds the state for an enumeration, see <xref:System.Collections.Generic.IEnumerator<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>yield<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>expression<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>yield break<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1*>, \<xref:System.Collections.IEnumerator*>, or <xref:System.Collections.Generic.IEnumerator<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>yield<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>object<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>1*> or <xref:System.Collections.Generic.IEnumerator<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>yield break<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>yield break<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>finally<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>IEnumerable<string><CodeContentPlaceHolder>24\</CodeContentPlaceHolder>MyIteratorMethod<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>IEnumerable<string><CodeContentPlaceHolder>26\</CodeContentPlaceHolder>elements<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>elements<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>MyIteratorMethod<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>yield return<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>element<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>1.Current*> property of elements, which is an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 On each subsequent iteration of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> loop, the execution of the iterator body continues from where it left off, again stopping when it reaches a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statement. The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> loop completes when the end of the iterator method or a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> statement is reached.  
  
## Example  
 The following example has a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> statement that's inside a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> loop. Each iteration of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> statement body in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> creates a call to the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> iterator function. Each call to the iterator function proceeds to the next execution of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement, which occurs during the next iteration of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> loop.  
  
 The return type of the iterator method is \<xref:System.Collections.IEnumerable*>, which is an iterator interface type. When the iterator method is called, it returns an enumerable object that contains the powers of a number.  
  
 [!code[csrefKeywordsContextual#5](../vs140/codesnippet/CSharp/yield--csharp-reference-_1.cs)]  
  
## Example  
 The following example demonstrates a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> accessor that is an iterator. In the example, each <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> statement returns an instance of a user-defined class.  
  
 [!code[csrefKeywordsContextual#21](../vs140/codesnippet/CSharp/yield--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [foreach, in](../vs140/foreach--in--csharp-reference-.md)   
 [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md)