---
title: "Match Expressions (F#)"
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
  - "pattern matching [F#]"
  - "match expression [F#]"
ms.assetid: dab9b934-5528-4283-8986-794d832f0a0b
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Match Expressions (F#)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expression provides branching control that is based on the comparison of an expression with a set of patterns.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The pattern matching expressions allow for complex branching based on the comparison of a test expression with a set of patterns. In the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is compared with each pattern in turn, and when a match is found, the corresponding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is evaluated and the resulting value is returned as the value of the match expression.  
  
 The pattern matching function shown in the previous syntax is a lambda expression in which pattern matching is performed immediately on the argument. The pattern matching function shown in the previous syntax is equivalent to the following.  
  
 fun <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> ->  
  
 match <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with  
  
 &#124; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> [ when <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> ] -> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 &#124; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> [ when <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> ]-> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 &#124; ...  
  
 For more information about lambda expressions, see [Lambda Expressions: The fun keyword](../vs140/lambda-expressions--the-fun-keyword--fsharp-.md).  
  
 The whole set of patterns should cover all the possible matches of the input variable. Frequently, you use the wildcard pattern (_) as the last pattern to match any previously unmatched input values.  
  
 The following code illustrates some of the ways in which the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> expression is used. For a reference and examples of all the possible patterns that can be used, see [Patterns](../vs140/pattern-matching--fsharp-.md).  
  
 [!code[FsLangRef2#4601](../vs140/codesnippet/FSharp/match-expressions--fsharp-_1.fs)]  
  
## Guards on Patterns  
 You can use a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause to specify an additional condition that the variable must satisfy to match a pattern. Such a clause is referred to as a *guard*. The expression following the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword is not evaluated unless a match is made to the pattern associated with that guard.  
  
 The following example illustrates the use of a guard to specify a numeric range for a variable pattern. Note that multiple conditions are combined by using Boolean operators.  
  
 [!code[FsLangRef2#4602](../vs140/codesnippet/FSharp/match-expressions--fsharp-_2.fs)]  
  
 Note that because values other than literals cannot be used in the pattern, you must use a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> clause if you have to compare some part of the input against a value. This is shown in the following code.  
  
 [!code[FsLangRef2#4603](../vs140/codesnippet/FSharp/match-expressions--fsharp-_3.fs)]  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Active Patterns](../vs140/active-patterns--fsharp-.md)