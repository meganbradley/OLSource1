---
title: "How to: Perform Custom Join Operations (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "custom joins [C#]"
  - "joins [C#], custom"
  - "query expressions [LINQ in C#], joins"
  - "queries [LINQ in C#], joins"
ms.assetid: a05e2ab1-410d-4a1d-8ada-af93539682c9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Perform Custom Join Operations (C# Programming Guide)
This example shows how to perform join operations that are not possible with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> clause. In a query expression, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause is limited to, and optimized for, equijoins, which are by far the most common type of join operation. When performing an equijoin, you will probably always get the best performance by using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause.  
  
 However, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause cannot be used in the following cases:  
  
-   When the join is predicated on an expression of inequality (a non-equijoin).  
  
-   When the join is predicated on more than one expression of equality or inequality.  
  
-   When you have to introduce a temporary range variable for the right side (inner) sequence before the join operation.  
  
 To perform joins that are not equijoins, you can use multiple <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clauses to introduce each data source independently. You then apply a predicate expression in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause to the range variable for each source. The expression also can take the form of a method call.  
  
> [!NOTE]
>  Do not confuse this kind of custom join operation with the use of multiple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clauses to access inner collections. For more information, see [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md).  
  
## Example  
 The first method in the following example shows a simple cross join. Cross joins must be used with caution because they can produce very large result sets. However, they can be useful in some scenarios for creating source sequences against which additional queries are run.  
  
 The second method produces a sequence of all the products whose category ID is listed in the category list on the left side. Note the use of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method to create a temporary array. It also is possible to create the array before the query and eliminate the first <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause.  
  
 [!code[csProgGuideLINQ#64](../vs140/codesnippet/CSharp/how-to--perform-custom-join-operations--csharp-programming-guide-_1.cs)]  
  
## Example  
 In the following example, the query must join two sequences based on matching keys that, in the case of the inner (right side) sequence, cannot be obtained prior to the join clause itself. If this join were performed with a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> clause, then the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method would have to be called for each element. The use of multiple <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clauses enables the query to avoid the overhead of the repeated method call. However, since <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is optimized, in this particular case it might still be faster than using multiple <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clauses. The results will vary depending primarily on how expensive the method call is.  
  
 [!code[csProgGuideLINQ#13](../vs140/codesnippet/CSharp/how-to--perform-custom-join-operations--csharp-programming-guide-_2.cs)]  
  
## Compiling the Code  
  
-   Create a [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] console application project that targets [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 3.5 or later. By default, the project has a reference to System.Core.dll and a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> directive for the System.Linq namespace.  
  
-   Replace the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class with the code in the previous example.  
  
-   Follow the instructions in [How To: Join Content from Dissimilar Files (LINQ)](../vs140/how-to--join-content-from-dissimilar-files--linq-.md) to set up the data files, scores.csv and names.csv.  
  
-   Press F5 to compile and run the program.  
  
-   Press any key to exit the console window.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md)   
 [Join Operations](../vs140/join-operations.md)   
 [How to: Order the Results of a Join Clause (C# Programming Guide)](../vs140/how-to--order-the-results-of-a-join-clause--csharp-programming-guide-.md)