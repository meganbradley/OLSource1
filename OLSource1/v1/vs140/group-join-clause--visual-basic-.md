---
title: "Group Join Clause (Visual Basic)"
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
  - "vb.QueryGroupJoinIn"
  - "vb.QueryGroupJoinOn"
  - "vb.QueryGroupJoin"
  - "vb.QueryGroupJoinInto"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Group Join clause"
  - "Group Join statement"
  - "queries [Visual Basic], Group Join"
ms.assetid: 37dbf79c-7b5c-421b-bbb7-dadfd2b92a1c
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Group Join Clause (Visual Basic)
Combines two collections into a single hierarchical collection. The join operation is based on matching keys.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. The control variable for the collection being joined.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. The type of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If no <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is specified, the type of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is inferred from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Required. The collection to combine with the collection that is on the left side of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator. A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause can be nested in a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> clause or in another <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Required. Identifies keys for the collections being joined. You must use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operator to compare keys from the collections being joined. You can combine join conditions by using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> operator to identify multiple keys. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter must be from the collection on the left side of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> operator. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter must be from the collection on the right side of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator.\<br />\<br /> The keys used in the join condition can be expressions that include more than one item from the collection. However, each key expression can contain only items from its respective collection.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Required. One or more expressions that identify how the groups of elements from the collection are aggregated. To identify a member name for the grouped results, use the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> keyword (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>). You can also include aggregate functions to apply to the group.|  
  
## Remarks  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> clause combines two collections based on matching key values from the collections being joined. The resulting collection can contain a member that references a collection of elements from the second collection that match the key value from the first collection. You can also specify aggregate functions to apply to the grouped elements from the second collection. For information about aggregate functions, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).  
  
 Consider, for example, a collection of managers and a collection of employees. Elements from both collections have a ManagerID property that identifies the employees that report to a particular manager. The results from a join operation would contain a result for each manager and employee with a matching ManagerID value. The results from a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> operation would contain the complete list of managers. Each manager result would have a member that referenced the list of employees that were a match for the specific manager.  
  
 The collection resulting from a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> operation can contain any combination of values from the collection identified in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> clause and the expressions identified in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> clause of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> clause. For more information about valid expressions for the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> clause, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).  
  
 A <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operation will return all results from the collection identified on the left side of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator. This is true even if there are no matches in the collection being joined. This is like a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in SQL.  
  
 You can use the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> clause to combine collections into a single collection. This is equivalent to an <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> in SQL.  
  
## Example  
 The following code example joins two collections by using the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> clause.  
  
 [!code[VbSimpleQuerySamples#14](../vs140/codesnippet/VisualBasic/group-join-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Join Clause](../vs140/join-clause--visual-basic-.md)   
 [Where Clause](../vs140/where-clause--visual-basic-.md)   
 [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md)