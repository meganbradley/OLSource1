---
title: "Skip Clause (Visual Basic)"
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
  - "vb.QuerySkip"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], Skip"
  - "Skip statement"
  - "Skip clause"
ms.assetid: f00eb172-3907-4c43-9745-d8546ab86234
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Skip Clause (Visual Basic)
Bypasses a specified number of elements in a collection and then returns the remaining elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. A value or an expression that evaluates to the number of elements of the sequence to skip.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause causes a query to bypass elements at the beginning of a results list and return the remaining elements. The number of elements to skip is identified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 You can use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause to return a range of data from any segment of a query. To do this, pass the index of the first element of the range to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause and the size of the range to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause.  
  
 When you use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause in a query, you may also need to ensure that the results are returned in an order that will enable the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause to bypass the intended results. For more information about ordering query results, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).  
  
 You can use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> clause to specify that only certain elements are ignored, depending on a supplied condition.  
  
## Example  
 The following code example uses the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause together with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause to return data from a query in pages. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function uses the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause to bypass the customers in the list until the supplied starting index value, and uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> clause to return a page of customers starting from that index value.  
  
 [!code[VbSimpleQuerySamples#1](../vs140/codesnippet/VisualBasic/skip-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md)   
 [SkipWhile Clause (Visual Basic)](../vs140/skip-while-clause--visual-basic-.md)   
 [Take Clause (Visual Basic)](../vs140/take-clause--visual-basic-.md)