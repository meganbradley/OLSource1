---
title: "Aggregate Clause (Visual Basic)"
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
  - "vb.QueryAggregateIn"
  - "vb.QueryAggregate"
  - "vb.QueryAggregateInto"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Aggregate clause"
  - "Aggregate statement"
  - "queries [Visual Basic], Aggregate"
ms.assetid: 1315a814-5db6-4077-b34b-b141e11cc0eb
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Aggregate Clause (Visual Basic)
Applies one or more aggregate functions to a collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Required. Variable used to iterate through the elements of the collection.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. The type of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If no type is specified, the type of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is inferred from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required. Refers to the collection to operate on.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. One or more query clauses, such as a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause, to refine the query result to apply the aggregate clause or clauses to.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required. One or more comma-delimited expressions that identify an aggregate function to apply to the collection. You can apply an alias to an aggregate function to specify a member name for the query result. If no alias is supplied, the name of the aggregate function is used. For examples, see the section about aggregate functions later in this topic.|  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> clause can be used to include aggregate functions in your queries. Aggregate functions perform checks and computations over a set of values and return a single value. You can access the computed value by using a member of the query result type. The standard aggregate functions that you can use are the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> functions. These functions are familiar to developers who are familiar with aggregates in SQL. They are described in the following section of this topic.  
  
 The result of an aggregate function is included in the query result as a field of the query result type. You can supply an alias for the aggregate function result to specify the name of the member of the query result type that will hold the aggregate value. If no alias is supplied, the name of the aggregate function is used.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> clause can begin a query, or it can be included as an additional clause in a query. If the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> clause begins a query, the result is a single value that is the result of the aggregate function specified in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> clause. If more than one aggregate function is specified in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> clause, the query returns a single type with a separate property to reference the result of each aggregate function in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> clause. If the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> clause is included as an additional clause in a query, the type returned in the query collection will have a separate property to reference the result of each aggregate function in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> clause.  
  
## Aggregate Functions  
 The following list describes the standard aggregate functions that can be used with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clause.  
  
|||  
|-|-|  
|Function|Description|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if all elements in the collection satisfy a specified condition; otherwise returns <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Following is an example:\<br />\<br /> [!code[VbSimpleQuerySamples#5](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_1.vb)]|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if any element in the collection satisfies a specified condition; otherwise returns <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. Following is an example:\<br />\<br /> [!code[VbSimpleQuerySamples#6](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_2.vb)]|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Computes the average of all elements in the collection, or a computes supplied expression for all elements in the collection. Following is an example:\<br />\<br /> [!code[VbSimpleQuerySamples#7](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_3.vb)]|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Counts the number of elements in the collection. You can supply an optional <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> expression to count only the number of elements in the collection that satisfy a condition. Following is an example:\<br />\<br /> [!code[VbSimpleQuerySamples#8](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_4.vb)]|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Refers to query results that are grouped as a result of a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> clause. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function is valid only in the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> clause of a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> clause. For more information and examples, see [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md) and [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md).|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Counts the number of elements in the collection. You can supply an optional <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> expression to count only the number of elements in the collection that satisfy a condition. Returns the result as a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. For an example, see the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> aggregate function.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Computes the maximum value from the collection, or computes a supplied expression for all elements in the collection. Following is an example:\<br />\<br /> [!code[VbSimpleQuerySamples#9](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_5.vb)]|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Computes the minimum value from the collection, or computes a supplied expression for all elements in the collection. Following is an example:\<br />\<br /> [!code[VbSimpleQuerySamples#10](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_6.vb)]|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Computes the sum of all elements in the collection, or computes a supplied expression for all elements in the collection. Following is an example:\<br />\<br /> [!code[VbSimpleQuerySamples#15](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_7.vb)]|  
  
## Example  
 The following code example shows how to use the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> clause to apply aggregate functions to a query result.  
  
 [!code[VbSimpleQuerySamples#4](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_8.vb)]  
  
## Creating User-Defined Aggregate Functions  
 You can include your own custom aggregate functions in a query expression by adding extension methods to the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>IEnumerable(Of Double)<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>Double<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>Func(Of T, Double)<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>Double<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>Integer<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>Double<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>Double<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>Double<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>Median<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>Integer<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>Median` method.  
  
 [!code[VbSimpleQuerySamples#19](../vs140/codesnippet/VisualBasic/aggregate-clause--visual-basic-_10.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Where Clause (Visual Basic)](../vs140/where-clause--visual-basic-.md)   
 [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md)