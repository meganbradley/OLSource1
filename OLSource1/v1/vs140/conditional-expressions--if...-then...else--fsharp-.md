---
title: "Conditional Expressions: if... then...else (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "elif keyword [F#]"
  - "if...then...else expressions [F#]"
  - "else keyword [F#]"
  - "then keyword [F#]"
  - "if keyword [F#]"
ms.assetid: af9f36de-21eb-476c-af03-db4bce95ee72
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conditional Expressions: if... then...else (F#)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expression runs different branches of code and also evaluates to a different value depending on the Boolean expression given.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the previous syntax, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> runs when the Boolean expression evaluates to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> runs.  
  
 Unlike in other languages, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> construct is an expression, not a statement. That means that it produces a value, which is the value of the last expression in the branch that executes. The types of the values produced in each branch must match. If there is no explicit <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> branch, its type is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Therefore, if the type of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> branch is any type other than <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, there must be an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> branch with the same return type. When chaining <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> expressions together, you can use the keyword <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>; they are equivalent.  
  
## Example  
 The following example illustrates how to use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> expression.  
  
 [!code[FsLangRef2#4501](../vs140/codesnippet/FSharp/conditional-expressions--if...-then...else--fsharp-_1.fs)]  
  
  **<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>10 is less than 20**  
**You are only 9 years old and already learning F#? Wow!**   
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)