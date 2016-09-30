---
title: "Loops: for...in Expression (F#)"
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
  - "in keyword [F#]"
  - "loops [F#]"
  - "for keyword [F#]"
ms.assetid: 9675be52-5da2-4407-9e5c-c9caa44a2bd8
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Loops: for...in Expression (F#)
This looping construct is used to iterate over the matches of a pattern in an enumerable collection such as a range expression, sequence, list, array, or other construct that supports enumeration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression can be compared to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement in other .NET languages because it is used to loop over the values in an enumerable collection. However, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> also supports pattern matching over the collection instead of just iteration over the whole collection.  
  
 The enumerable expression can be specified as an enumerable collection or, by using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operator, as a range on an integral type. Enumerable collections include lists, sequences, arrays, sets, maps, and so on. Any type that implements \<xref:System.Collections.IEnumerable*> can be used.  
  
 When you express a range by using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator, you can use the following syntax.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> .. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 You can also use a version that includes an increment called the *skip*, as in the following code.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> .. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> .. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 When you use integral ranges and a simple counter variable as a pattern, the typical behavior is to increment the counter variable by 1 on each iteration, but if the range includes a skip value, the counter is incremented by the skip value instead.  
  
 Values matched in the pattern can also be used in the body expression.  
  
 The following code examples illustrate the use of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> expression.  
  
 [!code[FsLangRef2#5201](../vs140/codesnippet/FSharp/loops--for...in-expression--fsharp-_1.fs)]  
  
 The output is as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following example shows how to loop over a sequence, and how to use a tuple pattern instead of a simple variable.  
  
 [!code[FsLangRef2#5202](../vs140/codesnippet/FSharp/loops--for...in-expression--fsharp-_2.fs)]  
  
 The output is as follows.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example shows how to loop over a simple integer range.  
  
 [!code[FsLangRef2#5203](../vs140/codesnippet/FSharp/loops--for...in-expression--fsharp-_3.fs)]  
  
 The output of function1 is as follows.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following example shows how to loop over a range with a skip of 2, which includes every other element of the range.  
  
 [!code[FsLangRef2#5204](../vs140/codesnippet/FSharp/loops--for...in-expression--fsharp-_4.fs)]  
  
 The output of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is as follows.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The following example shows how to use a character range.  
  
 [!code[FsLangRef2#5205](../vs140/codesnippet/FSharp/loops--for...in-expression--fsharp-_5.fs)]  
  
 The output of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is as follows.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The following example shows how to use a negative skip value for a reverse iteration.  
  
 [!code[FsLangRef2#5208](../vs140/codesnippet/FSharp/loops--for...in-expression--fsharp-_6.fs)]  
  
 The output of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is as follows.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The beginning and ending of the range can also be expressions, such as functions, as in the following code.  
  
 [!code[FsLangRef2#5206](../vs140/codesnippet/FSharp/loops--for...in-expression--fsharp-_7.fs)]  
  
 The output of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> with this input is as follows.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The next example shows the use of a wildcard character (_) when the element is not needed in the loop.  
  
 [!code[FsLangRef2#5207](../vs140/codesnippet/FSharp/loops--for...in-expression--fsharp-_8.fs)]  
  
 The output is as follows.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 **Note** You can use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in sequence expressions and other computation expressions, in which case a customized version of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> expression is used. For more information, see [Sequences (F#)](../vs140/sequences--fsharp-.md), [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md), and [Computation Expressions (F#)](../vs140/computation-expressions--fsharp-.md).  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Loops: for .. to Expression](../vs140/loops--for...to-expression--fsharp-.md)   
 [Loops: while...do Expression](../vs140/loops--while...do-expression--fsharp-.md)