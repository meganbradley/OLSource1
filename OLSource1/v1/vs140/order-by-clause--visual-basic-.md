---
title: "Order By Clause (Visual Basic)"
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
  - "vb.QueryOrderBy"
  - "vb.QueryAscending"
  - "vb.QueryDescending"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], Order By"
  - "Order By clause"
  - "Order By statement"
ms.assetid: fa911282-6b81-44c7-acfa-46b5bb93df75
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Order By Clause (Visual Basic)
Specifies the sort order for a query result.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. One or more fields from the current query result that identify how to order the returned values. The field names must be separated by commas (,). You can identify each field as sorted in ascending or descending order by using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keywords. If no <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword is specified, the default sort order is ascending. The sort order fields are given precedence from left to right.  
  
## Remarks  
 You can use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause to sort the results of a query. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause can only sort a result based on the range variable for the current scope. For example, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause introduces a new scope in a query expression with new iteration variables for that scope. Range variables defined before a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause in a query are not available after the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> clause. Therefore, if you want to order your results by a field that is not available in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause, you must put the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause before the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> clause. One example of when you would have to do this is when you want to sort your query by fields that are not returned as part of the result.  
  
 Ascending and descending order for a field is determined by the implementation of the \<xref:System.IComparable*> interface for the data type of the field. If the data type does not implement the \<xref:System.IComparable*> interface, the sort order is ignored.  
  
## Example  
 The following query expression uses a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause to declare a range variable <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> collection. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> clause sorts the query result by price in ascending order (the default). Books with the same price are sorted by title in ascending order. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause selects the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> properties as the values returned by the query.  
  
 [!code[VbSimpleQuerySamples#24](../vs140/codesnippet/VisualBasic/order-by-clause--visual-basic-_1.vb)]  
  
## Example  
 The following query expression uses the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> clause to sort the query result by price in descending order. Books with the same price are sorted by title in ascending order.  
  
 [!code[VbSimpleQuerySamples#25](../vs140/codesnippet/VisualBasic/order-by-clause--visual-basic-_2.vb)]  
  
## Example  
 The following query expression uses a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> clause to select the book title, price, publish date, and author. It then populates the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> fields of the range variable for the new scope. The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> clause orders the new range variable by author name, book title, and then price. Each column is sorted in the default order (ascending).  
  
 [!code[VbSimpleQuerySamples#26](../vs140/codesnippet/VisualBasic/order-by-clause--visual-basic-_3.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)