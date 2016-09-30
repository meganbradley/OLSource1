---
title: "Query Expression Syntax for Standard Query Operators (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: eb978d86-d3b5-497b-95ce-a054bea8f510
caps.latest.revision: 5
---
# Query Expression Syntax for Standard Query Operators (Visual Basic)
Some of the more frequently used standard query operators have dedicated Visual Basic language keyword syntax that enables them to be called as part of a *query expression*. A query expression is a different, more readable form of expressing a query than its *method-based*  equivalent. Query expression clauses are translated into calls to the query methods at compile time.  
  
## Query Expression Syntax Table  
 The following table lists the standard query operators that have equivalent query expression clauses.  
  
|Method|Visual Basic Query Expression Syntax|  
|------------|------------------------------------------|  
|\<xref:System.Linq.Enumerable.All*>|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Any*>|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Average*>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Cast*>|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Count*>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Distinct<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>0})>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Distinct Clause (Visual Basic)](../vs140/distinct-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.GroupBy*>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.GroupJoin<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>0},System.Collections.Generic.IEnumerable{<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>0,<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>1,<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>0,System.Collections.Generic.IEnumerable{<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>3})>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Join<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>0},System.Collections.Generic.IEnumerable{<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>0,<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>1,<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>0,<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>3})>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>\<br />\<br /> -or-\<br />\<br /> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Join Clause (Visual Basic)](../vs140/join-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.LongCount*>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Max*>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Min*>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.OrderBy<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>1})>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.OrderByDescending<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>1})>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Select*>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Select Clause (Visual Basic)](../vs140/select-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.SelectMany*>|Multiple <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> clauses\<br />\<br /> (For more information, see [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Skip*>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Skip Clause (Visual Basic)](../vs140/skip-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.SkipWhile*>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Skip While Clause (Visual Basic)](../vs140/skip-while-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Sum*>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Take*>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Take Clause (Visual Basic)](../vs140/take-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.TakeWhile*>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Take While Clause (Visual Basic)](../vs140/take-while-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.ThenBy<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>1})>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.ThenByDescending<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>1})>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).)|  
|\<xref:System.Linq.Enumerable.Where*>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [Where Clause (Visual Basic)](../vs140/where-clause--visual-basic-.md).)|  
  
## See Also  
 \<xref:System.Linq.Enumerable*>   
 \<xref:System.Linq.Queryable*>   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Classification of Standard Query Operators by Manner of Execution (Visual Basic)](../vs140/classification-of-standard-query-operators-by-manner-of-execution--visual-basic-.md)