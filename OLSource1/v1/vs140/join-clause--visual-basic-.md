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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Join Clause (Visual Basic)
Combines two collections into a single collection. The join operation is based on matching keys and uses the `Equals` operator.  
  
## Syntax  
  
```  
Join element In collection _  
  [ joinClause _ ]   
  [ groupJoinClause ... _ ]   
On key1 Equals key2 [ And key3 Equals key4 [... ]  
```  
  
## Parts  
 `element`  
 Required. The control variable for the collection being joined.  
  
 `collection`  
 Required. The collection to combine with the collection identified on the left side of the `Join` operator. A `Join` clause can be nested in another `Join` clause, or in a `Group Join` clause.  
  
 `joinClause`  
 Optional. One or more additional `Join` clauses to further refine the query.  
  
 `groupJoinClause`  
 Optional. One or more additional `Group Join` clauses to further refine the query.  
  
 `key1` `Equals` `key2`  
 Required. Identifies keys for the collections being joined. You must use the `Equals` operator to compare keys from the collections being joined. You can combine join conditions by using the `And` operator to identify multiple keys. `key1` must be from the collection on the left side of the `Join` operator. `key2` must be from the collection on the right side of the `Join` operator.  
  
 The keys used in the join condition can be expressions that include more than one item from the collection. However, each key expression can contain only items from its respective collection.  
  
## Remarks  
 The `Join` clause combines two collections based on matching key values from the collections being joined. The resulting collection can contain any combination of values from the collection identified on the left side of the `Join` operator and the collection identified in the `Join` clause. The query will return only results for which the condition specified by the `Equals` operator is met. This is equivalent to an `INNER JOIN` in SQL.  
  
 You can use multiple `Join` clauses in a query to join two or more collections into a single collection.  
  
 You can perform an implicit join to combine collections without the `Join` clause. To do this, include multiple `In` clauses in your `From` clause and specify a `Where` clause that identifies the keys that you want to use for the join.  
  
 You can use the `Group Join` clause to combine collections into a single hierarchical collection. This is like a `LEFT OUTER JOIN` in SQL.  
  
## Example  
 The following code example performs an implicit join to combine a list of customers with their orders.  
  
 [!code[VbSimpleQuerySamples#13](../vs140/codesnippet/VisualBasic/join-clause--visual-basic-_1.vb)]  
  
## Example  
 The following code example joins two collections by using the `Join` clause.  
  
 [!code[VbSimpleQuerySamples#12](../vs140/codesnippet/VisualBasic/join-clause--visual-basic-_2.vb)]  
  
 This example will produce output similar to the following:  
  
 `winlogon (968), Windows Logon`  
  
 `explorer (2424), File Explorer`  
  
 `cmd (5136), Command Window`  
  
## Example  
 The following code example joins two collections by using the `Join` clause with two key columns.  
  
 [!code[VbSimpleQuerySamples#17](../vs140/codesnippet/VisualBasic/join-clause--visual-basic-_3.vb)]  
  
 The example will produce output similar to the following:  
  
 `winlogon (968), Windows Logon, Priority = 13`  
  
 `cmd (700), Command Window, Priority = 8`  
  
 `explorer (2424), File Explorer, Priority = 8`  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Group Join Clause](../vs140/group-join-clause--visual-basic-.md)   
 [Where Clause](../vs140/where-clause--visual-basic-.md)