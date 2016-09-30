---
title: "join clause (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "join"
  - "join_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "join clause [C#]"
  - "join keyword [C#]"
ms.assetid: 76e9df84-092c-41a6-9537-c3f1cbd7f0fb
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# join clause (C# Reference)
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> clause is useful for associating elements from different source sequences that have no direct relationship in the object model. The only requirement is that the elements in each source share some value that can be compared for equality. For example, a food distributor might have a list of suppliers of a certain product, and a list of buyers. A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause can be used, for example, to create a list of the suppliers and buyers of that product who are all in the same specified region.  
  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause takes two source sequences as input. The elements in each sequence must either be or contain a property that can be compared to a corresponding property in the other sequence. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause compares the specified keys for equality by using the special <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword. All joins performed by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause are equijoins. The shape of the output of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause depends on the specific type of join you are performing. The following are three most common join types:  
  
-   Inner join  
  
-   Group join  
  
-   Left outer join  
  
## Inner Join  
 The following example shows a simple inner equijoin. This query produces a flat sequence of "product name / category" pairs. The same category string will appear in multiple elements. If an element from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> has no matching <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, that category will not appear in the results.  
  
 [!code[cscsrefQueryKeywords#24](../vs140/codesnippet/CSharp/join-clause--csharp-reference-_1.cs)]  
  
 For more information, see [How to: Perform an Inner Join (C# Programming Guide)](../vs140/how-to--perform-inner-joins--csharp-programming-guide-.md).  
  
## Group Join  
 A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause with an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> expression is called a group join.  
  
 [!code[cscsrefQueryKeywords#25](../vs140/codesnippet/CSharp/join-clause--csharp-reference-_2.cs)]  
  
 A group join produces a hierarchical result sequence, which associates elements in the left source sequence with one or more matching elements in the right side source sequence. A group join has no equivalent in relational terms; it is essentially a sequence of object arrays.  
  
 If no elements from the right source sequence are found to match an element in the left source, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause will produce an empty array for that item. Therefore, the group join is still basically an inner-equijoin except that the result sequence is organized into groups.  
  
 If you just select the results of a group join, you can access the items, but you cannot identify the key that they match on. Therefore, it is generally more useful to select the results of the group join into a new type that also has the key name, as shown in the previous example.  
  
 You can also, of course, use the result of a group join as the generator of another subquery:  
  
 [!code[cscsrefQueryKeywords#26](../vs140/codesnippet/CSharp/join-clause--csharp-reference-_3.cs)]  
  
 For more information, see [How to: Perform a Grouped Join (C# Programming Guide)](../vs140/how-to--perform-grouped-joins--csharp-programming-guide-.md).  
  
## Left Outer Join  
 In a left outer join, all the elements in the left source sequence are returned, even if no matching elements are in the right sequence. To perform a left outer join in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)], use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method in combination with a group join to specify a default right-side element to produce if a left-side element has no matches. You can use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> as the default value for any reference type, or you can specify a user-defined default type. In the following example, a user-defined default type is shown:  
  
 [!code[cscsrefQueryKeywords#27](../vs140/codesnippet/CSharp/join-clause--csharp-reference-_4.cs)]  
  
 For more information, see [How to: Perform a Left Outer Join (C# Programming Guide)](../vs140/how-to--perform-left-outer-joins--csharp-programming-guide-.md).  
  
## The equals operator  
 A <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause performs an equijoin. In other words, you can only base matches on the equality of two keys. Other types of comparisons such as "greater than" or "not equals" are not supported. To make clear that all joins are equijoins, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> clause uses the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword instead of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operator. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword can only be used in a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> clause and it differs from the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator in one important way. With <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the left key consumes the outer source sequence, and the right key consumes the inner source. The outer source is only in scope on the left side of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and the inner source sequence is only in scope on the right side.  
  
## Non-Equijoins  
 You can perform non-equijoins, cross joins, and other custom join operations by using multiple <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> clauses to introduce new sequences independently into a query. For more information, see [How To: Perform Custom Join Operations](../vs140/how-to--perform-custom-join-operations--csharp-programming-guide-.md).  
  
## Joins on object collections vs. relational tables  
 In a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expression, join operations are performed on object collections. Object collections cannot be "joined" in exactly the same way as two relational tables. In [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)], explicit <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> clauses are only required when two source sequences are not tied by any relationship. When working with [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)], foreign key tables are represented in the object model as properties of the primary table. For example, in the Northwind database, the Customer table has a foreign key relationship with the Orders table. When you map the tables to the object model, the Customer class has an Orders property that contains the collection of Orders associated with that Customer. In effect, the join has already been done for you.  
  
 For more information about querying across related tables in the context of [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)], see [Representing Database Relationships (LINQ to SQL)](assetId:///538def39-8399-46fb-b02d-60ede4e050af).  
  
## Composite Keys  
 You can test for equality of multiple values by using a composite key. For more information, see [How to: Join By Using Composite Keys (C# Programming Guide)](../vs140/how-to--join-by-using-composite-keys--csharp-programming-guide-.md). Composite keys can be also used in a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> clause.  
  
## Example  
 The following example compares the results of an inner join, a group join, and a left outer join on the same data sources by using the same matching keys. Some extra code is added to these examples to clarify the results in the console display.  
  
 [!code[cscsrefQueryKeywords#23](../vs140/codesnippet/CSharp/join-clause--csharp-reference-_5.cs)]  
  
## Remarks  
 A <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clause that is not followed by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is translated into a \<xref:System.Linq.Enumerable.Join*> method call. A <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> clause that is followed by <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is translated to a \<xref:System.Linq.Enumerable.GroupJoin*> method call.  
  
## See Also  
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [Join Operations](../vs140/join-operations.md)   
 [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md)   
 [How to: Perform a Left Outer Join](../vs140/how-to--perform-left-outer-joins--csharp-programming-guide-.md)   
 [How to: Perform an Inner Join](../vs140/how-to--perform-inner-joins--csharp-programming-guide-.md)   
 [How to: Perform a Grouped Join](../vs140/how-to--perform-grouped-joins--csharp-programming-guide-.md)   
 [How to: Order the Results of a Join Clause (C# Programming Guide)](../vs140/how-to--order-the-results-of-a-join-clause--csharp-programming-guide-.md)   
 [How to: Join By Using Composite Keys (C# Programming Guide)](../vs140/how-to--join-by-using-composite-keys--csharp-programming-guide-.md)   
 [How to: Install Sample Databases](assetId:///ed1291f6-604c-4972-ae22-0345c6dea12e)