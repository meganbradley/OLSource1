---
title: "How to: Group Query Results (C# Programming Guide)"
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
  - "group clause examples [LINQ in C#]"
  - "groups [LINQ in C#]"
  - "queries [LINQ in C#], grouping"
  - "query expressions [LINQ in C#], grouping"
ms.assetid: ee981053-3392-4245-a8c2-b3730211da0d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Group Query Results (C# Programming Guide)
Grouping is one of the most powerful capabilities of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)]. The following examples show how to group data in various ways:  
  
-   By a single property.  
  
-   By the first letter of a string property.  
  
-   By a computed numeric range.  
  
-   By Boolean predicate or other expression.  
  
-   By a compound key.  
  
 In addition, the last two queries project their results into a new anonymous type that contains only the student's first and last name. For more information, see the [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md).  
  
## Example  
 All the examples in this topic use the following helper classes and data sources.  
  
 [!code[csProgGuideLINQ#15](../vs140/codesnippet/CSharp/how-to--group-query-results--csharp-programming-guide-_1.cs)]  
  
## Example  
 The following example shows how to group source elements by using a single property of the element as the group key. In this case the key is a `string`, the student's last name. It is also possible to use a substring for the key. The grouping operation uses the default equality comparer for the type.  
  
 Paste the following method into the `StudentClass` class. Change the calling statement in the `Main` method to `sc.GroupBySingleProperty()`.  
  
 [!code[csProgGuideLINQ#17](../vs140/codesnippet/CSharp/how-to--group-query-results--csharp-programming-guide-_2.cs)]  
  
## Example  
 The following example shows how to group source elements by using something other than a property of the object for the group key. In this example, the key is the first letter of the student's last name.  
  
 Paste the following method into the `StudentClass` class. Change the calling statement in the `Main` method to `sc.GroupBySubstring()`.  
  
 [!code[csProgGuideLINQ#18](../vs140/codesnippet/CSharp/how-to--group-query-results--csharp-programming-guide-_3.cs)]  
  
## Example  
 The following example shows how to group source elements by using a numeric range as a group key. The query then projects the results into an anonymous type that contains only the first and last name and the percentile range to which the student belongs. An anonymous type is used because it is not necessary to use the complete `Student` object to display the results. `GetPercentile` is a helper function that calculates a percentile based on the student's average score. The method returns an integer between 0 and 10.  
  
 [!code[csProgGuideLINQ#50](../vs140/codesnippet/CSharp/how-to--group-query-results--csharp-programming-guide-_4.cs)]  
  
 Paste the following method into the `StudentClass` class. Change the calling statement in the `Main` method to `sc.GroupByRange()`.  
  
 [!code[csProgGuideLINQ#19](../vs140/codesnippet/CSharp/how-to--group-query-results--csharp-programming-guide-_5.cs)]  
  
## Example  
 The following example shows how to group source elements by using a Boolean comparison expression. In this example, the Boolean expression tests whether a student's average exam score is greater than 75. As in previous examples, the results are projected into an anonymous type because the complete source element is not needed. Note that the properties in the anonymous type become properties on the `Key` member and can be accessed by name when the query is executed.  
  
 Paste the following method into the `StudentClass` class. Change the calling statement in the `Main` method to `sc.GroupByBoolean()`.  
  
 [!code[csProgGuideLINQ#20](../vs140/codesnippet/CSharp/how-to--group-query-results--csharp-programming-guide-_6.cs)]  
  
## Example  
 The following example shows how to use an anonymous type to encapsulate a key that contains multiple values. In this example, the first key value is the first letter of the student's last name. The second key value is a Boolean that specifies whether the student scored over 85 on the first exam. You can order the groups by any property in the key.  
  
 Paste the following method into the `StudentClass` class. Change the calling statement in the `Main` method to `sc.GroupByCompositeKey()`.  
  
 [!code[csProgGuideLINQ#21](../vs140/codesnippet/CSharp/how-to--group-query-results--csharp-programming-guide-_7.cs)]  
  
## Compiling the Code  
 Copy and paste each method that you want to test into the `StudentClass` class. Add a calling statement for the method to the `Main` method and press F5.  
  
 When you adapt these methods to your own application, remember that LINQ requires version 3.5 or 4 of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], and that the project must contain a reference to System.Core.dll and a using directive for System.Linq. LINQ to SQL, LINQ to XML, and LINQ to DataSet types require additional using directives and references. For more information, see [How To: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project_deleted.md).  
  
## See Also  
 <xref:System.Linq.Enumerable.GroupBy*>   
 <xref:System.Linq.IGrouping`2*>   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)   
 [How to: Perform a Subquery on a Grouping Operation (C# Programming Guide)](../vs140/how-to--perform-a-subquery-on-a-grouping-operation--csharp-programming-guide-.md)   
 [How To: Group a Group (LINQ)](../vs140/how-to--create-a-nested-group--csharp-programming-guide-.md)   
 [Grouping Data](../vs140/grouping-data.md)