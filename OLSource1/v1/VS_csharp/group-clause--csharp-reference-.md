---
title: "group clause (C# Reference)"
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
  - "group"
  - "group_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "group keyword [C#]"
  - "group clause [C#]"
ms.assetid: c817242e-b12c-4baa-a57e-73ee138f34d1
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# group clause (C# Reference)
The `group` clause returns a sequence of <xref:System.Linq.IGrouping`2*> objects that contain zero or more items that match the key value for the group. For example, you can group a sequence of strings according to the first letter in each string. In this case, the first letter is the key and has a type [char](../VS_csharp/char--csharp-reference-.md), and is stored in the `Key` property of each <xref:System.Linq.IGrouping`2*> object. The compiler infers the type of the key.  
  
 You can end a query expression with a `group` clause, as shown in the following example:  
  
 [!code[cscsrefQueryKeywords#10](../VS_csharp/codesnippet/CSharp/group-clause--csharp-reference-_1.cs)]  
  
 If you want to perform additional query operations on each group, you can specify a temporary identifier by using the [into](../VS_csharp/into--csharp-reference-.md) contextual keyword. When you use `into`, you must continue with the query, and eventually end it with either a `select` statement or another `group` clause, as shown in the following excerpt:  
  
 [!code[cscsrefQueryKeywords#11](../VS_csharp/codesnippet/CSharp/group-clause--csharp-reference-_2.cs)]  
  
 More complete examples of the use of `group` with and without `into` are provided in the Example section of this topic.  
  
## Enumerating the Results of a Group Query  
 Because the <xref:System.Linq.IGrouping`2*> objects produced by a `group` query are essentially a list of lists, you must use a nested [foreach](../VS_csharp/foreach--in--csharp-reference-.md) loop to access the items in each group. The outer loop iterates over the group keys, and the inner loop iterates over each item in the group itself. A group may have a key but no elements. The following is the `foreach` loop that executes the query in the previous code examples:  
  
 [!code[cscsrefQueryKeywords#12](../VS_csharp/codesnippet/CSharp/group-clause--csharp-reference-_3.cs)]  
  
## Key Types  
 Group keys can be any type, such as a string, a built-in numeric type, or a user-defined named type or anonymous type.  
  
### Grouping by string  
 The previous code examples used a `char`. A string key could easily have been specified instead, for example the complete last name:  
  
 [!code[cscsrefQueryKeywords#13](../VS_csharp/codesnippet/CSharp/group-clause--csharp-reference-_4.cs)]  
  
### Grouping by bool  
 The following example shows the use of a bool value for a key to divide the results into two groups. Note that the value is produced by a sub-expression in the `group` clause.  
  
 [!code[cscsrefQueryKeywords#14](../VS_csharp/codesnippet/CSharp/group-clause--csharp-reference-_5.cs)]  
  
### Grouping by numeric range  
 The next example uses an expression to create numeric group keys that represent a percentile range. Note the use of [let](../VS_csharp/let-clause--csharp-reference-.md) as a convenient location to store a method call result, so that you do not have to call the method two times in the `group` clause. Note also in the `group` clause that to avoid a "divide by zero" exception the code checks to make sure that the student does not have an average of zero. For more information about how to safely use methods in query expressions, see [How To: Avoid Exceptions in Query Expressions](../VS_csharp/how-to--handle-exceptions-in-query-expressions--csharp-programming-guide-.md).  
  
 [!code[cscsrefQueryKeywords#15](../VS_csharp/codesnippet/CSharp/group-clause--csharp-reference-_6.cs)]  
  
### Grouping by Composite Keys  
 Use a composite key when you want to group elements according to more than one key. You create a composite key by using an anonymous type or a named type to hold the key element. In the following example, assume that a class `Person` has been declared with members named `surname` and `city`. The `group` clause causes a separate group to be created for each set of persons with the same last name and the same city.  
  
```  
group person by new {name = person.surname, city = person.city};  
```  
  
 Use a named type if you must pass the query variable to another method. Create a special class using auto-implemented properties for the keys, and then override the <xref:System.Object.Equals*> and <xref:System.Object.GetHashCode*> methods. You can also use a struct, in which case you do not strictly have to override those methods. For more information see [How to: Implement a Lightweight Class with Auto-Implemented Properties (C# Programming Guide)](../VS_csharp/how-to--implement-a-lightweight-class-with-auto-implemented-properties--csharp-programming-guide-.md) and [How To: Query for Duplicate Files in a Directory Tree (LINQ)](../VS_csharp/how-to--query-for-duplicate-files-in-a-directory-tree--linq-.md). The latter topic has a code example that demonstrates how to use a composite key with a named type.  
  
## Example  
 The following example shows the standard pattern for ordering source data into groups when no additional query logic is applied to the groups. This is called a grouping without a continuation. The elements in an array of strings are grouped according to their first letter. The result of the query is an <xref:System.Linq.IGrouping`2*> type that contains a public `Key` property of type `char` and an <xref:System.Collections.Generic.IEnumerable`1*> collection that contains each item in the grouping.  
  
 The result of a `group` clause is a sequence of sequences. Therefore, to access the individual elements within each returned group, use a nested `foreach` loop inside the loop that iterates the group keys, as shown in the following example.  
  
 [!code[cscsrefQueryKeywords#16](../VS_csharp/codesnippet/CSharp/group-clause--csharp-reference-_7.cs)]  
  
## Example  
 This example shows how to perform additional logic on the groups after you have created them, by using a *continuation* with `into`. For more information, see [into (C# Reference)](../VS_csharp/into--csharp-reference-.md). The following example queries each group to select only those whose key value is a vowel.  
  
 [!code[cscsrefQueryKeywords#17](../VS_csharp/codesnippet/CSharp/group-clause--csharp-reference-_8.cs)]  
  
## Remarks  
 At compile time, `group` clauses are translated into calls to the <xref:System.Linq.Enumerable.GroupBy*> method.  
  
## See Also  
 <xref:System.Linq.IGrouping`2*>   
 <xref:System.Linq.Enumerable.GroupBy*>   
 <xref:System.Linq.Enumerable.ThenBy*>   
 <xref:System.Linq.Enumerable.ThenByDescending*>   
 [Query Keywords (C# Reference)](../VS_csharp/query-keywords--csharp-reference-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)   
 [How To: Execute a Group Query and Enumerate Group Items](../VS_csharp/how-to--create-a-nested-group--csharp-programming-guide-.md)   
 [How To: Group Results in Various Ways (LINQ)](../VS_csharp/how-to--group-query-results--csharp-programming-guide-.md)   
 [How to: Perform a Subquery on a Grouping Operation (C# Programming Guide)](../VS_csharp/how-to--perform-a-subquery-on-a-grouping-operation--csharp-programming-guide-.md)