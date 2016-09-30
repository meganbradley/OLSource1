---
title: "Where Clause (Visual Basic)"
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
  - "vb.QueryWhere"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Where statement"
  - "queries [Visual Basic], Where"
  - "Where clause"
ms.assetid: 48b5c2c5-3181-429c-8545-894296798c89
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Where Clause (Visual Basic)
Specifies the filtering condition for a query.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. An expression that determines whether the values for the current item in the collection are included in the output collection. The expression must evaluate to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value or the equivalent of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value. If the condition evaluates to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the element is included in the query result; otherwise, the element is excluded from the query result.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause enables you to filter query data by selecting only elements that meet certain criteria. Elements whose values cause the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause to evaluate to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are included in the query result; other elements are excluded. The expression that is used in a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause must evaluate to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or the equivalent of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, such as an Integer that evaluates to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when its value is zero. You can combine multiple expressions in a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause by using logical operators such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 By default, query expressions are not evaluated until they are accessed—for example, when they are data-bound or iterated through in a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> loop. As a result, the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> clause is not evaluated until the query is accessed. If you have values external to the query that are used in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> clause, ensure that the appropriate value is used in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> clause at the time the query is executed. For more information about query execution, see [Three Stages of a LINQ Query (Visual Basic)](../vs140/writing-your-first-linq-query--visual-basic-.md).  
  
 You can call functions within a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> clause to perform a calculation or operation on a value from the current element in the collection. Calling a function in a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> clause can cause the query to be executed immediately when it is defined instead of when it is accessed. For more information about query execution, see [Three Stages of a LINQ Query (Visual Basic)](../vs140/writing-your-first-linq-query--visual-basic-.md).  
  
## Example  
 The following query expression uses a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> clause to declare a range variable <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for each <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> collection. The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> clause uses the range variable to restrict the output to customers from the specified region. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> loop displays the company name for each customer in the query result.  
  
 [!code[VbSimpleQuerySamples#23](../vs140/codesnippet/VisualBasic/where-clause--visual-basic-_1.vb)]  
  
## Example  
 The following example uses <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> logical operators in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> clause.  
  
 [!code[VbSimpleQuerySamples#31](../vs140/codesnippet/VisualBasic/where-clause--visual-basic-_2.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md)