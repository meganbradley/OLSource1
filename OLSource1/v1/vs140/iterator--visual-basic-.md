---
title: "Iterator (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Iterator"
helpviewer_keywords: 
  - "Iterator keyword [Visual Basic]"
ms.assetid: 69cb0b04-ac87-49d0-bcfe-810c0d60daff
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Iterator (Visual Basic)
Specifies that a function or <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> accessor is an iterator.  
  
## Remarks  
 An *iterator* performs a custom iteration over a collection. An iterator uses the [Yield](../vs140/yield-statement--visual-basic-.md) statement to return each element in the collection one at a time. When a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement is reached, the current location in code is retained. Execution is restarted from that location the next time that the iterator function is called.  
  
 An iterator can be implemented as a function or as a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> accessor of a property definition. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier appears in the declaration of the iterator function or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> accessor.  
  
 You call an iterator from client code by using a [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md).  
  
 The return type of an iterator function or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> accessor can be \<xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>1*>.  
  
 An iterator cannot have any <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameters.  
  
 An iterator cannot occur in an event, instance constructor, static constructor, or static destructor.  
  
 An iterator can be an anonymous function. For more information, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
 For more information about iterators, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
## Usage  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> modifier can be used in these contexts:  
  
-   [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)  
  
-   [Property Statement](../vs140/property-statement.md)  
  
## Example  
 The following example demonstrates an iterator function. The iterator function has a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement that is inside a [For…Next](../vs140/for...next-statement--visual-basic-.md) loop. Each iteration of the [For Each](../vs140/for-each...next-statement--visual-basic-.md) statement body in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> creates a call to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> iterator function. Each call to the iterator function proceeds to the next execution of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement, which occurs during the next iteration of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> loop.  
  
 [!code[VbVbalrStatements#98](../vs140/codesnippet/VisualBasic/iterator--visual-basic-_1.vb)]  
  
## Example  
 The following example demonstrates a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> accessor that is an iterator. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> modifier is in the property declaration.  
  
 [!code[VbVbalrStatements#99](../vs140/codesnippet/VisualBasic/iterator--visual-basic-_2.vb)]  
  
 For additional examples, see [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md).  
  
## See Also  
 \<xref:System.Runtime.CompilerServices.IteratorStateMachineAttribute*>   
 [Iterators (C# and Visual Basic)](../vs140/iterators--csharp-and-visual-basic-.md)   
 [Yield Statement (Visual Basic)](../vs140/yield-statement--visual-basic-.md)