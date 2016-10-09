---
title: "Order By Clause (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 16
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Order By Clause (Visual Basic)
Specifies the sort order for a query result.  
  
## Syntax  
  
```  
Order By orderExp1 [ Ascending | Descending ] [, orderExp2 [...] ]  
```  
  
## Parts  
 `orderExp1`  
 Required. One or more fields from the current query result that identify how to order the returned values. The field names must be separated by commas (,). You can identify each field as sorted in ascending or descending order by using the `Ascending` or `Descending` keywords. If no `Ascending` or `Descending` keyword is specified, the default sort order is ascending. The sort order fields are given precedence from left to right.  
  
## Remarks  
 You can use the `Order By` clause to sort the results of a query. The `Order By` clause can only sort a result based on the range variable for the current scope. For example, the `Select` clause introduces a new scope in a query expression with new iteration variables for that scope. Range variables defined before a `Select` clause in a query are not available after the `Select` clause. Therefore, if you want to order your results by a field that is not available in the `Select` clause, you must put the `Order By` clause before the `Select` clause. One example of when you would have to do this is when you want to sort your query by fields that are not returned as part of the result.  
  
 Ascending and descending order for a field is determined by the implementation of the \<xref:System.IComparable> interface for the data type of the field. If the data type does not implement the \<xref:System.IComparable> interface, the sort order is ignored.  
  
## Example  
 The following query expression uses a `From` clause to declare a range variable `book` for the `books` collection. The `Order By` clause sorts the query result by price in ascending order (the default). Books with the same price are sorted by title in ascending order. The `Select` clause selects the `Title` and `Price` properties as the values returned by the query.  
  
 [!code[VbSimpleQuerySamples#24](../VS_visualbasic/codesnippet/VisualBasic/order-by-clause--visual-basic-_1.vb)]  
  
## Example  
 The following query expression uses the `Order By` clause to sort the query result by price in descending order. Books with the same price are sorted by title in ascending order.  
  
 [!code[VbSimpleQuerySamples#25](../VS_visualbasic/codesnippet/VisualBasic/order-by-clause--visual-basic-_2.vb)]  
  
## Example  
 The following query expression uses a `Select` clause to select the book title, price, publish date, and author. It then populates the `Title`, `Price`, `PublishDate`, and `Author` fields of the range variable for the new scope. The `Order By` clause orders the new range variable by author name, book title, and then price. Each column is sorted in the default order (ascending).  
  
 [!code[VbSimpleQuerySamples#26](../VS_visualbasic/codesnippet/VisualBasic/order-by-clause--visual-basic-_3.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../VS_visualbasic/introduction-to-linq-in-visual-basic.md)   
 [Queries](../VS_visualbasic/queries--visual-basic-.md)   
 [Select Clause](../VS_visualbasic/select-clause--visual-basic-.md)   
 [From Clause](../VS_visualbasic/from-clause--visual-basic-.md)