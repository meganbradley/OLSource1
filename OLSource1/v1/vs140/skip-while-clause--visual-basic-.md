---
title: "Skip While Clause (Visual Basic)"
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
  - "vb.QuerySkipWhile"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Skip While statement"
  - "Skip While clause"
  - "queries [Visual Basic], Skip While"
ms.assetid: 5dee8350-7520-4f1a-b00d-590cacd572d6
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Skip While Clause (Visual Basic)
Bypasses elements in a collection as long as a specified condition is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and then returns the remaining elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required. An expression that represents a condition to test elements for. The expression must return a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value or a functional equivalent, such as an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to be evaluated as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause bypasses elements from the beginning of a query result until the supplied <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. After <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the query returns all the remaining elements. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is ignored for the remaining results.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause differs from the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> clause in that the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause can be used to exclude all elements from a query that do not meet a particular condition. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> clause excludes elements only until the first time that the condition is not satisfied. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> clause is most useful when you are working with an ordered query result.  
  
 You can bypass a specific number of results from the beginning of a query result by using the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> clause.  
  
## Example  
 The following code example uses the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause to bypass results until the first customer from the United States is found.  
  
 [!code[VbSimpleQuerySamples#3](../vs140/codesnippet/VisualBasic/skip-while-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Skip Clause (Visual Basic)](../vs140/skip-clause--visual-basic-.md)   
 [Take While Clause (Visual Basic)](../vs140/take-while-clause--visual-basic-.md)   
 [Where Clause](../vs140/where-clause--visual-basic-.md)