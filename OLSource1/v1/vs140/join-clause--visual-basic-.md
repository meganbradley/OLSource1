---
title: "Join Clause (Visual Basic)"
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
  - "vb.QueryJoinIn"
  - "vb.QueryJoin"
  - "vb.QueryJoinOn"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], Join"
  - "Join statement"
  - "Join clause"
ms.assetid: 6dd37936-b27c-4e00-98ad-154b23f4de64
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Join Clause (Visual Basic)
Combines two collections into a single collection. The join operation is based on matching keys and uses the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The control variable for the collection being joined.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. The collection to combine with the collection identified on the left side of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator. A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause can be nested in another <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause, or in a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Optional. One or more additional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clauses to further refine the query.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Optional. One or more additional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clauses to further refine the query.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Required. Identifies keys for the collections being joined. You must use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operator to compare keys from the collections being joined. You can combine join conditions by using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> operator to identify multiple keys. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must be from the collection on the left side of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> operator. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> must be from the collection on the right side of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator.  
  
 The keys used in the join condition can be expressions that include more than one item from the collection. However, each key expression can contain only items from its respective collection.  
  
## Remarks  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> clause combines two collections based on matching key values from the collections being joined. The resulting collection can contain any combination of values from the collection identified on the left side of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> operator and the collection identified in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> clause. The query will return only results for which the condition specified by the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> operator is met. This is equivalent to an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in SQL.  
  
 You can use multiple <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clauses in a query to join two or more collections into a single collection.  
  
 You can perform an implicit join to combine collections without the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> clause. To do this, include multiple <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> clauses in your <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> clause and specify a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> clause that identifies the keys that you want to use for the join.  
  
 You can use the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> clause to combine collections into a single hierarchical collection. This is like a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> in SQL.  
  
## Example  
 The following code example performs an implicit join to combine a list of customers with their orders.  
  
 [!code[VbSimpleQuerySamples#13](../vs140/codesnippet/VisualBasic/join-clause--visual-basic-_1.vb)]  
  
## Example  
 The following code example joins two collections by using the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> clause.  
  
 [!code[VbSimpleQuerySamples#12](../vs140/codesnippet/VisualBasic/join-clause--visual-basic-_2.vb)]  
  
 This example will produce output similar to the following:  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Example  
 The following code example joins two collections by using the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> clause with two key columns.  
  
 [!code[VbSimpleQuerySamples#17](../vs140/codesnippet/VisualBasic/join-clause--visual-basic-_3.vb)]  
  
 The example will produce output similar to the following:  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Group Join Clause](../vs140/group-join-clause--visual-basic-.md)   
 [Where Clause](../vs140/where-clause--visual-basic-.md)