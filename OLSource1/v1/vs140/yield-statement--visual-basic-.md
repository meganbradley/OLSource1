---
title: "Yield Statement (Visual Basic)"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Yield"
helpviewer_keywords: 
  - "iterators, Yield statement [Visual Basic]"
  - "iterators [Visual Basic]"
  - "Yield statement [Visual Basic]"
ms.assetid: f33126c5-d7c4-43e2-8e36-4ae3f0703d97
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Yield Statement (Visual Basic)
Sends the next element of a collection to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required. An expression that is implicitly convertible to the type of the iterator function or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> accessor that contains the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.|  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement returns one element of a collection at a time. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement is included in an iterator function or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> accessor, which perform custom iterations over a collection.  
  
 You consume an iterator function by using a [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md) or a LINQ query. Each iteration of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> loop calls the iterator function. When a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement is reached in the iterator function, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is returned, and the current location in code is retained. Execution is restarted from that location the next time that the iterator function is called.  
  
 An implicit conversion must exist from the type of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement to the return type of the iterator.  
  
 You can use an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement to end the iteration.  
  
 "Yield" is not a reserved word and has special meaning only when it is used in an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> accessor.  
  
 For more information about iterator functions and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> accessors, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
## Iterator Functions and Get Accessors  
 The declaration of an iterator function or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> accessor must meet the following requirements:  
  
-   It must include an [Iterator](../vs140/iterator--visual-basic-.md) modifier.  
  
-   The return type must be \<xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>1*>.  
  
-   It cannot have any <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameters.  
  
 An iterator function cannot occur in an event, instance constructor, static constructor, or static destructor.  
  
 An iterator function can be an anonymous function. For more information, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
## Exception Handling  
 A <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement can be inside a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> block of a [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md). A <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> block that has a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement can have <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> blocks, and can have a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> block.  
  
 A <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement cannot be inside a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> block or a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> block.  
  
 If the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> body (outside of the iterator function) throws an exception, a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block in the iterator function is not executed, but a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> block in the iterator function is executed. A <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> block inside an iterator function catches only exceptions that occur inside the iterator function.  
  
## Technical Implementation  
 The following code returns an <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> from an iterator function and then iterates through the elements of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The call to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> doesn't execute the body of the function. Instead the call returns an <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> variable.  
  
 On an iteration of the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> loop, the \<xref:System.Collections.IEnumerator.MoveNext*> method is called for <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. This call executes the body of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> until the next <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> statement is reached. The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement returns an expression that determines not only the value of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> variable for consumption by the loop body but also the <xref:System.Collections.Generic.IEnumerator<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>IEnumerable (Of String)<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>Yield<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>For Each<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>Return<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>Exit Function<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>Yield<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>Main<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>Power<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>Yield<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>For…Next<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>1*>, an iterator interface type. When the iterator method is called, it returns an enumerable object that contains the powers of a number.  
  
 [!code[VbVbalrStatements#98](../vs140/codesnippet/VisualBasic/yield-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example demonstrates a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> accessor that is an iterator. The property declaration includes an <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> modifier.  
  
 [!code[VbVbalrStatements#99](../vs140/codesnippet/VisualBasic/yield-statement--visual-basic-_2.vb)]  
  
 For additional examples, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
## Requirements  
 [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)]  
  
## See Also  
 [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md)   
 [Statements (Visual Basic)](../vs140/statements--visual-basic-.md)