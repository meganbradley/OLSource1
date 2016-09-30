---
title: "Take Clause (Visual Basic)"
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
  - "vb.QueryTake"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Take statement"
  - "queries [Visual Basic], Take"
  - "Take clause"
ms.assetid: 77bf87b2-1476-4456-957f-fee922fbad8c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Take Clause (Visual Basic)
Returns a specified number of contiguous elements from the start of a collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. A value or an expression that evaluates to the number of elements of the sequence to return.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause causes a query to include a specified number of contiguous elements from the start of a results list. The number of elements to include is specified by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 You can use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause to return a range of data from any segment of a query. To do this, pass the index of the first element of the range to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause and the size of the range to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause. In this case, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause must be specified after the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause.  
  
 When you use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> clause in a query, you may also need to ensure that the results are returned in an order that will enable the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause to include the intended results. For more information about ordering query results, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).  
  
 You can use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause to specify that only certain elements be returned, depending on a supplied condition.  
  
## Example  
 The following code example uses the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> clause together with the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause to return data from a query in pages. The GetCustomers function uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> clause to bypass the customers in the list until the supplied starting index value, and uses the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> clause to return a page of customers starting from that index value.  
  
 [!code[VbSimpleQuerySamples#1](../vs140/codesnippet/VisualBasic/take-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md)   
 [Take While Clause (Visual Basic)](../vs140/take-while-clause--visual-basic-.md)   
 [Skip Clause (Visual Basic)](../vs140/skip-clause--visual-basic-.md)