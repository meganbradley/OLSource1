---
title: "From Clause (Visual Basic)"
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
  - "vb.QueryFrom"
  - "vb.QueryFromIn"
  - "vb.QueryFromLet"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], From"
  - "From clause"
  - "From statement"
ms.assetid: 83e3665e-68a0-4540-a3a3-3d777a0f95d5
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# From Clause (Visual Basic)
Specifies one or more range variables and a collection to query.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. A *range variable* used to iterate through the elements of the collection. A range variable is used to refer to each member of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as the query iterates through the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Must be an enumerable type.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional. The type of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If no <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is specified, the type of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is inferred from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required. Refers to the collection to be queried. Must be an enumerable type.|  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> clause is used to identify the source data for a query and the variables that are used to refer to an element from the source collection. These variables are called *range variables*. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause is required for a query, except when the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause is used to identify a query that returns only aggregated results. For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).  
  
 You can specify multiple <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> clauses in a query to identify multiple collections to be joined. When multiple collections are specified, they are iterated over independently, or you can join them if they are related. You can join collections implicitly by using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause, or explicitly by using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> clauses. As an alternative, you can specify multiple range variables and collections in a single <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> clause, with each related range variable and collection separated from the others by a comma. The following code example shows both syntax options for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause.  
  
 [!code[VbSimpleQuerySamples#21](../vs140/codesnippet/VisualBasic/from-clause--visual-basic-_1.vb)]  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> clause defines the scope of a query, which is similar to the scope of a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> loop. Therefore, each <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> range variable in the scope of a query must have a unique name. Because you can specify multiple <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> clauses for a query, subsequent <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> clauses can refer to range variables in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> clause, or they can refer to range variables in a previous <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> clause. For example, the following example shows a nested <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clause where the collection in the second clause is based on a property of the range variable in the first clause.  
  
 [!code[VbSimpleQuerySamples#22](../vs140/codesnippet/VisualBasic/from-clause--visual-basic-_2.vb)]  
  
 Each <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> clause can be followed by any combination of additional query clauses to refine the query. You can refine the query in the following ways:  
  
-   Combine multiple collections implicitly by using the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> clauses, or explicitly by using the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> clauses.  
  
-   Use the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> clause to filter the query result.  
  
-   Sort the result by using the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> clause.  
  
-   Group similar results together by using the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> clause.  
  
-   Use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> clause to identify aggregate functions to evaluate for the whole query result.  
  
-   Use the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> clause to introduce an iteration variable whose value is determined by an expression instead of a collection.  
  
-   Use the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> clause to ignore duplicate query results.  
  
-   Identify parts of the result to return by using the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> clauses.  
  
## Example  
 The following query expression uses a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> clause to declare a range variable <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> for each <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> collection. The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> clause uses the range variable to restrict the output to customers from the specified region. The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> loop displays the company name for each customer in the query result.  
  
 [!code[VbSimpleQuerySamples#23](../vs140/codesnippet/VisualBasic/from-clause--visual-basic-_3.vb)]  
  
## See Also  
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md)   
 [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [Where Clause](../vs140/where-clause--visual-basic-.md)   
 [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md)   
 [Distinct Clause (Visual Basic)](../vs140/distinct-clause--visual-basic-.md)   
 [Join Clause (Visual Basic)](../vs140/join-clause--visual-basic-.md)   
 [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md)   
 [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md)   
 [Let Clause (Visual Basic)](../vs140/let-clause--visual-basic-.md)   
 [Skip Clause (Visual Basic)](../vs140/skip-clause--visual-basic-.md)   
 [Take Clause (Visual Basic)](../vs140/take-clause--visual-basic-.md)   
 [Skip While Clause (Visual Basic)](../vs140/skip-while-clause--visual-basic-.md)   
 [Take While Clause (Visual Basic)](../vs140/take-while-clause--visual-basic-.md)