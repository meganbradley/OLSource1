---
title: "Query Expression Syntax for Standard Query Operators (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: e1e17ef2-68ff-4c26-b6e2-015668227fa5
caps.latest.revision: 6
---
# Query Expression Syntax for Standard Query Operators (C#)
Some of the more frequently used standard query operators have dedicated C# language keyword syntax that enables them to be called as part of a *query expression*. A query expression is a different, more readable form of expressing a query than its *method-based*  equivalent. Query expression clauses are translated into calls to the query methods at compile time.  
  
## Query Expression Syntax Table  
 The following table lists the standard query operators that have equivalent query expression clauses.  
  
|Method|C# Query Expression Syntax|  
|------------|---------------------------------|  
|\<xref:System.Linq.Enumerable.Cast*>|Use an explicitly typed range variable, for example:\<br />\<br /> <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [from clause (C# Reference)](../vs140/from-clause--csharp-reference-.md).)|  
|\<xref:System.Linq.Enumerable.GroupBy*>|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>\<br />\<br /> -or-\<br />\<br /> <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md).)|  
|<xref:System.Linq.Enumerable.GroupJoin<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>0},System.Collections.Generic.IEnumerable{<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>0,<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1,<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>0,System.Collections.Generic.IEnumerable{<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>3})>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md).)|  
|<xref:System.Linq.Enumerable.Join<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>0},System.Collections.Generic.IEnumerable{<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>0,<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1,<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>0,<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>3})>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md).)|  
<xref:System.Linq.Enumerable.OrderBy<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>1})>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [orderby clause (C# Reference)](../vs140/orderby-clause--csharp-reference-.md).)|  
|<xref:System.Linq.Enumerable.OrderByDescending<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>1})>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [orderby clause (C# Reference)](../vs140/orderby-clause--csharp-reference-.md).)|  
|\<xref:System.Linq.Enumerable.Select*>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [select clause (C# Reference)](../vs140/select-clause--csharp-reference-.md).)|  
|\<xref:System.Linq.Enumerable.SelectMany*>|Multiple <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> clauses.\<br />\<br /> (For more information, see [from clause (C# Reference)](../vs140/from-clause--csharp-reference-.md).)|  
|<xref:System.Linq.Enumerable.ThenBy<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>1})>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [orderby clause (C# Reference)](../vs140/orderby-clause--csharp-reference-.md).)|  
<xref:System.Linq.Enumerable.ThenByDescending<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>0},System.Func{<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>1})>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [orderby clause (C# Reference)](../vs140/orderby-clause--csharp-reference-.md).)|  
|\<xref:System.Linq.Enumerable.Where*>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<br />\<br /> (For more information, see [where clause (C# Reference)](../vs140/where-clause--csharp-reference-.md).)|  
  
## See Also  
 \<xref:System.Linq.Enumerable*>   
 \<xref:System.Linq.Queryable*>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [Classification of Standard Query Operators by Manner of Execution (C#)](../vs140/classification-of-standard-query-operators-by-manner-of-execution--csharp-.md)